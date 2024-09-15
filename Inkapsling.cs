namespace Patient
{



    public class Patient
    {
        // Privat attribut som bara kan nås via metoder
        private string name;

        //Konstruktor för att sätta namn när ett objekt skapas
        public Patient(string name)
        {
            this.name = name;
        }

        // Public metod för att hämta namnet 

        public string Getname()
        {
            return name;
        }


        // Public metod för att ändra namnet

        public void Setname(string newName)
        {
            name = newName;
        }

    }

    class program
    {
        static void Main(string[] args)
        {
            // Skapa ett nytt Student-objekt med namnet "Hassan"

            Patient patient1 = new Patient("Hassan");


            // Skriv ut nuvarande namn

            Console.WriteLine(patient1.Getname());

            // Ändra namnet till "Erik"

            patient1.Setname("Erik");

            // Skriv ut det uppdaterade namnet 

            Console.WriteLine("Uppdaterade namn: " + patient1.Getname());

        }

    }

}