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



namespace BoosterPanel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double runNumber1 = 0;
        double runNumber2 = 0;
        double runNumber3 = 0;
        double runNumber4 = 0;

        string textName1 = "Empty";
        string textName2 = "Empty";
        string textName3 = "Empty";
        string textName4 = "Empty";
        string txStr;

        int addClients = 1;

       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonPlusRun1_Click(object sender, RoutedEventArgs e)
        {
            runNumber1 += .5;
            labelRun1.Content = runNumber1.ToString();
        }

        private void buttonMinusRun1_Click(object sender, RoutedEventArgs e)
        {
            runNumber1 -= .5;

            if(runNumber1 < 0)
            {
                runNumber1 = 0;
            }
            labelRun1.Content = runNumber1.ToString();

            
        }

        private void buttonPlusRun2_Click(object sender, RoutedEventArgs e)
        {
            runNumber2 += .5;
            labelRun2.Content = runNumber2.ToString();
        }

        private void buttonMinusRun2_Click(object sender, RoutedEventArgs e)
        {
            runNumber2 -= .5;
            if (runNumber2 < 0)
            {
                runNumber2 = 0;
            }
            labelRun2.Content = runNumber2.ToString();
        }

        private void buttonPlusRun3_Click(object sender, RoutedEventArgs e)
        {
            runNumber3 += .5;
            labelRun3.Content = runNumber3.ToString();
        }

        private void buttonMinusRun3_Click(object sender, RoutedEventArgs e)
        {
            runNumber3 -= .5;
            if (runNumber3 < 0)
            {
                runNumber3 = 0;
            }
            labelRun3.Content = runNumber3.ToString();
        }

        private void buttonPlusRun4_Click(object sender, RoutedEventArgs e)
        {
            runNumber4 += .5;
            labelRun4.Content = runNumber4.ToString();
        }

        private void buttonMinusRun4_Click(object sender, RoutedEventArgs e)
        {
            runNumber4 -= .5;
            if (runNumber4 < 0)
            {
                runNumber4 = 0;
            }
            labelRun4.Content = runNumber4.ToString();
        }

        private void resetButt1_Click(object sender, RoutedEventArgs e)
        {
            runNumber1 = 0;
            labelRun1.Content = runNumber1.ToString();
            txBoxName1.Text = "";
            textName1 = "Empty";
            txBoxName1.IsReadOnly = false;
            nameRect1.Visibility = Visibility.Visible;

        }

        private void resetButt2_Click(object sender, RoutedEventArgs e)
        {
            runNumber2 = 0;
            labelRun2.Content = runNumber2.ToString();
            txBoxName2.Text = "";
            textName2 = "Empty";
            txBoxName2.IsReadOnly = false;
            nameRect2.Visibility = Visibility.Visible;
        }

        private void resetButt3_Click(object sender, RoutedEventArgs e)
        {
            runNumber3 = 0;
            labelRun3.Content = runNumber3.ToString();
            txBoxName3.Text = "";
            textName3 = "Empty";
            txBoxName3.IsReadOnly = false;
            nameRect3.Visibility = Visibility.Visible;
        }

        private void resetButt4_Click(object sender, RoutedEventArgs e)
        {
            runNumber4 = 0;
            labelRun4.Content = runNumber4.ToString();
            txBoxName4.Text = "";
            textName4 = "Empty";
            txBoxName4.IsReadOnly = false;
            nameRect4.Visibility = Visibility.Visible;
        }

        private void txBoxName1_KeyDown(object sender, KeyEventArgs e)
        {
                       
                if (e.Key == Key.Return)
                {
                    textName1 = txBoxName1.Text;

                    txBoxName1.IsReadOnly = true;
                nameRect1.Visibility = Visibility.Hidden;
                if (textName1 == "" || textName1 == " ")
                {
                    textName1 = "Empty";
                }
            }
            if (e.Key == Key.Tab)
            {
                textName1 = txBoxName1.Text;

                txBoxName1.IsReadOnly = true;
                nameRect1.Visibility = Visibility.Hidden;
                if (textName1 == "" || textName1 == " ")
                {
                    textName1 = "Empty";
                }
            }
            

        }

        private void txBoxName2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                textName2 = txBoxName2.Text;

                txBoxName2.IsReadOnly = true;
                nameRect2.Visibility = Visibility.Hidden;
                if (textName2 == "" || textName2 == " ")
                {
                    textName2 = "Empty";
                }

            }
            if (e.Key == Key.Tab)
            {
                textName2 = txBoxName2.Text;

                txBoxName2.IsReadOnly = true;
                nameRect2.Visibility = Visibility.Hidden;
                if (textName2 == "" || textName2 == " ")
                {
                    textName2 = "Empty";
                }

            }
            
        }

        private void txBoxName3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                textName3 = txBoxName3.Text;

                txBoxName3.IsReadOnly = true;
                nameRect3.Visibility = Visibility.Hidden;
                if (textName3 == "" || textName3 == " ")
                {
                    textName3 = "Empty";
                }
            }
            if (e.Key == Key.Tab)
            {
                textName3 = txBoxName3.Text;

                txBoxName3.IsReadOnly = true;
                nameRect3.Visibility = Visibility.Hidden;
                if (textName3 == "" || textName3 == " ")
                {
                    textName3 = "Empty";
                }
            }
            
        }

        private void txBoxName4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txBoxName4.IsReadOnly = true;
                nameRect4.Visibility = Visibility.Hidden;
                textName4 = txBoxName4.Text;
                if(textName4 == "" || textName4 == " ")
                {
                    textName4 = "Empty";
                }
                
                
            }
            if (e.Key == Key.Tab)
            {
                textName4 = txBoxName4.Text;

                txBoxName4.IsReadOnly = true;
                nameRect4.Visibility = Visibility.Hidden;

                if (textName4 == "" || textName4 == " ")
                {
                    textName4 = "Empty";
                }
            }
            
        }

        private void copyClip1_Click(object sender, RoutedEventArgs e)
        {
           Clipboard.SetText("Current Balances: " + textName1 + ": " + runNumber1 + " || " + textName2 + ": " + runNumber2 + " || " + textName3 + ": " + runNumber3 + " || " + textName4 + ": " + runNumber4 + " || ");
        }

        private void addClientsButt_Click(object sender, RoutedEventArgs e)
        {
            addClients += 1;

            if(addClients > 4)
            {
                addClients = 1;
            }
            clientsLabel.Content = addClients;

      
        }

        private void textBoxString_KeyDown(object sender, KeyEventArgs e)
        {
            



            if (e.Key == Key.Return)
            {               

                textBoxString.IsReadOnly = true;
                nameRect5.Visibility = Visibility.Hidden;
            }
            if (e.Key == Key.Tab)
            {

                textBoxString.IsReadOnly = true;
                nameRect5.Visibility = Visibility.Hidden;
            }


            
        }

        private void textBoxEdit_Click(object sender, RoutedEventArgs e)
        {
            textBoxString.IsReadOnly = false;
            nameRect5.Visibility = Visibility.Visible;
        }

        private void copyClip1_Copy_Click(object sender, RoutedEventArgs e)
        {
            if(addClients == 1)
            {
                txStr = textBoxString.Text;
                Clipboard.SetText(txStr + " (" + addClients + " slot remaining)");
            }
            else{
                txStr = textBoxString.Text;
                Clipboard.SetText(txStr + " (" + addClients + " slots remaining)");
            }
        }

        /*private void textBoxString_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            using (tb.DeclareChangeBlock())
            {
                foreach (var c in e.Changes)
                {
                    if (c.AddedLength == 0) continue;
                    tb.Select(c.Offset, c.AddedLength);
                    if (tb.SelectedText.Contains("#"))
                    {
                        tb.SelectedText = tb.SelectedText.Replace("#",Convert.ToString(addClients) );
                    }
                    tb.Select(c.Offset + c.AddedLength, 0);
                }
            }
        }*/

        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}

