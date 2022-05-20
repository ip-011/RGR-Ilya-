using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Reactive.Linq;
using RGR_Ilya_.Models;

namespace RGR_Ilya_.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreateTabs();
            CreateGrid();
            CreateRequests();
            Content = Fv = new FirstViewModel(this);
            Sv = new SecondViewModel(this);
        }

        public FirstViewModel Fv { get; }
        public SecondViewModel Sv { get; }

        public void Change()
        {
            if (Content == Fv)
                Content = Sv;
            else if (Content == Sv)
                Content = Fv;
        }

        ViewModelBase content;
        public ViewModelBase Content
        {
            get { return content; }
            set { this.RaiseAndSetIfChanged(ref content, value); }
        }

        ObservableCollection<Tabs> tab;
        public ObservableCollection<Tabs> Tab
        {
            get { return tab; }
            set { this.RaiseAndSetIfChanged(ref tab, value); }
        }
        private void CreateTabs()
        {
            Tab = new ObservableCollection<Tabs>();
            Tab.Add(new Tabs("Player", false));
            Tab.Add(new Tabs("Coach", false));
            Tab.Add(new Tabs("Player`s result", false));
            Tab.Add(new Tabs("Team", false));
            Tab.Add(new Tabs("Match", false));
            Tab.Add(new Tabs("Command result", false));
            Tab.Add(new Tabs("Request 1", false));
            Tab.Add(new Tabs("Request 2", false));
        }

        ObservableCollection<Tabs> request;
        public ObservableCollection<Tabs> Request
        {
            get { return request; }
            set { this.RaiseAndSetIfChanged(ref request, value); }
        }

        private void CreateRequests()
        {
            Request = new ObservableCollection<Tabs>();
            Request.Add(new Tabs("Request 1", true));
            Request.Add(new Tabs("Request 2", true));
        }

        ObservableCollection<Grids> grid;
        public ObservableCollection<Grids> Grid
        {
            get { return grid; }
            set { this.RaiseAndSetIfChanged(ref grid, value); }
        }
        private void CreateGrid()
        {
            Grid = new ObservableCollection<Grids>();
            Grid.Add(new Grids("Kevin De Bruyne", "28.05.1991", "17", "CAM"));
            Grid.Add(new Grids("Lionel Messi", "24.05.1987", "30", "RW"));
            Grid.Add(new Grids("Cristiano Ronaldo", "05.02.1985", "7", "ST"));
            Grid.Add(new Grids("Neymar Jr", "05.02.1992", "10", "LW"));
            Grid.Add(new Grids("Robert Lewandowski", "21.08.1988", "9", "ST"));
        }
    }
}
