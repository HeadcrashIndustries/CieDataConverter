using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CieDataConverter
{
	public partial class Form1 : Form
	{
		public Form1( )
		{
			InitializeComponent();
		}

		private void button1_Click( object sender, EventArgs e )
		{
			foreach (var line in textBox1.Lines)
			{
				if (!string.IsNullOrEmpty(line))
				{
					string[] cells = line.Split(new char[] { ',' });
					int nm = int.Parse(cells[0]);
					double[] values = new double[11];

					for (int i = 1; i < 11; ++i)
					{
						if (string.IsNullOrEmpty(cells[i]))
						{
							cells[i] = "0.0";
						}

						values[i] = double.Parse(cells[i]);
					}

					textBoxCieA.Text += "{ " + nm.ToString() + ", " + values[1].ToString("F6") + " }," + Environment.NewLine;
					textBoxCieD65.Text += "{ " + nm.ToString() + ", " + values[2].ToString("F5") + " }," + Environment.NewLine;
					textBoxCie2Obs.Text += "{ " + nm.ToString() + ", " + values[5].ToString("F12") + ", " + values[6].ToString("F12") + ", " + values[7].ToString("F12") + " }," + Environment.NewLine;
					textBoxCie10Obs.Text += "{ " + nm.ToString() + ", " + values[8].ToString("F12") + ", " + values[9].ToString("F12") + ", " + values[10].ToString("F12") + " }," + Environment.NewLine;
				}
			}
		}
	}
}
