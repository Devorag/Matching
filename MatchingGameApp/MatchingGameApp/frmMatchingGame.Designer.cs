namespace MatchingGame
{
    partial class frmMatchingGame
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tblStart = new TableLayoutPanel();
            BtnStart = new Button();
            tblBoard = new TableLayoutPanel();
            lbl16 = new Label();
            lbl15 = new Label();
            lbl14 = new Label();
            lbl13 = new Label();
            lbl12 = new Label();
            lbl11 = new Label();
            lbl10 = new Label();
            lbl9 = new Label();
            lbl8 = new Label();
            lbl7 = new Label();
            lbl6 = new Label();
            lbl5 = new Label();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tblStart.SuspendLayout();
            tblBoard.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tblStart, 0, 0);
            tableLayoutPanel1.Controls.Add(tblBoard, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0872478F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 86.91275F));
            tableLayoutPanel1.Size = new Size(649, 596);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tblStart
            // 
            tblStart.ColumnCount = 1;
            tblStart.ColumnStyles.Add(new ColumnStyle());
            tblStart.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tblStart.Controls.Add(BtnStart, 0, 0);
            tblStart.Dock = DockStyle.Fill;
            tblStart.Location = new Point(3, 3);
            tblStart.Name = "tblStart";
            tblStart.RowCount = 1;
            tblStart.RowStyles.Add(new RowStyle());
            tblStart.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblStart.Size = new Size(643, 71);
            tblStart.TabIndex = 3;
            // 
            // BtnStart
            // 
            BtnStart.Dock = DockStyle.Fill;
            BtnStart.Font = new Font("Segoe UI", 12F);
            BtnStart.Location = new Point(3, 3);
            BtnStart.Name = "BtnStart";
            BtnStart.Size = new Size(637, 65);
            BtnStart.TabIndex = 0;
            BtnStart.Text = "PRESS HERE TO START";
            BtnStart.UseVisualStyleBackColor = true;
            // 
            // tblBoard
            // 
            tblBoard.BackColor = Color.CornflowerBlue;
            tblBoard.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tblBoard.ColumnCount = 4;
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblBoard.Controls.Add(lbl16, 3, 3);
            tblBoard.Controls.Add(lbl15, 2, 3);
            tblBoard.Controls.Add(lbl14, 1, 3);
            tblBoard.Controls.Add(lbl13, 0, 3);
            tblBoard.Controls.Add(lbl12, 3, 2);
            tblBoard.Controls.Add(lbl11, 2, 2);
            tblBoard.Controls.Add(lbl10, 1, 2);
            tblBoard.Controls.Add(lbl9, 0, 2);
            tblBoard.Controls.Add(lbl8, 3, 1);
            tblBoard.Controls.Add(lbl7, 2, 1);
            tblBoard.Controls.Add(lbl6, 1, 1);
            tblBoard.Controls.Add(lbl5, 0, 1);
            tblBoard.Controls.Add(lbl4, 3, 0);
            tblBoard.Controls.Add(lbl3, 2, 0);
            tblBoard.Controls.Add(lbl2, 1, 0);
            tblBoard.Controls.Add(lbl1, 0, 0);
            tblBoard.Dock = DockStyle.Fill;
            tblBoard.Location = new Point(3, 80);
            tblBoard.Name = "tblBoard";
            tblBoard.RowCount = 4;
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblBoard.Size = new Size(643, 513);
            tblBoard.TabIndex = 2;
            // 
            // lbl16
            // 
            lbl16.Dock = DockStyle.Fill;
            lbl16.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl16.Location = new Point(485, 383);
            lbl16.Name = "lbl16";
            lbl16.Size = new Size(153, 128);
            lbl16.TabIndex = 15;
            lbl16.Text = "c";
            lbl16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl15
            // 
            lbl15.Dock = DockStyle.Fill;
            lbl15.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl15.Location = new Point(325, 383);
            lbl15.Name = "lbl15";
            lbl15.Size = new Size(152, 128);
            lbl15.TabIndex = 14;
            lbl15.Text = "c";
            lbl15.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl14
            // 
            lbl14.Dock = DockStyle.Fill;
            lbl14.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl14.Location = new Point(165, 383);
            lbl14.Name = "lbl14";
            lbl14.Size = new Size(152, 128);
            lbl14.TabIndex = 13;
            lbl14.Text = "c";
            lbl14.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl13
            // 
            lbl13.Dock = DockStyle.Fill;
            lbl13.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl13.Location = new Point(5, 383);
            lbl13.Name = "lbl13";
            lbl13.Size = new Size(152, 128);
            lbl13.TabIndex = 12;
            lbl13.Text = "c";
            lbl13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl12
            // 
            lbl12.Dock = DockStyle.Fill;
            lbl12.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl12.Location = new Point(485, 256);
            lbl12.Name = "lbl12";
            lbl12.Size = new Size(153, 125);
            lbl12.TabIndex = 11;
            lbl12.Text = "c";
            lbl12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl11
            // 
            lbl11.Dock = DockStyle.Fill;
            lbl11.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl11.Location = new Point(325, 256);
            lbl11.Name = "lbl11";
            lbl11.Size = new Size(152, 125);
            lbl11.TabIndex = 10;
            lbl11.Text = "c";
            lbl11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl10
            // 
            lbl10.Dock = DockStyle.Fill;
            lbl10.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl10.Location = new Point(165, 256);
            lbl10.Name = "lbl10";
            lbl10.Size = new Size(152, 125);
            lbl10.TabIndex = 9;
            lbl10.Text = "c";
            lbl10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl9
            // 
            lbl9.Dock = DockStyle.Fill;
            lbl9.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl9.Location = new Point(5, 256);
            lbl9.Name = "lbl9";
            lbl9.Size = new Size(152, 125);
            lbl9.TabIndex = 8;
            lbl9.Text = "c";
            lbl9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl8
            // 
            lbl8.Dock = DockStyle.Fill;
            lbl8.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl8.Location = new Point(485, 129);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(153, 125);
            lbl8.TabIndex = 7;
            lbl8.Text = "c";
            lbl8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl7
            // 
            lbl7.Dock = DockStyle.Fill;
            lbl7.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl7.Location = new Point(325, 129);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(152, 125);
            lbl7.TabIndex = 6;
            lbl7.Text = "c";
            lbl7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl6
            // 
            lbl6.Dock = DockStyle.Fill;
            lbl6.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl6.Location = new Point(165, 129);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(152, 125);
            lbl6.TabIndex = 5;
            lbl6.Text = "c";
            lbl6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            lbl5.Dock = DockStyle.Fill;
            lbl5.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl5.Location = new Point(5, 129);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(152, 125);
            lbl5.TabIndex = 4;
            lbl5.Text = "c";
            lbl5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            lbl4.Dock = DockStyle.Fill;
            lbl4.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl4.Location = new Point(485, 2);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(153, 125);
            lbl4.TabIndex = 3;
            lbl4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl3.Location = new Point(325, 2);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(152, 125);
            lbl3.TabIndex = 2;
            lbl3.Text = "c";
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            lbl2.Dock = DockStyle.Fill;
            lbl2.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl2.Location = new Point(165, 2);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(152, 125);
            lbl2.TabIndex = 1;
            lbl2.Text = "c";
            lbl2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl1
            // 
            lbl1.Dock = DockStyle.Fill;
            lbl1.Font = new Font("Webdings", 48F, FontStyle.Bold);
            lbl1.Location = new Point(5, 2);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(152, 125);
            lbl1.TabIndex = 0;
            lbl1.Text = "c";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMatchingGame
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 596);
            Controls.Add(tableLayoutPanel1);
            Name = "frmMatchingGame";
            Text = "frmMatchingGame";
            tableLayoutPanel1.ResumeLayout(false);
            tblStart.ResumeLayout(false);
            tblBoard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tblStart;
        private Button BtnStart;
        private TableLayoutPanel tblBoard;
        private Label lbl16;
        private Label lbl15;
        private Label lbl14;
        private Label lbl13;
        private Label lbl12;
        private Label lbl11;
        private Label lbl10;
        private Label lbl9;
        private Label lbl8;
        private Label lbl7;
        private Label lbl6;
        private Label lbl5;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
    }
}