﻿Imports HWLib.Objects
Imports HWLib.JSON

Public Class MainForm

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserInfoForm.Close()
        CourseForm.Close()
        LoadContent()
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim newType As TypeSelection = New TypeSelection(HWLib.Objects.Assignments.Action.AddNew)
        newType.ShowDialog()
    End Sub

    Private Sub btnExisting_Click(sender As Object, e As EventArgs) Handles btnExisting.Click
        Dim newType As TypeSelection = New TypeSelection(HWLib.Objects.Assignments.Action.AddExisting)
        newType.ShowDialog()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim newType As TypeSelection = New TypeSelection(HWLib.Objects.Assignments.Action.Delete)
        newType.ShowDialog()
    End Sub
    Sub LoadContent()
        lboClasses.Items.Clear()
        For Each classes As Course In CourseReader.courses
            Try
                lboClasses.Items.Add(classes.name)
            Catch ex As NullReferenceException
                ' The first item in courses.json is always null
                ' This prevents the application from reading it
            End Try
        Next
    End Sub
End Class