using System;
using System.Collections.Generic;

namespace Code_Challenge_Day_18_Queues_and_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();

            // create the Solution class object p.
            Program obj = new Program();

            // push/enqueue all the characters of string s to stack.
            foreach (char c in s)
            {
                obj.pushCharacter(c);
                obj.enqueueCharacter(c);
            }

            bool isPalindrome = true;

            // pop the top character from stack.
            // dequeue the first character from queue.
            // compare both the characters.
            for (int i = 0; i < s.Length / 2; i++)
            {
                if (obj.popCharacter() != obj.dequeueCharacter())
                {
                    isPalindrome = false;

                    break;
                }
            }

            // finally print whether string s is palindrome or not.
            if (isPalindrome)
            {
                Console.Write("The word, {0}, is a palindrome.", s);
            }
            else
            {
                Console.Write("The word, {0}, is not a palindrome.", s);
            }

            Console.WriteLine("ASasasxcdsv aga");

            Console.ReadLine();
        }

        public Stack<char> charStack = new Stack<char>();

        public Queue<char> charQueue = new Queue<char>();

        private object dequeueCharacter()
        {
          return charQueue.Dequeue();
        }

        private object popCharacter()
        {
            return charStack.Pop();
        }

        private void enqueueCharacter(char c)
        {
            charQueue.Enqueue(c);
        }

        private void pushCharacter(char c)
        {
            charStack.Push(c);
        }
    }
}
