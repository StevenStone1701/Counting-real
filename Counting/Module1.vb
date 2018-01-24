Module Module1

    Sub Main()
        Console.Write("write a number: ")
        Dim N As String = Console.ReadLine
        Int(N)
        Dim J As Integer = 1
        Do While (N > J)
            If N > J Then
                Console.Write(" " & J)
            End If
            J = J + 1
        Loop
        If N = J Then
            Console.Write(" " & J)
        End If
        Console.ReadLine()
    End Sub

End Module
