using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GuidGenerator {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
			Initialize();
		}

		private void Initialize() {
			m_copyToClipboard.Enabled = false;
			m_convertToUppercase.Enabled = false;
		}

		private void OnTextChanged(object sender, EventArgs e) {
			string guidString = m_generateGuid.Text.Trim();
			bool enable = !string.IsNullOrEmpty(guidString);

			m_copyToClipboard.Enabled = enable;
			m_convertToUppercase.Enabled = enable;
		}

		private void OnGenerateGuidClick(object sender, EventArgs e) {
			Guid guid = Guid.NewGuid();
			string guidString = guid.ToString();
			m_guid.Text = m_convertToUppercase.Checked ? guidString.ToUpper() : guidString.ToLower();
		}

		private void OnCopyToClipboard(object sender, EventArgs e) {
			m_guid.SelectAll();
			m_guid.Copy();
			m_guid.SelectionLength = 0;
		}

		private void OnCheckChanged(object sender, EventArgs e) {
			string guidString = m_guid.Text;
			m_guid.Text = m_convertToUppercase.Checked ? guidString.ToUpper() : guidString.ToLower();
		}

		private void OnCloseClick(object sender, EventArgs e) {
			this.Close();
			//Application.Exit();
		}
	};
};
