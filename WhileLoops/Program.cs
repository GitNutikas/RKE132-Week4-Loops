Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool - true/false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 4); // (1, 4) kuni 3ni

    //Console.WriteLine($"cpu has generated {cpuRandom}."); //cheat
    Console.WriteLine("Make a guess. Enter a number 1-3");

    int userNumber = Int32.Parse(Console.ReadLine());   //konverteerime string numbriks

    if(userNumber == cpuRandom)
    {
        Console.WriteLine("Congratulations, you won!");
        //loopActive = false;
        break;  //lõpeb tsükli while loopi, sama mis loopActive = false;
    }
    else 
    {
        Console.WriteLine("Oops. Try again!");
    }
}

Console.WriteLine("Have a nice day!");