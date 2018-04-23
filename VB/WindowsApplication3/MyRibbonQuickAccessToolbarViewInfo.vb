Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing
Imports DevExpress.XtraBars.Ribbon

Namespace DXSample
	'if you need to change a toolbar location, use this class
	Public Class MyRibbonQuickAccessToolbarViewInfo
		Inherits RibbonQuickAccessToolbarViewInfo
		Public Sub New(ByVal toolBar As RibbonQuickAccessToolbar)
			MyBase.New(toolBar)
		End Sub

		Protected ReadOnly Property Ribbon() As MyRibbonControl
			Get
				Return TryCast(MyBase.ViewInfo.Ribbon, MyRibbonControl)
			End Get
		End Property
	End Class
End Namespace