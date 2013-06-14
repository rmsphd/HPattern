using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Microsoft.SqlServer.MessageBox;

namespace Heurys.Patterns.HPattern
{
    public class StandardMessageBox
    {
        internal static bool Confirm(string message)
        {
            DialogResult r = MessageBox.Show(message, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return r == DialogResult.Yes;
        }

        internal static int Show(string message, string title, string[] btns, ExceptionMessageBoxSymbol messageBoxIcon, int defaultButton, ExceptionMessageBoxOptions messageBoxOptions)
        {
            ExceptionMessageBox emb = new ExceptionMessageBox(message,title,ExceptionMessageBoxButtons.Custom,messageBoxIcon,(ExceptionMessageBoxDefaultButton)defaultButton,messageBoxOptions);
            switch (btns.Length)
            {
                case 1:
                    emb.SetButtonText(btns[0]);
                    break;
                case 2:
                    emb.SetButtonText(btns[0],btns[1]);
                    break;
                case 3:
                    emb.SetButtonText(btns[0],btns[1],btns[2]);
                    break;
                case 4:
                    emb.SetButtonText(btns[0],btns[1],btns[2],btns[3]);
                    break;
                case 5:
                    emb.SetButtonText(btns[0],btns[1],btns[2],btns[3],btns[4]);
                    break;
            }
            emb.Show(null);
            return (int)(emb.CustomDialogResult - ExceptionMessageBoxDialogResult.Button1);
        }
    }

}
