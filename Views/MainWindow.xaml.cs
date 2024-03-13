﻿using AGRevitCommandSimple.ViewModels;
using Autodesk.Revit.DB;
using System.Windows;

namespace AGRevitCommandSimple.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(MainWindowViewModel mainaWindowViewModel)
        {
            DataContext = mainaWindowViewModel;
            InitializeComponent();
        }
    }
}