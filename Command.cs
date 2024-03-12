﻿using AGRevitCommandSimple.Base;
using AGRevitCommandSimple.UI;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace AGRevitCommandSimple
{
    [Transaction(TransactionMode.Manual)]
    internal class Command : BaseExternalCommand
    {
        private MainWinForm _mainWinForm;

        public override Result Execute()
        {
            MainWinForm _mainWinForm = new(_doc);
            _mainWinForm.Show();

            return Result.Succeeded;
        }
    }
}