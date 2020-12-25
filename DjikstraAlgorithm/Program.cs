using System;

namespace DjikstraAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть номер початкової вершини (1-6)");
            int startPointNumber;
            while (true)
            {
                if (Int32.TryParse(Console.ReadLine(), out startPointNumber))
                {
                    if (startPointNumber >= 1 && startPointNumber <= 6)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введіть число в межах від 1-6");
                    }
                }
            }

            startPointNumber -= 1;

            Djikstra Djikstra = new Djikstra(startPointNumber);

            foreach (var point in Djikstra.Graph.Points)
            {
                Console.WriteLine($"Найкоротший шлях від вершини {Djikstra.startPoint.Name} до вершини {point.Name} = {point.DistanceFromStart}");
            }
        }
    }
}
