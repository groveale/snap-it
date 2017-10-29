using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using SplitIt.Models;
using UIKit;

namespace SplitIt
{
    internal class SplitHistorySource : UITableViewSource
    {
        private List<SplitItem> tempSplits;
        private UIViewController owner;

        private const string splitCellIdentifier = "splitCell_id";
        private const string splitSubCellIdentifier = "splitSubtitleCell_id";

        public SplitHistorySource(UIViewController owner, List<SplitItem> tempSplits)
        {
            this.owner = owner;
            this.tempSplits = tempSplits.OrderBy(s => s.Time).ToList();
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(splitSubCellIdentifier) as SplitSubtitle;

            if (cell.Amount == null)
            {
                var amountLabel = new UILabel(
                    new CoreGraphics.CGRect(
                        cell.Frame.Width - 80, 
                        (cell.Frame.Height / 2) - 10, 
                        80, 
                        20));

                amountLabel.TextAlignment = UITextAlignment.Right;
                amountLabel.TextColor = UIColor.Gray;
                amountLabel.Font = amountLabel.Font.WithSize(12f);

                cell.AddSubview(amountLabel);

                cell.Amount = amountLabel;
            }

            cell.UpdateCell(tempSplits[indexPath.Row]);

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return tempSplits.Count;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {

            var splitItem = tempSplits[indexPath.Row];

            var splitDetailVC = owner.Storyboard.InstantiateViewController("SplitDetailsViewController") as SplitDetailsViewController;

            if (splitDetailVC != null)
            {
                splitDetailVC.TheSplit = splitItem;

                owner.NavigationController.PushViewController(splitDetailVC, true);
            }
        }
    }
}