Public Class Vector
    Private v(100) As Integer
    Private n As Integer

    Public Sub New()
        n = 0
    End Sub

    Public Sub New(_n As Integer)
        n = _n
    End Sub

    Public Sub New(_n As Integer, data As DataGridView)
        n = _n
        data.ColumnCount = _n
    End Sub

    Public Function obtenerItem(i As Integer)
        If ((i > n) Or (i <= 0)) Then
            Throw New System.Exception("El item a obtener esta fuera del rango del vector")
        Else
            Return v(i)
        End If
    End Function

    Public Sub ponerItem(valor As Integer)
        If (n >= 99) Then
            Throw New System.Exception("El vector esta lleno")
        Else
            n = n + 1
            v(n) = valor
        End If
    End Sub

    Public Function Dimension()
        Return n
    End Function

    Public Sub ponerItem(i As Integer, valor As Integer)
        If ((i > n) Or (i <= 0)) Then
            Throw New System.Exception("El item a poner esta fuera del rango del vector")
        Else
            v(i) = valor
        End If
    End Sub

    Public Sub redimensionar(_n As Integer, data As DataGridView)
        n = _n
        data.ColumnCount = _n
    End Sub

    Public Sub cargar(data As DataGridView)
        For i = 0 To data.ColumnCount - 1
            v(i + 1) = data.Item(i, 0).Value
        Next
        n = data.ColumnCount
    End Sub

    Public Sub descargar(data As DataGridView)
        For i = 0 To data.ColumnCount - 1
            data.Item(i, 0).Value = v(i + 1)
        Next
    End Sub

    Public Function descargar() As String
        Dim respuesta As String
        respuesta = "["
        For i = 0 To n - 1
            respuesta = respuesta + v(i + 1).ToString + " , "
        Next
        respuesta = respuesta + "]"

        Return respuesta
    End Function


    Public Sub eliminar(pos As Integer)
        n = n - 1
        For i = pos To n
            v(i) = v(i + 1)
        Next
    End Sub

    Public Function existe(elem As Integer) As Boolean
        Dim res = False

        For i = 1 To Dimension()

            If (elem = obtenerItem(i)) Then
                res = True
            End If
        Next

        Return res
    End Function

    Public Function diferencia(v2 As Vector) As Vector
        Dim vr = New Vector()

        For i = 1 To Dimension()
            Dim elem = obtenerItem(i)
            If (Not v2.existe(elem)) Then
                vr.ponerItem(elem)
            End If
        Next

        Return vr
    End Function

    Public Function acumularPorMultiplo(multiplo As Integer) As Integer
        Dim res = 0

        For i = 1 To Dimension()
            If (i Mod multiplo = 0) Then
                res = res + obtenerItem(i)
            End If
        Next

        Return res
    End Function

    Public Function mayorPorMultiplo(multiplo As Integer) As Integer
        Dim mayor = Integer.MinValue

        For i = 1 To Dimension()
            If (i Mod multiplo = 0) Then
                If (mayor < obtenerItem(i)) Then
                    mayor = obtenerItem(i)
                End If
            End If
        Next

        Return mayor
    End Function

    Public Function existeElementoRepetidoRango(elem As Integer, a As Integer, b As Integer) As Boolean
        Dim contador = 0

        For i = a To b
            If (v(i) = elem) Then
                contador = contador + 1
            End If
        Next

        Return contador > 1
    End Function

    Public Sub eliminarRepetidosRango(a As Integer, b As Integer)

        Dim sum = 0
        For i = a To b
            Dim actual = v(i - sum)
            If (existeElementoRepetidoRango(actual, a, b - sum)) Then
                eliminar(i - sum)
                sum = sum + 1
            End If
        Next
    End Sub

    Private Function frecuenciaRango(elem As Integer, a As Integer, b As Integer)
        Dim frec = 0
        For i = a To b
            If (v(i) = elem) Then
                frec = frec + 1
            End If
        Next
        Return frec
    End Function

    Public Sub menorMayorFrecuenciaRango(a As Integer, b As Integer, ByRef v1 As Vector, ByRef v2 As Vector)
        v1 = New Vector(2) 'Numeros
        v2 = New Vector(2) 'Frecuencias
        v2.ponerItem(1, 9999)

        For i = a To b
            Dim menor = v2.obtenerItem(1)
            Dim mayor = v2.obtenerItem(2)
            Dim frecuenciaActual = frecuenciaRango(v(i), a, b)

            If (frecuenciaActual < menor) Then
                v2.ponerItem(1, frecuenciaActual)
                v1.ponerItem(1, v(i))
            End If

            If (frecuenciaActual > mayor) Then
                v2.ponerItem(2, frecuenciaActual)
                v1.ponerItem(2, v(i))
            End If

        Next
    End Sub


    Public Sub invertirVector()
        For i = 1 To n \ 2
            Dim aux = v(i)
            v(i) = v(n - i + 1)
            v(n - i + 1) = aux
        Next
    End Sub

    Public Function todosPrimos()
        Dim res = True
        For i = 1 To n
            Dim numero = New Entero(v(i))
            If (Not numero.esPrimo) Then
                res = False
            End If
        Next
        Return res
    End Function

    Public Sub ordenarMultiplosDeM(m As Integer)
        For i = 1 To n
            For j = i To n
                If (i Mod m = 0) And (j Mod m = 0) Then
                    If (v(i) > v(j)) Then
                        Dim aux = v(i)
                        v(i) = v(j)
                        v(j) = aux
                    End If
                End If
            Next
        Next
    End Sub

    Public Sub ordenarMenorAMayor()
        For i = 1 To n
            For j = i To n
                If (v(i) > v(j)) Then
                    Dim aux = v(i)
                    v(i) = v(j)
                    v(j) = aux
                End If
            Next
        Next
    End Sub

    Public Function esPrimo(numero As Integer) As Boolean
        Dim cont = 0
        For i = 1 To numero
            If (numero Mod i = 0) Then
                cont = cont + 1
            End If

        Next
        Return cont = 2
    End Function

    Public Sub intercalarPrimosNoPrimosRango(a As Integer, b As Integer)
        Dim vp As Vector
        Dim vnp As Vector
        vp = New Vector()
        vnp = New Vector()

        For i = a To b
            If (esPrimo(v(i))) Then
                vp.ponerItem(v(i))
            Else
                vnp.ponerItem(v(i))
            End If
        Next

        vp.ordenarMenorAMayor()
        vnp.ordenarMenorAMayor()

        Dim k = 1
        Dim primo = True
        For i = a To b
            If (primo And k <= vp.Dimension()) Then
                v(i) = vp.obtenerItem(k)
            End If

            If (Not primo And k <= vnp.Dimension()) Then
                v(i) = vnp.obtenerItem(k)
            End If

            If (Not primo) Then
                k = k + 1
            End If

            If (primo) Then
                If (k <= vnp.Dimension()) Then
                    primo = False
                Else
                    k = k + 1
                End If
            Else
                If (k <= vp.Dimension()) Then
                    primo = True
                End If
            End If

        Next

    End Sub

    'Numero de elementos diferentes primos de un vector que tiene elementos primos y no primos
    Public Function numeroElemDiferentesPrimos()
        Dim vp = New Vector()
        For i = 1 To n
            Dim ent = New Entero(v(i))
            If (ent.esPrimo() And Not vp.existe(ent.obtenerNumero())) Then
                vp.ponerItem(ent.obtenerNumero())
            End If
        Next
        Return vp.Dimension()
    End Function


    Public Function esFibbo(k As Integer)
        Dim a = -1
        Dim res = False
        Dim b = 1
        Dim c = a + b
        While (c <= k)
            If c = k Then
                res = True
            End If
            a = b
            b = c
            c = a + b
        End While
        Return res
    End Function

    Public Sub eliminarFibboRango(a As Integer, b As Integer)
        Dim i = a
        While (i <= b)
            If (esFibbo(v(i))) Then
                eliminar(i)
            Else
                i = i + 1
            End If
        End While
    End Sub



    Public Sub examen1(V1 As Vector, V2 As Vector, ByRef VS1 As Vector, ByRef VS2 As Vector)
        VS1 = New Vector()
        VS2 = New Vector()

        Dim i = 1
        For i = 1 To V1.Dimension
            Dim j = i + 1
            While (j <= V1.Dimension)
                If (V1.obtenerItem(i) = V1.obtenerItem(j)) Then
                    Dim valor1 = V2.obtenerItem(i)
                    Dim valor2 = V2.obtenerItem(j)
                    V2.ponerItem(i, valor1 + valor2)
                    V1.eliminar(j)
                    V2.eliminar(j)
                Else
                    j = j + 1
                End If
            End While
        Next

        For i = 1 To V1.Dimension
            For j = i + 1 To Dimension()
                If (V1.obtenerItem(i) > V1.obtenerItem(j)) Then
                    Dim aux1 = V1.obtenerItem(i)
                    Dim aux2 = V2.obtenerItem(i)

                    V1.ponerItem(i, V1.obtenerItem(j))
                    V2.ponerItem(i, V2.obtenerItem(j))

                    V1.ponerItem(j, aux1)
                    V2.ponerItem(j, aux2)
                End If
            Next
        Next

        VS1 = V1
        VS2 = V2
    End Sub

End Class
