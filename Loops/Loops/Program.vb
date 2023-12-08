Imports System
Imports System.Diagnostics.Contracts

Module Program
    Sub Main(args As String())

        Dim LoopNumber As Integer

        LoopNumber = 7

        Select Case LoopNumber
            Case 1
                For i = 1 To 4
                    Console.Write(i & " ")
                Next i

            Case 2
                Dim index As Integer = 0
                Do While index <= 5
                    Console.Write(index & " ")
                    index += 1
                Loop
                Console.WriteLine("")
                Console.Write(index)
            Case 3
                Dim index As Integer = 5
                Do
                    Console.Write(index & " ")
                    index -= 1
                Loop Until index <= 0

            Case 4
                'Dim navn As String = "UngKolding"
                Dim navn As String = "Nørd"
                For Each letter In navn
                    Console.WriteLine(letter)
                Next letter

            Case 5
                Dim navn As String = "UngKolding"
                For Each i In navn
                    If i = "g" Then
                        Console.Write("z")
                    Else
                        Console.Write(i)
                    End If
                Next

            Case 6
                Dim navn As String = "UngKolding"
                Dim Res As String
                For Each i In navn
                    If i = "g" Then
                        Res = Res & "z"
                    Else
                        Res = Res & i
                    End If
                Next
                Console.Write(Res)

            Case 7
                'for loop med ungkolding
                Dim navn As String = "UngKolding"
                For i = 1 To 10
                    If Mid(navn, i, 1) = "g" Then
                        Console.Write("z")
                    Else
                        Console.Write(Mid(navn, i, 1))
                    End If
                Next

            Case Else
                Console.Write("ugyldigt loopnumber")
        End Select





    End Sub
End Module
