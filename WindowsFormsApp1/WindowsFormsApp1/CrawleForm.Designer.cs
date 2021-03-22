namespace WindowsFormsApp1
{
    partial class CrawleForm
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
            this.num_threadCount = new System.Windows.Forms.NumericUpDown();
            this.btn_start = new System.Windows.Forms.Button();
            this.num_crawleCount = new System.Windows.Forms.NumericUpDown();
            this.listview_crawle = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.num_threadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_crawleCount)).BeginInit();
            this.SuspendLayout();
            // 
            // num_threadCount
            // 
            this.num_threadCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_threadCount.Location = new System.Drawing.Point(119, 50);
            this.num_threadCount.Name = "num_threadCount";
            this.num_threadCount.Size = new System.Drawing.Size(66, 29);
            this.num_threadCount.TabIndex = 1;
            this.num_threadCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(214, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(106, 67);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // num_crawleCount
            // 
            this.num_crawleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_crawleCount.Location = new System.Drawing.Point(119, 12);
            this.num_crawleCount.Name = "num_crawleCount";
            this.num_crawleCount.Size = new System.Drawing.Size(66, 29);
            this.num_crawleCount.TabIndex = 1;
            this.num_crawleCount.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // listview_crawle
            // 
            this.listview_crawle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listview_crawle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listview_crawle.HideSelection = false;
            this.listview_crawle.Location = new System.Drawing.Point(12, 94);
            this.listview_crawle.Name = "listview_crawle";
            this.listview_crawle.Size = new System.Drawing.Size(858, 562);
            this.listview_crawle.TabIndex = 7;
            this.listview_crawle.UseCompatibleStateImageBehavior = false;
            this.listview_crawle.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID";
            this.columnHeader2.Width = 114;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Link";
            this.columnHeader3.Width = 241;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "FileName";
            this.columnHeader4.Width = 142;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "%";
            this.columnHeader5.Width = 127;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            this.columnHeader6.Width = 112;
            // 
            // CrawleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 668);
            this.Controls.Add(this.listview_crawle);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.num_crawleCount);
            this.Controls.Add(this.num_threadCount);
            this.Name = "CrawleForm";
            this.Text = "CrawleForm";
            ((System.ComponentModel.ISupportInitialize)(this.num_threadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_crawleCount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown num_threadCount;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.NumericUpDown num_crawleCount;
        private System.Windows.Forms.ListView listview_crawle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}