using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDojo1
{
    class CustomStack<T>
    {
        private T DataObject { get; set; }
        private CustomStack<T> NextElement { get; set; }

        public CustomStack() : this(default(T))
        {
        }

        public CustomStack(T dataObject)
        {
            DataObject = dataObject;
            NextElement = null;
        }

        public void Push(T dataObject)
        {
            if (EqualityComparer<T>.Default.Equals(DataObject, default(T)))
            {
                DataObject = dataObject;
            }
            else
            {
                CustomStack<T> currentElement = new CustomStack<T>(DataObject);
                currentElement.NextElement = NextElement;
                NextElement = currentElement;
                DataObject = dataObject;
            }   
        }

        public T Pop()
        {
            T tempObject = DataObject;

            if(NextElement == null)
            {
                DataObject = default(T);
            }
            else
            {
                DataObject = NextElement.DataObject;
                NextElement = NextElement.NextElement;
            }

            return tempObject;
        }

        public T Peak()
        {
            return DataObject;
        }

    }
}
