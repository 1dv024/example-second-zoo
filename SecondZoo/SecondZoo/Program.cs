using System;
using System.Diagnostics;

namespace SecondZoo
{
    enum NoiseObjectType { Indefinite, Cat, Dog, Car };


    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            NoiseObjectType type = NoiseObjectType.Indefinite;

            do
            {
                switch (GetMenuChoice())
                {
                    case 0:
                        exit = true;
                        break;

                    case 1:
                        type = NoiseObjectType.Cat;
                        break;

                    case 2:
                        type = NoiseObjectType.Dog;
                        break;

                    case 3:
                        type = NoiseObjectType.Car;
                        break;

                    case 4:
                        Console.Clear();
                        Test test = new Test();
                        test.Run();
                        continue;

#if DEBUG
                    default:
                        Debug.Assert(false, "Hantering av menyalternativet saknas.");
                        continue;
#endif
                }

                Console.Clear();
                INoise noise = CreateNoiseObject(type);
                noise.MakeNoise();
                ContinueOnKeyPressed();
            } while (!exit);
        }

        private static void ContinueOnKeyPressed()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("\n   Tryck tangent för att fortsätta   ");
            Console.ResetColor();
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.Clear();
            Console.CursorVisible = true;
        }

        private static INoise CreateNoiseObject(NoiseObjectType type)
        {
            switch (type)
            {
                case NoiseObjectType.Car:
                    return new Car();

                case NoiseObjectType.Cat:
                    return new Cat();

                case NoiseObjectType.Dog:
                    return new Dog();

                default:
                    throw new NotImplementedException();
            }
        }

        private static int GetMenuChoice()
        {
            int index;

            do
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" ╔═══════════════════════════════════╗ ");
                Console.WriteLine(" ║          Objekt med ljud          ║ ");
                Console.WriteLine(" ╚═══════════════════════════════════╝ ");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\n - Arkiv -----------------------------------\n");
                Console.WriteLine(" 0. Avsluta.");
                Console.WriteLine("\n - Ljudliga objekt -------------------------\n");
                Console.WriteLine(" 1. Katt.");
                Console.WriteLine(" 2. Hund.");
                Console.WriteLine(" 3. Bil.");
                Console.WriteLine("\n - Test ------------------------------------\n");
                Console.WriteLine(" 4. Kör test.");
                Console.WriteLine("\n ═══════════════════════════════════════════\n");
                Console.Write(" Ange menyval [0-4]: ");
                Console.ResetColor();

                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 4)
                {
                    return index;
                }

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n FEL! Ange ett nummer mellan 0 och 4.\n");
                ContinueOnKeyPressed();
            } while (true);
        }
    }
}
