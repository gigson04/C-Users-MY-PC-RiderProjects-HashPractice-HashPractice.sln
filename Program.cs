using System;
using System.Collections;
using System.Runtime.InteropServices.JavaScript;

namespace HashPractice;

internal class Employee
{
    
        public int ID;
        public string Name;
        public string Address;
        public string ContactNumber;
        
        public Employee(int id, string name, string address, string contactNumber)
        {
            ID = id;
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable EmployeeTable = new Hashtable();
            
            // Add an employee to the table
            EmployeeTable.Add(123, new Employee(123,"Tricia","123 Main St","555-123-4567"));
            EmployeeTable.Add(456, new Employee(456,"John","456 Main St","555-456-7890"));
            EmployeeTable.Add(789, new Employee(789,"Jane","789 Main St","555-789-0123"));
            
            string choice = "Y";
            
             Console.WriteLine("Employee Information:");

             while (choice.ToUpper() == "Y")
             {
                 Console.WriteLine("Here are the Avilable Employee IDs: ");
                 Console.WriteLine("Here are the Id you can search for : ");
                 
                 // Display available employee IDs
                 foreach (int id in EmployeeTable.Keys)
                 {
                     Console.WriteLine(id);
                 }
                 // Prompt for lookup ID
                 Console.WriteLine();
                 Console.WriteLine("Enter Look up ID: ");
                 int lookupID;
                 if (!int.TryParse(Console.ReadLine(), out lookupID))
                 {
                     Console.WriteLine("Invalid ID entered. Please enter a valid integer.");
                     continue;
                 }
               Console.WriteLine();
               // Display employee information
               if (EmployeeTable.ContainsKey(lookupID))
               {
                   Employee employee = (Employee)EmployeeTable[lookupID];
                   Console.WriteLine("Here is the detailed information:");
                   Console.WriteLine("Employee ID:    " + employee.ID);
                   Console.WriteLine("Name:           " + employee.Name);
                   Console.WriteLine("Address:        " + employee.Address);
                   Console.WriteLine("Contact no:     " + employee.ContactNumber);
               }
               else
               {
                   Console.WriteLine("Employee not found with ID: " + lookupID);
               }
               
               Console.WriteLine();
               Console.WriteLine("Do you want to look up another employee? (Y/N): ");
               choice = Console.ReadLine();                     
                 
                 
                 
                 


             }
        }
    }
    
    
   
