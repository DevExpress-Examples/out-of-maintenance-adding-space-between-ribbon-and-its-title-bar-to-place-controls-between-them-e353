using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;

namespace DXSample {
    public class MyRibbonPanelViewInfo : RibbonPanelViewInfo
    {
        public MyRibbonPanelViewInfo(RibbonViewInfo viewInfo) : base(viewInfo) { }

        protected MyRibbonControl Ribbon
        {
            get { return base.ViewInfo.Ribbon as MyRibbonControl; }
        }
       
    }

}