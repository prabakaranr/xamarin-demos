#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using SampleBrowser.SfDataGrid.iOS;

[assembly : Dependency(typeof(DataGridDependencyService))]
namespace SampleBrowser.SfDataGrid.iOS
{
    internal class DataGridDependencyService : IDataGridDependencyService
    {
        public string GetOrientation()
        {
            return UIDevice.CurrentDevice.Orientation.ToString();
        }
    }
}