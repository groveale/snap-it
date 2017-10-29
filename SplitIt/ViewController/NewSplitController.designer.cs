// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace SplitIt
{
    [Register ("NewSplitController")]
    partial class NewSplitController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CalculateSplit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIImageView GrovealeImage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel PercentageLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SaveSplit { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField SplitNumber { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TipLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TipPercentage { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch TipSwitch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TotalAmount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel TotalSplitAmount { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CalculateSplit != null) {
                CalculateSplit.Dispose ();
                CalculateSplit = null;
            }

            if (GrovealeImage != null) {
                GrovealeImage.Dispose ();
                GrovealeImage = null;
            }

            if (PercentageLabel != null) {
                PercentageLabel.Dispose ();
                PercentageLabel = null;
            }

            if (SaveSplit != null) {
                SaveSplit.Dispose ();
                SaveSplit = null;
            }

            if (SplitNumber != null) {
                SplitNumber.Dispose ();
                SplitNumber = null;
            }

            if (TipLabel != null) {
                TipLabel.Dispose ();
                TipLabel = null;
            }

            if (TipPercentage != null) {
                TipPercentage.Dispose ();
                TipPercentage = null;
            }

            if (TipSwitch != null) {
                TipSwitch.Dispose ();
                TipSwitch = null;
            }

            if (TotalAmount != null) {
                TotalAmount.Dispose ();
                TotalAmount = null;
            }

            if (TotalSplitAmount != null) {
                TotalSplitAmount.Dispose ();
                TotalSplitAmount = null;
            }
        }
    }
}