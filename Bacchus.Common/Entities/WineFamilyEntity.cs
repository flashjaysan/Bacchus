namespace Bacchus.Common.Entities;

public class WineFamilyEntity : Enumeration
{
    public static WineFamilyEntity Rouge = new WineFamilyEntity(1, "Rouge");
    public static WineFamilyEntity Blanc = new WineFamilyEntity(2, "Blanc");
    public static WineFamilyEntity Rose = new WineFamilyEntity(3, "Rosé");
    public static WineFamilyEntity Autre = new WineFamilyEntity(4, "Autre");

    public WineFamilyEntity(int id, string name)
      : base(id, name)
    {
    }

    public static IEnumerable<WineFamilyEntity> List() => new[] { Rouge, Blanc, Rose, Autre };

    public static WineFamilyEntity FromName(string name)
    {
        var state = List()
            .SingleOrDefault(s => String.Equals(s.Name, name, StringComparison.CurrentCultureIgnoreCase));

        if (state == null)
        {
            throw new Exception($"Possible values for OrderStatus: {String.Join(",", List().Select(s => s.Name))}");
        }

        return state;
    }

    public static WineFamilyEntity From(int id)
    {
        var state = List().SingleOrDefault(s => s.Id == id);

        if (state == null)
        {
            throw new Exception($"Possible values for OrderStatus: {String.Join(",", List().Select(s => s.Name))}");
        }

        return state;
    }
}
