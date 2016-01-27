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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buddhabrotUserControl4 = new BuddhabrotDrawer.BuddhabrotUserControl();
            this.buddhabrotUserControl3 = new BuddhabrotDrawer.BuddhabrotUserControl();
            this.buddhabrotUserControl1 = new BuddhabrotDrawer.BuddhabrotUserControl();
            this.buddhabrotUserControl2 = new BuddhabrotDrawer.BuddhabrotUserControl();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PercentColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeLeftColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimatedEndColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(12, 12);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(107, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(718, 293);
            this.tableLayoutPanel1.TabIndex = 50;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.PercentColumn,
            this.TimeLeftColumn,
            this.EstimatedEndColumn});
            this.dataGridView1.Location = new System.Drawing.Point(-2, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(824, 166);
            this.dataGridView1.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "label1";
            // 
            // buddhabrotUserControl4
            // 
            this.buddhabrotUserControl4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buddhabrotUserControl4.Location = new System.Drawing.Point(362, 149);
            this.buddhabrotUserControl4.Name = "buddhabrotUserControl4";
            this.buddhabrotUserControl4.Size = new System.Drawing.Size(353, 141);
            this.buddhabrotUserControl4.TabIndex = 3;
            // 
            // buddhabrotUserControl3
            // 
            this.buddhabrotUserControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buddhabrotUserControl3.Location = new System.Drawing.Point(3, 149);
            this.buddhabrotUserControl3.Name = "buddhabrotUserControl3";
            this.buddhabrotUserControl3.Size = new System.Drawing.Size(353, 141);
            this.buddhabrotUserControl3.TabIndex = 2;
            // 
            // buddhabrotUserControl1
            // 
            this.buddhabrotUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buddhabrotUserControl1.Location = new System.Drawing.Point(362, 3);
            this.buddhabrotUserControl1.Name = "buddhabrotUserControl1";
            this.buddhabrotUserControl1.Size = new System.Drawing.Size(353, 140);
            this.buddhabrotUserControl1.TabIndex = 0;
            // 
            // buddhabrotUserControl2
            // 
            this.buddhabrotUserControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buddhabrotUserControl2.Location = new System.Drawing.Point(3, 3);
            this.buddhabrotUserControl2.Name = "buddhabrotUserControl2";
            this.buddhabrotUserControl2.Size = new System.Drawing.Size(353, 140);
            this.buddhabrotUserControl2.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Iteration";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // PercentColumn
            // 
            this.PercentColumn.HeaderText = "Percent";
            this.PercentColumn.Name = "PercentColumn";
            // 
            // TimeLeftColumn
            // 
            this.TimeLeftColumn.HeaderText = "TimeLeft";
            this.TimeLeftColumn.Name = "TimeLeftColumn";
            // 
            // EstimatedEndColumn
            // 
            this.EstimatedEndColumn.HeaderText = "EstimatedEnd";
            this.EstimatedEndColumn.Name = "EstimatedEndColumn";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDraw;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 492);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.drawingCompletionLabel1);
            this.Controls.Add(this.btnDraw);
            this.Name = "Form1";
            this.Text = "howto_buddhabrot";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PercentColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimatedEndColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeLeftColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

