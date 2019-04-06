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
                    Zero(msg, false);
                    break;
                case CalcState.AccumulateDigits:
                    AccumulateDigits(msg, false);
                    break;
                case CalcState.Operation:
                    Operation(msg, false);
                    break;
                case CalcState.Result:
                    Result(msg, false);
                    break;
                default:
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
                if (Rules.IsNonZeroDigit(msg))
                {
                    AccumulateDigits(msg,true);
                }

            }
        }

        void AccumulateDigits(string msg, bool IsInput)
        {
            if (IsInput)
            {
                calcState = CalcState.AccumulateDigits;
                tempNumber += msg;
                changeTextDelegate.Invoke(tempNumber);
            }
            else
            {
                if (Rules.IsDigit(msg))
                {
                    AccumulateDigits(msg, true);
                }
                else if (Rules.IsOperation(msg))
                {
                    Operation(msg, true);
                }
                else if (Rules.IsResult(msg))
                {
                    Result(msg, true);
                }
            }

        }

        void Operation(string msg, bool IsInput)
        {
            if (IsInput)
            {
                calcState = CalcState.Operation;
                if (operation.Length != 0)
                {
                    PerformCalculations();
                    changeTextDelegate(resultNumber);
                }
                if (resultNumber == "")
                {
                    resultNumber = tempNumber;
                }
                operation = msg;
                tempNumber = "";
            }
            else if (Rules.IsDigit(msg))
            {
                AccumulateDigits(msg, true);
            }

        }
        void Result(string msg, bool IsInput)
        {
            if (IsInput)
            {
                calcState = CalcState.Result;
                PerformCalculations();
                operation = "";
                changeTextDelegate.Invoke(resultNumber);
            }
            else 
            {
                if (Rules.IsOperation(msg))
                {
                    Operation(msg, true);
                }

            }
        }
        void PerformCalculations()
        {
            if(operation == "+")
            {
                resultNumber = (int.Parse(tempNumber) + int.Parse(resultNumber)).ToString();
            }
            else if (operation == "-")
            {
                resultNumber = (int.Parse(resultNumber) - int.Parse(tempNumber)).ToString();
            }
            else if(operation == "×")
            {
                resultNumber = (int.Parse(tempNumber) * int.Parse(resultNumber)).ToString();
            }
            else if (operation == "÷")
            {
                resultNumber = (int.Parse(resultNumber) / int.Parse(tempNumber)).ToString();
            }
            else if (operation == "%")
            {

            }
            else if (operation == "√")
            {

            }
            else if (operation == "x²")
            {

            }
            else if (operation == "1/x")
            {

            }
            else if (operation == "±")
            {

            }
        }
    }
}
