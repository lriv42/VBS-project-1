<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TileCalc
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.calcualtebtn = New System.Windows.Forms.Button()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.exitbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLength = New System.Windows.Forms.TextBox()
        Me.txtWidth = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblTsqft = New System.Windows.Forms.Label()
        Me.lblTPrice = New System.Windows.Forms.Label()
        Me.CmpnyNm = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'calcualtebtn
        '
        Me.calcualtebtn.BackColor = System.Drawing.SystemColors.Info
        Me.calcualtebtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcualtebtn.Location = New System.Drawing.Point(153, 425)
        Me.calcualtebtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.calcualtebtn.Name = "calcualtebtn"
        Me.calcualtebtn.Size = New System.Drawing.Size(132, 57)
        Me.calcualtebtn.TabIndex = 3
        Me.calcualtebtn.Text = "&Calculate"
        Me.calcualtebtn.UseVisualStyleBackColor = False
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.SystemColors.Info
        Me.clearbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.Location = New System.Drawing.Point(452, 425)
        Me.clearbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(132, 57)
        Me.clearbtn.TabIndex = 4
        Me.clearbtn.Text = "Clea&r"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'exitbtn
        '
        Me.exitbtn.BackColor = System.Drawing.Color.Maroon
        Me.exitbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.exitbtn.Location = New System.Drawing.Point(763, 425)
        Me.exitbtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.Size = New System.Drawing.Size(132, 57)
        Me.exitbtn.TabIndex = 5
        Me.exitbtn.Text = "E&xit"
        Me.exitbtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 128)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Length :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 203)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Width :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 265)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Price :"
        '
        'txtLength
        '
        Me.txtLength.Location = New System.Drawing.Point(169, 123)
        Me.txtLength.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtLength.Name = "txtLength"
        Me.txtLength.Size = New System.Drawing.Size(132, 22)
        Me.txtLength.TabIndex = 0
        '
        'txtWidth
        '
        Me.txtWidth.Location = New System.Drawing.Point(169, 198)
        Me.txtWidth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(132, 22)
        Me.txtWidth.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(169, 263)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(132, 22)
        Me.txtPrice.TabIndex = 2
        '
        'lblTsqft
        '
        Me.lblTsqft.AutoSize = True
        Me.lblTsqft.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTsqft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTsqft.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTsqft.Location = New System.Drawing.Point(500, 186)
        Me.lblTsqft.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTsqft.MinimumSize = New System.Drawing.Size(133, 37)
        Me.lblTsqft.Name = "lblTsqft"
        Me.lblTsqft.Size = New System.Drawing.Size(133, 37)
        Me.lblTsqft.TabIndex = 11
        '
        'lblTPrice
        '
        Me.lblTPrice.AutoSize = True
        Me.lblTPrice.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTPrice.Location = New System.Drawing.Point(500, 248)
        Me.lblTPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTPrice.MinimumSize = New System.Drawing.Size(133, 37)
        Me.lblTPrice.Name = "lblTPrice"
        Me.lblTPrice.Size = New System.Drawing.Size(133, 37)
        Me.lblTPrice.TabIndex = 12
        '
        'CmpnyNm
        '
        Me.CmpnyNm.AutoSize = True
        Me.CmpnyNm.Font = New System.Drawing.Font("Microsoft Uighur", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmpnyNm.Location = New System.Drawing.Point(395, 9)
        Me.CmpnyNm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.CmpnyNm.Name = "CmpnyNm"
        Me.CmpnyNm.Size = New System.Drawing.Size(313, 79)
        Me.CmpnyNm.TabIndex = 13
        Me.CmpnyNm.Text = "Tile Limited Inc."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Project_1_Limited_Inc_Liam_Rivers.My.Resources.Resources.Tile_company_logo
        Me.PictureBox1.Location = New System.Drawing.Point(796, 123)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(142, 196)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(392, 265)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Total Price :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(396, 198)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Total Area :"
        '
        'TileCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CmpnyNm)
        Me.Controls.Add(Me.lblTPrice)
        Me.Controls.Add(Me.lblTsqft)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtWidth)
        Me.Controls.Add(Me.txtLength)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.calcualtebtn)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "TileCalc"
        Me.Text = "Tile Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcualtebtn As Button
    Friend WithEvents clearbtn As Button
    Friend WithEvents exitbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLength As TextBox
    Friend WithEvents txtWidth As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblTsqft As Label
    Friend WithEvents lblTPrice As Label
    Friend WithEvents CmpnyNm As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
