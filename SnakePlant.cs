using System;
namespace GreenHouse {
    public class SnakePlant: IGiftBasketItem, IPlant {

        public string Species {get; set;}

        public string Color {get; set;}

        public int Price {get; set;}

        public int TotalWeight {get; set;}

        public bool DroughtTolerant {get; set;}

        public void Report(){
            Console.WriteLine($"This is a {Color} snake plant of species {Species}. This plant {(DroughtTolerant ? "is" :"is not")} drought tolerant.");
        }
    }
}