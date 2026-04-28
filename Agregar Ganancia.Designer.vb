<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Ganancia
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim GanaciaLabel As System.Windows.Forms.Label
        Dim Tipo_de_ganaciaLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim OtrosLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Ganancia))
        Me.Bd_controlDataSet = New Control_de_Gasto_y_Ganacia.bd_controlDataSet()
        Me.GanaciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GanaciaTableAdapter = New Control_de_Gasto_y_Ganacia.bd_controlDataSetTableAdapters.ganaciaTableAdapter()
        Me.TableAdapterManager = New Control_de_Gasto_y_Ganacia.bd_controlDataSetTableAdapters.TableAdapterManager()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.GanaciaBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.GanaciaBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.GanaciaTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_de_ganaciaComboBox = New System.Windows.Forms.ComboBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.OtrosTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        GanaciaLabel = New System.Windows.Forms.Label()
        Tipo_de_ganaciaLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        OtrosLabel = New System.Windows.Forms.Label()
        CType(Me.Bd_controlDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GanaciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GanaciaBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GanaciaBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(12, 41)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Id:"
        '
        'GanaciaLabel
        '
        GanaciaLabel.AutoSize = True
        GanaciaLabel.Location = New System.Drawing.Point(12, 69)
        GanaciaLabel.Name = "GanaciaLabel"
        GanaciaLabel.Size = New System.Drawing.Size(54, 17)
        GanaciaLabel.TabIndex = 3
        GanaciaLabel.Text = "Dinero:"
        '
        'Tipo_de_ganaciaLabel
        '
        Tipo_de_ganaciaLabel.AutoSize = True
        Tipo_de_ganaciaLabel.Location = New System.Drawing.Point(12, 97)
        Tipo_de_ganaciaLabel.Name = "Tipo_de_ganaciaLabel"
        Tipo_de_ganaciaLabel.Size = New System.Drawing.Size(125, 17)
        Tipo_de_ganaciaLabel.TabIndex = 5
        Tipo_de_ganaciaLabel.Text = "Tipo de Ganancia:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(12, 129)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(51, 17)
        FechaLabel.TabIndex = 7
        FechaLabel.Text = "Fecha:"
        '
        'OtrosLabel
        '
        OtrosLabel.AutoSize = True
        OtrosLabel.Location = New System.Drawing.Point(12, 156)
        OtrosLabel.Name = "OtrosLabel"
        OtrosLabel.Size = New System.Drawing.Size(86, 17)
        OtrosLabel.TabIndex = 9
        OtrosLabel.Text = "Descripción:"
        '
        'Bd_controlDataSet
        '
        Me.Bd_controlDataSet.DataSetName = "bd_controlDataSet"
        Me.Bd_controlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GanaciaBindingSource
        '
        Me.GanaciaBindingSource.DataMember = "ganacia"
        Me.GanaciaBindingSource.DataSource = Me.Bd_controlDataSet
        '
        'GanaciaTableAdapter
        '
        Me.GanaciaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ganaciaTableAdapter = Me.GanaciaTableAdapter
        Me.TableAdapterManager.gastoTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Control_de_Gasto_y_Ganacia.bd_controlDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
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
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
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
        'GanaciaBindingNavigatorSaveItem
        '
        Me.GanaciaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GanaciaBindingNavigatorSaveItem.Image = CType(resources.GetObject("GanaciaBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GanaciaBindingNavigatorSaveItem.Name = "GanaciaBindingNavigatorSaveItem"
        Me.GanaciaBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 24)
        Me.GanaciaBindingNavigatorSaveItem.Text = "Save Data"
        '
        'GanaciaBindingNavigator
        '
        Me.GanaciaBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GanaciaBindingNavigator.BindingSource = Me.GanaciaBindingSource
        Me.GanaciaBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GanaciaBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GanaciaBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GanaciaBindingNavigatorSaveItem})
        Me.GanaciaBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GanaciaBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GanaciaBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GanaciaBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GanaciaBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GanaciaBindingNavigator.Name = "GanaciaBindingNavigator"
        Me.GanaciaBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GanaciaBindingNavigator.Size = New System.Drawing.Size(437, 27)
        Me.GanaciaBindingNavigator.TabIndex = 0
        Me.GanaciaBindingNavigator.Text = "BindingNavigator1"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GanaciaBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(140, 38)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(139, 22)
        Me.IdTextBox.TabIndex = 2
        '
        'GanaciaTextBox
        '
        Me.GanaciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GanaciaBindingSource, "ganacia", True))
        Me.GanaciaTextBox.Location = New System.Drawing.Point(140, 66)
        Me.GanaciaTextBox.Name = "GanaciaTextBox"
        Me.GanaciaTextBox.Size = New System.Drawing.Size(139, 22)
        Me.GanaciaTextBox.TabIndex = 4
        '
        'Tipo_de_ganaciaComboBox
        '
        Me.Tipo_de_ganaciaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GanaciaBindingSource, "tipo de ganacia", True))
        Me.Tipo_de_ganaciaComboBox.FormattingEnabled = True
        Me.Tipo_de_ganaciaComboBox.Items.AddRange(New Object() {"Salario", "Prestamo", "Negocios", "Otras Ganancias"})
        Me.Tipo_de_ganaciaComboBox.Location = New System.Drawing.Point(140, 94)
        Me.Tipo_de_ganaciaComboBox.Name = "Tipo_de_ganaciaComboBox"
        Me.Tipo_de_ganaciaComboBox.Size = New System.Drawing.Size(200, 24)
        Me.Tipo_de_ganaciaComboBox.TabIndex = 6
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GanaciaBindingSource, "fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(140, 125)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(270, 22)
        Me.FechaDateTimePicker.TabIndex = 8
        '
        'OtrosTextBox
        '
        Me.OtrosTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GanaciaBindingSource, "otros", True))
        Me.OtrosTextBox.Location = New System.Drawing.Point(140, 153)
        Me.OtrosTextBox.Name = "OtrosTextBox"
        Me.OtrosTextBox.Size = New System.Drawing.Size(270, 22)
        Me.OtrosTextBox.TabIndex = 10
        '
        'Agregar_Ganancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(437, 201)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(GanaciaLabel)
        Me.Controls.Add(Me.GanaciaTextBox)
        Me.Controls.Add(Tipo_de_ganaciaLabel)
        Me.Controls.Add(Me.Tipo_de_ganaciaComboBox)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(OtrosLabel)
        Me.Controls.Add(Me.OtrosTextBox)
        Me.Controls.Add(Me.GanaciaBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Agregar_Ganancia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar_Ganancia"
        CType(Me.Bd_controlDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GanaciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GanaciaBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GanaciaBindingNavigator.ResumeLayout(False)
        Me.GanaciaBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Bd_controlDataSet As Control_de_Gasto_y_Ganacia.bd_controlDataSet
    Friend WithEvents GanaciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GanaciaTableAdapter As Control_de_Gasto_y_Ganacia.bd_controlDataSetTableAdapters.ganaciaTableAdapter
    Friend WithEvents TableAdapterManager As Control_de_Gasto_y_Ganacia.bd_controlDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GanaciaBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents GanaciaBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents IdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GanaciaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Tipo_de_ganaciaComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents OtrosTextBox As System.Windows.Forms.TextBox
End Class
