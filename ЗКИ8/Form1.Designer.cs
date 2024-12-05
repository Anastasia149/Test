namespace ЗКИ8
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonGenerateAlphabet = new System.Windows.Forms.Button();
            this.textBoxCustomAlphabet = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxGamma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.buttonLoadFromFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите ключ для шифра Цезаря:";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(45, 242);
            this.textBoxKey.Multiline = true;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(349, 45);
            this.textBoxKey.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите текст для гаммирования:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(45, 79);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(349, 45);
            this.textBoxInput.TabIndex = 3;
            // 
            // buttonGenerateAlphabet
            // 
            this.buttonGenerateAlphabet.Location = new System.Drawing.Point(45, 311);
            this.buttonGenerateAlphabet.Name = "buttonGenerateAlphabet";
            this.buttonGenerateAlphabet.Size = new System.Drawing.Size(347, 61);
            this.buttonGenerateAlphabet.TabIndex = 5;
            this.buttonGenerateAlphabet.Text = "Генерация алфавита";
            this.buttonGenerateAlphabet.UseVisualStyleBackColor = true;
            this.buttonGenerateAlphabet.Click += new System.EventHandler(this.buttonGenerateAlphabet_Click);
            // 
            // textBoxCustomAlphabet
            // 
            this.textBoxCustomAlphabet.Location = new System.Drawing.Point(482, 242);
            this.textBoxCustomAlphabet.Multiline = true;
            this.textBoxCustomAlphabet.Name = "textBoxCustomAlphabet";
            this.textBoxCustomAlphabet.ReadOnly = true;
            this.textBoxCustomAlphabet.Size = new System.Drawing.Size(529, 45);
            this.textBoxCustomAlphabet.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Сдвинутый алфавит";
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(45, 395);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(347, 61);
            this.buttonEncrypt.TabIndex = 8;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textBoxGamma
            // 
            this.textBoxGamma.Location = new System.Drawing.Point(482, 79);
            this.textBoxGamma.Multiline = true;
            this.textBoxGamma.Name = "textBoxGamma";
            this.textBoxGamma.Size = new System.Drawing.Size(349, 45);
            this.textBoxGamma.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Гамма";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(296, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Зашифрованное сообщение";
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Location = new System.Drawing.Point(482, 395);
            this.textBoxEncrypted.Multiline = true;
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.ReadOnly = true;
            this.textBoxEncrypted.Size = new System.Drawing.Size(529, 61);
            this.textBoxEncrypted.TabIndex = 11;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(47, 489);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(347, 61);
            this.buttonDecrypt.TabIndex = 13;
            this.buttonDecrypt.Text = "Расшифровать";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 534);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(308, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Расшифрованное сообщение";
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Location = new System.Drawing.Point(482, 571);
            this.textBoxDecrypted.Multiline = true;
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.ReadOnly = true;
            this.textBoxDecrypted.Size = new System.Drawing.Size(529, 61);
            this.textBoxDecrypted.TabIndex = 14;
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(1084, 395);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(347, 61);
            this.buttonSaveToFile.TabIndex = 16;
            this.buttonSaveToFile.Text = "Сохранить";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // buttonLoadFromFile
            // 
            this.buttonLoadFromFile.Location = new System.Drawing.Point(1084, 571);
            this.buttonLoadFromFile.Name = "buttonLoadFromFile";
            this.buttonLoadFromFile.Size = new System.Drawing.Size(347, 61);
            this.buttonLoadFromFile.TabIndex = 17;
            this.buttonLoadFromFile.Text = "Загрузить";
            this.buttonLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonLoadFromFile.Click += new System.EventHandler(this.buttonLoadFromFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 727);
            this.Controls.Add(this.buttonLoadFromFile);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDecrypted);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxEncrypted);
            this.Controls.Add(this.textBoxGamma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCustomAlphabet);
            this.Controls.Add(this.buttonGenerateAlphabet);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonGenerateAlphabet;
        private System.Windows.Forms.TextBox textBoxCustomAlphabet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxGamma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxEncrypted;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDecrypted;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.Button buttonLoadFromFile;
    }
}

