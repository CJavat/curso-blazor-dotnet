namespace CsBases.Fundamentos;

public interface IProduct
{
  string? Name { get; set; }


  void ApplyDiscount(decimal percentage);
  string GetDescription();
}
