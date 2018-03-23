using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

namespace DiscordApp_v._02
{
    class Program
    {
        private CommandService commands;
        private DiscordSocketClient client;
        private IServiceProvider services;

        string token = "";

        static void Main(string[] args) => new Program().Start().GetAwaiter().GetResult();

        public async Task Start()
        {
            client = new DiscordSocketClient(new DiscordSocketConfig
            {
                WebSocketProvider = Discord.Net.Providers.WS4Net.WS4NetProvider.Instance
            });
            commands = new CommandService();
            services = new ServiceCollection().BuildServiceProvider();

            await InstallCommands();

            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();

            client.Log += Log;

            await Task.Delay(-1);
        }

        public async Task InstallCommands()
        {
            // Hook the MessageReceived Event into our Command Handler
            client.MessageReceived += HandleCommand;
            // Discover all of the commands in this assembly and load them
            await commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }

        public async Task HandleCommand(SocketMessage msgParam)
        {
            var msg = msgParam as SocketUserMessage;
            char prefix = '~';
            if (msg == null) return;

            int argPos = 0;
            if (!(msg.HasCharPrefix(prefix, ref argPos) || msg.HasMentionPrefix(client.CurrentUser, ref argPos))) return;
            // Create a Command Prompt
            var context = new CommandContext(client, msg);
            // Execute the command. (result does not indicate a return value,
            // Rather an object stating if the command executed successfully)
            var result = await commands.ExecuteAsync(context, argPos, services);
            if (!result.IsSuccess)
                await context.Channel.SendMessageAsync(result.ErrorReason);
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
    }
}