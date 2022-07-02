Public Class ArchivosForm

    Dim arc As Archivo

    Dim projNEArch As ProyectoEnterosArchivo

    Private Sub LeerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeerToolStripMenuItem.Click
        TextBox1.Text = arc.leer()
    End Sub

    Private Sub ConstruirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstruirToolStripMenuItem.Click
        arc = New Archivo()
    End Sub

    Private Sub EscribirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EscribirToolStripMenuItem.Click
        arc.escribir(TextBox1.Text)
    End Sub

    Private Sub LeerLineaPorLineaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeerLineaPorLineaToolStripMenuItem.Click
        TextBox1.Text = arc.leerLineaPorLinea()
    End Sub

    Private Sub ConstruirConPathToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstruirConPathToolStripMenuItem.Click
        arc = New Archivo(TextBox1.Text)
    End Sub

    Private Sub CantidadDeLineasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CantidadDeLineasToolStripMenuItem.Click
        TextBox1.Text = arc.cantidadDeLineas()
    End Sub

    Private Sub SumarNumerosArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SumarNumerosArchivoToolStripMenuItem.Click
        TextBox1.Text = projNEArch.sumar()
    End Sub

    Private Sub ConstruirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConstruirToolStripMenuItem1.Click
        projNEArch = New ProyectoEnterosArchivo()
    End Sub

    Private Sub EscribirAgregandoAlFinalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EscribirAgregandoAlFinalToolStripMenuItem.Click
        arc.escribirAgregandoTexto(TextBox1.Text)
    End Sub
End Class