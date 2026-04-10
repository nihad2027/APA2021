namespace _09_UpcastingDowncastingExplicitImplicit;

internal class Program
{
    static void Main(string[] args)
    {
        #region Upcasting - Downcasting 

        #endregion
        //Dog dog = new Dog { AvgLifeTime = 23, Breed = "Xaski", Gender = "male", Name = "Hatiko" };
        //Eagle eagle = new Eagle { AvgLifeTime = 50, Gender = "female", FlySpeed = 200 };

        //Upcasting - Implicit
        //Animal animal = dog;
        //Animal animal1 = eagle;


        //Downcasting - Explicit
        //Dog dog1 = (Dog)animal;
        //Eagle eagle1 = (Eagle)animal1;

        //Animal[] animals = { dog, eagle };

        //foreach (var animal in animals)
        //{
        //    Eagle eagle1 = (Eagle)animal;


        //    Eagle eagle1 = animal as Eagle;

        //    eagle1.Fly();

        //    if (eagle1 != null)
        //    {
        //        eagle1.Fly();
        //    }

        //    if (animal is Eagle)
        //    {
        //        Eagle eagle1 = (Eagle)animal;
        //    }
        //    else
        //    {
        //        Dog dog1 = (Dog)animal;
        //    }
        //}

        #region Boxing-Unboxing
        //Boxing
        //int a = 6;

        //Object b = a as Object;

        //int c = (int)b;

        //Test test = new Test();

        //ITest test1 = test;

        //Test test2= (Test)test1; 
        #endregion

        Dollar dollar = new(200);
        //Console.WriteLine(dollar.USD);

        Manat manat = new(170);
        //Console.WriteLine(manat.AZN);

        Dollar dollar1 = manat;
        Console.WriteLine(dollar1.USD);

        Manat manat1 = dollar;
        Console.WriteLine(manat1.AZN);
    }
}





