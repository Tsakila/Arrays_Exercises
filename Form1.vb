Public Class Form1
    Private Sub btnExercise1_Click(sender As Object, e As EventArgs) Handles btnExercise1.Click

        'Exercise 1: Output each item in a separate message box one after another

        Dim aiData(4) As Integer 'Initialize the array of integers


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer  'initialize a counter (i)

        'use a for loop to count the items and display them in a message box
        For i = 0 To 4
            MsgBox(aiData(i))
        Next


    End Sub

    Private Sub btnExercise2_Click(sender As Object, e As EventArgs) Handles btnExercise2.Click

        'Exercise 2: Output all  of the items in the same message box on separate lines

        Dim aiData(4) As Integer 'Initialize the array of integers


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer  'initialize a counter (i)
        Dim stOut As String 'string to outp the items

        'use a for loop to count the items and display them in a message box
        For i = 0 To 4
            stOut = stOut & aiData(i) & vbNewLine
        Next

        MsgBox(stOut) 'show output
    End Sub

    Private Sub btnExercise3_Click(sender As Object, e As EventArgs) Handles btnExercise3.Click

        'Exercise 3: Add up all the items then output the total in a message box

        Dim aiData(4) As Integer 'Initialize the array of integers


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer  'initialize a counter (i)
        Dim iTotal As Integer

        'use a for loop to count the items, add all of them and display them in a message box
        For i = 0 To 4
            iTotal = iTotal + aiData(i)
        Next

        MsgBox("The total is " & iTotal)   'show output of the total

    End Sub

    Private Sub btnExercise4_Click(sender As Object, e As EventArgs) Handles btnExercise4.Click

        'Exercise 4: Calculate the average of the items then output it in a message box

        Dim aiData(4) As Integer 'Initialize the array of integers


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer  'initialize a counter (i)
        Dim iTotal As Integer 'intialize the total

        ' use the for loop to get a total of the items and calculate the average
        For i = 0 To 4
            iTotal = iTotal + aiData(i)
        Next

        MsgBox("The average is " & iTotal / 5) 'show output of the average
    End Sub

    Private Sub btnExercise5_Click(sender As Object, e As EventArgs) Handles btnExercise5.Click

        'Exercise 5: Add up the items greater than 20 then output the result in a message box

        Dim aiData(4) As Integer 'Initialize the array of integers


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer  'initialize a counter (i)
        Dim iTotal As Integer  'intialize the total

        ' use the for loop to count the items 
        For i = 0 To 4
            ' use if statement to check for items greater than 20 ,if there is any add them to a total
            If aiData(i) > 20 Then
                iTotal = iTotal + aiData(i)
            End If
        Next

        ' & -ampersand is a contatenator (adding the string and the integer to show output)

        MsgBox("The total of the items bigger than 20 is " & iTotal)
    End Sub

    Private Sub btnExercise6_Click(sender As Object, e As EventArgs) Handles btnExercise6.Click
        'Exercise 6: find the largest item then output it in a message box

        Dim aiData(4) As Integer 'Initialize the array of integers


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer  'initialize a counter (i)
        Dim iMax As Integer  'initialize iMax , which will hold the largest number

        iMax = 0 ' initaliaze iMax as zero , assuming working positive items 

        'use for loop to count for items and check which item is larger than the next item in the array
        For i = 0 To 4
            If aiData(i) > iMax Then
                iMax = aiData(i)
            End If
        Next

        MsgBox("The largest item is " & iMax)
    End Sub

    Private Sub btnExercise7_Click(sender As Object, e As EventArgs) Handles btnExercise7.Click
        'Exercise 7: find the smallest item then output it in a message box

        Dim aiData(4) As Integer 'Initialize the array of integers


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer  'initialize a counter (i)
        Dim iMin As Integer  'initialize iMin , which will hold the smallest number

        iMin = 10000 ' initaliaze iMin as 10 000 , assuming a large number  is bigger than any item in the array

        'use for loop to count for items and check which item is smallest than the next item in the array
        For i = 0 To 4
            If aiData(i) < iMin Then
                iMin = aiData(i)
            End If
        Next

        MsgBox("The smallest item is " & iMin)
    End Sub

    Private Sub btnExercise8_Click(sender As Object, e As EventArgs) Handles btnExercise8.Click

        'Exercise 8: Replace each item in the array with a new value which is twice as big then output the new values

        Dim aiData(4) As Integer 'Initialize the array of integers


        aiData(0) = 5
        aiData(1) = 7
        aiData(2) = 33
        aiData(3) = 22
        aiData(4) = 8

        Dim i As Integer  'initialize a counter (i)
        ' use the for loop to count each item and multiply it by 2
        For i = 0 To 4
            aiData(i) = aiData(i) * 2
        Next

        Dim stOut As String 'initialize stOut to output new values of the items

        For i = 0 To 4
            stOut = stOut & aiData(i) & vbNewLine

        Next

        MsgBox(stOut)

    End Sub
End Class
