using Discord;
using Discord.Commands;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp_v._02
{
    class SquidKid
    {
        DiscordClient discord;


        public SquidKid()
        {
            discord = new DiscordClient(x =>
            {
                x.LogLevel = LogSeverity.Info;
                x.LogHandler = Log;
            });

            discord.UsingCommands(x =>
            {
                x.PrefixChar = '~';
                x.AllowMentionPrefix = true;
            });

            var commands = discord.GetService<CommandService>();

            commands.CreateCommand("Hello")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("P-please don't message me at random like that. O///O");
                });

            commands.CreateCommand("Status")
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("Pls be nice to me while I am in development.");
                });

            commands.CreateCommand("Name")
               .Do(async (e) =>
               {
                   await e.Channel.SendMessage("I will go by SquidKid when I am up and running.");
               });

            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect("MzI5NzMwOTI0NTM3MzE1MzI5.DDfGWg.tqJUDn27CADP9err_zXZq81KJlI", TokenType.Bot);
            });
        }

        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
