Public Class Cadena

    Private caracteres(100) As Char
    Private n As Integer

    Public Sub New()
        n = 0
    End Sub

    Public Sub New(value() As Char)
        caracteres = value
        n = value.Count
    End Sub

    Public Function obtenerCadena() As String
        Dim resultado = ""
        For i = 1 To n
            resultado = resultado + caracteres(i)
        Next
        Return resultado
    End Function

    Public Function obtenerCaracter(i As Integer)
        Return caracteres(i)
    End Function

    Public Sub ponerCaracter(i As Integer, caracter As Char)
        caracteres(i) = caracter
    End Sub

    Public Function Dimension() As Integer
        Return n
    End Function

    Public Sub ponerCaracter(caracter As Char)
        n = n + 1
        caracteres(n) = caracter
    End Sub

    Public Sub ponerCaracter(caracter As Integer)
        n = n + 1
        caracteres(n) = ChrW(caracter)
    End Sub

    Public Function concatenar(cad As Cadena) 
        For i = 1 To cad.Dimension
            ponerCaracter(cad.obtenerCaracter(i))
        Next
        Return caracteres
    End Function


End Class
