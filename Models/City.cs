namespace MES_Service.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal TransportCost { get; set; }
        public decimal CostOfWorkingHour { get; set; }
        public virtual SearchHistory SearchHistory { get; set; }
    }
}