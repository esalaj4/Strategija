using System;

namespace RPPOON_LV5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product milk = new Product("Polumasno mlijeko ", 5, 7);
            string descriptionMilk = milk.Description();
            Console.WriteLine(descriptionMilk);
            Box cereal = new Box("Pahuljice");
            Product Nestle = new Product("Nestle cereal", 20.7, 2);
            IShipable Muesli = new Product("Muesli cereal", 27.99, 0.350);
            Box Nesquick = new Box("Nesquick cereal");

            Product DrOretker = new Product("DrOretker cereal", 19.99, 0.500);

            Nesquick.Add(new Product("Black-white nesquick", 21.99, 0.500));
            Nesquick.Add(new Product("Shell nesquick", 24.99, 0.500));
            cereal.Add(Nesquick);
            cereal.Add(Muesli);
            cereal.Add(Nestle);
            cereal.Add(DrOretker);

            string cerealDescription = cereal.Description();
            Console.WriteLine(cerealDescription);

            ShippingService shippingService = new ShippingService();
            Console.WriteLine(shippingService.GetDeliveryPrice(cereal));

            

        }
    }
}
