namespace TextToSpeech
{
    partial class TextToSpeechForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.btnSpeak = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbSpeaker = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // rtbText
            // 
            this.rtbText.Location = new System.Drawing.Point(12, 39);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(477, 279);
            this.rtbText.TabIndex = 0;
            this.rtbText.Text = "";
            // 
            // btnSpeak
            // 
            this.btnSpeak.Location = new System.Drawing.Point(12, 333);
            this.btnSpeak.Name = "btnSpeak";
            this.btnSpeak.Size = new System.Drawing.Size(75, 23);
            this.btnSpeak.TabIndex = 1;
            this.btnSpeak.Text = "Speak";
            this.btnSpeak.UseVisualStyleBackColor = true;
            this.btnSpeak.Click += new System.EventHandler(this.btnSpeak_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 333);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbSpeaker
            // 
            this.cbSpeaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeaker.FormattingEnabled = true;
            this.cbSpeaker.Location = new System.Drawing.Point(12, 12);
            this.cbSpeaker.Name = "cbSpeaker";
            this.cbSpeaker.Size = new System.Drawing.Size(477, 21);
            this.cbSpeaker.TabIndex = 4;
            // 
            // TextToSpeechForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 368);
            this.Controls.Add(this.cbSpeaker);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSpeak);
            this.Controls.Add(this.rtbText);
            this.MaximumSize = new System.Drawing.Size(517, 407);
            this.MinimumSize = new System.Drawing.Size(517, 407);
            this.Name = "TextToSpeechForm";
            this.Text = "TextToSpeech";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.Button btnSpeak;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbSpeaker;
    }
}

