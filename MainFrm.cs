using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhatsappWeb
{
    public partial class MainFrm : Form
    {
        const int BY_XPATH = 1;
        const int BY_CSS_SELECTOR = 2;
        const int BY_ID = 3;

        ChromeDriver driver = null;
        private int count = 0;
        private string mesaj = string.Empty;
        public MainFrm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            openDialogNumara.FileName = "Txt Seç";
            openDialogNumara.Filter = "Text files(*.txt)| *.txt";
            openDialogNumara.Title = "Numara Yükle";

            listViewNumaralar.Columns.Add("Numara");
            listViewNumaralar.Columns.Add("Durum");


            listViewNumaralar.View = View.Details;
            listViewNumaralar.Scrollable = true;


        }


        private void mesajGonder()
        {
            string numara = listViewNumaralar.Items[count].SubItems[0].Text;
            string api = "https://api.whatsapp.com/send?phone=" + numara + "&text=" + mesaj;
            driver.Url = api;
            var actionButton = ElementSelector(driver, "action-button", BY_ID);
            actionButton.Click();
            lblDurum.Text = numara + " mesaj gönderiliyor ...";
            Thread.Sleep(500);
            if (driver.FindElementsByCssSelector("[data-animate-modal-body]").Count == 0)
            {
                while (true)
                {
                    Thread.Sleep(1500);
                    var spanDataIconSend = ElementSelector(driver, "span[data-icon=send]", BY_CSS_SELECTOR);
                    if (spanDataIconSend != null)
                    {
                        if (chkDosyaGonder.Checked)
                        {
                            lblDurum.Text = "Dosya Gönderiliyor ...";
                            Thread.Sleep(2000);
                            DosyayiEkranaSurukle();
                            Thread.Sleep(1000);
                            resmiGonder();
                            Thread.Sleep(int.Parse(txtBeklemeSuresi.Text));
                            lblDurum.Text = "Dosya Gönderildi";
                        }

                        else
                        {
                            Thread.Sleep(3000);
                            driver.ExecuteScript("document.querySelector('span[data-icon=send]').closest('button').click()");
                        }

                        break;
                    }

                }
            }

            listViewNumaralar.Items[count].SubItems[1].Text = "Gönderildi";
            progressBar1.Value = count + 1;
            int ss = count + 1;
            this.Text = "WhatsappWeb Mesaj Gönder | ixlarge.com [" + listViewNumaralar.Items.Count + "] / [" + ss + "]";
            listViewNumaralar.Items[count++].SubItems[1].ForeColor = Color.Green;

            Atesle();
        }

        private void resmiGonder()
        {
            while (true)
            {
                var dosyaGonderButton = ElementSelector(driver, "#app > div > div div[role=\"button\"] span[data-icon=\"send-light\"]", BY_CSS_SELECTOR);
                if (dosyaGonderButton != null)
                {
                    dosyaGonderButton.Click();
                    break;
                }
                Thread.Sleep(2500);
            }
        }
        private void ChromeCalistir()
        {
            var options = new ChromeOptions();
            options.AddArgument("disable-infobars");

            options.AddArguments(
                     "--disable-plugins",
                     "--no-experiments",
                     "--disk-cache-dir=null");

            options.AddArgument("--disable-geolocation");
            options.AddArgument("--disable-search-geolocation-disclosure");

            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory, options);
            driver.Navigate().GoToUrl("https://web.whatsapp.com/");

        }

        private void btnCalistir_Click(object sender, EventArgs e)
        {


        }



        private void Atesle()
        {
            if (count == listViewNumaralar.Items.Count)
            {
                bitti();
                lblDurum.Text = "Bitti";
                return;
            }

            mesajGonder();

        }



        private void bitti()
        {
            count = 0;
            btnMesajGonder.Enabled = true;
            txtMesaj.ReadOnly = false;
            txtBeklemeSuresi.ReadOnly = false;
        }


        const string JS_DROP_FILE = "for(var b=arguments[0],k=arguments[1],l=arguments[2],c=b.ownerDocument,m=0;;){var e=b.getBoundingClientRect(),g=e.left+(k||e.width/2),h=e.top+(l||e.height/2),f=c.elementFromPoint(g,h);if(f&&b.contains(f))break;if(1<++m)throw b=Error('Element not interractable'),b.code=15,b;b.scrollIntoView({behavior:'instant',block:'center',inline:'center'})}var a=c.createElement('INPUT');a.setAttribute('type','file');a.setAttribute('style','position:fixed;z-index:2147483647;left:0;top:0;');a.onchange=function(){var b={effectAllowed:'all',dropEffect:'none',types:['Files'],files:this.files,setData:function(){},getData:function(){},clearData:function(){},setDragImage:function(){}};window.DataTransferItemList&&(b.items=Object.setPrototypeOf([Object.setPrototypeOf({kind:'file',type:this.files[0].type,file:this.files[0],getAsFile:function(){return this.file},getAsString:function(b){var a=new FileReader;a.onload=function(a){b(a.target.result)};a.readAsText(this.file)}},DataTransferItem.prototype)],DataTransferItemList.prototype));Object.setPrototypeOf(b,DataTransfer.prototype);['dragenter','dragover','drop'].forEach(function(a){var d=c.createEvent('DragEvent');d.initMouseEvent(a,!0,!0,c.defaultView,0,0,0,g,h,!1,!1,!1,!1,0,null);Object.setPrototypeOf(d,null);d.dataTransfer=b;Object.setPrototypeOf(d,DragEvent.prototype);f.dispatchEvent(d)});a.parentElement.removeChild(a)};c.documentElement.appendChild(a);a.getBoundingClientRect();return a;";


        private void DropFile(IWebElement target, string filePath, double offsetX = 0, double offsetY = 0)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException(filePath);

            var _driver = ((RemoteWebElement)target).WrappedDriver;
            var jse = (IJavaScriptExecutor)_driver;

            var input = (IWebElement)jse.ExecuteScript(JS_DROP_FILE, target, offsetX, offsetY);
            input.SendKeys(filePath);
            var inputFile = ElementSelector(driver, "//*[@id=\"app\"]/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/input", BY_XPATH);
            inputFile.SendKeys(txtDosyaYolu.Text);

        }

        private void DosyayiEkranaSurukle()
        {
            var dosyaSuruklenenYer = ElementSelector(driver, "#main > div > div > div", BY_CSS_SELECTOR);
            if (dosyaSuruklenenYer != null)
            {
                DropFile(dosyaSuruklenenYer, txtDosyaYolu.Text);
            }
            else
            {
                MessageBox.Show("resim yeri null geldi");
            }

        }

        private IWebElement ElementSelector(ChromeDriver cDriver, string secici, int selectorType)
        {
            if (cDriver == null || string.IsNullOrWhiteSpace(secici))
                throw new ArgumentException("invalid argüment");

            ReadOnlyCollection<IWebElement> bulunan = null;

            switch (selectorType)
            {
                case 1:
                    bulunan = cDriver.FindElementsByXPath(secici);
                    break;
                case 2:
                    bulunan = cDriver.FindElementsByCssSelector(secici);
                    break;
                case 3:
                    bulunan = cDriver.FindElementsById(secici);
                    break;
            }
            return bulunan != null && bulunan.Count > 0 ? bulunan[0] : null;
        }






        private void iTalk_btnCalistir_Click(object sender, EventArgs e)
        {
            lblDurum.Text = "web.whatsapp.com açılıyor...";
            Task.Run(() =>
            {
                ChromeCalistir();
                lblDurum.Text = "Hazır !";
            });
        }


        private void iTalk_btnNumaraYukle_Click(object sender, EventArgs e)
        {
            if (openDialogNumara.ShowDialog() == DialogResult.OK)
            {
                listViewNumaralar.Items.Clear();
                iTalk_btnNumaraYukle.Enabled = false;
                lblDurum.Text = "Numaralar Yükleniyor ...";
                Task.Run(() =>
                {
                    string[] numaralar = File.ReadAllLines(openDialogNumara.FileName);
                    foreach (var numara in numaralar)
                    {
                        if (string.IsNullOrWhiteSpace(numara))
                        {
                            continue;
                        }

                        var item = new ListViewItem(numara.Trim());
                        item.SubItems.Add("Bekliyor     ");
                        item.UseItemStyleForSubItems = false;
                        item.ForeColor = Color.Brown;
                        item.SubItems[1].ForeColor = Color.Brown;
                        listViewNumaralar.Items.Add(item);

                    }
                    lblDurum.Text = "Numaralar Yüklendi !";
                    this.Text = "WhatsappWeb Mesaj Gönder | ixlarge.com [" + listViewNumaralar.Items.Count + "]";
                    iTalk_btnNumaraYukle.Enabled = true;
                    listViewNumaralar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                });
            }
        }

        private void chkDosyaGonder_CheckedChanged(object sender)
        {
            if (chkDosyaGonder.Checked)
            {
                if (openFileDialogDosya.ShowDialog() == DialogResult.OK)
                {
                    txtDosyaYolu.Text = openFileDialogDosya.FileName;
                }
            }
        }

        private void btnNumaraEkle_Click(object sender, EventArgs e)
        {
            var item = new ListViewItem(txtNumara.Text.Trim());
            item.SubItems.Add("Bekliyor     ");
            item.UseItemStyleForSubItems = false;
            item.ForeColor = Color.Brown;
            item.SubItems[1].ForeColor = Color.Brown;
            listViewNumaralar.Items.Add(item);
            txtNumara.Text = "";
            listViewNumaralar.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void btnMesajGonder_Click(object sender, EventArgs e)
        {
            mesaj = Uri.EscapeDataString(txtMesaj.Text);
            progressBar1.Maximum = listViewNumaralar.Items.Count;
            btnMesajGonder.Enabled = false;
            txtMesaj.ReadOnly = true;
            txtBeklemeSuresi.ReadOnly = true;
            lblDurum.Text = "İşlem Başlatıldı ...";

            Task.Run(() =>
            {
                Atesle();
            });
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            bitti();
        }
    }
}
