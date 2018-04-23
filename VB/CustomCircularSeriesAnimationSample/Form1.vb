Imports DevExpress.XtraCharts
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace CustomCircularSeriesAnimationSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            Dim series As Series = chartControl1.Series("Day")
            If series Is Nothing Then
                Return
            End If
            Dim view As RadarLineSeriesView = TryCast(series.View, RadarLineSeriesView)
            If view Is Nothing Then
                Return
            End If

            view.SeriesPointAnimation = New CircularSlideFromLeftAnimation() With {.EasingFunction = New QuinticEasingFunction With {.EasingMode = EasingMode.Out}, .PointDelay = New TimeSpan(0, 0, 0, 0, 250), .Duration = New TimeSpan(0, 0, 3)}
        End Sub

        Private Overloads Sub OnDoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles chartControl1.DoubleClick
            chartControl1.Animate()
        End Sub
    End Class
End Namespace
