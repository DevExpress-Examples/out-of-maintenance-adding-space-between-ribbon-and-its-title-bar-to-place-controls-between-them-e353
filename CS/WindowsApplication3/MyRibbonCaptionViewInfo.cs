using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace DXSample {
    public class MyRibbonCaptionViewInfo : RibbonCaptionViewInfo
    {
        public MyRibbonCaptionViewInfo(RibbonViewInfo viewInfo) : base(viewInfo) { }

        public override int CalcGlassFormTopMargin()
        {
            int top = base.CalcGlassFormTopMargin();
            return top + Ribbon.CustomSpace;
        }
        protected new MyRibbonControl Ribbon
        {
            get { return base.Ribbon as MyRibbonControl; }
        }
    }
}