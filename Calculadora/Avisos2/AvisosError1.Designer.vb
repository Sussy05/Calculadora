<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AvisosError1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AvisosError1))
        Me.lblmensaje = New System.Windows.Forms.Label()
        Me.btnaceptar2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblmensaje
        '
        Me.lblmensaje.AutoSize = True
        Me.lblmensaje.BackColor = System.Drawing.Color.Transparent
        Me.lblmensaje.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmensaje.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblmensaje.Location = New System.Drawing.Point(12, 20)
        Me.lblmensaje.Name = "lblmensaje"
        Me.lblmensaje.Size = New System.Drawing.Size(283, 19)
        Me.lblmensaje.TabIndex = 1
        Me.lblmensaje.Text = "¡Error! No se puede completar la operación."
        '
        'btnaceptar2
        '
        Me.btnaceptar2.BackColor = System.Drawing.Color.Gray
        Me.btnaceptar2.FlatAppearance.BorderSize = 0
        Me.btnaceptar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaceptar2.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaceptar2.Image = CType(resources.GetObject("btnaceptar2.Image"), System.Drawing.Image)
        Me.btnaceptar2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnaceptar2.Location = New System.Drawing.Point(66, 60)
        Me.btnaceptar2.Name = "btnaceptar2"
        Me.btnaceptar2.Size = New System.Drawing.Size(158, 36)
        Me.btnaceptar2.TabIndex = 2
        Me.btnaceptar2.Text = "Aceptar"
        Me.btnaceptar2.UseVisualStyleBackColor = False
        '
        'AvisosError1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ClientSize = New System.Drawing.Size(299, 109)
        Me.Controls.Add(Me.btnaceptar2)
        Me.Controls.Add(Me.lblmensaje)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AvisosError1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AvisosError1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblmensaje As Label
    Friend WithEvents btnaceptar2 As Button
End Class
