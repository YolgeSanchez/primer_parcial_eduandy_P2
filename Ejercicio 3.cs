// Ejercicio 3: Clases y objetos

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void Presentarse()
    {
        Console.WriteLine("Hola, mi nombre es " + Nombre + " y tengo " + Edad + " años.");
    }
}

class Ejercicio3
{
    static void Main(string[] args)
    {
        Persona integrante1 = new Persona { Nombre = "Jorge Ray Sanchez", Edad = 20 };
        Persona integrante2 = new Persona { Nombre = "Keinel Feliz", Edad = 20 };
        Persona integrante3 = new Persona { Nombre = "Reyson Armando Feliz", Edad = 19 };

        integrante1.Presentarse();
        integrante2.Presentarse();
        integrante3.Presentarse();
    }
}