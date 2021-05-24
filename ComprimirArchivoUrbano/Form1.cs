using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;
using System.IO;
using Microsoft.VisualBasic.Devices;

namespace ComprimirArchivoUrbano
{
	public partial class Form1 : Form
	{
		Computer MyComputer = new Computer();
		private static string tipo = "Carpeta";

		public Form1()
		{
			InitializeComponent();
		}

		private void RadioCarpeta_CheckedChanged(object sender, EventArgs e)
		{
			if (RadioCarpeta.Checked == true)
			{
				tipo = "Carpeta";
				btnCarpeta.Enabled = true;
				btnArchivo.Enabled = false;
				btnDestino.Enabled = false;
				txtCarpetaOrigen.Focus();
			}
			else
			{
				tipo = "Archivo";
				btnCarpeta.Enabled = false;
				btnArchivo.Enabled = true;
				txtCarpetaOrigen.Focus();
				btnDestino.Enabled = true;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			RadioCarpeta.Checked = true;
			txtCarpetaOrigen.Enabled = false;
			txtDestino.Enabled = false;
			btnDestino.Enabled = false;
			timePicker.Value = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day,20,30,0);
		}

		public void ComprimirCarpeta()
		{
			if (txtCarpetaOrigen.Text=="")
			{
				MessageBox.Show("Debe seleccionar una carpeta");
			}
			else
			{
				string Ruta = txtCarpetaOrigen.Text;
				string RutaZip = Ruta + DateTime.Now.Day+DateTime.Now.Month+DateTime.Now.Year + ".zip";

				if (File.Exists(RutaZip))
				{
					MessageBox.Show("Ya existe un carpeta creado con el mismo nombre!!");
				}
				else
				{
					ZipFile.CreateFromDirectory(Ruta, RutaZip);
					MessageBox.Show("Se comprimió correctamente!!");
					tipo = "Archivo";
				}

			}

		}
	    private static	string directoryPath;

		public  void ComprimirArchivo(DirectoryInfo directorySelected)
		{

			var ultimo_archivo = (from item in directorySelected.GetFiles()
								  where item.Extension != ".rar"
								  orderby item.LastWriteTime descending
								  select item).First();

			if (ultimo_archivo.Exists)
			{

				//foreach (FileInfo fileToCompress in directorySelected.GetFiles())
				//{
				using (FileStream originalFileStream = ultimo_archivo.OpenRead())
				{
					if ((File.GetAttributes(ultimo_archivo.FullName) & FileAttributes.Hidden) != FileAttributes.Hidden & ultimo_archivo.Extension != ".rar")
					{
						using (FileStream compressedFileStream = File.Create(ultimo_archivo.FullName + ".rar"))
						{
							using (GZipStream compressionStream = new GZipStream(compressedFileStream,
							   CompressionMode.Compress))
							{
								originalFileStream.CopyTo(compressionStream);
								compressionStream.Close();

							}
							compressedFileStream.Close();
						}

						FileInfo info = new FileInfo(directoryPath + Path.DirectorySeparatorChar + ultimo_archivo.Name + ".rar");
						//MessageBox.Show("Se comprimió el archivo más reciente correctamente " + info);

					}
					else
					{
						MessageBox.Show("Existe un archivo creado con el mismo nombre!!");
					}
				}
				//}
			}
			else
			{
				MessageBox.Show("Ya existe el archivo comprimido");
			}

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnArchivo_Click(object sender, EventArgs e)
		{
			string rutacarpeta = string.Empty;
			FolderBrowserDialog fbd1 = new FolderBrowserDialog();
			if (fbd1.ShowDialog()==DialogResult.OK)
			{
				rutacarpeta = fbd1.SelectedPath;
			}
			txtCarpetaOrigen.Text = rutacarpeta;
		}

		private void btnComprimir_Click(object sender, EventArgs e)
		{
			if (tipo=="Carpeta")
			{
				ComprimirCarpeta();
			}else
			{
				if (directoryPath==null)
				{
					MessageBox.Show("Debe seleccionar una carpeta");
				}
				else
				{
					DirectoryInfo directorySelected = new DirectoryInfo(directoryPath);
					ComprimirArchivo(directorySelected);
					var ultimo_archivo = (from item in directorySelected.GetFiles()
										  where item.Extension == ".rar"
										  orderby item.LastWriteTime descending
										  select item).First();
					System.IO.File.Move(directoryPath + Path.DirectorySeparatorChar + ultimo_archivo, txtDestino.Text + Path.DirectorySeparatorChar + ultimo_archivo);
					MessageBox.Show("Se comprimió el archivo más reciente correctamente ");
				}



			}



		}

		private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
		{
			string rutacarpeta = string.Empty;
			if (rutacarpeta=="")
			{
				FolderBrowserDialog fbd1 = new FolderBrowserDialog();
				if (fbd1.ShowDialog() == DialogResult.OK)
				{
					rutacarpeta = fbd1.SelectedPath;
					txtCarpetaOrigen.Text = rutacarpeta;
					directoryPath = txtCarpetaOrigen.Text;
					
				}
				else
				{
					MessageBox.Show("Debe selecionar una ruta!!");
				}
			}

		}
		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			
		}
		private void btnAutomatico_Click(object sender, EventArgs e)
		{
			if (tipo=="Archivo" && txtCarpetaOrigen.Text !="")
			{
				btnComprimir.Enabled = false;
				TimerHora.Enabled = true;
			}
			else
			{
				MessageBox.Show("Seleccione una Carpeta");
			}
		}
		private void TimerHora_Tick(object sender, EventArgs e)
		{
			DateTime fechasistema = new DateTime(DateTime.Now.Year, DateTime.Now.Month,DateTime.Now.Day,DateTime.Now.Hour,DateTime.Now.Minute,00);
			DateTime fechatempini = Convert.ToDateTime(timePicker.Value);
			DateTime fechainicio = new DateTime(fechasistema.Year,fechasistema.Month,fechasistema.Day,fechatempini.Hour,fechatempini.Minute,fechatempini.Second);

			if (fechasistema==fechainicio)
			{
				DirectoryInfo directorySelected = new DirectoryInfo(directoryPath);
				ComprimirArchivo(directorySelected);
				var ultimo_archivo = (from item in directorySelected.GetFiles()
									  where item.Extension == ".rar"
									  orderby item.LastWriteTime descending
									  select item).First();
				System.IO.File.Move(directoryPath + Path.DirectorySeparatorChar + ultimo_archivo, txtDestino.Text + Path.DirectorySeparatorChar + ultimo_archivo);
				MessageBox.Show("Se comprimió el archivo más reciente correctamente");
			}
		}
		private void pictureBox2_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnDestino_Click(object sender, EventArgs e)
		{
			string rutacarpeta = string.Empty;
			FolderBrowserDialog fbd1 = new FolderBrowserDialog();
			if (fbd1.ShowDialog() == DialogResult.OK)
			{
				rutacarpeta = fbd1.SelectedPath;
			}
			txtDestino.Text = rutacarpeta;
		}
	}
}
