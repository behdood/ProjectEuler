Module MainEntry

    Sub Main()
        Dim console_msg As String = "Enter problem no ('exit' for exit) : "
        Dim problem_no As String
        Dim result As String
        Dim problem As BaseProblem

        Console.Write(console_msg)
        problem_no = Console.ReadLine()
        While (problem_no <> "exit")
            problem = problemFactory(problem_no)

            result = problem.solve()
            Console.Write("Problem " + problem_no + " : " + result + vbNewLine + console_msg)
            problem_no = Console.ReadLine()
        End While

    End Sub


    Function problemFactory(ByVal problem_no As String) As BaseProblem
        If (problem_no = "1") Then
            Return New P1
        Else
            Return New NullProblem
        End If

    End Function

End Module
