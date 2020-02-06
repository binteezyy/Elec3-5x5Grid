Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Interval = 1000
        Timer.Start()
    End Sub

    Private Sub Timer_Tick(sender As Object, ea As EventArgs) Handles Timer.Tick
        Static ctr As Integer = 0
        Dim b As Button() = {
            Button1, Button2, Button3, Button4, Button5,
            Button6, Button7, Button8, Button9, Button10,
            Button11, Button12, Button13, Button14, Button15,
            Button16, Button17, Button18, Button19, Button20,
            Button21, Button22, Button23, Button24, Button25
        }

        Dim ctrl As Control = Me.GetNextControl(Me, True)
        If ctr = 0 Then
            ctr += 1
            Do Until ctrl Is Nothing
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = Color.Gray
                End If
                ctrl = Me.GetNextControl(ctrl, True)
            Loop

            For i As Byte = 1 To 3
                b(i).BackColor = Color.Red
            Next

            b(5).BackColor = Color.Red
            b(9).BackColor = Color.Red
            b(10).BackColor = Color.Red
            b(14).BackColor = Color.Red
            b(15).BackColor = Color.Red
            b(19).BackColor = Color.Red

            For i As Byte = 21 To 23
                b(i).BackColor = Color.Red
            Next

        ElseIf ctr = 1 Then
            ctr += 1
            Do Until ctrl Is Nothing
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = Color.Gray
                End If
                ctrl = Me.GetNextControl(ctrl, True)
            Loop
            b(2).BackColor = Color.Red
            b(7).BackColor = Color.Red
            b(12).BackColor = Color.Red
            b(17).BackColor = Color.Red
            b(22).BackColor = Color.Red

        ElseIf ctr = 2 Then
            ctr += 1
            Do Until ctrl Is Nothing
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = Color.Gray
                End If
                ctrl = Me.GetNextControl(ctrl, True)
            Loop

            For i As Byte = 0 To 4
                b(i).BackColor = Color.Red
            Next
            b(9).BackColor = Color.Red
            For i As Byte = 10 To 14
                b(i).BackColor = Color.Red
            Next
            b(15).BackColor = Color.Red
            For i As Byte = 20 To 24
                b(i).BackColor = Color.Red
            Next

        ElseIf ctr = 3 Then
            ctr += 1
            Do Until ctrl Is Nothing
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = Color.Gray
                End If
                ctrl = Me.GetNextControl(ctrl, True)
            Loop

            For i As Byte = 0 To 4
                b(i).BackColor = Color.Red
            Next
            b(9).BackColor = Color.Red
            For i As Byte = 11 To 14
                b(i).BackColor = Color.Red
            Next
            b(19).BackColor = Color.Red
            For i As Byte = 20 To 24
                b(i).BackColor = Color.Red
            Next

        ElseIf ctr = 4 Then
            ctr += 1
            Do Until ctrl Is Nothing
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = Color.Gray
                End If
                ctrl = Me.GetNextControl(ctrl, True)
            Loop

            b(0).BackColor = Color.Red
            b(4).BackColor = Color.Red
            b(5).BackColor = Color.Red
            b(9).BackColor = Color.Red
            For i As Byte = 10 To 14
                b(i).BackColor = Color.Red
            Next
            b(19).BackColor = Color.Red
            b(24).BackColor = Color.Red

        ElseIf ctr = 5 Then
            ctr += 1
            Do Until ctrl Is Nothing
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = Color.Gray
                End If
                ctrl = Me.GetNextControl(ctrl, True)
            Loop

            For i As Byte = 0 To 4
                b(i).BackColor = Color.Red
            Next
            b(5).BackColor = Color.Red
            For i As Byte = 10 To 14
                b(i).BackColor = Color.Red
            Next
            b(19).BackColor = Color.Red
            For i As Byte = 20 To 24
                b(i).BackColor = Color.Red
            Next

        ElseIf ctr = 6 Then
            ctr += 1
            Do Until ctrl Is Nothing
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = Color.Gray
                End If
                ctrl = Me.GetNextControl(ctrl, True)
            Loop

            For i As Byte = 0 To 4
                b(i).BackColor = Color.Red
            Next
            b(5).BackColor = Color.Red
            For i As Byte = 10 To 14
                b(i).BackColor = Color.Red
            Next
            b(15).BackColor = Color.Red
            b(19).BackColor = Color.Red
            For i As Byte = 20 To 24
                b(i).BackColor = Color.Red
            Next

        ElseIf ctr = 7 Then
            ctr += 1
            Do Until ctrl Is Nothing
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = Color.Gray
                End If
                ctrl = Me.GetNextControl(ctrl, True)
            Loop
            For i As Byte = 0 To 4
                b(i).BackColor = Color.Red
            Next
            b(9).BackColor = Color.Red
            b(13).BackColor = Color.Red
            b(17).BackColor = Color.Red
            b(21).BackColor = Color.Red

        ElseIf ctr = 8 Then
            ctr += 1
            Do Until ctrl Is Nothing
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = Color.Gray
                End If
                ctrl = Me.GetNextControl(ctrl, True)
            Loop

            For i As Byte = 1 To 3
                b(i).BackColor = Color.Red
            Next
            b(5).BackColor = Color.Red
            b(9).BackColor = Color.Red
            For i As Byte = 10 To 14
                b(i).BackColor = Color.Red
            Next
            b(15).BackColor = Color.Red
            b(19).BackColor = Color.Red
            For i As Byte = 21 To 23
                b(i).BackColor = Color.Red
            Next

        ElseIf ctr = 9 Then
            ctr = 0
            Do Until ctrl Is Nothing
                If TypeOf ctrl Is Button Then
                    ctrl.BackColor = Color.Gray
                End If
                ctrl = Me.GetNextControl(ctrl, True)
            Loop

            For i As Byte = 0 To 4
                b(i).BackColor = Color.Red
            Next
            b(0).BackColor = Color.Red
            b(4).BackColor = Color.Red
            b(5).BackColor = Color.Red
            b(9).BackColor = Color.Red
            For i As Byte = 10 To 14
                b(i).BackColor = Color.Red
            Next
            b(19).BackColor = Color.Red
            b(24).BackColor = Color.Red

        End If
    End Sub


End Class
