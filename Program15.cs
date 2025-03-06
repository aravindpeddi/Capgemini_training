//**Use of Delegates for Event Handling**

//Create a `Button` class that has a delegate `OnClick`. Implement an event that triggers
//when the button is clicked.

using System;

namespace c__Assignment
{
    class Button
    {
        public delegate void ClickHandler();
        public event ClickHandler OnClick;
        public void Click()
        {
            Console.WriteLine("Button clicked.");
            OnClick?.Invoke();
        }
    }

    //class Program
    //{
    //    static void Main()
    //    {
    //        Button button = new Button();

    //        button.OnClick += Button_OnClick;

    //        button.Click();
    //    }

    //    private static void Button_OnClick()
    //    {
    //        Console.WriteLine("Button click event handler executed.");
    //    }
    //}
}
