Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace DXSample
	Public Class MyRibbonCaptionViewInfo
		Inherits RibbonCaptionViewInfo
		Public Sub New(ByVal viewInfo As RibbonViewInfo)
			MyBase.New(viewInfo)
		End Sub

		Public Overrides Function CalcGlassFormTopMargin() As Integer
			Dim top As Integer = MyBase.CalcGlassFormTopMargin()
			Return top + Ribbon.CustomSpace
		End Function
		Protected Shadows ReadOnly Property Ribbon() As MyRibbonControl
			Get
				Return TryCast(MyBase.Ribbon, MyRibbonControl)
			End Get
		End Property
	End Class
End Namespace