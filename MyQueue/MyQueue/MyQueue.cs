using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueue
{
    public class myQueue
    {
        private int top;
        private int get;
        private string[] buffer;
        public myQueue(int size)
        {
            buffer = new string[size];
            top = -1;
        }
        public myQueue()
        {
            buffer = new string[1000];
            top = -1;
        }
        public void Enqueue(string value)
        {
            buffer[top + 1] = value;
            top++;
            get = 0;
        }
        public string Dequeue()
        {
            string value = buffer[get];
            top--;
            get++;
            return value;
        }
        public string Peek()
        {
            string value = buffer[get];
            return value;
        }
        public int Count()
        {
            return top + 1;
        }
        public void Clear()
        {
            top = -1;
        }
    }
}
