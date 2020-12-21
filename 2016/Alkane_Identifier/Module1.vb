Module Module1

    Dim InputAlkane As New Alkane
    Sub Main()
        Dim Choice As Integer = 1
        Do Until Choice = 0
            Dim Valid As Boolean = False
            ShowMenu(Choice)
            If Choice <> 0 Then
                GetFormula(Choice)
                If Choice = 1 Then
                    InputAlkane.AnalysisM()
                ElseIf Choice = 2 Then
                    InputAlkane.AnalysisS()
                End If
                Valid = CheckValid()
                If Valid Then
                    Dim Output As String() = InputAlkane.Results(Choice)
                    Console.WriteLine(Output(0))
                    Console.ForegroundColor = ConsoleColor.DarkGreen
                    Console.WriteLine(Output(1))
                    Console.ForegroundColor = ConsoleColor.Gray
                    InputAlkane.Displayed()
                Else
                    Console.WriteLine("Formula is not a normal aliphatic alkane.")
                End If
            End If
        Loop
    End Sub

    Sub ShowMenu(ByRef Choice As Integer)
        Console.WriteLine()
        Console.WriteLine("1. Molecular  -> Structural")
        Console.WriteLine("2. Structural -> Molecular")
        Console.WriteLine("0. Quit")
        Choice = Console.ReadLine()
    End Sub
    Sub GetFormula(ByVal Choice As Integer)
        If Choice = 1 Then
            Console.Write("Enter molecular formula: ")
        ElseIf Choice = 2 Then
            Console.Write("Enter structural formula: ")
        End If
        InputAlkane.PFormula() = Console.ReadLine()
    End Sub

    Function CheckValid()
        If (InputAlkane.PNoH - 2) / 2 = InputAlkane.PNoC Then
            Return True
        Else
            Return False
        End If
    End Function

    'Sub Displayed(ByVal NoC As Integer)
    '    Console.WriteLine()
    '    If NoC = 1 Then
    '        Console.WriteLine("     H")
    '        Console.WriteLine("     I")
    '        Console.WriteLine(" H - C - H")
    '        Console.WriteLine("     I")
    '        Console.WriteLine("     H")
    '    ElseIf NoC = 2 Then
    '        Console.WriteLine("     H   H")
    '        Console.WriteLine("     I   I")
    '        Console.WriteLine(" H - C - C - H")
    '        Console.WriteLine("     I   I")
    '        Console.WriteLine("     H   H")
    '    Else
    '        Console.Write("     H   ")
    '        For i As Integer = 2 To NoC
    '            Console.Write("H   ")
    '        Next
    '        Console.WriteLine()
    '        Console.Write("     I   ")
    '        For i As Integer = 2 To NoC
    '            Console.Write("I   ")
    '        Next
    '        Console.WriteLine()
    '        Console.Write(" H - ")
    '        For i As Integer = 1 To NoC
    '            Console.Write("C - ")
    '        Next
    '        Console.WriteLine("H")
    '        Console.Write("     I   ")
    '        For i As Integer = 2 To NoC
    '            Console.Write("I   ")
    '        Next
    '        Console.WriteLine()
    '        Console.Write("     H   ")
    '        For i As Integer = 2 To NoC
    '            Console.Write("H   ")
    '        Next
    '        Console.WriteLine()
    '    End If
    'End Sub

    'Sub GiveResults(ByRef Choice As Integer, ByRef NoC As Integer, ByRef NoH As Integer)
    '    If Choice = 1 And NoC > 1 Then
    '        If NoC <> 2 Then
    '            Console.Write("CH3(CH2)" & NoC - 2 & "CH3")
    '            Console.Write(" [CH3")
    '            For i As Integer = 1 To NoC - 2
    '                Console.Write("CH2")
    '            Next
    '            Console.WriteLine("CH3]")
    '        Else
    '            Console.WriteLine("CH3CH3") 'special clause for CH3CH3 (no (CH2) section messes with analysis
    '        End If
    '    ElseIf Choice = 2 And NoC > 1 Then
    '        Console.WriteLine("Molecular formula: C" & NoC & "H" & NoH) 'prints Molecular formula with NoC and NoH
    '    Else
    '        Console.WriteLine("CH4") 'special clause for CH4 (only 3 char, messes with analysis
    '    End If
    '    Console.ForegroundColor = ConsoleColor.DarkGreen
    '    Select Case NoC                 'Name and number references
    '        Case 1
    '            Console.Write("Meth")
    '        Case 2
    '            Console.Write("Eth")
    '        Case 3
    '            Console.Write("Prop")
    '        Case 4
    '            Console.Write("But")
    '        Case 5
    '            Console.Write("Pent")
    '        Case 6
    '            Console.Write("Hex")
    '        Case 7
    '            Console.Write("Hept")
    '        Case 8
    '            Console.Write("Oct")
    '        Case 9
    '            Console.Write("Non")
    '        Case 10
    '            Console.Write("Dec")
    '        Case 11
    '            Console.Write("Undec")
    '        Case 12
    '            Console.Write("Dodec")
    '        Case 13
    '            Console.Write("Tridec")
    '        Case 14
    '            Console.Write("Tetradec")
    '        Case 15
    '            Console.Write("Pentadec")
    '        Case 16
    '            Console.Write("Hexadec")
    '        Case 17
    '            Console.Write("Heptadec")
    '        Case 18
    '            Console.Write("Octadec")
    '        Case 19
    '            Console.Write("Nonadec")
    '        Case 20
    '            Console.Write("Icos")
    '        Case Else
    '            Console.Write("Greek-Name-")
    '    End Select
    '    Console.WriteLine("ane")
    '    Console.ForegroundColor = ConsoleColor.Gray
    '    Displayed(NoC)
    'End Sub
End Module
