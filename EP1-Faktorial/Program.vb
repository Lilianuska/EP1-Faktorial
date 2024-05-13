Imports System


Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim součin As Integer = 0

        Console.Write("Zadej èíslo: ")
        cislo = Console.ReadLine
        If cislo <= 0 Then
            Console.Write("Chyba vstupu!")
            End
        End If

        If cislo > 10 Then
            Console.Write("Zadej menší číslo!")
            End
        End If
        If cislo < 0 Then
            Console.Write("Zadej celé číslo!")
        End If



        součin = cislo * (cislo - 1)
        Next

        Console.WriteLine($"Součin od 1 do {cislo} je {součin}")



    End Sub
End Module
