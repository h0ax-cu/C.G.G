<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Gasto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Gasto))
        Dim IdLabel As System.Windows.Forms.Label
        Dim GastoLabel As System.Windows.Forms.Label
        Dim Tipo_de_gastoLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim OtrosLabel As System.Windows.Forms.Label
        Me.Bd_controlDataSet = New Control_de_Gasto_y_Ganacia.bd_controlDataSet()
        Me.GastoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GastoTableAdapter = New Control_de_Gasto_y_Ganacia.bd_controlDataSetTableAdapters.gastoTableAdapter()
        Me.TableAdapterManager = New Control_de_Gasto_y_Ganacia.bd_controlDataSetTableAdapters.TableAdapterManager()
        Me.GastoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GastoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.GastoTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_de_gastoComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OtrosTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        GastoLabel = New System.Windows.Forms.Label()
        Tipo_de_gastoLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        OtrosLabel = New System.Windows.Forms.Label()
        CType(Me.Bd_controlDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GastoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GastoBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'Bd_controlDataSet
        '
        Me.Bd_controlDataSet.DataSetName = "bd_controlDataSet"
        Me.Bd_controlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GastoBindingSource
        '
        Me.GastoBindingSource.DataMember = "gasto"
        Me.GastoBindingSource.DataSource = Me.Bd_controlDataSet
        '
        'GastoTableAdapter
        '
        Me.GastoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ganaciaTableAdapter = Nothing
        Me.TableAdapterManager.gastoTableAdapter = Me.GastoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Control_de_Gasto_y_Ganacia.bd_controlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GastoBindingNavigator
        '
        Me.GastoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GastoBindingNavigator.BindingSource = Me.GastoBindingSource
        Me.GastoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GastoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GastoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GastoBindingNavigatorSaveItem})
        Me.GastoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GastoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GastoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GastoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GastoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GastoBindingNavigator.Name = "GastoBindingNavigator"
        Me.GastoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GastoBindingNavigator.Size = New System.Drawing.Size(404, 27)
        Me.GastoBindingNavigator.TabIndex = 0
        Me.GastoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'GastoBindingNavigatorSaveItem
        '
        Me.GastoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GastoBindingNavigatorSaveItem.Image = CType(resources.GetObject("GastoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GastoBindingNavigatorSaveItem.Name = "GastoBindingNavigatorSaveItem"
        Me.GastoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.GastoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(14, 46)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(120, 43)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(110, 22)
        Me.IdTextBox.TabIndex = 2
        '
        'GastoLabel
        '
        GastoLabel.AutoSize = True
        GastoLabel.Location = New System.Drawing.Point(14, 74)
        GastoLabel.Name = "GastoLabel"
        GastoLabel.Size = New System.Drawing.Size(54, 17)
        GastoLabel.TabIndex = 3
        GastoLabel.Text = "Dinero:"
        '
        'GastoTextBox
        '
        Me.GastoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "gasto", True))
        Me.GastoTextBox.Location = New System.Drawing.Point(120, 71)
        Me.GastoTextBox.Name = "GastoTextBox"
        Me.GastoTextBox.Size = New System.Drawing.Size(110, 22)
        Me.GastoTextBox.TabIndex = 4
        '
        'Tipo_de_gastoLabel
        '
        Tipo_de_gastoLabel.AutoSize = True
        Tipo_de_gastoLabel.Location = New System.Drawing.Point(14, 102)
        Tipo_de_gastoLabel.Name = "Tipo_de_gastoLabel"
        Tipo_de_gastoLabel.Size = New System.Drawing.Size(102, 17)
        Tipo_de_gastoLabel.TabIndex = 5
        Tipo_de_gastoLabel.Text = "Tipo de Gasto:"
        '
        'Tipo_de_gastoComboBox
        '
        Me.Tipo_de_gastoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "tipo de gasto", True))
        Me.Tipo_de_gastoComboBox.FormattingEnabled = True
        Me.Tipo_de_gastoComboBox.Items.AddRange(New Object() {"Negocio", "Deudas a Pagar", "Casa", "Personal", "Comida", "Otros Gastos"})
        Me.Tipo_de_gastoComboBox.Location = New System.Drawing.Point(120, 99)
        Me.Tipo_de_gastoComboBox.Name = "Tipo_de_gastoComboBox"
        Me.Tipo_de_gastoComboBox.Size = New System.Drawing.Size(200, 24)
        Me.Tipo_de_gastoComboBox.TabIndex = 6
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(14, 134)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(51, 17)
        FechaLabel.TabIndex = 7
        FechaLabel.Text = "Fecha:"
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GastoBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(120, 130)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(266, 22)
        Me.FechaDateTimePicker.TabIndex = 8
        '
        'OtrosLabel
        '
        OtrosLabel.AutoSize = True
        OtrosLabel.Location = New System.Drawing.Point(14, 161)
        OtrosLabel.Name = "OtrosLabel"
        OtrosLabel.Size = New System.Drawing.Size(86, 17)
        OtrosLabel.TabIndex = 9
        OtrosLabel.Text = "Descripción:"
        '
        'OtrosTextBox
        '
        Me.OtrosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GastoBindingSource, "otros", True))
        Me.OtrosTextBox.Location = New System.Drawing.Point(120, 158)
        Me.OtrosTextBox.Name = "OtrosTextBox"
        Me.OtrosTextBox.Size = New System.Drawing.Size(266, 22)
        Me.OtrosTextBox.TabIndex = 10
        '
        'Agregar_Gasto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(404, 197)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(GastoLabel)
        Me.Controls.Add(Me.GastoTextBox)
        Me.Controls.Add(Tipo_de_gastoLabel)
        Me.Controls.Add(Me.Tipo_de_gastoComboBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(OtrosLabel)
        Me.Controls.Add(Me.OtrosTextBox)
        Me.Controls.Add(Me.GastoBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Agregar_Gasto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar_Gasto"
        CType(Me.Bd_controlDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GastoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GastoBindingNavigator.ResumeLayout(False)
        Me.GastoBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bd_controlDataSet As Control_de_Gasto_y_Ganacia.bd_controlDataSet
    Friend WithEvents GastoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GastoTableAdapter As Control_de_Gasto_y_Ganacia.bd_controlDataSetTableAdapters.gastoTableAdapter
    Friend WithEvents TableAdapterManager As Control_de_Gasto_y_Ganacia.bd_controlDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GastoBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GastoBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GastoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tipo_de_gastoComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OtrosTextBox As System.Windows.Forms.TextBox
End Class
