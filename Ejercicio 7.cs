// Author: Jorge Sanchez

// Interfaz
public interface IVehiculo
{
  void Encender();
  void Apagar();
}

// Implementacion de las clases en base a la interfaz
public class Carro : IVehiculo
{
  public void Apagar()
  {
    Console.WriteLine("El carro ha sido apagado");
  }

  public void Encender()
  {
    Console.WriteLine("El carro ha sido encendido");
  }
}

public class Motocicleta : IVehiculo
{
  public void Apagar()
  {
    Console.WriteLine("La motocicleta ha sido apagada");
  }

  public void Encender()
  {
    Console.WriteLine("La motocicleta ha sido encendida");
  }

}

// Uso
public class Program
{
  public static void Main()
  {
    List<IVehiculo> vehiculos = new List<IVehiculo>
    {
      new Carro(),
      new Motocicleta()
    };

    foreach (var vehiculo in vehiculos)
    {
      vehiculo.Encender();
      vehiculo.Apagar();
    }
  }
}
