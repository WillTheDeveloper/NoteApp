using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace NoteApp
{
    public partial class NoteApp : Form
    {
        public NoteApp()
        {
            InitializeComponent();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            string Note = notelabel.Text;
            string Title = titlelabel.Text;

            File.WriteAllText(Title + ".txt", Note);
        }
    }
}
