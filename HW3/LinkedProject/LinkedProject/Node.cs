using System;

public class Node
{ 
    public object data;
    public Node next;

	public Node()//this is the creation of the node
	{
    data = null;//carries but two item, the information, and whats next.
    next = null;
 	}

public Node(Object data, Node next)
{
    this.data = data;//this is the public node for all
    this.next = next;
}
}
