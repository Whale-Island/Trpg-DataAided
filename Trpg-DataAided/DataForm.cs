using System;
using System.Windows.Forms;

namespace Trpg_DataAided
{
    public partial class DataForm : Form
    {
        Player player =new Player();
        public DataForm()
        {
            InitializeComponent();
        }

        private void DataForm_Activated(object sender, EventArgs e)
        {
            BaseAttributeGroupBox.Focus();
        }

        private void Focused_Click(object sender, EventArgs e)
        {
            BaseAttributeGroupBox.Focus();
        }

        public void InitFromData(Player player)
        {
            this.player = player;
            RefreshDate();
        }

        public void RefreshDate()
        {
            NicknameTextBox.Text = player.Nickname;
            LevelTextBox.Text = player.Level.ToString();

            StrengthTextBox.Text = player.Strength.ToString();
            PhysiqueTextBox.Text = player.Physique.ToString();
            NimbleTextBox.Text = player.Nimble.ToString();
            MagicTextBox.Text = player.Magic.ToString();
            LoreTextBox.Text = player.Lore.ToString();
            InspirationTextBox.Text = player.Inspiration.ToString();
            PerceptionTextBox.Text = player.Perception.ToString();
            GlamourTextBox.Text = player.Glamour.ToString();
            ResolutionTextBox.Text = player.Resolution.ToString();

            StrengthGrowTextBox.Text = player.Strength_Grow.ToString();
            PhysiqueGrowTextBox.Text = player.Physique_Grow.ToString();
            NimbleGrowTextBox.Text = player.Nimble_Grow.ToString();
            MagicGrowTextBox.Text = player.Magic_Grow.ToString();
            LoreGrowTextBox.Text = player.Lore_Grow.ToString();
            InspirationGrowTextBox.Text = player.Inspiration_Grow.ToString();
            PerceptionGrowTextBox.Text = player.Perception_Grow.ToString();
            GlamourGrowTextBox.Text = player.Glamour_Grow.ToString();
            ResolutionGrowTextBox.Text = player.Resolution_Grow.ToString();

            HPTextBox.Text = player.HP.ToString();
            HPRecoveryTextBox.Text = player.HP_Recovery.ToString();
            MANATextBox.Text = player.MANA.ToString();
            MANARecoveryTextBox.Text = player.MANA_Recovery.ToString();
            SpeedTextBox.Text = player.Speed.ToString();
            ChantTextBox.Text = player.Chant.ToString();
            AccuracyTextBox.Text = player.Accuracy.ToString();
            DodgeTextBox.Text = player.Dodge.ToString();
            CriticalTextBox.Text = player.Critical.ToString();
            DamageGainTextBox.Text = player.DamageGain.ToString();
            DamageMitigationTextBox.Text = player.DamageMitigation.ToString();
            GainTextBox.Text = player.Gain.ToString();
            SpellResistanceTextBox.Text = player.SpellResistance.ToString();
            ExpTextBox.Text = player.Exp.ToString();
            HideTextBox.Text = player.Hide.ToString();
            EnduraceTextBox.Text = player.Endurance.ToString();
            LoadTextBox.Text = player.Load.ToString();
            EnergyTextBox.Text = player.Energy.ToString();
            SpellDamageTextBox.Text = player.SpellDamage.ToString();
            NousTextBox.Text = player.Nous.ToString();
            SanityTextBox.Text = player.Sanity.ToString();
            LuckTextBox.Text = player.Luck.ToString();

            StrengthAdditionTextBox.Text = player.Strength_Addition.ToString();
            PhysiqueAdditionTextBox.Text = player.Physique_Addition.ToString();
            NimbleAdditionTextBox.Text = player.Nimble_Addition.ToString();
            MagicAdditionTextBox.Text = player.Magic_Addition.ToString();
            LoreAdditionTextBox.Text = player.Lore_Addition.ToString();
            InspirationAdditionTextBox.Text = player.Inspiration_Addition.ToString();
            PerceptionAdditionTextBox.Text = player.Perception_Addition.ToString();
            GlamourAdditionTextBox.Text = player.Glamour_Addition.ToString();
            ResolutionAdditionTextBox.Text = player.Resolution_Addition.ToString();

            StrengthPercentTextBox.Text = player.Strength_Percent.ToString();
            PhysiquePercentTextBox.Text = player.Physique_Percent.ToString();
            NimblePercentTextBox.Text = player.Nimble_Percent.ToString();
            MagicPercentTextBox.Text = player.Magic_Percent.ToString();
            LorePercentTextBox.Text = player.Lore_Percent.ToString();
            InspirationPercentTextBox.Text = player.Inspiration_Percent.ToString();
            PerceptionPercentTextBox.Text = player.Perception_Percent.ToString();
            GlamourPercentTextBox.Text = player.Glamour_Percent.ToString();
            ResolutionPercentTextBox.Text = player.Resolution_Percent.ToString();

            HPAdditionTextBox.Text = player.HP_Addition.ToString();
            HPRecoveryAdditionTextBox.Text = player.HP_Recovery_Addition.ToString();
            MANAAdditionTextBox.Text = player.MANA_Addition.ToString();
            MANARecoveryAdditionTextBox.Text = player.MANA_Recovery_Addition.ToString();
            SpeedAdditionTextBox.Text = player.Speed_Addition.ToString();
            ChantAdditionTextBox.Text = player.Chant_Addition.ToString();
            AccuracyAdditionTextBox.Text = player.Accuracy_Addition.ToString();
            DodgeAdditionTextBox.Text = player.Dodge_Addition.ToString();
            CriticalAdditionTextBox.Text = player.Critical_Addition.ToString();
            DamageGainAdditionTextBox.Text = player.DamageGain_Addition.ToString();
            DamageMitigationAdditionTextBox.Text = player.DamageMitigation_Addition.ToString();
            GainAdditionTextBox.Text = player.Gain_Addition.ToString();
            SpellResistanceAdditionTextBox.Text = player.SpellResistance_Addition.ToString();
            ExpAdditionTextBox.Text = player.Exp_Addition.ToString();
            HideAdditionTextBox.Text = player.Hide_Addition.ToString();
            EnduranceAdditionTextBox.Text = player.Endurance_Addition.ToString();
            LoadAdditionTextBox.Text = player.Load_Addition.ToString();
            EnergyAdditionTextBox.Text = player.Energy_Addition.ToString();
            SpellDamageAdditionTextBox.Text = player.SpellDamage_Addition.ToString();
            NousAdditionTextBox.Text = player.Nous_Addition.ToString();
            SanityAdditionTextBox.Text = player.Sanity_Addition.ToString();
            LuckAdditionTextBox.Text = player.Luck_Addition.ToString();

            HPPercentTextBox.Text = player.HP_Percent.ToString();
            HPRecoveryPercentTextBox.Text = player.HP_Recovery_Percent.ToString();
            MANAPercentTextBox.Text = player.MANA_Percent.ToString();
            MANARecoveryPercentTextBox.Text = player.MANA_Recovery_Percent.ToString();
            SpeedPercentTextBox.Text = player.Speed_Percent.ToString();
            ChantPercentTextBox.Text = player.Chant_Percent.ToString();
            AccuracyPercentTextBox.Text = player.Accuracy_Percent.ToString();
            DodgePercentTextBox.Text = player.Dodge_Percent.ToString();
            CriticalPercentTextBox.Text = player.Critical_Percent.ToString();
            DamageGainPercentTextBox.Text = player.DamageGain_Percent.ToString();
            DamageMitigationPercentTextBox.Text = player.DamageMitigation_Percent.ToString();
            GainPercentTextBox.Text = player.Gain_Percent.ToString();
            SpellResistancePercentTextBox.Text = player.SpellResistance_Percent.ToString();
            ExpPercentTextBox.Text = player.Exp_Percent.ToString();
            HidePercentTextBox.Text = player.Hide_Percent.ToString();
            EndurancePercentTextBox.Text = player.Endurance_Percent.ToString();
            LoadPercentTextBox.Text = player.Load_Percent.ToString();
            EnergyPercentTextBox.Text = player.Energy_Percent.ToString();
            SpellDamagePercentTextBox.Text = player.SpellDamage_Percent.ToString();
            NousPercentTextBox.Text = player.Nous_Percent.ToString();
            SanityPercentTextBox.Text = player.Sanity_Percent.ToString();
            LuckPercentTextBox.Text = player.Luck_Percent.ToString();
        }

