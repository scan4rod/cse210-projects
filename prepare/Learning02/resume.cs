public class Resume
    {
        // The C# convention is to start member variables with an underscore _
        public string _name;
        public List<Job> _jobs = new List<Job>();
        

        // A method that displays the person's full name as used in eastern 
        // countries or <family name, given name>.
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");

            // Notice the use of the custom data type "Job" in this loop
            foreach (Job job in _jobs)
            {
                // This calls the Display method on each job
                job.Display();
            }
    }
      
    }