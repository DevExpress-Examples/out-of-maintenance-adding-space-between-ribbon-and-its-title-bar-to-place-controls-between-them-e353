using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon.Drawing;


namespace DXSample {
    public partial class MyRibbonForm: RibbonForm {
        public MyRibbonForm() {
            InitializeComponent();
           
        }

        internal new bool IsGlassForm
        {
            get { return base.IsGlassForm; }
        }

      

        private void OnButtonPaint(object sender, PaintEventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            using (StringFormat format = new StringFormat())
            {
                format.Alignment = StringAlignment.Center;
                e.Graphics.DrawString("->", btn.Font, Brushes.Black, btn.ClientRectangle, format);
            }
        }
    }
}
