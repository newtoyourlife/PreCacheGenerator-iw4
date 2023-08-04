using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PreCacheGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void WriteToCache(string AnimType, int Limit)
        {
            File.AppendAllText(@"_precache.gsc", "//"+AnimType+ Environment.NewLine);
            string[] lines = File.ReadAllLines(@"Animations\\" + AnimType + ".txt");
            List<string> AnimPool = new List<string>();
            foreach (string line in lines)
            {AnimPool.Add(line);}
            {
                for (int i = 0; i < Limit; i++)
                {
                    Random random = new Random();
                    int randomIndex = random.Next(0, AnimPool.Count);
                    if (AnimPool.Count == 0)
                    {
                        break;
                    }
                    string Anim = AnimPool[randomIndex];
                    File.AppendAllText(@"_precache.gsc", "PrecacheMPAnim(\"" + Anim + "\");" + Environment.NewLine);
                    AnimPool.RemoveAt(randomIndex);
                }
            }
        }

        private int WeightOfType(float main, float w, float x, float y, float z)
        {
            int Limit = int.Parse(txtLimit.Text);
            float total = main + w + x + y + z;
            float mainper = main / total;
            float weight = mainper * Limit;
            int roundedDown = (int)Math.Floor(weight);
            return roundedDown;
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            float MovementSlider = tbMovement.Value;
            float DeathSlider = tbDeaths.Value;
            float ExplosionSlider = tbExplosions.Value;
            float StandIdleSlider = tbStandIdle.Value;
            float MiscSlider = tbMisc.Value;
            int MovementWeight = WeightOfType(MovementSlider, DeathSlider, ExplosionSlider, StandIdleSlider, MiscSlider);
            int DeathWeight = WeightOfType(DeathSlider, MovementSlider, ExplosionSlider, StandIdleSlider, MiscSlider);
            int ExplosionWeight = WeightOfType(ExplosionSlider, DeathSlider, MovementSlider, StandIdleSlider, MiscSlider);
            int StandIdleWeight = WeightOfType(StandIdleSlider, DeathSlider, ExplosionSlider, MovementSlider, MiscSlider);
            int MiscWeight = WeightOfType(MiscSlider, DeathSlider, ExplosionSlider, StandIdleSlider, MovementSlider);

            File.WriteAllText(@"_precache.gsc", "#include maps\\mp\\_utility;" + Environment.NewLine);
            File.AppendAllText(@"_precache.gsc", "#include common_scripts\\utility;" + Environment.NewLine);
            File.AppendAllText(@"_precache.gsc", "#using_animtree(\"multiplayer\");" + Environment.NewLine);
            File.AppendAllText(@"_precache.gsc", "precache(){" + Environment.NewLine);

            if (cbExplosions.Checked)
            {
                int LimitInt = int.Parse(txtLimit.Text); float LimitDec = LimitInt;
                WriteToCache("Explosions", ExplosionWeight);
            }
            if (cbMovement.Checked)
            {
                int LimitInt = int.Parse(txtLimit.Text); float LimitDec = LimitInt;
                WriteToCache("Movement", MovementWeight);
            }
            if (cbDeaths.Checked)
            {
                int LimitInt = int.Parse(txtLimit.Text); float LimitDec = LimitInt;
                WriteToCache("Deaths", DeathWeight);
            }
            if (cbStandIdle.Checked)
            {
                int LimitInt = int.Parse(txtLimit.Text); float LimitDec = LimitInt;
                WriteToCache("StandIdle", StandIdleWeight);
            }
            if (cbMisc.Checked)
            {
                int LimitInt = int.Parse(txtLimit.Text); float LimitDec = LimitInt;
                WriteToCache("Misc", MiscWeight);
            }
            File.AppendAllText(@"_precache.gsc", "}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtLimit_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCrouch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbProne_CheckedChanged(object sender, EventArgs e)
        {
            tbStandIdle.Value = 0;
        }

        private void cbMovement_CheckedChanged(object sender, EventArgs e)
        {
            tbMovement.Value = 0;
        }

        private void cbDeaths_CheckedChanged(object sender, EventArgs e)
        {
            tbDeaths.Value = 0;
        }

        private void cbExplosions_CheckedChanged(object sender, EventArgs e)
        {
            tbExplosions.Value = 0;
        }

        private void cbMisc_CheckedChanged(object sender, EventArgs e)
        {
            tbMisc.Value = 0;
        }
    }
}
