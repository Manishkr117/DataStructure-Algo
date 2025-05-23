// See https://aka.ms/new-console-template for more information
using System.Diagnostics;









LinkedListOperations linkedListOperations = new LinkedListOperations();

Node node = new Node();
// insert at start
//insert at given index
//delete at

int choice=5;

while (choice != 0)
{

    Console.WriteLine(@"PLeas provide ur inputs \r\n Press 1 to Add elements to linked list \r\n  Press 2 to Display all the elements of the linked list \r\n   Press 3 to delete the provided element of th linked list \r\n   Press 4 to insert elemet at given position\r\n    Press 5 to delete element at given index  \r\n
Press 0 key to exit ");

var input = Console.ReadLine();
int.TryParse(input, out  choice);

    switch (choice)
    {
        case 1:
            {
                Console.WriteLine("Please enter the element to be ADDED followed by retun key");
                String dataToBAdded = Console.ReadLine();
                node = linkedListOperations.AddElementToLinkedList(node, dataToBAdded);

                break;
            }
        case 2:
            {
                linkedListOperations.PrintAllEmenents(node);
                break;
            }
        case 3:
            {
                // Press 3 to delete the provided element of th linked list 
                Console.WriteLine("PLease enter the elelemt to be deleted followed by return key");
                string? dataToBeDeleleted = Console.ReadLine();
                if (linkedListOperations.DeleteGivenElementFromArray(node, dataToBeDeleleted))
                    Console.WriteLine(dataToBeDeleleted + "  deleted successfully");
                else
                    Console.WriteLine(dataToBeDeleleted + " could not be deleted");
                break;
            }
            case 4:
            {
                //Press 4 to insert elemet at given position
                Console.WriteLine("Press enter the index followed by enter");
                string? index = Console.ReadLine();
                if(int.TryParse(index,out int positionAtWhichItem2BAdded))
                {
                    Console.WriteLine("Press enter the element to be  followed by enter");
                string? element = Console.ReadLine();
                linkedListOperations.AddElementAtGivenIndex( node, element,  positionAtWhichItem2BAdded);
                }
                else{
                    Console.WriteLine("Ypu have entered wrong index ");
                }
               
                break;
            }
            case 5:
            {
                //\r\n    Press 5 to delete element at given index  
                Console.WriteLine("Press enter the index followed by enter");
                string? index = Console.ReadLine();
                if(int.TryParse(index,out int positionAtWhichItem2BAdded))
                {
                linkedListOperations.RemoveElementAtGivenIndex( node,  positionAtWhichItem2BAdded);
                }
                else{
                    Console.WriteLine("Ypu have entered wrong index ");
                }
                break;
            }
        case 0:
            {
                return;
                break;
            }
        default:
            Console.WriteLine("Ur input is input is invalid");
            Console.WriteLine("enter 0 to exit");
            break;
    }
}
//Add element to node

//ßConsole.ReadKey();