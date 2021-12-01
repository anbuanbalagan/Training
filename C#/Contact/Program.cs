using System;
using System.Collections;
class program {
  public static void Main() {
    Hashtable phoneBook = new Hashtable();

    while (true) {
      
      Console.WriteLine("1:Add Contact");
      Console.WriteLine("2:Search");
            Console.WriteLine("3:Edit");
      Console.WriteLine("4:Delete");
      Console.WriteLine("5:Exit");
      Console.WriteLine("\n\nEnter choice: ");
      int choice = Convert.ToInt32(Console.ReadLine());

      switch (choice) {
      case 1:
        {
          long number = 0;
          string name = "";

          Console.Write("Enter your name : ");
          name = Console.ReadLine();

          Console.Write("Enter your phone number : ");
          number = Convert.ToInt64(Console.ReadLine());

          phoneBook.Add(name, number);
        }
        break;
      case 2:
        {
          long number = 0;
          string name = "";

          Console.Write("Enter your name : ");
          name = Console.ReadLine();

          if (phoneBook[name] == null) {
            Console.WriteLine("Given name is not found in phonebook");
          }
          else {
            number = Convert.ToInt64(phoneBook[name]);
            Console.WriteLine("Name: " + name + ", phone number: " + number);
          }
        }
        break;
      case 3:
        {
          goto OUT;
        }
        break;
      default:
        {
          Console.WriteLine("\nYou have entered wrong choice");
        }
        break;
      }
    }

    OUT:
    Console.WriteLine("\nThankyou for using phonebook");
  }
}