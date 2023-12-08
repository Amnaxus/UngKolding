Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Vælg funktion")
        Console.WriteLine("1. addition")
        Console.WriteLine("2. subtraktion")
        Console.WriteLine("3. multiplikation")
        Dim p As Integer
        p = Val(Console.ReadLine())

        If p = 1 Then
            Dim a As Integer, b As Integer
            Console.WriteLine("skriv første tal")
            a = Console.ReadLine()
            Console.WriteLine("skriv andet tal")
            b = Console.ReadLine()

            Console.WriteLine("resultatet er: " & a + b)
        ElseIf p = 2 Then
            Dim a As Integer, b As Integer
            Console.WriteLine("skriv første tal")
            a = Console.ReadLine()
            Console.WriteLine("skriv andet tal")
            b = Console.ReadLine()

            Console.WriteLine("resultatet er: " & a - b)
        ElseIf p = 3 Then
            Dim a As Integer, b As Integer
            Console.WriteLine("skriv første tal")
            a = Console.ReadLine()
            Console.WriteLine("skriv andet tal")
            b = Console.ReadLine()

            Console.WriteLine("resultatet er: " & a * b)
        Else
            Console.WriteLine("valget er ikke valid")
        End If



    End Sub
End Module
