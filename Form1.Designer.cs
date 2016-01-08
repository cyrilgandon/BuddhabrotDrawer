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
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.drawingCompletionLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buddhabrotUserControl3 = new BuddhabrotDrawer.BuddhabrotUserControl();
            this.buddhabrotUserControl2 = new BuddhabrotDrawer.BuddhabrotUserControl();
            this.buddhabrotUserControl1 = new BuddhabrotDrawer.BuddhabrotUserControl();
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
            // 
            // sfdBrot
            // 
            this.sfdBrot.Filter = "Bitmaps|*.bmp|JPEGs|*.jpeg;*.jpg|GIFs|*.gif|All Files|*.*";
            // 
            // txtDrawEvery
            // 
            this.txtDrawEvery.Location = new System.Drawing.Point(92, 62);
            this.txtDrawEvery.Name = "txtDrawEvery";
            this.txtDrawEvery.Size = new System.Drawing.Size(39, 20);
            this.txtDrawEvery.TabIndex = 45;
            this.txtDrawEvery.Text = "2";
            this.txtDrawEvery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(12, 62);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(65, 13);
            this.Label7.TabIndex = 44;
            this.Label7.Text = "Draw Every:";
            // 
            // txtStopAfter
            // 
            this.txtStopAfter.Location = new System.Drawing.Point(92, 38);
            this.txtStopAfter.Name = "txtStopAfter";
            this.txtStopAfter.Size = new System.Drawing.Size(72, 20);
            this.txtStopAfter.TabIndex = 43;
            this.txtStopAfter.Text = "10000000";
            this.txtStopAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(12, 38);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(57, 13);
            this.Label6.TabIndex = 42;
            this.Label6.Text = "Stop After:";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(92, 88);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 41;
            this.btnDraw.Text = "Draw";
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
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
            // drawingCompletionLabel1
            // 
            this.drawingCompletionLabel1.AutoSize = true;
            this.drawingCompletionLabel1.Location = new System.Drawing.Point(409, -11);
            this.drawingCompletionLabel1.Name = "drawingCompletionLabel1";
            this.drawingCompletionLabel1.Size = new System.Drawing.Size(18, 13);
            this.drawingCompletionLabel1.TabIndex = 49;
            this.drawingCompletionLabel1.Text = " %";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = " %";
            // 
            // buddhabrotUserControl3
            // 
            this.buddhabrotUserControl3.Location = new System.Drawing.Point(293, 224);
            this.buddhabrotUserControl3.Name = "buddhabrotUserControl3";
            this.buddhabrotUserControl3.Size = new System.Drawing.Size(193, 173);
            this.buddhabrotUserControl3.TabIndex = 61;
            // 
            // buddhabrotUserControl2
            // 
            this.buddhabrotUserControl2.Location = new System.Drawing.Point(615, 5);
            this.buddhabrotUserControl2.Name = "buddhabrotUserControl2";
            this.buddhabrotUserControl2.Size = new System.Drawing.Size(194, 174);
            this.buddhabrotUserControl2.TabIndex = 60;
            // 
            // buddhabrotUserControl1
            // 
            this.buddhabrotUserControl1.Location = new System.Drawing.Point(293, 5);
            this.buddhabrotUserControl1.Name = "buddhabrotUserControl1";
            this.buddhabrotUserControl1.Size = new System.Drawing.Size(193, 174);
            this.buddhabrotUserControl1.TabIndex = 59;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDraw;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 443);
            this.Controls.Add(this.buddhabrotUserControl3);
            this.Controls.Add(this.buddhabrotUserControl2);
            this.Controls.Add(this.buddhabrotUserControl1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drawingCompletionLabel1);
            this.Controls.Add(this.txtDrawEvery);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.txtStopAfter);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.Label1);
            this.Menu = this.MainMenu1;
            this.Name = "Form1";
            this.Text = "howto_buddhabrot";
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
        internal System.Windows.Forms.TextBox txtWidth;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label drawingCompletionLabel1;
        private System.Windows.Forms.Label label2;
        private BuddhabrotUserControl buddhabrotUserControl1;
        private BuddhabrotUserControl buddhabrotUserControl2;
        private BuddhabrotUserControl buddhabrotUserControl3;
    }
}

