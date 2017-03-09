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
using Crypto;

namespace PasswordHash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Hash Functions
        public static string getBlake2b(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            Blake2B hashstring = new Blake2B();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
        public static string getHashSha3(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA384Managed hashstring = new SHA384Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
        public static string getHashSha256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        public static string getHashSha512(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA512Managed hashstring = new SHA512Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
        public static string getHashSha1(string text) //Deprecated
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA1Managed hashstring = new SHA1Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }

        public static string getRipemd160(string text) //Superseeded by SHA256
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            RIPEMD160Managed hashstring = new RIPEMD160Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
        public static string getMD5(string text) //Deprecated
        {
            // byte array representation of that string
            byte[] encodedPassword = new UTF8Encoding().GetBytes(text);

            // need MD5 to calculate the hash
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);

            // string representation (similar to UNIX format)
            string encoded = BitConverter.ToString(hash)
               // without dashes
               .Replace("-", string.Empty)
               // make lowercase
               .ToLower();

            // encoded contains the hash you are wanting
            return encoded;
        }
        #endregion
        private void credits_00(object sender, KeyEventArgs e)
        {
            if (e.Shift && e.KeyCode == Keys.F5)
            {
                MessageBox.Show("By Romel Vera\nhttps://www.keybase.io/romel","Credits",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        // Buttons ---------------------------------------------
        private void button1_Blake2b_Click(object sender, EventArgs e)
        {
            string password_toHash = textBox1_password.Text;
            string hash_result = getBlake2b(password_toHash);
            textBox1_result.Text = hash_result;
        }

        private void button1_sha256_Click(object sender, EventArgs e)
        {
            string password_toHash = textBox1_password.Text;
            string hash_result = getHashSha256(password_toHash);
            textBox1_result.Text = hash_result;
        }

        private void button1_sha512_Click(object sender, EventArgs e)
        {
            string password_toHash = textBox1_password.Text;
            string hash_result = getHashSha512(password_toHash);
            textBox1_result.Text = hash_result;
        }

        private void button1_sha384_Click(object sender, EventArgs e)
        {
            string password_toHash = textBox1_password.Text;
            string hash_result = getHashSha3(password_toHash);
            textBox1_result.Text = hash_result;
        }

        private void button1_sha1_Click(object sender, EventArgs e)
        {
            string password_toHash = textBox1_password.Text;
            string hash_result = getHashSha1(password_toHash);
            textBox1_result.Text = hash_result;
        }

        private void button_MD5_Click(object sender, EventArgs e)
        {
            string password_toHash = textBox1_password.Text;
            string hash_result = getMD5(password_toHash);
            textBox1_result.Text = hash_result;
        }

        private void button_RIPEMD160_Click(object sender, EventArgs e)
        {
            string password_toHash = textBox1_password.Text;
            string hash_result = getRipemd160(password_toHash);
            textBox1_result.Text = hash_result;
        }

    }
}
