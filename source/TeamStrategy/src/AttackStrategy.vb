'ConcreteStrategy: The AttackStrategy class

'This class is a concrete implementation of the
'strategy class.

Public Class AttackStrategy
	 Inherits TeamStrategy

    'Overrides the Play function. 
    'Let us play some attacking game

    Public Overrides Sub Play()
        'Algorithm to attack
        System.Console.WriteLine("   Playing in attacking mode")
    End Sub

End Class ' END CLASS DEFINITION AttackStrategy
