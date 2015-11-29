using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverSample.Widgets
{

    public class TvWidgets
    {
        public void Update(string tvitter, string lenta, string tv)
        {
            Console.WriteLine("Tv: {0}", tv);
        }

        public void Display()
        {

        }
    }
}
