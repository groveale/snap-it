using Foundation;
using System;
using UIKit;
using CoreGraphics;
using SplitIt.Models;
using SplitIt.Helpers;
using System.Diagnostics;

namespace SplitIt
{
    public partial class NewSplitController : UIViewController
    {
        UITextField totalAmount, splitBetween, tipPercentage;
        UISwitch tipSwitch;
        UILabel percentageLabel, splitTotal;
        UIButton splitButton, saveButton;
        SplitItem newSplit;


        public NewSplitController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            newSplit = new SplitItem();

            CellHelper.CircleTheView(GrovealeImage, UIColor.White, 2);

            totalAmount = TotalAmount;
            splitBetween = SplitNumber;
            tipSwitch = TipSwitch;
            tipPercentage = TipPercentage;
            percentageLabel = PercentageLabel;
            splitButton = CalculateSplit;
            splitTotal = TotalSplitAmount;
            saveButton = SaveSplit;

            totalAmount.KeyboardType = UIKeyboardType.DecimalPad;
            splitBetween.KeyboardType = UIKeyboardType.DecimalPad;
            tipPercentage.KeyboardType = UIKeyboardType.DecimalPad;

            tipSwitch.ValueChanged += TipSwitch_ValueChanged;

            splitButton.TouchUpInside += SplitButton_TouchUpInside;

            saveButton.TouchUpInside += SaveButton_TouchUpInside; 

        }

        void TipSwitch_ValueChanged(object sender, EventArgs e)
        {
            CloseKeyboards();

            if (tipSwitch.On)
            {
                tipPercentage.Hidden = false;
                percentageLabel.Hidden = false;

                return;
            }

            tipPercentage.Hidden = true;
            percentageLabel.Hidden = true;
        }

        void SplitButton_TouchUpInside(object sender, EventArgs e)
        {
            CloseKeyboards();

            double amount = 0;
            int noSplitBetween = 1;
            double splitAmount = 0;

            Double.TryParse(totalAmount.Text, out amount);

            if (tipSwitch.On)
            {
                double tip = 0;
                Double.TryParse(tipPercentage.Text, out tip);

                amount += amount * (tip / 100);

            }

            int.TryParse(SplitNumber.Text, out noSplitBetween);

            splitAmount = amount / noSplitBetween;

            splitTotal.Text = string.Format("Split amount is £{0:N}", splitAmount);

            newSplit.Amount = splitAmount;
            newSplit.SplitBetween = noSplitBetween;
        }

        public override void TouchesBegan(NSSet touches, UIEvent evt)
        {
            CloseKeyboards();
        }

        void SaveButton_TouchUpInside(object sender, EventArgs e)
        {
            // Save split
            newSplit.Time = DateTime.Now;
            newSplit.SplitType = (int)SplitHelper.SplitType.Personal;

            Debug.WriteLine("Split Saved");
        }

        void CloseKeyboards()
        {
            totalAmount.ResignFirstResponder();
            splitBetween.ResignFirstResponder();
            tipPercentage.ResignFirstResponder();
        }
    }
}