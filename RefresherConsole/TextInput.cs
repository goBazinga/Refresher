using System;
using System.Collections.Generic;
using System.Text;

namespace RefresherConsole
{
    public class TextInput
    {
        public string CurrentValue = "";
        public virtual void Add(char c)
        {
            CurrentValue = CurrentValue + c;
        }

        public virtual string GetValue()
        {
            return CurrentValue;
        }


    }

    public class NumericInput : TextInput
    {

        public override void Add(char c)
        {
            if (Char.IsNumber(c))
                CurrentValue = CurrentValue + c;
        }

        public override string GetValue()
        {
            return CurrentValue;
        }

    }
}
