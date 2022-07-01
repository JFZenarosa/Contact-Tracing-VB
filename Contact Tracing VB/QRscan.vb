Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Imports ZXing.Aztec
Public Class QRscan
    Dim scanner As VideoCaptureDevice
    Dim img As Bitmap
    Private Sub QRread_Click(sender As Object, e As EventArgs) Handles QRread.Click
        Dim qrScan As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If qrScan.ShowDialog() = DialogResult.OK Then
            scanner = qrScan.VideoDevice
            AddHandler scanner.NewFrame, New NewFrameEventHandler(AddressOf QRreader)
            scanner.Start()
            QRtimer.Start()
        End If
    End Sub

    Private Sub QRreader(sender As Object, eventArgs As NewFrameEventArgs)
        img = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        pictureBox.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub QRtimer_Tick(sender As Object, e As EventArgs) Handles QRtimer.Tick
        If pictureBox.Image IsNot Nothing Then
            Dim QRscanner As BarcodeReader = New BarcodeReader
            Dim qrInputs As Result = QRscanner.Decode(DirectCast(pictureBox.Image, Bitmap))
            If qrInputs IsNot Nothing Then
                Dim ctForm As New CTF
                ctForm.getOutput = qrInputs.ToString()
                ctForm.Show()
                Me.Hide()
            End If
        End If

    End Sub
End Class