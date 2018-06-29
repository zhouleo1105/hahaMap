namespace nmap
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cer_bt = new System.Windows.Forms.Button();
            this.ip_box = new System.Windows.Forms.TextBox();
            this.ip_txt = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.port_box = new System.Windows.Forms.TextBox();
            this.port_txt = new System.Windows.Forms.Label();
            this.ssl_bt = new System.Windows.Forms.Button();
            this.state = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cer_bt
            // 
            this.cer_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cer_bt.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cer_bt.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cer_bt.Location = new System.Drawing.Point(299, 15);
            this.cer_bt.Name = "cer_bt";
            this.cer_bt.Size = new System.Drawing.Size(97, 62);
            this.cer_bt.TabIndex = 0;
            this.cer_bt.Text = "Cer";
            this.cer_bt.UseVisualStyleBackColor = true;
            this.cer_bt.Click += new System.EventHandler(this.BtCer_Click);
            // 
            // ip_box
            // 
            this.ip_box.BackColor = System.Drawing.Color.Ivory;
            this.ip_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ip_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip_box.Location = new System.Drawing.Point(87, 15);
            this.ip_box.Name = "ip_box";
            this.ip_box.Size = new System.Drawing.Size(190, 26);
            this.ip_box.TabIndex = 1;
            // 
            // ip_txt
            // 
            this.ip_txt.AutoSize = true;
            this.ip_txt.Location = new System.Drawing.Point(10, 22);
            this.ip_txt.Name = "ip_txt";
            this.ip_txt.Size = new System.Drawing.Size(61, 12);
            this.ip_txt.TabIndex = 2;
            this.ip_txt.Text = "IP / Domain";
            this.ip_txt.Click += new System.EventHandler(this.LbIP_Click);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Linen;
            this.result.Font = new System.Drawing.Font("標楷體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.result.Location = new System.Drawing.Point(12, 91);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.result.Size = new System.Drawing.Size(629, 304);
            this.result.TabIndex = 3;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // port_box
            // 
            this.port_box.BackColor = System.Drawing.Color.Ivory;
            this.port_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.port_box.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.port_box.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port_box.Location = new System.Drawing.Point(87, 51);
            this.port_box.MaxLength = 5;
            this.port_box.Name = "port_box";
            this.port_box.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.port_box.Size = new System.Drawing.Size(190, 26);
            this.port_box.TabIndex = 4;
            this.port_box.TextChanged += new System.EventHandler(this.port_box_TextChanged);
            // 
            // port_txt
            // 
            this.port_txt.AutoSize = true;
            this.port_txt.Location = new System.Drawing.Point(12, 58);
            this.port_txt.Name = "port_txt";
            this.port_txt.Size = new System.Drawing.Size(24, 12);
            this.port_txt.TabIndex = 5;
            this.port_txt.Text = "Port";
            this.port_txt.Click += new System.EventHandler(this.port_txt_Click);
            // 
            // ssl_bt
            // 
            this.ssl_bt.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ssl_bt.Location = new System.Drawing.Point(412, 15);
            this.ssl_bt.Name = "ssl_bt";
            this.ssl_bt.Size = new System.Drawing.Size(97, 62);
            this.ssl_bt.TabIndex = 6;
            this.ssl_bt.Text = "SSL";
            this.ssl_bt.UseVisualStyleBackColor = true;
            this.ssl_bt.Click += new System.EventHandler(this.BtSSL_Click);
            // 
            // state
            // 
            this.state.BackColor = System.Drawing.Color.LightGreen;
            this.state.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.state.Location = new System.Drawing.Point(542, 14);
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Size = new System.Drawing.Size(72, 27);
            this.state.TabIndex = 7;
            this.state.Text = "等待中";
            this.state.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.state.TextChanged += new System.EventHandler(this.state_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(654, 412);
            this.Controls.Add(this.state);
            this.Controls.Add(this.ssl_bt);
            this.Controls.Add(this.port_txt);
            this.Controls.Add(this.port_box);
            this.Controls.Add(this.result);
            this.Controls.Add(this.ip_txt);
            this.Controls.Add(this.ip_box);
            this.Controls.Add(this.cer_bt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NMAP-scanner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cer_bt;
        private System.Windows.Forms.TextBox ip_box;
        private System.Windows.Forms.Label ip_txt;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox port_box;
        private System.Windows.Forms.Label port_txt;
        private System.Windows.Forms.Button ssl_bt;
        private System.Windows.Forms.TextBox state;
    }
}

