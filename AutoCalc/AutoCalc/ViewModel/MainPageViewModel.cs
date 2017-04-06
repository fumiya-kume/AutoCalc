using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoCalc.Model;
using Reactive.Bindings;
using Xamarin.Forms;

namespace AutoCalc.ViewModel
{
    class MainPageViewModel
    {
        public CalcModel CalcModel { get; set; } = new CalcModel();

        public ReactiveCommand PlusCommand { get; set; } = new ReactiveCommand();
        public ReactiveCommand SubCommand { get; set; } = new ReactiveCommand();
        public ReactiveCommand ClearCommand { get; set; } = new ReactiveCommand();
        public ReactiveCommand ResultCommand { get; set; } = new ReactiveCommand();

        public ReactiveCommand Input0Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Input1Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Input2Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Input3Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Input4Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Input5Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Input6Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Input7Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Input8Command { get; set; } = new ReactiveCommand();
        public ReactiveCommand Input9Command { get; set; } = new ReactiveCommand();
        public ReactiveProperty<string> InputHistory { get; set; } = new ReactiveProperty<string>("");
        public ReactiveProperty<int> CalcResult { get; set; }


    public MainPageViewModel()
        {
            CalcResult = CalcModel.CalcValue.ToReactiveProperty();

            PlusCommand.Subscribe(o =>
            {
                InputHistory.Value += "+";
                CalcModel.Add();
            });

            SubCommand.Subscribe(o =>
            {
                InputHistory.Value += "-";
                CalcModel.Sub();
            });

            ClearCommand.Subscribe(o =>
            {
                InputHistory.Value = "";
                CalcModel.Clear();
            });

            ResultCommand.Subscribe(o =>
            {
                CalcModel.Result();
                InputHistory.Value = CalcModel.CalcValue.Value.ToString();
            });

            Input0Command.Subscribe(o =>
            {
                InputHistory.Value += "0";
                CalcModel.Push(0);
            });

            Input1Command.Subscribe(o =>
            {
                InputHistory.Value += "1";
                CalcModel.Push(1);
            });

            Input2Command.Subscribe(o =>
            {
                InputHistory.Value += "2";
                CalcModel.Push(2);
            });

            Input3Command.Subscribe(o =>
            {
                InputHistory.Value += "2";
                CalcModel.Push(3);
            });
            
            Input4Command.Subscribe(o =>
            {
                InputHistory.Value += "3";
                CalcModel.Push(4);
            });

            Input5Command.Subscribe(o =>
            {
                InputHistory.Value += "5";
                CalcModel.Push(5);
            });

            Input6Command.Subscribe(o =>
            {
                InputHistory.Value += "6";
                CalcModel.Push(6);
            });

            Input7Command.Subscribe(o =>
            {
                InputHistory.Value += "7";
                CalcModel.Push(7);
            });

            Input8Command.Subscribe(o =>
            {
                InputHistory.Value += "8";
                CalcModel.Push(8);
            });

            Input9Command.Subscribe(o =>
            {
                InputHistory.Value += "9";
                CalcModel.Push(9);
            });
        }
    }
}
