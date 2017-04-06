using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reactive.Bindings;

namespace AutoCalc.Model
{
    public class CalcModel
    {
        public ReactiveProperty<int> CalcValue { get; set; } = new ReactiveProperty<int>(0);

        private readonly Stack<int> _valueStack = new Stack<int>();

        public void Push(int i)
        {
            _valueStack.Push(i);
        }

        public void Add()
        {
            if (_valueStack.Count < 2) return;
            var RValue = _valueStack.Pop();
            var LValue = _valueStack.Pop();
            _valueStack.Push(LValue + RValue);
        }

        public void Sub()
        {
            if (_valueStack.Count < 2) return;
            var RValue = _valueStack.Pop();
            var LValue = _valueStack.Pop();
            _valueStack.Push(LValue - RValue);
        }

        public void Clear()
        {
            _valueStack.Clear();
            CalcValue.Value = 0;
        }

        public void Result()
        {
            if (_valueStack.Count() != 1) return;
            CalcValue.Value = _valueStack.Peek();
        }
    }
}
