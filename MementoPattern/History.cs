using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{ 
    //CareTaker
    public class History
    {
        public Stack<Editor.Memento> mementos = new Stack<Editor.Memento>();

        public void Push(Editor.Memento memento)
        {
            mementos.Push(memento);
        }

        public Editor.Memento Pop()
        {
            return mementos.Pop();
        }
    }
}
