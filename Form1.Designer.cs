partial class Form1
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

    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.listBoxAirplanes = new System.Windows.Forms.ListBox();
            this.textBoxAirplaneName = new System.Windows.Forms.TextBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.numericUpDownRange = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownFuelConsumption = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAddAirplane = new System.Windows.Forms.Button();
            this.buttonRefuel = new System.Windows.Forms.Button();
            this.buttonChooseFont = new System.Windows.Forms.Button();
            this.buttonChooseColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAirplanes
            // 
            this.listBoxAirplanes.FormattingEnabled = true;
            this.listBoxAirplanes.ItemHeight = 25;
            this.listBoxAirplanes.Location = new System.Drawing.Point(279, 61);
            this.listBoxAirplanes.Name = "listBoxAirplanes";
            this.listBoxAirplanes.Size = new System.Drawing.Size(367, 79);
            this.listBoxAirplanes.TabIndex = 0;
            // 
            // textBoxAirplaneName
            // 
            this.textBoxAirplaneName.Location = new System.Drawing.Point(279, 146);
            this.textBoxAirplaneName.Name = "textBoxAirplaneName";
            this.textBoxAirplaneName.Size = new System.Drawing.Size(240, 31);
            this.textBoxAirplaneName.TabIndex = 1;
            this.textBoxAirplaneName.Text = "Введите имя самолета";
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(524, 144);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(121, 33);
            this.comboBoxModel.TabIndex = 2;
            this.comboBoxModel.Text = "Модель самолета";
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // numericUpDownRange
            // 
            this.numericUpDownRange.Location = new System.Drawing.Point(525, 183);
            this.numericUpDownRange.Name = "numericUpDownRange";
            this.numericUpDownRange.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownRange.TabIndex = 3;
            this.numericUpDownRange.Tag = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "диапозон полета";
            // 
            // numericUpDownFuelConsumption
            // 
            this.numericUpDownFuelConsumption.Location = new System.Drawing.Point(526, 220);
            this.numericUpDownFuelConsumption.Name = "numericUpDownFuelConsumption";
            this.numericUpDownFuelConsumption.Size = new System.Drawing.Size(120, 31);
            this.numericUpDownFuelConsumption.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "расход топлива";
            // 
            // buttonAddAirplane
            // 
            this.buttonAddAirplane.Location = new System.Drawing.Point(279, 257);
            this.buttonAddAirplane.Name = "buttonAddAirplane";
            this.buttonAddAirplane.Size = new System.Drawing.Size(210, 33);
            this.buttonAddAirplane.TabIndex = 8;
            this.buttonAddAirplane.Text = "добавить самолет";
            this.buttonAddAirplane.UseVisualStyleBackColor = true;
            this.buttonAddAirplane.Click += new System.EventHandler(this.buttonAddAirplane_Click);
            // 
            // buttonRefuel
            // 
            this.buttonRefuel.Location = new System.Drawing.Point(495, 257);
            this.buttonRefuel.Name = "buttonRefuel";
            this.buttonRefuel.Size = new System.Drawing.Size(151, 33);
            this.buttonRefuel.TabIndex = 9;
            this.buttonRefuel.Text = "заправить \r\n";
            this.buttonRefuel.UseVisualStyleBackColor = true;
            this.buttonRefuel.Click += new System.EventHandler(this.buttonRefuel_Click);
            // 
            // buttonChooseFont
            // 
            this.buttonChooseFont.Location = new System.Drawing.Point(279, 296);
            this.buttonChooseFont.Name = "buttonChooseFont";
            this.buttonChooseFont.Size = new System.Drawing.Size(210, 35);
            this.buttonChooseFont.TabIndex = 10;
            this.buttonChooseFont.Text = "выбрать шрифт";
            this.buttonChooseFont.UseVisualStyleBackColor = true;
            this.buttonChooseFont.Click += new System.EventHandler(this.buttonChooseFont_Click);
            // 
            // buttonChooseColor
            // 
            this.buttonChooseColor.Location = new System.Drawing.Point(495, 296);
            this.buttonChooseColor.Name = "buttonChooseColor";
            this.buttonChooseColor.Size = new System.Drawing.Size(150, 35);
            this.buttonChooseColor.TabIndex = 11;
            this.buttonChooseColor.Text = "цвет\r\n";
            this.buttonChooseColor.UseVisualStyleBackColor = true;
            this.buttonChooseColor.Click += new System.EventHandler(this.buttonChooseColor_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(942, 581);
            this.Controls.Add(this.buttonChooseColor);
            this.Controls.Add(this.buttonChooseFont);
            this.Controls.Add(this.buttonRefuel);
            this.Controls.Add(this.buttonAddAirplane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownFuelConsumption);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.numericUpDownRange);
            this.Controls.Add(this.textBoxAirplaneName);
            this.Controls.Add(this.listBoxAirplanes);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFuelConsumption)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox listBoxAirplanes;
    private System.Windows.Forms.TextBox textBoxAirplaneName;
    private System.Windows.Forms.ComboBox comboBoxModel;
    private System.Windows.Forms.NumericUpDown numericUpDownRange;
    private System.Windows.Forms.NumericUpDown numericUpDownFuelConsumption;
    private System.Windows.Forms.Button buttonAddAirplane;
    private System.Windows.Forms.Button buttonRefuel;
    private System.Windows.Forms.Button buttonChooseFont;
    private System.Windows.Forms.Button buttonChooseColor;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
}
