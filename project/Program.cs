using System.Collections;
using System.ComponentModel.Design;
using System.Numerics;
using System.Text;
//EbraBepo
namespace project
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Menu: " +
                    "a == ADD"
                    + "   p== show in list "
                    + "  m== Average"
                    + " l== large of element"
                    + "  s== small of element"
                    + "  f== search of element"
                    + "  c == clear of list "
                    + "  q==exit" + "   sorting==sort"
                    + "  swaping==swap");
                string option = Console.ReadLine();
                if (option == "a")
                {
                    Console.WriteLine("you are need one element or multi element ?  please write one or more");
                    string choice = Console.ReadLine();
                    if (choice == "one")
                    {
                        Console.WriteLine("Enter element to add:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        list.Add(x);
                    }
                    else if (choice == "more")
                    {
                        Console.WriteLine("how many element you want to add ?");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Enter element to add:");
                            int x = Convert.ToInt32(Console.ReadLine());
                            list.Add(x);
                        }
                    }
                }
                else if (option == "p")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("list is empty");
                    }
                    else
                    {
                        for (int i = 0; i < list.Count; i++)
                        {
                            Console.WriteLine(list[i]);
                        }

                    }
                }
                else if (option == "m")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("list is empty");
                    }
                    else
                    {
                        double sum = 0;
                        for (int i = 0; i < list.Count; i++)
                        {
                            sum += list[i];
                        }
                        double average = sum / list.Count;
                        Console.WriteLine("Average of list: " + average);
                    }
                }
                else if (option == "l")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("list is empty");
                    }
                    else
                    {
                        int large = list[0];
                        for (int i = 1; i < list.Count; i++)
                        {
                            if (list[i] > large)
                            {
                                large = list[i];
                            }
                        }
                        Console.WriteLine("Largest element: " + large);
                    }
                }
                else if (option == "s")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("list is empty");
                    }
                    else
                    {
                        int small = list[0];
                        for (int i = 1; i < list.Count; i++)
                        {
                            if (list[i] < small)
                            {
                                small = list[i];
                            }
                        }
                        Console.WriteLine("Smallest element: " + small);
                    }
                }


                else if (option == "f")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("list is empty");
                    }
                    else
                    {
                        Console.WriteLine("Enter element to search:");
                        int searchElement = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < list.Count; i++)
                        {
                            if (list[i] == searchElement)
                            {
                                Console.WriteLine("Element found at index: " + i);
                                break;
                            }
                            else if (i == list.Count - 1)
                            {
                                Console.WriteLine("Element not found");
                            }
                        }
                    }
                }
                else if (option == "c")
                {
                    list.Clear();
                    Console.WriteLine("List cleared");
                }
                if (option == "sort")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine("list is empty");
                    }
                    else
                    {
                        for (int i = 0; i < list.Count - 1; i++)
                        {
                            for (int j = i + 1; j < list.Count; j++)
                            {
                                if (list[i] > list[j])
                                {
                                    int temp = list[i];
                                    list[i] = list[j];
                                    list[j] = temp;
                                }
                            }
                        }
                        Console.WriteLine("List sorted");
                    }
                }
                if (option == "swap")
                {
                    Console.WriteLine("Enter first index to swap:");
                    int index1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second index to swap:");
                    int index2 = Convert.ToInt32(Console.ReadLine());
                    if (index1 < 0 || index1 >= list.Count || index2 < 0 || index2 >= list.Count)
                    {
                        Console.WriteLine("Invalid indices");
                    }
                    else
                    {
                        int temp = list[index1];
                        list[index1] = list[index2];
                        list[index2] = temp;
                        Console.WriteLine("Elements swapped");
                    }
                }
                else if (option == "q")
                {
                    break;


                }

            }
        }


    }
}
