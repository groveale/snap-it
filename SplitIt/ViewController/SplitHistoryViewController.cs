using Foundation;
using System;
using UIKit;
using SplitIt.Helpers;

namespace SplitIt
{
    public partial class SplitHistoryViewController : UITableViewController
    {
        UITableView splitHistory;

        public SplitHistoryViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            splitHistory = StoredSplits;

            var tempSplits = SplitHelper.GenerateTempSplits();

            splitHistory.Source = new SplitHistorySource(this, tempSplits);


            //splitHistory.BackgroundColor = UIColor.Blue;
        }
    }
}