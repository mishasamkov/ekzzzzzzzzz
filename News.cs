using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{ 
    public class News
    {
        public string Src { get; set; }
        public string Img {  get; set; }
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        
        public News(string src,string img, DateTime date,string title,string text )
        { 
            this.Img = img;
            this.Date = date;
            this.Title = title;
            this.Text = text;
            this.Src = src;
        }

        //news-card //news-card_img-small  //news-card_date    //news-card_title  //news-card_text

    }
}
