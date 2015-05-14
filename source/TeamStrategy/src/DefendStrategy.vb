'ConcreteStrategy: The DefendStrategy class

'This class is a concrete implementation of the
'strategy class.

Public Class DefendStrategy
	 Inherits TeamStrategy

    'Overrides the Play function. 
    'Let us go defensive
    Public Overrides Sub Play()
        'Algorithm to defend
        System.Console.WriteLine("   Playing in defensive mode")
    End Sub

End Class ' END CLASS DEFINITION DefendStrategy
