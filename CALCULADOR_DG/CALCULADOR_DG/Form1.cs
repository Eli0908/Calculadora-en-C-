using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CALCULADOR_DG
{
	public partial class CALCULADORA : Form
	{
		public CALCULADORA()
		{
			InitializeComponent();
		}
		private void btnSuma_Click(object sender, EventArgs e)
		{
			 decimal v1 = this.nudOp1.Value;
			 decimal v2 = this.nudOp2.Value;
		   
			 decimal total = v1 + v2;
			  this.txtResultado.Text = total + "";

		}

        private void btnResta_Click_1(object sender, EventArgs e)
        {
            decimal v1 = this.nudOp1.Value;
            decimal v2 = this.nudOp2.Value;

            decimal total = v1 - v2;
            this.txtResultado.Text = total + "";
        }

        private void btnMultiplicacion_Click_1(object sender, EventArgs e)
        {
            decimal v1 = this.nudOp1.Value;
            decimal v2 = this.nudOp2.Value;

            decimal total = v1 * v2;
            this.txtResultado.Text = total + "";
        }

        private void btnDivision_Click_1(object sender, EventArgs e)
        {
            decimal v1 = this.nudOp1.Value;
            decimal v2 = this.nudOp2.Value;

            if (v2 == 0)
            {
                MessageBox.Show("No puede ser cero");
            }

            else
            {

                decimal total = v1 / v2;
                this.txtResultado.Text = total + "";
            }
        }
    }
}
