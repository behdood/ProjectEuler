Public Class P20
    Implements BaseProblem

    Public Function description() As String Implements BaseProblem.description
        Return "n! means n × (n − 1) × ... × 3 × 2 × 1" + vbNewLine +
            "For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800," +
            "and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27." + vbNewLine +
            "Find the sum of the digits in the number 100!"
    End Function

    Public Function hints() As String Implements BaseProblem.hints
        Return ""
    End Function

    Public Function solve() As String Implements BaseProblem.solve
        Return ""
    End Function
End Class
