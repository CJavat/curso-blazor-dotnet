using CsBases.Fundamentos;

public class ProductRepository
{
  public async Task<Product> GetProduct(int id)
  {
    // Obtener de una DB.
    // Una llamada a API
    // De un archivo
    WriteLine("Buscando Producto...");
    await Task.Delay(2000);

    return new Product("Producto simulado", 500);
  }
}
