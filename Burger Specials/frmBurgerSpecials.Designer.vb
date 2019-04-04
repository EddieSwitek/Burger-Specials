<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBurgerSpecials
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picBeef = New System.Windows.Forms.PictureBox()
        Me.picVeggie = New System.Windows.Forms.PictureBox()
        Me.btnBeef = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnVeggie = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.picBeef, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(241, 27)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(233, 25)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Farm Burger Specials"
        '
        'picBeef
        '
        Me.picBeef.Location = New System.Drawing.Point(12, 68)
        Me.picBeef.Name = "picBeef"
        Me.picBeef.Size = New System.Drawing.Size(300, 250)
        Me.picBeef.TabIndex = 1
        Me.picBeef.TabStop = False
        '
        'picVeggie
        '
        Me.picVeggie.Location = New System.Drawing.Point(402, 68)
        Me.picVeggie.Name = "picVeggie"
        Me.picVeggie.Size = New System.Drawing.Size(300, 250)
        Me.picVeggie.TabIndex = 2
        Me.picVeggie.TabStop = False
        '
        'btnBeef
        '
        Me.btnBeef.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeef.Location = New System.Drawing.Point(99, 338)
        Me.btnBeef.Name = "btnBeef"
        Me.btnBeef.Size = New System.Drawing.Size(126, 36)
        Me.btnBeef.TabIndex = 3
        Me.btnBeef.Text = "Prime Beef"
        Me.btnBeef.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(294, 338)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(126, 36)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Select Meal"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnVeggie
        '
        Me.btnVeggie.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVeggie.Location = New System.Drawing.Point(489, 338)
        Me.btnVeggie.Name = "btnVeggie"
        Me.btnVeggie.Size = New System.Drawing.Size(126, 36)
        Me.btnVeggie.TabIndex = 5
        Me.btnVeggie.Text = "Veggie"
        Me.btnVeggie.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(213, 406)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(288, 14)
        Me.lblInstructions.TabIndex = 6
        Me.lblInstructions.Text = "Choose a burger then click the Select Meal button."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(283, 449)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 14)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Enjoy your burger special!"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(294, 517)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 36)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmBurgerSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 661)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.btnVeggie)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnBeef)
        Me.Controls.Add(Me.picVeggie)
        Me.Controls.Add(Me.picBeef)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmBurgerSpecials"
        Me.Text = "Burger Specials"
        CType(Me.picBeef, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVeggie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picBeef As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents btnBeef As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnVeggie As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
End Class
