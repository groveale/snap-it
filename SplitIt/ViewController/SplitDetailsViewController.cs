using Foundation;
using System;
using UIKit;
using SharedCode.Models;
using System.Diagnostics;

namespace SplitIt
{
    public partial class SplitDetailsViewController : UITableViewController
    {
        UILabel totalAmount, splitNumber, splitShare, location, time, date;
        UISwitch paidSwitch;

        public SplitItem TheSplit { get; set; }

        public SplitDetailsViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            NavLabel.Title = TheSplit.Name;

            totalAmount = TotalLabel;
            splitNumber = SplitNumberLabel;
            splitShare = ShareLabel;
            location = LocationLabel;
            time = TimeLabel;
            date = DateLabel;

            paidSwitch = PaidSwitch;

            UpdateLabels(TheSplit);

            paidSwitch.ValueChanged += PaidSwitch_ValueChanged;
        }

        private void CircleTheView(object groveale)
        {
            throw new NotImplementedException();
        }

        private void UpdateLabels(SplitItem theSplit)
        {
            totalAmount.Text = string.Format("£{0:N}", theSplit.Amount * theSplit.SplitBetween);

            splitNumber.Text = theSplit.SplitBetween.ToString();

            splitShare.Text = string.Format("£{0:N}", theSplit.Amount);

            location.Text = theSplit.Location;

            time.Text = theSplit.Time.ToString("HH:mm");

            date.Text = theSplit.Time.ToString("ddd, DD MMM");
        }

        void PaidSwitch_ValueChanged(object sender, EventArgs e)
        {
            if (paidSwitch.On)
            {
                Debug.WriteLine("Update SplitItem - Paid");

                return;
            }

            Debug.WriteLine("Update SplitItem - NOT Paid");
        }
    }
}