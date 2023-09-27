using System;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
using System.Net.Http;
using System.IO;
using System.Diagnostics;

namespace image_thingy
{
    public partial class Main : Form
    {
        HttpClient http;
        string username;
        string password;
        string address;
        string captureDir;
        int captureCount;
        string webViewCache;
        int webViewPID;
        public Main()
        {
            InitializeComponent();
            _ = InitializeAsync();
            Application.ApplicationExit += OnApplicationExit;
            var handler = new HttpClientHandler();
            handler.ClientCertificateOptions = ClientCertificateOption.Manual;
            handler.ServerCertificateCustomValidationCallback =
                (httpRequestMessage, cert, cetChain, policyErrors) =>
                {
                    return true;
                };
            http = new HttpClient(handler);
        }

        private async Task InitializeAsync()
        {
            
            CoreWebView2EnvironmentOptions options = new CoreWebView2EnvironmentOptions("--disable-web-security");
            CoreWebView2Environment environment = await CoreWebView2Environment.CreateAsync(null, null, options);
            await webCamera.EnsureCoreWebView2Async(environment);
            webViewCache = environment.UserDataFolder;
            webViewPID = Convert.ToInt32(webCamera.CoreWebView2.BrowserProcessId);
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            try
            {
                var webViewProcess = Process.GetProcessById(webViewPID);
                webCamera.Dispose();
                webViewProcess.WaitForExit(3000);
                Directory.Delete(webViewCache, true);
            } catch (Exception ex)
            {

            }
           
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username...")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username...";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password...")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.Text = "Password...";
            }
        }

