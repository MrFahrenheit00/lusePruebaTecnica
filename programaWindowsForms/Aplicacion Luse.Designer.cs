using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;

namespace PruebaTecnica
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
            buttonGuardarNota = new Button();
            buttonLeerNota = new Button();
            buttonBorrarNota = new Button();
            label = new Label();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // buttonGuardarNota
            // 
            buttonGuardarNota.Location = new Point(89, 404);
            buttonGuardarNota.Margin = new Padding(3, 4, 3, 4);
            buttonGuardarNota.Name = "buttonGuardarNota";
            buttonGuardarNota.Size = new Size(147, 31);
            buttonGuardarNota.TabIndex = 0;
            buttonGuardarNota.Text = "Guardar nota";
            buttonGuardarNota.UseVisualStyleBackColor = true;
            buttonGuardarNota.Click += buttonGuardarNota_Click;
            // 
            // buttonLeerNota
            // 
            buttonLeerNota.Location = new Point(334, 404);
            buttonLeerNota.Margin = new Padding(3, 4, 3, 4);
            buttonLeerNota.Name = "buttonLeerNota";
            buttonLeerNota.Size = new Size(147, 31);
            buttonLeerNota.TabIndex = 1;
            buttonLeerNota.Text = "Leer nota";
            buttonLeerNota.UseVisualStyleBackColor = true;
            buttonLeerNota.Click += buttonLeerNota_Click;
            // 
            // buttonBorrarNota
            // 
            buttonBorrarNota.Location = new Point(586, 404);
            buttonBorrarNota.Margin = new Padding(3, 4, 3, 4);
            buttonBorrarNota.Name = "buttonBorrarNota";
            buttonBorrarNota.Size = new Size(147, 31);
            buttonBorrarNota.TabIndex = 2;
            buttonBorrarNota.Text = "Borrar nota";
            buttonBorrarNota.UseVisualStyleBackColor = true;
            buttonBorrarNota.Click += buttonBorrarNota_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Consolas", 12F, FontStyle.Italic, GraphicsUnit.Point);
            label.Location = new Point(89, 35);
            label.Name = "label";
            label.Size = new Size(0, 23);
            label.TabIndex = 3;
            // 
            // textBox
            // 
            textBox.Location = new Point(89, 168);
            textBox.Margin = new Padding(3, 4, 3, 4);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(644, 152);
            textBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(textBox);
            Controls.Add(label);
            Controls.Add(buttonBorrarNota);
            Controls.Add(buttonLeerNota);
            Controls.Add(buttonGuardarNota);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Aplicación Luse Prueba Tecnica";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGuardarNota;
        private Button buttonLeerNota;
        private Button buttonBorrarNota;
        private Label label;
        private TextBox textBox;
    }
}