namespace PerfTest
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this._table = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this._lblCostPerf = new System.Windows.Forms.Label();
            this._lblCpuPerf = new System.Windows.Forms.Label();
            this._lblCostApi = new System.Windows.Forms.Label();
            this._lblCpuApi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this._btnReset = new System.Windows.Forms.Button();
            this._lblInfo = new System.Windows.Forms.Label();
            this._table.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _table
            // 
            this._table.ColumnCount = 4;
            this._table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this._table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this._table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._table.Controls.Add(this.label2, 2, 0);
            this._table.Controls.Add(this._lblCostPerf, 2, 1);
            this._table.Controls.Add(this._lblCpuPerf, 1, 1);
            this._table.Controls.Add(this._lblCostApi, 2, 2);
            this._table.Controls.Add(this._lblCpuApi, 1, 2);
            this._table.Controls.Add(this.label1, 1, 0);
            this._table.Controls.Add(this.label3, 0, 1);
            this._table.Controls.Add(this.label4, 0, 2);
            this._table.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this._table.Dock = System.Windows.Forms.DockStyle.Fill;
            this._table.Location = new System.Drawing.Point(0, 0);
            this._table.Name = "_table";
            this._table.RowCount = 4;
            this._table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this._table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this._table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this._table.Size = new System.Drawing.Size(545, 225);
            this._table.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Avg Cost (ms)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblCostPerf
            // 
            this._lblCostPerf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblCostPerf.AutoSize = true;
            this._lblCostPerf.Location = new System.Drawing.Point(125, 29);
            this._lblCostPerf.Margin = new System.Windows.Forms.Padding(5);
            this._lblCostPerf.Name = "_lblCostPerf";
            this._lblCostPerf.Size = new System.Drawing.Size(80, 75);
            this._lblCostPerf.TabIndex = 0;
            this._lblCostPerf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblCpuPerf
            // 
            this._lblCpuPerf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblCpuPerf.AutoSize = true;
            this._lblCpuPerf.Location = new System.Drawing.Point(65, 29);
            this._lblCpuPerf.Margin = new System.Windows.Forms.Padding(5);
            this._lblCpuPerf.Name = "_lblCpuPerf";
            this._lblCpuPerf.Size = new System.Drawing.Size(50, 75);
            this._lblCpuPerf.TabIndex = 0;
            this._lblCpuPerf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblCostApi
            // 
            this._lblCostApi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblCostApi.AutoSize = true;
            this._lblCostApi.Location = new System.Drawing.Point(125, 114);
            this._lblCostApi.Margin = new System.Windows.Forms.Padding(5);
            this._lblCostApi.Name = "_lblCostApi";
            this._lblCostApi.Size = new System.Drawing.Size(80, 75);
            this._lblCostApi.TabIndex = 0;
            this._lblCostApi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _lblCpuApi
            // 
            this._lblCpuApi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lblCpuApi.AutoSize = true;
            this._lblCpuApi.Location = new System.Drawing.Point(65, 114);
            this._lblCpuApi.Margin = new System.Windows.Forms.Padding(5);
            this._lblCpuApi.Name = "_lblCpuApi";
            this._lblCpuApi.Size = new System.Drawing.Size(50, 75);
            this._lblCpuApi.TabIndex = 0;
            this._lblCpuApi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPU%";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 75);
            this.label3.TabIndex = 0;
            this.label3.Text = "Perf Counter";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 75);
            this.label4.TabIndex = 0;
            this.label4.Text = "Win32 API";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this._table.SetColumnSpan(this.flowLayoutPanel1, 4);
            this.flowLayoutPanel1.Controls.Add(this._btnReset);
            this.flowLayoutPanel1.Controls.Add(this._lblInfo);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 197);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(539, 25);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // _btnReset
            // 
            this._btnReset.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this._btnReset.Location = new System.Drawing.Point(1, 1);
            this._btnReset.Margin = new System.Windows.Forms.Padding(1);
            this._btnReset.Name = "_btnReset";
            this._btnReset.Size = new System.Drawing.Size(102, 22);
            this._btnReset.TabIndex = 0;
            this._btnReset.Text = "Reset counters";
            this._btnReset.UseVisualStyleBackColor = true;
            this._btnReset.Click += new System.EventHandler(this.HandleButtonResetCountersClick);
            // 
            // _lblInfo
            // 
            this._lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this._lblInfo.AutoSize = true;
            this._lblInfo.Location = new System.Drawing.Point(109, 2);
            this._lblInfo.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this._lblInfo.Name = "_lblInfo";
            this._lblInfo.Size = new System.Drawing.Size(36, 20);
            this._lblInfo.TabIndex = 1;
            this._lblInfo.Text = "<info>";
            this._lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 225);
            this.Controls.Add(this._table);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "System CPU";
            this._table.ResumeLayout(false);
            this._table.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label _lblCpuPerf;
        private System.Windows.Forms.Label _lblCostPerf;
        private System.Windows.Forms.Label _lblCpuApi;
        private System.Windows.Forms.Label _lblCostApi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button _btnReset;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label _lblInfo;
    }
}

