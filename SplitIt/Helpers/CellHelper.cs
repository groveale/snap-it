using System;
using UIKit;

namespace SplitIt.Helpers
{
    public class CellHelper
    {
        public static void CircleTheView(UIView viewToCircle, UIColor boarderColour, int borderWidth = 0)
        {
            viewToCircle.Layer.CornerRadius = viewToCircle.Frame.Size.Height / 2;
            viewToCircle.Layer.MasksToBounds = true;

            if (borderWidth > 0)
            {
                viewToCircle.Layer.BorderColor = boarderColour.CGColor;
                viewToCircle.Layer.BorderWidth = borderWidth; 
            }
        }
    }
}
