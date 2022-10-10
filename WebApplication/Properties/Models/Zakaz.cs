namespace WebApplication.Properties.Models
{
    public class Zakaz
    {
        public int ZakazaId { get; set; }
        public int UserId { get; set; }
        public int BasketId { get; set; }
        public string AddressDostavki { get; set; }
        public int TotalPrice { get; set; }
        public bool StatusZakaza { get; set; }
    }
}
