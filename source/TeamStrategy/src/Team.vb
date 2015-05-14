'Context: The Team class
'This class encapsulates the algorithm

Public Class Team


    'Just a variable to keep the name of team
    Private teamName As String


    'A reference to the strategy algorithm to use
	Private strategy As TeamStrategy

    'ContextInterface to set the strategy
    Public Sub SetStrategy(ByVal s As TeamStrategy)
        'Set the strategy
        strategy = s
    End Sub

    'Function to play
    Public Sub PlayGame()
        'Print the team's name
        System.Console.WriteLine(" -" & teamName)
        'Play according to the strategy
        strategy.Play()
    End Sub

    'Constructor to create this class, by passing the team's
    'name

    Public Sub New(ByVal teamName As String)
        'Set the team name to use later
        Me.teamName = teamName
    End Sub

End Class ' END CLASS DEFINITION Team
