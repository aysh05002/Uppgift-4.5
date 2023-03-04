using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Skriv in ett heltal");
        string heltal = Console.ReadLine();

        for (int i = 0; i < heltal.Length; i++)
        {
            string tecken = heltal[i].ToString();
            int siffra = int.Parse(tecken);
            if (siffra == 9)
            {
                int x = 0;
                Console.Write(x);
            }
            else
            {
                int y = siffra + 1;
                Console.Write(y);
            }
        }
    }
}