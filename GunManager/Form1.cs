using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GunManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //********** LinkLabel **********
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("http://minecraft-ja.gamepedia.com/%E8%A3%85%E9%A3%BE%E3%82%B3%E3%83%BC%E3%83%89");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start("http://minecraft-ids.grahamedgecombe.com/");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Shampaggon/CrackShot/wiki/List-of-Accepted-Sounds");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Shampaggon/CrackShot/wiki/The-Complete-Guide-to-CrackShot");
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel5.LinkVisited = true;
            System.Diagnostics.Process.Start("http://minecraft-ja.gamepedia.com/%E8%A3%85%E9%A3%BE%E3%82%B3%E3%83%BC%E3%83%89");
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel6.LinkVisited = true;
            System.Diagnostics.Process.Start("http://minecraft-ids.grahamedgecombe.com/");
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel7.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Shampaggon/CrackShot/wiki/List-of-Accepted-Sounds");
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel8.LinkVisited = true;
            System.Diagnostics.Process.Start("http://seesaawiki.jp/neeted/d/CrackShot%A1%D6%A5%B6%A1%A6%A5%B3%A5%F3%A5%D7%A5%EA%A1%BC%A5%C8%A5%AC%A5%A4%A5%C9%A1%D7");
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel9.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Shampaggon/CrackShot/wiki/The-Complete-Guide-to-CrackShot");
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel9.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Shampaggon/CrackShot/wiki/Default-weapons");
        }





        //********** 出力 **********
        private void button1_Click(object sender, EventArgs e)//出力
        {
            String WN = II_IName.Text;  //II_IName.Textの文字コードを取っ払う。
            WN = WN.Replace("&0", "");
            WN = WN.Replace("&1", "");
            WN = WN.Replace("&2", "");
            WN = WN.Replace("&3", "");
            WN = WN.Replace("&4", "");
            WN = WN.Replace("&5", "");
            WN = WN.Replace("&6", "");
            WN = WN.Replace("&7", "");
            WN = WN.Replace("&8", "");
            WN = WN.Replace("&9", "");
            WN = WN.Replace("&a", "");
            WN = WN.Replace("&b", "");
            WN = WN.Replace("&c", "");
            WN = WN.Replace("&d", "");
            WN = WN.Replace("&e", "");
            WN = WN.Replace("&f", "");
            WN = WN.Replace("&k", "");
            WN = WN.Replace("&l", "");
            WN = WN.Replace("&m", "");
            WN = WN.Replace("&n", "");
            WN = WN.Replace("&o", "");
            WN = WN.Replace("&r", "");

            string ItemType;
            if(II_IType_meta.Value == 0)
            {
                ItemType = II_IType.Text;
            }
            else
            {
                ItemType = II_IType.Value.ToString() + "~" + II_IType_meta.Value.ToString();
            }

            string ItemLore = null;
            if(II_ILore.Text != "")
            {
                ItemLore = "        Item_Lore: " + II_ILore.Text + "\r\n";
            }

            string RCTS = null;
            if (Sh_RCTS.Checked == true)
            {
                RCTS = "        Right_Click_To_Shoot: true\r\n";
            }

            string CLCBD = null;
            if(Sh_CLCBD.Checked == true)
            {
                CLCBD = "        Cancel_Left_Click_Block_Damage: true\r\n";
            }

            string DBS = null;
            if(Sh_DBS.Value != 0)
            {
                DBS = "        Delay_Between_Shots: " + Sh_DBS.Value.ToString() + "\r\n";
            }

            string ReA = null;
            if(Sh_ReA.Value != 0)
            {
                ReA = "        Recoil_Amount: " + Sh_ReA.Value.ToString() + "\r\n";
            }

            string RBD = null;
            if(Sh_RBD.Checked == true)
            {
                RBD = "        Remove_Bullet_Drop: true\r\n";
            }

            string Shooting_SS = null;
            if(Sh_SS.Text != "")
            {
                Shooting_SS = "        Sounds_Shoot: " + Sh_SS.Text + "\r\n";
            }

            string Sneak = null;
            string Sneak_NoR = null;
            if (Sn_Ena.Checked == true)
            {
                if(Sn_NoR.Checked == true)
                {
                    Sneak_NoR = "        No_Recoil: true\r\n";
                }
                Sneak = "    Sneak:\r\n"
                     + "        Enable: true\r\n"
                     + Sneak_NoR
                     + "        Bullet_Spread: " + Sn_BuS.Value + "\r\n"; //ToString() がこっから抜けてるｗ
            }

            string FA = null;
            if(FA_Ena.Checked == true)
            {
                FA = "    Fully_Automatic:\r\n"
                    + "        Enable: true\r\n"
                    + "        Fire_Rate: " + FA_FiR.Value + "\r\n";
            }

            string Reload = null;
            string Reload_RBI = null;
            string Reload_SOOA = null;
            string Reload_SR = null;    //まさか、string A, B, C = null;ができないとは...
            if (Re_Ena.Checked == true)
            {
                if(Re_RBI.Checked == true)
                {
                    Reload_RBI = "        Reload_Bullets_Individually: true\r\n";
                }
                if(Re_SOOA.Text != "")
                {
                    Reload_SOOA = "        Sounds_Out_Of_Ammo: " + Re_SOOA.Text + "\r\n";
                }
                if(Re_SR.Text != "")
                {
                    Reload_SR = "        Sounds_Reloading: " + Re_SR.Text + "\r\n";
                }
                Reload = "    Reload:\r\n"
                    + "        Enable: true\r\n"
                    + "        Reload_Amount: " + Re_ReA.Value + "\r\n"
                    + Reload_RBI
                    + "         Reload_Duration: " + Re_ReD.Value + "\r\n"
                    + Reload_SOOA;
            }

            string FiA = null;
            if(FiA_Type.Text != "")
            {
                string OD = null;
                if ((FiA_OD.Value != 0) && (FiA_Type.Text == "bolt"))
                {
                    OD = "        Open_Duration: " + FiA_OD.Value + "\r\n";
                }
                string CD = null;
                if(FiA_CD.Value != 0)
                {
                    CD = "        Close_Duration: " + FiA_CD.Value + "";
                }
                string SC = null;
                if(FiA_SC.Text != "")
                {
                    SC = "          Sound_Close: " + FiA_SC.Text + "\r\n";
                }
                FiA = "     Firearm_Action:\r\n"
                    + "        Type: " + FiA_Type.Text + "\r\n"
                    + OD
                    + CD
                    + SC;
            }
            string Scope = null;
            if(Sc_Ena.Checked == true)
            {
                string Niv = null;
                if(Sc_NiV.Checked == true)
                {
                    Niv = "        Night_Vision: true\r\n";
                }
                string ZA = null;
                if(Sc_ZoA.Value != 0)
                {
                    ZA = "        Zoom_Amount: " + Sc_ZoA.Value + "\r\n";
                }
                string STZ = null;
                if(Sc_STZ.Text != "")
                {
                    STZ = "        Sounds_Toggle_Zoom: " + Sc_STZ.Text + "\r\n";
                }
                Scope = "    Scope:\r\n"
                    + "        Enable: true\r\n"
                    + Niv
                    + ZA
                    + "        Zoom_Bullet_Spread: " + Sc_ZBS.Value + "\r\n"
                    + STZ;
            }
            string Region = null;
            if(ReC_Ena.Checked == true)
            {
                string WAC = null;
                if (ReC_WAC.Text != "")
                {
                    WAC = "        World_And_Coordinates: " + ReC_WAC.Text + "\r\n";
                }
                string MOD = null;
                if(ReC_MOD.Text != "")
                {
                    MOD = "        Message_Of_Denial: " + ReC_MOD.Text + "\r\n";
                }
                Region = "    Region_Check:\r\n"
                    + "        Enable: true\r\n"
                    + WAC
                    + MOD;
            }
            string CDM = null;
            if (Cdm_Normal.Text != "")
            {
                CDM = "    Custom_Death_Message:\r\n"
                    + "        Normal: " + Cdm_Normal.Text + "\r\n";
            }
            string HS = null;
            if (Hs_Ena.Checked == true)
            {
                string SS = null;
                if (Hs_SS.Text != "")
                {
                    SS = "        Sounds_Shooter: " + Hs_SS.Text + "\r\n";
                }
                
                HS = "    Headshot:\r\n"
                    + "        Enable: true\r\n"
                    + "        Bonus_Damage: " + Hs_BD.Value + "\r\n"
                    + SS;
            }
            string Abi = null;
            if ((Ab_RHC.Checked == true)||(Ab_Kno.Value != 0)||(Ab_RHC.Checked == true)||(Ab_HE.Checked == true))
            {
                string RHC = null;
                if(Ab_RHC.Checked == true)
                {
                    RHC = "        Reset_Hit_Cooldown: true\r\n";
                }
                string Kno = null;
                if(Ab_Kno.Value != 0)
                {
                    Kno = "        Knockback: " + Ab_Kno.Value + "\r\n";
                }
                string NVR = null;
                if(Ab_NVR.Checked == true)
                {
                    NVR = "        No_Vertical_Recoil: true\r\\n";
                }
                string HE = null;
                if(Ab_HE.Checked == true)
                {
                    HE = "        No_Vertical_Recoil: true\r\n";
                }
                Abi = "    Abilities:"
                    + RHC
                    + Kno
                    + NVR
                    + HE;
            }


            if ((II_IName.Text != "")&&(II_IType.Value != 0)&&(Sh_PrS.Value != 0))
            {
                textBox_output.Text = WN + ":\r\n"
                    + "    Item_Information:\r\n"
                    + "        Item_Name: " + II_IName.Text + "\r\n"
                    + "        Item_Type: " + ItemType + "\r\n"
                    + ItemLore
                    + "    Shooting:\r\n"
                    + RCTS
                    + CLCBD
                    + DBS
                    + ReA
                    + "        Projectile_Amount: " + Sh_PrA.Value + "\r\n"
                    + "        Projectile_Type: " + Sh_PrT.Text + "\r\n"
                    + RBD
                    + "        Projectile_Speed: " + Sh_PrS.Value + "\r\n"
                    + "        Bullet_Spread: " + Sh_BuS.Value + "\r\n"
                    + Shooting_SS
                    + Sneak
                    + FA
                    + Reload
                    + FiA
                    + Scope
                    + Region
                    + CDM
                    + HS
                    + Abi;
            }
            else
            {
                textBox_output.Text = "赤い * マークのところに記述漏れがあります。\r\n"
                    + "再度確認してください。";
            }
        }

        private void button2_Click(object sender, EventArgs e)//コピー
        {
            Clipboard.SetText(textBox_output.Text);
        }

        private void button3_Click(object sender, EventArgs e)//出力クリア
        {
            textBox_output.Text = null;
        }

        private void button4_Click(object sender, EventArgs e)//銃情報クリア
        {
            if (checkBox1.Checked == true)
            {

                II_IName.Text = null;
                II_IType.Value = 0;
                II_IType_meta.Value = 0;
                II_ILore.Text = null;

                Sh_RCTS.Checked = false;
                Sh_CLCBD.Checked = false;
                Sh_DBS.Value = 0;
                Sh_ReA.Value = 0;
                Sh_PrA.Value = 1;
                Sh_PrT.Text = "snowball";
                Sh_RBD.Checked = false;
                Sh_PrS.Value = 0;
                Sh_PrD.Value = 0;
                Sh_BuS.Value = 0;
                Sh_SS.Text = null;

                Sn_Ena.Checked = false;
                Sn_NoR.Checked = false;
                Sn_BuS.Value = 0;

                FA_Ena.Checked = false;
                FA_FiR.Value = 0;

                Re_Ena.Checked = true;
                Re_ReA.Value = 0;
                Re_RBI.Checked = false;
                Re_ReD.Value = 1;
                Re_SOOA.Text = null;
                Re_SR.Text = null;

                FiA_Type.Text = "";
                FiA_OD.Value = 0;
                FiA_CD.Value = 0;
                FiA_SC.Text = null;

                Sc_Ena.Checked = false;
                Sc_NiV.Checked = false;
                Sc_ZoA.Value = 0;
                Sc_ZBS.Value = 0;
                Sc_STZ.Text = null;

                Ab_RHC.Checked = false;
                Ab_Kno.Value = 0;
                Ab_NVR.Checked = true;
                Ab_HE.Checked = false;

                ReC_Ena.Checked = false;
                ReC_WAC.Text = null;
                ReC_MOD.Text = null;

                Hs_Ena.Checked = false;
                Hs_BD.Value = 1;
                Hs_SS.Text = null;

                Cdm_Normal.Text = null;

                linkLabel1.LinkVisited = false;
                linkLabel2.LinkVisited = false;
                linkLabel3.LinkVisited = false;
                linkLabel4.LinkVisited = false;
                linkLabel5.LinkVisited = false;
                linkLabel6.LinkVisited = false;
                linkLabel7.LinkVisited = false;
                linkLabel8.LinkVisited = false;
                linkLabel9.LinkVisited = false;

                checkBox1.Checked = false;
            }

        }






        //********* groupBox等の設定 **********
        private void Sn_Ena_CheckedChanged(object sender, EventArgs e)//Sneek Enabled
        {   
            if(Sn_Ena.Checked == true)
            {
                groupBox4.Enabled = true;
            }
            else
            {
                groupBox4.Enabled = false;
            }
        }

        private void FA_Ena_CheckedChanged(object sender, EventArgs e)//Fully_Automatic
        {
            if(FA_Ena.Checked == true)
            {
                groupBox6.Enabled = true;
            }
            else
            {
                groupBox6.Enabled = false;
            }
        }

        private void Re_Ena_CheckedChanged(object sender, EventArgs e)//Reload
        {
            if(Re_Ena.Checked == true)
            {
                groupBox8.Enabled = true;
            }
            else
            {
                groupBox8.Enabled = false;
            }
        }

        private void Sc_Ena_CheckedChanged(object sender, EventArgs e)//Scope
        {
            if(Sc_Ena.Checked == true)
            {
                groupBox11.Enabled = true;
            }
            else
            {
                groupBox11.Enabled = false;
            }
        }

        private void ReC_Ena_CheckedChanged(object sender, EventArgs e)//Region checks
        {
            if(ReC_Ena.Checked == true)
            {
                groupBox14.Enabled = true;
            }
            else
            {
                groupBox14.Enabled = false;
            }
        }

        private void Hs_Ena_CheckedChanged(object sender, EventArgs e)//Headshots
        {
            if(Hs_Ena.Checked == true)
            {
                groupBox17.Enabled = true;
            }
            else
            {
                groupBox17.Enabled = false;
            }
        }

        private void FiA_Type_SelectedIndexChanged(object sender, EventArgs e)//Firearm_Action
        {
            if(FiA_Type.Text == "bolt")
            {
                FiA_OD.Enabled = true;
            }
            else
            {
                FiA_OD.Enabled = false;
            }
        }

    }
}
