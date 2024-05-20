using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReastEasySpotify.Database.Mongo.Model
{
    public partial class Image
    {
        public string url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }
}
