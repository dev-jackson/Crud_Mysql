﻿namespace Crud_Mysql
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dgwDatos = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgwDatos)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 65);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "BUSCAR:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(110, 65);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(443, 22);
			this.textBox1.TabIndex = 1;
			// 
			// dgwDatos
			// 
			this.dgwDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgwDatos.Location = new System.Drawing.Point(26, 107);
			this.dgwDatos.Name = "dgwDatos";
			this.dgwDatos.RowHeadersWidth = 51;
			this.dgwDatos.RowTemplate.Height = 24;
			this.dgwDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgwDatos.Size = new System.Drawing.Size(1052, 422);
			this.dgwDatos.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(192, 558);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(143, 42);
			this.button1.TabIndex = 3;
			this.button1.Text = "Registrar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(492, 558);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(143, 42);
			this.button2.TabIndex = 4;
			this.button2.Text = "Actualizar";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(794, 558);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(143, 42);
			this.button3.TabIndex = 5;
			this.button3.Text = "Eliminar";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(581, 62);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(129, 23);
			this.button4.TabIndex = 6;
			this.button4.Text = "Buscar";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1090, 624);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgwDatos);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgwDatos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridView dgwDatos;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}

