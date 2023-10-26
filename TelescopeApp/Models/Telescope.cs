namespace TelescopeApp.Models
{
    public class Telescope
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Manufacturer { get; set; } = string.Empty;

        public int Aperture { get; set; } 

        public int FocalLenght { get; set; }

        public byte[]? Picture { get; set; }
    }
}
