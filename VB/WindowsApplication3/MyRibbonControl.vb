Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.Utils

Namespace DXSample
	Public Class MyRibbonControl
		Inherits RibbonControl
		Private customSpace_Renamed As Integer = 0
		Public Sub New()
			MyBase.New()
		End Sub

		<Description("This property adds a space between a RibbonForm's title bar and a RibbonControl")> _
		Public Property CustomSpace() As Integer
			Get
				Return customSpace_Renamed
			End Get
			Set(ByVal value As Integer)
				If customSpace_Renamed <> value AndAlso value > 0 Then
					customSpace_Renamed = value
				End If
			End Set
		End Property

		Protected Overrides Function CreateViewInfo() As DevExpress.XtraBars.Ribbon.ViewInfo.RibbonViewInfo
			Return New MyRibbonViewInfo(Me)
		End Function

		Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
			e.Graphics.Clear(Color.Transparent)
			CheckViewInfo()
			DrawGlassBackground(e)
			RibbonPaint(e)
			RaisePaintEvent(Me, e)
		End Sub
		Private Sub DrawGlassBackground(ByVal e As PaintEventArgs)
			If RibbonForm Is Nothing OrElse (Not RibbonForm.IsGlassForm) OrElse ViewInfo.Caption.Bounds.IsEmpty Then
				Return
			End If
			Dim bounds As Rectangle = ClientRectangle
			If GetRibbonStyle() <> RibbonControlStyle.Office2007 AndAlso ViewInfo.IsAllowDisplayRibbon Then
				bounds.Y = ViewInfo.Header.Bounds.Bottom
			Else
				bounds.Y = ViewInfo.Caption.Bounds.Bottom
			End If
			bounds.Y += CustomSpace
			bounds.Height = Height - bounds.Top
			Using brush As Brush = New SolidBrush(RibbonForm.BackColor)
				e.Graphics.FillRectangle(brush, bounds)
			End Using
		End Sub

		Protected Shadows ReadOnly Property RibbonForm() As MyRibbonForm
			Get
				Return TryCast(MyBase.RibbonForm, MyRibbonForm)
			End Get
		End Property
	End Class
End Namespace