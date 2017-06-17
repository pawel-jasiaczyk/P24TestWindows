using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Przelewy24;
using System.Diagnostics;

namespace P24TestWindow
{
    public partial class Form1 : Form
    {
        private Przelewy24.Przelewy24 p24;
        private Przelewy24.Transaction transaction;
        private string redirectLink;
        
        public Form1 ()
        {
            InitializeComponent ();
            CreateTestMerchant ();
            CreateTestTransaction ();
        }

        private void CreateTestMerchant()
        {
            this.p24 = new Przelewy24.Przelewy24 ("49518", "49518", "d13be93f322c7ec3", true);
            
            this.textBoxMerchantId.Text = p24.MerchantId;
            this.textBoxPosId.Text = p24.PosId;
            this.textBoxCrc.Text = p24.CrcKey;
            this.checkBoxSandBox.Checked = p24.SandboxMode;
        }

        private void CreateTestTransaction()
        {
            this.transaction =
                new Przelewy24.Transaction (
                    this.p24,
                    Przelewy24.SessionIdGenerationMode.time,
                    "",
                    "100",
                    "PLN",
                    "Test",
                    "pawel.jasiaczyk@przelewy24.pl",
                    "PL",
                    "http://www.przelewy24.pl"
                    );

            this.textBoxSessionId.Text = transaction.P24_session_id;
            this.textBoxAmount.Text = transaction.P24_amount;
            this.textBoxCurrency.Text = transaction.P24_currency;
            this.textBoxDescription.Text = transaction.P24_description;
            this.textBoxEmail.Text = transaction.P24_email;
            this.textBoxCountry.Text = transaction.P24_country;
            this.textBoxUrlReturn.Text = transaction.P24_url_return;
            this.textBoxApiVersion.Text = transaction.P24_api_version;

            this.textBoxSign.Text = transaction.RegisterSign;
        }

        private async void btnTest_Click (object sender, EventArgs e)
        {
            var result = await p24.TestConnection ();
            this.textBoxResult.Text = result.ToString ();
        }

        private void btnUpdate_Click (object sender, EventArgs e)
        {
            this.p24.MerchantId = this.textBoxMerchantId.Text.Trim();
            this.p24.PosId = this.textBoxPosId.Text.Trim();
            this.p24.CrcKey = this.textBoxCrc.Text.Trim();

            if (this.checkBoxSessionId.Checked)
                this.transaction.P24_session_id = this.textBoxSessionId.Text.Trim();
            else
            {
                this.transaction.SetUniqueSessionId (Przelewy24.SessionIdGenerationMode.time, "");
                this.textBoxSessionId.Text = this.transaction.P24_session_id;
            }

            this.transaction.P24_amount = this.textBoxAmount.Text.Trim();
            this.transaction.P24_currency = this.textBoxCurrency.Text.Trim();
            this.transaction.P24_description = this.textBoxDescription.Text.Trim();
            this.transaction.P24_email = this.textBoxEmail.Text.Trim();
            this.transaction.P24_country = this.textBoxCountry.Text.Trim();
            this.transaction.P24_url_return = this.textBoxUrlReturn.Text.Trim();
            this.textBoxSign.Text = this.transaction.RegisterSign;

            this.p24.SandboxMode = this.checkBoxSandBox.Checked;
        }

        private async void btnRegister_Click (object sender, EventArgs e)
        {
            var result = await this.transaction.RegisterTransaction ();
            char[] seps = new char[] { '&' };
            string[] words;
            words = result.Split (seps);
            if (words[0] == "error=0")
            {
                string token = words[1].Substring(6);
                this.textBoxToken.Text = token;
                this.btnBrowser.Enabled = true;
                this.redirectLink = this.p24.UrlTrnRequest + "/" + token;
                this.textBoxResult.Text = this.redirectLink;
            }
            else
            {
                this.textBoxToken.Text = "";
                this.textBoxResult.Text = result.ToString ();
                this.btnBrowser.Enabled = false;
            }
        }

        private void btnBrowser_Click (object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo (redirectLink);
            Process.Start (sInfo);
        }
    }
}
