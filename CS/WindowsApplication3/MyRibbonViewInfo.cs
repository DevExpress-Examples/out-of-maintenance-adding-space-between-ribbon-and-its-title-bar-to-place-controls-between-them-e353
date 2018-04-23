using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.Ribbon;
using System.Drawing;

namespace DXSample
{
    public class MyRibbonViewInfo : RibbonViewInfo
    {
        public MyRibbonViewInfo(RibbonControl ribbon) : base(ribbon) { }

        protected override int CalcMinHeight()
        {
            int height = base.CalcMinHeight();
            return height + Ribbon.CustomSpace;
        }

        protected override RibbonPanelViewInfo CreatePanelInfo()
        {
            return new MyRibbonPanelViewInfo(this);
        }
        protected override RibbonPageHeaderViewInfo CreateHeaderInfo()
        {
            return new MyRibbonPageHeaderViewInfo(this);
        }

        protected override RibbonCaptionViewInfo CreateCaptionInfo()
        {
            return new MyRibbonCaptionViewInfo(this);
        }

        protected override RibbonQuickAccessToolbarViewInfo CreateToolbarInfo()
        {
            return new MyRibbonQuickAccessToolbarViewInfo(Ribbon.Toolbar);
        }

        protected override RibbonApplicationButtonInfo CreateApplicationButtonInfo()
        {
            return new MyRibbonApplicationButtonInfo(this);
        }

        protected override Rectangle CalcContentBounds()
        {
            Rectangle rect = base.CalcContentBounds();
            rect.Y += Ribbon.CustomSpace;
            return rect;
        }

        protected new MyRibbonControl Ribbon
        {
            get { return base.Ribbon as MyRibbonControl; }
        }

    }
}