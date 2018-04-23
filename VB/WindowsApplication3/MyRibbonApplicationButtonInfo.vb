Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing

Namespace DXSample

	'if you need to change the ApplicationButton location, use this class
	Public Class MyRibbonApplicationButtonInfo
		Inherits RibbonApplicationButtonInfo
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