using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace StackADT
{
    internal class IntegerStack
    {
        private int[] stack; //Array of elements
        private int size;    //maximum number of elements in stack
        private int top;     //index of top element in the stack.

        public IntegerStack(int n)  //n is the maximum size of stack.
        {
            size = n;
            stack = new int[size]; //allocate space to array of size n
            top = -1;              // No elements in the stack initially.
        }
       public bool isEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }
        public bool isFull()
        {
            if (top==size-1)
                return true;
            else 
                return false;
        }
        public void push(int element)
        {
            if (isFull())
                Console.WriteLine("Stack OverFlow!");
            else
            {
                top++;
                stack[top] = element;
            }
        }
        public int pop() 
        { 
            if(isEmpty())
            {
                Console.WriteLine("⚠ Stack underflow!");
                return -1;
            }
            else
            {
                int element = stack[top];
                top--;
                return element;
            }   
        }
        public int peek()
        {
            if (isEmpty())
            {
                Console.WriteLine("⚠ Stack is empty!");
                return -1;
            }                
            else
                return stack[top];
        }

        public void print()
        {
            if (isEmpty())
                Console.WriteLine("Stack is empty");
            else
            {
                Console.WriteLine("The elements of Stack are: ");
                for (int i = top; i >= 0; i--)                
                    Console.WriteLine(stack[i]);                
            }
        }

        public void reverse()
        {
            if (top == -1) return;

            int left = 0;
            int right = top;

            while (left < right)
            {
                int temp = stack[left];
                stack[left] = stack[right];
                stack[right] = temp;
                left++;
                right--;
            }
        }
    }
}
