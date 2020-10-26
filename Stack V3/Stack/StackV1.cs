using System;
using System.Windows.Forms.VisualStyles;
using System.Xml.Schema;

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
    public virtual void canPush()
    {
        IsFull();
    }

    public void Push(int item, int top)
    {
        items[top] = item;
        
    }

    public void DoPush(int item)
    {
        canPush();
        Push(item,top);
        top++;
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

    public virtual void canPop()
    {
        if (IsEmpty())
            throw new Exception();
    }

    public void DoPop()
    {
        canPop();
        Pop(top);
        top--;
    }

    public void Pop(int top)
    {
        items[top] = 0;
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
    // возврат верхушки и дна
    public int PrintTop()
    {
        if (top == 0)
            return 0;
        int number = top - 1;
        return items[number];
    }

    public int PrintBot()
    {
        if (top == 0)
            return 0;
        return items[0];
    }

    public double SearchSuperF(string x)
    {
        //создаю переменную с определённым значением 
        double parametr = 0;
        switch (x)
        {
            case "min":
                parametr = Double.MaxValue;
                break;

            case "max":
                parametr = Double.MinValue;
                break;

            case "multi":
                parametr = 1;
                break;
        }
        //в зависимости от параметра считаю, что нужно
        for (int i = 0; i < top; i++)
        {
            switch (x)
            {
                case "min":
                    if (items[i] < parametr)
                        parametr = items[i];
                    break;

                case "max":
                    if (items[i] > parametr)
                        parametr = items[i];
                    break;

                case "sum":
                    parametr += items[i];
                    break;

                case "multi":
                    parametr *= items[i];
                    break;
            }
        }

        return parametr;

    }


}
