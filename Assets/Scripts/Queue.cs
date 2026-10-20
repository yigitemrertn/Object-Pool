public class Queue
{
    private Node head;
    private Node tail;

    private int len = 0;

    public void Enqueue(Arrow data)
    {
        Node newNode = new Node();
        newNode.data = data;
        newNode.next = null;

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.next = newNode;
            tail = newNode;
        }

        len++;
    }

    public Arrow Dequeue()
    {
        if (head == null)
        {
            return null;
        }

        Arrow data = head.data;
        head = head.next;

        if (head == null)
        {
            tail = null;
        }

        len--;
        return data;
    }

    public int Count
    {
        get { return len; }
    }
}

public class Node
{
    public Arrow data;
    public Node next;
}