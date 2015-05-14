' Component: The Player class

Public MustInherit Class Player

    'Just give a name for this player
    Private myName As String

    'The property to get/set the name
    Public Property Name() As String
        Get
            Return myName
        End Get
        Set(ByVal Value As String)
            myName = Value
        End Set
    End Property

    'This is the Operation in the component
    'and this will be overrided by concrete components
    Public MustOverride Sub PassBall()

End Class ' END CLASS DEFINITION Player
