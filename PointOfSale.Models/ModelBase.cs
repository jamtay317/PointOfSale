namespace PointOfSale.Models
{
    public abstract class ModelBase:IEntity
    {
        public int Id { get; set; }
    }

    public interface IEntity
    {
        int Id { get; set; }
    }
}