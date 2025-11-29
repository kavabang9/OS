namespace OS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Calculator = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Computer = new System.Windows.Forms.Button();
            this.Github = new System.Windows.Forms.Button();
            this.CloseStartMenu = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.HelpAndSupport = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 636);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 45);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.CausesValidation = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Пуск";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ControlPanel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Computer);
            this.panel2.Controls.Add(this.Github);
            this.panel2.Controls.Add(this.CloseStartMenu);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Location = new System.Drawing.Point(1, 216);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 420);
            this.panel2.TabIndex = 1;
            // 
            // ControlPanel
            // 
            this.ControlPanel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ControlPanel.Location = new System.Drawing.Point(213, 53);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(183, 40);
            this.ControlPanel.TabIndex = 8;
            this.ControlPanel.Text = "Панель управления";
            this.ControlPanel.UseVisualStyleBackColor = true;
            this.ControlPanel.Click += new System.EventHandler(this.ControlPanel_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Calculator);
            this.panel3.Location = new System.Drawing.Point(10, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 374);
            this.panel3.TabIndex = 7;
            // 
            // Calculator
            // 
            this.Calculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculator.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Calculator.Location = new System.Drawing.Point(3, 3);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(176, 40);
            this.Calculator.TabIndex = 8;
            this.Calculator.Text = "Калькулятор";
            this.Calculator.UseVisualStyleBackColor = true;
            this.Calculator.Click += new System.EventHandler(this.Calculator_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(71, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Пуск";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Computer
            // 
            this.Computer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Computer.Location = new System.Drawing.Point(213, 99);
            this.Computer.Name = "Computer";
            this.Computer.Size = new System.Drawing.Size(183, 40);
            this.Computer.TabIndex = 5;
            this.Computer.Text = "Мой компьютер";
            this.Computer.UseVisualStyleBackColor = true;
            this.Computer.Click += new System.EventHandler(this.Computer_Click);
            // 
            // Github
            // 
            this.Github.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Github.Location = new System.Drawing.Point(213, 145);
            this.Github.Name = "Github";
            this.Github.Size = new System.Drawing.Size(183, 40);
            this.Github.TabIndex = 2;
            this.Github.Text = "Справка и поддержка";
            this.Github.UseVisualStyleBackColor = true;
            this.Github.Click += new System.EventHandler(this.HelpAndSupport_Click);
            // 
            // CloseStartMenu
            // 
            this.CloseStartMenu.Location = new System.Drawing.Point(359, -1);
            this.CloseStartMenu.Name = "CloseStartMenu";
            this.CloseStartMenu.Size = new System.Drawing.Size(51, 29);
            this.CloseStartMenu.TabIndex = 1;
            this.CloseStartMenu.Text = "X";
            this.CloseStartMenu.UseVisualStyleBackColor = true;
            this.CloseStartMenu.Click += new System.EventHandler(this.CloseStartMenu_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.buttonExit.Location = new System.Drawing.Point(213, 365);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(183, 40);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "Завершение работы";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // HelpAndSupport
            // 
            this.HelpAndSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpAndSupport.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.HelpAndSupport.Location = new System.Drawing.Point(0, 0);
            this.HelpAndSupport.Name = "HelpAndSupport";
            this.HelpAndSupport.Size = new System.Drawing.Size(1264, 681);
            this.HelpAndSupport.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HelpAndSupport);
            this.Name = "MainWindow";
            this.Text = "OS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button CloseStartMenu;
        private System.Windows.Forms.Button Computer;
        private System.Windows.Forms.Button Github;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel HelpAndSupport;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Calculator;
        private System.Windows.Forms.Button ControlPanel;
    }
}

