'ConcreteDecorator: Defender class is a Concrete implementation
'of the  PlayerRole (Decorator) class

Public Class Defender
    Inherits PlayerRole

    'Added Behavior: This is a responsibility exclusively for the Defender
    Public Sub Defend()
        System.Console.WriteLine("   Defender ({0}) -  defended the ball", _
                                         MyBase.player.Name)
    End Sub

End Class ' END CLASS DEFINITION Defender
