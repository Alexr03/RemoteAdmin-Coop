namespace SolarRemoteAdminGUI
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
            this.browser = new Gecko.GeckoWebBrowser();
            this.Server1Execute = new System.Windows.Forms.Button();
            this.Server1Log = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Server2Execute = new System.Windows.Forms.Button();
            this.Server2Log = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Server5Execute = new System.Windows.Forms.Button();
            this.Server5Log = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Server7Execute = new System.Windows.Forms.Button();
            this.Server7Log = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Server8Execute = new System.Windows.Forms.Button();
            this.Server8Log = new System.Windows.Forms.Button();
            this.CMDBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Button();
            this.Server6Logs = new System.Windows.Forms.Button();
            this.Server6Execute = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.Location = new System.Drawing.Point(-1, 64);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(1471, 731);
            this.browser.TabIndex = 2;
            this.browser.UseHttpActivityObserver = false;
            // 
            // Server1Execute
            // 
            this.Server1Execute.Location = new System.Drawing.Point(1476, 102);
            this.Server1Execute.Name = "Server1Execute";
            this.Server1Execute.Size = new System.Drawing.Size(81, 47);
            this.Server1Execute.TabIndex = 3;
            this.Server1Execute.Text = "Execute";
            this.Server1Execute.UseVisualStyleBackColor = true;
            this.Server1Execute.Click += new System.EventHandler(this.Server1Execute_Click);
            // 
            // Server1Log
            // 
            this.Server1Log.Location = new System.Drawing.Point(1563, 102);
            this.Server1Log.Name = "Server1Log";
            this.Server1Log.Size = new System.Drawing.Size(81, 47);
            this.Server1Log.TabIndex = 4;
            this.Server1Log.Text = "Logs";
            this.Server1Log.UseVisualStyleBackColor = true;
            this.Server1Log.Click += new System.EventHandler(this.Server1Log_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(1497, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(1497, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "Server 2";
            // 
            // Server2Execute
            // 
            this.Server2Execute.Location = new System.Drawing.Point(1476, 200);
            this.Server2Execute.Name = "Server2Execute";
            this.Server2Execute.Size = new System.Drawing.Size(81, 47);
            this.Server2Execute.TabIndex = 7;
            this.Server2Execute.Text = "Execute";
            this.Server2Execute.UseVisualStyleBackColor = true;
            this.Server2Execute.Click += new System.EventHandler(this.Server2Execute_Click);
            // 
            // Server2Log
            // 
            this.Server2Log.Location = new System.Drawing.Point(1563, 200);
            this.Server2Log.Name = "Server2Log";
            this.Server2Log.Size = new System.Drawing.Size(81, 47);
            this.Server2Log.TabIndex = 8;
            this.Server2Log.Text = "Logs";
            this.Server2Log.UseVisualStyleBackColor = true;
            this.Server2Log.Click += new System.EventHandler(this.Server2Log_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(1506, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 33);
            this.label3.TabIndex = 9;
            this.label3.Text = "Server 5";
            // 
            // Server5Execute
            // 
            this.Server5Execute.Location = new System.Drawing.Point(1476, 306);
            this.Server5Execute.Name = "Server5Execute";
            this.Server5Execute.Size = new System.Drawing.Size(81, 47);
            this.Server5Execute.TabIndex = 10;
            this.Server5Execute.Text = "Execute";
            this.Server5Execute.UseVisualStyleBackColor = true;
            this.Server5Execute.Click += new System.EventHandler(this.Server5Execute_Click);
            // 
            // Server5Log
            // 
            this.Server5Log.Location = new System.Drawing.Point(1563, 306);
            this.Server5Log.Name = "Server5Log";
            this.Server5Log.Size = new System.Drawing.Size(81, 47);
            this.Server5Log.TabIndex = 11;
            this.Server5Log.Text = "Logs";
            this.Server5Log.UseVisualStyleBackColor = true;
            this.Server5Log.Click += new System.EventHandler(this.Server5Log_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(1506, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 33);
            this.label4.TabIndex = 12;
            this.label4.Text = "Server 7";
            // 
            // Server7Execute
            // 
            this.Server7Execute.Location = new System.Drawing.Point(1476, 514);
            this.Server7Execute.Name = "Server7Execute";
            this.Server7Execute.Size = new System.Drawing.Size(81, 47);
            this.Server7Execute.TabIndex = 13;
            this.Server7Execute.Text = "Execute";
            this.Server7Execute.UseVisualStyleBackColor = true;
            this.Server7Execute.Click += new System.EventHandler(this.Server7Execute_Click);
            // 
            // Server7Log
            // 
            this.Server7Log.Location = new System.Drawing.Point(1562, 514);
            this.Server7Log.Name = "Server7Log";
            this.Server7Log.Size = new System.Drawing.Size(81, 47);
            this.Server7Log.TabIndex = 14;
            this.Server7Log.Text = "Logs";
            this.Server7Log.UseVisualStyleBackColor = true;
            this.Server7Log.Click += new System.EventHandler(this.Server7Log_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(1506, 583);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Server 8";
            // 
            // Server8Execute
            // 
            this.Server8Execute.Location = new System.Drawing.Point(1476, 619);
            this.Server8Execute.Name = "Server8Execute";
            this.Server8Execute.Size = new System.Drawing.Size(81, 47);
            this.Server8Execute.TabIndex = 16;
            this.Server8Execute.Text = "Execute";
            this.Server8Execute.UseVisualStyleBackColor = true;
            this.Server8Execute.Click += new System.EventHandler(this.Server8Execute_Click);
            // 
            // Server8Log
            // 
            this.Server8Log.Location = new System.Drawing.Point(1563, 619);
            this.Server8Log.Name = "Server8Log";
            this.Server8Log.Size = new System.Drawing.Size(81, 47);
            this.Server8Log.TabIndex = 17;
            this.Server8Log.Text = "Logs";
            this.Server8Log.UseVisualStyleBackColor = true;
            this.Server8Log.Click += new System.EventHandler(this.Server8Log_Click);
            // 
            // CMDBox
            // 
            this.CMDBox.Location = new System.Drawing.Point(145, 801);
            this.CMDBox.Name = "CMDBox";
            this.CMDBox.Size = new System.Drawing.Size(1122, 20);
            this.CMDBox.TabIndex = 18;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(1482, 801);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(162, 20);
            this.PassBox.TabIndex = 19;
            // 
            // Status
            // 
            this.Status.Location = new System.Drawing.Point(1482, 714);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(161, 47);
            this.Status.TabIndex = 20;
            this.Status.Text = "Status";
            this.Status.UseVisualStyleBackColor = true;
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // Server6Logs
            // 
            this.Server6Logs.Location = new System.Drawing.Point(1562, 409);
            this.Server6Logs.Name = "Server6Logs";
            this.Server6Logs.Size = new System.Drawing.Size(81, 47);
            this.Server6Logs.TabIndex = 23;
            this.Server6Logs.Text = "Logs";
            this.Server6Logs.UseVisualStyleBackColor = true;
            this.Server6Logs.Click += new System.EventHandler(this.Server6Logs_Click);
            // 
            // Server6Execute
            // 
            this.Server6Execute.Location = new System.Drawing.Point(1476, 409);
            this.Server6Execute.Name = "Server6Execute";
            this.Server6Execute.Size = new System.Drawing.Size(81, 47);
            this.Server6Execute.TabIndex = 22;
            this.Server6Execute.Text = "Execute";
            this.Server6Execute.UseVisualStyleBackColor = true;
            this.Server6Execute.Click += new System.EventHandler(this.Server6Execute_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(1506, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 33);
            this.label6.TabIndex = 21;
            this.label6.Text = "Server 6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 833);
            this.Controls.Add(this.Server6Logs);
            this.Controls.Add(this.Server6Execute);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.CMDBox);
            this.Controls.Add(this.Server8Log);
            this.Controls.Add(this.Server8Execute);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Server7Log);
            this.Controls.Add(this.Server7Execute);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Server5Log);
            this.Controls.Add(this.Server5Execute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Server2Log);
            this.Controls.Add(this.Server2Execute);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Server1Log);
            this.Controls.Add(this.Server1Execute);
            this.Controls.Add(this.browser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Gecko.GeckoWebBrowser browser;
        private System.Windows.Forms.Button Server1Execute;
        private System.Windows.Forms.Button Server1Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Server2Execute;
        private System.Windows.Forms.Button Server2Log;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Server5Execute;
        private System.Windows.Forms.Button Server5Log;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Server7Execute;
        private System.Windows.Forms.Button Server7Log;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Server8Execute;
        private System.Windows.Forms.Button Server8Log;
        private System.Windows.Forms.TextBox CMDBox;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.Button Status;
        private System.Windows.Forms.Button Server6Logs;
        private System.Windows.Forms.Button Server6Execute;
        private System.Windows.Forms.Label label6;
    }
}

