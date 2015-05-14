'ConcreteDecorator: MidFielder class is a Concrete implementation
'of the  PlayerRole (Decorator) class

Public Class MidFielder
    Inherits PlayerRole

    'AddedBehavior: This is a responsibility exclusively for the Midfielder
    '(Don't ask me whether only mid filders can dribble the ball - atleast
    'it is so in our engine)

    Public Sub Dribble()
        System.Console.WriteLine("   Midfielder ({0}) -  dribbled the ball", _
            MyBase.player.Name)
    End Sub

End Class ' END CLASS DEFINITION Midfielder
