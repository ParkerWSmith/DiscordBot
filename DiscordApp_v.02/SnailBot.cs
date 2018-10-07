using Discord;
using Discord.Commands;

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;

namespace SnailBot
{
    public class SnailBot : ModuleBase
    {

        Random rand = new Random();

        string[] randMgs = new string[] // MSG Music
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

        string[] randWest = new string[] //Kanye command music
        {
                "Niggaz money is homo, it's hard to get straight. \n https://www.youtube.com/watch?v=xKqVhcp51qM",
                "If my manager insults me again I will be assaulting him. \n https://www.youtube.com/watch?v=ZCvTk1iA2RI",
                "The way Kathie Lee needed Regis that's the way I need Jesus. \n https://www.youtube.com/watch?v=bGlfcbwoj40",
                "It's a party tonight and ooh she's so excited, tell me who's invited: you, your friends and my dick. \n https://www.youtube.com/watch?v=fOZwGGiOJlk",
                "Mayonnaise-colored Benz, I push Miracle Whips \n https://www.youtube.com/watch?v=gt0a4A45edg",
                "And yer ass barely passed any and every class, looking at every ass, cheated on every test \n https://www.youtube.com/watch?v=QfUuKPceYVo",
                "Heard they'd do anything for a Klondike well, I'd do anything for a blonde dyke \n https://www.youtube.com/watch?v=CKkafaZL4IQ",
                "Ye, keep making that, keep making that, Keep making that platinum and gold for me! \n https://www.youtube.com/watch?v=FvSCUjFWkb0",
                "Cause when she leave yo ass she gone leave with half \n https://www.youtube.com/watch?v=RogC-7p_F5Y",
                "The plan was to drink until the pain over but what's worse, the pain or the hangover? \n https://www.youtube.com/watch?v=lUSJ_MeX4Io",
                "I don’t need your pussy, bitch, I’m on my own dick. \n https://www.youtube.com/watch?v=nfef5WqC85A",
                "The plan was to drink until the pain over but what's worse, the pain or the hangover? /n https://www.youtube.com/watch?v=lUSJ_MeX4Io",
                "Have you ever had sex with a pharaoh? Put the pussy in a sarcophagus! \n https://www.youtube.com/watch?v=yctBp6n8ROo",
                "Baby, I got a plan, run away fast as you can. \n https://www.youtube.com/watch?v=TyPz81Jcb10",
                "You left your fridge open, somebody just took a sandwich. \n https://www.youtube.com/watch?v=fZlpqRpXBLg",

        };

        string[] randChill = new string[] //random coffee pour
        {
                "Yo, chill the fuck out. \n https://www.youtube.com/watch?v=2L9vFNMvIBE",
                "Yo, chill the fuck out. \n https://www.youtube.com/watch?v=hX3j0sQ7ot8",
                "Yo, chill the fuck out. \n https://www.youtube.com/watch?v=TUEBsOQxA90",
                "Yo, chill the fuck out. \n https://www.youtube.com/watch?v=8fYiwMSqRyg",
                "Yo, chill the fuck out. \n https://www.youtube.com/watch?v=EoB_LKjizOQ",
                "Yo, chill the fuck out. \n https://www.youtube.com/watch?v=tJbVvu2AoQs",
                "Yo, chill the fuck out. \n http://rainymood.com/watch?v=7bW75OwVXZI",
        };

        string[] goodQuote = new string[]  //Quotes for the quote function
        {
                "I'm 15 minutes from a felony. - Parker Smith, 2017",
                "It's Sunday somewhere. - Parker Craine, 2016",
                "I wonder if this urinal will wash my pee pee. - Mohamed Aden, 2015",
                "You arn't drunk unless you shit your pants twice. - Nic Carnes, 2015",
                "I want it like the picture. - Jun Ho Lee, 2014",
                "I will go to Metacon 2016. - Brennan Schneider, 2016",
                "I'm a literal nobody. - Parker Smith, 2016",
                "FINLAND - Jim Nordberg, ALL THE FUCKING TIME",
                "Well when I was in... - Parker Smith, ALL THE FUCKING TIME",
                "When you understand why, then you'll know. - Parker Smith, 2017",
                "I like to live vicariously through my own photos. - Mohamed Aden, 2017",
                "One is a fetish and one is gay. - Mohamed Aden, 2017",
                //"I will get high for $30. - James V. Nordberg, 2017",
                "Don't let it happen again. - Parker Craine, 2017",
                "Do whatever it takes to get the food into your mouth - Bao Nguyen, 2016"

        };

