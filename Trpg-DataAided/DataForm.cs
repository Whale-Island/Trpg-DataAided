using System;
using System.Windows.Forms;

namespace Trpg_DataAided
{
    public partial class DataForm : Form
    {
        Player player = new Player();
        public DataForm()
        {
            InitializeComponent();
        }

        private void Focused_Click(object sender, EventArgs e)
        {
            BaseAttributeGroupBox.Focus();
        }

        private void Focused_Click(object sender, MouseEventArgs e)
        {
            BaseAttributeGroupBox.Focus();
        }

        public void InitFromData(Player player)
        {
            this.player = player;
        }

        private void DataForm_Shown(object sender, EventArgs e)
        {
            RefreshDate();
            RefreshResult();
            Focus();

            BaseAttributeGroupBox.MouseClick += new MouseEventHandler(Focused_Click);
            AdditionGroupBox.MouseClick += new MouseEventHandler(Focused_Click);
            ResultGroupBox.MouseClick += new MouseEventHandler(Focused_Click);
            LogGroupBox.MouseClick += new MouseEventHandler(Focused_Click);
        }

        private void UpLevelButton_Click(object sender, EventArgs e)
        {
            player.CurrentProperty.Level++;
        }

        private void DownLevelButton_Click(object sender, EventArgs e)
        {
            player.CurrentProperty.Level--;
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        public void RefreshDate()
        {
            NicknameTextBox.Text = player.Nickname;
            LevelTextBox.Text = player.CurrentProperty.Level.ToString();

            StrengthTextBox.Text = player.CurrentProperty.Strength.ToString();
            PhysiqueTextBox.Text = player.CurrentProperty.Physique.ToString();
            NimbleTextBox.Text = player.CurrentProperty.Nimble.ToString();
            MagicTextBox.Text = player.CurrentProperty.Magic.ToString();
            LoreTextBox.Text = player.CurrentProperty.Lore.ToString();
            InspirationTextBox.Text = player.CurrentProperty.Inspiration.ToString();
            PerceptionTextBox.Text = player.CurrentProperty.Perception.ToString();
            GlamourTextBox.Text = player.CurrentProperty.Glamour.ToString();
            ResolutionTextBox.Text = player.CurrentProperty.Resolution.ToString();

            StrengthGrowTextBox.Text = player.CurrentProperty.Strength_Grow.ToString();
            PhysiqueGrowTextBox.Text = player.CurrentProperty.Physique_Grow.ToString();
            NimbleGrowTextBox.Text = player.CurrentProperty.Nimble_Grow.ToString();
            MagicGrowTextBox.Text = player.CurrentProperty.Magic_Grow.ToString();
            LoreGrowTextBox.Text = player.CurrentProperty.Lore_Grow.ToString();
            InspirationGrowTextBox.Text = player.CurrentProperty.Inspiration_Grow.ToString();
            PerceptionGrowTextBox.Text = player.CurrentProperty.Perception_Grow.ToString();
            GlamourGrowTextBox.Text = player.CurrentProperty.Glamour_Grow.ToString();
            ResolutionGrowTextBox.Text = player.CurrentProperty.Resolution_Grow.ToString();

            HPTextBox.Text = player.CurrentProperty.HP.ToString();
            HPRecoveryTextBox.Text = player.CurrentProperty.HP_Recovery.ToString();
            MANATextBox.Text = player.CurrentProperty.MANA.ToString();
            MANARecoveryTextBox.Text = player.CurrentProperty.MANA_Recovery.ToString();
            SpeedTextBox.Text = player.CurrentProperty.Speed.ToString();
            ChantTextBox.Text = player.CurrentProperty.Chant.ToString();
            AccuracyTextBox.Text = player.CurrentProperty.Accuracy.ToString();
            DodgeTextBox.Text = player.CurrentProperty.Dodge.ToString();
            CriticalTextBox.Text = player.CurrentProperty.Critical.ToString();
            DamageGainTextBox.Text = player.CurrentProperty.DamageGain.ToString();
            DamageMitigationTextBox.Text = player.CurrentProperty.DamageMitigation.ToString();
            GainTextBox.Text = player.CurrentProperty.Gain.ToString();
            SpellResistanceTextBox.Text = player.CurrentProperty.SpellResistance.ToString();
            ExpTextBox.Text = player.CurrentProperty.Exp.ToString();
            HideTextBox.Text = player.CurrentProperty.Hide.ToString();
            EnduraceTextBox.Text = player.CurrentProperty.Endurance.ToString();
            LoadTextBox.Text = player.CurrentProperty.Load.ToString();
            EnergyTextBox.Text = player.CurrentProperty.Energy.ToString();
            SpellDamageTextBox.Text = player.CurrentProperty.SpellDamage.ToString();
            NousTextBox.Text = player.CurrentProperty.Nous.ToString();
            SanityTextBox.Text = player.CurrentProperty.Sanity.ToString();
            LuckTextBox.Text = player.CurrentProperty.Luck.ToString();

            StrengthAdditionTextBox.Text = player.CurrentProperty.Strength_Addition.ToString();
            PhysiqueAdditionTextBox.Text = player.CurrentProperty.Physique_Addition.ToString();
            NimbleAdditionTextBox.Text = player.CurrentProperty.Nimble_Addition.ToString();
            MagicAdditionTextBox.Text = player.CurrentProperty.Magic_Addition.ToString();
            LoreAdditionTextBox.Text = player.CurrentProperty.Lore_Addition.ToString();
            InspirationAdditionTextBox.Text = player.CurrentProperty.Inspiration_Addition.ToString();
            PerceptionAdditionTextBox.Text = player.CurrentProperty.Perception_Addition.ToString();
            GlamourAdditionTextBox.Text = player.CurrentProperty.Glamour_Addition.ToString();
            ResolutionAdditionTextBox.Text = player.CurrentProperty.Resolution_Addition.ToString();

            StrengthPercentTextBox.Text = player.CurrentProperty.Strength_Percent.ToString();
            PhysiquePercentTextBox.Text = player.CurrentProperty.Physique_Percent.ToString();
            NimblePercentTextBox.Text = player.CurrentProperty.Nimble_Percent.ToString();
            MagicPercentTextBox.Text = player.CurrentProperty.Magic_Percent.ToString();
            LorePercentTextBox.Text = player.CurrentProperty.Lore_Percent.ToString();
            InspirationPercentTextBox.Text = player.CurrentProperty.Inspiration_Percent.ToString();
            PerceptionPercentTextBox.Text = player.CurrentProperty.Perception_Percent.ToString();
            GlamourPercentTextBox.Text = player.CurrentProperty.Glamour_Percent.ToString();
            ResolutionPercentTextBox.Text = player.CurrentProperty.Resolution_Percent.ToString();

            HPAdditionTextBox.Text = player.CurrentProperty.HP_Addition.ToString();
            HPRecoveryAdditionTextBox.Text = player.CurrentProperty.HP_Recovery_Addition.ToString();
            MANAAdditionTextBox.Text = player.CurrentProperty.MANA_Addition.ToString();
            MANARecoveryAdditionTextBox.Text = player.CurrentProperty.MANA_Recovery_Addition.ToString();
            SpeedAdditionTextBox.Text = player.CurrentProperty.Speed_Addition.ToString();
            ChantAdditionTextBox.Text = player.CurrentProperty.Chant_Addition.ToString();
            AccuracyAdditionTextBox.Text = player.CurrentProperty.Accuracy_Addition.ToString();
            DodgeAdditionTextBox.Text = player.CurrentProperty.Dodge_Addition.ToString();
            CriticalAdditionTextBox.Text = player.CurrentProperty.Critical_Addition.ToString();
            DamageGainAdditionTextBox.Text = player.CurrentProperty.DamageGain_Addition.ToString();
            DamageMitigationAdditionTextBox.Text = player.CurrentProperty.DamageMitigation_Addition.ToString();
            GainAdditionTextBox.Text = player.CurrentProperty.Gain_Addition.ToString();
            SpellResistanceAdditionTextBox.Text = player.CurrentProperty.SpellResistance_Addition.ToString();
            ExpAdditionTextBox.Text = player.CurrentProperty.Exp_Addition.ToString();
            HideAdditionTextBox.Text = player.CurrentProperty.Hide_Addition.ToString();
            EnduranceAdditionTextBox.Text = player.CurrentProperty.Endurance_Addition.ToString();
            LoadAdditionTextBox.Text = player.CurrentProperty.Load_Addition.ToString();
            EnergyAdditionTextBox.Text = player.CurrentProperty.Energy_Addition.ToString();
            SpellDamageAdditionTextBox.Text = player.CurrentProperty.SpellDamage_Addition.ToString();
            NousAdditionTextBox.Text = player.CurrentProperty.Nous_Addition.ToString();
            SanityAdditionTextBox.Text = player.CurrentProperty.Sanity_Addition.ToString();
            LuckAdditionTextBox.Text = player.CurrentProperty.Luck_Addition.ToString();

            HPPercentTextBox.Text = player.CurrentProperty.HP_Percent.ToString();
            HPRecoveryPercentTextBox.Text = player.CurrentProperty.HP_Recovery_Percent.ToString();
            MANAPercentTextBox.Text = player.CurrentProperty.MANA_Percent.ToString();
            MANARecoveryPercentTextBox.Text = player.CurrentProperty.MANA_Recovery_Percent.ToString();
            SpeedPercentTextBox.Text = player.CurrentProperty.Speed_Percent.ToString();
            ChantPercentTextBox.Text = player.CurrentProperty.Chant_Percent.ToString();
            AccuracyPercentTextBox.Text = player.CurrentProperty.Accuracy_Percent.ToString();
            DodgePercentTextBox.Text = player.CurrentProperty.Dodge_Percent.ToString();
            CriticalPercentTextBox.Text = player.CurrentProperty.Critical_Percent.ToString();
            DamageGainPercentTextBox.Text = player.CurrentProperty.DamageGain_Percent.ToString();
            DamageMitigationPercentTextBox.Text = player.CurrentProperty.DamageMitigation_Percent.ToString();
            GainPercentTextBox.Text = player.CurrentProperty.Gain_Percent.ToString();
            SpellResistancePercentTextBox.Text = player.CurrentProperty.SpellResistance_Percent.ToString();
            ExpPercentTextBox.Text = player.CurrentProperty.Exp_Percent.ToString();
            HidePercentTextBox.Text = player.CurrentProperty.Hide_Percent.ToString();
            EndurancePercentTextBox.Text = player.CurrentProperty.Endurance_Percent.ToString();
            LoadPercentTextBox.Text = player.CurrentProperty.Load_Percent.ToString();
            EnergyPercentTextBox.Text = player.CurrentProperty.Energy_Percent.ToString();
            SpellDamagePercentTextBox.Text = player.CurrentProperty.SpellDamage_Percent.ToString();
            NousPercentTextBox.Text = player.CurrentProperty.Nous_Percent.ToString();
            SanityPercentTextBox.Text = player.CurrentProperty.Sanity_Percent.ToString();
            LuckPercentTextBox.Text = player.CurrentProperty.Luck_Percent.ToString();
        }

        private void SaveData()
        {

            MessageBox.Show("保存成功！");
        }

        private void RefreshResult()
        {
            float Strength = (player.CurrentProperty.Strength + (player.CurrentProperty.Level - 1) * player.CurrentProperty.Strength_Grow + player.CurrentProperty.Strength_Addition) * player.CurrentProperty.Strength_Percent;
            float Physique = (player.CurrentProperty.Physique + (player.CurrentProperty.Level - 1) * player.CurrentProperty.Physique_Grow + player.CurrentProperty.Physique_Addition) * player.CurrentProperty.Physique_Percent;
            float Nimble = (player.CurrentProperty.Nimble + (player.CurrentProperty.Level - 1) * player.CurrentProperty.Nimble_Grow + player.CurrentProperty.Nimble_Addition) * player.CurrentProperty.Nimble_Percent;
            float Magic = (player.CurrentProperty.Magic + (player.CurrentProperty.Level - 1) * player.CurrentProperty.Magic_Grow + player.CurrentProperty.Magic_Addition) * player.CurrentProperty.Magic_Percent;
            float Lore = (player.CurrentProperty.Lore + (player.CurrentProperty.Level - 1) * player.CurrentProperty.Lore_Grow + player.CurrentProperty.Lore_Addition) * player.CurrentProperty.Lore_Percent;
            float Inspiration = (player.CurrentProperty.Inspiration + (player.CurrentProperty.Level - 1) * player.CurrentProperty.Inspiration_Grow + player.CurrentProperty.Inspiration_Addition) * player.CurrentProperty.Inspiration_Percent;
            float Perception = (player.CurrentProperty.Perception + (player.CurrentProperty.Level - 1) * player.CurrentProperty.Perception_Grow + player.CurrentProperty.Perception_Addition) * player.CurrentProperty.Perception_Percent;
            float Glamour = (player.CurrentProperty.Glamour + (player.CurrentProperty.Level - 1) * player.CurrentProperty.Glamour_Grow + player.CurrentProperty.Glamour_Addition) * player.CurrentProperty.Glamour_Percent;
            float Resolution = (player.CurrentProperty.Resolution + (player.CurrentProperty.Level - 1) * player.CurrentProperty.Resolution_Grow + player.CurrentProperty.Resolution_Addition) * player.CurrentProperty.Resolution_Percent;

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
            int Exp = (int)((Lore * 1) / 5) * 5;
            int Hide = 0;
            float Endurance = 20 + ((int)((Strength * 0.5) + (Physique * 1) + (Nimble * 0.5) + (Resolution * 0.2)) / 10) * 20;
            float Load = 15 + (int)((Strength * 0.5) + (Physique * 1) + (Nimble * 0.1) + (Lore * 0.1) + (Resolution * 0.2)) * 5;
            float Energy = 100 + (int)((Strength * 0.2) + (Physique * 1) + (Nimble * 0.2) + (Resolution * 0.5)) * 5;
            int SpellDamage = (int)(Magic * 0.5);
            float Nous = 50 + (int)((Magic * 0.2) + (Lore * 0.5) + (Resolution * 0.2) + (Perception * 0.5)) * 10;
            float Sanity = 4 + (int)((Resolution * 0.5) + (Glamour * 0.2) + (Perception * 0.2) + (Inspiration * 0.2));
            int Luck = 0;

            HP_Dice = (int)((player.CurrentProperty.HP_Addition + HP_Dice) * player.CurrentProperty.HP_Percent);
            HP_Recovery = (int)((player.CurrentProperty.HP_Recovery_Addition + HP_Recovery) * player.CurrentProperty.HP_Recovery_Percent);
            MANA = (int)((player.CurrentProperty.MANA_Addition + MANA) * player.CurrentProperty.MANA_Percent);
            MANA_Recovery = (int)((player.CurrentProperty.MANA_Recovery_Addition + MANA_Recovery) * player.CurrentProperty.MANA_Recovery_Percent);
            Speed = (int)((player.CurrentProperty.Speed_Addition + Speed) * player.CurrentProperty.Speed_Percent);
            Chant = (int)((player.CurrentProperty.Chant_Addition + Chant) * player.CurrentProperty.Chant_Percent);
            Accuracy = (int)((player.CurrentProperty.Accuracy_Addition + Accuracy) * player.CurrentProperty.Accuracy_Percent);
            Dodge = (int)((player.CurrentProperty.Dodge_Addition + Dodge) * player.CurrentProperty.Dodge_Percent);
            Critical = (int)((player.CurrentProperty.Critical_Addition + Critical) * player.CurrentProperty.Critical_Percent);
            DamageGain = (int)((player.CurrentProperty.DamageGain_Addition + DamageGain) * player.CurrentProperty.DamageGain_Percent);
            DamageMitigation = (int)((player.CurrentProperty.DamageMitigation_Addition + DamageMitigation) * player.CurrentProperty.DamageMitigation_Percent);
            Gain = (int)((player.CurrentProperty.Gain_Addition + Gain) * player.CurrentProperty.Gain_Percent);
            Gain_Turn = (int)((player.CurrentProperty.Gain_Addition + Gain_Turn) * player.CurrentProperty.Gain_Percent);
            SpellResistance = (int)((player.CurrentProperty.SpellResistance_Addition + SpellResistance) * player.CurrentProperty.SpellResistance_Percent);
            Exp = (int)((player.CurrentProperty.Exp_Addition + Exp) * player.CurrentProperty.Exp_Percent);
            Hide = (int)((player.CurrentProperty.Hide_Addition + Hide) * player.CurrentProperty.Hide_Percent);
            Endurance = (int)((player.CurrentProperty.Endurance_Addition + Endurance) * player.CurrentProperty.Endurance_Percent);
            Load = (int)((player.CurrentProperty.Load_Addition + Load) * player.CurrentProperty.Load_Percent);
            Energy = (int)((player.CurrentProperty.Energy_Addition + Energy) * player.CurrentProperty.Energy_Percent);
            SpellDamage = (int)((player.CurrentProperty.SpellDamage_Addition + SpellDamage) * player.CurrentProperty.SpellDamage_Percent);
            Nous = (int)((player.CurrentProperty.Nous_Addition + Nous) * player.CurrentProperty.Nous_Percent);
            Sanity = (int)((player.CurrentProperty.Sanity_Addition + Sanity) * player.CurrentProperty.Sanity_Percent);
            Luck = (int)((player.CurrentProperty.Luck_Addition + Luck) * player.CurrentProperty.Luck_Percent);

            int SpellDamage_p = SpellDamage * 5;


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
            ExpResultTextBox.Text = Exp.ToString() + "/" + Exp + "%";
            HideResultTextBox.Text = Hide.ToString();
            EnduranceResultTextBox.Text = Endurance.ToString();
            LoadResultTextBox.Text = Load.ToString() + "s";
            EnergyResultTextBox.Text = Energy.ToString();
            SpellDamageResultTextBox.Text = SpellDamage.ToString() + "/" + SpellDamage_p + "%";
            NousResultTextBox.Text = Nous.ToString();
            SanityResultTextBox.Text = Sanity.ToString() + "D20";
            LuckResultTextBox.Text = Luck.ToString();
        }

        #region TextBox_Leave


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
            else if (player.CurrentProperty.Level != Text)
            {
                player.CurrentProperty.Level = Text;

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
            else if (player.CurrentProperty.Strength != Text)
            {
                player.CurrentProperty.Strength = Text;

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
            else if (player.CurrentProperty.Physique != Text)
            {
                player.CurrentProperty.Physique = Text;

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
            else if (player.CurrentProperty.Nimble != Text)
            {
                player.CurrentProperty.Nimble = Text;

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
            else if (player.CurrentProperty.Magic != Text)
            {
                player.CurrentProperty.Magic = Text;

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
            else if (player.CurrentProperty.Lore != Text)
            {
                player.CurrentProperty.Lore = Text;

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
            else if (player.CurrentProperty.Inspiration != Text)
            {
                player.CurrentProperty.Inspiration = Text;

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
            else if (player.CurrentProperty.Perception != Text)
            {
                player.CurrentProperty.Perception = Text;

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
            else if (player.CurrentProperty.Glamour != Text)
            {
                player.CurrentProperty.Glamour = Text;

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
            else if (player.CurrentProperty.Resolution != Text)
            {
                player.CurrentProperty.Resolution = Text;

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
            else if (player.CurrentProperty.Strength_Grow != Text)
            {
                player.CurrentProperty.Strength_Grow = Text;

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
            else if (player.CurrentProperty.Physique_Grow != Text)
            {
                player.CurrentProperty.Physique_Grow = Text;

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
            else if (player.CurrentProperty.Nimble_Grow != Text)
            {
                player.CurrentProperty.Nimble_Grow = Text;

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
            else if (player.CurrentProperty.Magic_Grow != Text)
            {
                player.CurrentProperty.Magic_Grow = Text;

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
            else if (player.CurrentProperty.Lore_Grow != Text)
            {
                player.CurrentProperty.Lore_Grow = Text;

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
            else if (player.CurrentProperty.Inspiration_Grow != Text)
            {
                player.CurrentProperty.Inspiration_Grow = Text;

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
            else if (player.CurrentProperty.Perception_Grow != Text)
            {
                player.CurrentProperty.Perception_Grow = Text;

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
            else if (player.CurrentProperty.Glamour_Grow != Text)
            {
                player.CurrentProperty.Glamour_Grow = Text;

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
            else if (player.CurrentProperty.Resolution_Grow != Text)
            {
                player.CurrentProperty.Resolution_Grow = Text;

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
            else if (player.CurrentProperty.Strength_Addition != Text)
            {
                player.CurrentProperty.Strength_Addition = Text;

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
            else if (player.CurrentProperty.Physique_Addition != Text)
            {
                player.CurrentProperty.Physique_Addition = Text;

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
            else if (player.CurrentProperty.Nimble_Addition != Text)
            {
                player.CurrentProperty.Nimble_Addition = Text;

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
            else if (player.CurrentProperty.Magic_Addition != Text)
            {
                player.CurrentProperty.Magic_Addition = Text;

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
            else if (player.CurrentProperty.Lore_Addition != Text)
            {
                player.CurrentProperty.Lore_Addition = Text;

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
            else if (player.CurrentProperty.Inspiration_Addition != Text)
            {
                player.CurrentProperty.Inspiration_Addition = Text;

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
            else if (player.CurrentProperty.Perception_Addition != Text)
            {
                player.CurrentProperty.Perception_Addition = Text;

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
            else if (player.CurrentProperty.Glamour_Addition != Text)
            {
                player.CurrentProperty.Glamour_Addition = Text;

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
            else if (player.CurrentProperty.Resolution_Addition != Text)
            {
                player.CurrentProperty.Resolution_Addition = Text;

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
            else if (player.CurrentProperty.Strength_Percent != Text)
            {
                player.CurrentProperty.Strength_Percent = Text;

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
            else if (player.CurrentProperty.Physique_Percent != Text)
            {
                player.CurrentProperty.Physique_Percent = Text;

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
            else if (player.CurrentProperty.Nimble_Percent != Text)
            {
                player.CurrentProperty.Nimble_Percent = Text;

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
            else if (player.CurrentProperty.Magic_Percent != Text)
            {
                player.CurrentProperty.Magic_Percent = Text;

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
            else if (player.CurrentProperty.Lore_Percent != Text)
            {
                player.CurrentProperty.Lore_Percent = Text;

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
            else if (player.CurrentProperty.Inspiration_Percent != Text)
            {
                player.CurrentProperty.Inspiration_Percent = Text;

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
            else if (player.CurrentProperty.Perception_Percent != Text)
            {
                player.CurrentProperty.Perception_Percent = Text;

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
            else if (player.CurrentProperty.Glamour_Percent != Text)
            {
                player.CurrentProperty.Glamour_Percent = Text;

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
            else if (player.CurrentProperty.Resolution_Percent != Text)
            {
                player.CurrentProperty.Resolution_Percent = Text;

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
            else if (player.CurrentProperty.HP_Addition != Text)
            {
                player.CurrentProperty.HP_Addition = Text;

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
            else if (player.CurrentProperty.HP_Recovery_Addition != Text)
            {
                player.CurrentProperty.HP_Recovery_Addition = Text;

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
            else if (player.CurrentProperty.MANA_Addition != Text)
            {
                player.CurrentProperty.MANA_Addition = Text;

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
            else if (player.CurrentProperty.MANA_Recovery_Addition != Text)
            {
                player.CurrentProperty.MANA_Recovery_Addition = Text;

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
            else if (player.CurrentProperty.Speed_Addition != Text)
            {
                player.CurrentProperty.Speed_Addition = Text;

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
            else if (player.CurrentProperty.Chant_Addition != Text)
            {
                player.CurrentProperty.Chant_Addition = Text;

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
            else if (player.CurrentProperty.Accuracy_Addition != Text)
            {
                player.CurrentProperty.Accuracy_Addition = Text;

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
            else if (player.CurrentProperty.Critical_Addition != Text)
            {
                player.CurrentProperty.Critical_Addition = Text;

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
            else if (player.CurrentProperty.DamageGain_Addition != Text)
            {
                player.CurrentProperty.DamageGain_Addition = Text;

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
            else if (player.CurrentProperty.DamageMitigation_Addition != Text)
            {
                player.CurrentProperty.DamageMitigation_Addition = Text;

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
            else if (player.CurrentProperty.Gain_Addition != Text)
            {
                player.CurrentProperty.Gain_Addition = Text;

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
            else if (player.CurrentProperty.SpellResistance_Addition != Text)
            {
                player.CurrentProperty.SpellResistance_Addition = Text;

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
            else if (player.CurrentProperty.Exp_Addition != Text)
            {
                player.CurrentProperty.Exp_Addition = Text;

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
            else if (player.CurrentProperty.Hide_Addition != Text)
            {
                player.CurrentProperty.Hide_Addition = Text;

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
            else if (player.CurrentProperty.Endurance_Addition != Text)
            {
                player.CurrentProperty.Endurance_Addition = Text;

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
            else if (player.CurrentProperty.Load_Addition != Text)
            {
                player.CurrentProperty.Load_Addition = Text;

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
            else if (player.CurrentProperty.Energy_Addition != Text)
            {
                player.CurrentProperty.Energy_Addition = Text;

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
            else if (player.CurrentProperty.SpellDamage_Addition != Text)
            {
                player.CurrentProperty.SpellDamage_Addition = Text;

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
            else if (player.CurrentProperty.Nous_Addition != Text)
            {
                player.CurrentProperty.Nous_Addition = Text;

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
            else if (player.CurrentProperty.Sanity_Addition != Text)
            {
                player.CurrentProperty.Sanity_Addition = Text;

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
            else if (player.CurrentProperty.Luck_Addition != Text)
            {
                player.CurrentProperty.Luck_Addition = Text;

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
            else if (player.CurrentProperty.HP_Percent != Text)
            {
                player.CurrentProperty.HP_Percent = Text;

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
            else if (player.CurrentProperty.HP_Recovery_Percent != Text)
            {
                player.CurrentProperty.HP_Recovery_Percent = Text;

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
            else if (player.CurrentProperty.MANA_Percent != Text)
            {
                player.CurrentProperty.MANA_Percent = Text;

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
            else if (player.CurrentProperty.MANA_Recovery_Percent != Text)
            {
                player.CurrentProperty.MANA_Recovery_Percent = Text;

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
            else if (player.CurrentProperty.Speed_Percent != Text)
            {
                player.CurrentProperty.Speed_Percent = Text;

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
            else if (player.CurrentProperty.Chant_Percent != Text)
            {
                player.CurrentProperty.Chant_Percent = Text;

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
            else if (player.CurrentProperty.Accuracy_Percent != Text)
            {
                player.CurrentProperty.Accuracy_Percent = Text;

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
            else if (player.CurrentProperty.Dodge_Percent != Text)
            {
                player.CurrentProperty.Dodge_Percent = Text;

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
            else if (player.CurrentProperty.Critical_Percent != Text)
            {
                player.CurrentProperty.Critical_Percent = Text;

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
            else if (player.CurrentProperty.DamageGain_Percent != Text)
            {
                player.CurrentProperty.DamageGain_Percent = Text;

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
            else if (player.CurrentProperty.DamageMitigation_Percent != Text)
            {
                player.CurrentProperty.DamageMitigation_Percent = Text;

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
            else if (player.CurrentProperty.Gain_Percent != Text)
            {
                player.CurrentProperty.Gain_Percent = Text;

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
            else if (player.CurrentProperty.SpellResistance_Percent != Text)
            {
                player.CurrentProperty.SpellResistance_Percent = Text;

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
            else if (player.CurrentProperty.Exp_Percent != Text)
            {
                player.CurrentProperty.Exp_Percent = Text;

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
            else if (player.CurrentProperty.Hide_Percent != Text)
            {
                player.CurrentProperty.Hide_Percent = Text;

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
            else if (player.CurrentProperty.Endurance_Percent != Text)
            {
                player.CurrentProperty.Endurance_Percent = Text;

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
            else if (player.CurrentProperty.Load_Percent != Text)
            {
                player.CurrentProperty.Load_Percent = Text;

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
            else if (player.CurrentProperty.Energy_Percent != Text)
            {
                player.CurrentProperty.Energy_Percent = Text;

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
            else if (player.CurrentProperty.SpellDamage_Percent != Text)
            {
                player.CurrentProperty.SpellDamage_Percent = Text;

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
            else if (player.CurrentProperty.Nous_Percent != Text)
            {
                player.CurrentProperty.Nous_Percent = Text;

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
            else if (player.CurrentProperty.Sanity_Percent != Text)
            {
                player.CurrentProperty.Sanity_Percent = Text;

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
            else if (player.CurrentProperty.Luck_Percent != Text)
            {
                player.CurrentProperty.Luck_Percent = Text;

                RefreshResult();
            }
        }



        #endregion

    }
}
