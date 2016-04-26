using System.Collections.Generic;

namespace ConsoleApplication5
{
    public class Statistic
    {
        public string provider
        {
            get;
            set;
        }

        public string url
        {
            get;
            set;
        }

        public string webapp_url
        {
            get;
            set;
        }

        public string iphone_url
        {
            get;
            set;
        }

        public string ipad_url
        {
            get;
            set;
        }

        public string android_url
        {
            get;
            set;
        }

        public string desktop_url
        {
            get;
            set;
        }

        public List<CustomVar> customVars
        {
            get;
            set;
        }

        public string id
        {
            get;
            set;
        }

        public int ? legacy_id
        {
            get;
            set;
        }

        public string name
        {
            get;
            set;
        }
    }
}