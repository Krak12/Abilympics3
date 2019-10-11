using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abilympics3
{
    public partial class ChangePassSp : Form
    {
        public ChangePassSp()
        {
            InitializeComponent();
        }

        /* значение поля textBox сохраняется в переменную ChangePassSp и
         происходит переход на форму SpecialistMenu*/
        private void button2_Click(object sender, EventArgs e)
        {
            Data.ChangePassSp = textBox3.Text;
            Form spm = new SpecialistMenu();
            Hide();
            DialogResult res = spm.ShowDialog();
            if (res != DialogResult.Cancel)
            {
                Show();
            }
            else Close();
        }

        // закрытие формы
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
