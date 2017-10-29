using Foundation;
using System;
using UIKit;
using SplitIt.Models;
using SplitIt.Helpers;

namespace SplitIt
{
    public partial class SplitTabelCell : UITableViewCell
    {
        public SplitTabelCell (IntPtr handle) : base (handle)
        {
        }


        public void UpdateCell(SplitItem split)
        {
            AmountLabel.Text = string.Format("£{0:N}", split.Amount);
            NameLabel.Text = split.Name;
            LocationLabel.Text = split.Location;


            PersonImage.Image = SplitHelper.GenerateImage(PersonImage.Frame.Width, PersonImage.Frame.Height);
        }
    }
}