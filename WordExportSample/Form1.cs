using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace WordExportSample
{
    public partial class FormWordExport : Form
    {
        private readonly string TemplateFileName = @"C:\Users\ra.rakhimbayev\Desktop\Шаблоны Word\HTK\Акт_приема-передачи_HTK.doc";
        private readonly string SaveFilePath = @"C:\Users\ra.rakhimbayev\Desktop\Sample.doc";

        public FormWordExport()
        {
            InitializeComponent();
        }

        private void ButtonGenerateContract_Click(object sender, EventArgs e)
        {
            var fullName = TextBoxFullName.Text;
            var endDate = TextBoxEndDate.Text;
            var signDate = TextBoxSignDate.Text;

            //TODO: Word Export
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                // Получаем доступ к файлу
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("<fullname>", fullName, wordDocument);
                ReplaceWordStub("<signDate>", signDate, wordDocument);
                ReplaceWordStub("<endDate>", endDate, wordDocument);

                wordDocument.SaveAs(SaveFilePath);
                // Показывает приложение Word
                wordApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                wordApp.Quit();
            }
            
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            // Получаем все содержимое документа
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText:stubToReplace, ReplaceWith: text);

        }
    }
}
