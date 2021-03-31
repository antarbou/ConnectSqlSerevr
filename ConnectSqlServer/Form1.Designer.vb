<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.dgvEtudiant = New System.Windows.Forms.DataGridView
        Me.Button3 = New System.Windows.Forms.Button
        CType(Me.dgvEtudiant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(396, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 49)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Insert"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(396, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 49)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgvEtudiant
        '
        Me.dgvEtudiant.AllowUserToAddRows = False
        Me.dgvEtudiant.AllowUserToDeleteRows = False
        Me.dgvEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEtudiant.Location = New System.Drawing.Point(28, 45)
        Me.dgvEtudiant.Name = "dgvEtudiant"
        Me.dgvEtudiant.ReadOnly = True
        Me.dgvEtudiant.Size = New System.Drawing.Size(350, 289)
        Me.dgvEtudiant.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(396, 109)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 49)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 346)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgvEtudiant)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Acuille"
        CType(Me.dgvEtudiant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgvEtudiant As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
