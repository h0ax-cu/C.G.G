Public Class Form1

    Private Sub GastoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.GastoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Bd_controlDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Bd_controlDataSet.ganacia' table. You can move, or remove it, as needed.
        Me.GanaciaTableAdapter.Fill(Me.Bd_controlDataSet.ganacia)
        'TODO: This line of code loads data into the 'Bd_controlDataSet.gasto' table. You can move, or remove it, as needed.
        Me.GastoTableAdapter.Fill(Me.Bd_controlDataSet.gasto)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Agregar_Gasto.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Agregar_Ganancia.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.GanaciaTableAdapter.Fill(Me.Bd_controlDataSet.ganacia)
        Me.GastoTableAdapter.Fill(Me.Bd_controlDataSet.gasto)


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AboutBox1.Show()

    End Sub

    Private Sub GanaciaDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GanaciaDataGridView.CellContentClick

    End Sub

    Private Sub GastoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GastoDataGridView.CellContentClick

    End Sub
End Class
