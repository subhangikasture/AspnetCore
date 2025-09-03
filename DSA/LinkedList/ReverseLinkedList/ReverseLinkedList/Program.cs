// See https://aka.ms/new-console-template for more information
using ReverseLinkedList;

Console.WriteLine("Hello, World!");
Node l1 = new Node(1);
l1.prev = null;
Node l2 = new Node(2);
l1.next = l2;
l2.prev = l1;
Node l3 = new Node(3);
l2.next = l3;
l3.prev = l2;
l3.next = null;

for(Node i = l1; i != null; i = i.next)
{
    Console.WriteLine(i.data);
}
//Reverse doubly linked list 
//Assisgned l1 to head 
Node head = l1;
Node curr = head;
Node t = null;

while (head != null)
{    t = head.prev;
    head.prev = head.next;
    head.next = t;
    head = head.prev;
}
for (Node i = t.prev; i != null; i = i.next)
{
    Console.WriteLine(i.data);
}
Console.ReadLine();