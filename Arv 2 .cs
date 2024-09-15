using System; // Behövs för Console.WriteLine()

class Program
{
    static void Main(string[] args)
    {
        // Skapa en ny Rawbike
        Rawbike myRawbike = new Rawbike();

        // Anropa metoden scream()
        myRawbike.scream(); // Utskrift: "This Rawbike is silent while riding!"

        // Anropa metoden speed()
        myRawbike.speed(); // Utskrift: "This Rawbike is incredibly fast!"
    }
}

// HUVUDKLASSEN
public class Bike
{
    public string model;
    public int year;

    // METOD AV KLASSEN
    public virtual void scream()
    {
        Console.WriteLine("This bike makes a sound");
    }
}

// Underklass Rawbike som ärver från Bike
public class Rawbike : Bike
{
    public int batteryCapacity;

    // Override för att modifiera ljudet
    public override void scream()
    {
        Console.WriteLine("This Rawbike is silent while riding!");
    }

    // Ny metod för hastighet
    public void speed()
    {
        Console.WriteLine("This Rawbike is incredibly fast!");
    }
}

