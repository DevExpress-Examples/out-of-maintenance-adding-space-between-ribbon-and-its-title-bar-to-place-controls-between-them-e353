using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;

namespace DXSample {
    public class MyRibbonPageHeaderViewInfo : RibbonPageHeaderViewInfo
    {
        public MyRibbonPageHeaderViewInfo(RibbonViewInfo viewInfo) : base(viewInfo) { }

        protected override Rectangle CalcActualHeaderRect(Rectangle availableHeaderRect, Size bestSize)
        {
            Rectangle rect = base.CalcActualHeaderRect(availableHeaderRect, bestSize);
            rect.Y += Ribbon.CustomSpace;
            return rect;
        }

        public override void CalcPageHeader()
        {
            base.CalcPageHeader();
            Rectangle rect = Bounds;
            rect.Y += Ribbon.CustomSpace;
            Bounds = rect;
        }

        protected override void CalcHeaderItemsLayout(Rectangle rect)
        {
            rect.Y += Ribbon.CustomSpace;
            base.CalcHeaderItemsLayout(rect);
        }

        protected new MyRibbonControl Ribbon
        {
            get { return base.Ribbon as MyRibbonControl; }
        }
    }
}