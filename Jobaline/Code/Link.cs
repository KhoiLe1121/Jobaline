using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jobaline.Code
{
    public class Link
    {
        [Required]
        public String Title { get; set; }

        [Required]
        public String Url { get; set; }

        public Link(String title, String url)
        {
            Title = title;
            Url = url;
        }
    }
}