namespace midterm
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTextEditor = new System.Windows.Forms.Button();
            this.btnToDo = new System.Windows.Forms.Button();
            this.btnBackground = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTextEditor
            // 
            this.btnTextEditor.Location = new System.Drawing.Point(116, 63);
            this.btnTextEditor.Name = "btnTextEditor";
            this.btnTextEditor.Size = new System.Drawing.Size(75, 23);
            this.btnTextEditor.TabIndex = 0;
            this.btnTextEditor.Text = "Text Editör";
            this.btnTextEditor.UseVisualStyleBackColor = true;
            this.btnTextEditor.Click += new System.EventHandler(this.btnTextEditor_Click);
            // 
            // btnToDo
            // 
            this.btnToDo.Location = new System.Drawing.Point(254, 63);
            this.btnToDo.Name = "btnToDo";
            this.btnToDo.Size = new System.Drawing.Size(75, 23);
            this.btnToDo.TabIndex = 1;
            this.btnToDo.Text = "TO-DO";
            this.btnToDo.UseVisualStyleBackColor = true;
            this.btnToDo.Click += new System.EventHandler(this.btnToDo_Click);
            // 
            // btnBackground
            // 
            this.btnBackground.Location = new System.Drawing.Point(383, 63);
            this.btnBackground.Name = "btnBackground";
            this.btnBackground.Size = new System.Drawing.Size(154, 23);
            this.btnBackground.TabIndex = 2;
            this.btnBackground.Text = "Background Color";
            this.btnBackground.UseVisualStyleBackColor = true;
            this.btnBackground.Click += new System.EventHandler(this.btnBackground_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 148);
            this.Controls.Add(this.btnBackground);
            this.Controls.Add(this.btnToDo);
            this.Controls.Add(this.btnTextEditor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTextEditor;
        private System.Windows.Forms.Button btnToDo;
        private System.Windows.Forms.Button btnBackground;
    }
}

