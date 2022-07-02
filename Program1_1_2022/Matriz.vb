Public Class Matriz

    Private m(100, 100) As Integer
    Private rowCount As Integer 'Cantidad de Filas
    Private colCount As Integer 'Cantidad de columnas


    Public Property cF As Integer
        Get
            Return rowCount
        End Get
        Set(value As Integer)
            rowCount = value
        End Set
    End Property

    Public Property cC As Integer
        Get
            Return colCount
        End Get
        Set(value As Integer)
            colCount = value
        End Set
    End Property

    Public Sub New()
        rowCount = 0
        colCount = 0
    End Sub

    Public Sub New(_rowCount As Integer, _colCount As Integer)
        rowCount = _rowCount
        colCount = _colCount
    End Sub

    Public Sub New(_rowCount As Integer, _colCount As Integer, data As DataGridView)
        rowCount = _rowCount
        colCount = _colCount
        data.RowCount = rowCount
        data.ColumnCount = colCount
    End Sub

    Public Function comoString() As String
        Dim res = ""

        For i = 1 To cF
            For j = 1 To cC
                res = res + m(i, j).ToString() + " "
            Next
            res=res+"/n"
        Next

        Return res
    End Function


    Public Sub cargar(i As Integer, j As Integer, valor As Integer)
        m(i, j) = valor
    End Sub

    Public Sub cargar(data As DataGridView)
        For i = 1 To cF
            For j = 1 To cC
                m(i, j) = data.Item(j - 1, i - 1).Value
            Next
        Next
    End Sub

    Public Sub descargar(data As DataGridView)
        data.RowCount = cF
        data.ColumnCount = cC
        For i = 1 To cF
            For j = 1 To cC
                data.Item(j - 1, i - 1).Value = m(i, j)
            Next
        Next
    End Sub


    Public Sub ordenarDeAbajoHaciaArribaAsc()
        For j = cC To 1 Step -1
            For i = cF To 1 Step -1

                'ORDENAMIENTO 
                For j2 = cC To 1 Step -1
                    For i2 = cF To 1 Step -1
                        Dim elem1 = m(i, j)
                        Dim elem2 = m(i2, j2)
                        If (elem1 < elem2) Then
                            m(i, j) = elem2
                            m(i2, j2) = elem1
                        End If
                    Next
                Next

            Next
        Next

    End Sub


    Private Function frecuenciaElemFila(i As Integer, elem As Integer)
        Dim frec = 0
        For j = 1 To cC
            If (elem = m(i, j)) Then
                frec = frec + 1
            End If
        Next
        Return frec
    End Function

    Private Function elementoMayFrecFila(i As Integer)
        Dim frecuencia = 0
        Dim elem = 0
        For j = 1 To cC
            Dim frecuenciaActual = frecuenciaElemFila(i, m(i, j))
            If (frecuenciaActual > frecuencia) Then
                frecuencia = frecuenciaActual
                elem = m(i, j)
            End If
        Next
        Return elem
    End Function

    Public Sub ordenarColumnaFinalFrecuencia()
        cC = cC + 1

        For i = 1 To cF
            m(i, cC) = elementoMayFrecFila(i)
        Next

    End Sub

    '-raiz(elemPrimo)+raiz(elemPrimo)....
    Public Function acumularPorElementosPrimos() As Double
        Dim res = 0.0
        Dim estaRestando = True
        For i = cF To 1 Step -1
            For j = cC To 1 Step -1
                Dim elem = New Entero(m(i, j))
                If (elem.esPrimoCon1ComoPrimo()) Then
                    If (estaRestando) Then
                        res = res - Math.Sqrt(elem.obtenerNumero)
                    Else
                        res = res + Math.Sqrt(elem.obtenerNumero)
                    End If
                    estaRestando = Not estaRestando
                End If
            Next
        Next

        Return res
    End Function

    Public Sub ordenarDiagonalSecundariaMayorAMenor()
        For i = 1 To cF
            Dim c = i
            Dim f = cF - i + 1

            For j = 1 To cF
                Dim c2 = j
                Dim f2 = cF - j + 1

                Dim elem1 = m(f, c)
                Dim elem2 = m(f2, c2)
                If (elem1 > elem2) Then
                    m(f, c) = elem2
                    m(f2, c2) = elem1
                End If
            Next
        Next
    End Sub


    Private Function elementoMayorFilaTriangularSecundaria(i As Integer)
        Dim mayor = 0
        For j = 1 To cC
            Dim f = cF - i + 1
            If (j >= f) Then
                If (m(i, j) > mayor) Then
                    mayor = m(i, j)
                End If
            End If
        Next
        Return mayor
    End Function

    Public Sub ordenarElementoMayorTriangularSecundaria()
        cC = cC + 1

        For i = 1 To cF
            m(i, cC) = elementoMayorFilaTriangularSecundaria(i)
        Next
    End Sub



    Private Function existeElementoEnColumnaDesdePosicionI(iInicial As Integer, j As Integer, elem As Integer)
        Dim respuesta = False
        For i = iInicial + 1 To cF
            If (m(i, j) = elem) Then
                respuesta = True
            End If
        Next
        Return respuesta
    End Function

    Private Function cantidadElementosDiferentesColumna(j As Integer)
        Dim c = 0
        For i = 1 To cF
            If (Not existeElementoEnColumnaDesdePosicionI(i, j, m(i, j))) Then
                c = c + 1
            End If
        Next
        Return c
    End Function

    Public Sub elementosDiferentesColumna()
        For j = 1 To cC
            m(cF + 1, j) = cantidadElementosDiferentesColumna(j)
        Next
        'Aumento una fila mas para agregar la cantidad de elementos diferentes
        cF = cF + 1
    End Sub



    Public Sub segmentarEnParesEImparesTriangularSecundaria()
        Dim pares(100) As Integer
        Dim cantidadPares = 0

        Dim impares(100) As Integer
        Dim cantidadImpares = 0

        For j = 1 To cC
            For i = 1 To cF
                Dim jTSec = cF - i + 1 'F(i)=constante-i+1
                If (j > jTSec) Then

                    If (m(i, j) Mod 2 = 0) Then 'Introduce los pares
                        pares(cantidadPares) = m(i, j)
                        cantidadPares = cantidadPares + 1
                    Else 'Introduce los impares
                        impares(cantidadImpares) = m(i, j)
                        cantidadImpares = cantidadImpares + 1
                    End If
                End If
            Next
        Next

        Dim paresIntroducidos = 0
        Dim imparesIntroducidos = 0
        For j = 1 To cC
            For i = 1 To cF
                Dim jTSec = cF - i + 1 'F(i)=constante-i+1
                If (j > jTSec) Then
                    If (paresIntroducidos < cantidadPares) Then 'Introduzco los pares a la matriz
                        m(i, j) = pares(paresIntroducidos)
                        paresIntroducidos = paresIntroducidos + 1
                    Else
                        m(i, j) = impares(imparesIntroducidos)
                        imparesIntroducidos = imparesIntroducidos + 1
                    End If
                End If
            Next
        Next
    End Sub

    Public Sub ordenarTriangularIzquierdaDiagPrincipal()
        For j = 1 To cC
            For i = 1 To cF

                If (j <= i) Then
                    For j2 = 1 To cC
                        For i2 = 1 To cF
                            If (m(i, j) < m(i2, j2) And (j2 <= i2)) Then
                                Dim aux = m(i, j)
                                m(i, j) = m(i2, j2)
                                m(i2, j2) = aux
                            End If
                        Next
                    Next
                End If

            Next
        Next

    End Sub


    Function cantidadParesColumna(j As Integer)
        Dim cantidad = 0
        For i = 1 To cF
            If (m(i, j) Mod 2 = 0) Then
                cantidad = cantidad + 1
            End If
        Next
        Return cantidad
    End Function

    Public Sub mostrarElementosParesPorColumna()
        For j = 1 To cC
            m(cF + 1, j) = cantidadParesColumna(j)
        Next
        cF = cF + 1
    End Sub

End Class
