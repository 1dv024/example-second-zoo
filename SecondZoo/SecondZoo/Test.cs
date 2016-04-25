using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecondZoo
{
    public class Test
    {
        public void Run()
        {
            Dog myDog = new Dog();
            Cat myCat = new Cat();
            Man myMan = new Man();
            Car myCar = new Car();

            DoActivity(myDog);
            DoActivity(myCat);
            DoActivity(myCar);
            DoActivity(myMan);

            INoise[] myNoiseObjects = { new Dog(), new Cat(), new Car() };

            foreach (INoise item in myNoiseObjects)
            {
                item.MakeNoise();
            }
        }


        //private static void DoActivity(Cat cat)
        //{
        //    cat.MakeNoise();
        //}

        //private static void DoActivity(Dog dog)
        //{
        //    dog.MakeNoise();
        //}

        //private static void DoActivity(Hippo hippo)
        //{
        //    hippo.MakeNoise();
        //}

        private void DoActivity(Animal animal)
        {
            animal.Roam();
            animal.Sleep();
            animal.MakeNoise();
        }

        private void DoActivity(INoise noise)
        {
            noise.MakeNoise();
        }

    }
}
