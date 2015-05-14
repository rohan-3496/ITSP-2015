'Decorator: PlayerRole is the decorator

Public Class PlayerRole
    Inherits player

    'The reference to the player
    Protected player As player

    'Call the base component's function
    Public Overrides Sub PassBall()
        player.PassBall()
    End Sub

    'This function is used to assign a player to this role
    Public Sub AssignPlayer(ByVal p As player)
        'Keep a reference to the player, to whom this
        'role is given
        player = p
    End Sub


End Class ' END CLASS DEFINITION PlayerRole
