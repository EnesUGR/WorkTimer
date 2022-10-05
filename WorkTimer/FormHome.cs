using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Microsoft.VisualBasic;

namespace WorkTimer
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private int defDurationWorking = 40; //Varsayılan çalışma süresi
        private int defDurationMola = 0; //Varsayılan dinlenme süresi
        int h, m, s;
        bool _startedWorking = false;

        private void picbtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            setToolTipInformations();
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblCurrentDate.Text = DateTime.Now.ToString("dd MMMM yyyy dddd");
            timerCTime.Start();
            
        }

        private void setToolTipInformations()
        {
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(this.btn_StartStop, "Shift+F4");
            toolTip1.SetToolTip(this.btn_Reset, "Shift+F5");
        }


        private void timerCTime_Tick(object sender, EventArgs e)
        {
            string[] t = lblCurrentTime.Text.Split(':');
            int h = Convert.ToInt16(t[0]), m = Convert.ToInt16(t[1]), s = Convert.ToInt16(t[2]);
            
            if (s == 0)
            {
                s++;
                if (m == 60)
                {
                    h++;
                    m = 0;
                    if (h == 24)
                    {
                        h = 0;
                        m = 0;
                        s = 0;
                        lblCurrentDate.Text = DateTime.Now.ToString("dd MMMM yyyy dddd");
                    }
                }
            } 
            else
            {
                s++;
                if (s == 60) { s = 0; m++; }
            }

            lblCurrentTime.Text = $"{h}:{m}:{s}";
        }


        private void btn_StartStop_Click(object sender, EventArgs e)
        {
            if (!timerWorkingUser.Enabled)
            {
                if (!_startedWorking) { resetTimer(); }
                timerWorkingUser.Start();
                _startedWorking = true;
                btn_StartStop.Text = "Durdur";
            }
            else
            {
                timerWorkingUser.Stop();
                btn_StartStop.Text = "Başlat";
            }
        }

        private void resetTimer()
        {
            Console.WriteLine($"{timerWorkingUser.ToString()}->{timerWorkingUser.Enabled}");
            h = defDurationWorking / 60;
            m = defDurationWorking - (60 * h);
            s = 0;
            if (!timerWorkingUser.Enabled)
            {
                lbl_ReamingTime.Text = "HH:mm:ss";
                groupBox_Status.Text = "Durum:Aktif Değil";
                groupBox_Status.ForeColor = Color.Red;
            }
        }

        private void timerWorkingUser_Tick(object sender, EventArgs e)
        {
            lbl_ReamingTime.Text = $"{h}:{m}:{s}";
            groupBox_Status.Text = "Durum:Aktif";
            groupBox_Status.ForeColor = Color.LimeGreen;
            if (s == 0)
            {
                s = 59;
                if (m != 0)
                {
                    m--;
                } else
                {
                    if (h != 0)
                    {
                        h--;
                        m = 59;
                    } else
                    {
                        //Süre doldu.
                        resetTimer();
                        timerWorkingUser.Stop();
                        groupBox_Status.ForeColor = Color.Yellow;
                        Console.WriteLine(timerWorkingUser.Enabled);
                        btn_StartStop.Text = "Başlat";
                        groupBox_Status.Text = "Durum:Mola";
                    }
                }

            } else
            {
                s--;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            resetTimer();
            _startedWorking=false;
        }

        private void btnSetWorkingDuration_Click(object sender, EventArgs e)
        {
            string d = Interaction.InputBox("Dakika Cinsinden Çalışmak İstediğiniz Süreyi Giriniz:", "Çalışma Süresi", $"Tanımlı:{defDurationWorking}");
            if (d != "")
            {
                try
                {
                    int durationMin = Convert.ToInt32(d);
                    if (durationMin < 1)
                    {
                        MessageBox.Show("Lütfen 1'den Büyük Bir Tam Sayı Girin.", "Çalışma Süresini Ayarla", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSetWorkingDuration.PerformClick();
                        return;
                    }
                    //Süre doğru girildi kaydedilebilir.
                    defDurationWorking = durationMin;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen Geçerli Bir Sayı Giriniz.\rDakika Cinsinden Ve 1'den Büyük Bir Tam Sayı Girdiğinizden Emin Olun.", "Çalışma Süresini Ayarla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSetWorkingDuration.PerformClick();
                    return;
                }
            }

        }

        private void btnSetMolaDuration_Click(object sender, EventArgs e)
        {
            string d = Interaction.InputBox("Dakika Cinsinden Mola Sürenizi Giriniz:", "Mola Süresi", $"Tanımlı:{defDurationMola}");
            if (d != "")
            {
                try
                {
                    int durationMin = Convert.ToInt32(d);
                    if (durationMin < 1)
                    {
                        MessageBox.Show("Lütfen 1'den Büyük Bir Tam Sayı Girin.", "Mola Süresini Ayarla", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnSetMolaDuration.PerformClick();
                        return;
                    }
                    //Süre doğru girildi kaydedilebilir.
                    defDurationMola = durationMin;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen Geçerli Bir Sayı Giriniz.\rDakika Cinsinden Ve 1'den Büyük Bir Tam Sayı Girdiğinizden Emin Olun.", "Mola Süresini Ayarla", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnSetMolaDuration.PerformClick();
                    return;
                }
            }
        }
    }
}
