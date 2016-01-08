namespace BuddhabrotDrawer
{
    partial class BuddhabrotUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.pointsCountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.sizePixelLabel = new System.Windows.Forms.Label();
            this.iterationLabel = new System.Windows.Forms.Label();
            this.sizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.goButton = new System.Windows.Forms.Button();
            this.iterationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.completionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsCountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(3, 3);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(638, 401);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanvas.TabIndex = 41;
            this.picCanvas.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.picCanvas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(644, 464);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pointsLabel);
            this.panel1.Controls.Add(this.pointsCountNumericUpDown);
            this.panel1.Controls.Add(this.sizePixelLabel);
            this.panel1.Controls.Add(this.iterationLabel);
            this.panel1.Controls.Add(this.sizeNumericUpDown);
            this.panel1.Controls.Add(this.goButton);
            this.panel1.Controls.Add(this.iterationNumericUpDown);
            this.panel1.Controls.Add(this.completionLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 410);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 51);
            this.panel1.TabIndex = 42;
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.Location = new System.Drawing.Point(165, 28);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(36, 13);
            this.pointsLabel.TabIndex = 7;
            this.pointsLabel.Text = "Points";
            // 
            // pointsCountNumericUpDown
            // 
            this.pointsCountNumericUpDown.Location = new System.Drawing.Point(207, 26);
            this.pointsCountNumericUpDown.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.pointsCountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pointsCountNumericUpDown.Name = "pointsCountNumericUpDown";
            this.pointsCountNumericUpDown.Size = new System.Drawing.Size(87, 20);
            this.pointsCountNumericUpDown.TabIndex = 6;
            this.pointsCountNumericUpDown.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // sizePixelLabel
            // 
            this.sizePixelLabel.AutoSize = true;
            this.sizePixelLabel.Location = new System.Drawing.Point(154, 0);
            this.sizePixelLabel.Name = "sizePixelLabel";
            this.sizePixelLabel.Size = new System.Drawing.Size(47, 13);
            this.sizePixelLabel.TabIndex = 5;
            this.sizePixelLabel.Text = "Size (px)";
            // 
            // iterationLabel
            // 
            this.iterationLabel.AutoSize = true;
            this.iterationLabel.Location = new System.Drawing.Point(6, 21);
            this.iterationLabel.Name = "iterationLabel";
            this.iterationLabel.Size = new System.Drawing.Size(45, 13);
            this.iterationLabel.TabIndex = 4;
            this.iterationLabel.Text = "Iteration";
            // 
            // sizeNumericUpDown
            // 
            this.sizeNumericUpDown.Location = new System.Drawing.Point(207, 0);
            this.sizeNumericUpDown.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.sizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizeNumericUpDown.Name = "sizeNumericUpDown";
            this.sizeNumericUpDown.Size = new System.Drawing.Size(57, 20);
            this.sizeNumericUpDown.TabIndex = 3;
            this.sizeNumericUpDown.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // goButton
            // 
            this.goButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.goButton.Location = new System.Drawing.Point(581, 21);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(54, 25);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // iterationNumericUpDown
            // 
            this.iterationNumericUpDown.Location = new System.Drawing.Point(57, 19);
            this.iterationNumericUpDown.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.iterationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationNumericUpDown.Name = "iterationNumericUpDown";
            this.iterationNumericUpDown.Size = new System.Drawing.Size(94, 20);
            this.iterationNumericUpDown.TabIndex = 1;
            this.iterationNumericUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // completionLabel
            // 
            this.completionLabel.AutoSize = true;
            this.completionLabel.Location = new System.Drawing.Point(3, 0);
            this.completionLabel.Name = "completionLabel";
            this.completionLabel.Size = new System.Drawing.Size(15, 13);
            this.completionLabel.TabIndex = 0;
            this.completionLabel.Text = "%";
            // 
            // BuddhabrotUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "BuddhabrotUserControl";
            this.Size = new System.Drawing.Size(644, 464);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsCountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sizeNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iterationNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label completionLabel;
        private System.Windows.Forms.NumericUpDown iterationNumericUpDown;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Label sizePixelLabel;
        private System.Windows.Forms.Label iterationLabel;
        private System.Windows.Forms.NumericUpDown sizeNumericUpDown;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.NumericUpDown pointsCountNumericUpDown;
    }
}
