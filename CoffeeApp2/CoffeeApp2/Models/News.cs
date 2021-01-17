using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeApp2.Models
{
    public class News
    {
        public String Title { get; set; }
        public String Content { get; set; }
        public String BriefContent { get; set; }
        public String ImageUrl { get; set; }

        public News(String Title, String Content, String BriefContent, String ImageUrl)
        {
            this.Title = Title;
            this.Content = Content;
            this.BriefContent = BriefContent;
            this.ImageUrl = ImageUrl;
        }
    }
}
