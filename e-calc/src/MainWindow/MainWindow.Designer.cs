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
            this.ConversionCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ResultQuantityCombobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ResultUnitCombobox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.InfoTextbox = new System.Windows.Forms.RichTextBox();
            this.ResultValueTextbox = new System.Windows.Forms.TextBox();
            this.OperandsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.operandControl2 = new e_calc.src.OperandControl();
            this.operandControl1 = new e_calc.src.OperandControl();
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
            this.MainWindowTable.Controls.Add(this.ConversionCombobox, 0, 1);
            this.MainWindowTable.Controls.Add(this.label2, 0, 2);
            this.MainWindowTable.Controls.Add(this.label5, 0, 4);
            this.MainWindowTable.Controls.Add(this.ResultQuantityCombobox, 0, 5);
            this.MainWindowTable.Controls.Add(this.label8, 0, 6);
            this.MainWindowTable.Controls.Add(this.ResultUnitCombobox, 1, 7);
            this.MainWindowTable.Controls.Add(this.label7, 0, 8);
            this.MainWindowTable.Controls.Add(this.InfoTextbox, 0, 9);
            this.MainWindowTable.Controls.Add(this.ResultValueTextbox, 0, 7);
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
            this.MainWindowTable.Size = new System.Drawing.Size(660, 464);
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
            // ConversionCombobox
            // 
            this.MainWindowTable.SetColumnSpan(this.ConversionCombobox, 2);
            this.ConversionCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ConversionCombobox.FormattingEnabled = true;
            this.ConversionCombobox.Location = new System.Drawing.Point(4, 25);
            this.ConversionCombobox.Margin = new System.Windows.Forms.Padding(4);
            this.ConversionCombobox.Name = "ConversionCombobox";
            this.ConversionCombobox.Size = new System.Drawing.Size(363, 29);
            this.ConversionCombobox.TabIndex = 1;
            this.ConversionCombobox.SelectedIndexChanged += new System.EventHandler(this.ConversionCombobox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.MainWindowTable.SetColumnSpan(this.label2, 2);
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Location = new System.Drawing.Point(4, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
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
            this.label5.Location = new System.Drawing.Point(4, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Найти:";
            // 
            // ResultQuantityCombobox
            // 
            this.MainWindowTable.SetColumnSpan(this.ResultQuantityCombobox, 2);
            this.ResultQuantityCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResultQuantityCombobox.FormattingEnabled = true;
            this.ResultQuantityCombobox.Items.AddRange(new object[] {
            "Напряжение",
            "Ток",
            "Мощность"});
            this.ResultQuantityCombobox.Location = new System.Drawing.Point(5, 236);
            this.ResultQuantityCombobox.Margin = new System.Windows.Forms.Padding(5);
            this.ResultQuantityCombobox.Name = "ResultQuantityCombobox";
            this.ResultQuantityCombobox.Size = new System.Drawing.Size(171, 29);
            this.ResultQuantityCombobox.TabIndex = 1;
            this.ResultQuantityCombobox.SelectedIndexChanged += new System.EventHandler(this.ResultQuantityCombobox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.MainWindowTable.SetColumnSpan(this.label8, 2);
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(4, 275);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ответ:";
            // 
            // ResultUnitCombobox
            // 
            this.ResultUnitCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ResultUnitCombobox.FormattingEnabled = true;
            this.ResultUnitCombobox.Items.AddRange(new object[] {
            "Напряжение",
            "Ток",
            "Мощность"});
            this.ResultUnitCombobox.Location = new System.Drawing.Point(188, 301);
            this.ResultUnitCombobox.Margin = new System.Windows.Forms.Padding(5, 5, 5, 7);
            this.ResultUnitCombobox.Name = "ResultUnitCombobox";
            this.ResultUnitCombobox.Size = new System.Drawing.Size(171, 29);
            this.ResultUnitCombobox.TabIndex = 1;
            this.ResultUnitCombobox.SelectedIndexChanged += new System.EventHandler(this.ResultUnitCombobox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.MainWindowTable.SetColumnSpan(this.label7, 2);
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(4, 337);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "Справка:";
            // 
            // InfoTextbox
            // 
            this.InfoTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.InfoTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainWindowTable.SetColumnSpan(this.InfoTextbox, 2);
            this.InfoTextbox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoTextbox.Location = new System.Drawing.Point(3, 361);
            this.InfoTextbox.Name = "InfoTextbox";
            this.InfoTextbox.ReadOnly = true;
            this.InfoTextbox.Size = new System.Drawing.Size(654, 100);
            this.InfoTextbox.TabIndex = 2;
            this.InfoTextbox.Text = "S = \\/3 U I";
            // 
            // ResultValueTextbox
            // 
            this.ResultValueTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.ResultValueTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultValueTextbox.Location = new System.Drawing.Point(5, 301);
            this.ResultValueTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.ResultValueTextbox.Name = "ResultValueTextbox";
            this.ResultValueTextbox.ReadOnly = true;
            this.ResultValueTextbox.Size = new System.Drawing.Size(173, 27);
            this.ResultValueTextbox.TabIndex = 2;
            this.ResultValueTextbox.Text = "0";
            // 
            // OperandsPanel
            // 
            this.OperandsPanel.AutoSize = true;
            this.OperandsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainWindowTable.SetColumnSpan(this.OperandsPanel, 2);
            this.OperandsPanel.Controls.Add(this.operandControl2);
            this.OperandsPanel.Controls.Add(this.operandControl1);
            this.OperandsPanel.Location = new System.Drawing.Point(3, 87);
            this.OperandsPanel.Name = "OperandsPanel";
            this.OperandsPanel.Size = new System.Drawing.Size(654, 120);
            this.OperandsPanel.TabIndex = 3;
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
            this.operandControl2.Size = new System.Drawing.Size(317, 110);
            this.operandControl2.TabIndex = 1;
            // 
            // operandControl1
            // 
            this.operandControl1.AutoSize = true;
            this.operandControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.operandControl1.BackColor = System.Drawing.SystemColors.Window;
            this.operandControl1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.operandControl1.Location = new System.Drawing.Point(332, 5);
            this.operandControl1.Margin = new System.Windows.Forms.Padding(5);
            this.operandControl1.Name = "operandControl1";
            this.operandControl1.Size = new System.Drawing.Size(317, 110);
            this.operandControl1.TabIndex = 0;
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
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
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
        private System.Windows.Forms.ComboBox ResultQuantityCombobox;
        private System.Windows.Forms.ComboBox ConversionCombobox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox InfoTextbox;
        private System.Windows.Forms.ComboBox ResultUnitCombobox;
        private System.Windows.Forms.TextBox ResultValueTextbox;
        private System.Windows.Forms.FlowLayoutPanel OperandsPanel;
        private src.OperandControl operandControl2;
        private src.OperandControl operandControl1;
    }
}

