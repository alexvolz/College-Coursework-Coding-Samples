<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUSDollars = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblForeignDollars = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radChinYuan = New System.Windows.Forms.RadioButton()
        Me.radBritPound = New System.Windows.Forms.RadioButton()
        Me.radSAfrRand = New System.Windows.Forms.RadioButton()
        Me.radMexiPeso = New System.Windows.Forms.RadioButton()
        Me.radJapaYen = New System.Windows.Forms.RadioButton()
        Me.radIndiRupee = New System.Windows.Forms.RadioButton()
        Me.radEuro = New System.Windows.Forms.RadioButton()
        Me.radCanaDollar = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(87, 213)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 43)
        Me.btnConvert.TabIndex = 3
        Me.btnConvert.Text = "Con&vert Money"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(168, 213)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 43)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 160)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&U.S. Dollars:"
        '
        'txtUSDollars
        '
        Me.txtUSDollars.Location = New System.Drawing.Point(157, 156)
        Me.txtUSDollars.Name = "txtUSDollars"
        Me.txtUSDollars.Size = New System.Drawing.Size(100, 25)
        Me.txtUSDollars.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Foreign Dollars:"
        '
        'lblForeignDollars
        '
        Me.lblForeignDollars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblForeignDollars.Location = New System.Drawing.Point(168, 184)
        Me.lblForeignDollars.Name = "lblForeignDollars"
        Me.lblForeignDollars.Size = New System.Drawing.Size(100, 25)
        Me.lblForeignDollars.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radChinYuan)
        Me.GroupBox1.Controls.Add(Me.radBritPound)
        Me.GroupBox1.Controls.Add(Me.radSAfrRand)
        Me.GroupBox1.Controls.Add(Me.radMexiPeso)
        Me.GroupBox1.Controls.Add(Me.radJapaYen)
        Me.GroupBox1.Controls.Add(Me.radIndiRupee)
        Me.GroupBox1.Controls.Add(Me.radEuro)
        Me.GroupBox1.Controls.Add(Me.radCanaDollar)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 138)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Foreign Currencies"
        '
        'radChinYuan
        '
        Me.radChinYuan.AutoSize = True
        Me.radChinYuan.Location = New System.Drawing.Point(131, 105)
        Me.radChinYuan.Name = "radChinYuan"
        Me.radChinYuan.Size = New System.Drawing.Size(103, 21)
        Me.radChinYuan.TabIndex = 7
        Me.radChinYuan.Text = "C&hinese Yuan"
        Me.radChinYuan.UseVisualStyleBackColor = True
        '
        'radBritPound
        '
        Me.radBritPound.AutoSize = True
        Me.radBritPound.Location = New System.Drawing.Point(6, 106)
        Me.radBritPound.Name = "radBritPound"
        Me.radBritPound.Size = New System.Drawing.Size(102, 21)
        Me.radBritPound.TabIndex = 6
        Me.radBritPound.Text = "&British Pound"
        Me.radBritPound.UseVisualStyleBackColor = True
        '
        'radSAfrRand
        '
        Me.radSAfrRand.AutoSize = True
        Me.radSAfrRand.Location = New System.Drawing.Point(131, 78)
        Me.radSAfrRand.Name = "radSAfrRand"
        Me.radSAfrRand.Size = New System.Drawing.Size(137, 21)
        Me.radSAfrRand.TabIndex = 5
        Me.radSAfrRand.Text = "South &African Rand"
        Me.radSAfrRand.UseVisualStyleBackColor = True
        '
        'radMexiPeso
        '
        Me.radMexiPeso.AutoSize = True
        Me.radMexiPeso.Location = New System.Drawing.Point(6, 79)
        Me.radMexiPeso.Name = "radMexiPeso"
        Me.radMexiPeso.Size = New System.Drawing.Size(106, 21)
        Me.radMexiPeso.TabIndex = 4
        Me.radMexiPeso.Text = "&Mexican Peso"
        Me.radMexiPeso.UseVisualStyleBackColor = True
        '
        'radJapaYen
        '
        Me.radJapaYen.AutoSize = True
        Me.radJapaYen.Location = New System.Drawing.Point(131, 51)
        Me.radJapaYen.Name = "radJapaYen"
        Me.radJapaYen.Size = New System.Drawing.Size(105, 21)
        Me.radJapaYen.TabIndex = 3
        Me.radJapaYen.Text = "&Japanese Yen"
        Me.radJapaYen.UseVisualStyleBackColor = True
        '
        'radIndiRupee
        '
        Me.radIndiRupee.AutoSize = True
        Me.radIndiRupee.Location = New System.Drawing.Point(6, 51)
        Me.radIndiRupee.Name = "radIndiRupee"
        Me.radIndiRupee.Size = New System.Drawing.Size(102, 21)
        Me.radIndiRupee.TabIndex = 2
        Me.radIndiRupee.Text = "&Indian Rupee"
        Me.radIndiRupee.UseVisualStyleBackColor = True
        '
        'radEuro
        '
        Me.radEuro.AutoSize = True
        Me.radEuro.Location = New System.Drawing.Point(131, 24)
        Me.radEuro.Name = "radEuro"
        Me.radEuro.Size = New System.Drawing.Size(53, 21)
        Me.radEuro.TabIndex = 1
        Me.radEuro.Text = "&Euro"
        Me.radEuro.UseVisualStyleBackColor = True
        '
        'radCanaDollar
        '
        Me.radCanaDollar.AutoSize = True
        Me.radCanaDollar.Checked = True
        Me.radCanaDollar.Location = New System.Drawing.Point(6, 24)
        Me.radCanaDollar.Name = "radCanaDollar"
        Me.radCanaDollar.Size = New System.Drawing.Size(119, 21)
        Me.radCanaDollar.TabIndex = 0
        Me.radCanaDollar.TabStop = True
        Me.radCanaDollar.Text = "&Canadian Dollar"
        Me.radCanaDollar.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 268)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblForeignDollars)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUSDollars)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnConvert)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency Solution"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUSDollars As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblForeignDollars As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radChinYuan As System.Windows.Forms.RadioButton
    Friend WithEvents radBritPound As System.Windows.Forms.RadioButton
    Friend WithEvents radSAfrRand As System.Windows.Forms.RadioButton
    Friend WithEvents radMexiPeso As System.Windows.Forms.RadioButton
    Friend WithEvents radJapaYen As System.Windows.Forms.RadioButton
    Friend WithEvents radIndiRupee As System.Windows.Forms.RadioButton
    Friend WithEvents radEuro As System.Windows.Forms.RadioButton
    Friend WithEvents radCanaDollar As System.Windows.Forms.RadioButton

End Class
