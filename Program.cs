string file = "Tickets.csv";
string choice;

do
{
    Console.WriteLine("1) Read from file.");
    Console.WriteLine("2) Write to file.");
    Console.WriteLine("Any other key to exit.");
    choice = Console.ReadLine();

    if (choice == "1")
    {
        if (File.Exists(file))
        {
            StreamReader sr = new StreamReader(file);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] arr = line.Split(',');
                Console.WriteLine
                    (
                    "TicketID: {0}, Summary: {1}, Status: {2}, Priority: {3}, Submitter: {4}, Assigned: {5}, Watching: {6}", 
                    arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6]
                    );
            }
            sr.Close();
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
    else if (choice == "2")
    {
        StreamWriter sw = new StreamWriter(file);
        string resp = "Y";
        while (resp == "Y")
        {
            Console.WriteLine("Construct a ticket (Y/N)?");
            resp = Console.ReadLine().ToUpper();
            if (resp != "Y") { break; }

            Console.WriteLine("Ticket ID:");
            string ticketID = Console.ReadLine();
            Console.WriteLine("Summary:");
            string summary = Console.ReadLine();
            Console.WriteLine("Status:");
            string status = Console.ReadLine();
            Console.WriteLine("Priority:");
            string priority = Console.ReadLine();
            Console.WriteLine("Submitter:");
            string submitter = Console.ReadLine();
            Console.WriteLine("Assigned:");
            string assigned = Console.ReadLine(); 
            Console.WriteLine("Watching:");
            string watching = Console.ReadLine();      
            sw.WriteLine("{0},{1},{2},{3},{4},{5},{6}", ticketID, summary, status, priority, submitter, assigned, watching);             
        }
        sw.Close();
    }

} while (choice == "1" || choice == "2");