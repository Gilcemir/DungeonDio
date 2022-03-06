using System;
namespace DungeonDio
{
    class Program
    {
        static void Main(string[]args)
        {
            string[] musics = new string[]{"drums", "flut", "harp", "random"};

            Knight Davion = new Knight("Davion", 10);
            Wizard Lina = new Wizard("Lina", 9);
            Bard Maga = new Bard("Maga", 2);
            
            Random random = new Random(4);

            Console.WriteLine("Our heroes: ");
            Console.WriteLine(Davion);
            Console.WriteLine(Lina);
            Console.WriteLine(Maga);

            for(int i = 0; i< 200; i+=random.Next(20)){
                Console.WriteLine(Davion.Attack(i));
                Console.WriteLine(Lina.Attack(i));
                Console.WriteLine(Maga.PlaySong(musics[random.Next(4)]));
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}