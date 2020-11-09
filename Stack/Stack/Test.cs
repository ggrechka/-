using System;
using System.Windows.Forms;

namespace Stack
{
 
    class Test :OneStack
    {
        public string TestStack()
        {
            string s="";
            
            try
            {
                //проверка пустого стека на пустоту 
                if (IsEmpty()) s += "Стек пуст, функция проверки стека на пустоту на пустом стеке работает.\n ";
                else
                {
                    s += "Стек пуст, но функция проверки стека на пустоту работает неверно.\n";
                    throw new Exception(s);
                }

                //проверка функции добавления и вывода верхушки
                int testtop = top;
                DoPush(5);
                if (top == testtop + 1)
                {
                    s += "Функция добавления элемента: изменение top работает корректно, ";
                    if (PrintTop() == 5  &&  PrintBot()==5)
                        s += " добавление элемента работает.\n";
                    else
                    {
                        s += " добавление элемента не работает.\n";
                        throw new Exception(s);
                    }
                }
                else
                {
                    s += "Функция добавления элемента: изменение top работает некорректно.\n ";
                    throw new Exception(s);
                }

               

                //вторая проверка на пустоту 

                if (!IsEmpty()) s += "Стек содержит элементы, функция проверки стека на пустоту на стеке работает.\n ";
                else
                {
                    s += "Стек содержит элементы, функция проверки стека на пустоту на стеке не работает.\n";
                    throw new Exception(s);
                }

                //проверка удаления
                testtop = top;

                DoPop();
                if (top == testtop - 1)
                {
                    s += "Функция удаления элемента: изменение top работает корректно, ";
                    if (items[testtop] == 0)
                        s += " удаление элемента работает.\n";
                    else
                    {
                        s += " удаление элемента не работает.\n";
                        throw new Exception(s);
                    }
                }
                else
                {
                    s += "Функция удаления элемента: изменение top работает некорректно.\n ";
                    throw new Exception(s);
                }


                //добавление 10 элементов
                int sum = 0, p = 1;
                for (int i = 0; i < 10; i++) 
                {
                    DoPush(i + 1);
                    sum =sum+ (i + 1);
                    p *= i + 1;

                }

                //проверка супер-функции
                if (SearchSuperF("max") != 10 || SearchSuperF("min") != 1 || SearchSuperF("sum") != sum || SearchSuperF("multi") != p)
                { 
                    s += "Суперфункция подсчёта всего на свете не работает.\n";
                    throw new Exception(s);
                }
                else
                    s += "Суперфункция работает. \n";

                //проверка ресайза
                int copyN = n;
                ResizeTop(10);
                if (copyN+10==n)
                    s += "Ресайз работает верно.\n";
                else
                {
                    s += "Ресайз не работает. \n";
                    throw new Exception(s);
                }

                MessageBox.Show(
                    "Тест пройден. Всё ок",
                    "Успешно",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
                

            catch (IndexOutOfRangeException exxxx)
            {
                s += "Функция проверки стека на заполненность работает неверно.\n";
                throw new Exception(s);
            }
            catch (Exception errException)
            {
               string test = errException.Message;
               MessageBox.Show(
                   test,
                   "Тест не пройден",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error); ;
            }
            return s;
        }
    }
}
