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
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.btnTekstvak = New System.Windows.Forms.Button()
        Me.btnNegatief = New System.Windows.Forms.Button()
        Me.btnLussen = New System.Windows.Forms.Button()
        Me.btnOneindige = New System.Windows.Forms.Button()
        Me.btnSluiten = New System.Windows.Forms.Button()
        Me.txtTekst = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnDebug
        '
        Me.btnDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebug.Location = New System.Drawing.Point(32, 12)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(376, 121)
        Me.btnDebug.TabIndex = 0
        Me.btnDebug.Text = "Uitvoer in immediate venster"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'btnTekstvak
        '
        Me.btnTekstvak.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTekstvak.Location = New System.Drawing.Point(32, 139)
        Me.btnTekstvak.Name = "btnTekstvak"
        Me.btnTekstvak.Size = New System.Drawing.Size(376, 121)
        Me.btnTekstvak.TabIndex = 1
        Me.btnTekstvak.Text = "Uitvoer in tekstvak"
        Me.btnTekstvak.UseVisualStyleBackColor = True
        '
        'btnNegatief
        '
        Me.btnNegatief.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNegatief.Location = New System.Drawing.Point(32, 265)
        Me.btnNegatief.Name = "btnNegatief"
        Me.btnNegatief.Size = New System.Drawing.Size(376, 121)
        Me.btnNegatief.TabIndex = 2
        Me.btnNegatief.Text = "Negatieve stapgrootte"
        Me.btnNegatief.UseVisualStyleBackColor = True
        '
        'btnLussen
        '
        Me.btnLussen.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLussen.Location = New System.Drawing.Point(32, 383)
        Me.btnLussen.Name = "btnLussen"
        Me.btnLussen.Size = New System.Drawing.Size(376, 121)
        Me.btnLussen.TabIndex = 3
        Me.btnLussen.Text = "Geneste lussen"
        Me.btnLussen.UseVisualStyleBackColor = True
        '
        'btnOneindige
        '
        Me.btnOneindige.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOneindige.Location = New System.Drawing.Point(32, 499)
        Me.btnOneindige.Name = "btnOneindige"
        Me.btnOneindige.Size = New System.Drawing.Size(376, 121)
        Me.btnOneindige.TabIndex = 4
        Me.btnOneindige.Text = "Oneindige lus"
        Me.btnOneindige.UseVisualStyleBackColor = True
        '
        'btnSluiten
        '
        Me.btnSluiten.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSluiten.Location = New System.Drawing.Point(32, 617)
        Me.btnSluiten.Name = "btnSluiten"
        Me.btnSluiten.Size = New System.Drawing.Size(376, 121)
        Me.btnSluiten.TabIndex = 5
        Me.btnSluiten.Text = "Sluiten"
        Me.btnSluiten.UseVisualStyleBackColor = True
        '
        'txtTekst
        '
        Me.txtTekst.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTekst.Location = New System.Drawing.Point(436, 24)
        Me.txtTekst.Multiline = True
        Me.txtTekst.Name = "txtTekst"
        Me.txtTekst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTekst.Size = New System.Drawing.Size(575, 684)
        Me.txtTekst.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1085, 740)
        Me.Controls.Add(Me.txtTekst)
        Me.Controls.Add(Me.btnSluiten)
        Me.Controls.Add(Me.btnOneindige)
        Me.Controls.Add(Me.btnLussen)
        Me.Controls.Add(Me.btnNegatief)
        Me.Controls.Add(Me.btnTekstvak)
        Me.Controls.Add(Me.btnDebug)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDebug As Button
    Friend WithEvents btnTekstvak As Button
    Friend WithEvents btnNegatief As Button
    Friend WithEvents btnLussen As Button
    Friend WithEvents btnOneindige As Button
    Friend WithEvents btnSluiten As Button
    Friend WithEvents txtTekst As TextBox
End Class
