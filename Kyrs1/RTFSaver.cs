using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrs1
{
    public class RTFSaver
    {
        public static void SaveToRTF(string filePath, RichTextBox rtbName, RichTextBox rtbInfo, RichTextBox rtbExtraInfo, RichTextBox rtbAddress, Image image)
        {
            // Збирання вмісту RichTextBox-ів
            string nameContent = rtbName.Rtf;
            string infoContent = rtbInfo.Rtf;
            string extraInfoContent = rtbExtraInfo.Rtf;
            string addressContent = rtbAddress.Rtf;

            // Форматування вмісту
            string formattedContent = $"Name: {nameContent}\n" +
                                      $"Info (RTF): {infoContent}\n" +
                                      $"ExtraInfo (RTF): {extraInfoContent}\n" +
                                      $"Address: {addressContent}\n";

            // Запис вмісту у файл
            File.WriteAllText(filePath, formattedContent);
        }
    }
}
