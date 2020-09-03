using System;
namespace GreenHouse {
    public class Fern: IGiftBasketItem, IPlant  {

        public string Species {get; set;}

        public string Color {get; set;}

        public int Price {get; set;}

        public int TotalWeight {get; set;}

        public void Report(){
            Console.WriteLine($"This is a {Color} Fern of species {Species}.");
        }
    }
}