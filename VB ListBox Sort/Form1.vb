Public Class Form1

    'DECLARATIONS
    ReadOnly spacecrafts As String() = {"Kepler", "Casini", "Voyager", "New Horizon", "James Web", "Apollo 15", "Enterprise", "WMAP", "Spitzer", "Galileo"}
    Dim ascending As Boolean = True

    'WHEN FORM IS LOADED
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub

    'POPULATE
    Private Sub Populate()
        ListBox1.Items.Clear()
        For Each s In spacecrafts
            ListBox1.Items.Add(s)
        Next
    End Sub

    'SORT
    Private Sub Sort(ByVal asc As Boolean)
        If asc Then
            Array.Sort(spacecrafts)
        Else
            Array.Reverse(spacecrafts)
        End If

        'FILL SORTED
        Populate()
    End Sub

    'SORT BTN CLICKED
    Private Sub sortBtn_Click(sender As Object, e As EventArgs) Handles sortBtn.Click
        Sort(ascending)
        ascending = Not ascending
    End Sub

   
End Class
