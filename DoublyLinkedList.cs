using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoHomework2
{
    internal class DoublyLinkedList
    {
        internal DoublyNode? Head { get; set; }

        internal DoublyNode? Tail { get; set; }

        internal uint Count { get; set; }

        internal void AddNode(int value)
        {
            if (this.Tail == null)
            {
                AddNodeAtBeginning(value);
            } else
            {
                AddNodeAfter(this.Tail, value);
            }
        }

        private void AddNodeAtBeginning(int value)
        {
            DoublyNode newNode = new DoublyNode(value);

            if (this.Head == null)
            {
                this.Head = newNode;
                this.Tail = newNode;

                newNode.PrevNode = null;
                newNode.NextNode = null;
            }
            else
            {
                AddNodeBefore(this.Head, newNode.Value);
            }

            Count++;
        }

        private void AddNodeBefore(DoublyNode node, int value)
        {
            DoublyNode newNode = new DoublyNode(value);

            newNode.NextNode = node;

            if (node.PrevNode == null)
            {
                newNode.PrevNode = null;
                this.Head = newNode;
            } else
            {
                newNode.PrevNode = node.PrevNode;
                node.PrevNode.NextNode = newNode;
            }

            Count++;
        }

        internal void AddNodeAfter(DoublyNode node, int value)
        {
            DoublyNode newNode = new DoublyNode(value);

            newNode.PrevNode = node;

            if (node.NextNode == null)
            {
                node.NextNode = newNode;
                this.Tail = newNode;
            } else
            {
                newNode.NextNode = node.NextNode;
                node.NextNode.PrevNode = newNode;
            }
            node.NextNode = newNode;

            Count++;
            
        }

        internal DoublyNode? FindNode(int searchValue)
        {
            DoublyNode? head = this.Head;

            while (head != null)
            {
                if (head.Value == searchValue)
                {
                    return head;
                }

                head = head.NextNode;
            }
            return null;
        }

        internal uint GetCount()
        {
            return Count;
        }

        internal void RemoveNode(int index)
        {
            DoublyNode? node = GetNodeByIndex(index);

            RemoveNode(node);
        }

        private DoublyNode? GetNodeByIndex(int index)
        {
            DoublyNode? head = this.Head;

            while (head != null)
            {
                if (index == head.Index)
                {
                    return head;
                }

                head = head.NextNode;
            }

            return null;
        }

        internal void RemoveNode(DoublyNode node)
        {
            if (node.PrevNode == null)
            {
                this.Head = node.NextNode;
            }
            else
            {
                node.PrevNode.NextNode = node.NextNode;
            }

            if (node.NextNode == null)
            {
                this.Tail = node.PrevNode;
            }
            else
            {
                node.NextNode.PrevNode = node.PrevNode;
            }

            Count--;
        }
    }
}
