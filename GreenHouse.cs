using System;
using System.Collections.Generic;
namespace GreenHouse {
    public class GreenHouse {

        public List<IGiftBasketItem> GiftBasketItems {get; set;}
        public List<IBouquetItem> BouquetItems {get; set;}

        public List<IPlant> OrderPlants {get; set;}

        public void MakeBouquet(){
            Console.WriteLine("You made a bouquet, the current stem lengths are");
            BouquetItems.ForEach(item => Console.WriteLine($"{item.StemLength} ''"));

        }

        public void MakeGiftBasket(){
            int totalWeightOfBasket = 0;
            Console.WriteLine("You made a gift basket");
            GiftBasketItems.ForEach(item =>totalWeightOfBasket = totalWeightOfBasket + item.TotalWeight );
            Console.WriteLine($"The total weight is {totalWeightOfBasket}lbs");

        }

        public void orderReport(){
            Console.WriteLine($"Your current order contains:");
            OrderPlants.ForEach(plant => plant.Report());

        }

    }
}