' ConcreteSubject : The Ball Class

Public Class FootBall
    Inherits Ball

    'State: The position of the ball
    Private myPosition As Position

    'This function will be called by observers to get current position
    Public Function GetBallPosition() As Position
        Return myPosition
    End Function

    'Some external client will call this to set the ball's position
    Public Function SetBallPosition(ByVal p As Position)
        myPosition = p
        'Once the position is updated, we have to notify observers
        NotifyObservers()
    End Function

    'Remarks: This can also be implemented as a get/set property

End Class ' END CLASS DEFINITION FootBall
