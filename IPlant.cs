namespace GreenHouse
{   
    public interface IPlant
    {
        string Species {get; set;}

        int Price {get; set;}

        string Color {get; set;}

        void Report(); 
    }
    
}