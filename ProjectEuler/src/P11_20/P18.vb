Public Class P18
    Implements BaseProblem

    Public Function description() As String Implements BaseProblem.description
        Return "If the numbers 1 to 5 are written out in words: " +
            "one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total." + vbNewLine +
            "If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?"
    End Function

    Public Function hints() As String Implements BaseProblem.hints
        Return "Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters " +
            "and 115 (one hundred and fifteen) contains 20 letters. The use of 'and' when writing out numbers is in compliance with British usage."
    End Function

    Public Function solve() As String Implements BaseProblem.solve
        Return ""
    End Function
End Class
