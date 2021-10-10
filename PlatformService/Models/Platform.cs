namespace PlatformService.Models
{
    public class Platform
    {
        [Key]
        [Reqired]
        public int Id { get; set; }

        [Reqired]
        public string Name { get; set; }

        [Reqired]
        public string Publisher { get; set; }
        
        [Reqired]
        public string Cost { get; set; }
        
    }
}