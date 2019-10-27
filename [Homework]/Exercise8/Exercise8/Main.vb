Module Main

    Dim emps As New List(Of Employee) From {
        New SalariedEmployee("John", "Smith", "111-11-1111", 800.0),
        New CommissionEmployee("Sue", "Jones", "222-22-2222", 10000.0, 0.06),
        New BasePlusCommissionEmployee("Bob", "Lewis", "333-33-3333", 5000.0, 0.04, 300.0),
        New PieceWorker("Gob", "Bluth", "444-44-4444", 69.0, 100),
        New HourlyWorker("Michael", "Bluth", "555-55-5555", 48.0, 15.0)
    }
    Sub Main()
        Console.SetWindowSize(80, 40)

        Dim counter As Integer

        For Each ee In emps

            ' Console color
            If counter Mod 2 = 0 Then
                Console.ForegroundColor = ConsoleColor.DarkGray
            Else
                Console.ForegroundColor = ConsoleColor.Cyan
            End If

            ' Display employees
            Console.WriteLine(ee.ToString())

            Console.ResetColor()
            Console.WriteLine("".PadRight(55, "="))

            counter += 1 ' Increment
        Next

        Console.Write(vbNewLine & "Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
