using System;
using System.Collections.Generic;
using CoreGraphics;
using Foundation;
using SplitIt.Models;
using UIKit;

namespace SplitIt.Helpers
{
    public class SplitHelper
    {

        public enum SplitType { Personal, Friend, Group };

        private static readonly CGColor[] colors = {
            UIColor.Red.CGColor,
            UIColor.Blue.CGColor,
            UIColor.Brown.CGColor,
            UIColor.DarkGray.CGColor,
            UIColor.Magenta.CGColor,
            UIColor.Orange.CGColor,
            UIColor.Purple.CGColor,
        };

        public static List<SplitItem> GenerateTempSplits(int number = 10)
        {
            List<SplitItem> splits = new List<SplitItem>();

            for (int i = 0; i < number; i++)
            {
                Random rnd = new Random(i);
                int month = rnd.Next(1, 13);                                // month: >= 1 and < 13
                int day = rnd.Next(1, 29);                                  // day: >= 1 and < 29 (real date)
                int hour = rnd.Next(24);                                    // hour: >= 0 and < 24 (real date)
                int min = rnd.Next(60);                                     // min: >= 0 and < 60 (real date)
                int splitNumer = rnd.Next(1, 10);                           // number:  >= 1 and < 9 (who has 9 friends)
                double amount = (rnd.NextDouble() * (100 - 10) + 10);      // double: between 10 and 1000


                SplitItem randomSplit = new SplitItem
                {
                    Amount = amount,
                    SplitType = (int)SplitHelper.SplitType.Personal,
                    SplitBetween = splitNumer,
                    Time = new DateTime(2017, month, day, hour, min, 0),
                    Name = string.Format("Split {0}", i),
                    Location = "Location - Coming Soon!"
                                 
                };

                splits.Add(randomSplit);
            }

            return splits;
        }

        public static UIImage GenerateImage(nfloat width, nfloat height, string name = "ME")
        {
            Random rnd = new Random();

            CGColor color = colors[rnd.Next(colors.Length - 1)];

            UIFont font = UIFont.FromName("Helvetica Light", 14);
            UIGraphics.BeginImageContextWithOptions(new CGSize(width, height), false, 0);

            var context = UIGraphics.GetCurrentContext();
            context.SetFillColor(color);
            context.AddArc(width / 2, height / 2, width / 2, 0, (nfloat)(2 * Math.PI), true);
            context.FillPath();

            var textAttributes = new UIStringAttributes
            {
                ForegroundColor = UIColor.White,
                BackgroundColor = UIColor.Clear,
                Font = font,
                ParagraphStyle = new NSMutableParagraphStyle { Alignment = UITextAlignment.Center },
            };

            string text;
            string[] splitFrom = name.Split(' ');
            if (splitFrom[0] == "ME")
            {
                text = "ME";
            }
            else if (splitFrom.Length > 1)
            {
                text = splitFrom[0][0].ToString() + splitFrom[1][0];
            }
            else if (splitFrom.Length > 0)
            {
                text = splitFrom[0][0].ToString();
            }
            else
            {
                text = "?";
            }

            NSString str = new NSString(text);

            var textSize = str.GetSizeUsingAttributes(textAttributes);
            str.DrawString(new CGRect(0, height / 2 - textSize.Height / 2,
                width, height), textAttributes);

            UIImage image = UIGraphics.GetImageFromCurrentImageContext();
            UIGraphics.EndImageContext();

            return image;
        }


    }
}
