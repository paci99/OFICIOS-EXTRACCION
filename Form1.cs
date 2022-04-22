using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronOcr;

namespace OFICIOS_EXTRACCION
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            fo.Filter = "Todos los archivos soportados | *.jpeg;*.png;*.bmp;*.ico;*.pdf;*.tif;*.tiff";
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {

                string extencion = System.IO.Path.GetExtension(fo.FileName);
                string ruta = fo.FileName;
                if (extencion == ".pdf")
                {
                    /*if (chkModoOCRpdf.Checked == false)
                    {
                    lblTipoReconocimiento.Text = "Archivo PDF";
                    string TextoExtraido = lecturapdf(ruta).ToString();
                    rtxtInfoExtraida.Text = TextoExtraido;

                    }
                    else
                    {

                        lblTipoReconocimiento.Text = "Archivo PDF (OCR)";
                        string TextoExtraidoOCR = lecturaPDFOCR(ruta).ToString();
                        rtxtInfoExtraida.Text = TextoExtraidoOCR;
                    }
                    lblTipoReconocimiento.Text = "Archivo PDF";
                    string TextoExtraido = lecturapdf(ruta).ToString();
                    rtxtInfoExtraida.Text = TextoExtraido;*/

                }
                else
                {
                    lblTipoReconocimiento.Text = "Archivo IMAGEN";
                    string TextoExtraido = lecturaOCR(ruta).ToString();
                    rtxtInfoExtraida.Text = TextoExtraido;
                }
            }
        }
        static string lecturaOCR(string _ruta)
        {
            string texto = "";
            try
            {
                var Ocr = new IronTesseract();
                using (var Input = new OcrInput())
                {
                    Input.AddImage(_ruta);
                    var Result = Ocr.Read(Input);
                    texto = Result.Text;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR", "ERROR", MessageBoxButtons.OK);

            }
            return texto;

        }

    }
}
