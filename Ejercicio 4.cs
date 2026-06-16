// Author: Keinel Feliz

// Clase Padre
public class Animal
{
  public virtual void HacerSonido()
  {
    Console.WriteLine("El animal hace un sonido");
  }
}

// Clases hijas
public class Perro : Animal
{
  public override void HacerSonido()
  {
    Console.WriteLine("El perro ladra");
  }
}

public class Gato : Animal
{
  public override void HacerSonido()
  {
    Console.WriteLine("El gato maulla");
  }
}

// Uso
public class Program
{
  public static void Main()
  {
    List<Animal> animals = new()
    {
      new Animal(),
      new Perro(),
      new Gato()
    };

    foreach (Animal animal in animals)
    {
      animal.HacerSonido();
    }
  }
}
