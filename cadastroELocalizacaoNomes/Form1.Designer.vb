<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numQtdNomes = New System.Windows.Forms.NumericUpDown()
        Me.btnIniciarCadastro = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomeBusca = New System.Windows.Forms.TextBox()
        Me.btnLocalizarNome = New System.Windows.Forms.Button()
        CType(Me.numQtdNomes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Qtd. Nomes: "
        '
        'numQtdNomes
        '
        Me.numQtdNomes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numQtdNomes.Location = New System.Drawing.Point(127, 39)
        Me.numQtdNomes.Name = "numQtdNomes"
        Me.numQtdNomes.Size = New System.Drawing.Size(120, 21)
        Me.numQtdNomes.TabIndex = 1
        '
        'btnIniciarCadastro
        '
        Me.btnIniciarCadastro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciarCadastro.Location = New System.Drawing.Point(46, 70)
        Me.btnIniciarCadastro.Name = "btnIniciarCadastro"
        Me.btnIniciarCadastro.Size = New System.Drawing.Size(201, 30)
        Me.btnIniciarCadastro.TabIndex = 2
        Me.btnIniciarCadastro.Text = "Iniciar Cadastro"
        Me.btnIniciarCadastro.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nome: "
        '
        'txtNomeBusca
        '
        Me.txtNomeBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomeBusca.Location = New System.Drawing.Point(96, 146)
        Me.txtNomeBusca.Name = "txtNomeBusca"
        Me.txtNomeBusca.Size = New System.Drawing.Size(151, 21)
        Me.txtNomeBusca.TabIndex = 4
        '
        'btnLocalizarNome
        '
        Me.btnLocalizarNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalizarNome.Location = New System.Drawing.Point(46, 173)
        Me.btnLocalizarNome.Name = "btnLocalizarNome"
        Me.btnLocalizarNome.Size = New System.Drawing.Size(201, 30)
        Me.btnLocalizarNome.TabIndex = 5
        Me.btnLocalizarNome.Text = "Localizar Nome"
        Me.btnLocalizarNome.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 247)
        Me.Controls.Add(Me.btnLocalizarNome)
        Me.Controls.Add(Me.txtNomeBusca)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnIniciarCadastro)
        Me.Controls.Add(Me.numQtdNomes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Cadastro e Localização de Nomes"
        CType(Me.numQtdNomes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numQtdNomes As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnIniciarCadastro As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNomeBusca As System.Windows.Forms.TextBox
    Friend WithEvents btnLocalizarNome As System.Windows.Forms.Button

End Class
