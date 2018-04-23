using DevExpress.XtraCharts;
using System.Drawing;

namespace CustomCircularSeriesAnimationSample {
    class CircularSlideFromLeftAnimation : CircularMarkerAnimationBase {
        public override void ApplyState(
                SceneModifier modifier,
                RectangleF diagramBounds,
                MarkerSeriesPointLayoutParameters markerParameters,
                float progress) {
            modifier.Translate(-markerParameters.Bounds.Right * (1 - progress), 0);
        }

        protected override ChartElement CreateObjectForClone() {
            return new CircularSlideFromLeftAnimation();
        }
    }
}
