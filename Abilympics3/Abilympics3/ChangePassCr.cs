﻿using System;
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
    public partial class ChangePassCr : Form
    {
        public ChangePassCr()
        {
            InitializeComponent();
        }

        /* значение поля textBox сохраняется в переменную ChangePassCr и
         происходит переход на форму CreatorMenu*/
        private void button2_Click(object sender, EventArgs e)
        {
            Data.ChangePassCr = textBox3.Text;
            Form crm = new CreatorMenu();
            Hide();
            DialogResult res = crm.ShowDialog();
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
