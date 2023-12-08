Imports System

Module Program
    Sub Main(args As String())
        Dim alfabet As String = "abcdefghijklmnopqrstuvwxyzæøå"
        Dim navne() As String = {"æble", "banan", "pære", "ananas", "jordbær"}

        For Each ele In navne
            Console.WriteLine(ele)
        Next
        Console.WriteLine("")

        Dim sortering(0) As String

        For i = 1 To Len(alfabet)
            For Each ele In navne
                If ele.Substring(0, 1) = alfabet.Substring(i - 1, 1) Then
                    If sortering(0) = "" Then
                        sortering(0) = ele
                    Else
                        ReDim Preserve sortering(UBound(sortering) + 1)
                        sortering(UBound(sortering)) = ele
                    End If
                End If
            Next
        Next

        For Each part In sortering
            Console.WriteLine(part)
        Next

        Console.WriteLine("")
        Array.Sort(navne)
        For Each part In navne
            Console.WriteLine(part)
        Next
    End Sub
End Module
