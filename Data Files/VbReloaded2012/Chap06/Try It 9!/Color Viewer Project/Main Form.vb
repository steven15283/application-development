﻿' Project name:         Color Viewer Project
' Project purpose:      Change the fill color of a shape
'                       from blue to yellow and then to red
' Created/revised by:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class MainForm

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Me.Close()
    End Sub

    Private Sub viewButton_Click(sender As Object, e As EventArgs) Handles viewButton.Click
        ' changes the fill color of the colorOvalShape

        ' disable the View Colors button
        viewButton.Enabled = False

        ' change the color
        colorOvalShape.FillColor = Color.Blue
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)

        colorOvalShape.FillColor = Color.Yellow
        Me.Refresh()
        System.Threading.Thread.Sleep(1000)

        colorOvalShape.FillColor = Color.Red

        ' enable the View Colors button
        viewButton.Enabled = True
    End Sub
End Class
