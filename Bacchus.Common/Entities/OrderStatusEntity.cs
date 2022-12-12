namespace Bacchus.Common.Entities;

public class OrderStatusEntity : Enumeration
{
    public static OrderStatusEntity EnAttente = new OrderStatusEntity(1, "En attente");
    public static OrderStatusEntity Validee = new OrderStatusEntity(2, "Validée");
    public static OrderStatusEntity Preparee = new OrderStatusEntity(3, "Préparée");
    public static OrderStatusEntity Envoyee = new OrderStatusEntity(4, "Envoyée");
    public static OrderStatusEntity Livree = new OrderStatusEntity(5, "Livrée");

    public OrderStatusEntity(int id, string name)
      : base(id, name)
    {
    }

    public static IEnumerable<OrderStatusEntity> List() => new[] { EnAttente, Validee, Preparee, Envoyee, Livree };

    public static OrderStatusEntity FromName(string name)
    {
        var state = List()
            .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

        if (state == null)
        {
            throw new Exception($"Possible values for OrderStatus: {String.Join(",", List().Select(s => s.Name))}");
        }

        return state;
    }

    public static OrderStatusEntity From(int id)
    {
        var state = List().SingleOrDefault(s => s.Id == id);

        if (state == null)
        {
            throw new Exception($"Possible values for OrderStatus: {String.Join(",", List().Select(s => s.Name))}");
        }

        return state;
    }

}
