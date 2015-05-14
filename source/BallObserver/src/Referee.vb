' ConcreteObserver :  The Referee Clas


Public Class Referee
	 Inherits IObserver

    'This variable holds the current state(position) of the ball
    Private ballPosition As Position

    'This is a pointer to the ball in the system
    Private ball As FootBall

    'A variable to store the name of the referee
    Private myName As String

    'Update() is called from Notify function in Ball class
    Public Overrides Sub Update()
        ballPosition = ball.GetBallPosition()
        System.Console.WriteLine("   Referee {0} say that the ball is at {1},{2},{3} ", _
                    myName, ballPosition.X, ballPosition.Y, ballPosition.Z)
    End Sub

    'A constructor which allows creating a reference to a ball
    Public Sub New(ByRef b As FootBall, ByVal refereeName As String)
        myName = refereeName
        ball = b
    End Sub

End Class ' END CLASS DEFINITION Referee
