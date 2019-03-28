/*
Conner Warboys
Short Form Translator Project
March 28th, 2019
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _185338TxtMSG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnTranslate_Click(object sender, RoutedEventArgs e)
        {
            string textInput = txtInput.Text;

            textInput = txtInput.Text.ToUpper();

            textInput = textInput.Replace("CUZ", "Because" + Environment.NewLine);
            textInput = textInput.Replace("CU","See you" + Environment.NewLine);
            textInput = textInput.Replace(":-)","I'm happy" + Environment.NewLine);
            textInput = textInput.Replace(":-)","I'm unhappy" + Environment.NewLine);
            textInput = textInput.Replace(";-)","Wink" + Environment.NewLine);
            textInput = textInput.Replace(":-P","Stick my tongue out" + Environment.NewLine);
            textInput = textInput.Replace("(~,~)","Sleepy" + Environment.NewLine);
            textInput = textInput.Replace("TA","Totally awesome" + Environment.NewLine);
            textInput = textInput.Replace("CCC","Canadian Computing Competition" + Environment.NewLine);
            textInput = textInput.Replace("TTYL", "Talk to you later" + Environment.NewLine);
            textInput = textInput.Replace("TY","Thank you" + Environment.NewLine);
            textInput = textInput.Replace("YW", "You're welcome" + Environment.NewLine);
            
            if (txtInput.Text == "TTYL")
            {
                this.Close();
            }

            lblOutput.Content = " " + textInput;

                

        }
    

    }
}
    

