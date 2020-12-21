Module Module1
    Sub Main()
        Dim calc As String = ""
        Do Until calc = "Q" Or calc = "q"
            Console.Write("Calculation: ")
            Try
                calc = CInt(Console.ReadLine())
            Catch ex As InvalidCastException
                Console.WriteLine("Cast error")
            End Try
            Dim operand1 As String = ""
            Dim length As Integer = 0
            Dim operand2 As String = ""
            Dim op As String = ""
            For i As Integer = 0 To calc.Length - 1
                If calc(i) = "*" Or calc(i) = "/" Or calc(i) = "+" Or calc(i) = "-" Then
                    op = calc(i)
                    length = i - 1
                End If
            Next
            For i As Integer = 0 To length
                operand1 += calc(i)
            Next
            For i As Integer = length + 2 To calc.Length - 1
                operand2 += calc(i)
            Next
            Select Case op
                Case "*"
                    Console.WriteLine(Val(operand1) * Val(operand2))
                Case "/"
                    Console.WriteLine(Val(operand1) / Val(operand2))
                Case "+"
                    Console.WriteLine(Val(operand1) + Val(operand2))
                Case "-"
                    Console.WriteLine(Val(operand1) - Val(operand2))
            End Select
        Loop
    End Sub
End Module
