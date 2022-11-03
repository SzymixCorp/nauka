static void Main(int przedzial)
{
    int attemps = 0;
    Random rnd = new Random();
    Console.WriteLine("Gra w zgadywanie liczb");
    int randomNumber = rnd.Next(1,przedzial);
    while (true)
    {
        Console.WriteLine($"Wybierz liczbe w przedziale 1 do {przedzial}");
        int wybrana = Convert.ToInt32(Console.ReadLine());
        attemps++;
        if(wybrana != randomNumber)
        {
            if (wybrana > randomNumber)
            {
                Console.WriteLine("Liczba za duża");
                continue;
            }else if(wybrana < randomNumber){
                Console.WriteLine("Liczba za mała");
                continue;
            }
        }
        else
        {
            Console.WriteLine($"Brawo zgadłeś!! Liczba to było {randomNumber}. Trafiłeś po {attemps} razach");
            break;
        }
    }
}

Main(100);