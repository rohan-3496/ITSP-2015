'ConcreteDecorator: Forward class is a Concrete implementation
'of the  PlayerRole (Decorator) class

Public Class Forward
    Inherits PlayerRole

    'Added Behavior: This is a responsibility exclusively for the Forward
    Public Sub ShootGoal()
        System.Console.WriteLine("   Forward ({0}) -  shooted the ball to goalpost", MyBase.player.Name)

    End Sub

End Class ' END CLASS DEFINITION Forward
