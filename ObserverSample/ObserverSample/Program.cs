using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverSample.News;
using ObserverSample.Widgets;

namespace ObserverSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var newsAggregator = new NewsAggregator();
            var lentaWidgets = new LentaWidgets();
            var tvitterWidgets = new TvitterWidgets();
            var tvWidgets = new TvWidgets();

            newsAggregator.NewsChanged += new NewsChangedEventHandler(lentaWidgets.Update);
            newsAggregator.NewsChanged += new NewsChangedEventHandler(tvitterWidgets.Update);
            newsAggregator.NewsChanged += new NewsChangedEventHandler(tvWidgets.Update);

            newsAggregator.NewNewsAvailable();
            Console.WriteLine();
            newsAggregator.NewNewsAvailable();

            Console.ReadKey();
        }
    }
}
