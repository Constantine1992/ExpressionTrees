using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortTables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int recCount = int.Parse(textBox_Rec_Count.Text); 
            int qtyMe = int.Parse(textBox_Me.Text);
            int qtyForMe = int.Parse(textBox_ForMe.Text);
            Calculate(recCount, qtyMe, qtyForMe);
        }

        private void Calculate(int recCount, int qtyMe, int qtyForMe)
        {
            int docCount = recCount / 2;
            qtyMe = qtyMe > docCount ? docCount : qtyMe;
            qtyForMe = qtyForMe > docCount ? docCount : qtyForMe;
            int difMe = docCount - qtyMe;
            int difForMe = docCount - qtyForMe;

            int me = Calc(qtyMe,  difMe, difForMe, docCount, recCount);
            int forMe = Calc(qtyForMe, difForMe, difMe, docCount, recCount);
            MessageBox.Show(string.Format("me {0} forMe {1}", me, forMe));

        }
        private int Calc(int val1, int difVal1, int difVal2, int docCount, int recCount)
        {
            int result = 0;
            if (difVal2 > 0 && difVal1 <= 0)
                result = val1 + difVal2;
            else
                result = val1; //> docCount ? docCount: val1;
            result = result > recCount ? recCount : result;
            return result;
        }
    }
}