        string[] spongeQuote = new string[] // Spongebob Quotes
        {
                "Life's as extreme as you want to make it!",
                "Well, it may be stupid, but it’s also dumb.",
                "Well, it’s no secret that the best thing about a secret is secretly telling someone your secret, thereby adding another secret to their secret collection of secrets, secretly.",
                "Gary, I’m absorbing his blows like I’m made of some sort of spongy material",
                "Meatball meatball spaghetti underneath, ravioli ravioli great barrier reef",
                "It’s not just any boulder……..it’s a ROCK!",
                "The inner machinations of my mind are an enigma.",
                "You can’t fool me. I listen to public radio!",
                "It’s a vast swirling wonderland of sparkling white pleasure. Let it fill your senses with cascading fluffy pillows of excitement, and comfort, as you’ve never felt before.",
                "If I were to die right now in a fiery explosion due to carelessness of a friend…. Then it would just be alright.",
                "You had to kill him. The boy cries you a sweater of tears... and you kill him. How are you going to live with yourself?",
                "I'll take a Double Triple Bossy Deluxe on a raft, 4x4 animal style, extra shingles with a shimmy and a squeeze, light axle grease; make it cry, burn it, and let it swim.",
                "Oh my god! A floating shopping list! Ahhh!",
                "Sandy: “Don’t you have to be stupid somewhere else?”\nPatrick: “Not until 4”",
                "Seaweed: 50% sea, 50% weed.",
                "Now you must develop a taste for free-form jazz.",
                "Squidward, your ceiling is talking to me.",
                "Put those eyeballs back in your head, son!",
                "Maybe a story will cheer you up. (picks up SpongeBob and seats him) It’s called “The Ugly Barnacle”. Once there was an ugly Barnacle. He was so ugly that everyone died. The End.",
                "Either you (a) put the dime in me pants, (b) put the dime in me pants, or (c) put the dime in me pants!",
                "Patrick! You forgot how to eat again! Come on, we’ll get the funnel",
                "Squidward… I used your clarinet to unclog my toilet!",
                "I’m ugly and I’m proud! I’m ugly and I’m proud!! I’m ugly and I’m proud!"
        };


        string[] randOra = new string[]  //random ora
            {
                "Ora!",
                "Ora, Ora, Ora!",
                "Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora!",
                "Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, OraOra, Ora, Ora, Ora!",
                "Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, OraOra, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora, Ora!",
                "ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA, ORA!",
                "https://i.imgur.com/YNAOKlC.gif"
            };

        string[] randMuda = new string[]  //random muda
         {
                "Muda!",
                "Muda, Muda, Muda!",
                "Muda, Muda, Muda, Muda, Muda, Muda!",
                "Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda!",
                "Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda, Muda!",
                "MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA, MUDA!",
                "http://i.imgur.com/1mSr2EU.gif"
         };


        //Here begins the commands

        [Command("hello")]
        [Summary("hows it going")]
        [Alias("hi")]
        public async Task hello()
        {
            await ReplyAsync("P-please don't message me at random like that. O///O " + Context.Message.Author.Mention);
        }

        [Command("help")]
        [Summary("list of commands")]
        [Alias("h")]
        public async Task help()
        {
            await ReplyAsync(" hello - Say Hi \nname - Bots name \nabout - Bot info  \nkiss - Kiss the bot  \nhentai - post from the hentai folder \nquote - Posts a classic quote \nora - Jotaro \nmuda - DIO \nroll - Rolls a d20 \ncalc - Simple calculator \nmgs - Random Song from Metal Gear Solid \nchill - Chill out \nstand - stand v stand battle \nstage - stage for the stand command \nOT - OppaiTime Invites \nbestgirl - Best girl \nbestgirlold - Older version of best girl \njello - bouncing jello \ndaki - Dakimakura Resource \nptg - Private Tracker General \nsosad - That's so sad \nqtloli - Cute Little Girls \ntravel - Travel Doc Outline \nahitsthenewnow - Kanye Command \nlife - in the end it doesn't even matter \nplex - Server run out of Chronos' basement \nsbquote - Random Spongebob Quote \nhappynewyear - Have a great year \nhitdabricks - You can leave \nroll - rolls a d20 \nstats - Gives some DnD stats");
        }

        [Command("about")]
        [Summary("About the bot")]
        public async Task about()
        {
            await ReplyAsync("Hi, I'm Snail! Most of my functions are useless but some of them are fun. \nCode can be found here (https://github.com/ParkerWSmith/DiscordBot) \nIf you want to add me to your server you can by following this link, \nhttps://discordapp.com/oauth2/authorize?&client_id=357006708016676867&scope=bot&permissions=0 \n\nNadeko a shit. A. SHIT.");
        }

