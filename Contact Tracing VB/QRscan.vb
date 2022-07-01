Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class QRscan
    Dim scanner As VideoCaptureDevice
    Dim img As Bitmap
    Private Sub QRread_Click(sender As Object, e As EventArgs) Handles QRread.Click
        Dim qrScan As VideoCaptureDeviceForm = New VideoCaptureDeviceForm

        If qrScan.ShowDialog() = DialogResult.OK Then
            scanner = qrScan.VideoDevice
            AddHandler scanner.NewFrame, New NewFrameEventHandler(AddressOf QRreader)
            scanner.Start()
        End If
    End Sub

    Private Sub QRreader(sender As Object, eventArgs As NewFrameEventArgs)
        img = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        pictureBox.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
End Class