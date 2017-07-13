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

        string[] goodQuote;
        string[] hardCore;
        string[] gayFur;

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
                "randumb/new_(21).jpeg",
                "randumb/new_(21).jpg",
                "randumb/new_(21).png",
                "randumb/new_(22).jpeg",
                "randumb/new_(22).jpg",
                "randumb/new_(22).png",
                "randumb/new_(23).jpeg",
                "randumb/new_(23).jpg",
                "randumb/new_(23).png",
                "randumb/new_(24).jpeg",
                "randumb/new_(24).jpg",
                "randumb/new_(24).png",
                "randumb/new_(25).jpeg",
                "randumb/new_(25).jpg",
                "randumb/new_(25).png",
                "randumb/new_(26).jpeg",
                "randumb/new_(26).jpg",
                "randumb/new_(26).png",
                "randumb/new_(27).jpeg",
                "randumb/new_(27).jpg",
                "randumb/new_(27).png",
                "randumb/new_(28).jpeg",
                "randumb/new_(28).jpg",
                "randumb/new_(28).png",
                "randumb/new_(29).jpeg",
                "randumb/new_(29).jpg",
                "randumb/new_(29).png",
                "randumb/new_(30).jpeg",
                "randumb/new_(30).jpg",
                "randumb/new_(30).png",
                "randumb/new_(31).jpeg",
                "randumb/new_(31).jpg",
                "randumb/new_(31).png",
                "randumb/new_(32).jpeg",
                "randumb/new_(32).jpg",
                "randumb/new_(32).png",
                "randumb/new_(33).jpeg",
                "randumb/new_(33).jpg",
                "randumb/new_(33).png",
                "randumb/new_(34).jpeg",
                "randumb/new_(34).jpg",
                "randumb/new_(34).png",
                "randumb/new_(35).jpeg",
                "randumb/new_(35).jpg",
                "randumb/new_(35).png",
                "randumb/new_(36).jpeg",
                "randumb/new_(36).jpg",
                "randumb/new_(36).png",
                "randumb/new_(37).jpeg",
                "randumb/new_(37).jpg",
                "randumb/new_(37).png",
                "randumb/new_(38).jpeg",
                "randumb/new_(38).jpg",
                "randumb/new_(38).png",
                "randumb/new_(39).jpeg",
                "randumb/new_(39).jpg",
                "randumb/new_(39).png",
                "randumb/new_(40).jpeg",
                "randumb/new_(40).jpg",
                "randumb/new_(40).png",
                "randumb/new_(41).jpeg",
                "randumb/new_(41).jpg",
                "randumb/new_(42).jpeg",
                "randumb/new_(42).jpg",
                "randumb/new_(42).png",
                "randumb/new_(43).jpeg",
                "randumb/new_(43).jpg",
                "randumb/new_(43).png",
                "randumb/new_(44).jpeg",
                "randumb/new_(44).png",
                "randumb/new_(45).jpeg",
                "randumb/new_(45).jpg",
                "randumb/new_(45).png",
                "randumb/new_(46).jpeg",
                "randumb/new_(46).jpg",
                "randumb/new_(46).png",
                "randumb/new_(47).jpeg",
                "randumb/new_(47).jpg",
                "randumb/new_(47).png",
                "randumb/new_(48).jpeg",
                "randumb/new_(48).jpg",
                "randumb/new_(48).png",
                "randumb/new_(49).jpeg",
                "randumb/new_(49).jpg",
                "randumb/new_(49).png",
                "randumb/new_(50).jpeg",
                "randumb/new_(50).jpg",
                "randumb/new_(50).png"

            };

            gayFur = new string[]  //Images for the Hentai function
            {
                "gay/gay(1).jpeg",
                "gay/gay(1).jpg",
                "gay/gay(1).png",
                "gay/gay(2).jpeg",
                "gay/gay(2).jpg",
                "gay/gay(2).png",
                "gay/gay(3).jpeg",
                "gay/gay(3).jpg",
                "gay/gay(3).png",
                "gay/gay(2).jpeg",
                "gay/gay(2).jpg",
                "gay/gay(2).png",
                "gay/gay(4).jpeg",
                "gay/gay(4).jpg",
                "gay/gay(5).jpeg",
                "gay/gay(5).jpg",
                "gay/gay(6).jpeg",
                "gay/gay(6).jpg",
                "gay/gay(7).jpeg",
                "gay/gay(7).jpg",
                "gay/gay(8).jpeg",
                "gay/gay(8).jpg",
                "gay/gay(9).jpeg",
                "gay/gay(9).jpg",
                "gay/gay(10).jpeg",
                "gay/gay(10).jpg",
                "gay/gay(11).jpeg",
                "gay/gay(11).jpg",
                "gay/gay(12).jpeg",
                "gay/gay(12).jpg",
                "gay/gay(13).jpeg",
                "gay/gay(13).jpg",
                "gay/gay(14).jpeg",
                "gay/gay(14).jpg",
                "gay/gay(15).jpeg",
                "gay/gay(15).jpg",
                "gay/gay(16).jpeg",
                "gay/gay(16).jpg",
                "gay/gay(17).jpeg",
                "gay/gay(17).jpg",
                "gay/gay(18).jpeg",
                "gay/gay(18).jpg",
                "gay/gay(19).jpeg",
                "gay/gay(19).jpg",
                "gay/gay(20).jpeg",
                "gay/gay(20).jpg",
                "gay/gay(21).jpeg",
                "gay/gay(21).jpg",
                "gay/gay(22).jpg",
                "gay/gay(23).jpg",
                "gay/gay(24).jpg",
                "gay/gay(25).jpg",
                "gay/gay(26).jpg",
                "gay/gay(27).jpg",
                "gay/gay(28).jpg",
                "gay/gay(29).jpg",
                "gay/gay(30).jpg",
                "gay/gay(31).jpg",
                "gay/gay(32).jpg",
                "gay/gay(33).jpg",
                "gay/gay(34).jpg",
                "gay/gay(35).jpg",
                "gay/gay(36).jpg",
                "gay/gay(37).jpg",
                "gay/gay(38).jpg",
                "gay/gay(39).jpg",
                "gay/gay(40).jpg"

            };

            goodQuote = new string[]  //Quotes for the quote function
            {
                "I'm 15 minutes from a felony. - Parker Smith, 2017",
                "It's Sunday somewhere. - Parker Craine, 2016",
                "I wonder if this urinal will wash my pee pee. - Mohamed Aden, 2015",
                "You arn't drunk unless you shit your pants twice. - Nic Carnes, 2015",
                "I want it like the picture. - Jun Ho Lee, 2014",
                "I will go to Metacon 2016 - Brennan Schneider, 2016",
                "I'm a literal nobody - Parker Smith, 2016",
                "FINLAND - Jim Nordberg, ALL THE FUCKING TIME",
                "Well when I was in... - Parker Smith, ALL THE FUCKING TIME"

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

            commands.CreateCommand("help") //Help
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage(" Hello - Say Hi \nName - Bots name \nStatus - Is the bot live  \nkiss - Kiss the bot  \nhentai - post from the hentai folder \ngayfur - Post from the gay folder  \nquote - Posts a classic quote ");
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

            commands.CreateCommand("gayfur")  //Gay Furry Function
                       .Do(async (e) =>
                       {
                           int randomFurIndex = rand.Next(gayFur.Length);
                           string furToPost = gayFur[randomFurIndex];
                           await e.Channel.SendFile(furToPost);
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
