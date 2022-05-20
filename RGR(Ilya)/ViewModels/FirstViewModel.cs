using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Reactive.Linq;
using System.Reactive;
using RGR_Ilya_.Models;
    
namespace RGR_Ilya_.ViewModels
{
    public class FirstViewModel : ViewModelBase
    {

        public FirstViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
        }

        public ReactiveCommand<Tabs, Unit> ButtonDeleteTab { get; }

        public MainWindowViewModel? MainContext { get; set; }


    }
}
