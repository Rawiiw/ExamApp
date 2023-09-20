using Gst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ExamApp
{
    internal class CheckForText
    {
        public void CheckText(TextBox textBox) 
        {
                if (textBox.Text.Length > 0)
                {
                    textBox.Text = textBox.Text[0].ToString().ToUpper() + textBox.Text.Substring(1, textBox.Text.Length - 1);
                    textBox.SelectionStart = textBox.Text.Length;
                    textBox.SelectionLength = 0;
                }
                else
            {
                MessageBox.Show("Please enter ONLY numbers");
            }
            
        }
    }
}
