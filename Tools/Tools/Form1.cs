using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Creates a file in the chosen directory
            string Equipment = "I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Equipment.txt";
            //Writes the information to the file (hence streamwriter)
            System.IO.StreamWriter ToFile;
            ToFile = new System.IO.StreamWriter(Equipment);
            //Sends data from the text box to the file
            ToFile.Write(txtEquip.Text);
            //Closes file once information has been sent 
            ToFile.Close();
            //Displays message box to show that it has sent to a file
            MessageBox.Show("Item has been requested");

            //Creates a file in the chosen directory
            string Features = "I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Features.txt";
            //Writes the information to the file (hence streamwriter)
            System.IO.StreamWriter ToFileFeatures;
            
            ToFileFeatures = new System.IO.StreamWriter(Features);
            //Sends data from the text box to the file
            ToFileFeatures.Write(txtFeatures.Text);
            //Closes file once information has been sent 
            ToFileFeatures.Close();
            //Displays message box to show that it has sent to a file
            MessageBox.Show("Item has been requested");

            //Creates a file in the chosen directory
            string Reason = "I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Reason.txt";
            //Writes the information to the file (hence streamwriter)
            System.IO.StreamWriter ToFileReason;

            ToFileReason = new System.IO.StreamWriter(Reason);
            //Sends data from the text box to the file
            ToFileReason.Write(txtRea.Text);
            //Closes file once information has been sent 
            ToFileReason.Close();
            //Displays message box to show that it has sent to a file
            MessageBox.Show("Reason has been submitted");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {

                if (rdoKid.Checked == true)
                {
                    // Pulls the information from the text file
                    string[] lines = System.IO.File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Equipment.txt");
                    //Adds the information the correct listbox
                    lstKidderminster.Items.AddRange(lines);

                    // Pulls the information from the text file
                    string[] text = System.IO.File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Features.txt");
                    //Adds the information the correct listbox
                    lstKidderminster.Items.AddRange(text);

                    // Pulls the information from the text file
                    string[] Reasons = System.IO.File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Reasons.txt");
                    //Adds the information the correct listbox
                    lstKidderminster.Items.AddRange(Reasons);
                }
                else if (rdoMal.Checked == true)
                {
                    // Pulls the information from the text file
                    string[] A = System.IO.File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Equipment.txt");
                    //Adds the information the correct listbox
                    lstMalvern.Items.AddRange(A);

                    // Pulls the information from the text file
                    string[] B = System.IO.File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Features.txt");
                    //Adds the information the correct listbox
                    lstMalvern.Items.AddRange(B);

                    // Pulls the information from the text file
                    string[] G = System.IO.File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Reasons.txt");
                    //Adds the information the correct listbox
                    lstMalvern.Items.AddRange(G);
                }
                else if (rdoRed.Checked == true)
                {
                    // Pulls the information from the text file
                    string[] C = System.IO.File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Equipment.txt");
                    //Adds the information the correct listbox
                    lstReddtich.Items.AddRange(C);

                    // Pulls the information from the text file
                    string[] D = System.IO.File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Features.txt");
                    //Adds the information the correct listbox
                    lstReddtich.Items.AddRange(D);

                    // Pulls the information from the text file
                    string[] H = System.IO.File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Reasons.txt");
                    //Adds the information the correct listbox
                    lstReddtich.Items.AddRange(H);
                }
                else if (rdoWorc.Checked == true)
                {
                    // Pulls the information from the text file
                    string[] E = System.IO.File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Equipment.txt");
                    //Adds the information the correct listbox
                    lstWorcester.Items.AddRange(E);

                    // Pulls the information from the text file
                    string[] F = System.IO.File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Features.txt");
                    //Adds the information the correct listbox
                    lstWorcester.Items.AddRange(F);

                    // Pulls the information from the text file
                    string[] I = System.IO.File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Reasons.txt");
                    //Adds the information the correct listbox
                    lstWorcester.Items.AddRange(I);
                }

                else
                {
                    //If no location has been checked then this message will appear telling the user to add an location
                    MessageBox.Show("Please enter a location");
                }

            }
                
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //Creates a new instance of the login page
            Login log = new Login();
            //displays the login page
            log.ShowDialog();
            
        }
    }
}
