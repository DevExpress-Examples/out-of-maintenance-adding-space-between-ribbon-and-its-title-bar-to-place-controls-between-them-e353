using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;
using DevExpress.XtraBars.Ribbon;

namespace DXSample {
    //if you need to change a toolbar location, use this class
    public class MyRibbonQuickAccessToolbarViewInfo : RibbonQuickAccessToolbarViewInfo
    {
        public MyRibbonQuickAccessToolbarViewInfo(RibbonQuickAccessToolbar toolBar) : base(toolBar) { }

        protected MyRibbonControl Ribbon
        {
            get { return base.ViewInfo.Ribbon as MyRibbonControl; }
        }
    }
}