using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenge_Day_18_Queues_and_Stacks
{
    public class Palindrome
    {
        public Stack<char> charStack = new Stack<char>();

        public Queue<char> charQueue = new Queue<char>();

        public char dequeueCharacter()
        {
            return charQueue.Dequeue();
        }

        public char popCharacter()
        {
            return charStack.Pop();
        }

        public void enqueueCharacter(char c)
        {
            charQueue.Enqueue(c);
        }

        public void pushCharacter(char c)
        {
            charStack.Push(c);
        }
    }
}
