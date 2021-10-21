using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebApp.Models
{
    public class Article
    {
        private int articleID;

        public int ArticleID
        {
            get { return this.articleID; }
            set
            {
                if (value >= 0)
                {
                    this.articleID = value;
                }
            }
        }
        public string ArticleName { get; set; }
        public string Brand { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}