using LIB;
using System.Dynamic;
using System.Net;
using System.Xml.Serialization;

namespace EmployeeManagement
{
    
    internal class Program
    {

        Employee[] employees;
        public Program()
        {
            employees = new Employee[2];
        }

       
        void SelectionMenu()
        {
            int Menu = 0;
            Console.WriteLine("Enter 1 To print all Employee :");
            Console.WriteLine("Enter 2 To Add :");
            Console.WriteLine("Enter 3 To Find Employee");
            Console.WriteLine("Enter 4 To Edit Employee");
            Console.WriteLine("Enter 5 To Delete Employee");
            Console.WriteLine("---------------------");
            do
            {
                
                Console.WriteLine("Enter the Menu :");
                Menu = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("---------------------");
                switch (Menu)
                {
                    case 1:
                        GetAllEmployee();
                        break;
                    case 2:
                        AddEmployee();
                        break;
                    case 3:
                        GetEmployee();
                        break;
                    case 4:
                        EditEmployee();
                        break;
                    case 5:
                        DeleteEmployee();
                        break;
                    default:
                        break;
                }

            } while (Menu != 0);
        }

        void GetAllEmployee()
        {

            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                    PrintEmployee(employees[i]);

            }
        }


        void AddEmployee()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] == null)
                {
                    employees[i] = CreateEmployee(i);
                    Console.WriteLine("---------------------");
                }
            }
        }
        void GetEmployee()
        {
            int ID = GetID();
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Id == ID)
                {
                    PrintEmployee(employees[i]);
                }
            }
        }

        void EditEmployee()
        {
            int ID = GetID();
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null && employees[i].Id == ID)
                {
                    Console.WriteLine("Editing details for Employee with ID " + ID);
                    Console.Write("Enter new name: ");
                    string newName = Console.ReadLine();
                    Console.Write("Enter new DOB: ");
                    DateTime newDateOfBirth = Convert.ToDateTime(Console.ReadLine());
                    employees[i].Name = newName;
                    employees[i].DateOfBirth = newDateOfBirth;
                    Console.WriteLine("update Completed");
                }
            }
            Console.WriteLine("---------------------");
        }
        void DeleteEmployee()
        {
            int ID = GetID();
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null && employees[i].Id == ID)
                {
                    employees[i] = null;
                }
            }
            Console.WriteLine("---------------------");
        }

        
        static void Main(string[] args)
        {
            Program program = new Program();
            program.SelectionMenu();

        }
        Employee CreateEmployee(int id)
        {
            Employee employee = new Employee();
            employee.Id = 100 + id;
            employee.BuildEmployeeFromConsole();
            return employee;
        }
        void PrintEmployee(Employee employee)
        {
            employee.PrintEmployeeDetails();
            Console.WriteLine("---------------------");
        }

        int GetID()
        {
            Console.Write("Enter the ID : ");
            int ID = Convert.ToInt32(Console.ReadLine());
            return ID;
        }
    }

}
