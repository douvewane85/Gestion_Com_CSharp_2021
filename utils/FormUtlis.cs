using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_commercial.utils
{
    public class FormUtils
    {
        public static void desactiveFied(Button btnAdd, Button btnUp, Button btnDel, Action action)
        {
            btnAdd.Enabled = false;
            btnUp.Enabled = false;
            btnDel.Enabled = false;
            switch (action)
            {
                case Action.ADD:
                    btnAdd.Enabled = true;
                    break;
                default:
                    btnUp.Enabled = true;
                    btnDel.Enabled = true;
                    break;
            }

        }

        public  static void clearFieds(GroupBox groupBox)
        {
            foreach(var control in groupBox.Controls)
            {
                if( control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
            }
        }
    }
}
