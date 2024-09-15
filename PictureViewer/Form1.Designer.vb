<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        TableLayoutPanel1 = New TableLayoutPanel()
        PictureBox1 = New PictureBox()
        CheckBox1 = New CheckBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        showBtn = New Button()
        clearBtn = New Button()
        bgBtn = New Button()
        closeBtn = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        ColorDialog1 = New ColorDialog()
        TableLayoutPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FlowLayoutPanel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanel1
        ' 
        TableLayoutPanel1.ColumnCount = 2
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 15F))
        TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 85F))
        TableLayoutPanel1.Controls.Add(PictureBox1, 0, 0)
        TableLayoutPanel1.Controls.Add(CheckBox1, 0, 1)
        TableLayoutPanel1.Controls.Add(FlowLayoutPanel1, 1, 1)
        TableLayoutPanel1.Dock = DockStyle.Fill
        TableLayoutPanel1.Location = New Point(0, 0)
        TableLayoutPanel1.Name = "TableLayoutPanel1"
        TableLayoutPanel1.RowCount = 2
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 90F))
        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 10F))
        TableLayoutPanel1.Size = New Size(1027, 531)
        TableLayoutPanel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.Fixed3D
        TableLayoutPanel1.SetColumnSpan(PictureBox1, 2)
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1021, 471)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Dock = DockStyle.Fill
        CheckBox1.Location = New Point(3, 480)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(148, 48)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "Stretch"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Controls.Add(showBtn)
        FlowLayoutPanel1.Controls.Add(clearBtn)
        FlowLayoutPanel1.Controls.Add(bgBtn)
        FlowLayoutPanel1.Controls.Add(closeBtn)
        FlowLayoutPanel1.Dock = DockStyle.Fill
        FlowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft
        FlowLayoutPanel1.Location = New Point(157, 480)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(867, 48)
        FlowLayoutPanel1.TabIndex = 2
        ' 
        ' showBtn
        ' 
        showBtn.AllowDrop = True
        showBtn.Location = New Point(726, 3)
        showBtn.Name = "showBtn"
        showBtn.Size = New Size(138, 29)
        showBtn.TabIndex = 0
        showBtn.Text = "Show a Picture"
        showBtn.UseVisualStyleBackColor = True
        ' 
        ' clearBtn
        ' 
        clearBtn.AllowDrop = True
        clearBtn.Location = New Point(571, 3)
        clearBtn.Name = "clearBtn"
        clearBtn.Size = New Size(149, 29)
        clearBtn.TabIndex = 1
        clearBtn.Text = "Clear the Picture"
        clearBtn.UseVisualStyleBackColor = True
        ' 
        ' bgBtn
        ' 
        bgBtn.AllowDrop = True
        bgBtn.Location = New Point(358, 3)
        bgBtn.Name = "bgBtn"
        bgBtn.Size = New Size(207, 29)
        bgBtn.TabIndex = 2
        bgBtn.Text = "Set the Background Color"
        bgBtn.UseVisualStyleBackColor = True
        ' 
        ' closeBtn
        ' 
        closeBtn.AllowDrop = True
        closeBtn.Location = New Point(258, 3)
        closeBtn.Name = "closeBtn"
        closeBtn.Size = New Size(94, 29)
        closeBtn.TabIndex = 3
        closeBtn.Text = "Close"
        closeBtn.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        OpenFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All files (*.*)|*.*"
        OpenFileDialog1.Title = "Select a picture file"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1027, 531)
        Controls.Add(TableLayoutPanel1)
        Name = "Form1"
        Text = "Picture Viewer"
        TableLayoutPanel1.ResumeLayout(False)
        TableLayoutPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FlowLayoutPanel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents showBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents bgBtn As Button
    Friend WithEvents closeBtn As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog

End Class
