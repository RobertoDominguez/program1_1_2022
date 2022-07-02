Public Class ProyectoEnterosArchivo

    Dim arc As Archivo

    Public Sub New()
        arc = New Archivo()
    End Sub

    Public Sub New(archivo As Archivo)
        arc = archivo
    End Sub

    Public Function sumar()
        arc.abrirReader()
        Dim reader = arc.obtenerReader()

        Dim suma = 0

        While (Not reader.EndOfStream)
            suma = suma + Integer.Parse(reader.ReadLine())
        End While

        arc.cerrarReader()

        Return suma
    End Function

End Class
