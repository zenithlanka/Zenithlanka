using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ZenithLanka.Sitemap
{
    public class SitemapItem
    {
        public DateTime? DateAdded { get; set; }
        public string URL { get; set; }
        public string Priority { get; set; }
    }

}