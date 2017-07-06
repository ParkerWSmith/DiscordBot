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
        CommandService commands;

        Random rand;

        string[] henReader;

        public SquidKid()
        {
            rand = new Random();

            henReader = new string[]
            {
                "randumb/hr2.jpg",
                "randumb/hr3.jpg",
                "randumb/hr4.png",
                "randumb/hr5.png",
                "randumb/hr6.jpg",
                "randumb/hr7.jpg",
                "randumb/hr8.jpg",
                "randumb/hr9.jpg",
                "randumb/hr10.jpg",
                "randumb/hr11.jpg",
                "randumb/hr12.jpg",
                "randumb/hr13.jpg",
                "randumb/hr14.jpg"
            };

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


            commands = discord.GetService<CommandService>();

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

            commands.CreateCommand("kiss")
               .Do(async (e) =>
               {
                   await e.Channel.SendMessage("Kyaaaaa~");
               });
         
            commands.CreateCommand("hr")
                        .Do(async (e) =>
                        {
                            int randomHrIndex = rand.Next(henReader.Length);
                            string hrToPost = henReader[randomHrIndex];
                            await e.Channel.SendFile(hrToPost);
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
