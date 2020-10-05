using System;
using System.Security.Principal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Stack.Form1;

namespace StackTests 
{
    [TestClass]
    public class StackTest
    {
        [TestMethod]


        public void Push_test_stack()
        {
            OneStack s = new OneStack();
            int x = 5;
            int top = 0;

            s.Push(x, top);
            Assert.AreEqual(x, s.items[top]);
        }

        public void Pop_test_stack()
        {
            OneStack s = new OneStack();
            int x = 5;
            s.Push(x, s.top);
            s.top++;
            

            s.Pop(s,s.top);

            Assert.AreEqual(0, s.items[s.top]);
        }

    }
}
