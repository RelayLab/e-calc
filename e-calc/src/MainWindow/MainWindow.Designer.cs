namespace e_calc
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainWindowTable = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.OperandsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.operandControl1 = new e_calc.src.OperandControl();
            this.operandControl2 = new e_calc.src.OperandControl();
            this.MainWindowTable.SuspendLayout();
            this.OperandsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainWindowTable
            // 
            this.MainWindowTable.AutoSize = true;
            this.MainWindowTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainWindowTable.ColumnCount = 2;
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainWindowTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainWindowTable.Controls.Add(this.label1, 0, 0);
            this.MainWindowTable.Controls.Add(this.TaskCombobox, 0, 1);
            this.MainWindowTable.Controls.Add(this.label2, 0, 2);
            this.MainWindowTable.Controls.Add(this.label5, 0, 4);
            this.MainWindowTable.Controls.Add(this.comboBox6, 0, 5);
            this.MainWindowTable.Controls.Add(this.label8, 0, 6);
            this.MainWindowTable.Controls.Add(this.comboBox9, 1, 7);
            this.MainWindowTable.Controls.Add(this.label7, 0, 8);
            this.MainWindowTable.Controls.Add(this.richTextBox1, 0, 9);
            this.MainWindowTable.Controls.Add(this.textBox2, 0, 7);
            this.MainWindowTable.Controls.Add(this.OperandsPanel, 0, 3);
            this.MainWindowTable.Location = new System.Drawing.Point(5, 5);
            this.MainWindowTable.Margin = new System.Windows.Forms.Padding(4);
            this.MainWindowTable.Name = "MainWindowTable";
            this.MainWindowTable.RowCount = 10;
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainWindowTable.Size = new System.Drawing.Size(1268, 409);
            this.MainWindowTable.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.MainWindowTable.SetColumnSpan(this.label1, 2);
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Что преобразовываем?";
            // 
            // TaskCombobox
            // 
            this.MainWindowTable.SetColumnSpan(this.TaskCombobox, 2);
            this.TaskCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskCombobox.FormattingEnabled = true;
            this.TaskCombobox.Location = new System.Drawing.Point(4, 25);
            this.TaskCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.TaskCombobox.Name = "TaskCombobox";
            this.TaskCombobox.Size = new System.Drawing.Size(363, 29);
            this.TaskCombobox.TabIndex = 1;
            this.TaskCombobox.SelectedIndexChanged += new System.EventHandler(this.TaskCombobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.MainWindowTable.SetColumnSpan(this.label2, 2);
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Дано:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.MainWindowTable.SetColumnSpan(this.label5, 2);
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Location = new System.Drawing.Point(4, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Найти:";
            // 
            // comboBox6
            // 
            this.MainWindowTable.SetColumnSpan(this.comboBox6, 2);
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "Напряжение",
            "Ток",
            "Мощность"});
            this.comboBox6.Location = new System.Drawing.Point(4, 277);
            this.comboBox6.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(171, 29);
            this.comboBox6.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.MainWindowTable.SetColumnSpan(this.label8, 2);
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(4, 310);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ответ:";
            // 
            // comboBox9
            // 
            this.comboBox9.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Items.AddRange(new object[] {
            "Напряжение",
            "Ток",
            "Мощность"});
            this.comboBox9.Location = new System.Drawing.Point(183, 335);
            this.comboBox9.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(171, 29);
            this.comboBox9.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.MainWindowTable.SetColumnSpan(this.label7, 2);
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(4, 368);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Формула";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainWindowTable.SetColumnSpan(this.richTextBox1, 2);
            this.richTextBox1.Location = new System.Drawing.Point(3, 392);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(100, 14);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "S = \\/3 U I";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(3, 334);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 27);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "100";
            // 
            // OperandsPanel
            // 
            this.OperandsPanel.AutoSize = true;
            this.OperandsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainWindowTable.SetColumnSpan(this.OperandsPanel, 2);
            this.OperandsPanel.Controls.Add(this.operandControl2);
            this.OperandsPanel.Controls.Add(this.operandControl1);
            this.OperandsPanel.Location = new System.Drawing.Point(3, 82);
            this.OperandsPanel.Name = "OperandsPanel";
            this.OperandsPanel.Size = new System.Drawing.Size(1262, 167);
            this.OperandsPanel.TabIndex = 3;
            // 
            // operandControl1
            // 
            this.operandControl1.AutoSize = true;
            this.operandControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.operandControl1.BackColor = System.Drawing.SystemColors.Window;
            this.operandControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandControl1.Location = new System.Drawing.Point(636, 5);
            this.operandControl1.Margin = new System.Windows.Forms.Padding(5);
            this.operandControl1.Name = "operandControl1";
            this.operandControl1.Size = new System.Drawing.Size(621, 157);
            this.operandControl1.TabIndex = 0;
            // 
            // operandControl2
            // 
            this.operandControl2.AutoSize = true;
            this.operandControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.operandControl2.BackColor = System.Drawing.SystemColors.Window;
            this.operandControl2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandControl2.Location = new System.Drawing.Point(5, 5);
            this.operandControl2.Margin = new System.Windows.Forms.Padding(5);
            this.operandControl2.Name = "operandControl2";
            this.operandControl2.Size = new System.Drawing.Size(621, 157);
            this.operandControl2.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.MainWindowTable);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "MainWindow";
            this.Text = "e-calc - ЭнергоКалькулятор";
            this.MainWindowTable.ResumeLayout(false);
            this.MainWindowTable.PerformLayout();
            this.OperandsPanel.ResumeLayout(false);
            this.OperandsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainWindowTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox TaskCombobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.FlowLayoutPanel OperandsPanel;
        private src.OperandControl operandControl2;
        private src.OperandControl operandControl1;
    }
}

