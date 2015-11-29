using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.Widgets;

namespace ObserverSample.News
{
    public class NewsAggregator
    {
        private static TvitterWidgets _tvitterWidgets;
        private static LentaWidgets _lentaWidgets;
        private static TvWidgets _tvWidgets;
        private static Random _random;

        public NewsAggregator()
        {
            _tvitterWidgets = new TvitterWidgets();
            _lentaWidgets = new LentaWidgets();
            _tvWidgets = new TvWidgets();
            _random = new Random();
        }

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
                "Новость Lenta из номер 1",
                "Новость Lenta из номер 2",
                "Новость Lenta из номер 3"
            };
            return news[_random.Next(3)];
        }

        public string GetTvNews()
        {
            var news = new List<String>
            {
                "Новость Tv из номер 1",
                "Новость Tv из номер 2",
                "Новость Tv из номер 3"
            };
            return news[_random.Next(3)];
        }

        public void NewNewsAvailable()
        {
            string tvitter = GetTvitterNews();
            string lenta = GetLentaNews();
            string tv = GetTvNews();

            _tvitterWidgets.Update(tvitter, lenta, tv);
            _lentaWidgets.Update(tvitter, lenta, tv);
            _tvWidgets.Update(tvitter, lenta, tv);
        }
    }
}

