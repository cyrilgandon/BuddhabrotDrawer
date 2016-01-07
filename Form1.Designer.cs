namespace BuddhabrotDrawer
{
    partial class Form1
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
            this.MainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.MenuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuFileSave = new System.Windows.Forms.MenuItem();
            this.sfdBrot = new System.Windows.Forms.SaveFileDialog();
            this.txtDrawEvery = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtStopAfter = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtRedCutoff = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.drawingCompletionLabel1 = new System.Windows.Forms.Label();
            this.drawingCompletionLabel2 = new System.Windows.Forms.Label();
            this.drawingCompletionLabel3 = new System.Windows.Forms.Label();
            this.drawingCompletionLabel4 = new System.Windows.Forms.Label();
            this.completionLabel1 = new System.Windows.Forms.Label();
            this.completionLabel2 = new System.Windows.Forms.Label();
            this.completionLabel3 = new System.Windows.Forms.Label();
            this.completionLabel4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu1
            // 
            this.MainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.MenuItem1});
            // 
            // MenuItem1
            // 
            this.MenuItem1.Index = 0;
            this.MenuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuFileSave});
            this.MenuItem1.Text = "&File";
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Enabled = false;
            this.mnuFileSave.Index = 0;
            this.mnuFileSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.mnuFileSave.Text = "&Save...";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // sfdBrot
            // 
            this.sfdBrot.Filter = "Bitmaps|*.bmp|JPEGs|*.jpeg;*.jpg|GIFs|*.gif|All Files|*.*";
            // 
            // txtDrawEvery
            // 
            this.txtDrawEvery.Location = new System.Drawing.Point(92, 172);
            this.txtDrawEvery.Name = "txtDrawEvery";
            this.txtDrawEvery.Size = new System.Drawing.Size(72, 20);
            this.txtDrawEvery.TabIndex = 45;
            this.txtDrawEvery.Text = "10000";
            this.txtDrawEvery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(12, 172);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(65, 13);
            this.Label7.TabIndex = 44;
            this.Label7.Text = "Draw Every:";
            // 
            // txtStopAfter
            // 
            this.txtStopAfter.Location = new System.Drawing.Point(92, 148);
            this.txtStopAfter.Name = "txtStopAfter";
            this.txtStopAfter.Size = new System.Drawing.Size(72, 20);
            this.txtStopAfter.TabIndex = 43;
            this.txtStopAfter.Text = "10000000";
            this.txtStopAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(12, 148);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(57, 13);
            this.Label6.TabIndex = 42;
            this.Label6.Text = "Stop After:";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(28, 212);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 41;
            this.btnDraw.Text = "Draw";
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // picCanvas
            // 
            this.picCanvas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCanvas.Location = new System.Drawing.Point(3, 3);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(194, 200);
            this.picCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCanvas.TabIndex = 40;
            this.picCanvas.TabStop = false;
            // 
            // txtRedCutoff
            // 
            this.txtRedCutoff.Location = new System.Drawing.Point(92, 68);
            this.txtRedCutoff.Name = "txtRedCutoff";
            this.txtRedCutoff.Size = new System.Drawing.Size(72, 20);
            this.txtRedCutoff.TabIndex = 35;
            this.txtRedCutoff.Text = "1250";
            this.txtRedCutoff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(12, 68);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(38, 13);
            this.Label4.TabIndex = 34;
            this.Label4.Text = "Cutoff:";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(92, 12);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(72, 20);
            this.txtWidth.TabIndex = 31;
            this.txtWidth.Text = "200";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 12);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(38, 13);
            this.Label1.TabIndex = 30;
            this.Label1.Text = "Width:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 209);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(203, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(203, 209);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(194, 188);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 48;
            this.pictureBox3.TabStop = false;
            // 
            // drawingCompletionLabel1
            // 
            this.drawingCompletionLabel1.AutoSize = true;
            this.drawingCompletionLabel1.Location = new System.Drawing.Point(409, -11);
            this.drawingCompletionLabel1.Name = "drawingCompletionLabel1";
            this.drawingCompletionLabel1.Size = new System.Drawing.Size(18, 13);
            this.drawingCompletionLabel1.TabIndex = 49;
            this.drawingCompletionLabel1.Text = " %";
            this.drawingCompletionLabel1.Click += new System.EventHandler(this.drawingCompletionLabel1_Click);
            // 
            // drawingCompletionLabel2
            // 
            this.drawingCompletionLabel2.AutoSize = true;
            this.drawingCompletionLabel2.Location = new System.Drawing.Point(427, 196);
            this.drawingCompletionLabel2.Name = "drawingCompletionLabel2";
            this.drawingCompletionLabel2.Size = new System.Drawing.Size(18, 13);
            this.drawingCompletionLabel2.TabIndex = 50;
            this.drawingCompletionLabel2.Text = " %";
            this.drawingCompletionLabel2.Click += new System.EventHandler(this.drawingCompletionLabel2_Click);
            // 
            // drawingCompletionLabel3
            // 
            this.drawingCompletionLabel3.AutoSize = true;
            this.drawingCompletionLabel3.Location = new System.Drawing.Point(211, 415);
            this.drawingCompletionLabel3.Name = "drawingCompletionLabel3";
            this.drawingCompletionLabel3.Size = new System.Drawing.Size(18, 13);
            this.drawingCompletionLabel3.TabIndex = 51;
            this.drawingCompletionLabel3.Text = " %";
            this.drawingCompletionLabel3.Click += new System.EventHandler(this.drawingCompletionLabel3_Click);
            // 
            // drawingCompletionLabel4
            // 
            this.drawingCompletionLabel4.AutoSize = true;
            this.drawingCompletionLabel4.Location = new System.Drawing.Point(427, 415);
            this.drawingCompletionLabel4.Name = "drawingCompletionLabel4";
            this.drawingCompletionLabel4.Size = new System.Drawing.Size(18, 13);
            this.drawingCompletionLabel4.TabIndex = 52;
            this.drawingCompletionLabel4.Text = " %";
            this.drawingCompletionLabel4.Click += new System.EventHandler(this.drawingCompletionLabel4_Click);
            // 
            // completionLabel1
            // 
            this.completionLabel1.AutoSize = true;
            this.completionLabel1.Location = new System.Drawing.Point(244, 179);
            this.completionLabel1.Name = "completionLabel1";
            this.completionLabel1.Size = new System.Drawing.Size(18, 13);
            this.completionLabel1.TabIndex = 53;
            this.completionLabel1.Text = " %";
            // 
            // completionLabel2
            // 
            this.completionLabel2.AutoSize = true;
            this.completionLabel2.Location = new System.Drawing.Point(427, 175);
            this.completionLabel2.Name = "completionLabel2";
            this.completionLabel2.Size = new System.Drawing.Size(18, 13);
            this.completionLabel2.TabIndex = 54;
            this.completionLabel2.Text = " %";
            // 
            // completionLabel3
            // 
            this.completionLabel3.AutoSize = true;
            this.completionLabel3.Location = new System.Drawing.Point(211, 393);
            this.completionLabel3.Name = "completionLabel3";
            this.completionLabel3.Size = new System.Drawing.Size(18, 13);
            this.completionLabel3.TabIndex = 55;
            this.completionLabel3.Text = " %";
            // 
            // completionLabel4
            // 
            this.completionLabel4.AutoSize = true;
            this.completionLabel4.Location = new System.Drawing.Point(427, 393);
            this.completionLabel4.Name = "completionLabel4";
            this.completionLabel4.Size = new System.Drawing.Size(18, 13);
            this.completionLabel4.TabIndex = 56;
            this.completionLabel4.Text = " %";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.picCanvas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox3, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(462, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(400, 400);
            this.tableLayoutPanel1.TabIndex = 57;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDraw;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 506);
            this.Controls.Add(this.drawingCompletionLabel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.completionLabel1);
            this.Controls.Add(this.completionLabel4);
            this.Controls.Add(this.completionLabel3);
            this.Controls.Add(this.completionLabel2);
            this.Controls.Add(this.drawingCompletionLabel4);
            this.Controls.Add(this.drawingCompletionLabel3);
            this.Controls.Add(this.drawingCompletionLabel2);
            this.Controls.Add(this.txtDrawEvery);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtStopAfter);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtRedCutoff);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.Label1);
            this.Menu = this.MainMenu1;
            this.Name = "Form1";
            this.Text = "howto_buddhabrot";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MainMenu MainMenu1;
        internal System.Windows.Forms.MenuItem MenuItem1;
        internal System.Windows.Forms.MenuItem mnuFileSave;
        internal System.Windows.Forms.SaveFileDialog sfdBrot;
        internal System.Windows.Forms.TextBox txtDrawEvery;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtStopAfter;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Button btnDraw;
        internal System.Windows.Forms.PictureBox picCanvas;
        internal System.Windows.Forms.TextBox txtRedCutoff;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtWidth;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label drawingCompletionLabel1;
        private System.Windows.Forms.Label drawingCompletionLabel2;
        private System.Windows.Forms.Label drawingCompletionLabel3;
        private System.Windows.Forms.Label drawingCompletionLabel4;
        private System.Windows.Forms.Label completionLabel1;
        private System.Windows.Forms.Label completionLabel2;
        private System.Windows.Forms.Label completionLabel3;
        private System.Windows.Forms.Label completionLabel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

