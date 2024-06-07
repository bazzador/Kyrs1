using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Kyrs1
{
    public class RTFParser
    {
        public static void ParseRTF(string filePath, RichTextBox rtbName, RichTextBox rtbInfo, RichTextBox rtbExtraInfo, RichTextBox rtbAddress)
        {
            // Зчитування файлу
            if (!File.Exists(filePath))
            {
                return;
            }
            string rtfContent = File.ReadAllText(filePath);

            // Регулярні вирази для виділення потрібних секцій
            string namePattern = @"Name:\s*({.*?})\s*Info";
            string infoPattern = @"Info \(RTF\):\s*({.*?})\s*ExtraInfo";
            string extraInfoPattern = @"ExtraInfo \(RTF\):\s*({.*?})\s*Address:(.*?)\n";
            string addressPattern = @"Address:(.*?)$";

            // Виділення значень за допомогою регулярних виразів
            var nameMatch = Regex.Match(rtfContent, namePattern, RegexOptions.Singleline);
            var infoMatch = Regex.Match(rtfContent, infoPattern, RegexOptions.Singleline);
            var extraInfoMatch = Regex.Match(rtfContent, extraInfoPattern, RegexOptions.Singleline);
            var addressMatch = Regex.Match(rtfContent, addressPattern, RegexOptions.Singleline);

            // Встановлення значень у відповідні RichTextBox
            if (nameMatch.Success)
            {
                rtbName.Rtf = nameMatch.Groups[1].Value.Trim();
            }
            if (infoMatch.Success)
            {
                rtbInfo.Rtf = infoMatch.Groups[1].Value.Trim();
            }
            if (extraInfoMatch.Success)
            {
                rtbExtraInfo.Rtf = extraInfoMatch.Groups[1].Value.Trim();
            }
            if (addressMatch.Success)
            {
                rtbAddress.Rtf = addressMatch.Groups[1].Value.Trim();
            }
        }
    }
}
