using System;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        Stack stack;
        
        public Form1()
        {
            InitializeComponent();
            stack = new Stack();
    }

        private void pushButton_Click(object sender, EventArgs e)
        {
            stack.Push(Convert.ToInt32(elementTextBox.Text));
            elementsTextBox.Text = stack.Print();
            //int counter = 0;
            //while (true)
            //{
            //    stack.Push(int.MaxValue);
            //    counter++;
            //    elementsTextBox.AppendText(Convert.ToString(counter));
            //}
            textTop.Text = stack.PrintTop();
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            stack.Pop();
            elementsTextBox.Text = stack.Print();
            textTop.Text = stack.PrintTop();
        }
    }

    public class Stack
    {
        private int[] items;
        private int counter;
        const int n = 10;

        public Stack()
        {
            items = new int[n];
            counter = 0;
        }
        //public Stack(int stackCount)
        //{
        //    items = new int[stackCount];
        //    counter = 0;
        //}

        //public Stack(int[] stackArray)
        //{
        //    items = stackArray;
        //    counter = stackArray.Length;
        //}

        public bool IsEmpty()
        {
            return counter == 0;
        }

        public void Push(int item)
        {
            if (counter == items.Length)
            {
                Resize(items.Length + 10);
                MessageBox.Show("Стек переполнен, его размер увеличен");
            }

            items[counter++] = item;
        }

        private void Resize(int size)
        {
            int[] tempItems = new int[size];
            for (int i = 0; i < counter; ++i)
                tempItems[i] = items[i];
            items = tempItems;
        }

        public int Pop()
        {
            if (IsEmpty())
            {
                MessageBox.Show("Стек пуст");
                
                return 0;
            }
            int item = items[--counter];
            if (0 < counter && counter < items.Length - 10)
                Resize(items.Length - 10);
            return item;
            
        }

        public string Print()
        {
            if (counter == 0)
                return "";
            int i;
            string s = "";
            for (i = 0; i < counter - 1; ++i)
                s += Convert.ToString(items[i]) + ", ";
            s += Convert.ToString(items[i]);
            return s;
        }

        public string PrintTop()
        {
            int number = counter - 1;
            return Convert.ToString(items[number]);
        }
    }
}
