namespace Assignment3
{
    partial class mainForm
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
            this.flushesGb = new System.Windows.Forms.GroupBox();
            this.transmissionCb = new System.Windows.Forms.CheckBox();
            this.radiatorCb = new System.Windows.Forms.CheckBox();
            this.oilGb = new System.Windows.Forms.GroupBox();
            this.lubeCb = new System.Windows.Forms.CheckBox();
            this.oilCb = new System.Windows.Forms.CheckBox();
            this.miscGb = new System.Windows.Forms.GroupBox();
            this.tiresLb = new System.Windows.Forms.ListBox();
            this.clearMiscBt = new System.Windows.Forms.Button();
            this.miscLb = new System.Windows.Forms.ListBox();
            this.partsGb = new System.Windows.Forms.GroupBox();
            this.msgparts2Lb = new System.Windows.Forms.Label();
            this.msgparts1Lb = new System.Windows.Forms.Label();
            this.hoursLb = new System.Windows.Forms.Label();
            this.hoursTb = new System.Windows.Forms.TextBox();
            this.partsLb = new System.Windows.Forms.Label();
            this.partsTb = new System.Windows.Forms.TextBox();
            this.summaryGb = new System.Windows.Forms.GroupBox();
            this.laborSumLb = new System.Windows.Forms.Label();
            this.laborSumTb = new System.Windows.Forms.TextBox();
            this.pstLb = new System.Windows.Forms.Label();
            this.gstLb = new System.Windows.Forms.Label();
            this.totalFeesLb = new System.Windows.Forms.Label();
            this.totalFeesTb = new System.Windows.Forms.TextBox();
            this.pstTb = new System.Windows.Forms.TextBox();
            this.taxSumLb = new System.Windows.Forms.Label();
            this.gstTb = new System.Windows.Forms.TextBox();
            this.PartsSumLb = new System.Windows.Forms.Label();
            this.partsSumTb = new System.Windows.Forms.TextBox();
            this.serviceSumLb = new System.Windows.Forms.Label();
            this.serviceSumTb = new System.Windows.Forms.TextBox();
            this.calcBt = new System.Windows.Forms.Button();
            this.clearBt = new System.Windows.Forms.Button();
            this.exitBt = new System.Windows.Forms.Button();
            this.flushesGb.SuspendLayout();
            this.oilGb.SuspendLayout();
            this.miscGb.SuspendLayout();
            this.partsGb.SuspendLayout();
            this.summaryGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // flushesGb
            // 
            this.flushesGb.Controls.Add(this.transmissionCb);
            this.flushesGb.Controls.Add(this.radiatorCb);
            this.flushesGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flushesGb.Location = new System.Drawing.Point(38, 33);
            this.flushesGb.Name = "flushesGb";
            this.flushesGb.Size = new System.Drawing.Size(379, 110);
            this.flushesGb.TabIndex = 0;
            this.flushesGb.TabStop = false;
            this.flushesGb.Text = "Flushes";
            // 
            // transmissionCb
            // 
            this.transmissionCb.AutoSize = true;
            this.transmissionCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transmissionCb.Location = new System.Drawing.Point(27, 60);
            this.transmissionCb.Name = "transmissionCb";
            this.transmissionCb.Size = new System.Drawing.Size(234, 24);
            this.transmissionCb.TabIndex = 1;
            this.transmissionCb.Text = "Transmission Flush ($80.00)";
            this.transmissionCb.UseVisualStyleBackColor = true;
            // 
            // radiatorCb
            // 
            this.radiatorCb.AutoSize = true;
            this.radiatorCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiatorCb.Location = new System.Drawing.Point(27, 26);
            this.radiatorCb.Name = "radiatorCb";
            this.radiatorCb.Size = new System.Drawing.Size(202, 24);
            this.radiatorCb.TabIndex = 0;
            this.radiatorCb.Text = "Radiator Flush ($30.00)";
            this.radiatorCb.UseVisualStyleBackColor = true;
            // 
            // oilGb
            // 
            this.oilGb.Controls.Add(this.lubeCb);
            this.oilGb.Controls.Add(this.oilCb);
            this.oilGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilGb.Location = new System.Drawing.Point(524, 33);
            this.oilGb.Name = "oilGb";
            this.oilGb.Size = new System.Drawing.Size(379, 110);
            this.oilGb.TabIndex = 1;
            this.oilGb.TabStop = false;
            this.oilGb.Text = "Oil and Lube";
            // 
            // lubeCb
            // 
            this.lubeCb.AutoSize = true;
            this.lubeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lubeCb.Location = new System.Drawing.Point(42, 60);
            this.lubeCb.Name = "lubeCb";
            this.lubeCb.Size = new System.Drawing.Size(159, 24);
            this.lubeCb.TabIndex = 3;
            this.lubeCb.Text = "Lube job ($19.50)";
            this.lubeCb.UseVisualStyleBackColor = true;
            // 
            // oilCb
            // 
            this.oilCb.AutoSize = true;
            this.oilCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oilCb.Location = new System.Drawing.Point(42, 26);
            this.oilCb.Name = "oilCb";
            this.oilCb.Size = new System.Drawing.Size(176, 24);
            this.oilCb.TabIndex = 2;
            this.oilCb.Text = "Oil Change ($28.50)";
            this.oilCb.UseVisualStyleBackColor = true;
            // 
            // miscGb
            // 
            this.miscGb.Controls.Add(this.tiresLb);
            this.miscGb.Controls.Add(this.clearMiscBt);
            this.miscGb.Controls.Add(this.miscLb);
            this.miscGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscGb.Location = new System.Drawing.Point(38, 163);
            this.miscGb.Name = "miscGb";
            this.miscGb.Size = new System.Drawing.Size(383, 268);
            this.miscGb.TabIndex = 1;
            this.miscGb.TabStop = false;
            this.miscGb.Text = "Misc";
            // 
            // tiresLb
            // 
            this.tiresLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiresLb.FormattingEnabled = true;
            this.tiresLb.ItemHeight = 20;
            this.tiresLb.Location = new System.Drawing.Point(27, 138);
            this.tiresLb.Name = "tiresLb";
            this.tiresLb.Size = new System.Drawing.Size(168, 104);
            this.tiresLb.TabIndex = 8;
            // 
            // clearMiscBt
            // 
            this.clearMiscBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearMiscBt.Location = new System.Drawing.Point(235, 150);
            this.clearMiscBt.Name = "clearMiscBt";
            this.clearMiscBt.Size = new System.Drawing.Size(116, 58);
            this.clearMiscBt.TabIndex = 7;
            this.clearMiscBt.Text = "Clear Misc";
            this.clearMiscBt.UseVisualStyleBackColor = true;
            this.clearMiscBt.Click += new System.EventHandler(this.clearMiscBt_Click);
            // 
            // miscLb
            // 
            this.miscLb.BackColor = System.Drawing.Color.Yellow;
            this.miscLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscLb.FormattingEnabled = true;
            this.miscLb.ItemHeight = 20;
            this.miscLb.Items.AddRange(new object[] {
            "Inspection ($15.00)",
            "Replace Muffler ($90.50)",
            "Tire Rotation ($28.90)",
            "Purchase New Tires ($87.75 each)"});
            this.miscLb.Location = new System.Drawing.Point(27, 39);
            this.miscLb.Name = "miscLb";
            this.miscLb.Size = new System.Drawing.Size(324, 84);
            this.miscLb.TabIndex = 0;
            this.miscLb.SelectedIndexChanged += new System.EventHandler(this.miscLb_SelectedIndexChanged);
            // 
            // partsGb
            // 
            this.partsGb.Controls.Add(this.msgparts2Lb);
            this.partsGb.Controls.Add(this.msgparts1Lb);
            this.partsGb.Controls.Add(this.hoursLb);
            this.partsGb.Controls.Add(this.hoursTb);
            this.partsGb.Controls.Add(this.partsLb);
            this.partsGb.Controls.Add(this.partsTb);
            this.partsGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsGb.Location = new System.Drawing.Point(524, 163);
            this.partsGb.Name = "partsGb";
            this.partsGb.Size = new System.Drawing.Size(379, 268);
            this.partsGb.TabIndex = 2;
            this.partsGb.TabStop = false;
            this.partsGb.Text = "Parts and Labor ($21.80)";
            // 
            // msgparts2Lb
            // 
            this.msgparts2Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgparts2Lb.ForeColor = System.Drawing.Color.Red;
            this.msgparts2Lb.Location = new System.Drawing.Point(72, 197);
            this.msgparts2Lb.Name = "msgparts2Lb";
            this.msgparts2Lb.Size = new System.Drawing.Size(265, 68);
            this.msgparts2Lb.TabIndex = 5;
            // 
            // msgparts1Lb
            // 
            this.msgparts1Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgparts1Lb.ForeColor = System.Drawing.Color.Red;
            this.msgparts1Lb.Location = new System.Drawing.Point(72, 123);
            this.msgparts1Lb.Name = "msgparts1Lb";
            this.msgparts1Lb.Size = new System.Drawing.Size(265, 74);
            this.msgparts1Lb.TabIndex = 4;
            // 
            // hoursLb
            // 
            this.hoursLb.AutoSize = true;
            this.hoursLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursLb.Location = new System.Drawing.Point(58, 85);
            this.hoursLb.Name = "hoursLb";
            this.hoursLb.Size = new System.Drawing.Size(141, 20);
            this.hoursLb.TabIndex = 3;
            this.hoursLb.Text = "Labor (hrs worked)";
            // 
            // hoursTb
            // 
            this.hoursTb.BackColor = System.Drawing.Color.Yellow;
            this.hoursTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursTb.Location = new System.Drawing.Point(215, 82);
            this.hoursTb.Name = "hoursTb";
            this.hoursTb.Size = new System.Drawing.Size(122, 26);
            this.hoursTb.TabIndex = 2;
            // 
            // partsLb
            // 
            this.partsLb.AutoSize = true;
            this.partsLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLb.Location = new System.Drawing.Point(132, 53);
            this.partsLb.Name = "partsLb";
            this.partsLb.Size = new System.Drawing.Size(69, 20);
            this.partsLb.TabIndex = 1;
            this.partsLb.Text = "Parts ($)";
            // 
            // partsTb
            // 
            this.partsTb.BackColor = System.Drawing.Color.Yellow;
            this.partsTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsTb.Location = new System.Drawing.Point(215, 50);
            this.partsTb.Name = "partsTb";
            this.partsTb.Size = new System.Drawing.Size(122, 26);
            this.partsTb.TabIndex = 0;
            // 
            // summaryGb
            // 
            this.summaryGb.Controls.Add(this.laborSumLb);
            this.summaryGb.Controls.Add(this.laborSumTb);
            this.summaryGb.Controls.Add(this.pstLb);
            this.summaryGb.Controls.Add(this.gstLb);
            this.summaryGb.Controls.Add(this.totalFeesLb);
            this.summaryGb.Controls.Add(this.totalFeesTb);
            this.summaryGb.Controls.Add(this.pstTb);
            this.summaryGb.Controls.Add(this.taxSumLb);
            this.summaryGb.Controls.Add(this.gstTb);
            this.summaryGb.Controls.Add(this.PartsSumLb);
            this.summaryGb.Controls.Add(this.partsSumTb);
            this.summaryGb.Controls.Add(this.serviceSumLb);
            this.summaryGb.Controls.Add(this.serviceSumTb);
            this.summaryGb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summaryGb.Location = new System.Drawing.Point(38, 453);
            this.summaryGb.Name = "summaryGb";
            this.summaryGb.Size = new System.Drawing.Size(699, 229);
            this.summaryGb.TabIndex = 3;
            this.summaryGb.TabStop = false;
            this.summaryGb.Text = "Summary";
            // 
            // laborSumLb
            // 
            this.laborSumLb.AutoSize = true;
            this.laborSumLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborSumLb.Location = new System.Drawing.Point(403, 35);
            this.laborSumLb.Name = "laborSumLb";
            this.laborSumLb.Size = new System.Drawing.Size(50, 20);
            this.laborSumLb.TabIndex = 19;
            this.laborSumLb.Text = "Labor";
            // 
            // laborSumTb
            // 
            this.laborSumTb.BackColor = System.Drawing.SystemColors.Control;
            this.laborSumTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laborSumTb.Location = new System.Drawing.Point(486, 32);
            this.laborSumTb.Name = "laborSumTb";
            this.laborSumTb.Size = new System.Drawing.Size(122, 26);
            this.laborSumTb.TabIndex = 18;
            // 
            // pstLb
            // 
            this.pstLb.AutoSize = true;
            this.pstLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pstLb.Location = new System.Drawing.Point(344, 151);
            this.pstLb.Name = "pstLb";
            this.pstLb.Size = new System.Drawing.Size(39, 20);
            this.pstLb.TabIndex = 17;
            this.pstLb.Text = "PST";
            // 
            // gstLb
            // 
            this.gstLb.AutoSize = true;
            this.gstLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstLb.Location = new System.Drawing.Point(342, 113);
            this.gstLb.Name = "gstLb";
            this.gstLb.Size = new System.Drawing.Size(42, 20);
            this.gstLb.TabIndex = 16;
            this.gstLb.Text = "GST";
            // 
            // totalFeesLb
            // 
            this.totalFeesLb.AutoSize = true;
            this.totalFeesLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFeesLb.Location = new System.Drawing.Point(113, 186);
            this.totalFeesLb.Name = "totalFeesLb";
            this.totalFeesLb.Size = new System.Drawing.Size(84, 20);
            this.totalFeesLb.TabIndex = 15;
            this.totalFeesLb.Text = "Total Fees";
            // 
            // totalFeesTb
            // 
            this.totalFeesTb.BackColor = System.Drawing.SystemColors.Control;
            this.totalFeesTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFeesTb.Location = new System.Drawing.Point(209, 183);
            this.totalFeesTb.Name = "totalFeesTb";
            this.totalFeesTb.Size = new System.Drawing.Size(170, 26);
            this.totalFeesTb.TabIndex = 14;
            // 
            // pstTb
            // 
            this.pstTb.BackColor = System.Drawing.SystemColors.Control;
            this.pstTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pstTb.Location = new System.Drawing.Point(209, 148);
            this.pstTb.Name = "pstTb";
            this.pstTb.Size = new System.Drawing.Size(122, 26);
            this.pstTb.TabIndex = 12;
            // 
            // taxSumLb
            // 
            this.taxSumLb.AutoSize = true;
            this.taxSumLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxSumLb.Location = new System.Drawing.Point(41, 112);
            this.taxSumLb.Name = "taxSumLb";
            this.taxSumLb.Size = new System.Drawing.Size(153, 20);
            this.taxSumLb.TabIndex = 11;
            this.taxSumLb.Text = "Tax (on parts ONLY)";
            // 
            // gstTb
            // 
            this.gstTb.BackColor = System.Drawing.SystemColors.Control;
            this.gstTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gstTb.Location = new System.Drawing.Point(209, 109);
            this.gstTb.Name = "gstTb";
            this.gstTb.Size = new System.Drawing.Size(122, 26);
            this.gstTb.TabIndex = 10;
            // 
            // PartsSumLb
            // 
            this.PartsSumLb.AutoSize = true;
            this.PartsSumLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsSumLb.Location = new System.Drawing.Point(126, 75);
            this.PartsSumLb.Name = "PartsSumLb";
            this.PartsSumLb.Size = new System.Drawing.Size(46, 20);
            this.PartsSumLb.TabIndex = 9;
            this.PartsSumLb.Text = "Parts";
            // 
            // partsSumTb
            // 
            this.partsSumTb.BackColor = System.Drawing.SystemColors.Control;
            this.partsSumTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSumTb.Location = new System.Drawing.Point(209, 72);
            this.partsSumTb.Name = "partsSumTb";
            this.partsSumTb.Size = new System.Drawing.Size(122, 26);
            this.partsSumTb.TabIndex = 8;
            // 
            // serviceSumLb
            // 
            this.serviceSumLb.AutoSize = true;
            this.serviceSumLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceSumLb.Location = new System.Drawing.Point(60, 38);
            this.serviceSumLb.Name = "serviceSumLb";
            this.serviceSumLb.Size = new System.Drawing.Size(137, 20);
            this.serviceSumLb.TabIndex = 7;
            this.serviceSumLb.Text = "Service and Labor";
            // 
            // serviceSumTb
            // 
            this.serviceSumTb.BackColor = System.Drawing.SystemColors.Control;
            this.serviceSumTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceSumTb.Location = new System.Drawing.Point(209, 35);
            this.serviceSumTb.Name = "serviceSumTb";
            this.serviceSumTb.Size = new System.Drawing.Size(122, 26);
            this.serviceSumTb.TabIndex = 6;
            // 
            // calcBt
            // 
            this.calcBt.Location = new System.Drawing.Point(119, 716);
            this.calcBt.Name = "calcBt";
            this.calcBt.Size = new System.Drawing.Size(150, 58);
            this.calcBt.TabIndex = 4;
            this.calcBt.Text = "Calculate";
            this.calcBt.UseVisualStyleBackColor = true;
            this.calcBt.Click += new System.EventHandler(this.calcBt_Click);
            // 
            // clearBt
            // 
            this.clearBt.Location = new System.Drawing.Point(389, 716);
            this.clearBt.Name = "clearBt";
            this.clearBt.Size = new System.Drawing.Size(150, 58);
            this.clearBt.TabIndex = 5;
            this.clearBt.Text = "Clear";
            this.clearBt.UseVisualStyleBackColor = true;
            this.clearBt.Click += new System.EventHandler(this.clearBt_Click);
            // 
            // exitBt
            // 
            this.exitBt.Location = new System.Drawing.Point(639, 716);
            this.exitBt.Name = "exitBt";
            this.exitBt.Size = new System.Drawing.Size(150, 58);
            this.exitBt.TabIndex = 6;
            this.exitBt.Text = "Exit";
            this.exitBt.UseVisualStyleBackColor = true;
            this.exitBt.Click += new System.EventHandler(this.exitBt_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 784);
            this.Controls.Add(this.exitBt);
            this.Controls.Add(this.clearBt);
            this.Controls.Add(this.calcBt);
            this.Controls.Add(this.summaryGb);
            this.Controls.Add(this.partsGb);
            this.Controls.Add(this.miscGb);
            this.Controls.Add(this.oilGb);
            this.Controls.Add(this.flushesGb);
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Fernando Automotive";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.flushesGb.ResumeLayout(false);
            this.flushesGb.PerformLayout();
            this.oilGb.ResumeLayout(false);
            this.oilGb.PerformLayout();
            this.miscGb.ResumeLayout(false);
            this.partsGb.ResumeLayout(false);
            this.partsGb.PerformLayout();
            this.summaryGb.ResumeLayout(false);
            this.summaryGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox flushesGb;
        private System.Windows.Forms.GroupBox oilGb;
        private System.Windows.Forms.GroupBox miscGb;
        private System.Windows.Forms.GroupBox partsGb;
        private System.Windows.Forms.GroupBox summaryGb;
        private System.Windows.Forms.Button calcBt;
        private System.Windows.Forms.Button clearBt;
        private System.Windows.Forms.Button exitBt;
        private System.Windows.Forms.CheckBox transmissionCb;
        private System.Windows.Forms.CheckBox radiatorCb;
        private System.Windows.Forms.CheckBox lubeCb;
        private System.Windows.Forms.CheckBox oilCb;
        private System.Windows.Forms.ListBox miscLb;
        private System.Windows.Forms.Button clearMiscBt;
        private System.Windows.Forms.ListBox tiresLb;
        private System.Windows.Forms.TextBox partsTb;
        private System.Windows.Forms.Label hoursLb;
        private System.Windows.Forms.TextBox hoursTb;
        private System.Windows.Forms.Label partsLb;
        private System.Windows.Forms.Label msgparts2Lb;
        private System.Windows.Forms.Label msgparts1Lb;
        private System.Windows.Forms.Label totalFeesLb;
        private System.Windows.Forms.TextBox totalFeesTb;
        private System.Windows.Forms.TextBox pstTb;
        private System.Windows.Forms.Label taxSumLb;
        private System.Windows.Forms.TextBox gstTb;
        private System.Windows.Forms.Label PartsSumLb;
        private System.Windows.Forms.TextBox partsSumTb;
        private System.Windows.Forms.Label serviceSumLb;
        private System.Windows.Forms.TextBox serviceSumTb;
        private System.Windows.Forms.Label pstLb;
        private System.Windows.Forms.Label gstLb;
        private System.Windows.Forms.Label laborSumLb;
        private System.Windows.Forms.TextBox laborSumTb;
    }
}

