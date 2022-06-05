Public Class Form1
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim form As System.IO.StreamWriter
        form = My.Computer.FileSystem.OpenTextFileWriter("C:\Example\Contact Tracing Form.txt", True)
        form.WriteLine("Mercury Drugs Contact Tracing Form")
        form.WriteLine("")
        form.WriteLine("Full Name: " + nametxt.Text)
        form.WriteLine("Home Address: " + hometxt.Text)
        form.WriteLine("Email Address: " + emailtxt.Text)
        form.WriteLine("Contact Number: " + numtxt.Text)
        form.WriteLine("Date: " + DateTimePicker1.Text)
        form.WriteLine("Time: " + DateTime.Now.ToString("h:mm:ss tt"))
        form.WriteLine("")
        form.WriteLine("COVID-19 Health Check")
        form.WriteLine("")
        form.Close()
    End Sub

    Private Sub time(sender As Object, e As EventArgs)

        timer.Text = DateTime.Now.ToLongTimeString()

    End Sub

End Class
