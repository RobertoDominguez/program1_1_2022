Public Class Archivo

    Dim path As String
    Dim reader As IO.StreamReader

    Public Sub New()
        'RUTA ABSOLUTA
        'path = "C:\Users\Roberto\Documents\Visual Studio 2022\Program1_1_2022\Program1_1_2022\bin\Debug\net6.0-windows\archivo.txt"

        'RUTA RELATIVA (directorio donde se esta ejecutando el proyecto)
        path = ".\archivo.algo"
    End Sub

    Public Sub New(_path As String)
        path = _path
    End Sub


    Public Function existeArchivo() As Boolean
        Return My.Computer.FileSystem.FileExists(path)
    End Function

    Public Function leer() As String
        If (Not existeArchivo()) Then
            escribir("")
        End If
        Dim str = My.Computer.FileSystem.ReadAllText(path)
        Return str
    End Function

    Public Function leerLineaPorLinea() As String
        Dim reader As IO.StreamReader
        reader = My.Computer.FileSystem.OpenTextFileReader(path)

        Dim str = ""

        While (Not reader.EndOfStream)
            str = str + reader.ReadLine() + Chr(13) + Chr(10)
        End While

        reader.Close()

        Return str
    End Function

    Public Function obtenerReader()
        Return reader
    End Function

    Public Sub abrirReader()
        reader = My.Computer.FileSystem.OpenTextFileReader(path)
    End Sub

    Public Sub cerrarReader()
        reader.Close()
    End Sub

    Public Function cantidadDeLineas()
        Dim reader As IO.StreamReader
        reader = My.Computer.FileSystem.OpenTextFileReader(path)

        Dim cantidad = 0

        While (Not reader.EndOfStream)
            reader.ReadLine()
            cantidad = cantidad + 1
        End While

        reader.Close()

        Return cantidad
    End Function

    Public Sub escribir(texto As String)
        My.Computer.FileSystem.WriteAllText(path, texto, False)
    End Sub

    Public Sub escribirAgregandoTexto(texto As String)
        My.Computer.FileSystem.WriteAllText(path, Chr(13) + Chr(10) + texto, True)
    End Sub

End Class
