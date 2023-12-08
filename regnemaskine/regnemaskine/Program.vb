Imports System

Module Program

    Function cwl(p As String)
        Console.WriteLine(p)
    End Function

    Sub Main(args As String())

        cwl("Jeg er en regnemaskine")
        cwl("Vælg en funktion:")
        cwl("1. Addition")
        cwl("2. Subtraktion")
        cwl("3. Multiplikation")
        cwl("4. Division")
        cwl("5. Gennemsnit")
        cwl("6. Kvadratrod")

        Dim valg

        valg = Val(Console.ReadLine())
        Select Case valg
            Case 1
                Dim a, b As Integer
                cwl("Jeg kan addere to tal. Skriv første tal:")
                a = Val(Console.ReadLine())
                cwl("Skriv andet tal:")
                b = Val(Console.ReadLine())
                cwl("Resultatet er: " & a + b)
            Case 2
                Dim a, b As Integer
                cwl("Jeg kan trække to tal fra hinanden. Skriv første tal:")
                a = Val(Console.ReadLine())
                cwl("Skriv andet tal:")
                b = Val(Console.ReadLine())
                cwl("Resultatet er: " & a - b)
            Case 3
                Dim a, b As Integer
                cwl("Jeg kan gange to tal med hinanden. Skriv første tal:")
                a = Val(Console.ReadLine())
                cwl("Skriv andet tal:")
                b = Val(Console.ReadLine())
                cwl("Resultatet er: " & a * b)
            Case 4
                Dim a, b As Integer
                cwl("Jeg kan dividere to tal med hinanden. Skriv første tal:")
                a = Val(Console.ReadLine())
                cwl("Skriv andet tal:")
                b = Val(Console.ReadLine())
                If b = 0 Then
                    cwl("Du kan ikke dividere med 0, prøv igen.")
                    Exit Select
                End If
                cwl("Resultatet er: " & a / b)
            Case 5
                Dim a, b As Integer
                cwl("Jeg kan tage gennemsnittet af to tal. Skriv første tal:")
                a = Val(Console.ReadLine())
                cwl("Skriv andet tal:")
                b = Val(Console.ReadLine())
                cwl("Resultatet er: " & (a + b) / 2)
            Case 6
                Dim a As Integer
                cwl("Jeg kan tage kvadratroden af et tal:")
                a = Val(Console.ReadLine())
                If a < 0 Then
                    cwl("Du kan ikke tage kvadratroden af et negativt tal")
                    Exit Select
                End If
                cwl("Resultatet er: " & Math.Sqrt(a))
            Case Else
                cwl("Du har ikke valgt en valid funktion. Prøv igen.")
        End Select



    End Sub


End Module
