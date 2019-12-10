using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            
            //If manager radio button has been ckecked 
            if (rdoAddMan.Checked == true)
            {
                //sets the file directory 
                string path = "I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\ManagersTwo";
                //adds username and password to the text file
                string line = txtAddUser.Text + "," + txtAddPass.Text;
                //checks the file exists
                if (!File.Exists(path))
                {
                    //A message displays saying the user has been added correctly 
                    MessageBox.Show(txtAddUser.Text + " successfully created.");
                    //Provides a stream to the file and creates an new instance of filestream
                    FileStream cred = new FileStream(path, FileMode.Create, FileAccess.Write);
                    //Create a new instance of streamwriter 
                    StreamWriter sw = new StreamWriter(cred);
                    //writes it to the text file
                    sw.WriteLine(line);
                    //closes the stream file
                    sw.Close();
                    //Closes the Stream writer 
                    cred.Close();
                }
            }

            if (rdoAddStaff.Checked == true)
            {

                //sets the file directory 
                string pat = "I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Staff.txt";
                //adds username and password to the text file
                string lin = txtAddUser.Text + "," + txtAddPass.Text;
                //checks the file exists
                if (!File.Exists(pat))
                {
                    //A message displays saying the user has been added correctly 
                    MessageBox.Show(txtAddUser.Text + " successfully created.");
                    //Provides a stream to the file and creates an new instance of filestream
                    FileStream cred = new FileStream(pat, FileMode.Create, FileAccess.Write);
                    //Create a new instance of streamwriter 
                    StreamWriter sw = new StreamWriter(cred);
                    //writes it to the text file
                    sw.WriteLine(lin);
                    //closes the file stream
                    sw.Close();
                    //closes the stream writer
                    cred.Close();
                }
            }

        }

        private void Manager_Load(object sender, EventArgs e)
        {
            
                // Pulls the information from the text file
                string[] lines = File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Equipment.txt");
                //Adds the information the correct listbox
                lstDisplay.Items.AddRange(lines);

                // Pulls the information from the text file
                string[] text = File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Features.txt");
                //Adds the information the correct listbox
                lstDisplay.Items.AddRange(text);

                // Pulls the information from the text file
                string[] Dis = File.ReadAllLines(@"I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Reasons.txt");
                //Adds the information the correct listbox
                lstDisplay.Items.AddRange(Dis);

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            //If the approved check box has been checked 
            if (chkItemsApproved.Checked == true)
            {
                //If the checkbox has been checked then it will display a message saying that the items have been approved
                MessageBox.Show("The items have been approved");
            }
            //If the non approved check box has been checked 
            if (chkNo.Checked == true)
            {
                //If the checkbox has been checked then it will display a message sayoing the items have not been approved
                MessageBox.Show("The items have not been approved");
                //If the items have not been approved then it will remove those items from the text file
                lstDisplay.Items.Clear();
            }
        }
    }
}
