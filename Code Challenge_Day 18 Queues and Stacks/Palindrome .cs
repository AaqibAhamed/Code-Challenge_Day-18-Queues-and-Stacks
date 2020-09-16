using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenge_Day_18_Queues_and_Stacks
{
    public class Palindrome
    {
        public Stack<char> charStack = new Stack<char>();

        public Queue<char> charQueue = new Queue<char>();

        public char DequeueCharacter()
        {
            return charQueue.Dequeue();
        }

        public char PopCharacter()
        {
            return charStack.Pop();
        }

        public void EnqueueCharacter(char c)
        {
            charQueue.Enqueue(c);
        }

        public void PushCharacter(char c)
        {
            charStack.Push(c);
        }
    }
}
