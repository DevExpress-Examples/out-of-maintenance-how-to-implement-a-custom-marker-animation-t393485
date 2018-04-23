using DevExpress.XtraCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomCircularSeriesAnimationSample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            Series series = chartControl1.Series["Day"];
            if(series == null) return;
            RadarLineSeriesView view = series.View as RadarLineSeriesView;
            if(view == null) return;

            view.SeriesPointAnimation = new CircularSlideFromLeftAnimation() {
                EasingFunction = new QuinticEasingFunction { EasingMode = EasingMode.Out },
                PointDelay = new TimeSpan(0, 0, 0, 0, 250),
                Duration = new TimeSpan(0, 0, 3)
            };
        }

        private void OnDoubleClick(object sender, EventArgs e) {
            chartControl1.Animate();
        }
    }
}
