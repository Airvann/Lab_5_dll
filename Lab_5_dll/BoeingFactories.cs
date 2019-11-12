using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_dll
{
    public class FactoryBoeing738Info : AbstractFactoryAircraftInfo
    {
        public override properties Create_properties()
        {
            return new b738Properties();
        }
        public override image Create_image()
        {
            return new b738Images();
        }
    }
    public class FactoryBoeing777Info : AbstractFactoryAircraftInfo
    {
        public override properties Create_properties()
        {
            return new b777Properties();
        }
        public override image Create_image()
        {
            return new b777Images();
        }
    }
    public class FactoryBoeing789Info : AbstractFactoryAircraftInfo
    {
        public override properties Create_properties()
        {
            return new b789properties();
        }
        public override image Create_image()
        {
            return new b789Images();
        }
    }
}
