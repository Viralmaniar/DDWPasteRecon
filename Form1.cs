using System;
using System.Web;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDWPasteRecon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste2.org " + HttpUtility.UrlEncode(textBox1.Text));
            button1.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastebin.com " + HttpUtility.UrlEncode(textBox1.Text));
            button2.BackColor = Color.Red;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:codepen.io " + HttpUtility.UrlEncode(textBox1.Text));
            button3.BackColor = Color.Red;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:ideone.com " + HttpUtility.UrlEncode(textBox1.Text));
            button4.BackColor = Color.Red;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:gist.github.com " + HttpUtility.UrlEncode(textBox1.Text));
            button5.BackColor = Color.Red;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.mozilla.org " + HttpUtility.UrlEncode(textBox1.Text));
            button10.BackColor = Color.Red;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:ide.geeksforgeeks.org " + HttpUtility.UrlEncode(textBox1.Text));
            button9.BackColor = Color.Red;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:gitlab.com " + HttpUtility.UrlEncode(textBox1.Text));
            button8.BackColor = Color.Red;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:repl.it " + HttpUtility.UrlEncode(textBox1.Text));
            button7.BackColor = Color.Red;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.ubuntu.com " + HttpUtility.UrlEncode(textBox1.Text));
            button6.BackColor = Color.Red;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:justpaste.it " + HttpUtility.UrlEncode(textBox1.Text));
            button25.BackColor = Color.Red;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:jsfiddle.net " + HttpUtility.UrlEncode(textBox1.Text));
            button24.BackColor = Color.Red;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.centos.org " + HttpUtility.UrlEncode(textBox1.Text));
            button23.BackColor = Color.Red;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:jsbin.com " + HttpUtility.UrlEncode(textBox1.Text));
            button20.BackColor = Color.Red;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastelink.net " + HttpUtility.UrlEncode(textBox1.Text));
            button19.BackColor = Color.Red;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:codebeautify.org " + HttpUtility.UrlEncode(textBox1.Text));
            button18.BackColor = Color.Red;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:controlc.com " + HttpUtility.UrlEncode(textBox1.Text));
            button17.BackColor = Color.Red;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:invent.kde.org " + HttpUtility.UrlEncode(textBox1.Text));
            button16.BackColor = Color.Red;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.rohitab.com " + HttpUtility.UrlEncode(textBox1.Text));
            button15.BackColor = Color.Red;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:codeshare.io " + HttpUtility.UrlEncode(textBox1.Text));
                        button14.BackColor = Color.Red;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.opensuse.org " + HttpUtility.UrlEncode(textBox1.Text));
                button13.BackColor = Color.Red;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:dotnetfiddle.net " + HttpUtility.UrlEncode(textBox1.Text));
                        button12.BackColor = Color.Red;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:notes.io " + HttpUtility.UrlEncode(textBox1.Text));
                        button11.BackColor = Color.Red;
        }

        private void button40_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:snipplr.com " + HttpUtility.UrlEncode(textBox1.Text));
            button40.BackColor = Color.Red;
        }

        private void button39_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:hastebin.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button39.BackColor = Color.Red;
        }

        private void button38_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:ivpaste.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button38.BackColor = Color.Red;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:phpfiddle.org " + HttpUtility.UrlEncode(textBox1.Text));
                        button60.BackColor = Color.Red;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:codepad.org " + HttpUtility.UrlEncode(textBox1.Text));
            button59.BackColor = Color.Red;
        }

        private void button58_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:justpaste.me " + HttpUtility.UrlEncode(textBox1.Text));
            button58.BackColor = Color.Red;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastebin.osuosl.org " + HttpUtility.UrlEncode(textBox1.Text));
            button57.BackColor = Color.Red;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:www.geany.org " + HttpUtility.UrlEncode(textBox1.Text));
            button56.BackColor = Color.Red;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:bpa.st " + HttpUtility.UrlEncode(textBox1.Text));
            button55.BackColor = Color.Red;
        }

        private void button54_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.ofcode.org " + HttpUtility.UrlEncode(textBox1.Text));
            button54.BackColor = Color.Red;
        }

        private void button53_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.ee " + HttpUtility.UrlEncode(textBox1.Text));
            button53.BackColor = Color.Red;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:dpaste.org " + HttpUtility.UrlEncode(textBox1.Text));
            button52.BackColor = Color.Red;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:friendpaste.com " + HttpUtility.UrlEncode(textBox1.Text));
            button51.BackColor = Color.Red;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:defuse.ca " + HttpUtility.UrlEncode(textBox1.Text));
            button50.BackColor = Color.Red;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:dpaste.com " + HttpUtility.UrlEncode(textBox1.Text));
            button49.BackColor = Color.Red;
        }

        private void button80_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastebin.icoder.uz " + HttpUtility.UrlEncode(textBox1.Text));
                        button80.BackColor = Color.Red;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:cl1p.net " + HttpUtility.UrlEncode(textBox1.Text));
            button79.BackColor = Color.Red;
        }

        private void button78_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastie.org " + HttpUtility.UrlEncode(textBox1.Text));
                        button78.BackColor = Color.Red;
        }

        private void button77_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastecode.io " + HttpUtility.UrlEncode(textBox1.Text));
                        button77.BackColor = Color.Red;
        }

        private void button76_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:ghostbin.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button76.BackColor = Color.Red;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:www.heypasteit.com " + HttpUtility.UrlEncode(textBox1.Text));
            button75.BackColor = Color.Red;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastebin.fr " + HttpUtility.UrlEncode(textBox1.Text));
            button74.BackColor = Color.Red;
        }

        private void button73_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pasteall.org " + HttpUtility.UrlEncode(textBox1.Text));
            button73.BackColor = Color.Red;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:jsitor.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button72.BackColor = Color.Red;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:termbin.com " + HttpUtility.UrlEncode(textBox1.Text));
            button71.BackColor = Color.Red;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:p.ip.fi " + HttpUtility.UrlEncode(textBox1.Text));
            button70.BackColor = Color.Red;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:cutapaste.net " + HttpUtility.UrlEncode(textBox1.Text));
            button69.BackColor = Color.Red;
        }

        private void button100_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:www.textsnip.com " + HttpUtility.UrlEncode(textBox1.Text));
            button100.BackColor = Color.Red;
        }

        private void button99_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.lisp.org " + HttpUtility.UrlEncode(textBox1.Text));
            button99.BackColor = Color.Red;
        }

        private void button98_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.sh " + HttpUtility.UrlEncode(textBox1.Text));
            button98.BackColor = Color.Red;
        }

        private void button97_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:dumpz.org " + HttpUtility.UrlEncode(textBox1.Text));
            button97.BackColor = Color.Red;
        }

        private void button96_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.jp " + HttpUtility.UrlEncode(textBox1.Text));
            button96.BackColor = Color.Red;
        }

        private void button90_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:apaste.info " + HttpUtility.UrlEncode(textBox1.Text));
            button90.BackColor = Color.Red;
        }

        private void button91_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.org.ru " + HttpUtility.UrlEncode(textBox1.Text));
            button91.BackColor = Color.Red;
        }

        private void button92_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.pound " + HttpUtility.UrlEncode(textBox1.Text));
            button92.BackColor = Color.Red;
        }

        private void button93_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:vpaste.net " + HttpUtility.UrlEncode(textBox1.Text));
            button93.BackColor = Color.Red;
        }

        private void button94_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.debian.net " + HttpUtility.UrlEncode(textBox1.Text));
                        button94.BackColor = Color.Red;
        }

        private void button95_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.xinu.at " + HttpUtility.UrlEncode(textBox1.Text));
                        button95.BackColor = Color.Red;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:quickhighlighter.com " + HttpUtility.UrlEncode(textBox1.Text));
            button89.BackColor = Color.Red;
        }

        private void button120_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:sprunge.us " + HttpUtility.UrlEncode(textBox1.Text));
                        button120.BackColor = Color.Red;
        }

        private void button119_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:commie.io " + HttpUtility.UrlEncode(textBox1.Text));
            button119.BackColor = Color.Red;
        }

        private void button118_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:everfall.com " + HttpUtility.UrlEncode(textBox1.Text));
            button118.BackColor = Color.Red;
        }

        private void button117_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.strictfp.com " + HttpUtility.UrlEncode(textBox1.Text));
            button117.BackColor = Color.Red;
        }

        private void button116_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:kpaste.net " + HttpUtility.UrlEncode(textBox1.Text));
            button116.BackColor = Color.Red;
        }

        private void button115_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:fferen.kpaste.net " + HttpUtility.UrlEncode(textBox1.Text));
            button115.BackColor = Color.Red;
        }

        private void button114_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:eilios.kpaste.net " + HttpUtility.UrlEncode(textBox1.Text));
            button114.BackColor = Color.Red;
        }

        private void button113_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:rathena.kpaste.net " + HttpUtility.UrlEncode(textBox1.Text));
            button113.BackColor = Color.Red;
        }

        private void button112_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.frubar.net " + HttpUtility.UrlEncode(textBox1.Text));
                        button112.BackColor = Color.Red;
        }

        private void button111_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pst.klgrth.io " + HttpUtility.UrlEncode(textBox1.Text));
            button111.BackColor = Color.Red;
        }

        private void button110_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:www.pastebin.pt " + HttpUtility.UrlEncode(textBox1.Text));
            button110.BackColor = Color.Red;
        }

        private void button109_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:nopaste.me " + HttpUtility.UrlEncode(textBox1.Text));
            button109.BackColor = Color.Red;
        }

        private void button140_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:99paste.com " + HttpUtility.UrlEncode(textBox1.Text));
            button140.BackColor = Color.Red;
        }

        private void button139_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:n0paste.tk " + HttpUtility.UrlEncode(textBox1.Text));
            button139.BackColor = Color.Red;
        }

        private void button138_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastecode.fr " + HttpUtility.UrlEncode(textBox1.Text));
                        button138.BackColor = Color.Red;
        }

        private void button137_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastecode.ru " + HttpUtility.UrlEncode(textBox1.Text));
            button137.BackColor = Color.Red;
        }

        private void button136_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:www.paste.lv " + HttpUtility.UrlEncode(textBox1.Text));
                        button136.BackColor = Color.Red;
        }

        private void button135_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastesqf.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button135.BackColor = Color.Red;
        }

        private void button134_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:tutpaste.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button134.BackColor = Color.Red;
        }

        private void button133_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.scratchbook.ch " + HttpUtility.UrlEncode(textBox1.Text));
                        button133.BackColor = Color.Red;
        }

        private void button132_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:bitbin.it " + HttpUtility.UrlEncode(textBox1.Text));
            button132.BackColor = Color.Red;
        }

        private void button131_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:privatebin.net " + HttpUtility.UrlEncode(textBox1.Text));
            button131.BackColor = Color.Red;
        }

        private void button130_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:0bin.net " + HttpUtility.UrlEncode(textBox1.Text));
            button130.BackColor = Color.Red;
        }

        private void button129_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:sebsauvage.net/paste " + HttpUtility.UrlEncode(textBox1.Text));
            button129.BackColor = Color.Red;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastefs.com " + HttpUtility.UrlEncode(textBox1.Text));
            button21.BackColor = Color.Red;
        }

        private void button160_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:slexy.org " + HttpUtility.UrlEncode(textBox1.Text));
            button160.BackColor = Color.Red;
        }

        private void button159_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pasteio.com " + HttpUtility.UrlEncode(textBox1.Text));
            button159.BackColor = Color.Red;
        }

        private void button158_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:www.paste4btc.com " + HttpUtility.UrlEncode(textBox1.Text));
            button158.BackColor = Color.Red;
        }

        private void button151_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:squadedit.com " + HttpUtility.UrlEncode(textBox1.Text));
            button151.BackColor = Color.Red;
        }

        private void button152_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastebin.ca " + HttpUtility.UrlEncode(textBox1.Text));
                        button152.BackColor = Color.Red;
        }

        private void button153_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:textsnip.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button153.BackColor = Color.Red;
        }

        private void button154_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:etherpad.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button154.BackColor = Color.Red;
        }

        private void button155_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.bradleygill.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button155.BackColor = Color.Red;
        }

        private void button156_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastie.textmate.org " + HttpUtility.UrlEncode(textBox1.Text));
                        button156.BackColor = Color.Red;
        }

        private void button157_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.pocoo.org " + HttpUtility.UrlEncode(textBox1.Text));
                        button157.BackColor = Color.Red;
        }

        private void button150_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:tinypaste.com " + HttpUtility.UrlEncode(textBox1.Text));
            button150.BackColor = Color.Red;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:vyew.com " + HttpUtility.UrlEncode(textBox1.Text));
            button27.BackColor = Color.Red;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:copytaste.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button22.BackColor = Color.Red;
        }

        private void button170_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:drupalbin.com " + HttpUtility.UrlEncode(textBox1.Text));
            button170.BackColor = Color.Red;
        }

        private void button171_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:chopapp.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button171.BackColor = Color.Red;
        }

        private void button172_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:dragbox.org " + HttpUtility.UrlEncode(textBox1.Text));
                        button172.BackColor = Color.Red;
        }

        private void button173_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:snipsource.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button173.BackColor = Color.Red;
        }

        private void button174_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:codeupload.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button174.BackColor = Color.Red;
        }

        private void button175_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastehtml.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button175.BackColor = Color.Red;
        }

        private void button176_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastebay.org " + HttpUtility.UrlEncode(textBox1.Text));
                        button176.BackColor = Color.Red;
        }

        private void button177_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:heypasteit.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button177.BackColor = Color.Red;
        }

        private void button178_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastee.org " + HttpUtility.UrlEncode(textBox1.Text));
                        button178.BackColor = Color.Red;
        }

        private void button179_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:snipt.net " + HttpUtility.UrlEncode(textBox1.Text));
                        button179.BackColor = Color.Red;
        }

        private void button180_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:drop.io " + HttpUtility.UrlEncode(textBox1.Text));
                        button180.BackColor = Color.Red;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:nopaste.info " + HttpUtility.UrlEncode(textBox1.Text));
            button28.BackColor = Color.Red;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:privatepaste.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button26.BackColor = Color.Red;
        }

        private void button190_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pasted.co " + HttpUtility.UrlEncode(textBox1.Text));
                        button190.BackColor = Color.Red;
        }

        private void button191_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:www.pastefs.com " + HttpUtility.UrlEncode(textBox1.Text));
            button191.BackColor = Color.Red;
        }

        private void button192_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:lettur.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button192.BackColor = Color.Red;
        }

        private void button193_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:tidypub.org " + HttpUtility.UrlEncode(textBox1.Text));
                        button193.BackColor = Color.Red;
        }

        private void button194_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:9url.us " + HttpUtility.UrlEncode(textBox1.Text));
                        button194.BackColor = Color.Red;
        }

        private void button195_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:hpaste.org " + HttpUtility.UrlEncode(textBox1.Text));
                        button195.BackColor = Color.Red;
        }

        private void button196_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:codesnipp.it " + HttpUtility.UrlEncode(textBox1.Text));
                        button196.BackColor = Color.Red;
        }

        private void button197_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:source.virtser.net " + HttpUtility.UrlEncode(textBox1.Text));
                        button197.BackColor = Color.Red;
        }

        private void button198_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:everfall.com/paste " + HttpUtility.UrlEncode(textBox1.Text));
                        button198.BackColor = Color.Red;
        }

        private void button199_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:snippets.dzone.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button199.BackColor = Color.Red;
        }

        private void button200_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:codekeep.net " + HttpUtility.UrlEncode(textBox1.Text));
            button200.BackColor = Color.Red;
        }

        private void button41_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:lpaste.net " + HttpUtility.UrlEncode(textBox1.Text));
                        button41.BackColor = Color.Red;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:crdclub.su " + HttpUtility.UrlEncode(textBox1.Text));
                        button30.BackColor = Color.Red;
        }

        private void button31_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.balbinus.org " + HttpUtility.UrlEncode(textBox1.Text));
                        button31.BackColor = Color.Red;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pasting.djstey.com " + HttpUtility.UrlEncode(textBox1.Text));
                        button32.BackColor = Color.Red;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:www.posu.org " + HttpUtility.UrlEncode(textBox1.Text));
                        button33.BackColor = Color.Red;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:paste.bitlair.nl " + HttpUtility.UrlEncode(textBox1.Text));
                        button34.BackColor = Color.Red;
        }

        private void button35_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:riskmitigation.ch " + HttpUtility.UrlEncode(textBox1.Text));
                        button35.BackColor = Color.Red;
        }

        private void button36_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:p.hgc.host " + HttpUtility.UrlEncode(textBox1.Text));
                        button36.BackColor = Color.Red;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:pastebin.centos.org " + HttpUtility.UrlEncode(textBox1.Text));
                        button37.BackColor = Color.Red;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=site:coderanch.com " + HttpUtility.UrlEncode(textBox1.Text));
            button29.BackColor = Color.Red;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/maniarviral ");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
