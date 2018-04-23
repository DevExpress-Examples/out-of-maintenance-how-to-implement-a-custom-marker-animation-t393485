Namespace CustomCircularSeriesAnimationSample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim radarDiagram1 As New DevExpress.XtraCharts.RadarDiagram()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(New Date(2001, 1, 1, 0, 0, 0, 0), New Object() { (DirectCast(6R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(New Date(2001, 2, 1, 0, 0, 0, 0), New Object() { (DirectCast(7R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(New Date(2001, 3, 1, 0, 0, 0, 0), New Object() { (DirectCast(10R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(New Date(2001, 4, 1, 0, 0, 0, 0), New Object() { (DirectCast(14R, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(New Date(2001, 5, 1, 0, 0, 0, 0), New Object() { (DirectCast(18R, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(New Date(2001, 6, 1, 0, 0, 0, 0), New Object() { (DirectCast(21R, Object))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(New Date(2001, 7, 1, 0, 0, 0, 0), New Object() { (DirectCast(22R, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(New Date(2001, 8, 1, 0, 0, 0, 0), New Object() { (DirectCast(22R, Object))})
            Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(New Date(2001, 9, 1, 0, 0, 0, 0), New Object() { (DirectCast(19R, Object))})
            Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(New Date(2001, 10, 1, 0, 0, 0, 0), New Object() { (DirectCast(15R, Object))})
            Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(New Date(2001, 11, 1, 0, 0, 0, 0), New Object() { (DirectCast(10R, Object))})
            Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(New Date(2001, 12, 1, 0, 0, 0, 0), New Object() { (DirectCast(7R, Object))})
            Dim radarLineSeriesView1 As New DevExpress.XtraCharts.RadarLineSeriesView()
            Dim circularSeriesZoomInAnimation1 As New DevExpress.XtraCharts.CircularSeriesZoomInAnimation()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(radarDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(radarLineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chartControl1.DataBindings = Nothing
            radarDiagram1.AxisX.Label.TextPattern = "{A:MMMM}"
            Me.chartControl1.Diagram = radarDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl1.Legend.Name = "Default Legend"
            Me.chartControl1.Location = New System.Drawing.Point(0, 0)
            Me.chartControl1.Name = "chartControl1"
            series1.LegendText = "Day (max)"
            series1.Name = "Day"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12})
            circularSeriesZoomInAnimation1.Enabled = False
            radarLineSeriesView1.SeriesAnimation = circularSeriesZoomInAnimation1
            series1.View = radarLineSeriesView1
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl1.Size = New System.Drawing.Size(624, 321)
            Me.chartControl1.TabIndex = 0
            chartTitle1.Text = "Average temperature in London"
            Me.chartControl1.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 321)
            Me.Controls.Add(Me.chartControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(radarDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(radarLineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

