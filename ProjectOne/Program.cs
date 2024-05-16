using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;
namespace ProjectOne
{
    class LinkedListNode
    {
        public int data;
        public LinkedListNode next;

        public LinkedListNode(int value)
        {
            data = value;
            next = null;
        }
    }
    class LinkedList
    {
        int count = 0;
        LinkedListNode head;
        LinkedListNode tail;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void AddNodeToFront( int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node;
            count++;
        }
        public void AddNodeToEnd(int data)
        {
            LinkedListNode tail = new LinkedListNode(data);
            if(head != null)
            {
                LinkedListNode runner = head;
                while (runner.next != null) 
                {
                    runner = runner.next;
                }
                runner.next = tail;
                runner = runner.next;
                count++;
            }
        }
        public void DeleteNodeFromFront()
        {
            LinkedListNode temp = head;
            head = temp.next;
            Console.WriteLine("Current head is node 2-> " + head.data);
        }
        public void DeleteNodeFromEnd()
        {
            LinkedListNode temp = head;
            while(temp.next.next !=null)
            {
                temp = temp.next;
            }
            tail = temp.next;
            Console.WriteLine("Tail Current position--> "+tail.data);
            count--;
        }

        public void PrintList()
        {
            LinkedListNode runner = head;
            while(runner!=null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
            
        }
    }
    class MainClass()
    {
        static void Main(string[] args)
        {

            LinkedList linkedlist = new LinkedList();

            linkedlist.AddNodeToFront(5);
            linkedlist.AddNodeToFront(10);
            linkedlist.AddNodeToFront(20);
            linkedlist.AddNodeToFront(30);
            linkedlist.AddNodeToFront(40);
            linkedlist.AddNodeToFront(50);
            

            linkedlist.AddNodeToEnd(2);
            linkedlist.AddNodeToEnd(26);
            linkedlist.AddNodeToEnd(1111);

            linkedlist.DeleteNodeFromFront();

            linkedlist.DeleteNodeFromEnd();

            linkedlist.PrintList();


            // Abstraction 
            /*
            RegularTicket regular = new RegularTicket();
            VipTicket vip = new VipTicket();
            StudentTicket student = new StudentTicket();

            regular.TicketID = "00001";
            regular.SeatNumber = 101;
            regular.CalculatePrice();
            regular.PrintTicket();
            Console.WriteLine("");

            vip.TicketID = "00002";
            vip.SeatNumber = 102;
            vip.CalculatePrice();
            vip.PrintTicket();
            Console.WriteLine("");

            student.TicketID = "00003";
            student.SeatNumber = 103;
            student.CalculatePrice();
            student.PrintTicket();
            */



            // Encapuslation  
            /*
            Encapsulation encapsulate = new Encapsulation();
            encapsulate.SetName("Salman");
            encapsulate.SetAge(20);
            Console.WriteLine(encapsulate.GetName());
            Console.WriteLine(encapsulate.GetAge());
            encapsulate.DisplayDetails();
            */
            //................................................................................................................


            // While-Loop
            /* Console.WriteLine("Hello!");
             bool validInput = false;
             while (!validInput)
             {
                 Console.WriteLine("Please enter your password");
                 String input = Console.ReadLine();
                 if(input == "yes")
                 {
                     validInput = true;
                     Console.WriteLine("Welcome Muhammad Faizan!");
                 }
                 else
                 {
                     Console.WriteLine("Invalid Password. Please Enter Password Again");
                 }
             }*/
            //..............................................................................................................


            // Switch Statement

            /*  Console.WriteLine("Are you member of Tech-Collegues?");
              Console.WriteLine("Type Yes/No");
              string input = Console.ReadLine();

              switch(input)
              {
                  case "yes":
                      Console.WriteLine("Me too!");
                      break;
                  case "no":
                      Console.WriteLine("OK!");
                      break;
                  default:
                      break;

              } */
            //..............................................................................................................


            // if/else Statement

            /* bool isActive = true;
             Console.WriteLine(" Are you Active or Not ? Type Yes/No");

             string input = Console.ReadLine();

             if(input == "yes")
             {
                 Console.WriteLine("YOU ARE ACTIVE");
             }
             else if(input == "no")
             {
                 Console.WriteLine("You are InActive");
             }
             else
             {
                 Console.WriteLine("Invalid Input");
             }*/
            //..............................................................................................................


            // Arrays 

            /* int[] myArrayOne = { 2, 4, 6, 8 };
             int[] myArrayTwo = new int[4];

             for(int i = 0;i<=myArrayOne.Length-1;i++)
             {
                 Console.WriteLine(myArrayOne[i]);
            }
             // Console.WriteLine(myArrayOne.Length);
             myArrayOne.CopyTo(myArrayTwo, 0);
             for(int i = 0; i<myArrayTwo.Length; i++)
             {
                 Console.WriteLine(myArrayTwo[i]);
             }*/
            //..............................................................................................................



            // List in C#

            /* List<string> MyList = new List<string> {"Faizan", "Salman", "Usman", "Rizwan", "Umar" };
             for (int i = 0; i < MyList.Count; i++)
             {
                 Console.WriteLine(MyList[i]);
             }

             Console.WriteLine("Adding Arslan to MyList");
             MyList.Add("Arslan");

             for (int i = 0; i < MyList.Count; i++)
             {
                 Console.WriteLine(MyList[i]);
             }

             Console.WriteLine("Removing salman from MyList");
             MyList.Remove("Salman");
             for (int i = 0; i < MyList.Count; i++)
             {
                 Console.WriteLine(MyList[i]);
             }*/
            //..............................................................................................................


            // Methods Parameters

            /* Console.WriteLine("Enter Numbers you want Add");
             Console.WriteLine("Enter First Number..");
             int NumberOne= Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter Second Number..");
             int NumberTwo = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine(AddNumber(NumberOne, NumberTwo));


             static int AddNumber(int NumOne, int NumTwo)
             {
                 return NumOne + NumTwo; 

             }*/
            //..............................................................................................................



            Console.ReadLine(); 

        }
    }
}
