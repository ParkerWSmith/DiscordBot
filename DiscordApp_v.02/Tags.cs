using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscordApp_v._02
{
    class Tags : SquidKid
    {
        public string Tag { get; set; }
        public string Description { get; set; }
    }

    class CollInit
    {
        Dictionary<int, Tags> tag = new Dictionary<int, Tags>()
        {
            { 111, new Tags {Tag="ahegao", Description="An exaggerated facial expression indicating pleasure, usually includes rolled-up eyes, open mouth, and tongue sticking out. Often occurs during sexual climax."}}

        };
    }
}
