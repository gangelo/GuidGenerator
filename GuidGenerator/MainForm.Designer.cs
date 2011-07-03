namespace GuidGenerator {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.m_generateGuid = new System.Windows.Forms.Button();
			this.m_guid = new System.Windows.Forms.TextBox();
			this.m_copyToClipboard = new System.Windows.Forms.Button();
			this.m_convertToUppercase = new System.Windows.Forms.CheckBox();
			this.m_close = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// m_generateGuid
			// 
			this.m_generateGuid.Location = new System.Drawing.Point(337, 12);
			this.m_generateGuid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.m_generateGuid.Name = "m_generateGuid";
			this.m_generateGuid.Size = new System.Drawing.Size(153, 28);
			this.m_generateGuid.TabIndex = 0;
			this.m_generateGuid.Text = "Generate GUID";
			this.m_generateGuid.UseVisualStyleBackColor = true;
			this.m_generateGuid.Click += new System.EventHandler(this.OnGenerateGuidClick);
			// 
			// m_guid
			// 
			this.m_guid.Location = new System.Drawing.Point(16, 14);
			this.m_guid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.m_guid.Name = "m_guid";
			this.m_guid.ReadOnly = true;
			this.m_guid.Size = new System.Drawing.Size(312, 22);
			this.m_guid.TabIndex = 1;
			this.m_guid.TextChanged += new System.EventHandler(this.OnTextChanged);
			// 
			// m_copyToClipboard
			// 
			this.m_copyToClipboard.Location = new System.Drawing.Point(337, 48);
			this.m_copyToClipboard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.m_copyToClipboard.Name = "m_copyToClipboard";
			this.m_copyToClipboard.Size = new System.Drawing.Size(153, 28);
			this.m_copyToClipboard.TabIndex = 2;
			this.m_copyToClipboard.Text = "Copy to Clipboard";
			this.m_copyToClipboard.UseVisualStyleBackColor = true;
			this.m_copyToClipboard.Click += new System.EventHandler(this.OnCopyToClipboard);
			// 
			// m_convertToUppercase
			// 
			this.m_convertToUppercase.AutoSize = true;
			this.m_convertToUppercase.Location = new System.Drawing.Point(156, 52);
			this.m_convertToUppercase.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.m_convertToUppercase.Name = "m_convertToUppercase";
			this.m_convertToUppercase.Size = new System.Drawing.Size(168, 21);
			this.m_convertToUppercase.TabIndex = 3;
			this.m_convertToUppercase.Text = "Convert to Uppercase";
			this.m_convertToUppercase.UseVisualStyleBackColor = true;
			this.m_convertToUppercase.CheckedChanged += new System.EventHandler(this.OnCheckChanged);
			// 
			// m_close
			// 
			this.m_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_close.Location = new System.Drawing.Point(337, 101);
			this.m_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.m_close.Name = "m_close";
			this.m_close.Size = new System.Drawing.Size(153, 28);
			this.m_close.TabIndex = 2;
			this.m_close.Text = "Close";
			this.m_close.UseVisualStyleBackColor = true;
			this.m_close.Click += new System.EventHandler(this.OnCloseClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_close;
			this.ClientSize = new System.Drawing.Size(503, 144);
			this.Controls.Add(this.m_convertToUppercase);
			this.Controls.Add(this.m_close);
			this.Controls.Add(this.m_copyToClipboard);
			this.Controls.Add(this.m_guid);
			this.Controls.Add(this.m_generateGuid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Guid Generator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button m_generateGuid;
		private System.Windows.Forms.TextBox m_guid;
		private System.Windows.Forms.Button m_copyToClipboard;
		private System.Windows.Forms.CheckBox m_convertToUppercase;
		private System.Windows.Forms.Button m_close;
	}
}

