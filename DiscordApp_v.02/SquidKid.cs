﻿using Discord;
using Discord.Commands;

using System;
using System.IO;
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
        string[] randOra;
        string[] randMuda;

        public SquidKid()
        {
            rand = new Random();


            DirectoryInfo hen = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\randumb"); //Random function for the hentai command
            FileInfo[] hentai = hen.GetFiles("*.jpg");
            Random randomHentai = new Random();


            DirectoryInfo fur = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\gay"); //Random function for the furry command
            FileInfo[] furry = fur.GetFiles("*.jpg");
            Random randomFurry = new Random();

            DirectoryInfo die = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\roll"); //Random function for the roll command
            FileInfo[] dice = die.GetFiles("*.png");
            Random randomDice = new Random();

            goodQuote = new string[]  //Quotes for the quote function
            {
                "I'm 15 minutes from a felony. - Parker Smith, 2017",
                "It's Sunday somewhere. - Parker Craine, 2016",
                "I wonder if this urinal will wash my pee pee. - Mohamed Aden, 2015",
                "You arn't drunk unless you shit your pants twice. - Nic Carnes, 2015",
                "I want it like the picture. - Jun Ho Lee, 2014",
                "I will go to Metacon 2016. - Brennan Schneider, 2016",
                "I'm a literal nobody. - Parker Smith, 2016",
                "FINLAND - Jim Nordberg, ALL THE FUCKING TIME",
                "Well when I was in... - Parker Smith, ALL THE FUCKING TIME"

            };

            randOra = new string[]  //random ora
            {
                "Ora!",
                "Ora, Ora, Ora!",
                "Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora!",
                "Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, OraOra, Ora, Ora, Ora!",
                "Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, OraOra, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora!",
                "ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA!",
                "https://i.imgur.com/YNAOKlC.gif"
            };

            randMuda = new string[]  //random muda
            {
                "Muda!",
                "Muda, Muda, Muda!",
                "Muda, Muda, Muda, Muda, Muda, Muda!",
                "Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda!",
                "Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda!",
                "MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA!",
                "http://i.imgur.com/1mSr2EU.gif"
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

            commands.CreateCommand("hello") //Hi
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("P-please don't message me at random like that. O///O");
                });

            commands.CreateCommand("help") //Help
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage(" hello - Say Hi \nname - Bots name \nstatus - Is the bot live  \nkiss - Kiss the bot  \nhentai - post from the hentai folder \ngayfur - Post from the gay folder  \nquote - Posts a classic quote \nora - Jotaro \nmuda - DIO \nroll - Rolls a d20 \ncalc - Simple calculator");
                });

            commands.CreateCommand("status") //Alive or not
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("Pls be nice to me while I am in development.");
                });

            commands.CreateCommand("name") //What is the bots name
               .Do(async (e) =>
               {
                   await e.Channel.SendMessage("I will go by SquidKid when I am up and running.");
               });

            commands.CreateCommand("kiss") //*kiss*
               .Do(async (e) =>
               {
                   await e.Channel.SendMessage("Kyaaaaa~");
               });

            commands.CreateCommand("think") //Posts Thinking and message
               .Do(async (e) =>
               {
                   await e.Channel.SendMessage("What the fuck are you talking about? \n🤔🤔🤔🤔🤔🤔🤔🤔");
               });

            commands.CreateCommand("hentai") //posts random hentai
                .Do(async (e) =>
                {
                    await e.Channel.SendFile(@"randumb\" + hentai[randomHentai.Next(0, hentai.Length)].Name);
                });

            commands.CreateCommand("gayfur") //posts random furry
                 .Do(async (e) =>
                 {
                     await e.Channel.SendFile(@"gay\" + furry[randomFurry.Next(0, furry.Length)].Name);
                 });

            commands.CreateCommand("roll").Parameter("sample.text", ParameterType.Multiple) //posts random d20
                 .Do(async (e) =>
                 {
                     await e.Channel.SendFile(@"roll\" + dice[randomDice.Next(0, dice.Length)].Name);
                 });

            commands.CreateCommand("calc").Parameter("operators", ParameterType.Multiple).Do(async (e) =>
            {
                string operat = e.Args[1];
                float number1 = float.Parse(e.Args[0]);
                float number2 = float.Parse(e.Args[2]);
                float solution;

                if (operat == "+")
                {
                    solution = number1 + number2;
                    await e.Channel.SendMessage(string.Format("{0}", solution));
                }
                else if (operat == "-")
                {
                    solution = number1 - number2;
                    await e.Channel.SendMessage(string.Format("{0}", solution));
                }
                else if (operat == "/")
                {
                    solution = number1 / number2;
                    await e.Channel.SendMessage(string.Format("{0}", solution));
                }
                else if (operat == "*")
                {
                    solution = number1 * number2;
                    await e.Channel.SendMessage(string.Format("{0}", solution));
                }
                else if (operat != "*" || operat != "/" || operat != "+" || operat != "-")
                {
                    await e.Channel.SendMessage("Please use a valid operator: +, -, *, /");
                }

            });


           commands.CreateCommand("website") //Information on the website
                .Do(async (e) =>
                {
                    await e.Channel.SendMessage("Information on the big up and coming Ebay for weebs can be found here.  \nhttps://github.com/ParkerWSmith/Weebsite");
                });

            commands.CreateCommand("quote")  //Quote Function
                        .Do(async (e) =>
                        {
                            int randomQuoteIndex = rand.Next(goodQuote.Length);
                            string quoteToPost = goodQuote[randomQuoteIndex];
                            await e.Channel.SendMessage(quoteToPost);
                        });

            commands.CreateCommand("ora")  //Ora Function
                        .Do(async (e) =>
                        {
                            int randomOraIndex = rand.Next(randOra.Length);
                            string oraToPost = randOra[randomOraIndex];
                            await e.Channel.SendMessage(oraToPost);
                        });

            commands.CreateCommand("muda")  //Muda Function
                        .Do(async (e) =>
                        {
                            int randomMudaIndex = rand.Next(randMuda.Length);
                            string mudaToPost = randMuda[randomMudaIndex];
                            await e.Channel.SendMessage(mudaToPost);
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
