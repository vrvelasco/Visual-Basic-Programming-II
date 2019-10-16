Module Main

    Sub Main()
        ' Variables
        Dim choice As Integer
        Dim checking As CheckingAccount
        Dim savings As SavingsAccount

        Console.WriteLine("
  _____       _               _ _                         ____              _    
 |_   _|     | |             (_) |                       |  _ \            | |   
   | |  _ __ | |__   ___ _ __ _| |_ __ _ _ __   ___ ___  | |_) | __ _ _ __ | | __
   | | | '_ \| '_ \ / _ \ '__| | __/ _` | '_ \ / __/ _ \ |  _ < / _` | '_ \| |/ /
  _| |_| | | | | | |  __/ |  | | || (_| | | | | (_|  __/ | |_) | (_| | | | |   < 
 |_____|_| |_|_| |_|\___|_|  |_|\__\__,_|_| |_|\___\___| |____/ \__,_|_| |_|_|\_\
                                                                                 
Welcome! Please make a selection below.                                           ")
        ' Display menu
        DisplayMainMenu()

        choice = ValidateSelection(Console.ReadLine()) ' Get the user's choice

        While choice <> 3 ' Loop until user wants to exit
            If choice >= 1 And choice <= 2 Then ' Check that the choice is within range
                Select Case choice
                    '*****************
                    ' Checking account
                    '*****************
                    Case 1
                        Try
                            Console.Write(vbNewLine & "What is the initial balance of the account?: $")
                            Dim b = Console.ReadLine()

                            Console.Write("What is the fee for this account?: $")
                            Dim f = Console.ReadLine()

                            checking = New CheckingAccount(b, f) ' Try to create a new checking account

                            Console.Write(vbNewLine & "SUCCESS: The checking account was opened." & vbNewLine)

                            '*********************
                            ' Display account menu
                            '*********************
                            DisplayCheckingMenu()
                            Dim aChoice = ValidateSelection(Console.ReadLine()) ' Get the user's choice again

                            While aChoice <> 4 ' Loop through account menu
                                If aChoice >= 1 And aChoice <= 3 Then ' Check that the choice is within range
                                    Select Case aChoice
                                        Case 1 ' Check balance
                                            Console.WriteLine(vbNewLine & "The balance is: " & checking.Balance.ToString("c"))
                                        Case 2 ' Make a deposit
                                            Console.Write(vbNewLine & "Amount of deposit: $")
                                            Dim deposit = ValidateAmount(Console.ReadLine())

                                            checking.Credit(deposit)
                                            Console.WriteLine(String.Format(vbNewLine & "{0} was deposited in the account. A fee of {1} was charged.", deposit.ToString("c"), checking.Fee.ToString("c")))
                                        Case 3 ' Withdrawl funds
                                            Console.Write(vbNewLine & "Amount of withdrawl: $")
                                            Dim withdrawal = ValidateAmount(Console.ReadLine())

                                            Try
                                                checking.Debit(withdrawal)
                                                Console.WriteLine(String.Format(vbNewLine & "{0} was debited from the account. A fee of {1} was charged.", withdrawal.ToString("c"), checking.Fee.ToString("c")))
                                            Catch ex As Exception
                                                Console.WriteLine(vbNewLine & "ERROR: The debit amount exceeds the current balance.")
                                            End Try
                                    End Select
                                Else
                                    Console.WriteLine(vbNewLine & "ERROR: Invalid choice. Please try again!")
                                End If

                                ' Display menu again
                                DisplayCheckingMenu()

                                aChoice = ValidateSelection(Console.ReadLine()) ' Get the user's choice again
                            End While

                            ' Exiting the account menu
                            Console.WriteLine(vbNewLine & "Returning to the main menu. Press any key to continue...")
                            Console.ReadKey()
                        Catch ex As Exception
                            Console.WriteLine(vbNewLine & "Error: Initial balance has to be greater than or equal to $0.00.") ' Failed to create the account
                        End Try

                        '*****************
                        ' Savings account
                        '*****************
                    Case 2
                        Try
                            Console.Write(vbNewLine & "What is the initial balance of the account?: $")
                            Dim b = Console.ReadLine()

                            Console.Write("What is the interest rate for this account?: ")
                            Dim r = Console.ReadLine()

                            savings = New SavingsAccount(b, r) ' Try to create a new savings account

                            Console.Write(vbNewLine & "SUCCESS: The savings account was opened." & vbNewLine)

                            '*********************
                            ' Display account menu
                            '*********************
                            DisplaySavingsMenu()
                            Dim aChoice = ValidateSelection(Console.ReadLine()) ' Get the user's choice again

                            While aChoice <> 5 ' Loop through account menu
                                If aChoice >= 1 And aChoice <= 4 Then ' Check that the choice is within range
                                    Select Case aChoice
                                        Case 1 ' Check balance
                                            Console.WriteLine(vbNewLine & "The balance is: " & savings.Balance.ToString("c"))
                                        Case 2 ' Make a deposit
                                            Console.Write(vbNewLine & "Amount of deposit: $")
                                            Dim deposit = ValidateAmount(Console.ReadLine())

                                            savings.Credit(deposit)
                                            Console.WriteLine(String.Format(vbNewLine & "{0} was deposited in the account.", deposit.ToString("c")))
                                        Case 3 ' Withdrawl funds
                                            Console.Write(vbNewLine & "Amount of withdrawl: $")
                                            Dim withdrawal = ValidateAmount(Console.ReadLine())

                                            Try
                                                savings.Debit(withdrawal)
                                                Console.WriteLine(String.Format(vbNewLine & "{0} was debited from the account.", withdrawal.ToString("c")))
                                            Catch ex As Exception
                                                Console.WriteLine(vbNewLine & "ERROR: The debit amount exceeds the current balance.")
                                            End Try
                                        Case 4
                                            Dim interest As Double
                                            interest = savings.CalculateInterest()
                                            savings.Credit(interest)

                                            Console.WriteLine(String.Format(vbNewLine & "{0} credited to the account for interest.", interest.ToString("c")))
                                    End Select
                                Else
                                    Console.WriteLine(vbNewLine & "ERROR: Invalid choice. Please try again!")
                                End If

                                ' Display menu again
                                DisplaySavingsMenu()

                                aChoice = ValidateSelection(Console.ReadLine()) ' Get the user's choice again
                            End While

                            ' Exiting the account menu
                            Console.WriteLine(vbNewLine & "Returning to the main menu. Press any key to continue...")
                            Console.ReadKey()
                        Catch ex As Exception
                            Console.WriteLine(vbNewLine & "Error: Initial balance has to be greater than or equal to $0.00.") ' Failed to create the account
                        End Try
                End Select
            Else
                Console.WriteLine(vbNewLine & "ERROR: Invalid choice. Please try again!")
            End If

            ' Display menu again
            DisplayMainMenu()

            choice = ValidateSelection(Console.ReadLine()) ' Get the user's choice again
        End While

        ' Program ended
        Console.Write(vbNewLine & "Thank you for banking with Inheritance Bank!" & vbNewLine & vbNewLine & "Press any key to continue...")
        Console.ReadKey()
    End Sub

    Private Sub DisplayMainMenu()
        Console.Write(vbNewLine &
                      "╔════════════════════════════════╗" & vbNewLine &
                      "║           MAIN  MENU           ║" & vbNewLine &
                      "╠════════════════════════════════╣" & vbNewLine &
                      "║ 1) Open a new checking account ║" & vbNewLine &
                      "║ 2) Open a new savings account  ║" & vbNewLine &
                      "║ 3) Exit                        ║" & vbNewLine &
                      "╚════════════════════════════════╝" & vbNewLine &
                      "SELECTION: ")
    End Sub

    Private Sub DisplayCheckingMenu()
        Console.Write(vbNewLine &
                      "╔════════════════════════════════╗" & vbNewLine &
                      "║     CHECKING  ACCOUNT  MENU    ║" & vbNewLine &
                      "╠════════════════════════════════╣" & vbNewLine &
                      "║ 1) View balance                ║" & vbNewLine &
                      "║ 2) Make a deposit              ║" & vbNewLine &
                      "║ 3) Withdrawl funds             ║" & vbNewLine &
                      "║ 4) Exit                        ║" & vbNewLine &
                      "╚════════════════════════════════╝" & vbNewLine &
                      "SELECTION: ")
    End Sub

    Private Sub DisplaySavingsMenu()
        Console.Write(vbNewLine &
                      "╔════════════════════════════════╗" & vbNewLine &
                      "║      SAVINGS ACCOUNT  MENU     ║" & vbNewLine &
                      "╠════════════════════════════════╣" & vbNewLine &
                      "║ 1) View balance                ║" & vbNewLine &
                      "║ 2) Make a deposit              ║" & vbNewLine &
                      "║ 3) Withdrawl funds             ║" & vbNewLine &
                      "║ 4) Pay interest                ║" & vbNewLine &
                      "║ 5) Exit                        ║" & vbNewLine &
                      "╚════════════════════════════════╝" & vbNewLine &
                      "SELECTION: ")
    End Sub

    Private Function ValidateSelection(s As String) As Integer
        Dim choice As Integer
        ' Convert from String to Integer
        If Not Integer.TryParse(s, choice) Then
            choice = 0
        End If

        Return choice
    End Function

    Private Function ValidateAmount(s As String) As Decimal
        Dim amount As Decimal
        ' Convert from String to Decimal
        If Not Decimal.TryParse(s, amount) Then
            amount = 0
        End If

        Return amount
    End Function
End Module
