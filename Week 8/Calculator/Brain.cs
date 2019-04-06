using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    enum CalcState
    {
        Zero,
        AccumulateDigits,
        Operation,
        Result
    }

    public delegate void ChangeTextDelegate(string text);

    class Brain
    {
        ChangeTextDelegate changeTextDelegate;
        CalcState calcState = CalcState.Zero;
        string tempNumber = "";
        string resultNumber = "";
        string operation = "";

       
        public Brain(ChangeTextDelegate changeTextDelegate)
        {
            this.changeTextDelegate = changeTextDelegate; 
        }

        public void Process(string msg)
        {
            switch (calcState)
            {
                case CalcState.Zero:
                    break;
                case CalcState.AccumulateDigits:
                    break;
                case CalcState.Operation:
                    break;
                case CalcState.Result:
                    break;
                
            }
        }
        void Zero(string msg, bool IsInput)
        {
            if (IsInput)
            {
                calcState = CalcState.Zero;
            }
            else
            {

            }
        }
        void AccumulateDigits(string msg, bool IsInput)
        {
            if (IsInput)
            {
                calcState = CalcState.AccumulateDigits;
            }
            else
            {

            }

        }
        void Operation(string msg, bool IsInput)
        {
            if (IsInput)
            {
                calcState = CalcState.Operation;
            }
            else
            {

            }

        }
        void Result(string msg, bool IsInput)
        {
            if (IsInput)
            {
                calcState = CalcState.Result;
            }
            else
            {

            }
        }
    }
}
