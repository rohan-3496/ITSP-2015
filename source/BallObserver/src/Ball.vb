' Subject : The Ball Class

Public Class Ball

    'A private list of observers
    Private observers As New System.Collections.ArrayList()

    'Routine to attach an observer
    Public Sub AttachObserver(ByVal obj As IObserver)
        observers.Add(obj)
    End Sub

    'Routine to remove an observer
    Public Sub DetachObserver(ByVal obj As IObserver)
        observers.Remove(obj)
    End Sub

    'Routine to notify all observers
    Public Sub NotifyObservers()
        Dim o As IObserver
        For Each o In observers
            o.Update()
        Next
    End Sub

End Class ' END CLASS DEFINITION Ball
