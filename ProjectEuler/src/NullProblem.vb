Public Class NullProblem
    Implements BaseProblem

    Public Function solve() As String Implements BaseProblem.solve
        Return "No solution!"
    End Function

    Public Function description() As String Implements BaseProblem.description
        Return "Problem does not exist!"

    End Function

    Public Function hints() As String Implements BaseProblem.hints
        Return ""
    End Function
End Class
