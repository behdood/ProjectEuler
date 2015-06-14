Public Class P19
    Implements BaseProblem

    Public Function description() As String Implements BaseProblem.description
        Return "You are given the following information, but you may prefer to do some research for yourself." + vbNewLine +
            "1 Jan 1900 was a Monday." + vbNewLine +
            "Thirty days has September," + vbNewLine +
            "April, June and November." + vbNewLine +
            "All the rest have thirty-one," + vbNewLine +
            "Saving February alone," + vbNewLine +
            "Which has twenty-eight, rain or shine." + vbNewLine +
            "And on leap years, twenty-nine." + vbNewLine +
            "A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400." + vbNewLine +
            "How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?"
    End Function

    Public Function hints() As String Implements BaseProblem.hints
        Return ""
    End Function

    Public Function solve() As String Implements BaseProblem.solve
        Return ""
    End Function
End Class
