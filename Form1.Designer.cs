
namespace NoteApp
{
    partial class NoteApp
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
            this.title = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.titlelabel = new System.Windows.Forms.Label();
            this.notelabel = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(114, 29);
            this.title.TabIndex = 0;
            this.title.Text = "Note App";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(17, 74);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(399, 20);
            this.titleBox.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 293);
            this.textBox1.TabIndex = 2;
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titlelabel.Location = new System.Drawing.Point(13, 51);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(38, 20);
            this.titlelabel.TabIndex = 3;
            this.titlelabel.Text = "Title";
            // 
            // notelabel
            // 
            this.notelabel.AutoSize = true;
            this.notelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notelabel.Location = new System.Drawing.Point(13, 97);
            this.notelabel.Name = "notelabel";
            this.notelabel.Size = new System.Drawing.Size(81, 20);
            this.notelabel.TabIndex = 4;
            this.notelabel.Text = "Note Area";
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(341, 419);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(75, 23);
            this.savebutton.TabIndex = 5;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            // 
            // NoteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.notelabel);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.title);
            this.Name = "NoteApp";
            this.Text = "Note App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label titlelabel;
        private System.Windows.Forms.Label notelabel;
        private System.Windows.Forms.Button savebutton;
    }
}

