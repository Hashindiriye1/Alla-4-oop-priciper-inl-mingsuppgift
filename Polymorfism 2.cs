
namespace Alla_4_oop_priciper_inlämingsuppgift
{

    namespace ChipExamples
    {
        public class Chips
        {
            public string Name;
            public string Description;

            public virtual void Start()
            {
                Console.WriteLine("These chips are delicious");
            }
        }

        public class Estrella : Chips
        {
            public override void Start()
            {
                Console.WriteLine("De här Estrella chipsen är goda");
            }
        }

        public class Doritos : Chips
        {
            public override void Start()
            {
                Console.WriteLine("Dessa Doritos är crunchy");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                // Skapa en instans av basklassen Chips och anropa metoden Start
                Chips myChips = new Chips();
                myChips.Start();

                // Skapa en instans av Estrella och anropa den överskrivna Start-metoden
                Estrella estrellaChip = new Estrella();
                estrellaChip.Start();

                // Skapa en instans av Doritos och anropa den överskrivna Start-metoden
                Doritos doritosChip = new Doritos();
                doritosChip.Start();
            }
        }
    }



















































}
