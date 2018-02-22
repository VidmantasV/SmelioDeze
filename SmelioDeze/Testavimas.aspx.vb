Imports Telerik.Web.UI.Calendar

Public Class Testavimas
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Private Sub RadCalendar1_DayRender(sender As Object, e As DayRenderEventArgs) Handles RadCalendar1.DayRender

        RadCalendar1.CalendarView.Title = "aaa"

    End Sub
End Class