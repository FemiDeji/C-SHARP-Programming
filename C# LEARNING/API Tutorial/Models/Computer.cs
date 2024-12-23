namespace APITutorial.Models
{
            //Model Class
    public class Computer
    {
        public int ComputerId { get; set; }

        public string Motherboard { get; set;} = "";           //alternative method instead of constructor
        
        public int? CPUCores { get; set; }
        
        public bool HasWifi { get; set; }
        
        public bool HasLTE {get; set; }
        
        public DateTime ReleaseDate { get; set; }
        
        public decimal Price { get; set; }
        
        public string VideoCard { get; set; } = "";             //alternative method instead of constructor

        //constructor for the model class to set the value if it were ever null 
        public Computer ()
        {
            if (VideoCard == null)
            {
                VideoCard = "";
            }
            if (Motherboard == null)
            {
                Motherboard = "";
            }
            if (Motherboard == null)
            {
                CPUCores = 0;
            }
        }
    }
}
