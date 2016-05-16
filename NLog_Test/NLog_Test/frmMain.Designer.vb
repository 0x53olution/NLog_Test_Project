<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.bntTrace = New System.Windows.Forms.Button()
        Me.bntWarn = New System.Windows.Forms.Button()
        Me.btnError = New System.Windows.Forms.Button()
        Me.btnFatal = New System.Windows.Forms.Button()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExeption = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDebug
        '
        Me.btnDebug.Location = New System.Drawing.Point(12, 141)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(75, 23)
        Me.btnDebug.TabIndex = 0
        Me.btnDebug.Text = "Debug"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'bntTrace
        '
        Me.bntTrace.Location = New System.Drawing.Point(12, 170)
        Me.bntTrace.Name = "bntTrace"
        Me.bntTrace.Size = New System.Drawing.Size(75, 23)
        Me.bntTrace.TabIndex = 1
        Me.bntTrace.Text = "Trace"
        Me.bntTrace.UseVisualStyleBackColor = True
        '
        'bntWarn
        '
        Me.bntWarn.Location = New System.Drawing.Point(12, 199)
        Me.bntWarn.Name = "bntWarn"
        Me.bntWarn.Size = New System.Drawing.Size(75, 23)
        Me.bntWarn.TabIndex = 2
        Me.bntWarn.Text = "Warn"
        Me.bntWarn.UseVisualStyleBackColor = True
        '
        'btnError
        '
        Me.btnError.Location = New System.Drawing.Point(12, 228)
        Me.btnError.Name = "btnError"
        Me.btnError.Size = New System.Drawing.Size(75, 23)
        Me.btnError.TabIndex = 3
        Me.btnError.Text = "Error"
        Me.btnError.UseVisualStyleBackColor = True
        '
        'btnFatal
        '
        Me.btnFatal.Location = New System.Drawing.Point(12, 257)
        Me.btnFatal.Name = "btnFatal"
        Me.btnFatal.Size = New System.Drawing.Size(75, 23)
        Me.btnFatal.TabIndex = 4
        Me.btnFatal.Text = "Fatal"
        Me.btnFatal.UseVisualStyleBackColor = True
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(12, 112)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(75, 23)
        Me.btnInfo.TabIndex = 5
        Me.btnInfo.Text = "Info"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(12, 9)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(641, 97)
        Me.txtResult.TabIndex = 6
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(578, 260)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExeption
        '
        Me.btnExeption.Location = New System.Drawing.Point(93, 228)
        Me.btnExeption.Name = "btnExeption"
        Me.btnExeption.Size = New System.Drawing.Size(75, 23)
        Me.btnExeption.TabIndex = 8
        Me.btnExeption.Text = "Exception"
        Me.btnExeption.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 296)
        Me.Controls.Add(Me.btnExeption)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.btnInfo)
        Me.Controls.Add(Me.btnFatal)
        Me.Controls.Add(Me.btnError)
        Me.Controls.Add(Me.bntWarn)
        Me.Controls.Add(Me.bntTrace)
        Me.Controls.Add(Me.btnDebug)
        Me.Name = "frmMain"
        Me.Text = "Main-Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents bntTrace As System.Windows.Forms.Button
    Friend WithEvents bntWarn As System.Windows.Forms.Button
    Friend WithEvents btnError As System.Windows.Forms.Button
    Friend WithEvents btnFatal As System.Windows.Forms.Button
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExeption As System.Windows.Forms.Button

End Class
