using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tools
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            //If manager radio button has been checked 
            if (rdoMan.Checked == true)
            {
                //Sets the path for where the file will be located
                string path = "I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\ManagersTwo";
                //Sets it that the username and password are located on the same line seperarted by the comma by doing this it saves writing out the file directory each time.
                string line = txtUser.Text + "," + txtPass.Text;
                //checks that the path exists and is active
                if (!File.Exists(path))
                {
                    //Creates a new instance of the stream writer and sets the file directory 
                    FileStream users = new FileStream("I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\ManagersTwo", FileMode.Open, FileAccess.Read);
                    //Creates an instance of streamreader
                    StreamReader su = new StreamReader(users);
                    //If the text fields equal the stream reader where it is refered to the users (file directory) then readline it checks that the information stored in the text file is equal to what the user has submitted
                    if (line == su.ReadLine())
                    {
                        //message box displays saying the user has logged in 
                        MessageBox.Show(txtUser.Text + " successfully logged in");
                        //Provides a stream to the file and creates an new instance of filestream
                        FileStream cred = new FileStream(path, FileMode.Create, FileAccess.Write);
                        //Create a new instance of streamwriter 
                        StreamWriter sw = new StreamWriter(cred);

                        //Writes to the text file
                        sw.WriteLine(line);
                        //closes the streamwiter
                        sw.Close();
                        //closes the file stream
                        cred.Close();

                    }
                    else
                    {
                        // If the information doenst match what is in the text file then it display this message
                        MessageBox.Show("Incorrect Username/Password");
                    }
                    if(rdoMan.Checked == true)
                    {
                        //Creates a new istance of the manager page
                        Manager man = new Manager();
                        //Dislays the managers page
                        man.ShowDialog();
                    }
                }
                

            }
            //If the staff radio button is checked
            if (rdoStaff.Checked == true)
            {
                //Sets the file directory for the text file 
                string path = "I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Staff.txt";
                //Sets it that the username and password are located on the same line seperarted by the comma
                string line = txtUser.Text + "," + txtPass.Text;
                //checks that the path exists and is active
                if (!File.Exists(path))
                {
                    //Sets it that the username and password are located on the same line seperarted by the comma by doing this it saves writing out the file directory each time.
                    FileStream users = new FileStream("I:\\Documents\\A1\\Tools\\Tools\\bin\\Debug\\Staff.txt", FileMode.Open, FileAccess.Read);
                    //Creates an instance of streamreader
                    StreamReader su = new StreamReader(users);
                    //If the text fields equal the stream reader where it is refered to the users (file directory) then readline it checks that the information stored in the text file is equal to what the user has submitted
                    if (line == su.ReadLine())
                    {
                        //message box displays saying the user has logged in 
                        MessageBox.Show(txtUser.Text + " successfully logged in");
                        //Provides a stream to the file and creates an new instance of filestream
                        FileStream cred = new FileStream(path, FileMode.Create, FileAccess.Write);
                        //Create a new instance of streamwriter 
                        StreamWriter sw = new StreamWriter(cred);
                        //Writes to the text file
                        sw.WriteLine(line);
                        //closes the streamwiter
                        sw.Close();
                        //closes the file stream
                        cred.Close();

                    }
                    else
                    {
                        // If the information doenst match what is in the text file then it display this message
                        MessageBox.Show("Incorrect Username/Password");
                    }
                    if(rdoStaff.Checked== true)
                    {
                        //Creates new instance of form 1
                        Form1 Staff = new Form1();
                        //Displays form 1
                        Staff.ShowDialog();
                    }
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
