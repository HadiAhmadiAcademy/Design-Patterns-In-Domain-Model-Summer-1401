using DemandPlanning.Domain.Framework;

namespace DemandPlanning.Domain.Model.Plan;

public class Demand : ValueObject<Demand>
{
    public ProductId Product { get; private set; }
    public long Quantity { get; private set; }
    public string UnitOfMeasure { get; private set; }
    public Demand(ProductId product, long quantity, string unitOfMeasure)
    {
        Product = product;
        Quantity = quantity;
        UnitOfMeasure = unitOfMeasure;
    }
    protected override IEnumerable<object> GetAttributesToIncludeInEqualityCheck()
    {
        yield return Product;
        yield return Quantity;
        yield return UnitOfMeasure;
    }
    public Demand Clone()
    {
        return new Demand(this.Product, this.Quantity, this.UnitOfMeasure);
    }
}