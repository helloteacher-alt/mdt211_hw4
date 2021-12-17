using System;

namespace mdt211_hw4
{
    class Program
    {
         static void Main(string[] args)
         {
            int numCity = int.Parse(Console.ReadLine());
            string nameCity;
            for (int i = 0; i < numCity; i++)
            {
                nameCity = Console.ReadLine();
                Node.city[i] = new Node(nameCity);
            }
                Loop(numCity);
                FindEndedPoint(numCity);


                int finalPoint = 0;
                int temp = 0;
                if (Node.End.Left != Node.city[0] && Node.End.Left != null)
                {
                    temp = temp + Node.End.Left.distance;
                        if (Node.End.Left.Left != Node.city[0] && Node.End.Left.Left != null)
                        { 
                            temp = temp + Node.End.Left.Left.distance;
                                if (Node.End.Left.Left.Left != Node.city[0] && Node.End.Left.Left.Left != null)
                                {
                                    temp = temp + Node.End.Left.Left.Left.distance;
                                }
                        }
                }
                if (finalPoint == 0 || temp < finalPoint)
                {
                    finalPoint = temp;
                    temp = 0;
                }
                Console.WriteLine(finalPoint);

         }


         static void Loop(int valueNumCity)
             {
                 for (int i = 1; i < valueNumCity; i++)
                 {
                     for (int j = 0; j < i; j++)
                     {
                         int Distance = int.Parse(Console.ReadLine());
                         if (Distance != -1)
                         {
                             if (Node.city[i].Left == null)
                             {
                                 Node.city[i].Left = Node.city[j];
                                 Node.city[i].Left.distance = Distance;
                             }
                             else if (Node.city[i].Right == null)
                             {
                                 Node.city[i].Right = Node.city[j];
                                 Node.city[i].Right.distance = Distance;
                             }
                         }
                     } Console.WriteLine();
                 }
             }

             static void FindEndedPoint(int valueNumCity)
             {
                 string endedLand = Console.ReadLine();
                 for (int i = 0; i < valueNumCity; i++)
                 {
                     if (endedLand == Node.city[i].name)
                     {
                         Node.End = Node.city[i];
                     }
                 }
             }
     }
}
    

