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
            //добавление элемента в стек
            stack.Push(Convert.ToInt32(elementTextBox.Text));
            //печать элементов
            elementsTextBox.Text = stack.Print();

            //поиск минимумов-максимумов
            textTop.Text = stack.PrintTop();
            if (stack.SearchMin() == 0)
                textMin.Text = "Не найдено";
            else
                textMin.Text = Convert.ToString(stack.SearchMin());

            if (stack.SearchMax() == 0)
                textMax.Text = "Не найдено";
            else
                textMax.Text = Convert.ToString(stack.SearchMax());

            //поиск суммы и произведения
            textSum.Text = Convert.ToString(stack.SearchSum());
            textMulti.Text = Convert.ToString(stack.SearchMulti());

            //печать инверсии стека
            textBottom.Text = Convert.ToString(stack.items[stack2.bot]);
            stack.Inversion(stack2);
            textIn.Text = stack2.Print();
        }

        private void popButton_Click(object sender, EventArgs e)
        {
            //удаление элемента и печать стека
            stack.Pop();
            elementsTextBox.Text = stack.Print();
            textTop.Text = stack.PrintTop();

            //поиск минимумов-максимумов
            textTop.Text = stack.PrintTop();
            if (stack.SearchMin() == 0)
                textMin.Text = "Не найдено";
            else
                textMin.Text = Convert.ToString(stack.SearchMin());

            if (stack.SearchMax() == 0)
                textMax.Text = "Не найдено";
            else
                textMax.Text = Convert.ToString(stack.SearchMax());

            //печать суммы и произведения 
            textSum.Text = Convert.ToString(stack.SearchSum());
            textMulti.Text = Convert.ToString(stack.SearchMulti());
            
            //инверсия и печать
            textBottom.Text = Convert.ToString(stack2.bot);
            stack.Inversion(stack2);
            textIn.Text = stack2.Print();
        }




        public class Stack
        {
            public int[] items;
            public int counter;
            public const int n = 10;

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
                int number = counter - 1;
                return Convert.ToString(items[number]);
            }
            //поиск минимума
            public int SearchMin()
            {
                if (counter == 0)
                    return 0;
                int i, min = items[0];
                for (i = 1; i < counter; ++i)
                    if (items[i] < min)
                        min = items[i];
                return min;
            }
            //поиск максимума
            public int SearchMax()
            {
                if (counter == 0)
                    return 0;
                int i, max = items[0];
                for (i = 1; i < counter; ++i)
                    if (items[i] > max)
                        max = items[i];
                return max;
            }
            //подсчёт суммы
            public int SearchSum()
            {
                int i, sum = 0;
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
            public void Inversion(Stack2 stack2)
            {
                int i, j;
                if (this.counter>10) 
                    stack2.Resize(counter);
                for (i = this.counter-1, j = 0; i > -1; i--, j++)

                    stack2.items[j] = this.items[i];
                stack2.counter = this.counter;
                
                
            }
        }

        public class Stack2 : Stack
        {
            public int bot;

            public Stack2()
            {
                items = new int[n];
                counter = 0;
                bot = 0;
            }
            public int Bottom()
            {
                if (!IsEmpty())
                    return items[bot];
                return 0;
            }
        }
    }
}