        [Command("name")]
        [Summary("What is the bots name?")]
        [Alias("who")]
        public async Task name()
        {
            await ReplyAsync("Hello, I am SnailBot How's it going?.");
        }

        [Command("no")]
        [Summary("Says no")]
        [Alias("nope")]
        public async Task no()
        {
            await ReplyAsync("No.");
        }

        [Command("kiss")]
        [Summary("Kiss the bot")]
        [Alias("Chuu")]
        public async Task kiss()
        {
            await ReplyAsync("Kyaaaaa~");
        }

        [Command("think")]
        [Summary("??")]
        public async Task think()
        {
            await ReplyAsync("What are you talking about??? \n🤔🤔🤔🤔🤔🤔🤔🤔");
        }

        [Command("3dpd")]
        [Summary("Live porn search")]
        public async Task porn()
        {
            await ReplyAsync("Porn live search via pornmd.  \nhttps://www.pornmd.com/live-search");
        }

        [Command("Daki")]
        [Summary("Dakimakura resource")]
        public async Task daki()
        {
            await ReplyAsync("https://chan.sankakucomplex.com/?tags=Dakimakura&commit=Search");
        }

        [Command("OT")]
        [Summary("Oppaitime inites")]
        [Alias("oppaitime")]
        public async Task OT()
        {
            await ReplyAsync("Ask Bao for an invite.");
        }

        [Command("plex")]
        [Summary("Plex server invite")]
        public async Task plex()
        {
            await ReplyAsync("The Plex server is invite only. Ask Bao.");
        }

        [Command("ptg")]
        [Summary("Private Tracker General")]
        public async Task ptg()
        {
            await ReplyAsync("lol just use piratebay bitchboi");
        }

        [Command("happynewyear")]
        [Summary("Happy new year")]
        public async Task newyear()
        {
            //>Current Year
            //>Better
            int currentYear = DateTime.Now.Year;
            int nextYear = currentYear + 1;
            await ReplyAsync(nextYear + " Will be Better");
        }

        [Command("travel")]
        [Summary("travel outline")]
        public async Task travel()
        {
            await ReplyAsync("Misguided Travelers is for planning out trips that you will never go on with your friends! \nRemember to use Google docs for all fleshed out plans.\nOutline here:\nhttps://docs.google.com/document/d/1ofW4vZR99JbLeAq6DD9ye4OGQ598tph3Wp2zC0o0tHg/edit?usp=sharing");
        }

        [Command("sosad")]
        [Summary("It's my life")]
        [Alias("sad")]
        public async Task sosad()
        {
            await ReplyAsync("https://www.youtube.com/watch?v=utddDvJ1Rvo");
        }

        [Command("ora")]
        [Summary("ORA")]
        [Alias("ORA")]
        public async Task Ora()
        {
            int randomOraIndex = rand.Next(randOra.Length);
            string oraToPost = randOra[randomOraIndex];
            await ReplyAsync(oraToPost);
        }

        [Command("muda")]
        [Summary("MUDA")]
        [Alias("MUDA")]
        public async Task Muda()
        {
            int randomMudaIndex = rand.Next(randMuda.Length);
            string mudaToPost = randMuda[randomMudaIndex];
            await ReplyAsync(mudaToPost);
        }

        [Command("kanye")]
        [Summary("")]
        [Alias("yee")]
        public async Task Kanye()
        {
            int randomKanyeIndex = rand.Next(randWest.Length);
            string kanyeToPost = randWest[randomKanyeIndex];
            await ReplyAsync(kanyeToPost);
        }

        [Command("chill")]
        [Summary("calm down")]
        [Alias("shh")]
        public async Task chill()
        {
            int randomChillIndex = rand.Next(randChill.Length);
            string chillToPost = randChill[randomChillIndex];
            await ReplyAsync(chillToPost);
        }

        [Command("quote")]
        [Summary("Random quote")]
        [Alias("stupidshitwesay")]
        public async Task quote()
        {
            int randomQuoteIndex = rand.Next(goodQuote.Length);
            string quoteToPost = goodQuote[randomQuoteIndex];
            await ReplyAsync(quoteToPost);
        }

        [Command("sbquote")]
        [Summary("Spongbob Quote")]
        [Alias("sb")]
        public async Task sbquote()
        {
            int randomSpongeIndex = rand.Next(spongeQuote.Length);
            string sbToPost = spongeQuote[randomSpongeIndex];
            await ReplyAsync(sbToPost);
        }

