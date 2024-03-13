﻿using AGRevitCommandSimple.Base;
using AGRevitCommandSimple.View;
using AGRevitCommandSimple.ViewModels;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace AGRevitCommandSimple
{
    [Transaction(TransactionMode.Manual)]
    internal class Command : BaseExternalCommand
    {
        public override Result Execute()
        {
            MainaWindowViewModel mainaWindowViewModel = new(_doc);
            MainWindow mainWindow = new(mainaWindowViewModel);
            mainWindow.ShowDialog();

            return Result.Succeeded;
        }
    }
}