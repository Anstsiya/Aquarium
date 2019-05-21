using aquarium.aquarium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            Aquarium aquarium = new Aquarium();

            aquarium.cells[3, 1] = new Predator(5, false);
            aquarium.cells[2, 2] = new Predator(9, true);
            aquarium.cells[3, 3] = new Predator(7, true);
            aquarium.cells[4, 2] = new Predator(3, true);
            aquarium.cells[1, 1] = new Predator(4, true);
            aquarium.cells[2, 0] = new Predator(3, true);
            aquarium.cells[5, 1] = new Predator(10, true);
            aquarium.cells[4, 0] = new Predator(3, true);

            for (int i = 0; i < aquarium.aquariumSizeRow; i++)
            {
                for (int j = 0; j < aquarium.aquariumSizeColumn; j++)
                {
                    Aquarium obj = aquarium.cells[i, j];
                    if (obj != null)
                    {
                        var type = obj.GetType();
                        if (type == typeof(Predator))
                        {
                            Predator currentObj = (Predator)obj;
                            currentObj.checkFish(i, j, aquarium.cells);
                        }
                        else if (type == typeof(Herbivore))
                        {
                            Herbivore currentObj = (Herbivore)obj;
                            currentObj.checkFish(i, j, aquarium.cells);
                        }
                        else if (type == typeof(Seaweed))
                        {
                            Seaweed currentObj = (Seaweed)obj;
                            currentObj.checkStatus();
                        }
                        else if (type == typeof(Rock))
                        {
                            Console.WriteLine("Rock");
                        }
                    }
                }
            }


            for (int i = 0; i < aquarium.aquariumSizeRow; i++)
            {
                for (int j = 0; j < aquarium.aquariumSizeColumn; j++)
                {
                    Aquarium obj = aquarium.cells[i, j];
                    if (obj != null)
                    {
                        var type = obj.GetType();
                        if (type == typeof(Predator))
                        {
                            Predator currentObj = (Predator)obj;
                            currentObj.lifeCycle(i, j, aquarium.cells);
                        }
                        else if (type == typeof(Herbivore))
                        {
                            Herbivore currentObj = (Herbivore)obj;
                            currentObj.lifeCycle(i, j, aquarium.cells);
                        }
                        else if (type == typeof(Seaweed))
                        {
                            Console.WriteLine("Seaweed");
                        }
                        else if (type == typeof(Rock))
                        {
                            Console.WriteLine("Rock");
                        }
                        
                        
                    }
                }
            }
            Console.WriteLine(".......");
            Console.ReadLine();
        }
    }
}
