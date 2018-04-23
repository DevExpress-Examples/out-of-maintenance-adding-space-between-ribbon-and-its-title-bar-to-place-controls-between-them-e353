using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.XtraBars.Ribbon;
using System.Drawing;
using System.ComponentModel;
using DevExpress.Utils;

namespace DXSample {
    public class MyRibbonControl : RibbonControl
    {
        int customSpace = 0;
        public MyRibbonControl() : base() { }

        [Description("This property adds a space between a RibbonForm's title bar and a RibbonControl")]
        public int CustomSpace
        {
            get { return customSpace; }
            set
            {
                if (customSpace != value && value > 0)
                    customSpace = value;
            }
        }

        protected override DevExpress.XtraBars.Ribbon.ViewInfo.RibbonViewInfo CreateViewInfo()
        {
            return new MyRibbonViewInfo(this);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Transparent);
            CheckViewInfo();
            DrawGlassBackground(e);
            RibbonPaint(e);
            RaisePaintEvent(this, e);
        }
        private void DrawGlassBackground(PaintEventArgs e)
        {
            if (RibbonForm == null || !RibbonForm.IsGlassForm || ViewInfo.Caption.Bounds.IsEmpty) return;
            Rectangle bounds = ClientRectangle;
            bounds.Y = GetRibbonStyle() != RibbonControlStyle.Office2007 && ViewInfo.IsAllowDisplayRibbon ? ViewInfo.Header.Bounds.Bottom : ViewInfo.Caption.Bounds.Bottom;
            bounds.Y += CustomSpace;
            bounds.Height = Height - bounds.Top;
            using (Brush brush = new SolidBrush(RibbonForm.BackColor))
            {
                e.Graphics.FillRectangle(brush, bounds);
            }
        }

        protected new MyRibbonForm RibbonForm
        {
            get { return base.RibbonForm as MyRibbonForm; }
        }
    }
}