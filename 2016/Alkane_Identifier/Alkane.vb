Public Class Alkane
    Private NoH, NoC As Integer
    Private Formula As String

    Public Sub New()
        NoH = 0
        NoC = 0
        Formula = ""
    End Sub

#Region "Get/Set Blocks"
    Property PNoH As Integer
        Set(value As Integer)
            NoH = value
        End Set
        Get
            Return NoH
        End Get
    End Property

    Property PNoC As Integer
        Set(value As Integer)
            NoC = value
        End Set
        Get
            Return NoC
        End Get
    End Property

    Property PFormula() As String
        Set(value As String)
            Formula = value
        End Set
        Get
            Return Formula
        End Get
    End Property
#End Region

    Public Sub AnalysisM()
        If Formula.Length > 3 Then
            Dim Num As String = Formula(1)
            If Formula.Length > 5 Then
                Num += Formula(2)
            End If
            NoC = CInt(Num)
            If NoC < 10 Then
                Num = Formula(3)
                If Formula.Length > 4 Then
                    Num += Formula(4)
                End If
            Else
                Num = Formula(4) & Formula(5)
            End If
            NoH = CInt(Num)
        ElseIf UCase(Formula) = "CH4" Then
            NoC = 1
            NoH = 4
        Else
            NoC = 0
            NoH = 0
        End If
    End Sub

    Public Sub AnalysisS()
        If UCase(Formula) = "CH4" Then
            NoC = 1
            NoH = 4
        ElseIf UCase(Formula) = "CH3CH3" Then
            NoC = 2
            NoH = 6
        ElseIf UCase(Formula) = "CH3(CH2)CH3" Or UCase(Formula) = "CH3CH2CH3" Then
            NoC = 3
            NoH = 8
        ElseIf Formula.Length >= 12 Then
            If Formula(3) = "(" Then
                Dim Num As String = Formula(8)
                If Formula.Length > 12 Then
                    Num += Formula(9)
                End If
                If Formula(2) = "3" And Formula(6) = "2" And Formula(Formula.Length - 1) = "3" Then
                    NoC = CInt(Num) + 2
                    NoH = (CInt(Num) * 2) + 6
                Else
                    NoC = 0
                    NoH = 0
                End If
            Else
                For i As Integer = 0 To Formula.Length - 1
                    If UCase(Formula(i)) = "C" Then
                        NoC += 1
                    ElseIf UCase(Formula(i)) = "H" Then
                        If UCase(Formula(i + 1)) <> "C" And i + 1 <= Formula.Length - 1 Then
                            Dim Num As String = Formula(i + 1)
                            NoH += CInt(Num)
                        End If
                    End If
                Next
            End If
        Else
            NoC = 0
            NoH = 0
        End If
    End Sub

    Public Sub Displayed()
        Console.WriteLine()
        If NoC = 1 Then
            Console.WriteLine("     H")
            Console.WriteLine("     I")
            Console.WriteLine(" H - C - H")
            Console.WriteLine("     I")
            Console.WriteLine("     H")
        ElseIf NoC = 2 Then
            Console.WriteLine("     H   H")
            Console.WriteLine("     I   I")
            Console.WriteLine(" H - C - C - H")
            Console.WriteLine("     I   I")
            Console.WriteLine("     H   H")
        Else
            Console.Write("     H   ")
            For i As Integer = 2 To NoC
                Console.Write("H   ")
            Next
            Console.WriteLine()
            Console.Write("     I   ")
            For i As Integer = 2 To NoC
                Console.Write("I   ")
            Next
            Console.WriteLine()
            Console.Write(" H - ")
            For i As Integer = 1 To NoC
                Console.Write("C - ")
            Next
            Console.WriteLine("H")
            Console.Write("     I   ")
            For i As Integer = 2 To NoC
                Console.Write("I   ")
            Next
            Console.WriteLine()
            Console.Write("     H   ")
            For i As Integer = 2 To NoC
                Console.Write("H   ")
            Next
            Console.WriteLine()
        End If
    End Sub

    Public Function Results(ByVal Choice As Integer)
        Dim OutputFormula, OutputName As String
        If Choice = 1 And NoC > 1 Then
            If NoC <> 2 Then
                OutputFormula = "CH3(CH2)" & NoC - 2 & "CH3 [CH3"
                For i As Integer = 1 To NoC - 2
                    OutputFormula += "CH2"
                Next
                OutputFormula += "CH3]"
            Else
                OutputFormula = "CH3CH3" 'special clause for CH3CH3 (no (CH2) section messes with analysis)
            End If
        ElseIf Choice = 2 And NoC > 1 Then
            OutputFormula = "Molecular formula: C" & NoC & "H" & NoH 'prints Molecular formula with NoC and NoH
        Else
            OutputFormula = "CH4" 'special clause for CH4 (only 3 char, messes with analysis)
        End If
        Select Case NoC                 'Name and number references
            Case 1
                OutputName = "Methane"
            Case 2
                OutputName = "Ethane"
            Case 3
                OutputName = "Propane"
            Case 4
                OutputName = "Butane"
            Case 5
                OutputName = "Pentane"
            Case 6
                OutputName = "Hexane"
            Case 7
                OutputName = "Heptane"
            Case 8
                OutputName = "Octane"
            Case 9
                OutputName = "Nonane"
            Case 10
                OutputName = "Decane"
            Case 11
                OutputName = "Undecane"
            Case 12
                OutputName = "Dodecane"
            Case 13
                OutputName = "Tridecane"
            Case 14
                OutputName = "Tetradecane"
            Case 15
                OutputName = "Pentadecane"
            Case 16
                OutputName = "Hexadecane"
            Case 17
                OutputName = "Heptadecane"
            Case 18
                OutputName = "Octadecane"
            Case 19
                OutputName = "Nonadecane"
            Case 20
                OutputName = "Icosane"
            Case Else
                OutputName = "Greek-name-ane"
        End Select
        Return {OutputFormula, OutputName}
    End Function
End Class
