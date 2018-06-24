using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShips
{
    public partial class ShipSetter : Form
    {
        char lf, lt;
        int nf, nt;
        public ShipSetter()
        {
            InitializeComponent();
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            if (numberBoxFrom.Text != "" && numberBoxTo.Text != "" && letterBoxFrom.Text != "" && letterBoxTo.Text != "")
            {
                nf = Int32.Parse(numberBoxFrom.Text.ToString());
                nt = Int32.Parse(numberBoxTo.Text.ToString());
                lf = letterBoxFrom.Text[0];
                lt = letterBoxTo.Text[0];
                this.Close();
            }
            else
                MessageBox.Show("Not all values were entered!");
        }

        public char GetLetterFrom()
        {
            return lf;
        }
        public char GetLetterTo()
        {
            return lt;
        }
        public int GetNumberFrom()
        {
            return nf;
        }
        public int GetNumberTo()
        {
            return nt;
        }
    }
}
