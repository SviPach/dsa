using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Security.Cryptography.RandomNumberGenerator;
using static DSA.Functions;
using System.IO;
using System.Security.Cryptography;
using System.IO.Compression;

namespace DSA
{
    public partial class Form1 : Form
    {
        class GenKeysInfo
        {
            public static BigInteger P;
            public static BigInteger Q;
            public static BigInteger N;
            public static BigInteger fN;
            public static BigInteger E = 65537;
            public static BigInteger D;
            
            private void CalculateN() { N = P * Q; }
            private void CalculateFn() { fN = (P - 1) * (Q - 1); }
            private void CalculateD() { D = ModInverse(E, fN); }
            
            public BigInteger GetP() { return P; }
            public BigInteger GetQ() { return Q; }
            public BigInteger GetN() { return N; }
            public BigInteger GetFn() { return fN; }
            public BigInteger GetE() { return E; }
            public BigInteger GetD() { return D; }
            
            public GenKeysInfo(BigInteger p, BigInteger q)
            {
                P = p;
                Q = q;
                CalculateN();
                CalculateFn();
                while (GCD(fN, E) != 1)
                {
                    E += 2;
                }
                CalculateD();
            }
        }

        private GenKeysInfo GeneratedKeysInfo = new GenKeysInfo(0, 0);
        public Form1()
        {
            InitializeComponent();
            button_keys_change.Enabled = false;
            button_signature_check.Enabled = false;
            button_file_sign.Enabled = false;
        }

        private string filePath;
        private string filePathTemp;
        private string archivePath;
        
        private void button_keys_generate_Click(object sender, EventArgs e)
        {
            BigInteger p = GenerateRandomBigInteger(1000000000000, 9999999999999);
            char[] pArray = p.ToString().ToCharArray();
            while (pArray[12] == '0' || pArray[12] == '2' || pArray[12] == '4' || pArray[12] == '5' || pArray[12] == '6' ||
                pArray[12] == '8' || !IsPrime(p))
            {
                p =  GenerateRandomBigInteger(1000000000000, 9999999999999);
                pArray = p.ToString().ToCharArray();
            }
            
            BigInteger q = GenerateRandomBigInteger(1000000000000, 9999999999999);
            char[] qArray = q.ToString().ToCharArray();
            while (qArray[12] == '0' || qArray[12] == '2' || qArray[12] == '4' || qArray[12] == '5' || qArray[12] == '6' ||
                   qArray[12] == '8' || !IsPrime(q))
            {
                q =  GenerateRandomBigInteger(1000000000000, 9999999999999);
                qArray = q.ToString().ToCharArray();
            }
            
            GeneratedKeysInfo = new GenKeysInfo(p, q);
            
            textBox_key_n.Text = GeneratedKeysInfo.GetN().ToString();
            textBox_key_e.Text = GeneratedKeysInfo.GetE().ToString();
            textBox_key_d.Text = GeneratedKeysInfo.GetD().ToString();
            
            MessageBox.Show($"P: {GeneratedKeysInfo.GetP().ToString()}" +
                            $"\nQ: {GeneratedKeysInfo.GetQ().ToString()}" +
                            $"\nfn: {GeneratedKeysInfo.GetFn().ToString()}" +
                            $"\nN: {GeneratedKeysInfo.GetN().ToString()}" +
                            $"\nE: {GeneratedKeysInfo.GetE().ToString()}" +
                            $"\nD: {GeneratedKeysInfo.GetD().ToString()}");
            

            textBox_key_n.ReadOnly = true;
            textBox_key_e.ReadOnly = true;
            textBox_key_d.ReadOnly = true;
            button_keys_generate.Enabled = false;
            button_keys_check.Enabled = false;
            
            button_signature_check.Enabled = true;
            button_file_sign.Enabled = true;
            button_keys_change.Enabled = true;
        }

        private void button_keys_change_Click(object sender, EventArgs e)
        {
            textBox_key_n.ReadOnly = false;
            textBox_key_e.ReadOnly = false;
            textBox_key_d.ReadOnly = false;
            button_keys_generate.Enabled = true;
            button_keys_check.Enabled = true;
            
            button_signature_check.Enabled = false;
            button_file_sign.Enabled = false;
            button_keys_change.Enabled = false;
        }

