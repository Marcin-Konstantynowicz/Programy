using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Windows;
using System.Diagnostics;

namespace BramkaSMS_GSMService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        public System.Windows.Forms.ComboBox.ObjectCollection Items { get; }
        private void send_Click(object sender, EventArgs e)
        {
            this.timer2.Start();
            int i;

            progressBar2.Minimum = 0;
            progressBar2.Maximum = 200;

            for (i = 0; i <= 200; i++)
            {
                progressBar2.Value = i;
            }
            // Utworzenie obiektu Web Services
            GSMServiceAPI.GSMServicePortTypeClient ws = new GSMServiceAPI.GSMServicePortTypeClient();

            // Obiekt Account - zawiera login oraz haslo do konta API
            GSMServiceAPI.Account account1 = new GSMServiceAPI.Account();
            account1.login = login.Text;
            account1.pass = pass.Text;

            GSMServiceAPI.Account account2 = new GSMServiceAPI.Account();
            account2.login = login.Text;
            account2.pass = pass.Text;

            GSMServiceAPI.Account account3 = new GSMServiceAPI.Account();
            account3.login = login.Text;
            account3.pass = pass.Text;

            GSMServiceAPI.Account account4 = new GSMServiceAPI.Account();
            account4.login = login.Text;
            account4.pass = pass.Text;

            GSMServiceAPI.Account account5 = new GSMServiceAPI.Account();
            account5.login = login.Text;
            account5.pass = pass.Text;

            GSMServiceAPI.Account account6 = new GSMServiceAPI.Account();
            account6.login = login.Text;
            account6.pass = pass.Text;

            GSMServiceAPI.Account account7 = new GSMServiceAPI.Account();
            account7.login = login.Text;
            account7.pass = pass.Text;

            GSMServiceAPI.Account account8 = new GSMServiceAPI.Account();
            account8.login = login.Text;
            account8.pass = pass.Text;

            GSMServiceAPI.Account account9 = new GSMServiceAPI.Account();
            account9.login = login.Text;
            account9.pass = pass.Text;

            // Tablica obiektów Message - zawiera wiadomosci SMS, ktore maja byc wyslane.
            // W przykladzie jest to 1 element = 1 wiadomosc
            GSMServiceAPI.Message[] messages = new GSMServiceAPI.Message[1];
            messages[0] = new GSMServiceAPI.Message();
            messages[0].recipients = new string[] { recipient.Text }; // Numer telefonu odbiorcy
            messages[0].message = message.Text; // Tresc wiadomosci

            GSMServiceAPI.Message[] messages2 = new GSMServiceAPI.Message[1];
            messages2[0] = new GSMServiceAPI.Message();
            messages2[0].recipients = new string[] { recipient2.Text }; // Numer telefonu odbiorcy
            messages2[0].message = message.Text; // Tresc wiadomosci

            GSMServiceAPI.Message[] messages3 = new GSMServiceAPI.Message[1];
            messages3[0] = new GSMServiceAPI.Message();
            messages3[0].recipients = new string[] { recipient3.Text }; // Numer telefonu odbiorcy
            messages3[0].message = message.Text; // Tresc wiadomosci

            GSMServiceAPI.Message[] messages4 = new GSMServiceAPI.Message[1];
            messages4[0] = new GSMServiceAPI.Message();
            messages4[0].recipients = new string[] { recipient4.Text }; // Numer telefonu odbiorcy
            messages4[0].message = message.Text; // Tresc wiadomosci

            GSMServiceAPI.Message[] messages5 = new GSMServiceAPI.Message[1];
            messages5[0] = new GSMServiceAPI.Message();
            messages5[0].recipients = new string[] { recipient5.Text }; // Numer telefonu odbiorcy
            messages5[0].message = message.Text; // Tresc wiadomosci

            GSMServiceAPI.Message[] messages6 = new GSMServiceAPI.Message[1];
            messages6[0] = new GSMServiceAPI.Message();
            messages6[0].recipients = new string[] { recipient6.Text }; // Numer telefonu odbiorcy
            messages6[0].message = message.Text; // Tresc wiadomosci

            GSMServiceAPI.Message[] messages7 = new GSMServiceAPI.Message[1];
            messages7[0] = new GSMServiceAPI.Message();
            messages7[0].recipients = new string[] { recipient7.Text }; // Numer telefonu odbiorcy
            messages7[0].message = message.Text; // Tresc wiadomosci
 
            GSMServiceAPI.Message[] messages8 = new GSMServiceAPI.Message[1];
            messages8[0] = new GSMServiceAPI.Message();
            messages8[0].recipients = new string[] { recipient8.Text }; // Numer telefonu odbiorcy
            messages8[0].message = message.Text; // Tresc wiadomosci

            GSMServiceAPI.Message[] messages9 = new GSMServiceAPI.Message[1];
            messages9[0] = new GSMServiceAPI.Message();
            messages9[0].recipients = new string[] { recipient9.Text }; // Numer telefonu odbiorcy
            messages9[0].message = message.Text; // Tresc wiadomosci

            // Wysyłanie SMS - wywolanie metody SendSMS
            GSMServiceAPI.SendSMSReturn[] sendResult1 = ws.SendSMS(account1, messages);
            GSMServiceAPI.SendSMSReturn[] sendResult2 = ws.SendSMS(account2, messages2);
            GSMServiceAPI.SendSMSReturn[] sendResult3 = ws.SendSMS(account3, messages3);

            GSMServiceAPI.SendSMSReturn[] sendResult4 = ws.SendSMS(account4, messages4);
            GSMServiceAPI.SendSMSReturn[] sendResult5 = ws.SendSMS(account5, messages5);
            GSMServiceAPI.SendSMSReturn[] sendResult6 = ws.SendSMS(account6, messages6);

            GSMServiceAPI.SendSMSReturn[] sendResult7 = ws.SendSMS(account7, messages7);
            GSMServiceAPI.SendSMSReturn[] sendResult8 = ws.SendSMS(account8, messages8);
            GSMServiceAPI.SendSMSReturn[] sendResult9 = ws.SendSMS(account9, messages9);

            // Obsluga odpowiedzi z bramki SMS:
            logBox.Text = "Status żądania: \n" + sendResult1[0].status +
                          ", Nr odbiorcy: \n" + sendResult1[0].recipient + ", ID wiadomości: \n" + sendResult1[0].msgId + ", Liczba części: \n" + sendResult1[0].parts +
                          ", Koszt: \n" + sendResult1[0].price + "\r\n" + logBox.Text;

            logBox.Text = "Status żądania: \n" + sendResult2[0].status +
                          ", Nr odbiorcy: \n" + sendResult2[0].recipient + ", ID wiadomości: \n" + sendResult2[0].msgId + ", Liczba części: \n" + sendResult2[0].parts +
                          ", Koszt: \n" + sendResult2[0].price + "\r\n" + logBox.Text;

            logBox.Text = "Status żądania: \n" + sendResult3[0].status +
                          ", Nr odbiorcy: \n" + sendResult3[0].recipient + ", ID wiadomości: \n" + sendResult3[0].msgId + ", Liczba części: \n" + sendResult3[0].parts +
                          ", Koszt: \n" + sendResult3[0].price + "\r\n" + logBox.Text;

            logBox.Text = "Status żądania: \n" + sendResult4[0].status +
                          ", Nr odbiorcy: \n" + sendResult4[0].recipient + ", ID wiadomości: \n" + sendResult4[0].msgId + ", Liczba części: \n" + sendResult4[0].parts +
                          ", Koszt: \n" + sendResult4[0].price + "\r\n" + logBox.Text;

            logBox.Text = "Status żądania: \n" + sendResult5[0].status +
                          ", Nr odbiorcy: \n" + sendResult5[0].recipient + ", ID wiadomości: \n" + sendResult5[0].msgId + ", Liczba części: \n" + sendResult5[0].parts +
                          ", Koszt: \n" + sendResult5[0].price + "\r\n" + logBox.Text;

            logBox.Text = "Status żądania: \n" + sendResult6[0].status +
                          ", Nr odbiorcy: \n" + sendResult6[0].recipient + ", ID wiadomości: \n" + sendResult6[0].msgId + ", Liczba części: \n" + sendResult6[0].parts +
                          ", Koszt: \n" + sendResult6[0].price + "\r\n" + logBox.Text;

            logBox.Text = "Status żądania: \n" + sendResult7[0].status +
                          ", Nr odbiorcy: \n" + sendResult7[0].recipient + ", ID wiadomości: \n" + sendResult7[0].msgId + ", Liczba części: \n" + sendResult7[0].parts +
                          ", Koszt: \n" + sendResult7[0].price + "\r\n" + logBox.Text;

            logBox.Text = "Status żądania: \n" + sendResult8[0].status +
                          ", Nr odbiorcy: \n" + sendResult8[0].recipient + ", ID wiadomości: \n" + sendResult8[0].msgId + ", Liczba części: \n" + sendResult8[0].parts +
                          ", Koszt: \n" + sendResult8[0].price + "\r\n" + logBox.Text;

            logBox.Text = "Status żądania: \n" + sendResult9[0].status +
                          ", Nr odbiorcy: \n" + sendResult9[0].recipient + ", ID wiadomości: \n" + sendResult9[0].msgId + ", Liczba części: \n" + sendResult9[0].parts +
                          ", Koszt: \n" + sendResult9[0].price + "\r\n" + logBox.Text;

            using (StreamWriter writer = new StreamWriter("Numet telefonów.txt", true))

            {
                writer.WriteLine("Klient:");
                writer.WriteLine(recipient.Text);
                writer.WriteLine(message.Text);
                writer.Close();
            }
            MessageBox.Show("Wysłano SMS", "Bramka SMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void price_Click(object sender, EventArgs e)
        {

            // Utworzenie obiektu Web Services
            GSMServiceAPI.GSMServicePortTypeClient ws = new GSMServiceAPI.GSMServicePortTypeClient();

            // Obiekt Account - zawiera login oraz haslo do konta API
            GSMServiceAPI.Account account1 = new GSMServiceAPI.Account();
            account1.login = login.Text;
            account1.pass = pass.Text;

            GSMServiceAPI.Account account2 = new GSMServiceAPI.Account();
            account2.login = login.Text;
            account2.pass = pass.Text;

            GSMServiceAPI.Account account3 = new GSMServiceAPI.Account();
            account3.login = login.Text;
            account3.pass = pass.Text;

            // Tablica obiektów Message - zawiera wiadomosci SMS, ktorych ceny maja byc sprawdzone.
            // W przykladzie jest to 1 element = 1 wiadomosc
            GSMServiceAPI.Message[] messages = new GSMServiceAPI.Message[1];
            messages[0] = new GSMServiceAPI.Message();
            messages[0].recipients = new string[] { recipient.Text }; // Numer telefonu odbiorcy
            messages[0].recipients = new string[] { recipient2.Text };
            messages[0].recipients = new string[] { recipient3.Text };
            messages[0].message = message.Text; // Tresc wiadomosci
            
            // Sprawdzenie ceny wyslania SMS - wywolanie metody GetPrice
            GSMServiceAPI.GetPriceReturn[] getpriceResult1 = ws.GetPrice(account1, messages);
            GSMServiceAPI.GetPriceReturn[] getpriceResult2 = ws.GetPrice(account2, messages);
            GSMServiceAPI.GetPriceReturn[] getpriceResult3 = ws.GetPrice(account3, messages);

            // Obsluga odpowiedzi z bramki SMS:
            logBox.Text = "Status żądania: \n" + getpriceResult1[0].status +
                          "\n Nr odbiorcy: \n" + getpriceResult1[0].recipient + "\n Koszt: \n" + getpriceResult1[0].price + "\r\n" + logBox.Text;

            logBox.Text = "Status żądania: \n" + getpriceResult2[0].status +
                          "\n Nr odbiorcy: \n" + getpriceResult2[0].recipient + "\n Koszt: \n" + getpriceResult2[0].price + "\r\n" + logBox.Text;

            logBox.Text = "Status żądania: \n" + getpriceResult3[0].status +
                          "\n Nr odbiorcy: \n" + getpriceResult3[0].recipient + "\n Koszt: \n" + getpriceResult3[0].price + "\r\n" + logBox.Text;
        }

        private void getStatus_Click(object sender, EventArgs e)
        {
            // Utworzenie obiektu Web Services
            GSMServiceAPI.GSMServicePortTypeClient ws = new GSMServiceAPI.GSMServicePortTypeClient();

            // Obiekt Account - zawiera login oraz haslo do konta API
            GSMServiceAPI.Account account = new GSMServiceAPI.Account();
            account.login = login.Text;
            account.pass = pass.Text;
        }

        private void getBalance_Click(object sender, EventArgs e)
        {
            // Utworzenie obiektu Web Services
            GSMServiceAPI.GSMServicePortTypeClient ws = new GSMServiceAPI.GSMServicePortTypeClient();

            // Obiekt Account - zawiera login oraz haslo do konta API
            GSMServiceAPI.Account account = new GSMServiceAPI.Account();
            account.login = login.Text;
            account.pass = pass.Text;

            // Sprawdzenie aktualnego stanu konta - wywolanie metody GetBalance
            GSMServiceAPI.GetBalanceReturn getbalanceResult = ws.GetBalance(account);

            // Obsluga odpowiedzi z bramki SMS:
            logBox.Text = "Status żądania: \n" + getbalanceResult.status + ", Kod błędu: \n" + getbalanceResult.errCode + ", Opis statusu: \n" + getbalanceResult.description +
                          ", Stan konta: \n" + getbalanceResult.balance + ", Waluta konta: \n" + getbalanceResult.currency + "\r\n" + logBox.Text;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            // Utworzenie obiektu Web Services
            GSMServiceAPI.GSMServicePortTypeClient ws = new GSMServiceAPI.GSMServicePortTypeClient();

            // Obiekt Account - zawiera login oraz haslo do konta API
            GSMServiceAPI.Account account = new GSMServiceAPI.Account();
            account.login = login.Text;
            account.pass = pass.Text;

        }

        private void pass_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msg_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void message_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            message.Text += comboBox1.SelectedItem.ToString() + "\n";
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login.Text = "Pakiet";
            pass.Text = "lamav3";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void recipient_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.progressBar2.Increment(2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void logBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void stop_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Szukaj_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            
            comboBox1.Items.Add(textBox2.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text += comboBox1.SelectedItem.ToString() + "\n";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Remove(textBox2.Text);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.timer3.Start();
            int i;

            progressBar3.Minimum = 0;
            progressBar3.Maximum = 200;

            for (i = 0; i <= 200; i++)
            {
                progressBar3.Value = i;
            }
            MessageBox.Show("Zalogowano!", "Bramka SMS", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void recipient3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }

}






