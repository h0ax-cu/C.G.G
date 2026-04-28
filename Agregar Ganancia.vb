Public Class Agregar_Ganancia

    Private Sub GanaciaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles GanaciaBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.GanaciaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd_controlDataSet)

    End Sub

    Private Sub Agregar_Ganancia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bd_controlDataSet.ganacia' table. You can move, or remove it, as needed.
        Me.GanaciaTableAdapter.Fill(Me.Bd_controlDataSet.ganacia)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub Tipo_de_ganaciaTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class