        private void button_keys_check_Click(object sender, EventArgs e)
        {
            if (BigInteger.TryParse(textBox_key_n.Text, out BigInteger N))
            {
                if (BigInteger.TryParse(textBox_key_e.Text, out BigInteger E))
                {
                    if (IsPrime(E))
                    {
                        button_signature_check.Enabled = true;
                    }
                    
                }
                if (BigInteger.TryParse(textBox_key_d.Text, out BigInteger D))
                {
                    button_file_sign.Enabled = true;
                }
                
            }
        
            if (button_signature_check.Enabled == false && button_file_sign.Enabled == false)
            {
                MessageBox.Show("Not a valid keys!");
                return;
            }
            
            textBox_key_n.ReadOnly = true;
            textBox_key_e.ReadOnly = true;
            textBox_key_d.ReadOnly = true;
            button_keys_generate.Enabled = false;
            button_keys_check.Enabled = false;
            
            button_keys_change.Enabled = true;
        }
        
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_generatedKeysInfo_Click(object sender, EventArgs e)
        {
            if (GeneratedKeysInfo.GetP() == 0 && GeneratedKeysInfo.GetQ() == 0)
            {
                MessageBox.Show("Generate new keys first!");
                return;
            }
            GeneratedKeysInfoForm Form2 = new GeneratedKeysInfoForm(
                GeneratedKeysInfo.GetP(), GeneratedKeysInfo.GetQ(),
                GeneratedKeysInfo.GetN(), GeneratedKeysInfo.GetFn(),
                GeneratedKeysInfo.GetE(), GeneratedKeysInfo.GetD());
            Form2.Show();
        }

