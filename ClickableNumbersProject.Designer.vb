<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClickableNumbers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClickableNumbers))
        Me.picOne = New System.Windows.Forms.PictureBox()
        Me.picFour = New System.Windows.Forms.PictureBox()
        Me.picTwo = New System.Windows.Forms.PictureBox()
        Me.picThree = New System.Windows.Forms.PictureBox()
        Me.picFive = New System.Windows.Forms.PictureBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picOne
        '
        Me.picOne.Image = CType(resources.GetObject("picOne.Image"), System.Drawing.Image)
        Me.picOne.Location = New System.Drawing.Point(1, 81)
        Me.picOne.Name = "picOne"
        Me.picOne.Size = New System.Drawing.Size(85, 147)
        Me.picOne.TabIndex = 0
        Me.picOne.TabStop = False
        '
        'picFour
        '
        Me.picFour.Image = CType(resources.GetObject("picFour.Image"), System.Drawing.Image)
        Me.picFour.Location = New System.Drawing.Point(506, 81)
        Me.picFour.Name = "picFour"
        Me.picFour.Size = New System.Drawing.Size(83, 147)
        Me.picFour.TabIndex = 1
        Me.picFour.TabStop = False
        '
        'picTwo
        '
        Me.picTwo.Image = CType(resources.GetObject("picTwo.Image"), System.Drawing.Image)
        Me.picTwo.Location = New System.Drawing.Point(168, 81)
        Me.picTwo.Name = "picTwo"
        Me.picTwo.Size = New System.Drawing.Size(87, 147)
        Me.picTwo.TabIndex = 2
        Me.picTwo.TabStop = False
        '
        'picThree
        '
        Me.picThree.Image = CType(resources.GetObject("picThree.Image"), System.Drawing.Image)
        Me.picThree.Location = New System.Drawing.Point(338, 81)
        Me.picThree.Name = "picThree"
        Me.picThree.Size = New System.Drawing.Size(84, 147)
        Me.picThree.TabIndex = 3
        Me.picThree.TabStop = False
        '
        'picFive
        '
        Me.picFive.Image = CType(resources.GetObject("picFive.Image"), System.Drawing.Image)
        Me.picFive.Location = New System.Drawing.Point(691, 81)
        Me.picFive.Name = "picFive"
        Me.picFive.Size = New System.Drawing.Size(82, 147)
        Me.picFive.TabIndex = 4
        Me.picFive.TabStop = False
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(365, 335)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(49, 13)
        Me.lblNumber.TabIndex = 5
        Me.lblNumber.Text = "Numbers"
        '
        'ClickableNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(910, 509)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.picFive)
        Me.Controls.Add(Me.picThree)
        Me.Controls.Add(Me.picTwo)
        Me.Controls.Add(Me.picFour)
        Me.Controls.Add(Me.picOne)
        Me.Name = "ClickableNumbers"
        Me.Text = "Clickable Numbers"
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picOne As PictureBox
    Friend WithEvents picFour As PictureBox
    Friend WithEvents picTwo As PictureBox
    Friend WithEvents picThree As PictureBox
    Friend WithEvents picFive As PictureBox
    Friend WithEvents lblNumber As Label
End Class
