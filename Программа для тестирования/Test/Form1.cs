using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Test
{
	public partial class Тест : Form
	{
		public Тест()
		{
			InitializeComponent();

			Size = new Size(400, 230);

			string[] s = File.ReadAllLines(repos.fName, Encoding.UTF8);

			string[] вопросы = new string[s.Length / 9];
			string[,] варианты = new string[вопросы.Length, 4];
			int[] ответы = new int[вопросы.Length];
			int[] myОтветы = new int[вопросы.Length];
			int count = 0;
			int ind = 2;
			int len = 1;

			next.Click += nextClick;

			for (int i = 1; i < s.Length / 9; i++) {
				вопросы[i] = s[ind-1];
				for (int j = 0; j < 4; j++) {
					варианты[i, j] = s[ind];

					if (s[ind + 1] == "1" & j == 0) ответы[i] = j + 1;
					if (s[ind + 1] == "1" & j == 1) ответы[i] = j + 1;
					if (s[ind + 1] == "1" & j == 2) ответы[i] = j + 1;
					if (s[ind + 1] == "1" & j == 3) ответы[i] = j + 1;

					ind += 2;
				}
				ind++;
			}

			progress.Text = len.ToString() + " / " + (вопросы.Length-1).ToString();
			вопрос.Text = вопросы[1].ToString();

			v1.Text = варианты[1, 0].ToString();
			v2.Text = варианты[1, 1].ToString();
			v3.Text = варианты[1, 2].ToString();
			v4.Text = варианты[1, 3].ToString();
			
			// зафиксировать ответ
			void принятьОтвет()
			{
				if (v1.Checked == true) myОтветы[len] = 1;
				if (v2.Checked == true) myОтветы[len] = 2;
				if (v3.Checked == true) myОтветы[len] = 3;
				if (v4.Checked == true) myОтветы[len] = 4;

				if (myОтветы[len] == ответы[len]) count++; //MessageBox.Show("верно");
														   //else MessageBox.Show("неверно");
			}

			// сбросить выбор ответа
			void сброс()
			{
				v1.Checked = false;
				v2.Checked = false;
				v3.Checked = false;
				v4.Checked = false;
				next.Enabled = false;
			}
			
			// далее
			void nextClick(object sender, EventArgs e) {

				принятьОтвет(); 
				len++;

				if (len == вопросы.Length)
				{
					len = вопросы.Length - 1;

					Size = new Size(РезультатТеста.Size.Width, РезультатТеста.Size.Height + 30);
					float 
						newCount = count, // верных ответов дано 
						newLen = len;	  // всего вопросов

					РезультатТеста.Visible = true;
					border.Text = "Результаты тестирования (" + userName.Text + ")";
					right.Text = "Правильных ответов: " + newCount + " из " + newLen;
					result.Text = "Результативность: " + String.Format("{0:0.0}", (newCount / newLen) * 100) + "%";
					note.Text = "Ваша оценка: " + String.Format("{0:0}", (newCount / newLen) * 10);
				}

				progress.Text = len.ToString() + " / " + (вопросы.Length - 1).ToString();
				вопрос.Text = вопросы[len].ToString();

				v1.Text = варианты[len, 0].ToString();
				v2.Text = варианты[len, 1].ToString();
				v3.Text = варианты[len, 2].ToString();
				v4.Text = варианты[len, 3].ToString();

				сброс();
			}
		}

		private void v1_CheckedChanged(object sender, EventArgs e) {
			next.Enabled = true;
		}

		private void v2_CheckedChanged(object sender, EventArgs e) {
			next.Enabled = true;
		}

		private void v3_CheckedChanged(object sender, EventArgs e) {
			next.Enabled = true;
		}

		private void v4_CheckedChanged(object sender, EventArgs e) {
			next.Enabled = true;
		}

		private void start_Click(object sender, EventArgs e)
		{
			startPanel.Visible = false;
			Size = new Size(670, 400);
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			if (userName.Text != "")
				start.Enabled = true;
			else start.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Главная главная = new Главная();
			главная.Show();
			Close();
		}
	}
}