        private void RefreshResult()
        {
            float Strength = (player.Strength + (player.Level - 1) * player.Strength_Grow + player.Strength_Addition) * player.Strength_Percent;
            float Physique = (player.Physique + (player.Level - 1) * player.Physique_Grow + player.Physique_Addition) * player.Physique_Percent;
            float Nimble = (player.Nimble + (player.Level - 1) * player.Nimble_Grow + player.Nimble_Addition) * player.Nimble_Percent;
            float Magic = (player.Magic + (player.Level - 1) * player.Magic_Grow + player.Magic_Addition) * player.Magic_Percent;
            float Lore = (player.Lore + (player.Level - 1) * player.Lore_Grow + player.Lore_Addition) * player.Lore_Percent;
            float Inspiration = (player.Inspiration + (player.Level - 1) * player.Inspiration_Grow + player.Inspiration_Addition) * player.Inspiration_Percent;
            float Perception = (player.Perception + (player.Level - 1) * player.Perception_Grow + player.Perception_Addition) * player.Perception_Percent;
            float Glamour = (player.Glamour + (player.Level - 1) * player.Glamour_Grow + player.Glamour_Addition) * player.Glamour_Percent;
            float Resolution = (player.Resolution + (player.Level - 1) * player.Resolution_Grow + player.Resolution_Addition) * player.Resolution_Percent;

            StrengthResultTextBox.Text = Strength.ToString();
            PhysiqueResultTextBox.Text = Physique.ToString();
            NimbleResultTextBox.Text = Nimble.ToString();
            MagicResultTextBox.Text = Magic.ToString();
            LoreResultTextBox.Text = Lore.ToString();
            InspirationResultTextBox.Text = Inspiration.ToString();
            PerceptionResultTextBox.Text = Perception.ToString();
            GlamourResultTextBox.Text = Glamour.ToString();
            ResolutionResultTextBox.Text = Resolution.ToString();

            int HP_Dice = 2 + (int)((Strength * 0.2) + Physique + (Resolution * 0.5)) / 10;
            int HP_Recovery = 2 + (int)((Physique * 0.2) + (Resolution * 0.05));
            int MANA = ((int)((Magic * 2) + (Lore * 0.2) + (Resolution * 0.5) + (Inspiration * 0.2)) / 10) * 10;
            int MANA_Recovery = (int)((Magic * 0.2) + (Resolution * 0.1) + (Inspiration * 0.1));
            int Speed = 100 + ((int)((Strength * 0.5) + (Nimble * 1.5)) / 10) * 5;
            float Chant = ((int)((Magic * 0.1) + (Lore * 0.2) + (Inspiration * 0.1))) * 0.05f;
            float Accuracy = 0.15f + ((int)((Strength * 0.1) + (int)(Nimble * 0.5) + (int)(Perception * 1)) / 10) * 0.05f;
            float Dodge = ((int)((Nimble * 0.2) + (Perception * 0.5) + (Inspiration * 0.1)) / 10) * 0.05f;
            float Critical = ((int)((Nimble * 0.1) + (Lore * 0.1) + (Perception * 0.5)) / 10) * 0.05f;
            int DamageGain = (int)((Strength * 0.5) + (Inspiration * 0.2)) / 10;
            int DamageMitigation = ((int)((Strength * 0.1) + (Physique * 0.5) + (Nimble * 0.2))) / 10;
            float Gain = ((int)(Physique * 0.05)) * 0.2f;
            int Gain_Turn = (int)Gain;
            float SpellResistance = ((int)((Physique * 0.1) + (Magic * 0.2) + (Resolution * 0.1))) * 0.05f;
            int Exp = (((int)(Lore * 1)) / 5) * 5;
            float Exp_p = Exp * 0.01f;
            int Hide = 0;
            float Endurance = 20 + ((int)((Strength * 0.5) + (Physique * 1) + (Nimble * 0.5) + (Resolution * 0.2)) / 10) * 20;
            float Load = 15 + (int)((Strength * 0.5) + (Physique * 1) + (Nimble * 0.1) + (Lore * 0.1) + (Resolution * 0.2)) * 5;
            float Energy = 100 + (int)((Strength * 0.2) + (Physique * 1) + (Nimble * 0.2) + (Resolution * 0.5)) * 5;
            int SpellDamage = (int)(Magic * 0.5);
            float SpellDamage_p = SpellDamage * 0.05f;
            float Nous = 50 + (int)((Magic * 0.2) + (Lore * 0.5) + (Resolution * 0.2) + (Perception * 0.5)) * 10;
            float Sanity = 4 + (int)((Resolution * 0.5) + (Glamour * 0.2) + (Perception * 0.2) + (Inspiration * 0.2));
            int Luck = 0;

            HPResultTextBox.Text = "20+" + HP_Dice + "D10";
            HPRecoveryResultTextBox.Text = HP_Recovery.ToString();
            MANAResultTextBox.Text = MANA.ToString();
            MANARecoveryResultTextBox.Text = MANA_Recovery.ToString();
            SpeedResultTextBox.Text = Speed.ToString();
            ChantResultTextBox.Text = Chant.ToString();
            AccuracyResultTextBox.Text = Accuracy.ToString();
            DodgeResultTextBox.Text = Dodge.ToString();
            CriticalResultTextBox.Text = Critical.ToString();
            DamageGainResultTextBox.Text = DamageGain.ToString();
            DamageMitigationResultTextBox.Text = DamageMitigation.ToString();
            GainResultTextBox.Text = Gain.ToString() + "+" + Gain_Turn + "T";
            SpellResistanceResultTextBox.Text = SpellResistance.ToString();
            ExpResultTextBox.Text = Exp.ToString() + "/" + Exp_p;
            HideResultTextBox.Text = Hide.ToString();
            EnduranceResultTextBox.Text = Endurance.ToString();
            LoadResultTextBox.Text = Load.ToString() + "s";
            EnergyResultTextBox.Text = Energy.ToString();
            SpellDamageResultTextBox.Text = SpellDamage.ToString() + "/" + SpellDamage_p;
            NousResultTextBox.Text = Nous.ToString();
            SanityResultTextBox.Text = Sanity.ToString() + "D20";
            LuckResultTextBox.Text = Luck.ToString();
        }

