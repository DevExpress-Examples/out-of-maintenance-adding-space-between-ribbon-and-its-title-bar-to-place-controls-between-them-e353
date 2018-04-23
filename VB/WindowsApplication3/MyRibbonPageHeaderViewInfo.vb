Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing

Namespace DXSample
	Public Class MyRibbonPageHeaderViewInfo
		Inherits RibbonPageHeaderViewInfo
		Public Sub New(ByVal viewInfo As RibbonViewInfo)
			MyBase.New(viewInfo)
		End Sub

		Protected Overrides Function CalcActualHeaderRect(ByVal availableHeaderRect As Rectangle, ByVal bestSize As Size) As Rectangle
			Dim rect As Rectangle = MyBase.CalcActualHeaderRect(availableHeaderRect, bestSize)
			rect.Y += Ribbon.CustomSpace
			Return rect
		End Function

		Public Overrides Sub CalcPageHeader()
			MyBase.CalcPageHeader()
			Dim rect As Rectangle = Bounds
			rect.Y += Ribbon.CustomSpace
			Bounds = rect
		End Sub

		Protected Overrides Sub CalcHeaderItemsLayout(ByVal rect As Rectangle)
			rect.Y += Ribbon.CustomSpace
			MyBase.CalcHeaderItemsLayout(rect)
		End Sub

		Protected Shadows ReadOnly Property Ribbon() As MyRibbonControl
			Get
				Return TryCast(MyBase.Ribbon, MyRibbonControl)
			End Get
		End Property
	End Class
End Namespace