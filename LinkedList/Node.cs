class Node
{
  public string data { get; set; }
  public Node next { get; set; }
}

class LinkedListOperations
{
    internal Node AddElementToLinkedList(Node head, string data)
    {
      if (head.data == null && head.next == null)
      {
        //if it is empty linked list
        head.data = data;
        Console.WriteLine("Element added to the node is " + data);
      }
      else if (head.data != null && head.next == null)   //Add element to the last
      {
        Node n = new Node() { data = data, next = null };
        head.next = n;
      }
      else
      {
        AddElementToLinkedList(head.next, data);   //if not last element, increment and go to the next element
      }
      return head;

    }

    internal bool PrintAllEmenents(Node head)
    {
      if (head.next == null)
      {
        Console.WriteLine(head.data);
        return true;
      }
      else
      {
        Console.WriteLine(head.data);
        PrintAllEmenents(head.next);    //increment one and go on
      }
      return false;
    }

    internal bool DeleteGivenElementFromArray(Node head, string dataToBeDeleted)
  {

    if (head.data == dataToBeDeleted)
    {

      //if the first element is containing the element to be deleted
      if (head.next == null) //if head.next is null, this means there is only one element 
      {
        head.data = string.Empty;
        return true;
      }
      else{
        head=head.next;
        return true;
      }
    }
    Node currentElement = head;
    while (currentElement.next != null)
    {
      Node previousElement=currentElement;
      currentElement = currentElement.next;
      if (currentElement.data == dataToBeDeleted)
      {
        previousElement.next=currentElement.next;
        currentElement=null;
        return true;
      }
    }
    //if traveresd and the element is not found 
    return false;
  }
}