        private void NicknameTextBox_Leave(object sender, EventArgs e)
        {
            if (!player.Nickname.Equals(NicknameTextBox.Text))
                player.Nickname = NicknameTextBox.Text;
        }

        private void LevelTextBox_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(LevelTextBox.Text, out int Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Level != Text)
            {
                player.Level = Text;

                RefreshResult();
            }
        }

        private void StrengthTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(StrengthTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Strength != Text)
            {
                player.Strength = Text;

                RefreshResult();
            }
        }

        private void PhysiqueTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(PhysiqueTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Physique != Text)
            {
                player.Physique = Text;

                RefreshResult();
            }
        }

        private void NimbleTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(NimbleTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Nimble != Text)
            {
                player.Nimble = Text;

                RefreshResult();
            }
        }

        private void MagicTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(MagicTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Magic != Text)
            {
                player.Magic = Text;

                RefreshResult();
            }
        }

        private void LoreTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(LoreTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Lore != Text)
            {
                player.Lore = Text;

                RefreshResult();
            }
        }

        private void InspirationTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(InspirationTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Inspiration != Text)
            {
                player.Inspiration = Text;

                RefreshResult();
            }
        }

        private void PerceptionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(PerceptionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Perception != Text)
            {
                player.Perception = Text;

                RefreshResult();
            }
        }

        private void GlamourTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(GlamourTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Glamour != Text)
            {
                player.Glamour = Text;

                RefreshResult();
            }
        }

        private void ResolutionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(ResolutionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Resolution != Text)
            {
                player.Resolution = Text;

                RefreshResult();
            }
        }

        private void StrengthGrowTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(StrengthGrowTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Strength_Grow != Text)
            {
                player.Strength_Grow = Text;

                RefreshResult();
            }
        }

        private void PhysiqueGrowTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(PhysiqueGrowTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Physique_Grow != Text)
            {
                player.Physique_Grow = Text;

                RefreshResult();
            }
        }

        private void NimbleGrowTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(NimbleGrowTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Nimble_Grow != Text)
            {
                player.Nimble_Grow = Text;

                RefreshResult();
            }
        }

        private void MagicGrowTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(MagicGrowTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Magic_Grow != Text)
            {
                player.Magic_Grow = Text;

                RefreshResult();
            }
        }

        private void LoreGrowTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(LoreGrowTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Lore_Grow != Text)
            {
                player.Lore_Grow = Text;

                RefreshResult();
            }
        }

        private void InspirationGrowTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(InspirationGrowTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Inspiration_Grow != Text)
            {
                player.Inspiration_Grow = Text;

                RefreshResult();
            }
        }

        private void PerceptionGrowTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(PerceptionGrowTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Perception_Grow != Text)
            {
                player.Perception_Grow = Text;

                RefreshResult();
            }
        }

        private void GlamourGrowTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(GlamourGrowTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Glamour_Grow != Text)
            {
                player.Glamour_Grow = Text;

                RefreshResult();
            }
        }

        private void ResolutionGrowTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(ResolutionGrowTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Resolution_Grow != Text)
            {
                player.Resolution_Grow = Text;

                RefreshResult();
            }
        }

        private void StrengthAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(StrengthAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Strength_Addition != Text)
            {
                player.Strength_Addition = Text;

                RefreshResult();
            }
        }

        private void PhysiqueAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(PhysiqueAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Physique_Addition != Text)
            {
                player.Physique_Addition = Text;

                RefreshResult();
            }
        }

        private void NimbleAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(NimbleAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Nimble_Addition != Text)
            {
                player.Nimble_Addition = Text;

                RefreshResult();
            }
        }

        private void MagicAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(MagicAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Magic_Addition != Text)
            {
                player.Magic_Addition = Text;

                RefreshResult();
            }
        }

        private void LoreAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(LoreAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Lore_Addition != Text)
            {
                player.Lore_Addition = Text;

                RefreshResult();
            }
        }

        private void InspirationAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(InspirationAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Inspiration_Addition != Text)
            {
                player.Inspiration_Addition = Text;

                RefreshResult();
            }
        }

        private void PerceptionAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(PerceptionAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Perception_Addition != Text)
            {
                player.Perception_Addition = Text;

                RefreshResult();
            }
        }

        private void GlamourAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(GlamourAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Glamour_Addition != Text)
            {
                player.Glamour_Addition = Text;

                RefreshResult();
            }
        }

        private void ResolutionAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(ResolutionAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Resolution_Addition != Text)
            {
                player.Resolution_Addition = Text;

                RefreshResult();
            }
        }

        private void StrengthPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(StrengthPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Strength_Percent != Text)
            {
                player.Strength_Percent = Text;

                RefreshResult();
            }
        }

        private void PhysiquePercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(PhysiquePercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Physique_Percent != Text)
            {
                player.Physique_Percent = Text;

                RefreshResult();
            }
        }

        private void NimblePercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(NimblePercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Nimble_Percent != Text)
            {
                player.Nimble_Percent = Text;

                RefreshResult();
            }
        }

        private void MagicPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(MagicPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Magic_Percent != Text)
            {
                player.Magic_Percent = Text;

                RefreshResult();
            }
        }

        private void LorePercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(LorePercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Lore_Percent != Text)
            {
                player.Lore_Percent = Text;

                RefreshResult();
            }
        }

        private void InspirationPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(InspirationPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Inspiration_Percent != Text)
            {
                player.Inspiration_Percent = Text;

                RefreshResult();
            }
        }

        private void PerceptionPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(PerceptionPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Perception_Percent != Text)
            {
                player.Perception_Percent = Text;

                RefreshResult();
            }
        }

        private void GlamourPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(GlamourPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Glamour_Percent != Text)
            {
                player.Glamour_Percent = Text;

                RefreshResult();
            }
        }

        private void ResolutionPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(ResolutionPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Resolution_Percent != Text)
            {
                player.Resolution_Percent = Text;

                RefreshResult();
            }
        }

        private void HPAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(HPAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.HP_Addition != Text)
            {
                player.HP_Addition = Text;

                RefreshResult();
            }
        }

        private void HPRecoveryAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(HPRecoveryAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.HP_Recovery_Addition != Text)
            {
                player.HP_Recovery_Addition = Text;

                RefreshResult();
            }
        }

        private void MANAAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(MANAAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.MANA_Addition != Text)
            {
                player.MANA_Addition = Text;

                RefreshResult();
            }
        }

        private void MANARecoveryAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(MANARecoveryAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.MANA_Recovery_Addition != Text)
            {
                player.MANA_Recovery_Addition = Text;

                RefreshResult();
            }
        }

        private void SpeedAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(SpeedAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Speed_Addition != Text)
            {
                player.Speed_Addition = Text;

                RefreshResult();
            }
        }

        private void ChantAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(ChantAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Chant_Addition != Text)
            {
                player.Chant_Addition = Text;

                RefreshResult();
            }
        }

        private void AccuracyAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(AccuracyAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Accuracy_Addition != Text)
            {
                player.Accuracy_Addition = Text;

                RefreshResult();
            }
        }

        private void CriticalAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(CriticalAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Critical_Addition != Text)
            {
                player.Critical_Addition = Text;

                RefreshResult();
            }
        }

        private void DamageGainAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(DamageGainAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.DamageGain_Addition != Text)
            {
                player.DamageGain_Addition = Text;

                RefreshResult();
            }
        }

        private void DamageMitigationAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(DamageMitigationAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.DamageMitigation_Addition != Text)
            {
                player.DamageMitigation_Addition = Text;

                RefreshResult();
            }
        }

        private void GainAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(GainAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Gain_Addition != Text)
            {
                player.Gain_Addition = Text;

                RefreshResult();
            }
        }

        private void SpellResistanceAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(SpellResistanceAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.SpellResistance_Addition != Text)
            {
                player.SpellResistance_Addition = Text;

                RefreshResult();
            }
        }

        private void ExpAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(ExpAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Exp_Addition != Text)
            {
                player.Exp_Addition = Text;

                RefreshResult();
            }
        }

        private void HideAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(HideAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Hide_Addition != Text)
            {
                player.Hide_Addition = Text;

                RefreshResult();
            }
        }

        private void EnduranceAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(EnduranceAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Endurance_Addition != Text)
            {
                player.Endurance_Addition = Text;

                RefreshResult();
            }
        }

        private void LoadAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(LoadAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Load_Addition != Text)
            {
                player.Load_Addition = Text;

                RefreshResult();
            }
        }

        private void EnergyAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(EnergyAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Energy_Addition != Text)
            {
                player.Energy_Addition = Text;

                RefreshResult();
            }
        }

        private void SpellDamageAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(SpellDamageAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.SpellDamage_Addition != Text)
            {
                player.SpellDamage_Addition = Text;

                RefreshResult();
            }
        }

        private void NousAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(NousAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Nous_Addition != Text)
            {
                player.Nous_Addition = Text;

                RefreshResult();
            }
        }

        private void SanityAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(SanityAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Sanity_Addition != Text)
            {
                player.Sanity_Addition = Text;

                RefreshResult();
            }
        }

        private void LuckAdditionTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(LuckAdditionTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Luck_Addition != Text)
            {
                player.Luck_Addition = Text;

                RefreshResult();
            }
        }

        private void HPPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(HPPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.HP_Percent != Text)
            {
                player.HP_Percent = Text;

                RefreshResult();
            }
        }

        private void HPRecoveryPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(HPRecoveryPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.HP_Recovery_Percent != Text)
            {
                player.HP_Recovery_Percent = Text;

                RefreshResult();
            }
        }

        private void MANAPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(MANAPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.MANA_Percent != Text)
            {
                player.MANA_Percent = Text;

                RefreshResult();
            }
        }

        private void MANARecoveryPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(MANARecoveryPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.MANA_Recovery_Percent != Text)
            {
                player.MANA_Recovery_Percent = Text;

                RefreshResult();
            }
        }

        private void SpeedPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(SpeedPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Speed_Percent != Text)
            {
                player.Speed_Percent = Text;

                RefreshResult();
            }
        }

        private void ChantPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(ChantPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Chant_Percent != Text)
            {
                player.Chant_Percent = Text;

                RefreshResult();
            }
        }

        private void AccuracyPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(AccuracyPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Accuracy_Percent != Text)
            {
                player.Accuracy_Percent = Text;

                RefreshResult();
            }
        }

        private void DodgePercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(DodgePercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Dodge_Percent != Text)
            {
                player.Dodge_Percent = Text;

                RefreshResult();
            }
        }

        private void CriticalPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(CriticalPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Critical_Percent != Text)
            {
                player.Critical_Percent = Text;

                RefreshResult();
            }
        }

        private void DamageGainPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(DamageGainPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.DamageGain_Percent != Text)
            {
                player.DamageGain_Percent = Text;

                RefreshResult();
            }
        }

        private void DamageMitigationPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(DamageMitigationPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.DamageMitigation_Percent != Text)
            {
                player.DamageMitigation_Percent = Text;

                RefreshResult();
            }
        }

        private void GainPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(GainPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Gain_Percent != Text)
            {
                player.Gain_Percent = Text;

                RefreshResult();
            }
        }

        private void SpellResistancePercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(SpellResistancePercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.SpellResistance_Percent != Text)
            {
                player.SpellResistance_Percent = Text;

                RefreshResult();
            }
        }

        private void ExpPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(ExpPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Exp_Percent != Text)
            {
                player.Exp_Percent = Text;

                RefreshResult();
            }
        }

        private void HidePercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(HidePercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Hide_Percent != Text)
            {
                player.Hide_Percent = Text;

                RefreshResult();
            }
        }

        private void EndurancePercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(EndurancePercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Endurance_Percent != Text)
            {
                player.Endurance_Percent = Text;

                RefreshResult();
            }
        }

        private void LoadPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(LoadPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Load_Percent != Text)
            {
                player.Load_Percent = Text;

                RefreshResult();
            }
        }

        private void EnergyPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(EnergyPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Energy_Percent != Text)
            {
                player.Energy_Percent = Text;

                RefreshResult();
            }
        }

        private void SpellDamagePercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(SpellDamagePercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.SpellDamage_Percent != Text)
            {
                player.SpellDamage_Percent = Text;

                RefreshResult();
            }
        }

        private void NousPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(NousPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Nous_Percent != Text)
            {
                player.Nous_Percent = Text;

                RefreshResult();
            }
        }

        private void SanityPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(SanityPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Sanity_Percent != Text)
            {
                player.Sanity_Percent = Text;

                RefreshResult();
            }
        }

        private void LuckPercentTextBox_Leave(object sender, EventArgs e)
        {
            if (!float.TryParse(LuckPercentTextBox.Text, out float Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (player.Luck_Percent != Text)
            {
                player.Luck_Percent = Text;

                RefreshResult();
            }
        }

    }
}
