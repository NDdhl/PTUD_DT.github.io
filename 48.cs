using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _48_24
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void cboNgoaiNgu_DropDown(object sender, EventArgs e)
		{
			string[] datas = { "Tiếng Anh", "Tiếng Pháp", "Tiếng Nhật" };
			this.cboNgoaiNgu.DataSource = datas;
		}

		private void cboNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
		{
			MessageBox.Show(this.cboNgoaiNgu.SelectedItem.ToString());
		}
	}
}
