Public Class TileCalc
    Private Sub exitbtn_Click(sender As Object, e As EventArgs) Handles exitbtn.Click
        Me.Close()

        'this closes the program

    End Sub

    Private Sub calcualtebtn_Click(sender As Object, e As EventArgs) Handles calcualtebtn.Click
        Dim decTileL As Decimal
        Dim decTileW As Decimal
        Dim decPrice As Decimal
        Dim decPriceTotal As Decimal
        Dim decTileTotal As Decimal

        'my necessary variables are declared. For a tile business I imagine it utilizes decimals a lot so I use dec to assign decimal to my variables

        Decimal.TryParse(txtLength.Text, decTileL)
        Decimal.TryParse(txtWidth.Text, decTileW)
        Decimal.TryParse(txtPrice.Text, decPrice)
        'this assigns the text boxes to the appropriate variables I need for my equations


        decTileTotal = decTileL * decTileW
        decPriceTotal = decPrice * decTileTotal

        'these are the equations necessary to display the total area, and total price as a result of total area

        lblTPrice.Text = decPriceTotal.ToString("C2")
        lblTsqft.Text = decTileTotal & " sq. ft."

        'this is the code that converts the equation results to text and displays in the text boxes

        If decTileTotal <= 0 Or decPriceTotal <= 0 Then
            MsgBox("Error: Please Enter A Valid Number")
            txtLength.Text = String.Empty
            txtWidth.Text = String.Empty
            txtPrice.Text = String.Empty
            lblTPrice.Text = String.Empty
            lblTsqft.Text = String.Empty
        End If
        'This ensures that a proper number is entered for the tile length, width, and price boxes. It then clears all boxes to allow for essentially a "fresh start". 
        'If a non-numeric or invalid numerical number is entered then a message box will appear to tell the user to input a valid number.

    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        lblTsqft.Text = String.Empty
        lblTPrice.Text = String.Empty
        txtLength.Text = String.Empty
        txtWidth.Text = String.Empty
        txtPrice.Text = String.Empty

        'These will clear all number boxes when the "clear" button is clicked


    End Sub
End Class