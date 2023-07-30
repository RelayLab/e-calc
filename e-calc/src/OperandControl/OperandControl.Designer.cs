namespace e_calc.src
{
    partial class OperandControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OperandGroupbox = new System.Windows.Forms.GroupBox();
            this.OperandTable = new System.Windows.Forms.TableLayoutPanel();
            this.OperandQuantityCombobox = new System.Windows.Forms.ComboBox();
            this.OperandValueTextbox = new System.Windows.Forms.TextBox();
            this.OperandUnitCombobox = new System.Windows.Forms.ComboBox();
            this.OperandGroupbox.SuspendLayout();
            this.OperandTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperandGroupbox
            // 
            this.OperandGroupbox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OperandGroupbox.Controls.Add(this.OperandTable);
            this.OperandGroupbox.Location = new System.Drawing.Point(0, 0);
            this.OperandGroupbox.Margin = new System.Windows.Forms.Padding(5);
            this.OperandGroupbox.Name = "OperandGroupbox";
            this.OperandGroupbox.Padding = new System.Windows.Forms.Padding(5, 20, 5, 5);
            this.OperandGroupbox.Size = new System.Drawing.Size(297, 105);
            this.OperandGroupbox.TabIndex = 4;
            this.OperandGroupbox.TabStop = false;
            this.OperandGroupbox.Text = "Величина 1";
            // 
            // OperandTable
            // 
            this.OperandTable.AutoSize = true;
            this.OperandTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OperandTable.ColumnCount = 2;
            this.OperandTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OperandTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OperandTable.Controls.Add(this.OperandQuantityCombobox, 0, 0);
            this.OperandTable.Controls.Add(this.OperandValueTextbox, 0, 1);
            this.OperandTable.Controls.Add(this.OperandUnitCombobox, 1, 1);
            this.OperandTable.Location = new System.Drawing.Point(5, 20);
            this.OperandTable.Margin = new System.Windows.Forms.Padding(5);
            this.OperandTable.Name = "OperandTable";
            this.OperandTable.RowCount = 2;
            this.OperandTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OperandTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OperandTable.Size = new System.Drawing.Size(287, 76);
            this.OperandTable.TabIndex = 1;
            // 
            // OperandQuantityCombobox
            // 
            this.OperandQuantityCombobox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OperandQuantityCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperandQuantityCombobox.FormattingEnabled = true;
            this.OperandQuantityCombobox.Items.AddRange(new object[] {
            "Напряжение",
            "Ток",
            "Мощность"});
            this.OperandQuantityCombobox.Location = new System.Drawing.Point(5, 5);
            this.OperandQuantityCombobox.Margin = new System.Windows.Forms.Padding(5);
            this.OperandQuantityCombobox.Name = "OperandQuantityCombobox";
            this.OperandQuantityCombobox.Size = new System.Drawing.Size(174, 29);
            this.OperandQuantityCombobox.TabIndex = 1;
            this.OperandQuantityCombobox.SelectedIndexChanged += new System.EventHandler(this.OperandQuantityCombobox_SelectedIndexChanged);
            // 
            // OperandValueTextbox
            // 
            this.OperandValueTextbox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OperandValueTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OperandValueTextbox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.OperandValueTextbox.Location = new System.Drawing.Point(5, 44);
            this.OperandValueTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.OperandValueTextbox.Name = "OperandValueTextbox";
            this.OperandValueTextbox.Size = new System.Drawing.Size(176, 27);
            this.OperandValueTextbox.TabIndex = 2;
            this.OperandValueTextbox.Text = "100";
            // 
            // OperandUnitCombobox
            // 
            this.OperandUnitCombobox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OperandUnitCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OperandUnitCombobox.FormattingEnabled = true;
            this.OperandUnitCombobox.Items.AddRange(new object[] {
            "Напряжение",
            "Ток",
            "Мощность"});
            this.OperandUnitCombobox.Location = new System.Drawing.Point(191, 47);
            this.OperandUnitCombobox.Margin = new System.Windows.Forms.Padding(5);
            this.OperandUnitCombobox.Name = "OperandUnitCombobox";
            this.OperandUnitCombobox.Size = new System.Drawing.Size(91, 29);
            this.OperandUnitCombobox.TabIndex = 1;
            // 
            // OperandControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.OperandGroupbox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OperandControl";
            this.Size = new System.Drawing.Size(302, 110);
            this.OperandGroupbox.ResumeLayout(false);
            this.OperandGroupbox.PerformLayout();
            this.OperandTable.ResumeLayout(false);
            this.OperandTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OperandGroupbox;
        private System.Windows.Forms.TableLayoutPanel OperandTable;
        private System.Windows.Forms.ComboBox OperandQuantityCombobox;
        private System.Windows.Forms.ComboBox OperandUnitCombobox;
        private System.Windows.Forms.TextBox OperandValueTextbox;
    }
}
