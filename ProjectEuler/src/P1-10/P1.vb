Public Class P1
    Implements BaseProblem

    Public Function solve() As String Implements BaseProblem.solve
        Return
    End Function

    Public Function description() As String Implements BaseProblem.description
        Return "If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. " +
            "The sum of these multiples is 23." + vbNewLine + "Find the sum of all the multiples of 3 or 5 below 1000."
    End Function

    Public Function hints() As String Implements BaseProblem.hints
        Return ""
    End Function
End Class
