'David Harmon
'RCET0265
'Spring 2020
'Shuffle The Deck
'https://github.com/harmdavi/shuffleTheDeck.git

Option Strict On
Option Explicit On
Option Compare Text




Module shuffleTheDeck

    Sub Main()

        Dim row As Integer = 12
        Dim column As Integer = 3
        Dim formattedString As String
        Dim currentArray(13, 4) As Boolean
        Dim randomColumn As Integer
        Dim randomRow As Integer
        Dim cardSuit As String
        Dim cardNumber As String
        Dim cardsInDeck As Single
        Dim userinput As String
        'Dim cardsRemaining As Single
        Dim setRow As Integer
        Dim setColumn As Integer
        Dim intI As Integer
        Dim intJ As Integer
        ' Dim randomRowBuffer As Integer
        'Dim randomColumnBuffer As Integer

        ' Initialize the random-number generator.
        Randomize()
        'Sets the array to all false until shuffled so that we can switch it true and keep track of arleady used cards.
        cardsInDeck = 1
        Do Until cardsInDeck = -1
            For intI = 0 To 13
                For intJ = 0 To 4
                    'Sets entire array to false
                    currentArray(intI, intJ) = False


                    'If currentArray(intI, intJ) Then
                    '    Console.Write(" T ")
                    'Else
                    '    Console.Write(" F ")
                    'End If


                Next intJ

            Next intI


            cardsInDeck = 52
            Console.WriteLine($"You have {cardsInDeck} Cards left in the Deck. please press enter to take a card from the Deck. Press Q to exit at any time!")
            userinput = Console.ReadLine()
            If userinput = "q" Then
                Exit Sub
            End If
            Do Until cardsInDeck = 0
                For i = 0 To 52

                    randomColumn = CInt(Int((4 * Rnd())))
                    randomRow = CInt(Int((13 * Rnd())))
                    If Not currentArray(randomRow, randomColumn) Then
                        currentArray(randomRow, randomColumn) = True
                        'Console.WriteLine(randomRow, randomColumn)
                        cardsInDeck -= 1

                        'cardsInDeck = cardsRemaining

                        'This takes the number that is selected and displays them as a card value 

                        Select Case randomColumn
                            Case 0
                                cardSuit = " of Spades"
                            Case 1
                                cardSuit = " of Diamonds"
                            Case 2
                                cardSuit = " of Clubs"
                            Case 3
                                cardSuit = " of Hearts"
                            Case Else
                                Console.WriteLine("Error. Could not read Suit of Card")
                                userinput = Console.ReadLine()
                                If userinput = "q" Then
                                    Exit Sub
                                Else
                                End If
                        End Select

                        Select Case randomRow
                            Case 0
                                cardNumber = "Ace"
                            Case 1
                            Case 2 To 9
                                cardNumber = CStr(randomRow)
                            Case 10
                                cardNumber = "Jack"
                            Case 11
                                cardNumber = "Queen"
                            Case 12
                                cardNumber = "King"
                            Case Else
                                Console.WriteLine("Error. Could not read Number of card.")
                                userinput = Console.ReadLine()
                                If userinput = "q" Then
                                    Exit Sub
                                End If
                        End Select

                        'Displays cards values 

                        Console.WriteLine(cardNumber & cardSuit)
                        'Console.WriteLine(currentArray)
                        Console.WriteLine()
                        Console.WriteLine($"You have {cardsInDeck} Cards left in the Deck")
                        userinput = Console.ReadLine()
                        If userinput = "q" Then
                            Exit Sub
                        End If









                        'For i = 0 To row
                        '    For j = 0 To column
                        '        formattedString = $" {i},{j} "
                        '        'Console.Write(formattedString.PadLeft(8))
                        '        If currentArray(i, j) Then
                        '            Console.Write(" T ")
                        '        Else
                        '            Console.Write(" F ")
                        '        End If
                        '    Next
                        '    Console.WriteLine()
                        'Next
                        'userinput = Console.ReadLine()
                        'If userinput = "q" Then
                        '    Exit Sub
                        'Else
                        'End If

                        'If the programs selects something that has already been selected then nothing is displayed 
                        'and the computer re excicutes its function 


                    ElseIf currentArray(randomRow, randomColumn) = True Then

                        'Console.WriteLine($"Row {randomRow} , Column {randomColumn}")
                    Else
                        Console.WriteLine("something broke when assinging a number")
                        userinput = Console.ReadLine()
                        If userinput = "q" Then
                            Exit Sub
                        End If

                    End If
                Next
                'This starts the loop to the begining so that it "shuffles the deck" 
                If cardsInDeck = 0 Then
                    Console.WriteLine("Time To Shuffle!")

                    'This allows the user to quit at any time. 

                    Select Case Console.ReadKey().Key
                        Case ConsoleKey.Q
                            Exit Sub
                    End Select
                    'userinput = Console.ReadLine()
                    'If userinput = "q" Then
                    '    Exit Sub
                    'End If
                    Console.Clear()

                End If
            Loop

        Loop
    End Sub

End Module
