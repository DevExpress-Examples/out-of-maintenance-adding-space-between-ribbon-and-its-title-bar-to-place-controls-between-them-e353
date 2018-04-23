using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;

namespace DXSample {

    //if you need to change the ApplicationButton location, use this class
    public class MyRibbonApplicationButtonInfo : RibbonApplicationButtonInfo
    {
        public MyRibbonApplicationButtonInfo(RibbonViewInfo viewInfo) : base(viewInfo) { }

        protected MyRibbonControl Ribbon
        {
            get { return base.ViewInfo.Ribbon as MyRibbonControl; }
        }
    }
}