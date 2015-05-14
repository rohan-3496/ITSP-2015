' ConcreteComponent : GaolKeeper class

'This is a concrete component. Later, we can add additional responsibilities
'to this class if required.


Public Class GoalKeeper
    Inherits Player

    'Operation: Overriding the base class operation
	Public Overrides Sub PassBall ()
        System.Console.WriteLine("   GoalKeeper ({0}) -  passed the ball", MyBase.Name)
	End Sub

    'A constructor to accept the name of the player
    Public Sub New(ByVal playerName As String)
        MyBase.Name = playerName
    End Sub

End Class ' END CLASS DEFINITION GoalKeeper
