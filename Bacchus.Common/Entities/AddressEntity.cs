using Bacchus.Common.Core;

namespace Bacchus.Common.Entities;

public class AddressEntity : Entity
{
    public string Name { get; set; }
    public string Number { get; set; }
    public string Street { get; set; }
    public string ZipCode { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public string AdditionalDetails { get; set; }
}
