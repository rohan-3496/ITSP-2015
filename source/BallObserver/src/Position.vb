'Position: This is a data structure to hold the position of the ball


Public Class Position

    Public X As Integer
    Public Y As Integer
    Public Z As Integer

    Public Sub New(Optional ByVal x As Integer = 0, _
                   Optional ByVal y As Integer = 0, _
                   Optional ByVal z As Integer = 0)

        Me.X = x
        Me.Y = y
        Me.Z = Z
    End Sub

End Class ' END CLASS DEFINITION Position
