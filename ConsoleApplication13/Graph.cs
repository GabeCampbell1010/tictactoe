using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickGraph;

namespace ConsoleApplication13
{
    class Graph
    {
    }
}


/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickGraph;
 
 
namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int[]> fullarr = new List<int[]>();
            int[] arr1 = new int[] { 1,4,5,4 };
            int[] arr2 = new int[] { 1, 4, 5, 4 };
            int[] arr3 = new int[] { 1, 4, 5, 4 };
 
 
            fullarr.Add(arr1);
            fullarr.Add(arr2);
            fullarr.Add(arr3);
 
 
            var graph = new AdjacencyGraph<string, Edge<string>>();
 
           
            graph.AddVertex("A");
            graph.AddVertex("B");
            graph.AddVertex("C");
            graph.AddVertex("D");
 
           
 
            Edge<string> a_b = new Edge<string>("A", "B");
            Edge<string> a_d = new Edge<string>("A", "D");
            Edge<string> b_a = new Edge<string>("B", "A");
            Edge<string> b_c = new Edge<string>("B", "C");
 
            graph.AddEdge(a_b);
            graph.AddEdge(a_d);
            graph.AddEdge(b_a);
            graph.AddEdge(b_c);
 
            
 
            Console.WriteLine(a_b);
 
 
            Console.ReadKey();
 
 
 
 
        }
    }
} 
     
*/
