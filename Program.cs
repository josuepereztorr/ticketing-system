using System;
using System.IO;

namespace ticketing_system
{
    class Program
    {
        static void Main(string[] args)
        {

            string file = "Tickets.csv";
            string choice;
            StreamWriter sw;

            Console.WriteLine("\nTicketing System\n" + new String('-', 16));

            do
            {
                // ask a question
                Console.WriteLine("\n1) Create a Tickets.csv file from data.");
                Console.WriteLine("2) Add a new record.");
                Console.WriteLine("\nOr enter any other key to exit.");

                // ask for user input
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    if (!File.Exists(file))
                    {
                        // create a file from data 
                        sw = new StreamWriter(file, append: true);
                        string[] watching;

                        // ask a question
                        Console.WriteLine("\nTicket\n------");

                        // ask a question
                        Console.Write("ID: ");

                        // input the response 
                        string ID = Console.ReadLine();

                        // ask a question
                        Console.Write("Summary: ");

                        // input the response 
                        string summary = Console.ReadLine();

                        // ask a question
                        Console.Write("Status: ");
                        // input the response 
                        string status = Console.ReadLine();

                        // ask a question
                        Console.Write("Priority: ");
                        // input the response 
                        string priority = Console.ReadLine();

                        // ask a question
                        Console.Write("Submitter: ");

                        // input the response 
                        string submitter = Console.ReadLine();

                        // ask a question
                        Console.Write("Assigned: ");

                        // input the response 
                        string assigned = Console.ReadLine();

                        // ask a question
                        Console.Write("How many people are Watching this ticket? ");

                        // input the response 
                        watching = new string[Convert.ToInt32(Console.ReadLine())];

                        Console.WriteLine("Please type the name of each person");

                        for (int i = 0; i < watching.Length; i++)
                        {
                            Console.Write((i + 1) + ". ");

                            if ((i != (watching.Length - 1)))
                            {
                                watching[i] = Console.ReadLine() + "|";
                            }
                            else
                            {
                                watching[i] = Console.ReadLine();
                            }

                        }

                        // convert array into a string 
                        string strArray = string.Join("", watching);

                        // write to file 
                        sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", ID, summary, status, priority, submitter, assigned, strArray);

                        sw.Close();

                        choice = "1";
                    }
                    else
                    {
                        Console.WriteLine("\nError: File already exists, to add a new ticket select option #2 in the main menu");

                        choice = "1";
                    }

                }
                else if (choice == "2")
                {

                    if (File.Exists(file))
                    {
                        string[] watching;

                        // ask a question
                        Console.WriteLine("\nTicket\n------");

                        // ask a question
                        Console.Write("ID: ");

                        // input the response 
                        string ID = Console.ReadLine();

                        // ask a question
                        Console.Write("Summary: ");

                        // input the response 
                        string summary = Console.ReadLine();

                        // ask a question
                        Console.Write("Status: ");
                        // input the response 
                        string status = Console.ReadLine();

                        // ask a question
                        Console.Write("Priority: ");
                        // input the response 
                        string priority = Console.ReadLine();

                        // ask a question
                        Console.Write("Submitter: ");

                        // input the response 
                        string submitter = Console.ReadLine();

                        // ask a question
                        Console.Write("Assigned: ");

                        // input the response 
                        string assigned = Console.ReadLine();

                        // ask a question
                        Console.Write("Watching: ");

                        // ask a question
                        Console.Write("How many people are Watching this ticket? ");

                        // input the response 
                        watching = new string[Convert.ToInt32(Console.ReadLine())];

                        for (int i = 0; i < watching.Length; i++)
                        {
                            Console.Write((i + 1) + ". ");

                            if ((i != (watching.Length - 1)))
                            {
                                watching[i] = Console.ReadLine() + "|";
                            }
                            else
                            {
                                watching[i] = Console.ReadLine();
                            }

                        }

                        // convert array into a string 
                        string strArray = string.Join("", watching);

                        using (StreamWriter writer = File.AppendText("Tickets.csv"))
                        {
                            // write to file 
                            writer.WriteLine("{0},{1},{2},{3},{4},{5},{6}", ID, summary, status, priority, submitter, assigned, strArray);
                            writer.Close();
                        }

                        choice = "2";
                    }
                    else
                    {

                        Console.WriteLine("\nError: No file exits, please create a new file in order to add a new ticket.");

                        choice = "2";

                    }

                }


            } while (choice == "1" || choice == "2");

        }
    }
}
