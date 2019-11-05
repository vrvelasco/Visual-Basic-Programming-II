Module Main
    Dim shapes() = {
        New Square(1),
        New Circle(2),
        New Cube(3),
        New Sphere(4)
        }
    Sub Main()
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
        Console.Write("Press any key to exit...")
        Console.ReadKey()
    End Sub

End Module
