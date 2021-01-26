<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formBase
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlNav = New System.Windows.Forms.Panel()
        Me.btnCredits = New System.Windows.Forms.Button()
        Me.btnCharacterRecords = New System.Windows.Forms.Button()
        Me.btnWeaponRecords = New System.Windows.Forms.Button()
        Me.btnExp = New System.Windows.Forms.Button()
        Me.btnBuilds = New System.Windows.Forms.Button()
        Me.btnFarming = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.pnlLoader = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoader.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pnlNav)
        Me.Panel1.Controls.Add(Me.btnCredits)
        Me.Panel1.Controls.Add(Me.btnCharacterRecords)
        Me.Panel1.Controls.Add(Me.btnWeaponRecords)
        Me.Panel1.Controls.Add(Me.btnExp)
        Me.Panel1.Controls.Add(Me.btnBuilds)
        Me.Panel1.Controls.Add(Me.btnFarming)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(186, 577)
        Me.Panel1.TabIndex = 0
        '
        'pnlNav
        '
        Me.pnlNav.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.pnlNav.Location = New System.Drawing.Point(0, 193)
        Me.pnlNav.Name = "pnlNav"
        Me.pnlNav.Size = New System.Drawing.Size(3, 100)
        Me.pnlNav.TabIndex = 1
        '
        'btnCredits
        '
        Me.btnCredits.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnCredits.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCredits.FlatAppearance.BorderSize = 0
        Me.btnCredits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCredits.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCredits.ForeColor = System.Drawing.Color.Crimson
        Me.btnCredits.Location = New System.Drawing.Point(0, 535)
        Me.btnCredits.Name = "btnCredits"
        Me.btnCredits.Size = New System.Drawing.Size(186, 42)
        Me.btnCredits.TabIndex = 1
        Me.btnCredits.Text = "ABOUT"
        Me.btnCredits.UseVisualStyleBackColor = False
        '
        'btnCharacterRecords
        '
        Me.btnCharacterRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnCharacterRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCharacterRecords.FlatAppearance.BorderSize = 0
        Me.btnCharacterRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCharacterRecords.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCharacterRecords.ForeColor = System.Drawing.Color.Crimson
        Me.btnCharacterRecords.Location = New System.Drawing.Point(0, 288)
        Me.btnCharacterRecords.Name = "btnCharacterRecords"
        Me.btnCharacterRecords.Size = New System.Drawing.Size(186, 42)
        Me.btnCharacterRecords.TabIndex = 1
        Me.btnCharacterRecords.Text = "CHARACTER RECORDS"
        Me.btnCharacterRecords.UseVisualStyleBackColor = False
        '
        'btnWeaponRecords
        '
        Me.btnWeaponRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnWeaponRecords.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnWeaponRecords.FlatAppearance.BorderSize = 0
        Me.btnWeaponRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeaponRecords.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeaponRecords.ForeColor = System.Drawing.Color.Crimson
        Me.btnWeaponRecords.Location = New System.Drawing.Point(0, 246)
        Me.btnWeaponRecords.Name = "btnWeaponRecords"
        Me.btnWeaponRecords.Size = New System.Drawing.Size(186, 42)
        Me.btnWeaponRecords.TabIndex = 1
        Me.btnWeaponRecords.Text = "WEAPON RECORDS"
        Me.btnWeaponRecords.UseVisualStyleBackColor = False
        '
        'btnExp
        '
        Me.btnExp.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnExp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnExp.FlatAppearance.BorderSize = 0
        Me.btnExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExp.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExp.ForeColor = System.Drawing.Color.Crimson
        Me.btnExp.Location = New System.Drawing.Point(0, 204)
        Me.btnExp.Name = "btnExp"
        Me.btnExp.Size = New System.Drawing.Size(186, 42)
        Me.btnExp.TabIndex = 1
        Me.btnExp.Text = "EXP CALCULATOR"
        Me.btnExp.UseVisualStyleBackColor = False
        '
        'btnBuilds
        '
        Me.btnBuilds.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnBuilds.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBuilds.FlatAppearance.BorderSize = 0
        Me.btnBuilds.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuilds.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuilds.ForeColor = System.Drawing.Color.Crimson
        Me.btnBuilds.Location = New System.Drawing.Point(0, 162)
        Me.btnBuilds.Name = "btnBuilds"
        Me.btnBuilds.Size = New System.Drawing.Size(186, 42)
        Me.btnBuilds.TabIndex = 1
        Me.btnBuilds.Text = "BUILDS"
        Me.btnBuilds.UseVisualStyleBackColor = False
        '
        'btnFarming
        '
        Me.btnFarming.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.btnFarming.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFarming.FlatAppearance.BorderSize = 0
        Me.btnFarming.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFarming.Font = New System.Drawing.Font("Inter", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFarming.ForeColor = System.Drawing.Color.Crimson
        Me.btnFarming.Location = New System.Drawing.Point(0, 120)
        Me.btnFarming.Name = "btnFarming"
        Me.btnFarming.Size = New System.Drawing.Size(186, 42)
        Me.btnFarming.TabIndex = 1
        Me.btnFarming.Text = "FARMING"
        Me.btnFarming.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(186, 120)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(186, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Montserrat", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(20, 17)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(157, 39)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "FARMING"
        '
        'pnlLoader
        '
        Me.pnlLoader.Controls.Add(Me.GroupBox1)
        Me.pnlLoader.Controls.Add(Me.btnClose)
        Me.pnlLoader.Controls.Add(Me.lblName)
        Me.pnlLoader.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlLoader.Location = New System.Drawing.Point(186, 0)
        Me.pnlLoader.Name = "pnlLoader"
        Me.pnlLoader.Size = New System.Drawing.Size(765, 577)
        Me.pnlLoader.TabIndex = 2
        '
        'btnClose
        '
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Montserrat Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(732, 3)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 30)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(6, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'formBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(951, 577)
        Me.Controls.Add(Me.pnlLoader)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "formBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formBase"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoader.ResumeLayout(False)
        Me.pnlLoader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnFarming As Button
    Friend WithEvents btnCredits As Button
    Friend WithEvents btnCharacterRecords As Button
    Friend WithEvents btnWeaponRecords As Button
    Friend WithEvents btnExp As Button
    Friend WithEvents btnBuilds As Button
    Friend WithEvents pnlNav As Panel
    Friend WithEvents lblName As Label
    Friend WithEvents pnlLoader As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
