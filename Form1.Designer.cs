namespace Aula9ExercicioVisualizadorImagem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            imagemListBox = new ListBox();
            favoritosListBox = new ListBox();
            adicionarButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imagemListBox
            // 
            imagemListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            imagemListBox.FormattingEnabled = true;
            imagemListBox.ItemHeight = 15;
            imagemListBox.Location = new Point(12, 12);
            imagemListBox.Name = "imagemListBox";
            imagemListBox.Size = new Size(412, 94);
            imagemListBox.TabIndex = 0;
            imagemListBox.SelectedIndexChanged += imagemListBox_SelectedIndexChanged;
            // 
            // favoritosListBox
            // 
            favoritosListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            favoritosListBox.FormattingEnabled = true;
            favoritosListBox.ItemHeight = 15;
            favoritosListBox.Location = new Point(12, 135);
            favoritosListBox.Name = "favoritosListBox";
            favoritosListBox.Size = new Size(412, 94);
            favoritosListBox.TabIndex = 1;
            favoritosListBox.SelectedIndexChanged += favoritosListBox_SelectedIndexChanged;
            // 
            // adicionarButton
            // 
            adicionarButton.Location = new Point(11, 109);
            adicionarButton.Name = "adicionarButton";
            adicionarButton.Size = new Size(206, 23);
            adicionarButton.TabIndex = 2;
            adicionarButton.Text = "Adicionar aos Favoritos";
            adicionarButton.UseVisualStyleBackColor = true;
            adicionarButton.Click += adicionarButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(412, 174);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 422);
            Controls.Add(pictureBox1);
            Controls.Add(adicionarButton);
            Controls.Add(favoritosListBox);
            Controls.Add(imagemListBox);
            Name = "Form1";
            Text = "Visualizador de Imagens";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox imagemListBox;
        private ListBox favoritosListBox;
        private Button adicionarButton;
        private PictureBox pictureBox1;
    }
}