namespace MandolinArt.Models
{
    public class Mandolin
    {
        public int ID { get; set; }
        public string Maker { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public decimal Value { get; set; }
        public byte[] Picture { get; set; }
       
    }
    
}