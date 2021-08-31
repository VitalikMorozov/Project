namespace Test
{
	partial class Редактор
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.v1 = new System.Windows.Forms.RadioButton();
			this.v2 = new System.Windows.Forms.RadioButton();
			this.v3 = new System.Windows.Forms.RadioButton();
			this.v4 = new System.Windows.Forms.RadioButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.saveT = new System.Windows.Forms.Button();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.hist = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Вопрос = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Вариант1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ответ1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Вариант2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ответ2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Вариант3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ответ3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Вариант4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ответ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.удалить = new System.Windows.Forms.Button();
			this.добавить = new System.Windows.Forms.Button();
			this.сохранить = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.меню = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Z = new System.Windows.Forms.RichTextBox();
			this.r1 = new System.Windows.Forms.RichTextBox();
			this.r2 = new System.Windows.Forms.RichTextBox();
			this.r3 = new System.Windows.Forms.RichTextBox();
			this.r4 = new System.Windows.Forms.RichTextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// v1
			// 
			this.v1.AutoSize = true;
			this.v1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.v1.Location = new System.Drawing.Point(224, 169);
			this.v1.Name = "v1";
			this.v1.Size = new System.Drawing.Size(36, 24);
			this.v1.TabIndex = 1;
			this.v1.TabStop = true;
			this.v1.Text = "1";
			this.v1.UseVisualStyleBackColor = true;
			// 
			// v2
			// 
			this.v2.AutoSize = true;
			this.v2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.v2.Location = new System.Drawing.Point(224, 214);
			this.v2.Name = "v2";
			this.v2.Size = new System.Drawing.Size(36, 24);
			this.v2.TabIndex = 1;
			this.v2.TabStop = true;
			this.v2.Text = "2";
			this.v2.UseVisualStyleBackColor = true;
			// 
			// v3
			// 
			this.v3.AutoSize = true;
			this.v3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.v3.Location = new System.Drawing.Point(224, 259);
			this.v3.Name = "v3";
			this.v3.Size = new System.Drawing.Size(36, 24);
			this.v3.TabIndex = 1;
			this.v3.TabStop = true;
			this.v3.Text = "3";
			this.v3.UseVisualStyleBackColor = true;
			// 
			// v4
			// 
			this.v4.AutoSize = true;
			this.v4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.v4.Location = new System.Drawing.Point(224, 304);
			this.v4.Name = "v4";
			this.v4.Size = new System.Drawing.Size(36, 24);
			this.v4.TabIndex = 1;
			this.v4.TabStop = true;
			this.v4.Text = "4";
			this.v4.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
			this.panel1.Controls.Add(this.saveT);
			this.panel1.Controls.Add(this.dgv);
			this.panel1.Controls.Add(this.удалить);
			this.panel1.Location = new System.Drawing.Point(785, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 360);
			this.panel1.TabIndex = 2;
			// 
			// saveT
			// 
			this.saveT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
			this.saveT.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.saveT.Enabled = false;
			this.saveT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveT.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.saveT.ForeColor = System.Drawing.Color.MediumSpringGreen;
			this.saveT.Location = new System.Drawing.Point(0, 288);
			this.saveT.Margin = new System.Windows.Forms.Padding(5);
			this.saveT.Name = "saveT";
			this.saveT.Size = new System.Drawing.Size(200, 36);
			this.saveT.TabIndex = 5;
			this.saveT.Tag = "1";
			this.saveT.Text = "Сохранить изменения";
			this.saveT.UseVisualStyleBackColor = false;
			this.saveT.Click += new System.EventHandler(this.saveT_Click);
			// 
			// dgv
			// 
			this.dgv.AllowUserToAddRows = false;
			this.dgv.AllowUserToDeleteRows = false;
			this.dgv.AllowUserToResizeColumns = false;
			this.dgv.AllowUserToResizeRows = false;
			this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
			this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hist,
            this.Вопрос,
            this.Вариант1,
            this.Ответ1,
            this.Вариант2,
            this.Ответ2,
            this.Вариант3,
            this.Ответ3,
            this.Вариант4,
            this.Ответ});
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv.DefaultCellStyle = dataGridViewCellStyle4;
			this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgv.Location = new System.Drawing.Point(0, 0);
			this.dgv.MultiSelect = false;
			this.dgv.Name = "dgv";
			this.dgv.ReadOnly = true;
			this.dgv.RowHeadersVisible = false;
			this.dgv.RowHeadersWidth = 50;
			this.dgv.Size = new System.Drawing.Size(200, 316);
			this.dgv.TabIndex = 4;
			this.dgv.CurrentCellChanged += new System.EventHandler(this.dgv_CurrentCellChanged);
			// 
			// hist
			// 
			this.hist.HeaderText = "История";
			this.hist.Name = "hist";
			this.hist.ReadOnly = true;
			// 
			// Вопрос
			// 
			this.Вопрос.HeaderText = "Вопрос";
			this.Вопрос.Name = "Вопрос";
			this.Вопрос.ReadOnly = true;
			this.Вопрос.Visible = false;
			// 
			// Вариант1
			// 
			this.Вариант1.HeaderText = "Вариант1";
			this.Вариант1.Name = "Вариант1";
			this.Вариант1.ReadOnly = true;
			this.Вариант1.Visible = false;
			// 
			// Ответ1
			// 
			this.Ответ1.HeaderText = "Ответ1";
			this.Ответ1.Name = "Ответ1";
			this.Ответ1.ReadOnly = true;
			this.Ответ1.Visible = false;
			// 
			// Вариант2
			// 
			this.Вариант2.HeaderText = "Вариант2";
			this.Вариант2.Name = "Вариант2";
			this.Вариант2.ReadOnly = true;
			this.Вариант2.Visible = false;
			// 
			// Ответ2
			// 
			this.Ответ2.HeaderText = "Ответ2";
			this.Ответ2.Name = "Ответ2";
			this.Ответ2.ReadOnly = true;
			this.Ответ2.Visible = false;
			// 
			// Вариант3
			// 
			this.Вариант3.HeaderText = "Вариант3";
			this.Вариант3.Name = "Вариант3";
			this.Вариант3.ReadOnly = true;
			this.Вариант3.Visible = false;
			// 
			// Ответ3
			// 
			this.Ответ3.HeaderText = "Ответ3";
			this.Ответ3.Name = "Ответ3";
			this.Ответ3.ReadOnly = true;
			this.Ответ3.Visible = false;
			// 
			// Вариант4
			// 
			this.Вариант4.HeaderText = "Вариант4";
			this.Вариант4.Name = "Вариант4";
			this.Вариант4.ReadOnly = true;
			this.Вариант4.Visible = false;
			// 
			// Ответ
			// 
			this.Ответ.HeaderText = "Ответ4";
			this.Ответ.Name = "Ответ";
			this.Ответ.ReadOnly = true;
			this.Ответ.Visible = false;
			// 
			// удалить
			// 
			this.удалить.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
			this.удалить.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.удалить.Enabled = false;
			this.удалить.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.удалить.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.удалить.ForeColor = System.Drawing.Color.MediumSpringGreen;
			this.удалить.Location = new System.Drawing.Point(0, 324);
			this.удалить.Margin = new System.Windows.Forms.Padding(5);
			this.удалить.Name = "удалить";
			this.удалить.Size = new System.Drawing.Size(200, 36);
			this.удалить.TabIndex = 3;
			this.удалить.Tag = "1";
			this.удалить.Text = "Удалить задание";
			this.удалить.UseVisualStyleBackColor = false;
			this.удалить.Click += new System.EventHandler(this.удалить_Click_1);
			// 
			// добавить
			// 
			this.добавить.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
			this.добавить.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.добавить.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.добавить.ForeColor = System.Drawing.Color.MediumSpringGreen;
			this.добавить.Location = new System.Drawing.Point(200, 360);
			this.добавить.Margin = new System.Windows.Forms.Padding(0);
			this.добавить.Name = "добавить";
			this.добавить.Size = new System.Drawing.Size(292, 36);
			this.добавить.TabIndex = 3;
			this.добавить.Text = "Добавить задание";
			this.добавить.UseVisualStyleBackColor = false;
			this.добавить.Click += new System.EventHandler(this.добавить_Click);
			// 
			// сохранить
			// 
			this.сохранить.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
			this.сохранить.Enabled = false;
			this.сохранить.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.сохранить.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.сохранить.ForeColor = System.Drawing.Color.MediumSpringGreen;
			this.сохранить.Location = new System.Drawing.Point(493, 360);
			this.сохранить.Margin = new System.Windows.Forms.Padding(0);
			this.сохранить.Name = "сохранить";
			this.сохранить.Size = new System.Drawing.Size(292, 36);
			this.сохранить.TabIndex = 3;
			this.сохранить.Tag = "";
			this.сохранить.Text = "Сохранить задание";
			this.сохранить.UseVisualStyleBackColor = false;
			this.сохранить.Click += new System.EventHandler(this.сохранить_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
			this.panel3.Controls.Add(this.button2);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.меню);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(200, 360);
			this.panel3.TabIndex = 4;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button2.ForeColor = System.Drawing.Color.SpringGreen;
			this.button2.Location = new System.Drawing.Point(0, 93);
			this.button2.Margin = new System.Windows.Forms.Padding(5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(200, 36);
			this.button2.TabIndex = 3;
			this.button2.Text = "Открыть тест";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.ForeColor = System.Drawing.Color.SpringGreen;
			this.button1.Location = new System.Drawing.Point(0, 139);
			this.button1.Margin = new System.Windows.Forms.Padding(5);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(200, 36);
			this.button1.TabIndex = 3;
			this.button1.Text = "Сохранить тест";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// меню
			// 
			this.меню.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(70)))), ((int)(((byte)(130)))));
			this.меню.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.меню.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.меню.ForeColor = System.Drawing.Color.SpringGreen;
			this.меню.Location = new System.Drawing.Point(0, 47);
			this.меню.Margin = new System.Windows.Forms.Padding(5);
			this.меню.Name = "меню";
			this.меню.Size = new System.Drawing.Size(200, 36);
			this.меню.TabIndex = 3;
			this.меню.Text = "Меню";
			this.меню.UseVisualStyleBackColor = false;
			this.меню.Click += new System.EventHandler(this.меню_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkBlue;
			this.label1.Location = new System.Drawing.Point(268, 134);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(433, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "Заполните и укажите один вариант ответа:";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.DarkBlue;
			this.label2.Location = new System.Drawing.Point(268, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(437, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Опишите задание:";
			// 
			// Z
			// 
			this.Z.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Z.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Z.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Z.Location = new System.Drawing.Point(272, 53);
			this.Z.MaxLength = 100;
			this.Z.Name = "Z";
			this.Z.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
			this.Z.Size = new System.Drawing.Size(433, 61);
			this.Z.TabIndex = 4;
			this.Z.Text = "";
			// 
			// r1
			// 
			this.r1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.r1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r1.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.r1.Location = new System.Drawing.Point(272, 160);
			this.r1.MaxLength = 80;
			this.r1.Name = "r1";
			this.r1.Size = new System.Drawing.Size(433, 40);
			this.r1.TabIndex = 4;
			this.r1.Text = "";
			// 
			// r2
			// 
			this.r2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.r2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r2.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.r2.Location = new System.Drawing.Point(272, 206);
			this.r2.MaxLength = 80;
			this.r2.Name = "r2";
			this.r2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
			this.r2.Size = new System.Drawing.Size(433, 40);
			this.r2.TabIndex = 4;
			this.r2.Text = "";
			// 
			// r3
			// 
			this.r3.BackColor = System.Drawing.Color.WhiteSmoke;
			this.r3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r3.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.r3.Location = new System.Drawing.Point(272, 252);
			this.r3.MaxLength = 80;
			this.r3.Name = "r3";
			this.r3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
			this.r3.Size = new System.Drawing.Size(433, 40);
			this.r3.TabIndex = 4;
			this.r3.Text = "";
			// 
			// r4
			// 
			this.r4.BackColor = System.Drawing.Color.WhiteSmoke;
			this.r4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.r4.Font = new System.Drawing.Font("Segoe UI", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.r4.Location = new System.Drawing.Point(272, 298);
			this.r4.MaxLength = 80;
			this.r4.Name = "r4";
			this.r4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Horizontal;
			this.r4.Size = new System.Drawing.Size(433, 40);
			this.r4.TabIndex = 4;
			this.r4.Text = "";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.AddExtension = false;
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// Редактор
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(240)))));
			this.ClientSize = new System.Drawing.Size(984, 396);
			this.Controls.Add(this.r4);
			this.Controls.Add(this.r3);
			this.Controls.Add(this.r2);
			this.Controls.Add(this.r1);
			this.Controls.Add(this.Z);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.добавить);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.сохранить);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.v4);
			this.Controls.Add(this.v3);
			this.Controls.Add(this.v2);
			this.Controls.Add(this.v1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Редактор";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редактор тестов";
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.RadioButton v1;
		private System.Windows.Forms.RadioButton v2;
		private System.Windows.Forms.RadioButton v3;
		private System.Windows.Forms.RadioButton v4;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button добавить;
		private System.Windows.Forms.Button сохранить;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button меню;
		private System.Windows.Forms.RichTextBox Z;
		private System.Windows.Forms.RichTextBox r1;
		private System.Windows.Forms.RichTextBox r2;
		private System.Windows.Forms.RichTextBox r3;
		private System.Windows.Forms.RichTextBox r4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button удалить;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.DataGridViewTextBoxColumn hist;
		private System.Windows.Forms.DataGridViewTextBoxColumn Вопрос;
		private System.Windows.Forms.DataGridViewTextBoxColumn Вариант1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ответ1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Вариант2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ответ2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Вариант3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ответ3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Вариант4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ответ;
		private System.Windows.Forms.Button saveT;
		private System.Windows.Forms.Button button2;
	}
}