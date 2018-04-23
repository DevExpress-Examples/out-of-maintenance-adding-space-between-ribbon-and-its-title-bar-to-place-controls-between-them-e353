Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.Utils.Drawing.Helpers
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraBars.Ribbon.Drawing


Namespace DXSample
	Partial Public Class MyRibbonForm
		Inherits RibbonForm
		Public Sub New()
			InitializeComponent()

		End Sub

		Friend Shadows ReadOnly Property IsGlassForm() As Boolean
			Get
				Return MyBase.IsGlassForm
			End Get
		End Property



		Private Sub OnButtonPaint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles simpleButton1.Paint, simpleButton2.Paint
			Dim btn As SimpleButton = TryCast(sender, SimpleButton)
			Using format As New StringFormat()
				format.Alignment = StringAlignment.Center
				e.Graphics.DrawString("->", btn.Font, Brushes.Black, btn.ClientRectangle, format)
			End Using
		End Sub
	End Class
End Namespace
