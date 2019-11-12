using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_dll
{
    public abstract class properties
    {
        public abstract string Create_properties();
    }
    class b789properties : properties
    {
        public override string Create_properties()
        {
            return @"Boeing 787-900 Dreamliner (B789):
Первый полет: 15 декабря 2009 года
Единиц произведено: 894
Количество пассажиров: 290
Длина: 63м
Размах крыла: 60,17м
Дальность полета: 14140 км";
        }
    }
    class b777Properties : properties
    {
        public override string Create_properties()
        {
            return @"Boeing 777 (B777):
Первый полет: 12 июня 1994 года
Единиц произведено: 1616
Количество пассажиров: 301
Длина: 63,7м
Размах крыла: 64,8м
Дальность полета: 17500 км";
        }
    }
    public class b738Properties : properties
    {
        public override string Create_properties()
        {
            return @"Boeing 737-800 (B738):
Первый полет: 7 февраля 1997 года
Единиц произведено: 2135
Количество пассажиров: 160
Длина: 39,5м
Размах крыла: 35,7м
Дальность полета: 5665 км";
        }
    }
    class a320Properties : properties
    {
        public override string Create_properties()
        {
            return @"Airbus A320 (A320):
Первый полет: 22 февраля 1987 года
Единиц произведено: 9117
Количество пассажиров: 180
Длина: 37,57м
Размах крыла: 34,1м
Дальность полета: 6150 км";
        }
    }
    class a380Properties : properties
    {
        public override string Create_properties()
        {
            return @"Airbus A380 (A380):
Первый полет: 27 апреля 2005 года
Единиц произведено: 239
Количество пассажиров: 525
Длина: 73м
Размах крыла: 79,75м
Дальность полета: 15200 км";
        }
    }
    public class a321Properties : properties
    {
        public override string Create_properties()
        {
            return @"Airbus A321 (A321):
Первый полет: 22 февраля 1987 года
Единиц произведено: 9117
Количество пассажиров: 220
Длина: 44,51м
Размах крыла: 34,1м
Дальность полета: 5950 км";
        }
    }
}
