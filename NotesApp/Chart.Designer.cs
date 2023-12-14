
namespace AdminTools
{
    partial class Chart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bunifuChartCanvas1 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.bunifuChartCanvas2 = new Bunifu.Charts.WinForms.BunifuChartCanvas();
            this.bunifuBubbleChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuBubbleChart(this.components);
            this.bunifuLineChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(106, 13);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bunifuChartCanvas1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bunifuChartCanvas2);
            this.splitContainer1.Size = new System.Drawing.Size(640, 425);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // bunifuChartCanvas1
            // 
            this.bunifuChartCanvas1.AnimationDuration = 1000;
            this.bunifuChartCanvas1.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.bunifuChartCanvas1.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuChartCanvas1.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas1.Labels = null;
            this.bunifuChartCanvas1.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas1.LegendDisplay = true;
            this.bunifuChartCanvas1.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas1.LegendForeColor = System.Drawing.Color.DarkGray;
            this.bunifuChartCanvas1.LegendFullWidth = true;
            this.bunifuChartCanvas1.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.LegendRevese = false;
            this.bunifuChartCanvas1.LegendRTL = false;
            this.bunifuChartCanvas1.Location = new System.Drawing.Point(0, 0);
            this.bunifuChartCanvas1.Name = "bunifuChartCanvas1";
            this.bunifuChartCanvas1.ShowXAxis = true;
            this.bunifuChartCanvas1.ShowYAxis = true;
            this.bunifuChartCanvas1.Size = new System.Drawing.Size(640, 209);
            this.bunifuChartCanvas1.TabIndex = 0;
            this.bunifuChartCanvas1.Title = "";
            this.bunifuChartCanvas1.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas1.TitlePadding = 10;
            this.bunifuChartCanvas1.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas1.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas1.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas1.TooltipsEnabled = true;
            this.bunifuChartCanvas1.XAxesBeginAtZero = true;
            this.bunifuChartCanvas1.XAxesDrawTicks = true;
            this.bunifuChartCanvas1.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesGridLines = true;
            this.bunifuChartCanvas1.XAxesLabel = "";
            this.bunifuChartCanvas1.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.XAxesLineWidth = 1;
            this.bunifuChartCanvas1.XAxesStacked = false;
            this.bunifuChartCanvas1.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas1.YAxesBeginAtZero = true;
            this.bunifuChartCanvas1.YAxesDrawTicks = true;
            this.bunifuChartCanvas1.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesGridLines = true;
            this.bunifuChartCanvas1.YAxesLabel = "";
            this.bunifuChartCanvas1.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas1.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas1.YAxesLineWidth = 1;
            this.bunifuChartCanvas1.YAxesStacked = false;
            this.bunifuChartCanvas1.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas1.YAxesZeroLineWidth = 1;
            // 
            // bunifuChartCanvas2
            // 
            this.bunifuChartCanvas2.AnimationDuration = 1000;
            this.bunifuChartCanvas2.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
            this.bunifuChartCanvas2.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuChartCanvas2.CanvasPadding = new System.Windows.Forms.Padding(0);
            this.bunifuChartCanvas2.Labels = null;
            this.bunifuChartCanvas2.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
            this.bunifuChartCanvas2.LegendDisplay = true;
            this.bunifuChartCanvas2.LegendFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuChartCanvas2.LegendForeColor = System.Drawing.Color.DarkGray;
            this.bunifuChartCanvas2.LegendFullWidth = true;
            this.bunifuChartCanvas2.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas2.LegendRevese = false;
            this.bunifuChartCanvas2.LegendRTL = false;
            this.bunifuChartCanvas2.Location = new System.Drawing.Point(33, 3);
            this.bunifuChartCanvas2.Name = "bunifuChartCanvas2";
            this.bunifuChartCanvas2.ShowXAxis = true;
            this.bunifuChartCanvas2.ShowYAxis = true;
            this.bunifuChartCanvas2.Size = new System.Drawing.Size(569, 194);
            this.bunifuChartCanvas2.TabIndex = 0;
            this.bunifuChartCanvas2.Title = "";
            this.bunifuChartCanvas2.TitleLineHeight = 1.2D;
            this.bunifuChartCanvas2.TitlePadding = 10;
            this.bunifuChartCanvas2.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
            this.bunifuChartCanvas2.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.TooltipFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuChartCanvas2.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
            this.bunifuChartCanvas2.TooltipsEnabled = true;
            this.bunifuChartCanvas2.XAxesBeginAtZero = true;
            this.bunifuChartCanvas2.XAxesDrawTicks = true;
            this.bunifuChartCanvas2.XAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.XAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas2.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.XAxesGridLines = true;
            this.bunifuChartCanvas2.XAxesLabel = "";
            this.bunifuChartCanvas2.XAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.XAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas2.XAxesLineWidth = 1;
            this.bunifuChartCanvas2.XAxesStacked = false;
            this.bunifuChartCanvas2.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.XAxesZeroLineWidth = 1;
            this.bunifuChartCanvas2.YAxesBeginAtZero = true;
            this.bunifuChartCanvas2.YAxesDrawTicks = true;
            this.bunifuChartCanvas2.YAxesFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.YAxesForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas2.YAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.YAxesGridLines = true;
            this.bunifuChartCanvas2.YAxesLabel = "";
            this.bunifuChartCanvas2.YAxesLabelFont = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.bunifuChartCanvas2.YAxesLabelForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuChartCanvas2.YAxesLineWidth = 1;
            this.bunifuChartCanvas2.YAxesStacked = false;
            this.bunifuChartCanvas2.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bunifuChartCanvas2.YAxesZeroLineWidth = 1;
            // 
            // bunifuBubbleChart1
            // 
            this.bunifuBubbleChart1.BackgroundColor = System.Drawing.Color.Purple;
            this.bunifuBubbleChart1.BorderColor = System.Drawing.Color.Empty;
            this.bunifuBubbleChart1.BorderWidth = 0;
            this.bunifuBubbleChart1.Data = null;
            this.bunifuBubbleChart1.HitRadius = 1;
            this.bunifuBubbleChart1.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuBubbleChart1.HoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuBubbleChart1.HoverBorderWidth = 0;
            this.bunifuBubbleChart1.HoverRadius = 4;
            this.bunifuBubbleChart1.Label = "Label here";
            this.bunifuBubbleChart1.Order = 0;
            this.bunifuBubbleChart1.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuBubbleChart.PointStyles.Circle;
            this.bunifuBubbleChart1.Radius = 3;
            this.bunifuBubbleChart1.Rotation = 0;
            this.bunifuBubbleChart1.TargetCanvas = this.bunifuChartCanvas1;
            // 
            // bunifuLineChart1
            // 
            this.bunifuLineChart1.BackgroundColor = System.Drawing.Color.Indigo;
            this.bunifuLineChart1.BorderCapStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.LineCaps.Butt;
            this.bunifuLineChart1.BorderColor = System.Drawing.Color.Purple;
            this.bunifuLineChart1.BorderDash = null;
            this.bunifuLineChart1.BorderDashOffset = 0D;
            this.bunifuLineChart1.BorderJoin = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.BorderJoinStyles.Miter;
            this.bunifuLineChart1.BorderWidth = 3;
            this.bunifuLineChart1.CubicInterpolationMode = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.CubicInterpolationModes.Default;
            this.bunifuLineChart1.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuLineChart1.Data")));
            this.bunifuLineChart1.Fill = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.FillOptions.Blank;
            this.bunifuLineChart1.Label = "Line Chart";
            this.bunifuLineChart1.LineTension = 0.4D;
            this.bunifuLineChart1.Order = 0;
            this.bunifuLineChart1.PointBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointBorderColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointBorderWidth = 1;
            this.bunifuLineChart1.PointHitRadius = 1;
            this.bunifuLineChart1.PointHoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointHoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuLineChart1.PointHoverBorderWidth = 4;
            this.bunifuLineChart1.PointHoverRadius = 1;
            this.bunifuLineChart1.PointRadius = 3;
            this.bunifuLineChart1.PointRotation = 0;
            this.bunifuLineChart1.PointStyle = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.PointStyles.Circle;
            this.bunifuLineChart1.ShowLine = true;
            this.bunifuLineChart1.SpanGaps = false;
            this.bunifuLineChart1.SteppedLine = Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart.SteppedLineStyles.False;
            this.bunifuLineChart1.TargetCanvas = this.bunifuChartCanvas2;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Chart";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Chart_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas1;
        private Bunifu.Charts.WinForms.BunifuChartCanvas bunifuChartCanvas2;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBubbleChart bunifuBubbleChart1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuLineChart bunifuLineChart1;
    }
}