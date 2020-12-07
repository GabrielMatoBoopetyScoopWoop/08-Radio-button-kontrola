namespace _08_Radio_button_kontrola
{
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OdabiriPrijevoza = new System.Windows.Forms.GroupBox();
            this.AvionRadio = new System.Windows.Forms.RadioButton();
            this.AutobusRadio = new System.Windows.Forms.RadioButton();
            this.VlastitiPrijevozRadio = new System.Windows.Forms.RadioButton();
            this.RezervirajButton = new System.Windows.Forms.Button();
            this.TextKutija = new System.Windows.Forms.TextBox();
            this.OdabiriPrijevoza.SuspendLayout();
            this.SuspendLayout();
            // 
            // OdabiriPrijevoza
            // 
            this.OdabiriPrijevoza.Controls.Add(this.VlastitiPrijevozRadio);
            this.OdabiriPrijevoza.Controls.Add(this.AutobusRadio);
            this.OdabiriPrijevoza.Controls.Add(this.AvionRadio);
            this.OdabiriPrijevoza.Location = new System.Drawing.Point(258, 72);
            this.OdabiriPrijevoza.Name = "OdabiriPrijevoza";
            this.OdabiriPrijevoza.Size = new System.Drawing.Size(263, 198);
            this.OdabiriPrijevoza.TabIndex = 0;
            this.OdabiriPrijevoza.TabStop = false;
            this.OdabiriPrijevoza.Text = "Odaberite vrstu prijevoza";
            this.OdabiriPrijevoza.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // AvionRadio
            // 
            this.AvionRadio.AutoSize = true;
            this.AvionRadio.Location = new System.Drawing.Point(59, 49);
            this.AvionRadio.Name = "AvionRadio";
            this.AvionRadio.Size = new System.Drawing.Size(52, 17);
            this.AvionRadio.TabIndex = 0;
            this.AvionRadio.TabStop = true;
            this.AvionRadio.Text = "Avion";
            this.AvionRadio.UseVisualStyleBackColor = true;
            // 
            // AutobusRadio
            // 
            this.AutobusRadio.AutoSize = true;
            this.AutobusRadio.Location = new System.Drawing.Point(59, 88);
            this.AutobusRadio.Name = "AutobusRadio";
            this.AutobusRadio.Size = new System.Drawing.Size(64, 17);
            this.AutobusRadio.TabIndex = 1;
            this.AutobusRadio.TabStop = true;
            this.AutobusRadio.Text = "Autobus";
            this.AutobusRadio.UseVisualStyleBackColor = true;
            // 
            // VlastitiPrijevozRadio
            // 
            this.VlastitiPrijevozRadio.AutoSize = true;
            this.VlastitiPrijevozRadio.Location = new System.Drawing.Point(59, 126);
            this.VlastitiPrijevozRadio.Name = "VlastitiPrijevozRadio";
            this.VlastitiPrijevozRadio.Size = new System.Drawing.Size(94, 17);
            this.VlastitiPrijevozRadio.TabIndex = 2;
            this.VlastitiPrijevozRadio.TabStop = true;
            this.VlastitiPrijevozRadio.Text = "Vlastiti prijevoz";
            this.VlastitiPrijevozRadio.UseVisualStyleBackColor = true;
            // 
            // RezervirajButton
            // 
            this.RezervirajButton.Location = new System.Drawing.Point(258, 276);
            this.RezervirajButton.Name = "RezervirajButton";
            this.RezervirajButton.Size = new System.Drawing.Size(263, 32);
            this.RezervirajButton.TabIndex = 1;
            this.RezervirajButton.Text = "Rezerviraj";
            this.RezervirajButton.UseVisualStyleBackColor = true;
            this.RezervirajButton.Click += new System.EventHandler(this.RezervirajButton_Click);
            // 
            // TextKutija
            // 
            this.TextKutija.Location = new System.Drawing.Point(258, 314);
            this.TextKutija.Multiline = true;
            this.TextKutija.Name = "TextKutija";
            this.TextKutija.Size = new System.Drawing.Size(263, 73);
            this.TextKutija.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TextKutija);
            this.Controls.Add(this.RezervirajButton);
            this.Controls.Add(this.OdabiriPrijevoza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.OdabiriPrijevoza.ResumeLayout(false);
            this.OdabiriPrijevoza.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox OdabiriPrijevoza;
        private System.Windows.Forms.RadioButton VlastitiPrijevozRadio;
        private System.Windows.Forms.RadioButton AutobusRadio;
        private System.Windows.Forms.RadioButton AvionRadio;
        private System.Windows.Forms.Button RezervirajButton;
        private System.Windows.Forms.TextBox TextKutija;
    }
}

