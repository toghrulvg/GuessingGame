using System;

class GuessingGame
{
    static void Main()
    {
        Console.WriteLine("Texmin oyunu");
        Console.WriteLine("Aglimda 1'den 100'e qeder bir eded tutdum , 5 defeye texmin et");

        Random random = new Random();
        int eded = random.Next(1, 101);

        int texminler = 0;

        while (true)
        {
            Console.Write("Texminin: ");
            int texmin = int.Parse(Console.ReadLine());
            texminler++;

            if (texminler >= 5)
            {
                Console.WriteLine("5 defeye tapa bilmedin");
                Console.WriteLine("Tutdugum eded "+ eded + " idi");
                break;
            }
            else
            {
                if (Math.Abs(texmin- eded) > 10 && texmin > eded)
                {
                    Console.WriteLine("Daxil etdiyin eded aglimda tutdugumnan cox coxdur");
                    Console.WriteLine("Geri qalan texmin sayi: " + (5 - texminler));
                }
                else if (Math.Abs(texmin - eded) > 10 && texmin < eded)
                {
                    Console.WriteLine("Daxil etdiyin eded aglimda tutdugumnan cox azdir");
                    Console.WriteLine("Geri qalan texmin sayi: " + (5 - texminler));
                }
                else if (texmin < eded)
                {
                    Console.WriteLine("Daxil etdiyin eded aglimda tutdugumnan azdir");
                    Console.WriteLine("Geri qalan texmin sayi: " + (5 - texminler));
                }
                else if (texmin > eded)
                {
                    Console.WriteLine("Daxil etdiyin eded aglimda tutdugumnan coxdur");
                    Console.WriteLine("Geri qalan texmin sayi: " + (5- texminler));
                    
                }
                else
                {
                    Console.WriteLine("Tebrikler " + texminler + " defeye tapdin");
                    break;
                }
            }

            
        }
    }
}
