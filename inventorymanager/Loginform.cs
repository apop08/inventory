using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace inventorymanager
{
    public partial class Loginform : Form
    {
        inventoryEntities test;
        RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
        public Loginform()
        {
            test = new inventoryEntities();
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            InitializeComponent();
            LoadToGrid();
        }

        private void CreateLogin_Click(object sender, EventArgs e)
        {
            try
            {
                login loginToAdd = new login
                {
                    username = Userhash.Text,
                    pass = PassHashOne.Text
                };
                test.logins.Add(loginToAdd);
                test.SaveChanges();
                MessageBox.Show("Record Inserted successfully.");
                LoadToGrid();
            }
            catch
            {
                MessageBox.Show("Error on insert");
            }
        }

        private void LoginLogin_Click(object sender, EventArgs e)
        {
            login loginToCheck = new login
            {
                username = Userhash.Text,
                pass = PassHashOne.Text
            };
            var load = from g in test.logins where (g.username.Equals(loginToCheck.username)) select g;
            try
            {
                if (load != null)
                {
                    if (load.Any())
                    {
                        login CheckPass = load.First();
                        if (CheckPass.pass.Equals(loginToCheck.pass))
                        {
                            storelistmanage form = new storelistmanage();
                            form.Show();
                            this.Hide();
                            MessageBox.Show("Login Successful");
                            return;
                        }

                    }
                    
                }
                MessageBox.Show("Login Fail");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.ToString());
            }
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void LoadToGrid()
        {
            //need to change display formating
            var load = from g in test.logins select g;
            if (load != null)
            {
                dataGridView1.DataSource = load.ToList();
            }
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
            byte[] rawUser = Encoding.ASCII.GetBytes(Username.Text);
            byte[] resultOneUser;
            byte[] resultTwoUser;
            
            SHA256 Sha = new SHA256Managed();
            resultOneUser = Sha.ComputeHash(rawUser);
            Userhash.Text = Encoding.Unicode.GetString(resultOneUser);
            resultTwoUser = Encrypt(resultOneUser, RSA.ExportParameters(false), false);
            UserHashTwo.Text = Encoding.Unicode.GetString(resultTwoUser);
        }

        private void PasswordLogin_TextChanged(object sender, EventArgs e)
        {
            byte[] rawPass = Encoding.ASCII.GetBytes(PasswordLogin.Text);
            byte[] resultOnePass;
            byte[] resultTwoPass;
            SHA256 Sha = new SHA256Managed();
            resultOnePass = Sha.ComputeHash(rawPass);
            PassHashOne.Text = Encoding.Unicode.GetString(resultOnePass);
            resultTwoPass = Encrypt(resultOnePass, RSA.ExportParameters(false), false);
            PassHashTwo.Text = Encoding.Unicode.GetString(resultTwoPass);
        }

        static public byte[] Encrypt(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] encrypt;
                RSACryptoServiceProvider RSA = new RSACryptoServiceProvider();
                RSA.ImportParameters(RSAKey); encrypt = RSA.Encrypt(Data, DoOAEPPadding);
                
                return encrypt;
            }
            catch (CryptographicException ex)
            { 
                MessageBox.Show(ex.InnerException.ToString());
                return null;
            }
        }
        static public byte[] Decrypt(byte[] Data, RSAParameters RSAKey, bool DoOAEPPadding)
        {
            try
            {
                byte[] decrypt;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAKey);
                    decrypt = RSA.Decrypt(Data, DoOAEPPadding);
                }
                return decrypt;
            }
            catch (CryptographicException ex)
            {
                MessageBox.Show(ex.InnerException.ToString());
                return null;
            }
        }
    }
}
