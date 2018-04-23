Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors.Repository

Namespace WindowsApplication41
	Public Class BarManagerHelper
		Private manager As BarManager

		Public Sub New(ByVal manager As BarManager)
			Me.manager = manager
		End Sub

		Public WriteOnly Property SaveEditValueImmediately() As Boolean
			Set(ByVal value As Boolean)
				UnsubscribeFromEvents()
				If value Then
					SubscribeToEvents()
				End If
			End Set
		End Property

		Private Sub SubscribeToEvents()
			AddHandler manager.RepositoryItems.CollectionChanged, AddressOf OnRepositoryItemsCollectionChanged
			For Each item As RepositoryItem In manager.RepositoryItems
				AddHandler item.EditValueChanged, AddressOf OnEditValueChanged
			Next item
		End Sub

		Private Sub UnsubscribeFromEvents()
			RemoveHandler manager.RepositoryItems.CollectionChanged, AddressOf OnRepositoryItemsCollectionChanged
			For Each item As RepositoryItem In manager.RepositoryItems
				RemoveHandler item.EditValueChanged, AddressOf OnEditValueChanged
			Next item
		End Sub

		Private Sub OnEditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			manager.ActiveEditItemLink.PostEditor()
		End Sub

		Private Sub OnRepositoryItemsCollectionChanged(ByVal sender As Object, ByVal e As System.ComponentModel.CollectionChangeEventArgs)
			Dim item As RepositoryItem = TryCast(e.Element, RepositoryItem)
			If e.Action = System.ComponentModel.CollectionChangeAction.Add Then
				AddHandler item.EditValueChanged, AddressOf OnEditValueChanged
			End If
			If e.Action = System.ComponentModel.CollectionChangeAction.Remove Then
				RemoveHandler item.EditValueChanged, AddressOf OnEditValueChanged
			End If
		End Sub

	End Class
End Namespace
