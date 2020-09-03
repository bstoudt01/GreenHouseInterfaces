using System;
using System.Collections.Generic;

namespace GreenHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Rose redRose = new Rose(){
                StemLength = 6,
                Color = "red", 
                Species = "BeepBoop", 
                Thorny = true,
                Price = 2
            };
            Rose yellowRose = new Rose(){
                StemLength = 8,
                Color = "yellow", 
                Species = "yellow Submarine", 
                Thorny = false,
                Price = 2
            };
            Tulip pinkTulip = new Tulip(){
                StemLength = 5,
                Color = "pink", 
                Species = "Adorable", 
                Variegated = true,
                Price = 3
            };
            Tulip whiteTulip = new Tulip(){
                StemLength = 4,
                Color = "white", 
                Species = "Boring", 
                Variegated = false,
                Price = 3
            };

            GreenHouse MosGreenHouse = new GreenHouse();

            MosGreenHouse.BouquetItems = new List<IBouquetItem>(){
                redRose,
                yellowRose,
                pinkTulip,
                whiteTulip
            }; 
            // MosGreenHouse.MakeBouquet();

            SnakePlant smallSnakePlant = new SnakePlant(){
                TotalWeight = 3,
                Color = "white", 
                Species = "Boring", 
                DroughtTolerant = true,
                Price = 3
            };
            Fern birdsNestFern = new Fern(){
                TotalWeight = 7,
                Color = "white", 
                Species = "Boring", 
                Price = 3
            };

            MosGreenHouse.GiftBasketItems = new List<IGiftBasketItem>() {
                smallSnakePlant,
                birdsNestFern
            };

            // MosGreenHouse.MakeGiftBasket();

            MosGreenHouse.OrderPlants = new List<IPlant>(){
                smallSnakePlant,
                birdsNestFern,
                pinkTulip,
                whiteTulip,
                redRose,
                yellowRose
            };

            MosGreenHouse.orderReport();
        }
    }
}
