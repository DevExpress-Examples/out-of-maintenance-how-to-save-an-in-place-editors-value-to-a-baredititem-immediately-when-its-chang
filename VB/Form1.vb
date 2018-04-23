Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors

Namespace WindowsApplication41
	Public Class Form1
		Inherits System.Windows.Forms.Form

	#Region " Windows Form Designer generated code "

		Public Sub New()
			MyBase.New()

			'This call is required by the Windows Form Designer.
			InitializeComponent()

			'Add any initialization after the InitializeComponent() call

		End Sub

		'Form overrides dispose to clean up the component list.
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		'Required by the Windows Form Designer
		Private components As System.ComponentModel.IContainer

		'NOTE: The following procedure is required by the Windows Form Designer
		'It can be modified using the Windows Form Designer.  
		'Do not modify it using the code editor.
		Friend BarManager1 As DevExpress.XtraBars.BarManager
		Friend barDockControlTop As DevExpress.XtraBars.BarDockControl
		Friend barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Friend barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Friend barDockControlRight As DevExpress.XtraBars.BarDockControl
		Friend TextEdit1 As DevExpress.XtraEditors.TextEdit
		Friend Bar1 As DevExpress.XtraBars.Bar
		Friend WithEvents BarEditItem1 As DevExpress.XtraBars.BarEditItem
		Friend RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
		Friend WithEvents BarEditItem2 As DevExpress.XtraBars.BarEditItem
		Friend RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private WithEvents barCheckItem1 As BarCheckItem
		Friend BarButtonItem1 As DevExpress.XtraBars.BarButtonItem
		<System.Diagnostics.DebuggerStepThrough()> _
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.Bar1 = New DevExpress.XtraBars.Bar()
			Me.BarEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
			Me.BarEditItem2 = New DevExpress.XtraBars.BarEditItem()
			Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.BarButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
			CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' BarManager1
			' 
			Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.Bar1})
			Me.BarManager1.DockControls.Add(Me.barDockControlTop)
			Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
			Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
			Me.BarManager1.DockControls.Add(Me.barDockControlRight)
			Me.BarManager1.Form = Me
			Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.BarEditItem1, Me.BarEditItem2, Me.BarButtonItem1, Me.barCheckItem1})
			Me.BarManager1.MaxItemId = 4
			Me.BarManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.RepositoryItemCheckEdit1, Me.RepositoryItemTextEdit1})
			' 
			' Bar1
			' 
			Me.Bar1.BarName = "Custom 1"
			Me.Bar1.DockCol = 0
			Me.Bar1.DockRow = 0
			Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
			Me.Bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.BarEditItem1), New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, Me.BarEditItem2, "", False, True, True, 135), New DevExpress.XtraBars.LinkPersistInfo(Me.BarButtonItem1), New DevExpress.XtraBars.LinkPersistInfo(Me.barCheckItem1)})
			Me.Bar1.Text = "Custom 1"
			' 
			' BarEditItem1
			' 
			Me.BarEditItem1.Caption = "BarEditItem1"
			Me.BarEditItem1.Edit = Me.RepositoryItemCheckEdit1
			Me.BarEditItem1.Id = 0
			Me.BarEditItem1.Name = "BarEditItem1"
'			Me.BarEditItem1.EditValueChanged += New System.EventHandler(Me.OnBarEditItemValueChanged);
			' 
			' RepositoryItemCheckEdit1
			' 
			Me.RepositoryItemCheckEdit1.AutoHeight = False
			Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
			' 
			' BarEditItem2
			' 
			Me.BarEditItem2.Caption = "BarEditItem2"
			Me.BarEditItem2.Edit = Me.RepositoryItemTextEdit1
			Me.BarEditItem2.Id = 1
			Me.BarEditItem2.Name = "BarEditItem2"
'			Me.BarEditItem2.EditValueChanged += New System.EventHandler(Me.OnBarEditItemValueChanged);
			' 
			' RepositoryItemTextEdit1
			' 
			Me.RepositoryItemTextEdit1.AutoHeight = False
			Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
			' 
			' BarButtonItem1
			' 
			Me.BarButtonItem1.Caption = "BarButtonItem1"
			Me.BarButtonItem1.Id = 2
			Me.BarButtonItem1.Name = "BarButtonItem1"
			' 
			' barCheckItem1
			' 
			Me.barCheckItem1.Caption = "SaveImmediately"
			Me.barCheckItem1.Id = 3
			Me.barCheckItem1.Name = "barCheckItem1"
'			Me.barCheckItem1.CheckedChanged += New DevExpress.XtraBars.ItemClickEventHandler(Me.barCheckItem1_CheckedChanged);
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.CausesValidation = False
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(472, 29)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.CausesValidation = False
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 261)
			Me.barDockControlBottom.Size = New System.Drawing.Size(472, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.CausesValidation = False
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 232)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.CausesValidation = False
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(472, 29)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 232)
			' 
			' TextEdit1
			' 
			Me.TextEdit1.EditValue = "TextEdit1"
			Me.TextEdit1.Location = New System.Drawing.Point(27, 76)
			Me.TextEdit1.Name = "TextEdit1"
			Me.TextEdit1.Size = New System.Drawing.Size(173, 20)
			Me.TextEdit1.TabIndex = 4
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(472, 261)
			Me.Controls.Add(Me.TextEdit1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "How to save an in-place editor's value to a BarEditItem immediately when it's cha" & "nged"
			CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

	#End Region

		Private helper As BarManagerHelper

		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			helper = New BarManagerHelper(BarManager1)
		End Sub


		Private Sub OnBarEditItemValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles BarEditItem1.EditValueChanged, BarEditItem2.EditValueChanged
			Dim item As BarEditItem = TryCast(sender, BarEditItem)
			Dim val As Object = item.EditValue
			Dim txt As String = String.Empty
			If val IsNot Nothing Then
				txt = val.ToString()
			End If
			XtraMessageBox.Show(txt)
		End Sub

		Private Sub barCheckItem1_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles barCheckItem1.CheckedChanged
			helper.SaveEditValueImmediately = barCheckItem1.Checked
		End Sub

		Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
			MyBase.OnFormClosing(e)
			helper.SaveEditValueImmediately = False
		End Sub


		<STAThread> _
		Shared Sub Main()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub


	End Class

End Namespace 'end of root namespace