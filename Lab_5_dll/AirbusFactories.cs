using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_dll
{
    public class FactoryAirbusA320Info : AbstractFactoryAircraftInfo
    {
        public override properties Create_properties()
        {
            return new a320Properties();
        }

        public override image Create_image()
        {
            return new a320Images();
        }
    }

    public class FactoryAirbusA321Info : AbstractFactoryAircraftInfo
    {
        public override properties Create_properties()
        {
            return new a321Properties();
        }
        public override image Create_image()
        {
            return new a321Images();
        }
    }
    public class FactoryAirbusA380Info : AbstractFactoryAircraftInfo
    {
        public override properties Create_properties()
        {
            return new a380Properties();
        }
        public override image Create_image()
        {
            return new a380Images();
        }
    }
}
