using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;

namespace ObserverSample.Widgets
{

    public class TvitterWidgets
    {
        private string _tvitter;

        public void Update(object sender, NewsEventArgs e)
        {
            _tvitter = e.Tvitter;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Tvitter: {0}", _tvitter);
        }
    }
}
