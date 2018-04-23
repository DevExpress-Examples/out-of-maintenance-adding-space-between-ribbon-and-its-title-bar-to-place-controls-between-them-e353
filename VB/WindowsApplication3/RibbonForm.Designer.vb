Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraBars.Ribbon
Namespace DXSample
	Partial Public Class MyRibbonForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.ribbonControl1 = New DXSample.MyRibbonControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
			Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
			Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			Me.simpleButton2 = New DevExpress.XtraEditors.SimpleButton()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins"
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationButtonText = Nothing
			Me.ribbonControl1.CustomSpace = 120
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.ExpandCollapseItem.Name = ""
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barCheckItem1, Me.barButtonGroup1, Me.barButtonItem4, Me.barButtonGroup2, Me.barButtonItem5})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 10
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.PageHeaderItemLinks.Add(Me.barButtonItem4)
			Me.ribbonControl1.PageHeaderItemLinks.Add(Me.barButtonGroup2)
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1, Me.ribbonPage2, Me.ribbonPage3, Me.ribbonPage4})
			Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010
			Me.ribbonControl1.Size = New System.Drawing.Size(641, 266)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.Id = 1
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "barButtonItem2"
			Me.barButtonItem2.Id = 3
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "barButtonItem3"
			Me.barButtonItem3.Id = 4
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' barCheckItem1
			' 
			Me.barCheckItem1.Caption = "barCheckItem1"
			Me.barCheckItem1.Id = 5
			Me.barCheckItem1.Name = "barCheckItem1"
			' 
			' barButtonGroup1
			' 
			Me.barButtonGroup1.Caption = "barButtonGroup1"
			Me.barButtonGroup1.Id = 6
			Me.barButtonGroup1.Name = "barButtonGroup1"
			' 
			' barButtonItem4
			' 
			Me.barButtonItem4.Caption = "barButtonItem4"
			Me.barButtonItem4.Id = 7
			Me.barButtonItem4.Name = "barButtonItem4"
			' 
			' barButtonGroup2
			' 
			Me.barButtonGroup2.Caption = "barButtonGroup2"
			Me.barButtonGroup2.Id = 8
			Me.barButtonGroup2.ItemLinks.Add(Me.barButtonItem5)
			Me.barButtonGroup2.Name = "barButtonGroup2"
			' 
			' barButtonItem5
			' 
			Me.barButtonItem5.Caption = "barButtonItem5"
			Me.barButtonItem5.Id = 9
			Me.barButtonItem5.Name = "barButtonItem5"
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "ribbonPage1"
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem2)
			Me.ribbonPageGroup1.ItemLinks.Add(Me.barCheckItem1)
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' ribbonPage2
			' 
			Me.ribbonPage2.Name = "ribbonPage2"
			Me.ribbonPage2.Text = "ribbonPage2"
			' 
			' ribbonPage3
			' 
			Me.ribbonPage3.Name = "ribbonPage3"
			Me.ribbonPage3.Text = "ribbonPage3"
			' 
			' ribbonPage4
			' 
			Me.ribbonPage4.Name = "ribbonPage4"
			Me.ribbonPage4.Text = "ribbonPage4"
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black
			Me.simpleButton1.Appearance.Options.UseForeColor = True
			Me.simpleButton1.Location = New System.Drawing.Point(12, 40)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(76, 17)
			Me.simpleButton1.TabIndex = 3
'			Me.simpleButton1.Paint += New System.Windows.Forms.PaintEventHandler(Me.OnButtonPaint);
			' 
			' simpleButton2
			' 
			Me.simpleButton2.Appearance.ForeColor = System.Drawing.Color.Black
			Me.simpleButton2.Appearance.Options.UseForeColor = True
			Me.simpleButton2.Location = New System.Drawing.Point(12, 63)
			Me.simpleButton2.Name = "simpleButton2"
			Me.simpleButton2.Size = New System.Drawing.Size(77, 17)
			Me.simpleButton2.TabIndex = 4
'			Me.simpleButton2.Paint += New System.Windows.Forms.PaintEventHandler(Me.OnButtonPaint);
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(94, 48)
			Me.textEdit1.MenuManager = Me.ribbonControl1
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(303, 20)
			Me.textEdit1.TabIndex = 5
			' 
			' MyRibbonForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(641, 467)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.simpleButton2)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "MyRibbonForm"
			Me.Ribbon = Me.ribbonControl1
			Me.Text = "How to add a space between a RibbonForm's title bar and a RibbonControl"
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private ribbonControl1 As MyRibbonControl
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton
		Private WithEvents simpleButton2 As DevExpress.XtraEditors.SimpleButton
		Private textEdit1 As DevExpress.XtraEditors.TextEdit
		Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem
		Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
		Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem
		Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
		Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace

