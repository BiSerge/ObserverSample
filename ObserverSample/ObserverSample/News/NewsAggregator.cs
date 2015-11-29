using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.Widgets;

namespace ObserverSample.News
{
    public class NewsEventArgs
    {
        public NewsEventArgs(string tvitter, string lenta, string tv)
        {
            Tvitter = tvitter;
            Lenta = lenta;
            Tv = tv;
        }

        public string Tvitter { get; private set; }
        public string Lenta { get; private set; }
        public string Tv { get; private set; }
    }

    public delegate void NewsChangedEventHandler(object sender, NewsEventArgs e);

    public class NewsAggregator
    {
        //private static TvitterWidgets _tvitterWidgets;
        //private static LentaWidgets _lentaWidgets;
        //private static TvWidgets _tvWidgets;
        private static Random _random;

        public NewsAggregator()
        {
            //_tvitterWidgets = new TvitterWidgets();
            //_lentaWidgets = new LentaWidgets();
            //_tvWidgets = new TvWidgets();
            _random = new Random();
        }

        public event NewsChangedEventHandler NewsChanged;

        public string GetTvitterNews()
        {
            var news = new List<String>
            {
                "Новость из Tvitter номер 1",
                "Новость из Tvitter номер 2",
                "Новость из Tvitter номер 3"
            };
            return news[_random.Next(3)];
        }

        public string GetLentaNews()
        {
            var news = new List<String>
            {
                "Новость из Lenta номер 1",
                "Новость из Lenta номер 2",
                "Новость из Lenta номер 3"
            };
            return news[_random.Next(3)];
        }

        public string GetTvNews()
        {
            var news = new List<String>
            {
                "Новость из Tv номер 1",
                "Новость из Tv номер 2",
                "Новость из Tv номер 3"
            };
            return news[_random.Next(3)];
        }

        public void NewNewsAvailable()
        {
            string tvitter = GetTvitterNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            if (NewsChanged != null)
                NewsChanged(this, new NewsEventArgs(tvitter, lenta, tv));
        }
    }
}

