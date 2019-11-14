Module Main
    Private transportation As New List(Of Vehicle) From {
        New Bicycle(50, 150),
        New Carpool(50, 15, 5),
        New Auto(50, 25)
    }
    Sub Main()
        Console.SetWindowSize(55, 15)
        Console.WriteLine("EXAM 3: Commuter Travel Options".PadLeft(44))

        Dim counter As Integer

        For Each t In transportation
            ' Console color
            If counter Mod 2 = 0 Then
                Console.ForegroundColor = ConsoleColor.Cyan
            Else
                Console.ForegroundColor = ConsoleColor.Green
            End If

            ' Display shapes
            Console.WriteLine(t.ToString())
            Console.ResetColor() ' Reset to white
            Console.WriteLine("".PadLeft(55, "═"))

            counter += 1 ' Increment counter
        Next
        Console.Write(vbNewLine & "Press any key to exit...")
        Console.ReadKey()
    End Sub

End Module
