using System.Reflection.Metadata.Ecma335;

class Node
{
  public string data { get; set; }
  public Node next { get; set; }
}

class LinkedListOperations

{
  /// <summary>
  /// 
  /// </summary>
  /// <param name="head"></param>
  /// <param name="data"></param>
  /// <returns></returns>
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


/// <summary>
/// 
/// </summary>
/// <param name="head"></param>
/// <returns></returns>
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

/// <summary>
/// 
/// </summary>
/// <param name="head"></param>
/// <param name="dataToBeDeleted"></param>
/// <returns></returns>
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


/// <summary>
/// This method adds elemt to the linked list at given index
/// </summary>
/// <param name="head"></param>
/// <param name="dataToBeAdded"></param>
/// <param name="index"></param>
/// <returns></returns>
    internal bool AddElementAtGivenIndex(Node head,string dataToBeAdded, int index)
    {
        //traverse to reach the node whose index has been passed
        int currentPostion=0;
        while(currentPostion!=index-1)
        {
          if(head.next==null)   //If we reach end of the node.
          return false;

          Node previousNode= head;
          head=head.next;
          currentPostion++;
           if(currentPostion==index-1)
           {
            Node n=new Node();
            n.next=previousNode.next;
            n.data=dataToBeAdded;
            previousNode.next=n;
            return true;
           }
        }
       

      return false;
    }

/// <summary>
/// This method deletes an elemet form given linked list at specified position.
/// </summary>
/// <param name="head"></param>
/// <param name="index"></param>
/// <returns></returns>
    internal bool RemoveElementAtGivenIndex(Node head,int  index)
    {
       //traverse to reach the node whose index has been passed
        int currentPostion=0;
        while(currentPostion!=index-1)
        {
          if(head.next==null)   //If we reach end of the node.
          return false;

          Node previousNode= head;
          head=head.next;
          currentPostion++;
           if(currentPostion==index-1)
           {
            Node n=new Node();
            previousNode.next= head.next;
            head=null;
            return true;
           }
        }
        return false;
    }

}