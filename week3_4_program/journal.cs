using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        int jor;
        jor=0;
        Console.WriteLine("Welcome to the journal program ");
        
        //string ans = Console.ReadLine();
        //num = int.Parse(ans);
            do
            { 
                Console.Write("Please select one of the following choices:");
                string opt = Console.ReadLine();
                opt_num = int.Parse(opt);
                jor = opt_num;
         
            } while (jor != 5);
        

    }
}