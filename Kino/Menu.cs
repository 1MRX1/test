using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text.pdf;
using System.IO;

namespace Kino
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        static string connect = "Server=localhost;Database=new_schema;User=root;Password=root";
        MySqlConnection conn = new MySqlConnection(connect);
        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "new_schemaDataSet2.test2". При необходимости она может быть перемещена или удалена.
            this.test2TableAdapter.Fill(this.new_schemaDataSet2.test2);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "new_schemaDataSet1.test". При необходимости она может быть перемещена или удалена.
            this.testTableAdapter.Fill(this.new_schemaDataSet1.test);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "test";
            Insert ins = new Insert();
            ins.ShowDialog();
            this.testTableAdapter.Fill(this.new_schemaDataSet1.test);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = "test2";
            Insert ins = new Insert();
            ins.ShowDialog();
            this.test2TableAdapter.Fill(this.new_schemaDataSet2.test2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var document = new iTextSharp.text.Document();
            var writer = PdfWriter.GetInstance(document, new FileStream("result.pdf", FileMode.Create));
            document.Open();

            var helvetica = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12);
            var helveticaBase = helvetica.GetCalculatedBaseFont(false);
            writer.DirectContent.BeginText();
            writer.DirectContent.SetFontAndSize(helveticaBase, 12f);
            writer.DirectContent.ShowTextAligned(iTextSharp.text.Element.ALIGN_LEFT, "Hello world!", 35, 766, 0);
            writer.DirectContent.EndText();

            document.Close();
            writer.Close();
        }
    }
}
