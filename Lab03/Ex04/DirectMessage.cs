using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab03.Ex04
{
	public partial class DirectMessage : Form
	{
		public DirectMessage(string userName)
		{
			InitializeComponent();
			Text = userName;
		}
	}
}
