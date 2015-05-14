' ConcreteComponent : Field Player class

'This is a concrete component. Later, we will add additional responsibilities
'like Forward, Defender etc to a field player.

Public Class FieldPlayer
    Inherits Player

    'Operation: Overrides PassBall operation
	Public Overrides Sub PassBall ()
        System.Console.WriteLine("   Fieldplayer ({0}) -  passed the ball", _
                            MyBase.Name)
    End Sub

    'A constructor to accept the name of the player
    Public Sub New(ByVal playerName As String)
        MyBase.Name = playerName
    End Sub

End Class ' END CLASS DEFINITION FieldPlayer
