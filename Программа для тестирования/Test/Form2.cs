using System;
using System.Windows.Forms;

namespace Test
{
	public partial class Главная : Form
	{
		public Главная()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			repos.fName = "C# тестирование.txt";
			Тест form1 = new Тест();
			form1.Show();
			Hide();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Редактор редактор = new Редактор();
			редактор.Show();
			Hide();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			repos.fName = openFileDialog1.FileName;

			Тест тест = new Тест();
			тест.Show();
			Hide();
		}
	}
}
