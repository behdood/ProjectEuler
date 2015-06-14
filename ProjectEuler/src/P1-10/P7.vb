Public Class P7
    Implements BaseProblem

    Public Function description() As String Implements BaseProblem.description
        Return "By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13." + vbNewLine +
            "What is the 10 001st prime number?"
    End Function

    Public Function hints() As String Implements BaseProblem.hints
        Return ""
    End Function

    Public Function solve() As String Implements BaseProblem.solve
        Return ""
    End Function
End Class
