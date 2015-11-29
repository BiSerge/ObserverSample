using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ObserverSample.News;

namespace ObserverSample.Widgets
{

    public class LentaWidgets
    {
        private string _lenta;

        public void Update(object sender, NewsEventArgs e)
        {
            _lenta = e.Lenta;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Lenta: {0}", _lenta);
        }
    }
}
