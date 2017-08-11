using Discord;
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
        string[] randMgs;
        string[] randChill;

        public SquidKid()
        {
            rand = new Random();


            DirectoryInfo hen = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\randumb"); //Random function for the hentai command
            FileInfo[] hentai = hen.GetFiles("*.*");
            Random randomHentai = new Random();


            DirectoryInfo fur = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\gay"); //Random function for the furry command
            FileInfo[] furry = fur.GetFiles("*.*");
            Random randomFurry = new Random();

            DirectoryInfo die = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\roll"); //Random function for the roll command
            FileInfo[] dice = die.GetFiles("*.png");
            Random randomDice = new Random();

            DirectoryInfo stand = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\stand"); //Random function for the stand command
            FileInfo[] user = stand.GetFiles("*.*");
            Random randomUser = new Random();

            DirectoryInfo local = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\stage"); //Random function for the stand command
            FileInfo[] stage = local.GetFiles("*.*");
            Random randomStage = new Random();

            DirectoryInfo poke = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\pokemon"); //Random function for the stand command
            FileInfo[] ball = poke.GetFiles("*.*");
            Random randomPoke = new Random();

            randMgs = new string[] // MSG Music
            {
                "https://www.youtube.com/watch?v=F9hagVL-__c",
                "https://www.youtube.com/watch?v=hULJu2mcU6s",
                "https://www.youtube.com/watch?v=VQzgI6xJEH0",
                "https://www.youtube.com/watch?v=PXkgn3QUA2w",
                "https://www.youtube.com/watch?v=lGf2b1H91JA",
                "https://www.youtube.com/watch?v=3lwUS0GlNIA",
                "https://www.youtube.com/watch?v=RrkzIN2eP0U",
                "https://www.youtube.com/watch?v=ZYAPgPH9hsI",
                "https://www.youtube.com/watch?v=XI1VpElKWF8",
                "https://www.youtube.com/watch?v=QiPon8lr48U",
            };

            randChill = new string[] //random coffee pour
            {
                "Yo, chill the fuck out. \n https://www.youtube.com/watch?v=2L9vFNMvIBE",
                "Yo, chill the fuck out. \n https://www.youtube.com/watch?v=hX3j0sQ7ot8",
                "Yo, chill the fuck out. \n https://www.youtube.com/watch?v=TUEBsOQxA90",
                "Yo, chill the fuck out. \n https://www.youtube.com/watch?v=8fYiwMSqRyg",
                "Yo, chill the fuck out. \n https://www.youtube.com/watch?v=EoB_LKjizOQ",
                "Yo, chill the fuck out. \n https://www.youtube.com/watch?v=tJbVvu2AoQs",
                "Yo, chill the fuck out. \n http://rainymood.com/watch?v=7bW75OwVXZI",
            };

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
                    await e.Channel.SendMessage(" hello - Say Hi \nname - Bots name \nstatus - Is the bot live  \nkiss - Kiss the bot  \nhentai - post from the hentai folder \ngayfur - Post from the gay folder  \nquote - Posts a classic quote \nora - Jotaro \nmuda - DIO \nroll - Rolls a d20 \ncalc - Simple calculator \nmgs - Random Song from Metal Gear Solid \nchill - Chill out \nstand - stand v stand battle \nstage - stage for the stand command");
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

            commands.CreateCommand("stand") //posts random stand
                 .Do(async (e) =>
                 {
                     await e.Channel.SendFile(@"stand\" + user[randomUser.Next(0, user.Length)].Name);
                     e.Channel.SendFile("extras/vs.jpg");
                     e.Channel.SendFile(@"stand\" + user[randomUser.Next(0, user.Length)].Name);
                 });

            commands.CreateCommand("pokemon") //posts random stand
                 .Do(async (e) =>
                 {
                     await e.Channel.SendFile(@"pokemon\" + ball[randomUser.Next(0, ball.Length)].Name);
                     e.Channel.SendFile("extras/vs.jpg");
                     e.Channel.SendFile(@"pokemon\" + ball[randomUser.Next(0, ball.Length)].Name);
                 });

            commands.CreateCommand("stage") //posts stage for jojo command
                .Do(async (e) =>
            {
                await e.Channel.SendFile(@"stage\" + stage[randomUser.Next(0, stage.Length)].Name);
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

            commands.CreateCommand("chill")  //Chillllll
                        .Do(async (e) =>
                        {
                            int randomChillIndex = rand.Next(randChill.Length);
                            string chillToPost = randChill[randomChillIndex];
                            await e.Channel.SendMessage(chillToPost);
                        });

            commands.CreateCommand("mgs")  //Metal Gear Music
                        .Do(async (e) =>
                        {
                            int randomMgsIndex = rand.Next(randMgs.Length);
                            string mgsToPost = randMgs[randomMgsIndex];
                            await e.Channel.SendMessage(mgsToPost);
                        });

            commands.CreateCommand("3dpd")  //live-search porn Function
                        .Do(async (e) =>
                        {
                            await e.Channel.SendMessage("Porn live search via pornmd.  \nhttps://www.pornmd.com/live-search");
                        });

            discord.ExecuteAndWait(async () =>
            {
                await discord.Connect("MzI5NzMwOTI0NTM3MzE1MzI5.DGGW-A.MFPA1vcn0jRNyHf8XEbShEyZlDs", TokenType.Bot);
            });

        }
        private void Log(object sender, LogMessageEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }
}