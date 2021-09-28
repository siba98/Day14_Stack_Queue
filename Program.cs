using DataStructureDemo.LinkedList1;
using DataStructureDemo.QueueUsingLinkedList;
using DataStructureDemo.StackUsingLinkedList;
using System;

namespace DataStructureDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region LinkedList

            //LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            ////list.InsertAtParticularPosition(3,36);
            //list.Display();

            //#endregion


            #region QueueUsingLinkedList

            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            //this.top = this.top.next;

            #endregion


            #region StackUsingLinkedList

            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();
            linkedListStack.Peek();
            linkedListStack.Pop();
            linkedListStack.IsEmpty();
            linkedListStack.Display();

            #endregion
        }
    }
}
