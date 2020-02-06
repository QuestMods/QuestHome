namespace QuestHome.UI.Popups
{
    partial class ADBShell
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADBShell));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_send = new System.Windows.Forms.Button();
            this.txt_chat_input = new System.Windows.Forms.TextBox();
            this.lst_shell = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_send);
            this.panel1.Controls.Add(this.txt_chat_input);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 275);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 27);
            this.panel1.TabIndex = 0;
            // 
            // btn_send
            // 
            this.btn_send.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_send.Location = new System.Drawing.Point(464, 3);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(93, 23);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.Btn_send_Click);
            // 
            // txt_chat_input
            // 
            this.txt_chat_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_chat_input.Location = new System.Drawing.Point(3, 3);
            this.txt_chat_input.Multiline = true;
            this.txt_chat_input.Name = "txt_chat_input";
            this.txt_chat_input.Size = new System.Drawing.Size(455, 20);
            this.txt_chat_input.TabIndex = 0;
            this.txt_chat_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_chat_input_KeyPress);
            // 
            // lst_shell
            // 
            this.lst_shell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_shell.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.lst_shell.FormattingEnabled = true;
            this.lst_shell.Location = new System.Drawing.Point(0, 0);
            this.lst_shell.Name = "lst_shell";
            this.lst_shell.Size = new System.Drawing.Size(560, 275);
            this.lst_shell.TabIndex = 1;
            this.lst_shell.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lst_shell_DrawItem);
            this.lst_shell.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lst_shell_MeasureItem);
            // 
            // ADBShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 302);
            this.Controls.Add(this.lst_shell);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADBShell";
            this.Text = "ADB Shell";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.TextBox txt_chat_input;
        private System.Windows.Forms.ListBox lst_shell;
    }
}