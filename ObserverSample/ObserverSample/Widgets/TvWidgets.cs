using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;

namespace ObserverSample.Widgets
{

    public class TvWidgets
    {
        private string _tv;

        public void Update(object sender, NewsEventArgs e)
        {
            _tv = e.Tv;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Tv: {0}", _tv);
        }
    }
}
