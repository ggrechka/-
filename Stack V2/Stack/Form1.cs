//блочная арифметика

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        Stack stack = new Stack();
        StackEdition stackEdition = new StackEdition();

        public Form1()
        {
            InitializeComponent();
            stack = new Stack();
            stackEdition = new StackEdition();
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            try
            {
                //добавление элемента в стек
                stack.IsFull();
                stack.PushTop(Convert.ToInt32(elementTextBox.Text));
            }
            catch (IndexOutOfRangeException exx)
            {

                DialogResult result = MessageBox.Show(
                       "Стек переполнен. Увеличить его размер на 10?",
                       "Предупреждение",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning
                   );
                if (result == DialogResult.Yes)
                    stack.ResizeTop(stack.items.Length + 10);
            }

            //печать элементов
            elementsTextBox.Text = stack.Print();
            textTop.Text = stack.PrintTop();

            //печать инверсии стека
            stackEdition.Inversion(stack);
            textIn.Text = stackEdition.Print();
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            //удаление элемента и печать стека
            stack.PopTop();
            elementsTextBox.Text = stack.Print();

            textTop.Text = stack.PrintTop();

            //инверсия и печать
            stackEdition.Inversion(stack);
            textIn.Text = stackEdition.Print();
        }

        private void PushBottom_Click(object sender, EventArgs e)
        {

        }

        private void PopBottom_Click(object sender, EventArgs e)
        {

        }

        private void buttonSearchMin_Click(object sender, EventArgs e)
        {
            textMin.Text = stack.SearchMin();
        }

        private void buttonSearchMax_Click(object sender, EventArgs e)
        {
            textMax.Text = stack.SearchMax();
        }

        private void buttonSearchSum_Click(object sender, EventArgs e)
        {
            textSum.Text = Convert.ToString(stack.SearchSum());
        }

        private void buttonSearchMulti_Click(object sender, EventArgs e)
        {
            textMulti.Text = Convert.ToString(stack.SearchMulti());
        }


        public class Stack
        {
            public int[] items;
            public int top;
            public int n = 10;

            public Stack()
            {
                items = new int[n];
                top = 0;
            }

            //проверка на пустоту
            public bool IsEmpty()
            {
                return top == 0;
            }

            //проверка на переполнение
            public void IsFull()
            {
                if (top == n)
                    throw new IndexOutOfRangeException();
 
            }

            //добавление элемента
            public void PushTop(int item)
            {
                items[top++] = item;
            }
            //изменение размера стека
            public void ResizeTop(int size)
            {
                int[] tempItems = new int[size];
                for (int i = 0; i < top; ++i)
                    tempItems[i] = items[i];
                items = tempItems;
                n += 10;
            }
            //удаление элемента
            public void PopTop()
            {
                if (IsEmpty())
                {
                    MessageBox.Show(
                        "Стек пуст",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
                int item = items[--top];
                if (0 < top && top < items.Length - 10)
                    ResizeTop(items.Length - 10);
            }
            //возвращение строкового вида стека
            public string Print()
            {
                if (top == 0)
                    return "";
                int i;
                string s = "";
                for (i = 0; i < top - 1; ++i)
                    s += Convert.ToString(items[i]) + ", ";
                s += Convert.ToString(items[i]);
                return s;
            }
            // возврат верхушки
            public string PrintTop()
            {
                if (top == 0)
                    return "";
                int number = top - 1;
                return Convert.ToString(items[number]);
            }
            //поиск минимума
            public string SearchMin()
            {
                if (top == 0)
                    return "Не найдено";
                int i, min = items[0];
                for (i = 1; i < top; ++i)
                    if (items[i] < min)
                        min = items[i];
                return Convert.ToString(min);
            }
            //поиск максимума
            public string SearchMax()
            {
                if (top == 0)
                    return "Не найдено";
                int i, max = items[0];
                for (i = 1; i < top; ++i)
                    if (items[i] > max)
                        max = items[i];
                return Convert.ToString(max);
            }
            //подсчёт суммы
            public Int64 SearchSum()
            {
                int i;
                Int64 sum = 0;
                for (i = 0; i < top; ++i)
                    sum += items[i];
                return sum;
            }
            //подсчёт произведения
            public int SearchMulti()
            {
                int i, p = 1;
                for (i = 0; i < top; ++i)
                    p *= items[i];
                return p;
            }
           
        }

        public class StackEdition : Stack
        {
            public int bot = 0;


            public bool IsEmptyBottom()
            {
                return bot==0;
            }

            public void PushBottom(int item)
            {
                if (bot - top == 1)
                {
                    MessageBox.Show("Стек переполнен");
                }

                items[++bot] = item;
            }

            public void PopBottom()
            {
                if (IsEmptyBottom())
                {
                    MessageBox.Show(
                        "Стек пуст",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
                bot--;
            }

            public void ResizeBottom(int size)
            {
                int[] tempItems = new int[size];
                for (int i = 0; i < top; ++i)
                    tempItems[i] = items[i];
                items = tempItems;
            }

            public void Inversion(Stack stack)
            {
                int i, j;
                if (stack.top > n)
                    this.ResizeTop(this.items.Length+10);
                for (i = stack.top - 1, j = 0; i > -1; i--, j++)

                    this.items[j] = stack.items[i];
                this.top = stack.top;

            }
        }

       
    }
}
