namespace ISP201Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxClients = new System.Windows.Forms.ListBox();
            this.textBoxLocalPort = new System.Windows.Forms.TextBox();
            this.buttonBind = new System.Windows.Forms.Button();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listBoxClients
            // 
            this.listBoxClients.FormattingEnabled = true;
            this.listBoxClients.ItemHeight = 20;
            this.listBoxClients.Location = new System.Drawing.Point(526, 85);
            this.listBoxClients.Name = "listBoxClients";
            this.listBoxClients.Size = new System.Drawing.Size(192, 324);
            this.listBoxClients.TabIndex = 9;
            // 
            // textBoxLocalPort
            // 
            this.textBoxLocalPort.Location = new System.Drawing.Point(60, 85);
            this.textBoxLocalPort.Multiline = true;
            this.textBoxLocalPort.Name = "textBoxLocalPort";
            this.textBoxLocalPort.Size = new System.Drawing.Size(446, 310);
            this.textBoxLocalPort.TabIndex = 8;
            // 
            // buttonBind
            // 
            this.buttonBind.Location = new System.Drawing.Point(358, 41);
            this.buttonBind.Name = "buttonBind";
            this.buttonBind.Size = new System.Drawing.Size(148, 29);
            this.buttonBind.TabIndex = 7;
            this.buttonBind.Text = "Открыть порт";
            this.buttonBind.UseVisualStyleBackColor = true;
            this.buttonBind.Click += new System.EventHandler(this.buttonBind_Click);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(216, 41);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(123, 29);
            this.textBoxLog.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Локальный порт:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxClients);
            this.Controls.Add(this.textBoxLocalPort);
            this.Controls.Add(this.buttonBind);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Комната";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxClients;
        private TextBox textBoxLocalPort;
        private Button buttonBind;
        private TextBox textBoxLog;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}