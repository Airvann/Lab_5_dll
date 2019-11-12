using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_dll
{
    public class Client
    {
        public properties properties;
        public image image;

        public Client(AbstractFactoryAircraftInfo factory)
        {
            properties = factory.Create_properties();
            image = factory.Create_image();
        }
    }
}
