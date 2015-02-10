using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Jobaline.Code;
using System.ServiceModel.Syndication;
using System.Xml;
namespace Jobaline.Models
{
    public class HomeModel
    {
        public List<Link> GetLinks(String rssUrl)
        {
            List<Link> results = new List<Link>();
            XmlReader reader = XmlReader.Create(rssUrl);
            SyndicationFeed feed = SyndicationFeed.Load(reader);
            reader.Close();
            foreach (SyndicationItem item in feed.Items)
            {
                String title = item.Title.Text;
                Uri link = item.Links[0].Uri;
                results.Add(new Link(title, link.ToString()));
            }
            return results;
        }
    }
}