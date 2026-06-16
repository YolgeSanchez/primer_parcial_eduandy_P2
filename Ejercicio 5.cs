// Ejercicio 5: Polimorfismo

public abstract class Animal
{
    public string Nombre { get; set; }

    public abstract void HacerSonido();
}

public class Perro : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine(Nombre + " dice: Woofwoof");
    }
}

public class Gato : Animal
{
    public override void HacerSonido()
    {
        Console.WriteLine(Nombre + " dice: ¡Miau!");
    }
}

class Ejercicio5
{
    static void Main(string[] args)
    {
        List<Animal> animales = new List<Animal>();

        animales.Add(new Perro { Nombre = "Canela" });
        animales.Add(new Gato { Nombre = "Chiquitin" });
        animales.Add(new Perro { Nombre = "Bobby" });

        foreach (Animal animal in animales)
        {
            animal.HacerSonido();
        }
    }
}