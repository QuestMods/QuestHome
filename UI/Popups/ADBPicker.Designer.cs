namespace QuestHome.UI
{
    partial class ADBPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADBPicker));
            this.label1 = new System.Windows.Forms.Label();
            this.lst_found = new System.Windows.Forms.ListBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_custom = new System.Windows.Forms.Button();
            this.txt_selected = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(555, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADB Path not specified! Please select one of the available ADB binaries below or " +
    "click on \"Custom\" to set your own.";
            // 
            // lst_found
            // 
            this.lst_found.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lst_found.FormattingEnabled = true;
            this.lst_found.Location = new System.Drawing.Point(15, 41);
            this.lst_found.Name = "lst_found";
            this.lst_found.Size = new System.Drawing.Size(752, 381);
            this.lst_found.TabIndex = 1;
            this.lst_found.SelectedIndexChanged += new System.EventHandler(this.lst_found_SelectedIndexChanged);
            // 
            // btn_apply
            // 
            this.btn_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_apply.Location = new System.Drawing.Point(692, 430);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_custom
            // 
            this.btn_custom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_custom.Location = new System.Drawing.Point(15, 430);
            this.btn_custom.Name = "btn_custom";
            this.btn_custom.Size = new System.Drawing.Size(75, 23);
            this.btn_custom.TabIndex = 3;
            this.btn_custom.Text = "Custom";
            this.btn_custom.UseVisualStyleBackColor = true;
            this.btn_custom.Click += new System.EventHandler(this.btn_custom_Click);
            // 
            // txt_selected
            // 
            this.txt_selected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_selected.Location = new System.Drawing.Point(96, 432);
            this.txt_selected.Name = "txt_selected";
            this.txt_selected.Size = new System.Drawing.Size(590, 20);
            this.txt_selected.TabIndex = 4;
            // 
            // ADBPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 464);
            this.Controls.Add(this.txt_selected);
            this.Controls.Add(this.btn_custom);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.lst_found);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ADBPicker";
            this.Text = "Quest Home - Select ADB to use";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ADBPicker_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_found;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_custom;
        private System.Windows.Forms.TextBox txt_selected;
    }
}