        private void button_file_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                label_file_name.Text = Path.GetFileName(filePath);
            }
        }

        private void button_file_info_Click(object sender, EventArgs e)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            MessageBox.Show($"Input image characteristics:" +
                            $"\n- File name: {Path.GetFileName(filePath)}" +
                            $"\n- File extension: {Path.GetExtension(filePath)}" +
                            $"\n- Path: {filePath}" +
                            $"\n- Size: {fileInfo.Length} Bytes" +
                            $"\n- Modified: {fileInfo.LastWriteTime}");
        }

        private void button_file_sign_Click(object sender, EventArgs e)
        {
            string tempDirectory = Path.GetTempPath() + "tempDSA\\";
            try
            {
                Directory.Exists(tempDirectory);
            }
            catch
            {
                Directory.Delete(tempDirectory, true);
            }
            Directory.CreateDirectory(tempDirectory);
            string tempFilePath = Path.Combine(tempDirectory, Path.GetFileName(filePath));
            string tempSignaturePath = Path.Combine(tempDirectory, Path.GetFileNameWithoutExtension(filePath) + ".sign");
            
            byte[] content = File.ReadAllBytes(filePath);
            File.WriteAllBytes(tempFilePath, content);
            
            byte[] hash = GetSHA3_512Hash(content);
            // string signature = Convert.ToBase64String(TextEncrypt(hash, BigInteger.Parse(textBox_key_d.Text), BigInteger.Parse(textBox_key_n.Text)));
            string signature = TextEncrypt(hash, BigInteger.Parse(textBox_key_d.Text), BigInteger.Parse(textBox_key_n.Text));
            signature = "RSA_SHA3_512 " + signature;
            File.WriteAllText(tempSignaturePath, signature);
            MessageBox.Show("Signature generated!");
            
            
            
            string keysPublic = "RSA_Public_Key_BASE_64\n" + Convert.ToBase64String(BigInteger.Parse(textBox_key_n.Text).ToByteArray()) 
                                                    + "\n" + Convert.ToBase64String(BigInteger.Parse(textBox_key_e.Text).ToByteArray());
            string keysPublicPath = Path.GetDirectoryName(filePath) + "\\" + Path.GetFileNameWithoutExtension(filePath) + ".pub";
            File.WriteAllText(keysPublicPath, keysPublic);
            
            string keysPrivate = "RSA_Private_Key_BASE_64\n" +  Convert.ToBase64String(BigInteger.Parse(textBox_key_n.Text).ToByteArray()) 
                                                      + "\n" + Convert.ToBase64String(BigInteger.Parse(textBox_key_d.Text).ToByteArray());
            string keysPrivatePath = Path.GetDirectoryName(filePath) + "\\" + Path.GetFileNameWithoutExtension(filePath) + ".priv";
            File.WriteAllText(keysPrivatePath, keysPrivate);
            
            
            
            string archivePathCreated = Path.GetDirectoryName(filePath) + "\\" + Path.GetFileNameWithoutExtension(filePath) + ".zip";
            ZipFile.CreateFromDirectory(tempDirectory, archivePathCreated);
            
            Directory.Delete(tempDirectory, true);
            
            DeleteTempFile(tempFilePath);
            DeleteTempFile(tempSignaturePath);
        }

        private void button_signature_check_Click(object sender, EventArgs e)
        {
            if (archivePath == null)
            {
                MessageBox.Show("Please select archive to check signature!");
                return;
            }
            
            string tempDirectory = Path.GetTempPath() + "tempDSA\\";
            Directory.CreateDirectory(tempDirectory);
            ZipFile.ExtractToDirectory(archivePath, tempDirectory);
            
            string signedFile = Directory.GetFiles(tempDirectory, "*").FirstOrDefault(f => !f.EndsWith(".sign"));
            string signatureFile = Directory.GetFiles(tempDirectory, "*.sign").FirstOrDefault();
            if (signedFile == null || signatureFile == null)
            {
                MessageBox.Show("Wrong archive!");
                return;
            }
            
            byte[] hashFile64 = GetSHA3_512Hash(File.ReadAllBytes(signedFile));
            BigInteger bigIntTemp = new BigInteger(hashFile64);
            byte[] hashTemp = bigIntTemp.ToByteArray();
            
            
            string hashEncryptedB64 = File.ReadAllText(signatureFile).Substring(13);
            byte[] hashDecrypted = TextDecrypt(hashEncryptedB64, BigInteger.Parse(textBox_key_e.Text), BigInteger.Parse(textBox_key_n.Text));

            for (int i = 0; i < 64; i++)
            {
                if (hashFile64[i] != hashDecrypted[i])
                {
                    MessageBox.Show("Signature is invalid!");
                    Directory.Delete(tempDirectory, true);
                    return;
                }
            }
            
            MessageBox.Show("Signature is valid!");
            Directory.Delete(tempDirectory, true);
        }

        private void button_archive_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (Path.GetExtension(openFileDialog.FileName) != ".zip")
                {
                    MessageBox.Show("Please select .zip file!");
                    return;
                }
                archivePath = openFileDialog.FileName;
                label_archive_name.Text = Path.GetFileName(archivePath);
            }
        }

        private void button_public_key_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(openFileDialog.FileName);
                List<string> contentArray = content.Split('\n').ToList();
                textBox_key_n.Text = new BigInteger(Convert.FromBase64String(contentArray[1])).ToString();
                textBox_key_e.Text = new BigInteger(Convert.FromBase64String(contentArray[2])).ToString();
                MessageBox.Show($"Public key read!\n" +
                                $"Key N: {textBox_key_n.Text}\n" +
                                $"Key E: {textBox_key_e.Text}");
            }
            
            textBox_key_n.ReadOnly = false;
            textBox_key_e.ReadOnly = false;
            textBox_key_d.ReadOnly = false;
            button_keys_generate.Enabled = true;
            button_keys_check.Enabled = true;
            
            button_signature_check.Enabled = false;
            button_file_sign.Enabled = false;
            button_keys_change.Enabled = false;
        }

        private void button_private_key_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string content = File.ReadAllText(openFileDialog.FileName);
                List<string> contentArray = content.Split('\n').ToList();
                textBox_key_n.Text = new BigInteger(Convert.FromBase64String(contentArray[1])).ToString();
                textBox_key_d.Text = new BigInteger(Convert.FromBase64String(contentArray[2])).ToString();
                MessageBox.Show($"Private key read!\n" +
                                $"Key N: {textBox_key_n.Text}\n" +
                                $"Key D: {textBox_key_d.Text}");
            }
            
            textBox_key_n.ReadOnly = false;
            textBox_key_e.ReadOnly = false;
            textBox_key_d.ReadOnly = false;
            button_keys_generate.Enabled = true;
            button_keys_check.Enabled = true;
            
            button_signature_check.Enabled = false;
            button_file_sign.Enabled = false;
            button_keys_change.Enabled = false;
        }
    }
}