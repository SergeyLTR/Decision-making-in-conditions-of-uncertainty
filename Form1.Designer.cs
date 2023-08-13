
namespace Decision_making_in_conditions_of_uncertainty
{
    partial class App
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Alfa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.ButtonCalc = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GurvicAlt = new System.Windows.Forms.TextBox();
            this.GurvicKrit = new System.Windows.Forms.TextBox();
            this.SAlt = new System.Windows.Forms.TextBox();
            this.SKrit = new System.Windows.Forms.TextBox();
            this.ValdAlt = new System.Windows.Forms.TextBox();
            this.LaplasALT = new System.Windows.Forms.TextBox();
            this.LaplasСriteria = new System.Windows.Forms.TextBox();
            this.ValdKrit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButtonLose = new System.Windows.Forms.RadioButton();
            this.radioButtonWin = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.S1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.S1,
            this.S2,
            this.S3,
            this.S4,
            this.S5,
            this.S6,
            this.S7,
            this.S8,
            this.S9,
            this.S10});
            this.dataGridView.Location = new System.Drawing.Point(5, 215);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView.Size = new System.Drawing.Size(1085, 438);
            this.dataGridView.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Alfa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkedListBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Критерии";
            // 
            // Alfa
            // 
            this.Alfa.Location = new System.Drawing.Point(128, 56);
            this.Alfa.Name = "Alfa";
            this.Alfa.Size = new System.Drawing.Size(100, 22);
            this.Alfa.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Параметр Альфа";
            // 
            // checkedListBox
            // 
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Лапласа",
            "Минимакса",
            "Сэвиджа",
            "Гурвица"});
            this.checkedListBox.Location = new System.Drawing.Point(6, 23);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(116, 89);
            this.checkedListBox.TabIndex = 4;
            // 
            // ButtonCalc
            // 
            this.ButtonCalc.Location = new System.Drawing.Point(639, 139);
            this.ButtonCalc.Name = "ButtonCalc";
            this.ButtonCalc.Size = new System.Drawing.Size(191, 36);
            this.ButtonCalc.TabIndex = 7;
            this.ButtonCalc.Text = "Расчет";
            this.ButtonCalc.UseVisualStyleBackColor = true;
            this.ButtonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GurvicAlt);
            this.groupBox2.Controls.Add(this.GurvicKrit);
            this.groupBox2.Controls.Add(this.SAlt);
            this.groupBox2.Controls.Add(this.SKrit);
            this.groupBox2.Controls.Add(this.ValdAlt);
            this.groupBox2.Controls.Add(this.LaplasALT);
            this.groupBox2.Controls.Add(this.LaplasСriteria);
            this.groupBox2.Controls.Add(this.ValdKrit);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(266, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(564, 121);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты";
            // 
            // GurvicAlt
            // 
            this.GurvicAlt.Location = new System.Drawing.Point(474, 72);
            this.GurvicAlt.Name = "GurvicAlt";
            this.GurvicAlt.ReadOnly = true;
            this.GurvicAlt.Size = new System.Drawing.Size(79, 22);
            this.GurvicAlt.TabIndex = 14;
            // 
            // GurvicKrit
            // 
            this.GurvicKrit.Location = new System.Drawing.Point(474, 44);
            this.GurvicKrit.Name = "GurvicKrit";
            this.GurvicKrit.ReadOnly = true;
            this.GurvicKrit.Size = new System.Drawing.Size(79, 22);
            this.GurvicKrit.TabIndex = 13;
            // 
            // SAlt
            // 
            this.SAlt.Location = new System.Drawing.Point(389, 74);
            this.SAlt.Name = "SAlt";
            this.SAlt.ReadOnly = true;
            this.SAlt.Size = new System.Drawing.Size(79, 22);
            this.SAlt.TabIndex = 12;
            // 
            // SKrit
            // 
            this.SKrit.Location = new System.Drawing.Point(389, 43);
            this.SKrit.Name = "SKrit";
            this.SKrit.ReadOnly = true;
            this.SKrit.Size = new System.Drawing.Size(79, 22);
            this.SKrit.TabIndex = 11;
            // 
            // ValdAlt
            // 
            this.ValdAlt.Location = new System.Drawing.Point(304, 74);
            this.ValdAlt.Name = "ValdAlt";
            this.ValdAlt.ReadOnly = true;
            this.ValdAlt.Size = new System.Drawing.Size(79, 22);
            this.ValdAlt.TabIndex = 10;
            // 
            // LaplasALT
            // 
            this.LaplasALT.Location = new System.Drawing.Point(219, 74);
            this.LaplasALT.Name = "LaplasALT";
            this.LaplasALT.ReadOnly = true;
            this.LaplasALT.Size = new System.Drawing.Size(79, 22);
            this.LaplasALT.TabIndex = 9;
            // 
            // LaplasСriteria
            // 
            this.LaplasСriteria.Location = new System.Drawing.Point(219, 43);
            this.LaplasСriteria.Name = "LaplasСriteria";
            this.LaplasСriteria.ReadOnly = true;
            this.LaplasСriteria.Size = new System.Drawing.Size(79, 22);
            this.LaplasСriteria.TabIndex = 8;
            // 
            // ValdKrit
            // 
            this.ValdKrit.Location = new System.Drawing.Point(304, 44);
            this.ValdKrit.Name = "ValdKrit";
            this.ValdKrit.ReadOnly = true;
            this.ValdKrit.Size = new System.Drawing.Size(79, 22);
            this.ValdKrit.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Гурвица";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Сэвиджа";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Минимакса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Оптимальная альтернатива";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Значение критерия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Лаплас";
            // 
            // radioButtonLose
            // 
            this.radioButtonLose.AutoSize = true;
            this.radioButtonLose.Location = new System.Drawing.Point(6, 43);
            this.radioButtonLose.Name = "radioButtonLose";
            this.radioButtonLose.Size = new System.Drawing.Size(113, 21);
            this.radioButtonLose.TabIndex = 9;
            this.radioButtonLose.TabStop = true;
            this.radioButtonLose.Text = "Проигрышей";
            this.radioButtonLose.UseVisualStyleBackColor = true;
            // 
            // radioButtonWin
            // 
            this.radioButtonWin.AutoSize = true;
            this.radioButtonWin.Location = new System.Drawing.Point(6, 21);
            this.radioButtonWin.Name = "radioButtonWin";
            this.radioButtonWin.Size = new System.Drawing.Size(106, 21);
            this.radioButtonWin.TabIndex = 10;
            this.radioButtonWin.TabStop = true;
            this.radioButtonWin.Text = "Выигрышей";
            this.radioButtonWin.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonWin);
            this.groupBox3.Controls.Add(this.radioButtonLose);
            this.groupBox3.Location = new System.Drawing.Point(29, 139);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(211, 70);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Выбор матрицы";
            // 
            // S1
            // 
            this.S1.HeaderText = "S1";
            this.S1.MinimumWidth = 6;
            this.S1.Name = "S1";
            this.S1.Width = 75;
            // 
            // S2
            // 
            this.S2.HeaderText = "S2";
            this.S2.MinimumWidth = 6;
            this.S2.Name = "S2";
            this.S2.Width = 75;
            // 
            // S3
            // 
            this.S3.HeaderText = "S3";
            this.S3.MinimumWidth = 6;
            this.S3.Name = "S3";
            this.S3.Width = 75;
            // 
            // S4
            // 
            this.S4.HeaderText = "S4";
            this.S4.MinimumWidth = 6;
            this.S4.Name = "S4";
            this.S4.Width = 75;
            // 
            // S5
            // 
            this.S5.HeaderText = "S5";
            this.S5.MinimumWidth = 6;
            this.S5.Name = "S5";
            this.S5.Width = 75;
            // 
            // S6
            // 
            this.S6.HeaderText = "S6";
            this.S6.MinimumWidth = 6;
            this.S6.Name = "S6";
            this.S6.Width = 75;
            // 
            // S7
            // 
            this.S7.HeaderText = "S7";
            this.S7.MinimumWidth = 6;
            this.S7.Name = "S7";
            this.S7.Width = 75;
            // 
            // S8
            // 
            this.S8.HeaderText = "S8";
            this.S8.MinimumWidth = 6;
            this.S8.Name = "S8";
            this.S8.Width = 75;
            // 
            // S9
            // 
            this.S9.HeaderText = "S9";
            this.S9.MinimumWidth = 6;
            this.S9.Name = "S9";
            this.S9.Width = 75;
            // 
            // S10
            // 
            this.S10.HeaderText = "S10";
            this.S10.MinimumWidth = 6;
            this.S10.Name = "S10";
            this.S10.Width = 40;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 665);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ButtonCalc);
            this.Controls.Add(this.groupBox1);
            this.Name = "App";
            this.Text = "Расчет критериев для принятия решений в условиях неопределенности";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Alfa;
        private System.Windows.Forms.Button ButtonCalc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LaplasALT;
        private System.Windows.Forms.TextBox LaplasСriteria;
        private System.Windows.Forms.TextBox ValdKrit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GurvicKrit;
        private System.Windows.Forms.TextBox SAlt;
        private System.Windows.Forms.TextBox SKrit;
        private System.Windows.Forms.TextBox ValdAlt;
        private System.Windows.Forms.TextBox GurvicAlt;
        private System.Windows.Forms.RadioButton radioButtonLose;
        private System.Windows.Forms.RadioButton radioButtonWin;
        private System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn S1;
        private System.Windows.Forms.DataGridViewTextBoxColumn S2;
        private System.Windows.Forms.DataGridViewTextBoxColumn S3;
        private System.Windows.Forms.DataGridViewTextBoxColumn S4;
        private System.Windows.Forms.DataGridViewTextBoxColumn S5;
        private System.Windows.Forms.DataGridViewTextBoxColumn S6;
        private System.Windows.Forms.DataGridViewTextBoxColumn S7;
        private System.Windows.Forms.DataGridViewTextBoxColumn S8;
        private System.Windows.Forms.DataGridViewTextBoxColumn S9;
        private System.Windows.Forms.DataGridViewTextBoxColumn S10;
    }
}

