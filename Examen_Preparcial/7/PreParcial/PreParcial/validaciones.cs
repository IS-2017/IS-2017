using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PreParcial
{
    class validaciones
    {
        public void validacion_sololetras(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsLetter(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Llene el campo con letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                // MessageBox.Show("Llene el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void validacion_solonumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;

                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("Llene el campo con numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                //MessageBox.Show("Llene el campo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
