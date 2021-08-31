using System;
using System.Text;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

namespace Test
{
	public partial class Редактор : Form
	{
		public Редактор()
		{
			InitializeComponent();
			сброс();
			запретВвода();
		}

		private void меню_Click(object sender, EventArgs e)
		{
			Главная главная = new Главная();
			главная.Show();
			Close();
		}

		// Добавить задание
		private void добавить_Click(object sender, EventArgs e)
		{
			if (dgv.RowCount == 10)
				MessageBox.Show("Разрешено не более 10 заданий!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			else
			{
				dgv.Rows.Add($"Задание {dgv.RowCount + 1}");
				разрешениеВвода();
				добавить.Enabled = false;
				сохранить.Enabled = true;
				saveT.Enabled = false;
				удалить.Enabled = false;
			}
		}

		// Сохранить задание
		private void сохранить_Click(object sender, EventArgs e) {
			try {
				if (проверка())
					MessageBox.Show("Задание и варианты ответа не должны быть пусты. Должен быть выбран один вариант ответа.",
									"Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				else {
					запретВвода();
					добавить.Enabled = true;
					сохранить.Enabled = false;
					saveT.Enabled = false;
					удалить.Enabled = false;

					string
						chek1 = "0",
						chek2 = "0",
						chek3 = "0",
						chek4 = "0";

					if (v1.Checked == true) chek1 = "1";
					if (v2.Checked == true) chek2 = "1";
					if (v3.Checked == true) chek3 = "1";
					if (v4.Checked == true) chek4 = "1";

					dgv.Rows[dgv.RowCount - 1].Cells[1].Value = Z.Text;
					dgv.Rows[dgv.RowCount - 1].Cells[2].Value = r1.Text;
					dgv.Rows[dgv.RowCount - 1].Cells[3].Value = chek1;
					dgv.Rows[dgv.RowCount - 1].Cells[4].Value = r2.Text;
					dgv.Rows[dgv.RowCount - 1].Cells[5].Value = chek2;
					dgv.Rows[dgv.RowCount - 1].Cells[6].Value = r3.Text;
					dgv.Rows[dgv.RowCount - 1].Cells[7].Value = chek3;
					dgv.Rows[dgv.RowCount - 1].Cells[8].Value = r4.Text;
					dgv.Rows[dgv.RowCount - 1].Cells[9].Value = chek4;

					добавить.Enabled = true;
					сброс();
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// сбросить выбор ответа
		void сброс() {
			v1.Checked = false;
			v2.Checked = false;
			v3.Checked = false;
			v4.Checked = false;
			Z.Text = "";
			r1.Text = "";
			r2.Text = "";
			r3.Text = "";
			r4.Text = "";
		}

		void запретВвода() {
			Z.Enabled = false;
			r1.Enabled = false;
			r2.Enabled = false;
			r3.Enabled = false;
			r4.Enabled = false;
		}

		void разрешениеВвода()
		{
			Z.Enabled = true;
			r1.Enabled = true;
			r2.Enabled = true;
			r3.Enabled = true;
			r4.Enabled = true;
		}

		bool пустаяТаблица() {
			if (dgv.RowCount == 0)
				return true;
			return false;
		}

		// Проверка заполнения сведений вопроса
		bool проверка() {
			if (Z.Text == "" || r1.Text == "" || r1.Text == ""
							 || r3.Text == "" || r4.Text == "")
				return true;
			if (v1.Checked == false & v2.Checked == false &
				v3.Checked == false & v4.Checked == false)
				return true;
			else return false;
		}

		// окно сохранения теста
		private void button1_Click(object sender, EventArgs e){
			saveFileDialog1.ShowDialog();
		}

		// сохранение данных из списка в файл
		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) {
			StreamWriter stream;
			FileInfo file = new FileInfo(saveFileDialog1.FileName);
			stream = file.AppendText();

			try {
				stream.WriteLine($"всего {dgv.ColumnCount} вопроса");

				for (int i = 0; i < dgv.RowCount; i++)
					for (int j = 1; j < dgv.ColumnCount; j++)
						stream.WriteLine(dgv.Rows[i].Cells[j].Value);
				stream.Close();
				MessageBox.Show($"Данные сохранены в файле {saveFileDialog1.FileName}", "Сохранение теста", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public static bool flag = true;

		// Выбор задания
		private void dgv_CurrentCellChanged(object sender, EventArgs e) {
			try {
				удалить.Enabled = true;
				saveT.Enabled = true;
				разрешениеВвода();

				Z.Text = dgv.CurrentRow.Cells[1].Value.ToString();
				r1.Text = dgv.CurrentRow.Cells[2].Value.ToString();
				r2.Text = dgv.CurrentRow.Cells[4].Value.ToString();
				r3.Text = dgv.CurrentRow.Cells[6].Value.ToString();
				r4.Text = dgv.CurrentRow.Cells[8].Value.ToString();

				if (dgv.CurrentRow.Cells[3].Value.ToString() == "1") v1.Checked = true;
				else v1.Checked = false;

				if (dgv.CurrentRow.Cells[5].Value.ToString() == "1") v2.Checked = true;
				else v2.Checked = false;

				if (dgv.CurrentRow.Cells[7].Value.ToString() == "1") v3.Checked = true;
				else v3.Checked = false;

				if (dgv.CurrentRow.Cells[9].Value.ToString() == "1") v4.Checked = true;
				else v4.Checked = false;
			}
			catch (Exception ex) { }
		}

		// Удалить задание
		private void удалить_Click_1(object sender, EventArgs e) {
			try {
				dgv.Rows.Remove(dgv.CurrentRow);

				if (пустаяТаблица()) {
					удалить.Enabled = false;
					saveT.Enabled = false;
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Сохранить изменения
		private void saveT_Click(object sender, EventArgs e)
		{
			try {
				string
					chek1 = "0",
					chek2 = "0",
					chek3 = "0",
					chek4 = "0";

				if (v1.Checked == true) chek1 = "1";
				if (v2.Checked == true) chek2 = "1";
				if (v3.Checked == true) chek3 = "1";
				if (v4.Checked == true) chek4 = "1";

				dgv.CurrentRow.Cells[1].Value = Z.Text;
				dgv.CurrentRow.Cells[2].Value = r1.Text;
				dgv.CurrentRow.Cells[3].Value = chek1;
				dgv.CurrentRow.Cells[4].Value = r2.Text;
				dgv.CurrentRow.Cells[5].Value = chek2;
				dgv.CurrentRow.Cells[6].Value = r3.Text;
				dgv.CurrentRow.Cells[7].Value = chek3;
				dgv.CurrentRow.Cells[8].Value = r4.Text;
				dgv.CurrentRow.Cells[9].Value = chek4;

				if (пустаяТаблица()) {
					удалить.Enabled = false;
					saveT.Enabled = false;
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		// Открыть тест
		private void button2_Click(object sender, EventArgs e)
		{
			try {
				openFileDialog1.ShowDialog();

				dgv.Rows.Clear();
				var stream = File.ReadAllLines(openFileDialog1.FileName, Encoding.UTF8);
				int ind = 1;

				for (int i = 0; i < stream.Length / 9; i++) {
					dgv.Rows.Add($"Задание {i + 1}");
					for (int j = 1; j < dgv.ColumnCount; j++) {
						dgv.Rows[i].Cells[j].Value = stream[ind];
						ind++;
					}
				}
			}
			catch (Exception ex) {
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}