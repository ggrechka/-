//checked b  вторую
using System;
using System.Windows.Forms;

namespace Stack
{
    public partial class Form1 : Form
    {
        OneStack stack = new OneStack();
        StackEdition stackEdition = new StackEdition();
        Test stacktest = new Test();


        public Form1()
        {
            InitializeComponent();
            stack = new OneStack();
            stackEdition = new StackEdition();
        }

        // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - //
        //для обычного стека


        //добавление элемента в стек
        private void pushButton_Click(object sender, EventArgs e)
        {
            try
            {
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
                MessageBox.Show(
                    "Ошибка ввода: вводите числа",
                    "Предупреждение",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning) ;
            }
           
            //печать элементов
            textStack.Text = stack.Print();
            textTop.Text = Convert.ToString(stack.PrintTop());
            textBottom.Text = Convert.ToString(stack.PrintBot());

        }


        //удаление элемента и печать стека

        private void popButton_Click(object sender, EventArgs e)
        {
            try
            {
                stack.DoPop();
                textStack.Text = stack.Print();
                textTop.Text = Convert.ToString(stack.PrintTop());
                textBottom.Text = Convert.ToString(stack.PrintBot());
            }
            catch (Exception)
            {

                MessageBox.Show(
                "Стек пуст",
                "Предупреждение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            }
        }

        //поиск макс/мин/произв/сумм в обычном стеке
        private void buttonSearchMin_Click(object sender, EventArgs e)
        {
            //звывать проверку на пустоту
            if (stack.top == 0)
                textMin.Text = "Не найдено";
            textMin.Text = Convert.ToString(stack.SearchSuperF("min"));
        }

        private void buttonSearchMax_Click(object sender, EventArgs e)
        {
            if (stack.top == 0)
                textMax.Text = "Не найдено";
            textMax.Text = Convert.ToString(stack.SearchSuperF("max"));
        }

        private void buttonSearchSum_Click(object sender, EventArgs e)
        {
            if (stack.top == 0)
                textSum.Text = "Не найдено";
            textSum.Text = Convert.ToString(stack.SearchSuperF("sum"));
        }

        private void buttonSearchMulti_Click(object sender, EventArgs e)
        {
                if (stack.top == 0)
                    textMulti.Text = "Не найдено";
                textMulti.Text = Convert.ToString(stack.SearchSuperF("multi"));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textTest.Text = stacktest.TestStack();
        }


        // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - //
        // для модифицированного стека

        private void PushBottom_Click(object sender, EventArgs e)
        {
            //добавление снизу
            try
            {
                stackEdition.DoPush(Convert.ToInt32(TextS2.Text));
            }
            catch (IndexOutOfRangeException)
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
            catch
            {
                MessageBox.Show(
                   "Ошибка ввода: вводите числа",
                   "Предупреждение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
            //печать элементов
            textmodstack.Text = stackEdition.PrintStackEdition2();                
        }
        

        private void PopBottom_Click(object sender, EventArgs e)
        {
            //удаление снизу

            try
            {
                stackEdition.DoPop();
            }
            catch (Exception qwerty)
            {
                MessageBox.Show(
                       "Снизу стек пуст",
                       "Предупреждение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                   );
            }
            
            textmodstack.Text = stackEdition.PrintStackEdition2();
        }

        private void PopTop_Click(object sender, EventArgs e)
        {

            try
            {
                stackEdition.DoPopBot(stackEdition.bot);
            }
            catch (Exception qwerty)
            {
                MessageBox.Show(
                       "Сверху стек пуст",
                       "Предупреждение",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Warning
                   );
            }
            textmodstack.Text = stackEdition.PrintStackEdition2();

        }

        private void PushPop_Click(object sender, EventArgs e)
        {
            try
            {
                stackEdition.DoPushBot(Convert.ToInt32(TextS2.Text));
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
            catch
            {
                MessageBox.Show(
                   "Ошибка ввода: вводите числа",
                   "Предупреждение",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
            }
            //печать элементов
            textmodstack.Text = stackEdition.PrintStackEdition2();
        }

      
    }
}

       

