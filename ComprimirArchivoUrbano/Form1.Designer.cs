namespace ComprimirArchivoUrbano
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
			this.btnAutomatico = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnArchivo = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnComprimir = new Bunifu.Framework.UI.BunifuFlatButton();
			this.txtCarpetaOrigen = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
			this.btnCarpeta = new Bunifu.Framework.UI.BunifuFlatButton();
			this.RadioCarpeta = new System.Windows.Forms.RadioButton();
			this.RadioArchivo = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timePicker = new System.Windows.Forms.DateTimePicker();
			this.TimerHora = new System.Windows.Forms.Timer(this.components);
			this.txtDestino = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
			this.btnDestino = new Bunifu.Framework.UI.BunifuFlatButton();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.bunifuCards1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.panel1.Controls.Add(this.pictureBox2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(781, 46);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(192, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "SISTEMA DE COMPRESION";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(733, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(24, 24);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// bunifuCards1
			// 
			this.bunifuCards1.BackColor = System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 5;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.bunifuCards1.Controls.Add(this.pictureBox3);
			this.bunifuCards1.Controls.Add(this.txtDestino);
			this.bunifuCards1.Controls.Add(this.btnDestino);
			this.bunifuCards1.Controls.Add(this.btnAutomatico);
			this.bunifuCards1.Controls.Add(this.btnArchivo);
			this.bunifuCards1.Controls.Add(this.btnComprimir);
			this.bunifuCards1.Controls.Add(this.txtCarpetaOrigen);
			this.bunifuCards1.Controls.Add(this.btnCarpeta);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new System.Drawing.Point(41, 122);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new System.Drawing.Size(707, 222);
			this.bunifuCards1.TabIndex = 1;
			// 
			// btnAutomatico
			// 
			this.btnAutomatico.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnAutomatico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnAutomatico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAutomatico.BorderRadius = 6;
			this.btnAutomatico.ButtonText = "Comprimir Automático";
			this.btnAutomatico.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAutomatico.DisabledColor = System.Drawing.Color.Gray;
			this.btnAutomatico.Iconcolor = System.Drawing.Color.Transparent;
			this.btnAutomatico.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAutomatico.Iconimage")));
			this.btnAutomatico.Iconimage_right = null;
			this.btnAutomatico.Iconimage_right_Selected = null;
			this.btnAutomatico.Iconimage_Selected = null;
			this.btnAutomatico.IconMarginLeft = 0;
			this.btnAutomatico.IconMarginRight = 0;
			this.btnAutomatico.IconRightVisible = true;
			this.btnAutomatico.IconRightZoom = 0D;
			this.btnAutomatico.IconVisible = true;
			this.btnAutomatico.IconZoom = 70D;
			this.btnAutomatico.IsTab = false;
			this.btnAutomatico.Location = new System.Drawing.Point(401, 153);
			this.btnAutomatico.Name = "btnAutomatico";
			this.btnAutomatico.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnAutomatico.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
			this.btnAutomatico.OnHoverTextColor = System.Drawing.Color.White;
			this.btnAutomatico.selected = false;
			this.btnAutomatico.Size = new System.Drawing.Size(169, 44);
			this.btnAutomatico.TabIndex = 10;
			this.btnAutomatico.Text = "Comprimir Automático";
			this.btnAutomatico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnAutomatico.Textcolor = System.Drawing.Color.White;
			this.btnAutomatico.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAutomatico.Click += new System.EventHandler(this.btnAutomatico_Click);
			// 
			// btnArchivo
			// 
			this.btnArchivo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnArchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnArchivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnArchivo.BorderRadius = 5;
			this.btnArchivo.ButtonText = "Archivo";
			this.btnArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnArchivo.DisabledColor = System.Drawing.Color.Gray;
			this.btnArchivo.Iconcolor = System.Drawing.Color.Transparent;
			this.btnArchivo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnArchivo.Iconimage")));
			this.btnArchivo.Iconimage_right = null;
			this.btnArchivo.Iconimage_right_Selected = null;
			this.btnArchivo.Iconimage_Selected = null;
			this.btnArchivo.IconMarginLeft = 0;
			this.btnArchivo.IconMarginRight = 0;
			this.btnArchivo.IconRightVisible = true;
			this.btnArchivo.IconRightZoom = 0D;
			this.btnArchivo.IconVisible = true;
			this.btnArchivo.IconZoom = 70D;
			this.btnArchivo.IsTab = false;
			this.btnArchivo.Location = new System.Drawing.Point(545, 21);
			this.btnArchivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnArchivo.Name = "btnArchivo";
			this.btnArchivo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnArchivo.OnHovercolor = System.Drawing.Color.DodgerBlue;
			this.btnArchivo.OnHoverTextColor = System.Drawing.Color.White;
			this.btnArchivo.selected = false;
			this.btnArchivo.Size = new System.Drawing.Size(123, 35);
			this.btnArchivo.TabIndex = 9;
			this.btnArchivo.Text = "Archivo";
			this.btnArchivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnArchivo.Textcolor = System.Drawing.Color.White;
			this.btnArchivo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnArchivo.Click += new System.EventHandler(this.bunifuFlatButton1_Click_1);
			// 
			// btnComprimir
			// 
			this.btnComprimir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
			this.btnComprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnComprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnComprimir.BorderRadius = 6;
			this.btnComprimir.ButtonText = "Comprimir";
			this.btnComprimir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnComprimir.DisabledColor = System.Drawing.Color.Gray;
			this.btnComprimir.Iconcolor = System.Drawing.Color.Transparent;
			this.btnComprimir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnComprimir.Iconimage")));
			this.btnComprimir.Iconimage_right = null;
			this.btnComprimir.Iconimage_right_Selected = null;
			this.btnComprimir.Iconimage_Selected = null;
			this.btnComprimir.IconMarginLeft = 0;
			this.btnComprimir.IconMarginRight = 0;
			this.btnComprimir.IconRightVisible = true;
			this.btnComprimir.IconRightZoom = 0D;
			this.btnComprimir.IconVisible = true;
			this.btnComprimir.IconZoom = 70D;
			this.btnComprimir.IsTab = false;
			this.btnComprimir.Location = new System.Drawing.Point(164, 153);
			this.btnComprimir.Name = "btnComprimir";
			this.btnComprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnComprimir.OnHovercolor = System.Drawing.Color.DodgerBlue;
			this.btnComprimir.OnHoverTextColor = System.Drawing.Color.White;
			this.btnComprimir.selected = false;
			this.btnComprimir.Size = new System.Drawing.Size(169, 44);
			this.btnComprimir.TabIndex = 8;
			this.btnComprimir.Text = "Comprimir";
			this.btnComprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnComprimir.Textcolor = System.Drawing.Color.White;
			this.btnComprimir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnComprimir.Click += new System.EventHandler(this.btnComprimir_Click);
			// 
			// txtCarpetaOrigen
			// 
			this.txtCarpetaOrigen.BorderColor = System.Drawing.Color.SeaGreen;
			this.txtCarpetaOrigen.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCarpetaOrigen.Location = new System.Drawing.Point(16, 24);
			this.txtCarpetaOrigen.Name = "txtCarpetaOrigen";
			this.txtCarpetaOrigen.Size = new System.Drawing.Size(352, 27);
			this.txtCarpetaOrigen.TabIndex = 6;
			// 
			// btnCarpeta
			// 
			this.btnCarpeta.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnCarpeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnCarpeta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnCarpeta.BorderRadius = 5;
			this.btnCarpeta.ButtonText = "Carpeta";
			this.btnCarpeta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCarpeta.DisabledColor = System.Drawing.Color.Gray;
			this.btnCarpeta.Iconcolor = System.Drawing.Color.Transparent;
			this.btnCarpeta.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCarpeta.Iconimage")));
			this.btnCarpeta.Iconimage_right = null;
			this.btnCarpeta.Iconimage_right_Selected = null;
			this.btnCarpeta.Iconimage_Selected = null;
			this.btnCarpeta.IconMarginLeft = 0;
			this.btnCarpeta.IconMarginRight = 0;
			this.btnCarpeta.IconRightVisible = true;
			this.btnCarpeta.IconRightZoom = 0D;
			this.btnCarpeta.IconVisible = true;
			this.btnCarpeta.IconZoom = 70D;
			this.btnCarpeta.IsTab = false;
			this.btnCarpeta.Location = new System.Drawing.Point(388, 21);
			this.btnCarpeta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCarpeta.Name = "btnCarpeta";
			this.btnCarpeta.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnCarpeta.OnHovercolor = System.Drawing.Color.DodgerBlue;
			this.btnCarpeta.OnHoverTextColor = System.Drawing.Color.White;
			this.btnCarpeta.selected = false;
			this.btnCarpeta.Size = new System.Drawing.Size(123, 35);
			this.btnCarpeta.TabIndex = 2;
			this.btnCarpeta.Text = "Carpeta";
			this.btnCarpeta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnCarpeta.Textcolor = System.Drawing.Color.White;
			this.btnCarpeta.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCarpeta.Click += new System.EventHandler(this.btnArchivo_Click);
			// 
			// RadioCarpeta
			// 
			this.RadioCarpeta.AutoSize = true;
			this.RadioCarpeta.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RadioCarpeta.Location = new System.Drawing.Point(170, 71);
			this.RadioCarpeta.Name = "RadioCarpeta";
			this.RadioCarpeta.Size = new System.Drawing.Size(79, 24);
			this.RadioCarpeta.TabIndex = 2;
			this.RadioCarpeta.TabStop = true;
			this.RadioCarpeta.Text = "Carpeta";
			this.RadioCarpeta.UseVisualStyleBackColor = true;
			this.RadioCarpeta.CheckedChanged += new System.EventHandler(this.RadioCarpeta_CheckedChanged);
			// 
			// RadioArchivo
			// 
			this.RadioArchivo.AutoSize = true;
			this.RadioArchivo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.RadioArchivo.Location = new System.Drawing.Point(257, 71);
			this.RadioArchivo.Name = "RadioArchivo";
			this.RadioArchivo.Size = new System.Drawing.Size(78, 24);
			this.RadioArchivo.TabIndex = 3;
			this.RadioArchivo.TabStop = true;
			this.RadioArchivo.Text = "Archivo";
			this.RadioArchivo.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(49, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 21);
			this.label2.TabIndex = 4;
			this.label2.Text = "Seleccionar:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(438, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 21);
			this.label3.TabIndex = 5;
			this.label3.Text = "Hora:";
			// 
			// timePicker
			// 
			this.timePicker.CustomFormat = "HH:mm:ss";
			this.timePicker.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timePicker.Location = new System.Drawing.Point(495, 74);
			this.timePicker.Name = "timePicker";
			this.timePicker.ShowUpDown = true;
			this.timePicker.Size = new System.Drawing.Size(116, 27);
			this.timePicker.TabIndex = 6;
			this.timePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// TimerHora
			// 
			this.TimerHora.Interval = 60000;
			this.TimerHora.Tick += new System.EventHandler(this.TimerHora_Tick);
			// 
			// txtDestino
			// 
			this.txtDestino.BorderColor = System.Drawing.Color.SeaGreen;
			this.txtDestino.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDestino.Location = new System.Drawing.Point(16, 90);
			this.txtDestino.Name = "txtDestino";
			this.txtDestino.Size = new System.Drawing.Size(352, 27);
			this.txtDestino.TabIndex = 12;
			// 
			// btnDestino
			// 
			this.btnDestino.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnDestino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnDestino.BorderRadius = 5;
			this.btnDestino.ButtonText = "Carpeta Destino";
			this.btnDestino.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDestino.DisabledColor = System.Drawing.Color.Gray;
			this.btnDestino.Iconcolor = System.Drawing.Color.Transparent;
			this.btnDestino.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDestino.Iconimage")));
			this.btnDestino.Iconimage_right = null;
			this.btnDestino.Iconimage_right_Selected = null;
			this.btnDestino.Iconimage_Selected = null;
			this.btnDestino.IconMarginLeft = 0;
			this.btnDestino.IconMarginRight = 0;
			this.btnDestino.IconRightVisible = true;
			this.btnDestino.IconRightZoom = 0D;
			this.btnDestino.IconVisible = true;
			this.btnDestino.IconZoom = 70D;
			this.btnDestino.IsTab = false;
			this.btnDestino.Location = new System.Drawing.Point(388, 87);
			this.btnDestino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDestino.Name = "btnDestino";
			this.btnDestino.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
			this.btnDestino.OnHovercolor = System.Drawing.Color.DodgerBlue;
			this.btnDestino.OnHoverTextColor = System.Drawing.Color.White;
			this.btnDestino.selected = false;
			this.btnDestino.Size = new System.Drawing.Size(123, 35);
			this.btnDestino.TabIndex = 11;
			this.btnDestino.Text = "Carpeta Destino";
			this.btnDestino.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.btnDestino.Textcolor = System.Drawing.Color.White;
			this.btnDestino.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(684, 13);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(24, 24);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(539, 63);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(140, 84);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 13;
			this.pictureBox3.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(781, 399);
			this.Controls.Add(this.timePicker);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.RadioArchivo);
			this.Controls.Add(this.RadioCarpeta);
			this.Controls.Add(this.bunifuCards1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			this.bunifuCards1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Bunifu.Framework.UI.BunifuCards bunifuCards1;
		private Bunifu.Framework.UI.BunifuFlatButton btnCarpeta;
		private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCarpetaOrigen;
		private Bunifu.Framework.UI.BunifuFlatButton btnComprimir;
		private Bunifu.Framework.UI.BunifuFlatButton btnArchivo;
		private System.Windows.Forms.RadioButton RadioCarpeta;
		private System.Windows.Forms.RadioButton RadioArchivo;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuFlatButton btnAutomatico;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker timePicker;
		private System.Windows.Forms.Timer TimerHora;
		private System.Windows.Forms.PictureBox pictureBox2;
		private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDestino;
		private Bunifu.Framework.UI.BunifuFlatButton btnDestino;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}

