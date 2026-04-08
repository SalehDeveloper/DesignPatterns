using System;
using System.Collections.Generic;
using System.Text;

namespace MementoPattern
{ 

    //originator 
    public class Editor
    {
        private string _content ;

       

        public void SetContent(string content)
        {
            _content = content;
        }   

        public string GetContent()
        {
            return _content;
        }
        public Memento Save()
        {
            return new Memento(_content);
        }

        public void Restore(Memento memento)
        {
            _content = memento.Content;


        }


        public class Memento
        {
            private readonly string _content;
            
            internal string Content => _content;
            internal Memento(string content)
            {
                _content =content;
            }

        }
    }
}
