using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    internal static class Program
    {


        static DialogResult GetDialogResult()
        {
            DialogResult result;
            string message = "Window displaying a text message";
            //result=MessageBox.Show(message);

            string caption = "C# Language";
            // result = MessageBox.Show(message, caption, MessageBoxButtons.OKCancel);
             result = MessageBox.Show(message, caption, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error);

            return result;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //var result=GetDialogResult();
            //if (result == DialogResult.OK)
            //{
            //    MessageBox.Show("OKAY");
            //}
            //else
            //{
            //    MessageBox.Show("CANCEL");
            //}


            //var result = GetDialogResult();
            //if (result == DialogResult.Yes)
            //{
            //    MessageBox.Show("Yes");
            //}
            //else if(result== DialogResult.No)
            //{
            //    MessageBox.Show("No");
            //}
            //else
            //{
            //    MessageBox.Show("CANCEL");
            //}

        }
    }
}
