using OOP_Polymorphism;

namespace OOP_Polymorphism
{


    public class Redskap
    {
        static void Main(string[] args)
        {
            Redskap myRedskap = new Redskap();
            myRedskap.Start();

            Refrigerator myRefrigerator = new Refrigerator();
            myRefrigerator.Start();

            Oven myOven = new Oven();
            myOven.Start();
        }

        // Här lagrar jag namn och modell för Redskap
        public string Namn;
        public string Modell;


        // Den här metoden startar redskap men det går att ändra hur den fungerar i andra klasser
        public virtual void Start()
        {

            // Här skriver den ut att köksredskap startar
            Console.WriteLine("Köksredskapet startar");
        }
    }

    // UNDERKLASS
    public class Refrigerator : Redskap
    {
        public override void Start()
        {
            Console.WriteLine("Kylskåp börjar kyla ner");
        }

    }

}

//En till underklass 
public class Oven : Redskap
{
    public override void Start()
    {
        Console.WriteLine("Spis börjar hettas upp");
    }
}
