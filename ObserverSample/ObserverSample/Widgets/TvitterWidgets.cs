using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverSample.Widgets
{

    public class TvitterWidgets
    {
        public void Update(string tvitter, string lenta, string tv)
        {
            Console.WriteLine("Tvitter: {0}", tvitter);
        }

        public void Display()
        {

        }
    }
}
