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
        Me.optSingapore = New System.Windows.Forms.RadioButton()
        Me.optBrazil = New System.Windows.Forms.RadioButton()
        Me.picFlag = New System.Windows.Forms.PictureBox()
        Me.btnClac = New System.Windows.Forms.Button()
        Me.txtUSD = New System.Windows.Forms.TextBox()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.optRussia = New System.Windows.Forms.RadioButton()
        Me.optCuba = New System.Windows.Forms.RadioButton()
        Me.optJapen = New System.Windows.Forms.RadioButton()
        Me.optCanada = New System.Windows.Forms.RadioButton()
        Me.optMexico = New System.Windows.Forms.RadioButton()
        Me.optAstraila = New System.Windows.Forms.RadioButton()
        Me.optIndia = New System.Windows.Forms.RadioButton()
        Me.optEuro = New System.Windows.Forms.RadioButton()
        CType(Me.picFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'optSingapore
        '
        Me.optSingapore.AutoSize = True
        Me.optSingapore.Location = New System.Drawing.Point(48, 44)
        Me.optSingapore.Name = "optSingapore"
        Me.optSingapore.Size = New System.Drawing.Size(91, 20)
        Me.optSingapore.TabIndex = 0
        Me.optSingapore.TabStop = True
        Me.optSingapore.Text = "Singapore"
        Me.optSingapore.UseVisualStyleBackColor = True
        '
        'optBrazil
        '
        Me.optBrazil.AutoSize = True
        Me.optBrazil.Location = New System.Drawing.Point(48, 174)
        Me.optBrazil.Name = "optBrazil"
        Me.optBrazil.Size = New System.Drawing.Size(61, 20)
        Me.optBrazil.TabIndex = 1
        Me.optBrazil.TabStop = True
        Me.optBrazil.Text = "Brazil"
        Me.optBrazil.UseVisualStyleBackColor = True
        '
        'picFlag
        '
        Me.picFlag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picFlag.Location = New System.Drawing.Point(199, 84)
        Me.picFlag.Name = "picFlag"
        Me.picFlag.Size = New System.Drawing.Size(401, 175)
        Me.picFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picFlag.TabIndex = 2
        Me.picFlag.TabStop = False
        '
        'btnClac
        '
        Me.btnClac.Location = New System.Drawing.Point(344, 41)
        Me.btnClac.Name = "btnClac"
        Me.btnClac.Size = New System.Drawing.Size(111, 23)
        Me.btnClac.TabIndex = 3
        Me.btnClac.Text = "Calculate"
        Me.btnClac.UseVisualStyleBackColor = True
        '
        'txtUSD
        '
        Me.txtUSD.Location = New System.Drawing.Point(344, 338)
        Me.txtUSD.Name = "txtUSD"
        Me.txtUSD.Size = New System.Drawing.Size(100, 22)
        Me.txtUSD.TabIndex = 4
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Location = New System.Drawing.Point(371, 296)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(38, 16)
        Me.lblFinal.TabIndex = 5
        Me.lblFinal.Text = "$0.00"
        '
        'optRussia
        '
        Me.optRussia.AutoSize = True
        Me.optRussia.Location = New System.Drawing.Point(48, 278)
        Me.optRussia.Name = "optRussia"
        Me.optRussia.Size = New System.Drawing.Size(70, 20)
        Me.optRussia.TabIndex = 6
        Me.optRussia.TabStop = True
        Me.optRussia.Text = "Russia"
        Me.optRussia.UseVisualStyleBackColor = True
        '
        'optCuba
        '
        Me.optCuba.AutoSize = True
        Me.optCuba.Location = New System.Drawing.Point(48, 252)
        Me.optCuba.Name = "optCuba"
        Me.optCuba.Size = New System.Drawing.Size(60, 20)
        Me.optCuba.TabIndex = 7
        Me.optCuba.TabStop = True
        Me.optCuba.Text = "Cuba"
        Me.optCuba.UseVisualStyleBackColor = True
        '
        'optJapen
        '
        Me.optJapen.AutoSize = True
        Me.optJapen.Location = New System.Drawing.Point(48, 226)
        Me.optJapen.Name = "optJapen"
        Me.optJapen.Size = New System.Drawing.Size(66, 20)
        Me.optJapen.TabIndex = 8
        Me.optJapen.TabStop = True
        Me.optJapen.Text = "Japen"
        Me.optJapen.UseVisualStyleBackColor = True
        '
        'optCanada
        '
        Me.optCanada.AutoSize = True
        Me.optCanada.Location = New System.Drawing.Point(48, 200)
        Me.optCanada.Name = "optCanada"
        Me.optCanada.Size = New System.Drawing.Size(76, 20)
        Me.optCanada.TabIndex = 9
        Me.optCanada.TabStop = True
        Me.optCanada.Text = "Canada"
        Me.optCanada.UseVisualStyleBackColor = True
        '
        'optMexico
        '
        Me.optMexico.AutoSize = True
        Me.optMexico.Location = New System.Drawing.Point(48, 148)
        Me.optMexico.Name = "optMexico"
        Me.optMexico.Size = New System.Drawing.Size(71, 20)
        Me.optMexico.TabIndex = 10
        Me.optMexico.TabStop = True
        Me.optMexico.Text = "Mexico"
        Me.optMexico.UseVisualStyleBackColor = True
        '
        'optAstraila
        '
        Me.optAstraila.AutoSize = True
        Me.optAstraila.Location = New System.Drawing.Point(48, 122)
        Me.optAstraila.Name = "optAstraila"
        Me.optAstraila.Size = New System.Drawing.Size(73, 20)
        Me.optAstraila.TabIndex = 11
        Me.optAstraila.TabStop = True
        Me.optAstraila.Text = "Astraila"
        Me.optAstraila.UseVisualStyleBackColor = True
        '
        'optIndia
        '
        Me.optIndia.AutoSize = True
        Me.optIndia.Location = New System.Drawing.Point(48, 70)
        Me.optIndia.Name = "optIndia"
        Me.optIndia.Size = New System.Drawing.Size(57, 20)
        Me.optIndia.TabIndex = 12
        Me.optIndia.TabStop = True
        Me.optIndia.Text = "India"
        Me.optIndia.UseVisualStyleBackColor = True
        '
        'optEuro
        '
        Me.optEuro.AutoSize = True
        Me.optEuro.Location = New System.Drawing.Point(48, 96)
        Me.optEuro.Name = "optEuro"
        Me.optEuro.Size = New System.Drawing.Size(56, 20)
        Me.optEuro.TabIndex = 13
        Me.optEuro.TabStop = True
        Me.optEuro.Text = "Euro"
        Me.optEuro.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.optEuro)
        Me.Controls.Add(Me.optIndia)
        Me.Controls.Add(Me.optAstraila)
        Me.Controls.Add(Me.optMexico)
        Me.Controls.Add(Me.optCanada)
        Me.Controls.Add(Me.optJapen)
        Me.Controls.Add(Me.optCuba)
        Me.Controls.Add(Me.optRussia)
        Me.Controls.Add(Me.lblFinal)
        Me.Controls.Add(Me.txtUSD)
        Me.Controls.Add(Me.btnClac)
        Me.Controls.Add(Me.picFlag)
        Me.Controls.Add(Me.optBrazil)
        Me.Controls.Add(Me.optSingapore)
        Me.Name = "Form1"
        Me.Text = "Currency Coverter"
        CType(Me.picFlag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents optSingapore As RadioButton
    Friend WithEvents optBrazil As RadioButton
    Friend WithEvents picFlag As PictureBox
    Friend WithEvents btnClac As Button
    Friend WithEvents txtUSD As TextBox
    Friend WithEvents lblFinal As Label
    Friend WithEvents optRussia As RadioButton
    Friend WithEvents optCuba As RadioButton
    Friend WithEvents optJapen As RadioButton
    Friend WithEvents optCanada As RadioButton
    Friend WithEvents optMexico As RadioButton
    Friend WithEvents optAstraila As RadioButton
    Friend WithEvents optIndia As RadioButton
    Friend WithEvents optEuro As RadioButton
End Class
