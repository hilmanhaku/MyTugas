<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Label1 = New Label()
        lblUang = New Label()
        lblHari = New Label()
        txtUang = New TextBox()
        txtHari = New TextBox()
        btnHitung = New Button()
        Label4 = New Label()
        Label5 = New Label()
        lblTotal = New Label()
        Button1 = New Button()
        Bu = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.Location = New Point(210, 41)
        Label1.Name = "Label1"
        Label1.Size = New Size(361, 25)
        Label1.TabIndex = 0
        Label1.Text = "KALKULATOR UANG SAKU MINGGUAN"
        ' 
        ' lblUang
        ' 
        lblUang.AutoSize = True
        lblUang.Location = New Point(65, 128)
        lblUang.Name = "lblUang"
        lblUang.Size = New Size(114, 15)
        lblUang.TabIndex = 1
        lblUang.Text = "Uang Saku per Hari ;"
        ' 
        ' lblHari
        ' 
        lblHari.AutoSize = True
        lblHari.Location = New Point(65, 177)
        lblHari.Name = "lblHari"
        lblHari.Size = New Size(120, 15)
        lblHari.TabIndex = 1
        lblHari.Text = "Jumlah Hari Sekolah ;"
        ' 
        ' txtUang
        ' 
        txtUang.Location = New Point(282, 123)
        txtUang.Name = "txtUang"
        txtUang.Size = New Size(188, 23)
        txtUang.TabIndex = 2
        ' 
        ' txtHari
        ' 
        txtHari.Location = New Point(282, 174)
        txtHari.Name = "txtHari"
        txtHari.Size = New Size(188, 23)
        txtHari.TabIndex = 2
        ' 
        ' btnHitung
        ' 
        btnHitung.Font = New Font("Segoe UI", 34F, FontStyle.Bold)
        btnHitung.Location = New Point(65, 226)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(405, 81)
        btnHitung.TabIndex = 3
        btnHitung.Text = "Hitung Total"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label4.Location = New Point(210, 331)
        Label4.Name = "Label4"
        Label4.Size = New Size(155, 15)
        Label4.TabIndex = 1
        Label4.Text = "Total Uang Saku Seminggu"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 29F, FontStyle.Bold)
        Label5.Location = New Point(210, 364)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 52)
        Label5.TabIndex = 1
        Label5.Text = "Rp"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 29F, FontStyle.Bold)
        lblTotal.Location = New Point(275, 367)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(44, 52)
        lblTotal.TabIndex = 1
        lblTotal.Text = "0"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(186, 431)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "reset"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Bu
        ' 
        Bu.Location = New Point(282, 431)
        Bu.Name = "Bu"
        Bu.Size = New Size(75, 23)
        Bu.TabIndex = 5
        Bu.Text = "Exit"
        Bu.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 476)
        Controls.Add(Bu)
        Controls.Add(Button1)
        Controls.Add(btnHitung)
        Controls.Add(txtHari)
        Controls.Add(txtUang)
        Controls.Add(lblTotal)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(lblHari)
        Controls.Add(lblUang)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblUang As Label
    Friend WithEvents lblHari As Label
    Friend WithEvents txtUang As TextBox
    Friend WithEvents txtHari As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Bu As Button

End Class
