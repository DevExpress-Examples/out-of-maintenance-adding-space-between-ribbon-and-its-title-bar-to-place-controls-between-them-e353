Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing

Namespace DXSample
	Public Class MyRibbonPanelViewInfo
		Inherits RibbonPanelViewInfo
		Public Sub New(ByVal viewInfo As RibbonViewInfo)
			MyBase.New(viewInfo)
		End Sub

		Protected ReadOnly Property Ribbon() As MyRibbonControl
			Get
				Return TryCast(MyBase.ViewInfo.Ribbon, MyRibbonControl)
			End Get
		End Property

	End Class

End Namespace