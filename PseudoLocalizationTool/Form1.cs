using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoLocalizationTool
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            StringBuilder pseudo = new StringBuilder();
            int extra = Int32.Parse(increamentText.Text);
            var length = Math.Ceiling(textBox1.Text.Length * (1 +(extra/100.0)));



            for (int i = 0; i < length; i++)
            {
                int index = r.Next(0, pseudoList.Count-1);
                pseudo.Append(pseudoList[index]);
            }

            textBox2.Text = pseudo.ToString();

            LengthInput.Text = textBox1.TextLength.ToString();
            LengthOutput.Text = textBox2.TextLength.ToString();
        }


        private List<char> pseudoList = new List<char>
        {
            'á',
            'β',
            'ç',
            'δ',
            'è',
            'ƒ',
            'ϱ',
            'λ',
            'ï',
            'J',
            'ƙ',
            'ℓ',
            '₥',
            'ñ',
            'ô',
            'ƥ',
            '9',
            'ř',
            'ƨ',
            'ƭ',
            'ú',
            'Ʋ',
            'ω',
            'ж',
            '¥',
            'ƺ',
            'Â',
            'ß',
            'Ç',
            'Ð',
            'É',
            'F',
            'G',
            'H',
            'Ì',
            'J',
            'K',
            '£',
            'M',
            'N',
            'Ó',
            'Þ',
            'Q',
            'R',
            '§',
            'T',
            'Û',
            'V',
            'W',
            'X',
            'Ý',
            'Z',
        };






        /*case 'a': out = 'á'; break;
          case 'b': out = 'β'; break;
          case 'c': out = 'ç'; break;
          case 'd': out = 'δ'; break;
          case 'e': out = 'è'; break;
          case 'f': out = 'ƒ'; break;
          case 'g': out = 'ϱ'; break;
          case 'h': out = 'λ'; break;
          case 'i': out = 'ï'; break;
          case 'j': out = 'J'; break;
          case 'k': out = 'ƙ'; break;
          case 'l': out = 'ℓ'; break;
          case 'm': out = '₥'; break;
          case 'n': out = 'ñ'; break;
          case 'o': out = 'ô'; break;
          case 'p': out = 'ƥ'; break;
          case 'q': out = '9'; break;
          case 'r': out = 'ř'; break;
          case 's': out = 'ƨ'; break;
          case 't': out = 'ƭ'; break;
          case 'u': out = 'ú'; break;
          case 'v': out = 'Ʋ'; break;
          case 'w': out = 'ω'; break;
          case 'x': out = 'ж'; break;
          case 'y': out = '¥'; break;
          case 'z': out = 'ƺ'; break;
          case 'A': out = 'Â'; break;
          case 'B': out = 'ß'; break;
          case 'C': out = 'Ç'; break;
          case 'D': out = 'Ð'; break;
          case 'E': out = 'É'; break;
          case 'F': out = 'F'; break;
          case 'G': out = 'G'; break;
          case 'H': out = 'H'; break;
          case 'I': out = 'Ì'; break;
          case 'J': out = 'J'; break;
          case 'K': out = 'K'; break;
          case 'L': out = '£'; break;
          case 'M': out = 'M'; break;
          case 'N': out = 'N'; break;
          case 'O': out = 'Ó'; break;
          case 'P': out = 'Þ'; break;
          case 'Q': out = 'Q'; break;
          case 'R': out = 'R'; break;
          case 'S': out = '§'; break;
          case 'T': out = 'T'; break;
          case 'U': out = 'Û'; break;
          case 'V': out = 'V'; break;
          case 'W': out = 'W'; break;
          case 'X': out = 'X'; break;
          case 'Y': out = 'Ý'; break;
          case 'Z': out = 'Z'; break;*/
    }
}
