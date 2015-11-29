using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverSample.Widgets
{

    public class LentaWidgets
    {
        public void Update(string tvitter, string lenta, string tv)
        {
            Console.WriteLine("Lenta: {0}", lenta);
        }

        public void Display()
        {

        }
    }
}
