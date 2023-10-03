using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static List<(int, int)> FirstGroup=new List<(int, int)>();
        static List<(int,int)> SecondGroup=new List<(int, int)>();
        static void Main(string[] args)

        {
            //Dictionary<int, Tuple<int, int>> numbersCol1 = new Dictionary<int, Tuple<int, int>>();
           // Dictionary<int, (int, int)> numbersCol2 = new Dictionary<int, (int, int)>();
    
            //int num = 0;
            string[] values = Console.ReadLine().Split(' ');
            
            int maxGreen = Int32.Parse(values[1]);
            int maxYellow = Int32.Parse(values[2]);
            // Console.WriteLine(values[0]+' '+values[1]+' '+values[2]);
            int iterator = Int32.Parse(values[0]);
            for (int i = 0; i < Int32.Parse(values[0]); i++)
            {
               // Console.WriteLine('1');
                values = Console.ReadLine().Split(' ');
                FirstGroup.Add((i, Int32.Parse(values[0])));//#id-item1 #value-item2
                
                SecondGroup.Add((i, Int32.Parse(values[1])));
            }
            //FirstGroup.OrderBy(n => n.Item2);
            //condGroup.OrderBy(n => n.Item2);
           var val1= Sorting(FirstGroup.OrderBy(n => n.Item2).ToList(),maxGreen);
           var val2= Sorting(SecondGroup.OrderBy(n => n.Item2).ToList(),maxYellow);
           // var result = val1.Intersect(val2).Count();
            Console.WriteLine(val1.Intersect(val2).Count());
        }


       static List<(int,int)> Sorting(List<(int,int)> listToSort,int maxVal)
        {
            int sum=0;
            for (int i = 0; i < listToSort.Count; i++)
            {
               
                if (sum + listToSort[i].Item1 > maxVal) { return listToSort.GetRange(0, i + 1); }
                sum += listToSort[i].Item1;


            }
            return listToSort ; }

    }
    
       
}

