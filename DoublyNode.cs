using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoHomework2
{
    internal sealed class DoublyNode
    {
        internal int Value { get; set; }

        internal DoublyNode? NextNode { get; set; }

        internal DoublyNode? PrevNode { get; set; }

        internal uint Index { get; set; }

        private static uint LastUsed = 0;

        public DoublyNode(int value)
        {
            Value = value;

            Index = LastUsed;
            LastUsed++;
        }
    }
}
