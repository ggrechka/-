//блочная арифметика

using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        Stack stack = new Stack();
        Stack2 stack2 = new Stack2();

        public Form1()
        {
            InitializeComponent();
            stack = new Stack();
            stack2 = new Stack2();
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            try
            {
                //добавление элемента в стек
                stack.Push(Convert.ToInt32(elementTextBox.Text));
            } catch (FormatException ex)
            {
                MessageBox.Show(
                    $"{ex.Message}",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                ) ;
            }
            //печать элементов
            elementsTextBox.Text = stack.Print();
            textTop.Text = stack.PrintTop();

            //дно
            textBottom.Text = stack.Bottom();

            //печать инверсии стека
            stack2.Inversion(stack);
            textIn.Text = stack2.Print();
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            //удаление элемента и печать стека
            stack.Pop();
            elementsTextBox.Text = stack.Print();

            textTop.Text = stack.PrintTop();

            textBottom.Text = stack.Bottom();


            //инверсия и печать
            stack2.Inversion(stack);
            textIn.Text = stack2.Print();
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
            public int counter;
            public const int n = 10;
            public int bot = 0;

            public Stack()
            {
                items = new int[n];
                counter = 0;
            }

            //проверка на пустоту
            public bool IsEmpty()
            {
                return counter == 0;
            }

            public string Bottom()
            {
                if (!IsEmpty())
                    return Convert.ToString(this.items[bot]);
                return "";
            }


            //добавление элемента
            public void Push(int item)
            {
                if (counter == items.Length)
                {
                    Resize(items.Length + 10);
                    MessageBox.Show("Стек переполнен, его размер увеличен");
                }

                items[counter++] = item;
            }
            //изменение размера стека
            public void Resize(int size)
            {
                int[] tempItems = new int[size];
                for (int i = 0; i < counter; ++i)
                    tempItems[i] = items[i];
                items = tempItems;
            }
            //удаление элемента
            public void Pop()
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
                int item = items[--counter];
                if (0 < counter && counter < items.Length - 10)
                    Resize(items.Length - 10);
            }
            //возвращение строкового вида стека
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
            // возврат верхушки
            public string PrintTop()
            {
                if (counter == 0)
                    return "";
                int number = counter - 1;
                return Convert.ToString(items[number]);
            }
            //поиск минимума
            public string SearchMin()
            {
                if (counter == 0)
                    return "Не найдено";
                int i, min = items[0];
                for (i = 1; i < counter; ++i)
                    if (items[i] < min)
                        min = items[i];
                return Convert.ToString(min);
            }
            //поиск максимума
            public string SearchMax()
            {
                if (counter == 0)
                    return "Не найдено";
                int i, max = items[0];
                for (i = 1; i < counter; ++i)
                    if (items[i] > max)
                        max = items[i];
                return Convert.ToString(max);
            }
            //подсчёт суммы
            public Int64 SearchSum()
            {
                int i;
                Int64 sum = 0;
                for (i = 0; i < counter; ++i)
                    sum += items[i];
                return sum;
            }
            //подсчёт произведения
            public int SearchMulti()
            {
                int i, p = 1;
                for (i = 0; i < counter; ++i)
                    p *= items[i];
                return p;
            }
            //инверсия стека
            //public void Inversion(Stack2 stack2)
            //{
            //    int i, j;
            //    if (this.counter>10) 
            //        stack2.Resize(counter);
            //    for (i = this.counter-1, j = 0; i > -1; i--, j++)

            //        stack2.items[j] = this.items[i];
            //    stack2.counter = this.counter;
                
                
            //}
        }

        public class Stack2 : Stack
        {

            public void Inversion(Stack stack)
            {
                int i, j;
                if (stack.counter > 10)
                    this.Resize(counter);
                for (i = stack.counter - 1, j = 0; i > -1; i--, j++)

                    this.items[j] = stack.items[i];
                this.counter = stack.counter;

            }
        }


    }
}
