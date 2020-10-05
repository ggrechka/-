
using System;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        OneStack stack = new OneStack();
        OneStack stackin = new OneStack();
        StackEdition stackEdition = new StackEdition();

        public Form1()
        {
            InitializeComponent();
            stack = new OneStack();
            stackEdition = new StackEdition();
        }

        private void pushButton_Click(object sender, EventArgs e)
        {
            try
            {
                //добавление элемента в стек
                stack.DoPush(Convert.ToInt32(elementTextBox.Text));
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
            catch
            {
                //доработать исключение при вводе пустой строки
            }

            //печать элементов
            elementsTextBox.Text = stack.Print();
            textTop.Text = stack.PrintTop();

        }

        private void popButton_Click(object sender, EventArgs e)
        {
            //удаление элемента и печать стека
            stack.DoPop();
            elementsTextBox.Text = stack.Print();

            textTop.Text = stack.PrintTop();
        }

        private void PushBottom_Click(object sender, EventArgs e)
        {
            //добавление снизу
            try
            {
                stackEdition.IsFullBottom();
                stackEdition.bot++;
                stackEdition.Push(Convert.ToInt32(TextS2.Text), stackEdition.bot);

            }
            catch (IndexOutOfRangeException exxx)
            {

                DialogResult results = MessageBox.Show(
                       "Стек переполнен. Хотите увеличить его размер на 10?",
                       "Предупреждение",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning
                   );
                if (results == DialogResult.Yes)
                    stackEdition.Resize(stackEdition.items.Length + 10);
            }
            //печать элементов
            textmodstack.Text = stackEdition.PrintStackEdition();


        }

        private void PopBottom_Click(object sender, EventArgs e)
        {
            //удаление снизу
            if (stackEdition.IsEmptyBot())
            {
                MessageBox.Show(
                       "Снизу стек пуст",
                       "Предупреждение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                   );

            }
            else
            {
                stack.Pop(stackEdition, stackEdition.bot);
                stackEdition.bot--;
            }

            textmodstack.Text = stackEdition.PrintStackEdition();
        }

        private void PopTop_Click(object sender, EventArgs e)
        {
            if (stackEdition.IsEmptyTop())
            {
                MessageBox.Show(
                       "Сверху стек пуст",
                       "Предупреждение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                   );
               
            }
            else
            {
                stack.Pop(stackEdition, stackEdition.top);
                stackEdition.top++;
            }

            textmodstack.Text = stackEdition.PrintStackEdition();

        }

        private void PushPop_Click(object sender, EventArgs e)
        {
            try
            {
                stackEdition.IsFullBottom();
                stackEdition.top--;
                stackEdition.Push(Convert.ToInt32(TextS2.Text), stackEdition.top);
                
            }
            catch (IndexOutOfRangeException exxx)
            {

                DialogResult results = MessageBox.Show(
                       "Стек переполнен. Хотите увеличить его размер на 10?",
                       "Предупреждение",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning
                   );
                if (results == DialogResult.Yes)
                    stackEdition.Resize(stackEdition.items.Length + 10);
            }
            //печать элементов
            textmodstack.Text = stackEdition.PrintStackEdition();
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


        public class OneStack
        {
            public int[] items;
            public int top;
            public int n = 10;

            public OneStack()
            {
                items = new int[n];
                for (int i = 0; i < n; i++)
                {
                    items[i] = 0;
                }
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
            public void Push(int item, int top)
            {
                items[top] = item;
            }
            public void DoPush(int item)
            {
                IsFull();
                Push(item,this.top);
                this.top++;
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
            public void DoPop()
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
                Pop(this,this.top);
                this.top--;
            }

            public void Pop(OneStack stack,int top)
            {
                stack.items[top] = 0;
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

            //public void Inversion(Stack stackin)
            //{
            //    int i, j;
            //    if (this.top > n)
            //        stackin.ResizeTop(stackin.items.Length + 10);
            //    for (i = this.top - 1, j = 0; i > -1; i--, j++)

            //        stackin.items[j] = this.items[i];
            //    stackin.top = this.top;

            //}

        }

        public class StackEdition : OneStack
        {
            public int bot = -1;

            public StackEdition()
            {
                this.n = 10;
                this.items = new int[n];
                this.top = this.n;
            }

            public bool IsEmptyBot()
            {
                return (bot==-1);
            }

            public bool IsEmptyTop()
            {
                return (this.top == n);
            }

            public void IsFullBottom()
            {
                if( Math.Abs(this.top - bot) == 1)
                    throw new IndexOutOfRangeException(); 
            }

            public void PushBottom(int item)
            {
                
                {
                    MessageBox.Show("Стек переполнен");
                }

                items[++bot] = item;
            }

            public void PopBottom()
            {
                if (IsEmptyBot())
                {
                    MessageBox.Show(
                        "Снизу стек пуст",
                        "Предупреждение",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
                bot--;
            }

           

            public void Resize(int size)
            {
                int[] tempItems = new int[size];
                for (int i = 0; i <= bot; i++)
                    tempItems[i] = this.items[i];
                for (int i =this.n-1+10,j=this.n-1; j >=this.top; i--,j--)
                {
                    tempItems[i] = this.items[j];
                }
                this.items = tempItems;
                this.n += 10;
                this.top += 10;
            }

            public string PrintStackEdition()
            {
                if (top == n && bot == -1)
                    return "Стек пуст";
                else
                {
                    int i;
                    string s = "";
                    for (i = 0; i < this.items.Length-1; i++)
                        s += Convert.ToString(items[i]) + ", ";
                    s += Convert.ToString(items[i]);
                    return s;
                }
            }
        }

       
    }
}