        [Command("mgs")]
        [Summary("Random MGS song")]
        [Alias("Standing")]
        public async Task mgs()
        {
            int randomMgsIndex = rand.Next(randMgs.Length);
            string mgsToPost = randMgs[randomMgsIndex];
            await ReplyAsync(mgsToPost);
        }

        [Command("roll")]
        [Summary("Rolls a random d20")]
        public async Task roll([Remainder, Summary("The text to echo")] string echo)
        {
            DirectoryInfo die = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\roll"); //Random function for the roll command
            FileInfo[] dice = die.GetFiles("*.png");
            Random randomDice = new Random();
            await Context.Channel.SendFileAsync(@"roll\" + dice[randomDice.Next(0, dice.Length)].Name);
        }

        [Command("stand")]
        [Summary("Stand Battle")]
        public async Task stand()
        {
            DirectoryInfo stand = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\stand"); //Random function for the stand command
            FileInfo[] user = stand.GetFiles("*.*");
            Random randomUser = new Random();
            await Context.Channel.SendFileAsync(@"stand\" + user[randomUser.Next(0, user.Length)].Name);
            Context.Channel.SendFileAsync("extras/vs.png");
            Context.Channel.SendFileAsync(@"stand\" + user[randomUser.Next(0, user.Length)].Name);
        }

        [Command("pokemon")]
        [Summary("pokemon battle")]
        public async Task pokemon()
        {
            DirectoryInfo poke = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\pokemon"); //Random function for the pokemon command
            FileInfo[] ball = poke.GetFiles("*.*");
            Random randomPoke = new Random();
            await Context.Channel.SendFileAsync(@"pokemon\" + ball[randomPoke.Next(0, ball.Length)].Name);
            Context.Channel.SendFileAsync("extras/vs.png");
            Context.Channel.SendFileAsync(@"pokemon\" + ball[randomPoke.Next(0, ball.Length)].Name);
        }

        [Command("stage")]
        [Summary("Jojo stage")]
        public async Task stage()
        {
            DirectoryInfo local = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\stage"); //Random function for the stage command
            FileInfo[] stage = local.GetFiles("*.*");
            Random randomStage = new Random();
            await Context.Channel.SendFileAsync(@"stage\" + stage[randomStage.Next(0, stage.Length)].Name);
        }

        [Command("jello")]
        [Summary("Bounce")]
        public async Task jello()
        {
            await Context.Channel.SendFileAsync("extras/jello.gif");
        }

        [Command("bestgirl")]
        [Summary("best girl")]
        public async Task bestgirl()
        {
            await Context.Channel.SendFileAsync("extras/bestgirl.jpg");
        }

        [Command("bestgirlold")]
        [Summary("best girl old")]
        public async Task bestgirlold()
        {
            await Context.Channel.SendFileAsync("extras/bestgirlold.jpg");
        }

        [Command("life")]
        [Summary("coming to bed dear")]
        public async Task life()
        {
            await Context.Channel.SendFileAsync("extras/life.gif");
        }

        [Command("qtloli")]
        [Summary("Hang tight")]
        public async Task qtloli()
        {
            await ReplyAsync("Hang tight, the feds are on the way fucko.");
            Context.Channel.SendFileAsync("extras/bestgirl.jpg");
        }

        [Command("hentai")]
        [Summary("random lewd image")]
        public async Task hentai()
        {
            DirectoryInfo hen = new DirectoryInfo(Directory.GetCurrentDirectory() + @"\randumb"); //Random function for the hentai command
            FileInfo[] hentai = hen.GetFiles("*.*");
            Random randomHentai = new Random();
            await Context.Channel.SendFileAsync(@"randumb\" + hentai[randomHentai.Next(0, hentai.Length)].Name);
        }

        [Command("stats")]
        [Summary("Give the user stats")]
        public async Task stats()
        {
            Random rnd = new Random();
            await ReplyAsync(Context.Message.Author.Mention + ", here are your stats for the day. \nStrength: " + rnd.Next(3, 19) + "\nDexterity: " + rnd.Next(3, 19) + "\nConstitution: " + rnd.Next(3, 19) + "\nIntelligence: " + rnd.Next(3, 19) + "\nWisdom: " + rnd.Next(3, 19) + "\nCharisma: " + rnd.Next(3, 19));
        }

        [Command("worstgirl")]
        [Summary("worst girl")]
        public async Task worstgirl()
        {
            await Context.Channel.SendFileAsync("extras/worst.JPG");
        }

        [Command("Define")]
        [Summary("Defines a hentai term")]
        public async Task define()
        {

        }
    }
};