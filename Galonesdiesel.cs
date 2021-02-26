using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO2
{
    class Galonesdiesel
    {

        private double numerogalones;
        private double dineroporgalon;
        private double totalgalon;
        private double totalefectivo;
        private double galonesrestantes;


        public double Numerogalones

        {
            get { return numerogalones; }
            set => numerogalones = (value);
        }


        public double Dineroporgalon
        {
            get { return dineroporgalon; }
            set { dineroporgalon = value; }
        }


        public double Totalgalon
        {
            get { return totalgalon; }
            set { totalgalon = value; }
        }

        public double Totalefectivo
        {
            get { return totalefectivo; }
            set { totalefectivo = value; }
        }


        public double Galonesrestantes
        {
            get { return galonesrestantes; }
            set { galonesrestantes = value; }
        }



    }
}
