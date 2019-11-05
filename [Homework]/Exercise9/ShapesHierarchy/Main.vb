Module Main
    Dim shapes() = { ' *** The book wanted an array. Including list below. ***
        New Square(1),
        New Circle(2),
        New Cube(3),
        New Sphere(4)
    }

    'Dim shapes As New List(Of Shape) From { ' *** List ***
    '    New Square(1),
    '    New Circle(2),
    '    New Cube(3),
    '    New Sphere(4)
    '    }

    Sub Main()
        Console.SetWindowSize(35, 25)

        Dim counter As Integer

        For Each s In shapes
            ' Console color
            If counter Mod 2 = 0 Then
                Console.ForegroundColor = ConsoleColor.DarkGreen
            Else
                Console.ForegroundColor = ConsoleColor.DarkRed
            End If

            ' Display shapes
            Console.WriteLine(s.ToString())
            Console.ResetColor() ' Reset to white
            Console.WriteLine("".PadLeft(35, "="))

            counter += 1 ' Increment counter
        Next
        Console.Write(vbNewLine & "Press any key to exit...")
        Console.ReadKey()
    End Sub

End Module
