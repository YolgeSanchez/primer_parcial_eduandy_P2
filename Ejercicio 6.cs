// Author: Keinel Feliz

// Clase
public class CuentaBancaria
{
  private decimal saldo { get; set; }

  public bool Depositar(decimal monto)
  {
    saldo += monto;
    Console.WriteLine("Deposito completado");
    return true;
  }

  public decimal ObtenerSaldo()
  {
    Console.WriteLine(saldo);
    return saldo;
  }
}

// Uso
public class Program
{
  public static void Main()
  {
    CuentaBancaria Keinel = new();
    Keinel.Depositar(5000);
    Keinel.ObtenerSaldo();
  }
}