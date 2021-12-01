using System;
using System.Collections;

public class ContactBook
{
    public string FirstName { get; set; }    
    public long PhoneNumber { get; set; }
    public string Location { get; set; }
}

public class Program
{
     static ArrayList Contacts = new ArrayList();
     
     static void Main(string[] args)
     {        
        DisplayMenu();
     }

     static void DisplayMenu()
	 {
		Console.WriteLine("1: Add Contact");
		Console.WriteLine("2: Display Contact");
        Console.WriteLine("3: Search Contact");
        Console.WriteLine("4: Edit Contact");
        Console.WriteLine("5: Delete Contact");
        Console.WriteLine("6: Exit");

        Console.Write("\nEnter your choice: ");
		int nChoice;
		int.TryParse(Console.ReadLine(), out nChoice);

		if(nChoice > 0)
        {
            switch(nChoice)
            { 
                case 1:
                    InsertContact();
                    break;
                case 2:
                    DisplayContact();
                    break;
                case 3:
                    SearchContact();
                    break;
                case 4:
                    EditContact();
                    break;
                case 5:
                    DeleteContact();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid Choice. Try Again...");
                    break;
            }            
        }
		else
		{
            Console.WriteLine("Invalid Choice");
		}
        DisplayMenu();
    }

     static void InsertContact()
     {
       
        ContactBook Contactbook = new ContactBook();

        Console.Write("Enter FirstName : ");
        Contactbook.FirstName = Console.ReadLine();

        Console.Write("Enter PhoneNumber : ");
        Contactbook.PhoneNumber =Convert.ToInt64(Console.ReadLine());

        Console.Write("Enter Location: ");
        Contactbook.Location = Console.ReadLine();

        Contacts.Add(Contactbook);
        Console.WriteLine("\nContact Added Successfully");
        Console.WriteLine("\n");
     }

     static void DisplayContact()
     {
        if(Contacts.Count == 0)
		{
            Console.WriteLine("ContactBook is Empty");
            Console.WriteLine("\n ");
		}
		else
		{
            foreach(ContactBook Contact in Contacts)
            {
                 Console.WriteLine("FirstName : " + Contact.FirstName);
                 Console.WriteLine("PhoneNumber : " + Contact.PhoneNumber);
                 Console.WriteLine("Location : " + Contact.Location);
                 Console.WriteLine("\n");
                 Console.ReadKey();
            }
        }
     }

     static void DeleteContact()
     {
        Console.WriteLine("Enter the PhoneNumber to Search");
        long lPhoneNumber = Convert.ToInt64(Console.ReadLine());
		bool bContactExist = false;

		foreach(ContactBook Contact in Contacts)
        {
            if(Contact.PhoneNumber == lPhoneNumber)
            {
                Contacts.Remove(Contact);
                bContactExist = true;
                break;
            }
        }
        if(bContactExist)
        {           
            Console.WriteLine("Contact Deleted");
            Console.WriteLine("\n");
            Console.ReadKey();
        }
		else
		{
              Console.WriteLine("No Records found in the ContactBook");
              Console.WriteLine("\n");
        }
        DisplayContact();
     }

     static void EditContact()
     {
        Console.WriteLine("Enter the PhoneNumber to find");
        long lPhoneNumber = Convert.ToInt64(Console.ReadLine());
        ContactBook Contactbook = new ContactBook();
        bool bContactExist = false;
        foreach(ContactBook Contact in Contacts)
        {
            if(Contact.PhoneNumber == lPhoneNumber )
            {
                Contactbook = Contact;
                bContactExist = true;
                break;
            }
        }
        if(bContactExist)
        {
            Console.WriteLine("\n For this PhoneNumber What do you want to edit");          
                Console.WriteLine("1: Edit FirstName");
                Console.WriteLine("2: Edit PhoneNumber");
                Console.WriteLine("3: Edit Location");
                Console.WriteLine("4: Exit");
                Console.WriteLine("Enter your Choice");

                int nChoice = int.Parse(Console.ReadLine());
                switch(nChoice)
                {
                    case 1:
                        Console.WriteLine("Enter the new FirstName");
                        Contactbook.FirstName = Console.ReadLine();
                        break;

                    case 2:
                        Console.WriteLine("Enter the new PhoneNumber");
                        Contactbook.PhoneNumber = Convert.ToInt64(Console.ReadLine());
                        break;

                    case 3:
                        Console.WriteLine("Enter the new Location");
                        Contactbook.Location = Console.ReadLine();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice. Try again...");
                        break;
                }            
        }
		else
		{
            Console.WriteLine("No Records found. Check the PhoneNumber");
            Console.WriteLine("\n");
        }     
     }

     static void SearchContact()
     {
           Console.WriteLine("Enter the PhoneNumber to Search");
           long lPhoneNumber = Convert.ToInt64(Console.ReadLine());
           ContactBook Contactbook = new ContactBook();          

           foreach(ContactBook Contact in Contacts)
           {
               if(Contact.PhoneNumber == lPhoneNumber)
               {
                   Contactbook = Contact;                   
                   break;
               }
           }
           if(Contactbook != null)
           {
              Console.WriteLine("FirstName : " + Contactbook.FirstName);
              Console.WriteLine("PhoneNumber : " + Contactbook.PhoneNumber);
              Console.WriteLine("Location : " + Contactbook.Location);
              Console.WriteLine("\n");
              //DisplayContact();
           }
		   else
		   {
            Console.WriteLine("No Record Found.");
            Console.WriteLine("\n");
		   }
    
    }    
}



