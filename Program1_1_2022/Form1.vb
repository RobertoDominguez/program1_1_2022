Public Class Form1

    Dim v1, v2 As Vector
    Dim cad1 As Cadena
    Dim m1, m2 As Matriz
    Private Sub ConstruirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstruirToolStripMenuItem.Click
        v1 = New Vector()
        v2 = New Vector()
    End Sub

    Private Sub ConstruirConDimensionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstruirConDimensionToolStripMenuItem.Click
        v1 = New Vector(TextBox1.Text, DataGridView1)
    End Sub

    Private Sub RedimensionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedimensionarToolStripMenuItem.Click
        v1.redimensionar(TextBox1.Text, DataGridView1)
    End Sub

    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        v1.cargar(DataGridView1)
    End Sub

    Private Sub DescargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarToolStripMenuItem.Click
        v1.descargar(DataGridView1)
    End Sub

    Private Sub CargarTextBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarTextBoxToolStripMenuItem.Click
        v1.ponerItem(TextBox5.Text)
    End Sub

    Private Sub DescargarTextBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarTextBoxToolStripMenuItem.Click
        TextBox1.Text = v1.descargar()
    End Sub

    Private Sub CargarV2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarV2ToolStripMenuItem.Click
        v2.cargar(DataGridView2)
    End Sub

    Private Sub RedimensionarV2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedimensionarV2ToolStripMenuItem.Click
        v2.redimensionar(TextBox1.Text, DataGridView2)
    End Sub

    Private Sub DescargarV2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarV2ToolStripMenuItem.Click
        v2.descargar(DataGridView2)
    End Sub

    Private Sub ConstruirConDimensionV2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConstruirConDimensionV2ToolStripMenuItem.Click
        v2 = New Vector(TextBox2.Text, DataGridView2)
    End Sub

    Private Sub Practico1Ej9ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Practico1Ej9ToolStripMenuItem.Click
        Dim vr = v1.diferencia(v2)

        TextBox1.Text = vr.descargar()

    End Sub

    Private Sub EliminarRepetidoRangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarRepetidoRangoToolStripMenuItem.Click
        Dim a = CInt(TextBox3.Text)
        Dim b = CInt(TextBox4.Text)
        v1.eliminarRepetidosRango(a, b)
    End Sub

    Private Sub MenorMayorFrecRangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenorMayorFrecRangoToolStripMenuItem.Click
        Dim v1e, v2e As Vector
        v1e = New Vector
        v2e = New Vector
        Dim a = CInt(TextBox3.Text)
        Dim b = CInt(TextBox4.Text)
        v1.menorMayorFrecuenciaRango(a, b, v1e, v2e)
        TextBox1.Text = "Numeros: " + v1e.descargar + "Frecuencias:" + v2e.descargar
    End Sub

    Private Sub InvertirVectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvertirVectorToolStripMenuItem.Click
        v1.invertirVector()
    End Sub

    Private Sub OrdenarMultiplosMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarMultiplosMToolStripMenuItem.Click
        v1.ordenarMultiplosDeM(TextBox1.Text)
    End Sub

    Private Sub OrdenarMenorAMayorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarMenorAMayorToolStripMenuItem.Click
        v1.ordenarMenorAMayor()
    End Sub

    Private Sub IntercalarPrimosNoPrimosRangoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntercalarPrimosNoPrimosRangoToolStripMenuItem.Click
        v1.intercalarPrimosNoPrimosRango(TextBox3.Text, TextBox4.Text)
    End Sub

    Private Sub ConstruirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConstruirToolStripMenuItem1.Click
        cad1 = New Cadena()
    End Sub

    Private Sub PonerCaracterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PonerCaracterToolStripMenuItem.Click
        Dim caracter As Char
        caracter = TextBox1.Text
        cad1.ponerCaracter(caracter)
    End Sub

    Private Sub PonerCaracterASCIIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PonerCaracterASCIIToolStripMenuItem.Click
        Dim caracter As Integer
        caracter = CInt(TextBox1.Text)
        cad1.ponerCaracter(caracter)
    End Sub

    Private Sub ObtenerCadenaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ObtenerCadenaToolStripMenuItem.Click
        TextBox1.Text = cad1.obtenerCadena()
    End Sub



    Private Sub Examen1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Examen1ToolStripMenuItem.Click
        Dim vs1 As Vector
        Dim vs2 As Vector

        v1.examen1(v1, v2, vs1, vs2)

        TextBox1.Text = vs1.descargar()
        TextBox2.Text = vs2.descargar()

    End Sub

    Private Sub ConstruirConDimensionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ConstruirConDimensionToolStripMenuItem1.Click
        Dim cantidadFilas = TextBox3.Text
        Dim cantidadColumnas = TextBox4.Text
        m1 = New Matriz(cantidadFilas, cantidadColumnas, DataGridView1)
    End Sub

    Private Sub DescargarStringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DescargarStringToolStripMenuItem.Click
        TextBox1.Text = m1.comoString()
    End Sub

    Private Sub CargarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem1.Click
        m1.cargar(DataGridView1)
    End Sub

    Private Sub DescargarStringGridToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DescargarStringGridToolStripMenuItem1.Click
        m1.descargar(DataGridView1)
    End Sub

    Private Sub CargarTextBoxToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CargarTextBoxToolStripMenuItem1.Click
        m1.cargar(TextBox3.Text, TextBox4.Text, TextBox5.Text)
    End Sub

    Private Sub OrdenarAscAbajoHaciaArribaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarAscAbajoHaciaArribaToolStripMenuItem.Click
        m1.ordenarDeAbajoHaciaArribaAsc()
    End Sub

    Private Sub IntroducirElemenMayFrecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IntroducirElemenMayFrecToolStripMenuItem.Click
        m1.ordenarColumnaFinalFrecuencia()
    End Sub

    Private Sub AcumularElemPrimosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcumularElemPrimosToolStripMenuItem.Click
        TextBox1.Text = m1.acumularPorElementosPrimos().ToString
    End Sub

    Private Sub OrdenarDiagonalSecundariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarDiagonalSecundariaToolStripMenuItem.Click
        m1.ordenarDiagonalSecundariaMayorAMenor()
    End Sub

    Private Sub ElementoMayorTriangularSecToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElementoMayorTriangularSecToolStripMenuItem.Click
        m1.ordenarElementoMayorTriangularSecundaria()
    End Sub

    Private Sub ElementosDiferentesColumnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElementosDiferentesColumnaToolStripMenuItem.Click
        m1.elementosDiferentesColumna()
    End Sub

    Private Sub SegmentarEnParesDiagonalSecundariaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SegmentarEnParesDiagonalSecundariaToolStripMenuItem.Click

    End Sub

    Private Sub SegmentarEnParesDiagonalSecundariaToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SegmentarEnParesTriangularSecundariaToolStripMenuItem1.Click
        m1.segmentarEnParesEImparesTriangularSecundaria()
    End Sub

    Private Sub OrdenarTriangularIzqDiagPrincToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenarTriangularIzqDiagPrincToolStripMenuItem.Click
        m1.ordenarTriangularIzquierdaDiagPrincipal()
    End Sub

    Private Sub MostrarElemParesPorColumnaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarElemParesPorColumnaToolStripMenuItem.Click
        m1.mostrarElementosParesPorColumna()
    End Sub

    Private Sub ArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoToolStripMenuItem.Click
        Dim f2 As New ArchivosForm
        f2.Show()
        'Me.Hide()
    End Sub

    Private Sub ConstruirToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ConstruirToolStripMenuItem2.Click
        m1 = New Matriz()
        m2 = New Matriz()
    End Sub

    Private Sub CargarPosTextBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarPosTextBoxToolStripMenuItem.Click
        v1.ponerItem(TextBox4.Text, TextBox5.Text)
    End Sub
End Class
