namespace Abstraktion_2._0
{
    // Abstrakt basklass
    public abstract class Fordon
    {
        // Abstrakt metod utan implementation
        public abstract void StartaMotor();
    }

    // Subklass som ärver från Fordon
    public class Bil : Fordon
    {
        // Override av StartaMotor-metoden med specifik implementation
        public override void StartaMotor()
        {
            Console.WriteLine("Bilen startar motorn");
        }
    }

    // Ny klass: Motorbat
    public class Motorbat : Fordon
    {
        // Override av StartaMotor-metoden med specifik implementation
        public override void StartaMotor()
        {
            // Simulera motorproblem
            Console.WriteLine("Motorbåten försöker starta, men motorn har problem och går inte att starta");
        }
    }

    // Huvudprogram
    class Program
    {
        static void Main(string[] args)
        {
            // Skapa en instans av Bil och anropa StartaMotor-metoden
            Bil bil = new Bil();
            bil.StartaMotor(); // Utskrift: "Bilen startar motorn"

            // Skapa en instans av Motorbat och anropa StartaMotor-metoden
            Motorbat motorbat = new Motorbat();
            motorbat.StartaMotor(); // Utskrift: "Motorbåten försöker starta, men motorn har problem och går inte att starta"
        }
    }

}
