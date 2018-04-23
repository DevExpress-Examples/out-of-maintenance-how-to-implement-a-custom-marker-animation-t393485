Imports DevExpress.XtraCharts
Imports System.Drawing

Namespace CustomCircularSeriesAnimationSample
    Friend Class CircularSlideFromLeftAnimation
        Inherits CircularMarkerAnimationBase

        Public Overrides Sub ApplyState(ByVal modifier As SceneModifier, ByVal diagramBounds As RectangleF, ByVal markerParameters As MarkerSeriesPointLayoutParameters, ByVal progress As Single)
            modifier.Translate(-markerParameters.Bounds.Right * (1 - progress), 0)
        End Sub

        Protected Overrides Function CreateObjectForClone() As ChartElement
            Return New CircularSlideFromLeftAnimation()
        End Function
    End Class
End Namespace
