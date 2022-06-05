Public Class CTF
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
        If yes1.CheckState = CheckState.Checked Then
            form.WriteLine("Have you been outside of the country lately?: YES")
        Else
            form.WriteLine("Have you been outside of the country lately?: NO")
        End If

        If yes2.CheckState = CheckState.Checked Then
            form.WriteLine("Have you been in contact with a person with COVID-19 lately?: YES")
        Else
            form.WriteLine("Have you been in contact with a person with COVID-19 lately?: NO")
        End If

        If yes3.CheckState = CheckState.Checked Then
            form.WriteLine("Are you feeling any sickness for the past few days?: YES")
        Else
            form.WriteLine("Are you feeling any sickness for the past few days?: NO")
        End If

        If yes4.CheckState = CheckState.Checked Then
            form.WriteLine("Are you vaccinated?: YES")
        Else
            form.WriteLine("Are you vaccinated?: NO")
        End If

        If yes5.CheckState = CheckState.Checked Then
            form.WriteLine("Have you been Diagnosed with COVID-19?: YES")
        Else
            form.WriteLine("Have you been Diagnosed with COVID-19?: NO")
        End If

        form.WriteLine("__________________________________________________________________________")
        form.WriteLine("")

        MessageBox.Show("Contact Tracing Form Submitted!")

        form.Close()
    End Sub

    Private Sub time(sender As Object, e As EventArgs) Handles tickticktime.Tick

        Timer.Text = DateTime.Now.ToLongTimeString()

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        nametxt.Clear()
        hometxt.Clear()
        emailtxt.Clear()
        numtxt.Clear()

        yes1.Checked = False
        yes2.Checked = False
        yes3.Checked = False
        yes4.Checked = False
        yes5.Checked = False

        no1.Checked = False
        no2.Checked = False
        no3.Checked = False
        no4.Checked = False
        no5.Checked = False
    End Sub
End Class
