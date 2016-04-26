using System.Collections.Generic;

namespace ConsoleApplication5
{
    public class ArticleElement
    {
        public string id
        {
            get;
            set;
        }

        public string boxtype
        {
            get;
            set;
        }

        public string title
        {
            get;
            set;
        }

        public string caption
        {
            get;
            set;
        }

        public string refresh
        {
            get;
            set;
        }

        public string cache
        {
            get;
            set;
        }

        public List<object> tags
        {
            get;
            set;
        }
    }
}