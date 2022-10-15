using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV5
{
    internal class ShippingService
    {

        private double unitPricePerMass=10; //kn
        public double GetDeliveryPrice(IShipable product) //10 kn per kilo 
        {
            double result;
            if(product.Weight<1)
                result=unitPricePerMass;
            result = (Convert.ToInt32(Math.Floor(product.Weight))*unitPricePerMass);

            return result;
        }
    }
}
