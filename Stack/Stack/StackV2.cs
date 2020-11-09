using System;


public class StackEdition : OneStack
{
    public int bot;

    public StackEdition()
    {
        bot=n-1;
    }
    // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - //
    // пустота и полнота
    public bool IsEmptyBot()//сверху пусто
    {
        return (bot == n-1);
    }

    public bool IsEmptyTop() //снизу пусто
    {
        return base.IsEmpty();
    }

    public bool IsEmptyTwo() // пустота с двух сторон
    {
        return IsEmptyBot() && IsEmpty();
    }

    public void IsFullStack()//полный
    {
        if (Math.Abs(bot - this.top) == 1)
            throw new IndexOutOfRangeException();
    }
    // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - //
    // изменение стека
    public void Resize(int size) // изменение размера
    {
        int[] tempItems = new int[size];
        for (int i = 0; i < top; i++)
            tempItems[i] = this.items[i];
        for (int i = this.n - 1 + 10, j = this.n - 1; j > this.bot; i--, j--)
        {
            tempItems[i] = this.items[j];
        }
        this.items = tempItems;
        this.n += 10;
        this.bot += 10;
    }

    public void DoPushBot(int item)
    {
        canPush();
        Push(item, bot);
        bot--;
    }

    public void DoPopBot(int item)
    {
        canPop();
        Pop(bot);
        bot++;
    }

    public override void canPop()
    {
        if (IsEmptyBot())
            throw new Exception();
    }

    public override void canPush()
    {
        IsFullStack();
    }

    // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - // - //
    // вывод
    public string PrintStackEdition2()
    {
        if (IsEmptyTwo())
            return "Стек пуст";
        else
        {
            int i;
            string s = "";
            if (top != 0)
            {
                for (i = 0; i < top-1; i++)
                    s += Convert.ToString(items[i]) + ", ";
                s += Convert.ToString(items[top-1]);
                if (this.bot != this.n-1)
                    s += ",";
            }
            if (this.bot != this.n-1)
            {
                for (i = bot+1; i < this.items.Length-1; i++)
                    s += Convert.ToString(items[i]) + ", ";
                s += Convert.ToString(items[this.items.Length-1]);
            }
            return s;
        }
    }

    //вывод верхушки
    public override int PrintBot()
    {
        if (bot == n-1)
            return 0;
        return items[bot-1];
    }

    //вывод другой верхушки
    public void PrintTop2()
    {
        PrintTop();
    }

}

       
    
