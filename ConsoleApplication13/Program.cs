using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickGraph;

namespace ConsoleApplication13
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[9];
            int count = 1;

            List<int[]> forkarr = new List<int[]>();

            List<int[]> fullarr = new List<int[]>();

            List<int[]> Altforkarr = new List<int[]>();



            for (int i = 0; i < 3; i++)
                {
                    
                        for (int j = 0; j < 3; j++)
                        {
                            
                                for (int k = 0; k < 3; k++)
                                {
                                    
                                        for (int l = 0; l < 3; l++)
                                        {
                                            
                                                for (int m = 0; m < 3; m++)
                                                {
                                                   
                                                        for (int n = 0; n < 3; n++)
                                                        {
                                                            
                                                                for (int o = 0; o < 3; o++)
                                                                {
                                                                    
                                                                        for (int p = 0; p < 3; p++)
                                                                        {
                                                                            
                                                                                for (int q = 0; q < 3; q++)
                                                                                {
                                                                                    arr[0] = i;
                                                                                    arr[1] = j;
                                                                                    arr[2] = k;
                                                                                    arr[3] = l;
                                                                                    arr[4] = m;
                                                                                    arr[5] = n;
                                                                                    arr[6] = o;
                                                                                    arr[7] = p;
                                                                                    arr[8] = q;

                                                                                    if (Valid.check(arr))
                                                                                    {
                                                                                        Console.WriteLine(count + ") ");
                                                                                        WinCheck.Win(arr);
                                                                                        PrintGame.print(arr);
                                                                                        fullarr.Add(arr);

                                                                                        if (AltFork.check(arr)) { Altforkarr.Add(arr); Console.WriteLine("It's a Alternative Fork!"); } //alternative fork check

                                                                                        count++;
                                                                                        Console.WriteLine();
                                                                                    }
                                                                                    arr = new int[9];
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }

            

            Console.WriteLine("The Forks: ");

            int c = 1;
            foreach (int[] arry in Altforkarr)
            {
                Console.WriteLine(c + ") ");
                PrintGame.print(arry);
                Console.WriteLine();
                c++;
            }

            //now make a new list of non-duplicated forks
            List<int[]> AltforkarrND = Altforkarr;

            // now complete duplicate fork list for forks and print them
            for (int i = 0; i < AltforkarrND.Count; i++)
            {
                for (int j = 0; j < AltforkarrND.Count; j++)
                {
                    if (ForkValid.ForkDuplicate(AltforkarrND[i], AltforkarrND[j]) == 3) { AltforkarrND.Remove(AltforkarrND[j]); }
                }
            }

            Console.WriteLine("Now the non-duplicated forks:");
            int co = 1;
            foreach (int[] arry in AltforkarrND)
            {
                Console.WriteLine(co + ") ");
                PrintGame.print(arry);
                Console.WriteLine();
                co++;
            }
            //declare graph
            
            var graph = new AdjacencyGraph<int[], Edge<int[]>>();
            //add all board states to graph as vertices
            for (int i = 0; i < fullarr.Count; i++)
            {
                graph.AddVertex(fullarr[i]);
            }

            
            //if connect conditions are met then connect vertices with edges
            for (int i = 0; i < fullarr.Count; i++)
            {
                for (int j = 0; j < fullarr.Count; j++)
                {
                    if (Connected.connect(fullarr[i], fullarr[j]))
                    {
                        
                        Edge<int[]> a = new Edge<int[]>(fullarr[i], fullarr[j]);//make new edge
                        graph.AddEdge(a);  //connect edge
                        
                    }
                }
            }
            //print the edges
            
            foreach (var vertex in graph.Vertices)
            {
                foreach (var edge in graph.OutEdges(vertex))
                {
                    PrintGame.print(vertex);
                    Console.WriteLine(edge);
                }
            }
            

            Console.ReadKey();
        }
        
    }
}