Public Class Entero
    Private numero As Integer

    Public Sub New()
        numero = 0
    End Sub

    Public Sub New(_num As Integer)
        numero = _num
    End Sub

    Public Function obtenerNumero() As Integer
        Return numero
    End Function

    Public Sub ponerNumero(_num As Integer)
        numero = _num
    End Sub

    Public Function aCadena() As String
        Return numero.ToString()
    End Function

    Public Function esPrimo() As Boolean
        Dim cont = 0
        For i = 1 To numero
            If (numero Mod i = 0) Then
                cont = cont + 1
            End If

        Next
        Return cont = 2
    End Function

    Public Function esPrimoCon1ComoPrimo() As Boolean
        Dim cont = 0
        For i = 1 To numero
            If (numero Mod i = 0) Then
                cont = cont + 1
            End If

        Next
        Return cont = 2 Or numero = 1
    End Function

End Class
