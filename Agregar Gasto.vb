Public Class Agregar_Gasto

    Private Sub GastoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GastoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GastoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd_controlDataSet)

    End Sub

    Private Sub Agregar_Gasto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bd_controlDataSet.gasto' table. You can move, or remove it, as needed.
        Me.GastoTableAdapter.Fill(Me.Bd_controlDataSet.gasto)

    End Sub
End Class