using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHolder{

    private int maxSize;
    private Item[] _stack;
    private int top;

    public ItemHolder(int s)
    {
        maxSize = s;
        _stack = new Item[maxSize];
        top = -1;
    }
    public void Push(Item item)
    {
        _stack[++top] = item;
    }
    public Item Pop()
    {
        return _stack[top--];
    }
    public Item Peek()
    {
        return _stack[top];
    }
    public bool IsEmpty()
    {
        return (top == -1);
    }
    public bool IsFull()
    {
        return (top == maxSize - 1);
    }

    public int GetSize()
    {

        return top + 1;

    }

}
