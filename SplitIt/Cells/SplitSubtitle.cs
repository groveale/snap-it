using Foundation;
using System;
using UIKit;
using SharedCode.Models;
using SplitIt.Helpers;

namespace SplitIt
{
    public partial class SplitSubtitle : UITableViewCell
    {
        public UILabel Amount { get; set; }

        public SplitSubtitle (IntPtr handle) : base (handle)
        {
        }


        public void UpdateCell(SplitItem split)
        {
            //TextLabel.Text = string.Format("£{0:N}", split.Amount);
            if (Amount != null)
            {
                Amount.Text = string.Format("£{0:N}", (split.Amount * split.SplitBetween));
            }

            TextLabel.Text = split.Name;
            DetailTextLabel.Text = string.Format("Your share: £{0:N}", split.Amount);

            ImageView.Image = SplitHelper.GenerateImage(32, 32);
        }
    }
}