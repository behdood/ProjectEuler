Public Class P6
    Implements BaseProblem

    Public Function description() As String Implements BaseProblem.description
        Return "The sum of the squares of the first ten natural numbers is," + vbNewLine +
            "1^2 + 2^2 + ... + 10^2 = 385" + vbNewLine +
            "The square of the sum of the first ten natural numbers is," + vbNewLine +
            "(1 + 2 + ... + 10)^2 = 552 = 3025" + vbNewLine +
            "Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is " +
            "3025 − 385 = 2640." + vbNewLine +
            "Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum."
    End Function

    Public Function hints() As String Implements BaseProblem.hints
        Return ""
    End Function

    Public Function solve() As String Implements BaseProblem.solve
        Return ""
    End Function
End Class
