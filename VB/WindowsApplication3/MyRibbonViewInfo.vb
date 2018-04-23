Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars.Ribbon
Imports System.Drawing

Namespace DXSample
	Public Class MyRibbonViewInfo
		Inherits RibbonViewInfo
		Public Sub New(ByVal ribbon As RibbonControl)
			MyBase.New(ribbon)
		End Sub

		Protected Overrides Function CalcMinHeight() As Integer
			Dim height As Integer = MyBase.CalcMinHeight()
			Return height + Ribbon.CustomSpace
		End Function

		Protected Overrides Function CreatePanelInfo() As RibbonPanelViewInfo
			Return New MyRibbonPanelViewInfo(Me)
		End Function
		Protected Overrides Function CreateHeaderInfo() As RibbonPageHeaderViewInfo
			Return New MyRibbonPageHeaderViewInfo(Me)
		End Function

		Protected Overrides Function CreateCaptionInfo() As RibbonCaptionViewInfo
			Return New MyRibbonCaptionViewInfo(Me)
		End Function

		Protected Overrides Function CreateToolbarInfo() As RibbonQuickAccessToolbarViewInfo
			Return New MyRibbonQuickAccessToolbarViewInfo(Ribbon.Toolbar)
		End Function

		Protected Overrides Function CreateApplicationButtonInfo() As RibbonApplicationButtonInfo
			Return New MyRibbonApplicationButtonInfo(Me)
		End Function

		Protected Overrides Function CalcContentBounds() As Rectangle
			Dim rect As Rectangle = MyBase.CalcContentBounds()
			rect.Y += Ribbon.CustomSpace
			Return rect
		End Function

		Protected Shadows ReadOnly Property Ribbon() As MyRibbonControl
			Get
				Return TryCast(MyBase.Ribbon, MyRibbonControl)
			End Get
		End Property

	End Class
End Namespace