using Bacchus.Common.Core;

namespace Bacchus.Common.Entities;

public class OrderTypeEntity : Enumeration
{
    public static OrderTypeEntity Achat = new OrderTypeEntity(1, "Achat");
    public static OrderTypeEntity Vente = new OrderTypeEntity(2, "Vente");

    public OrderTypeEntity(int id, string name)
      : base(id, name)
    {
    }

    public static IEnumerable<OrderTypeEntity> List() => new[] { Achat, Vente };

    public static OrderTypeEntity FromName(string name)
    {
        var state = List()
            .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

        if (state == null)
        {
            throw new Exception($"Possible values for OrderStatus: {String.Join(",", List().Select(s => s.Name))}");
        }

        return state;
    }

    public static OrderTypeEntity From(int id)
    {
        var state = List().SingleOrDefault(s => s.Id == id);

        if (state == null)
        {
            throw new Exception($"Possible values for OrderStatus: {String.Join(",", List().Select(s => s.Name))}");
        }

        return state;
    }
}
