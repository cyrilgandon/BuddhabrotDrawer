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
            this.btnDraw = new System.Windows.Forms.Button();
            this.drawingCompletionLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buddhabrotUserControl4 = new BuddhabrotDrawer.BuddhabrotUserControl();
            this.buddhabrotUserControl3 = new BuddhabrotDrawer.BuddhabrotUserControl();
            this.buddhabrotUserControl1 = new BuddhabrotDrawer.BuddhabrotUserControl();
            this.buddhabrotUserControl2 = new BuddhabrotDrawer.BuddhabrotUserControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(-2, 12);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(89, 23);
            this.btnDraw.TabIndex = 41;
            this.btnDraw.Text = "MultiBuddhabrot";
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // drawingCompletionLabel1
            // 
            this.drawingCompletionLabel1.AutoSize = true;
            this.drawingCompletionLabel1.Location = new System.Drawing.Point(409, -11);
            this.drawingCompletionLabel1.Name = "drawingCompletionLabel1";
            this.drawingCompletionLabel1.Size = new System.Drawing.Size(18, 13);
            this.drawingCompletionLabel1.TabIndex = 49;
            this.drawingCompletionLabel1.Text = " %";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.buddhabrotUserControl4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.buddhabrotUserControl3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buddhabrotUserControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buddhabrotUserControl2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(93, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 468);
            this.tableLayoutPanel1.TabIndex = 50;
            // 
            // buddhabrotUserControl4
            // 
            this.buddhabrotUserControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buddhabrotUserControl4.Location = new System.Drawing.Point(369, 237);
            this.buddhabrotUserControl4.Name = "buddhabrotUserControl4";
            this.buddhabrotUserControl4.Size = new System.Drawing.Size(360, 228);
            this.buddhabrotUserControl4.TabIndex = 3;
            // 
            // buddhabrotUserControl3
            // 
            this.buddhabrotUserControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buddhabrotUserControl3.Location = new System.Drawing.Point(3, 237);
            this.buddhabrotUserControl3.Name = "buddhabrotUserControl3";
            this.buddhabrotUserControl3.Size = new System.Drawing.Size(360, 228);
            this.buddhabrotUserControl3.TabIndex = 2;
            // 
            // buddhabrotUserControl1
            // 
            this.buddhabrotUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buddhabrotUserControl1.Location = new System.Drawing.Point(369, 3);
            this.buddhabrotUserControl1.Name = "buddhabrotUserControl1";
            this.buddhabrotUserControl1.Size = new System.Drawing.Size(360, 228);
            this.buddhabrotUserControl1.TabIndex = 0;
            // 
            // buddhabrotUserControl2
            // 
            this.buddhabrotUserControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buddhabrotUserControl2.Location = new System.Drawing.Point(3, 3);
            this.buddhabrotUserControl2.Name = "buddhabrotUserControl2";
            this.buddhabrotUserControl2.Size = new System.Drawing.Size(360, 228);
            this.buddhabrotUserControl2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDraw;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.drawingCompletionLabel1);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "howto_buddhabrot";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.Label drawingCompletionLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private BuddhabrotUserControl buddhabrotUserControl2;
        private BuddhabrotUserControl buddhabrotUserControl1;
        private BuddhabrotUserControl buddhabrotUserControl3;
        private BuddhabrotUserControl buddhabrotUserControl4;
    }
}

