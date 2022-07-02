<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArchivosForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConstruirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConstruirConPathToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscribirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeerLineaPorLineaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CantidadDeLineasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProyectoEnterosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConstruirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SumarNumerosArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.EscribirAgregandoAlFinalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ProyectoEnterosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1226, 29)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConstruirToolStripMenuItem, Me.ConstruirConPathToolStripMenuItem, Me.LeerToolStripMenuItem, Me.EscribirToolStripMenuItem, Me.LeerLineaPorLineaToolStripMenuItem, Me.CantidadDeLineasToolStripMenuItem, Me.EscribirAgregandoAlFinalToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(75, 25)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ConstruirToolStripMenuItem
        '
        Me.ConstruirToolStripMenuItem.Name = "ConstruirToolStripMenuItem"
        Me.ConstruirToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.ConstruirToolStripMenuItem.Text = "Construir"
        '
        'ConstruirConPathToolStripMenuItem
        '
        Me.ConstruirConPathToolStripMenuItem.Name = "ConstruirConPathToolStripMenuItem"
        Me.ConstruirConPathToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.ConstruirConPathToolStripMenuItem.Text = "ConstruirConPath"
        '
        'LeerToolStripMenuItem
        '
        Me.LeerToolStripMenuItem.Name = "LeerToolStripMenuItem"
        Me.LeerToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.LeerToolStripMenuItem.Text = "Leer"
        '
        'EscribirToolStripMenuItem
        '
        Me.EscribirToolStripMenuItem.Name = "EscribirToolStripMenuItem"
        Me.EscribirToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.EscribirToolStripMenuItem.Text = "Escribir"
        '
        'LeerLineaPorLineaToolStripMenuItem
        '
        Me.LeerLineaPorLineaToolStripMenuItem.Name = "LeerLineaPorLineaToolStripMenuItem"
        Me.LeerLineaPorLineaToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.LeerLineaPorLineaToolStripMenuItem.Text = "LeerLineaPorLinea"
        '
        'CantidadDeLineasToolStripMenuItem
        '
        Me.CantidadDeLineasToolStripMenuItem.Name = "CantidadDeLineasToolStripMenuItem"
        Me.CantidadDeLineasToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.CantidadDeLineasToolStripMenuItem.Text = "cantidadDeLineas"
        '
        'ProyectoEnterosToolStripMenuItem
        '
        Me.ProyectoEnterosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConstruirToolStripMenuItem1, Me.SumarNumerosArchivoToolStripMenuItem})
        Me.ProyectoEnterosToolStripMenuItem.Name = "ProyectoEnterosToolStripMenuItem"
        Me.ProyectoEnterosToolStripMenuItem.Size = New System.Drawing.Size(105, 25)
        Me.ProyectoEnterosToolStripMenuItem.Text = "ProyectoEnteros"
        '
        'ConstruirToolStripMenuItem1
        '
        Me.ConstruirToolStripMenuItem1.Name = "ConstruirToolStripMenuItem1"
        Me.ConstruirToolStripMenuItem1.Size = New System.Drawing.Size(198, 22)
        Me.ConstruirToolStripMenuItem1.Text = "construir"
        '
        'SumarNumerosArchivoToolStripMenuItem
        '
        Me.SumarNumerosArchivoToolStripMenuItem.Name = "SumarNumerosArchivoToolStripMenuItem"
        Me.SumarNumerosArchivoToolStripMenuItem.Size = New System.Drawing.Size(198, 22)
        Me.SumarNumerosArchivoToolStripMenuItem.Text = "SumarNumerosArchivo"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(110, 57)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(964, 417)
        Me.TextBox1.TabIndex = 1
        '
        'EscribirAgregandoAlFinalToolStripMenuItem
        '
        Me.EscribirAgregandoAlFinalToolStripMenuItem.Name = "EscribirAgregandoAlFinalToolStripMenuItem"
        Me.EscribirAgregandoAlFinalToolStripMenuItem.Size = New System.Drawing.Size(255, 26)
        Me.EscribirAgregandoAlFinalToolStripMenuItem.Text = "EscribirAgregandoAlFinal"
        '
        'ArchivosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 534)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ArchivosForm"
        Me.Text = "ArchivosForm"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ConstruirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EscribirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LeerLineaPorLineaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConstruirConPathToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CantidadDeLineasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProyectoEnterosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SumarNumerosArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConstruirToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EscribirAgregandoAlFinalToolStripMenuItem As ToolStripMenuItem
End Class
