' ConcreteObserver: The Player Class

'Player inherits from IObserver, and overrides Update method
Public Class Player
    Inherits IObserver

    'This variable holds the current state(position) of the ball
    Private ballPosition As Position

    'A variable to store the name of the player
    Private myName As String

    'This is a pointer to the ball in the system
	Private ball As FootBall

    'Update() is called from Notify function, in Ball class
	Public Overrides Sub Update ()
        ballPosition = ball.GetBallPosition()
        System.Console.WriteLine("   Player {0} say that the ball is at {1},{2},{3} ", myName, ballPosition.X, ballPosition.Y, ballPosition.Z)
    End Sub


    'A constructor which allows creating a reference to a ball
    Public Sub New(ByRef b As FootBall, ByVal playerName As String)
        ball = b
        myName = playerName
    End Sub

End Class ' END CLASS DEFINITION Player