        private void txtAddress_Enter(object sender, EventArgs e)
        {
            if (txtAddress.Text == "Address...") 
            {
                txtAddress.Text = "";
            }
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtAddress.Text))
            {
                txtAddress.Text = "Address...";
            }
        }


        async private void apiCall(string url)
        {
            await http.GetAsync(address + url);
        }




        private void btnGo_Click(object sender, EventArgs e)
        {
            address = "https://" + txtAddress.Text;

            if (txtUsername.Text != "Username...")
            {
                username = txtUsername.Text;
            } else
            {
                username = "";
            }
            if (txtPassword.Text != "Password...")
            {
                password = txtPassword.Text;
            }
            else
            {
                password = "";
            }

            webCamera.CoreWebView2.BasicAuthenticationRequested += delegate (object s, CoreWebView2BasicAuthenticationRequestedEventArgs args)
            {
                args.Response.UserName = username;
                args.Response.Password = password;
            };

            try
            {
                webCamera.CoreWebView2.Navigate(address + "/video");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var authBytes = Encoding.ASCII.GetBytes(username + ":" + password);
            http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(authBytes));

            if (chkRemember.Checked)
            {
                var output = txtAddress.Text + "\n" + txtUsername.Text + "\n" + txtPassword.Text + "\n" + txtFilePattern.Text;
                File.WriteAllText("./config.cfg", output);
            }
        }





        private void btnAuto_Click(object sender, EventArgs e)
        {
            NetworkInterface[] interfaces = NetworkInterface.GetAllNetworkInterfaces();
            string[] myIP = null;
            foreach (NetworkInterface networkInterface in interfaces)
            {
                if (networkInterface.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation address in networkInterface.GetIPProperties().UnicastAddresses)
                    {
                        if (address.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            myIP = address.Address.ToString().Split('.');
                        }
                    }
                }
                if (myIP != null) break;
            }
            string ipRange = $"{myIP[0]}.{myIP[1]}.{myIP[2]}.";

            int portToScan = Convert.ToInt32(txtPortFind.Text);

            string foundIp = null;



            Parallel.For(1, 254, (i, loopState) =>
            {
                try
                {
                    using (var tcpClient = new TcpClient())
                    {
                        var connectTask = tcpClient.ConnectAsync(ipRange + Convert.ToString(i), portToScan);
                        if (connectTask.Wait(150))
                        {
                            foundIp = ipRange + Convert.ToString(i);
                            loopState.Stop();
                        }
                    }
                }
                catch (SocketException)
                {}
            });


            //ipRange + Convert.ToString(i)

            if (foundIp != null)
            {
                txtAddress.Text = foundIp + ":" + portToScan;
            } else
            {
                MessageBox.Show("Couldn't find server");
            }
        }

        private void webCamera_WebResourceResponseReceived(object sender, CoreWebView2WebResourceResponseReceivedEventArgs e)
        {
            
            if (e.Response.Headers.Contains("Server") && e.Response.Headers.GetHeader("Server").StartsWith("IP Webcam Server"))
            {
                btnSingle.Enabled = true;
                btnVideoFeed.Enabled = true;
                btnWebUI.Enabled = true;
                trkQuality.Enabled = true;
                lblQuality.Enabled = true;
                chkManual.Enabled = true;
                chkAf.Enabled = true;
                btnStartStop.Enabled = true;
                lblInterval.Enabled = true;
                trkInterval.Enabled = true;
            }
            
        }
        private void webCamera_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            
            webCamera.CoreWebView2.ExecuteScriptAsync("disableSecurity = document.getElementById('proceed-link'); if (disableSecurity) {disableSecurity.click();}");
        }

        private void btnWebUI_Click(object sender, EventArgs e)
        {
            webCamera.CoreWebView2.Navigate(address);
        }

        private void btnVideoFeed_Click(object sender, EventArgs e)
        {
            webCamera.CoreWebView2.Navigate(address + "/video");
        }

        private void btnSingle_Click(object sender, EventArgs e)
        {
            //webCamera.NavigateToString(address + "/photo.jpg");
            webCamera.CoreWebView2.Navigate(address + "/photo.jpg");
            //webCamera.Source = new Uri(address + "/photo.jpg");
        }



        async private void trackQuality_MouseCaptureChanged(object sender, EventArgs e)
        {
            apiCall("/settings/quality?set=" + trkQuality.Value.ToString());
        }

        private void trackQuality_Scroll(object sender, EventArgs e)
        {
            lblQuality.Text = "Feed Quality "+trkQuality.Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAddress.Text="192.168.0.77:8080";
            txtUsername.Text="piss";
            txtPassword.Text="cupcake52";
            btnGo.PerformClick();
        }

        private void trackInterval_Scroll(object sender, EventArgs e)
        {
            lblInterval.Text = "Interval " + (Convert.ToSingle(trkInterval.Value) / 2).ToString() + "s";
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                btnStartStop.Text = "Start";
            }
            else
            {
                captureCount = 0;
                captureDir = txtDir.Text;
                Directory.CreateDirectory(captureDir);
                timer.Interval = trkInterval.Value * 500;
                timer.Start();
            }
            

        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtDir.Text = "./" + DateTime.Now.ToString("yyyy-MM-dd");

            try
            {
                var config = File.ReadAllText("./config.cfg").Split('\n');
                txtAddress.Text = config[0];
                txtUsername.Text = config[1];
                txtPassword.Text = config[2];
                txtFilePattern.Text = config[3];
                chkRemember.Checked = true;
            } catch (Exception ex) {
            }
            
            
        }

        private async Task SaveFile(string fileUrl, string pathToSave)
        {
            var httpResult = await http.GetAsync(fileUrl);
            var resultStream = await httpResult.Content.ReadAsStreamAsync();
            var fileStream = File.Create(pathToSave);
            resultStream.CopyTo(fileStream);
        }

        async private void timer_Tick(object sender, EventArgs e)
        {
            await SaveFile(address + "/photo.jpg", Path.Combine(captureDir, DateTime.Now.ToString(txtFilePattern.Text) + ".jpg"));

            captureCount++;

            if (timer.Enabled)
            {
                btnStartStop.Text = captureCount.ToString() + " Photos";
            }
            else
            {
                btnStartStop.Text = "Start";
            }

        }

        private void chkSave_CheckedChanged(object sender, EventArgs e)
        {
            if (File.Exists("config.cfg"))
            {
                File.Delete("config.cfg");
            }
        }

        private void trkIso_Scroll(object sender, EventArgs e)
        {
            lblIso.Text = "ISO" + trkIso.Value.ToString();
        }

        private void trkIso_MouseCaptureChanged(object sender, EventArgs e)
        {
            apiCall("/settings/iso?set=" + trkIso.Value.ToString());
        }

        private void chkAf_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAf.Checked)
            {
                apiCall("/focus");
            }
            else
            {
                apiCall("/nofocus");
            }
        }

        private void chkManual_CheckedChanged(object sender, EventArgs e)
        {
            if (chkManual.Checked)
            {
                apiCall("/settings/manual_sensor?set=on");
                trkIso_MouseCaptureChanged(null, null);
                trkExposure_MouseCaptureChanged(null, null);
            }
            else
            {
                apiCall("/settings/manual_sensor?set=off");
            }

            lblIso.Enabled=chkManual.Checked;
            trkIso.Enabled=chkManual.Checked;
            lblExposure.Enabled=chkManual.Checked;
            trkExposure.Enabled=chkManual.Checked;
        }

        private void trkExposure_Scroll(object sender, EventArgs e)
        {
            lblExposure.Text = trkExposure.Value.ToString()+"ms";
        }

        private void trkExposure_MouseCaptureChanged(object sender, EventArgs e)
        {
            apiCall("/settings/exposure_ns?set=" + (trkExposure.Value * 1000000).ToString());
        }

        private void webCamera_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            webCamera.CoreWebView2.WebResourceResponseReceived += this.webCamera_WebResourceResponseReceived;
        }
    }
}
