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
        string[] goodQuote;
        string[] hardCore;

        public SquidKid()
        {
            rand = new Random();

            hardCore = new string[]  //Images for the Hentai function
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
                "randumb/hr14.jpg",
                "randumb/new_(1).gif",
                "randumb/new_(1).jpeg",
                "randumb/new_(1).jpg",
                "randumb/new_(1).png",
                "randumb/new_(2).gif",
                "randumb/new_(2).jpeg",
                "randumb/new_(2).jpg",
                "randumb/new_(2).png",
                "randumb/new_(3).gif",
                "randumb/new_(3).jpeg",
                "randumb/new_(3).jpg",
                "randumb/new_(3).png",
                "randumb/new_(4).jpeg",
                "randumb/new_(4).jpg",
                "randumb/new_(4).png",
                "randumb/new_(5).jpeg",
                "randumb/new_(5).jpg",
                "randumb/new_(5).png",
                "randumb/new_(6).jpeg",
                "randumb/new_(6).jpg",
                "randumb/new_(6).png",
                "randumb/new_(7).jpeg",
                "randumb/new_(7).jpg",
                "randumb/new_(7).png",
                "randumb/new_(8).jpeg",
                "randumb/new_(8).jpg",
                "randumb/new_(8).png",
                "randumb/new_(9).jpeg",
                "randumb/new_(9).jpg",
                "randumb/new_(9).png",
                "randumb/new_(10).jpeg",
                "randumb/new_(10).jpg",
                "randumb/new_(10).png",
                "randumb/new_(11).jpeg",
                "randumb/new_(11).jpg",
                "randumb/new_(11).png",
                "randumb/new_(12).jpeg",
                "randumb/new_(12).jpg",
                "randumb/new_(12).png",
                "randumb/new_(13).jpeg",
                "randumb/new_(13).jpg",
                "randumb/new_(13).png",
                "randumb/new_(14).jpeg",
                "randumb/new_(14).jpg",
                "randumb/new_(14).png",
                "randumb/new_(15).jpeg",
                "randumb/new_(15).jpg",
                "randumb/new_(15).png",
                "randumb/new_(16).jpeg",
                "randumb/new_(16).jpg",
                "randumb/new_(16).png",
                "randumb/new_(16).jpeg",
                "randumb/new_(17).jpg",
                "randumb/new_(17).png",
                "randumb/new_(18).jpeg",
                "randumb/new_(18).jpg",
                "randumb/new_(18).png",
                "randumb/new_(19).jpeg",
                "randumb/new_(19).jpg",
                "randumb/new_(19).png",
                "randumb/new_(20).jpeg",
                "randumb/new_(20).jpg",
                "randumb/new_(20).png",
            };

            goodQuote = new string[]  //Quotes for the quote function
            {
                "I'm 15 minutes from a felony. - Parker Smith, 2017",
                "It's Sunday somewhere. - Parker Craine, 2016",
                "I wonder if this urinal will wash my pee pee. - Mohamed Aden, 2015",
                "You arn't drunk unless you shit your pants twice. - Nic Carnes, 2015",
                "I want it like the picture. - Jun Ho Lee, 2014",
                "I will go to Metacon 2016 - Brennan Schneider, 2016"

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

            commands.CreateCommand("Hello") //Hi
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("P-please don't message me at random like that. O///O");
                });

            commands.CreateCommand("Status") //Alive or not
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("Pls be nice to me while I am in development.");
                });

            commands.CreateCommand("Name") //What is the bots name
               .Do(async (e) =>
               {
                   await e.Channel.SendMessage("I will go by SquidKid when I am up and running.");
               });

            commands.CreateCommand("kiss") //*kiss*
               .Do(async (e) =>
               {
                   await e.Channel.SendMessage("Kyaaaaa~");
               });

            commands.CreateCommand("kill_me") //Posts Emote
               .Do(async (e) =>
               {
                   await e.Channel.SendMessage(":suffering:");
               });

            commands.CreateCommand("hentai")  //Hentai Function
                       .Do(async (e) =>
                       {
                           int randomHcIndex = rand.Next(hardCore.Length);
                           string hcToPost = hardCore[randomHcIndex];
                           await e.Channel.SendFile(hcToPost);
                       });

            commands.CreateCommand("quote")  //Quote Function
                        .Do(async (e) =>
                        {
                            int randomQuoteIndex = rand.Next(goodQuote.Length);
                            string quoteToPost = goodQuote[randomQuoteIndex];
                            await e.Channel.SendMessage(quoteToPost);
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
