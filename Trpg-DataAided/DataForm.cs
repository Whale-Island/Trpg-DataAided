using System;
using System.Text;
using System.Windows.Forms;

namespace Trpg_DataAided
{
    public partial class DataForm : Form
    {
        int id;
        PlayerProperty Property;
        PlayerProperty PreProperty;
        StringBuilder log = new StringBuilder();
        Object locker = new Object();

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
            id = player.ID;
            NicknameTextBox.Text = player.Nickname;
            Property = (PlayerProperty)Tool.CopyOjbect(player.CurrentProperty);

            if (player.SnapshotList.Count > 1)
                PreProperty = (PlayerProperty)Tool.CopyOjbect(player.SnapshotList[player.SnapshotList.Count - 2].Property);
            else
                PreProperty = (PlayerProperty)Tool.CopyOjbect(Property);

            foreach (PlayerSnapshot snapshot in player.SnapshotList)
            {
                log.Append(string.Format("时间：{0} 类型：{1} 原因：{2}\r\n", snapshot.Date, snapshot.Category, snapshot.Description));
            }
            LogTextBox.Text = log.ToString();
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
            lock (locker)
            {
                PreProperty = (PlayerProperty)Tool.CopyOjbect(Property);
                Property.Level++;
                LevelTextBox.Text = Property.Level.ToString();

                Property.Strength_Grow_Value += Property.Strength_Grow;
                Property.Physique_Grow_Value += Property.Physique_Grow;
                Property.Nimble_Grow_Value += Property.Nimble_Grow;
                Property.Magic_Grow_Value += Property.Magic_Grow;
                Property.Lore_Grow_Value += Property.Lore_Grow;
                Property.Inspiration_Grow_Value += Property.Inspiration_Grow;
                Property.Perception_Grow_Value += Property.Perception_Grow;
                Property.Glamour_Grow_Value += Property.Glamour_Grow;
                Property.Resolution_Grow_Value += Property.Resolution_Grow;

                PlayerSnapshot snapshot = new PlayerSnapshot()
                {
                    Date = DateTime.Now,
                    Category = CategoryEnum.Upgrade,
                    Description = "升级自动保存",
                    Property = (PlayerProperty)Tool.CopyOjbect(Property)
                };
                Manager.Instance.Save(id, NicknameTextBox.Text, snapshot);

                log.Append(string.Format("时间：{0} 类型：{1} 原因：{2}\r\n", snapshot.Date, snapshot.Category, snapshot.Description));
                LogTextBox.Text = log.ToString();

                RefreshDate();
                RefreshResult();
            }
        }

        private void DownLevelButton_Click(object sender, EventArgs e)
        {
            lock (locker)
            {
                if (Property.Level > 1)
                {
                    PreProperty = (PlayerProperty)Tool.CopyOjbect(Property);
                    Property.Level--;
                    LevelTextBox.Text = Property.Level.ToString();
                    Player player = Manager.Instance.list.Find(p => p.ID == id);
                    PlayerProperty temp = player.SnapshotList.FindLast(s => s.Property.Level == Property.Level).Property;

                    Property.Strength_Grow_Value = temp.Strength_Grow_Value;
                    Property.Physique_Grow_Value = temp.Physique_Grow_Value;
                    Property.Nimble_Grow_Value = temp.Nimble_Grow_Value;
                    Property.Magic_Grow_Value = temp.Magic_Grow_Value;
                    Property.Lore_Grow_Value = temp.Lore_Grow_Value;
                    Property.Inspiration_Grow_Value = temp.Inspiration_Grow_Value;
                    Property.Perception_Grow_Value = temp.Perception_Grow_Value;
                    Property.Glamour_Grow_Value = temp.Glamour_Grow_Value;
                    Property.Resolution_Grow_Value = temp.Resolution_Grow_Value;

                    PlayerSnapshot snapshot = new PlayerSnapshot()
                    {
                        Date = DateTime.Now,
                        Category = CategoryEnum.Downgrade,
                        Description = "降级自动保存！",
                        Property = (PlayerProperty)Tool.CopyOjbect(Property)
                    };
                    Manager.Instance.Save(id, NicknameTextBox.Text, snapshot);

                    log.Append(string.Format("时间：{0} 类型：{1} 原因：{2}\r\n", snapshot.Date, snapshot.Category, snapshot.Description));
                    LogTextBox.Text = log.ToString();

                    RefreshDate();
                    RefreshResult();
                }
                else
                    MessageBox.Show("等级不可小于1！");
            }
        }

        private void SaveMenuItem_Click(object sender, EventArgs e)
        {
            SaveForm form = new SaveForm();
            DialogResult result = form.ShowDialog();
            if (DialogResult.Yes == result)
            {
                PlayerSnapshot snapshot = new PlayerSnapshot()
                {
                    Date = DateTime.Now,
                    Category = CategoryEnum.Modify,
                    Description = form.Description,
                    Property = Property
                };
                Manager.Instance.Save(id, NicknameTextBox.Text, snapshot);

                log.Append(string.Format("时间：{0} 类型：{1} 原因：{2}\r\n", snapshot.Date, snapshot.Category, snapshot.Description));
                LogTextBox.Text = log.ToString();

                MessageBox.Show("保存成功!");
            }
        }

        public void RefreshDate()
        {
            LevelTextBox.Text = Property.Level.ToString();

            StrengthTextBox.Text = Property.Strength.ToString();
            PhysiqueTextBox.Text = Property.Physique.ToString();
            NimbleTextBox.Text = Property.Nimble.ToString();
            MagicTextBox.Text = Property.Magic.ToString();
            LoreTextBox.Text = Property.Lore.ToString();
            InspirationTextBox.Text = Property.Inspiration.ToString();
            PerceptionTextBox.Text = Property.Perception.ToString();
            GlamourTextBox.Text = Property.Glamour.ToString();
            ResolutionTextBox.Text = Property.Resolution.ToString();

            StrengthGrowTextBox.Text = Property.Strength_Grow.ToString();
            PhysiqueGrowTextBox.Text = Property.Physique_Grow.ToString();
            NimbleGrowTextBox.Text = Property.Nimble_Grow.ToString();
            MagicGrowTextBox.Text = Property.Magic_Grow.ToString();
            LoreGrowTextBox.Text = Property.Lore_Grow.ToString();
            InspirationGrowTextBox.Text = Property.Inspiration_Grow.ToString();
            PerceptionGrowTextBox.Text = Property.Perception_Grow.ToString();
            GlamourGrowTextBox.Text = Property.Glamour_Grow.ToString();
            ResolutionGrowTextBox.Text = Property.Resolution_Grow.ToString();

            StrengthGrowValueTextBox.Text = Property.Strength_Grow_Value.ToString();
            PhysiqueGrowValueTextBox.Text = Property.Physique_Grow_Value.ToString();
            NimbleGrowValueTextBox.Text = Property.Nimble_Grow_Value.ToString();
            MagicGrowValueTextBox.Text = Property.Magic_Grow_Value.ToString();
            LoreGrowValueTextBox.Text = Property.Lore_Grow_Value.ToString();
            InspirationGrowValueTextBox.Text = Property.Inspiration_Grow_Value.ToString();
            PerceptionGrowValueTextBox.Text = Property.Perception_Grow_Value.ToString();
            GlamourGrowValueTextBox.Text = Property.Glamour_Grow_Value.ToString();
            ResolutionGrowValueTextBox.Text = Property.Resolution_Grow_Value.ToString();

            //HPTextBox.Text = Property.HP.ToString();
            //HPRecoveryTextBox.Text = Property.HP_Recovery.ToString();
            //MANATextBox.Text = Property.MANA.ToString();
            //MANARecoveryTextBox.Text = Property.MANA_Recovery.ToString();
            //SpeedTextBox.Text = Property.Speed.ToString();
            //ChantTextBox.Text = Property.Chant.ToString();
            //AccuracyTextBox.Text = Property.Accuracy.ToString();
            //DodgeTextBox.Text = Property.Dodge.ToString();
            //CriticalTextBox.Text = Property.Critical.ToString();
            //DamageGainTextBox.Text = Property.DamageGain.ToString();
            //DamageMitigationTextBox.Text = Property.DamageMitigation.ToString();
            //GainTextBox.Text = Property.Gain.ToString();
            //SpellResistanceTextBox.Text = Property.SpellResistance.ToString();
            //ExpTextBox.Text = Property.Exp.ToString();
            //HideTextBox.Text = Property.Hide.ToString();
            //EnduraceTextBox.Text = Property.Endurance.ToString();
            //LoadTextBox.Text = Property.Load.ToString();
            //EnergyTextBox.Text = Property.Energy.ToString();
            //SpellDamageTextBox.Text = Property.SpellDamage.ToString();
            //NousTextBox.Text = Property.Nous.ToString();
            //SanityTextBox.Text = Property.Sanity.ToString();
            //LuckTextBox.Text = Property.Luck.ToString();

            StrengthAdditionTextBox.Text = Property.Strength_Addition.ToString();
            PhysiqueAdditionTextBox.Text = Property.Physique_Addition.ToString();
            NimbleAdditionTextBox.Text = Property.Nimble_Addition.ToString();
            MagicAdditionTextBox.Text = Property.Magic_Addition.ToString();
            LoreAdditionTextBox.Text = Property.Lore_Addition.ToString();
            InspirationAdditionTextBox.Text = Property.Inspiration_Addition.ToString();
            PerceptionAdditionTextBox.Text = Property.Perception_Addition.ToString();
            GlamourAdditionTextBox.Text = Property.Glamour_Addition.ToString();
            ResolutionAdditionTextBox.Text = Property.Resolution_Addition.ToString();

            StrengthPercentTextBox.Text = Property.Strength_Percent.ToString();
            PhysiquePercentTextBox.Text = Property.Physique_Percent.ToString();
            NimblePercentTextBox.Text = Property.Nimble_Percent.ToString();
            MagicPercentTextBox.Text = Property.Magic_Percent.ToString();
            LorePercentTextBox.Text = Property.Lore_Percent.ToString();
            InspirationPercentTextBox.Text = Property.Inspiration_Percent.ToString();
            PerceptionPercentTextBox.Text = Property.Perception_Percent.ToString();
            GlamourPercentTextBox.Text = Property.Glamour_Percent.ToString();
            ResolutionPercentTextBox.Text = Property.Resolution_Percent.ToString();

            HPAdditionTextBox.Text = Property.HP_Addition.ToString();
            HPRecoveryAdditionTextBox.Text = Property.HP_Recovery_Addition.ToString();
            MANAAdditionTextBox.Text = Property.MANA_Addition.ToString();
            MANARecoveryAdditionTextBox.Text = Property.MANA_Recovery_Addition.ToString();
            SpeedAdditionTextBox.Text = Property.Speed_Addition.ToString();
            ChantAdditionTextBox.Text = Property.Chant_Addition.ToString();
            AccuracyAdditionTextBox.Text = Property.Accuracy_Addition.ToString();
            DodgeAdditionTextBox.Text = Property.Dodge_Addition.ToString();
            CriticalAdditionTextBox.Text = Property.Critical_Addition.ToString();
            DamageGainAdditionTextBox.Text = Property.DamageGain_Addition.ToString();
            DamageMitigationAdditionTextBox.Text = Property.DamageMitigation_Addition.ToString();
            GainAdditionTextBox.Text = Property.Gain_Addition.ToString();
            SpellResistanceAdditionTextBox.Text = Property.SpellResistance_Addition.ToString();
            ExpAdditionTextBox.Text = Property.Exp_Addition.ToString();
            HideAdditionTextBox.Text = Property.Hide_Addition.ToString();
            EnduranceAdditionTextBox.Text = Property.Endurance_Addition.ToString();
            LoadAdditionTextBox.Text = Property.Load_Addition.ToString();
            EnergyAdditionTextBox.Text = Property.Energy_Addition.ToString();
            SpellDamageAdditionTextBox.Text = Property.SpellDamage_Addition.ToString();
            NousAdditionTextBox.Text = Property.Nous_Addition.ToString();
            SanityAdditionTextBox.Text = Property.Sanity_Addition.ToString();
            LuckAdditionTextBox.Text = Property.Luck_Addition.ToString();

            HPPercentTextBox.Text = Property.HP_Percent.ToString();
            HPRecoveryPercentTextBox.Text = Property.HP_Recovery_Percent.ToString();
            MANAPercentTextBox.Text = Property.MANA_Percent.ToString();
            MANARecoveryPercentTextBox.Text = Property.MANA_Recovery_Percent.ToString();
            SpeedPercentTextBox.Text = Property.Speed_Percent.ToString();
            ChantPercentTextBox.Text = Property.Chant_Percent.ToString();
            AccuracyPercentTextBox.Text = Property.Accuracy_Percent.ToString();
            DodgePercentTextBox.Text = Property.Dodge_Percent.ToString();
            CriticalPercentTextBox.Text = Property.Critical_Percent.ToString();
            DamageGainPercentTextBox.Text = Property.DamageGain_Percent.ToString();
            DamageMitigationPercentTextBox.Text = Property.DamageMitigation_Percent.ToString();
            GainPercentTextBox.Text = Property.Gain_Percent.ToString();
            SpellResistancePercentTextBox.Text = Property.SpellResistance_Percent.ToString();
            ExpPercentTextBox.Text = Property.Exp_Percent.ToString();
            HidePercentTextBox.Text = Property.Hide_Percent.ToString();
            EndurancePercentTextBox.Text = Property.Endurance_Percent.ToString();
            LoadPercentTextBox.Text = Property.Load_Percent.ToString();
            EnergyPercentTextBox.Text = Property.Energy_Percent.ToString();
            SpellDamagePercentTextBox.Text = Property.SpellDamage_Percent.ToString();
            NousPercentTextBox.Text = Property.Nous_Percent.ToString();
            SanityPercentTextBox.Text = Property.Sanity_Percent.ToString();
            LuckPercentTextBox.Text = Property.Luck_Percent.ToString();
        }

        private void RefreshResult()
        {
            float Strength = (Property.Strength + Property.Strength_Grow_Value + Property.Strength_Addition) * Property.Strength_Percent;
            float Physique = (Property.Physique + Property.Physique_Grow_Value + Property.Physique_Addition) * Property.Physique_Percent;
            float Nimble = (Property.Nimble + Property.Nimble_Grow_Value + Property.Nimble_Addition) * Property.Nimble_Percent;
            float Magic = (Property.Magic + Property.Magic_Grow_Value + Property.Magic_Addition) * Property.Magic_Percent;
            float Lore = (Property.Lore + Property.Lore_Grow_Value + Property.Lore_Addition) * Property.Lore_Percent;
            float Inspiration = (Property.Inspiration + Property.Inspiration_Grow_Value + Property.Inspiration_Addition) * Property.Inspiration_Percent;
            float Perception = (Property.Perception + Property.Perception_Grow_Value + Property.Perception_Addition) * Property.Perception_Percent;
            float Glamour = (Property.Glamour + Property.Glamour_Grow_Value + Property.Glamour_Addition) * Property.Glamour_Percent;
            float Resolution = (Property.Resolution + Property.Resolution_Grow_Value + Property.Resolution_Addition) * Property.Resolution_Percent;

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

            HP_Dice = (int)((Property.HP_Addition + HP_Dice) * Property.HP_Percent);
            HP_Recovery = (int)((Property.HP_Recovery_Addition + HP_Recovery) * Property.HP_Recovery_Percent);
            MANA = (int)((Property.MANA_Addition + MANA) * Property.MANA_Percent);
            MANA_Recovery = (int)((Property.MANA_Recovery_Addition + MANA_Recovery) * Property.MANA_Recovery_Percent);
            Speed = (int)((Property.Speed_Addition + Speed) * Property.Speed_Percent);
            Chant = (int)((Property.Chant_Addition + Chant) * Property.Chant_Percent);
            Accuracy = (int)((Property.Accuracy_Addition + Accuracy) * Property.Accuracy_Percent);
            Dodge = (int)((Property.Dodge_Addition + Dodge) * Property.Dodge_Percent);
            Critical = (int)((Property.Critical_Addition + Critical) * Property.Critical_Percent);
            DamageGain = (int)((Property.DamageGain_Addition + DamageGain) * Property.DamageGain_Percent);
            DamageMitigation = (int)((Property.DamageMitigation_Addition + DamageMitigation) * Property.DamageMitigation_Percent);
            Gain = (int)((Property.Gain_Addition + Gain) * Property.Gain_Percent);
            Gain_Turn = (int)((Property.Gain_Addition + Gain_Turn) * Property.Gain_Percent);
            SpellResistance = (int)((Property.SpellResistance_Addition + SpellResistance) * Property.SpellResistance_Percent);
            Exp = (int)((Property.Exp_Addition + Exp) * Property.Exp_Percent);
            Hide = (int)((Property.Hide_Addition + Hide) * Property.Hide_Percent);
            Endurance = (int)((Property.Endurance_Addition + Endurance) * Property.Endurance_Percent);
            Load = (int)((Property.Load_Addition + Load) * Property.Load_Percent);
            Energy = (int)((Property.Energy_Addition + Energy) * Property.Energy_Percent);
            SpellDamage = (int)((Property.SpellDamage_Addition + SpellDamage) * Property.SpellDamage_Percent);
            Nous = (int)((Property.Nous_Addition + Nous) * Property.Nous_Percent);
            Sanity = (int)((Property.Sanity_Addition + Sanity) * Property.Sanity_Percent);
            Luck = (int)((Property.Luck_Addition + Luck) * Property.Luck_Percent);

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

        private void LevelTextBox_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(LevelTextBox.Text, out int Text))
            {
                MessageBox.Show("必须输入数字！");
                RefreshDate();
            }
            else if (Property.Level != Text)
            {
                Property.Level = Text;

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
            else if (Property.Strength != Text)
            {
                Property.Strength = Text;

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
            else if (Property.Physique != Text)
            {
                Property.Physique = Text;

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
            else if (Property.Nimble != Text)
            {
                Property.Nimble = Text;

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
            else if (Property.Magic != Text)
            {
                Property.Magic = Text;

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
            else if (Property.Lore != Text)
            {
                Property.Lore = Text;

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
            else if (Property.Inspiration != Text)
            {
                Property.Inspiration = Text;

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
            else if (Property.Perception != Text)
            {
                Property.Perception = Text;

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
            else if (Property.Glamour != Text)
            {
                Property.Glamour = Text;

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
            else if (Property.Resolution != Text)
            {
                Property.Resolution = Text;

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
            else if (Property.Strength_Grow != Text)
            {
                Property.Strength_Grow = Text;

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
            else if (Property.Physique_Grow != Text)
            {
                Property.Physique_Grow = Text;

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
            else if (Property.Nimble_Grow != Text)
            {
                Property.Nimble_Grow = Text;

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
            else if (Property.Magic_Grow != Text)
            {
                Property.Magic_Grow = Text;

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
            else if (Property.Lore_Grow != Text)
            {
                Property.Lore_Grow = Text;

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
            else if (Property.Inspiration_Grow != Text)
            {
                Property.Inspiration_Grow = Text;

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
            else if (Property.Perception_Grow != Text)
            {
                Property.Perception_Grow = Text;

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
            else if (Property.Glamour_Grow != Text)
            {
                Property.Glamour_Grow = Text;

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
            else if (Property.Resolution_Grow != Text)
            {
                Property.Resolution_Grow = Text;

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
            else if (Property.Strength_Addition != Text)
            {
                Property.Strength_Addition = Text;

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
            else if (Property.Physique_Addition != Text)
            {
                Property.Physique_Addition = Text;

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
            else if (Property.Nimble_Addition != Text)
            {
                Property.Nimble_Addition = Text;

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
            else if (Property.Magic_Addition != Text)
            {
                Property.Magic_Addition = Text;

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
            else if (Property.Lore_Addition != Text)
            {
                Property.Lore_Addition = Text;

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
            else if (Property.Inspiration_Addition != Text)
            {
                Property.Inspiration_Addition = Text;

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
            else if (Property.Perception_Addition != Text)
            {
                Property.Perception_Addition = Text;

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
            else if (Property.Glamour_Addition != Text)
            {
                Property.Glamour_Addition = Text;

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
            else if (Property.Resolution_Addition != Text)
            {
                Property.Resolution_Addition = Text;

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
            else if (Property.Strength_Percent != Text)
            {
                Property.Strength_Percent = Text;

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
            else if (Property.Physique_Percent != Text)
            {
                Property.Physique_Percent = Text;

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
            else if (Property.Nimble_Percent != Text)
            {
                Property.Nimble_Percent = Text;

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
            else if (Property.Magic_Percent != Text)
            {
                Property.Magic_Percent = Text;

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
            else if (Property.Lore_Percent != Text)
            {
                Property.Lore_Percent = Text;

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
            else if (Property.Inspiration_Percent != Text)
            {
                Property.Inspiration_Percent = Text;

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
            else if (Property.Perception_Percent != Text)
            {
                Property.Perception_Percent = Text;

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
            else if (Property.Glamour_Percent != Text)
            {
                Property.Glamour_Percent = Text;

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
            else if (Property.Resolution_Percent != Text)
            {
                Property.Resolution_Percent = Text;

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
            else if (Property.HP_Addition != Text)
            {
                Property.HP_Addition = Text;

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
            else if (Property.HP_Recovery_Addition != Text)
            {
                Property.HP_Recovery_Addition = Text;

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
            else if (Property.MANA_Addition != Text)
            {
                Property.MANA_Addition = Text;

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
            else if (Property.MANA_Recovery_Addition != Text)
            {
                Property.MANA_Recovery_Addition = Text;

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
            else if (Property.Speed_Addition != Text)
            {
                Property.Speed_Addition = Text;

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
            else if (Property.Chant_Addition != Text)
            {
                Property.Chant_Addition = Text;

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
            else if (Property.Accuracy_Addition != Text)
            {
                Property.Accuracy_Addition = Text;

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
            else if (Property.Critical_Addition != Text)
            {
                Property.Critical_Addition = Text;

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
            else if (Property.DamageGain_Addition != Text)
            {
                Property.DamageGain_Addition = Text;

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
            else if (Property.DamageMitigation_Addition != Text)
            {
                Property.DamageMitigation_Addition = Text;

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
            else if (Property.Gain_Addition != Text)
            {
                Property.Gain_Addition = Text;

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
            else if (Property.SpellResistance_Addition != Text)
            {
                Property.SpellResistance_Addition = Text;

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
            else if (Property.Exp_Addition != Text)
            {
                Property.Exp_Addition = Text;

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
            else if (Property.Hide_Addition != Text)
            {
                Property.Hide_Addition = Text;

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
            else if (Property.Endurance_Addition != Text)
            {
                Property.Endurance_Addition = Text;

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
            else if (Property.Load_Addition != Text)
            {
                Property.Load_Addition = Text;

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
            else if (Property.Energy_Addition != Text)
            {
                Property.Energy_Addition = Text;

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
            else if (Property.SpellDamage_Addition != Text)
            {
                Property.SpellDamage_Addition = Text;

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
            else if (Property.Nous_Addition != Text)
            {
                Property.Nous_Addition = Text;

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
            else if (Property.Sanity_Addition != Text)
            {
                Property.Sanity_Addition = Text;

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
            else if (Property.Luck_Addition != Text)
            {
                Property.Luck_Addition = Text;

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
            else if (Property.HP_Percent != Text)
            {
                Property.HP_Percent = Text;

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
            else if (Property.HP_Recovery_Percent != Text)
            {
                Property.HP_Recovery_Percent = Text;

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
            else if (Property.MANA_Percent != Text)
            {
                Property.MANA_Percent = Text;

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
            else if (Property.MANA_Recovery_Percent != Text)
            {
                Property.MANA_Recovery_Percent = Text;

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
            else if (Property.Speed_Percent != Text)
            {
                Property.Speed_Percent = Text;

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
            else if (Property.Chant_Percent != Text)
            {
                Property.Chant_Percent = Text;

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
            else if (Property.Accuracy_Percent != Text)
            {
                Property.Accuracy_Percent = Text;

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
            else if (Property.Dodge_Percent != Text)
            {
                Property.Dodge_Percent = Text;

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
            else if (Property.Critical_Percent != Text)
            {
                Property.Critical_Percent = Text;

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
            else if (Property.DamageGain_Percent != Text)
            {
                Property.DamageGain_Percent = Text;

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
            else if (Property.DamageMitigation_Percent != Text)
            {
                Property.DamageMitigation_Percent = Text;

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
            else if (Property.Gain_Percent != Text)
            {
                Property.Gain_Percent = Text;

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
            else if (Property.SpellResistance_Percent != Text)
            {
                Property.SpellResistance_Percent = Text;

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
            else if (Property.Exp_Percent != Text)
            {
                Property.Exp_Percent = Text;

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
            else if (Property.Hide_Percent != Text)
            {
                Property.Hide_Percent = Text;

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
            else if (Property.Endurance_Percent != Text)
            {
                Property.Endurance_Percent = Text;

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
            else if (Property.Load_Percent != Text)
            {
                Property.Load_Percent = Text;

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
            else if (Property.Energy_Percent != Text)
            {
                Property.Energy_Percent = Text;

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
            else if (Property.SpellDamage_Percent != Text)
            {
                Property.SpellDamage_Percent = Text;

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
            else if (Property.Nous_Percent != Text)
            {
                Property.Nous_Percent = Text;

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
            else if (Property.Sanity_Percent != Text)
            {
                Property.Sanity_Percent = Text;

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
            else if (Property.Luck_Percent != Text)
            {
                Property.Luck_Percent = Text;

                RefreshResult();
            }
        }



        #endregion

        #region Label_Enter
        private void StrengthLabel_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(StrengthLabel, PreProperty.Strength.ToString());
        }

        private void PhysiqueLabel_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(PhysiqueLabel, PreProperty.Physique.ToString());
        }

        private void NimbleLabel_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(NimbleLabel, PreProperty.Nimble.ToString());
        }

        private void MagicLabel_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(MagicLabel, PreProperty.Magic.ToString());
        }

        private void LoreLabel_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(LoreLabel, PreProperty.Lore.ToString());
        }

        private void InspirationLabel_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(InspirationLabel, PreProperty.Inspiration.ToString());
        }

        private void PerceptionLabel_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(PerceptionLabel, PreProperty.Perception.ToString());
        }

        private void GlamourLabel_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(GlamourLabel, PreProperty.Glamour.ToString());
        }

        private void ResolutionLabel_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(ResolutionLabel, PreProperty.Resolution.ToString());
        }

        private void label30_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label30, PreProperty.Strength_Grow.ToString());
        }

        private void label31_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label31, PreProperty.Physique_Grow.ToString());
        }

        private void label32_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label32, PreProperty.Nimble_Grow.ToString());
        }

        private void label33_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label33, PreProperty.Magic_Grow.ToString());
        }

        private void label34_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label34, PreProperty.Lore_Grow.ToString());
        }

        private void label35_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label35, PreProperty.Inspiration_Grow.ToString());
        }

        private void label36_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label36, PreProperty.Perception_Grow.ToString());
        }

        private void label37_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label37, PreProperty.Glamour_Grow.ToString());
        }

        private void label38_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label38, PreProperty.Resolution_Grow.ToString());
        }

        private void label119_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label119, PreProperty.Strength_Grow_Value.ToString());
        }

        private void label120_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label120, PreProperty.Physique_Grow_Value.ToString());
        }

        private void label121_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label121, PreProperty.Nimble_Grow_Value.ToString());
        }

        private void label122_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label122, PreProperty.Magic_Grow_Value.ToString());
        }

        private void label123_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label123, PreProperty.Lore_Grow_Value.ToString());
        }

        private void label124_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label124, PreProperty.Inspiration_Grow_Value.ToString());
        }

        private void label125_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label125, PreProperty.Perception_Grow_Value.ToString());
        }

        private void label126_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label126, PreProperty.Glamour_Grow_Value.ToString());
        }

        private void label127_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label127, PreProperty.Resolution_Grow_Value.ToString());
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label10, PreProperty.Strength_Addition.ToString());
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label11, PreProperty.Physique_Addition.ToString());
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label12, PreProperty.Nimble_Addition.ToString());
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label13, PreProperty.Magic_Addition.ToString());
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label14, PreProperty.Lore_Addition.ToString());
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label15, PreProperty.Inspiration_Addition.ToString());
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label16, PreProperty.Perception_Addition.ToString());
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label17, PreProperty.Glamour_Addition.ToString());
        }

        private void label18_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label18, PreProperty.Resolution_Addition.ToString());
        }

        private void label20_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label20, PreProperty.Strength_Percent.ToString());
        }

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label21, PreProperty.Physique_Percent.ToString());
        }

        private void label22_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label22, PreProperty.Nimble_Percent.ToString());
        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label23, PreProperty.Magic_Percent.ToString());
        }

        private void label24_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label24, PreProperty.Lore_Percent.ToString());
        }

        private void label25_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label25, PreProperty.Inspiration_Percent.ToString());
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label26, PreProperty.Perception_Percent.ToString());
        }

        private void label27_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label27, PreProperty.Glamour_Percent.ToString());
        }

        private void label29_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label29, PreProperty.Resolution_Percent.ToString());
        }

        private void label51_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label51, PreProperty.HP_Addition.ToString());
        }

        private void label52_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label52, PreProperty.HP_Recovery_Addition.ToString());
        }

        private void label53_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label53, PreProperty.MANA_Addition.ToString());
        }

        private void label54_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label54, PreProperty.MANA_Recovery_Addition.ToString());
        }

        private void label55_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label55, PreProperty.Speed_Addition.ToString());
        }

        private void label56_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label56, PreProperty.Chant_Addition.ToString());
        }

        private void label57_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label57, PreProperty.Accuracy_Addition.ToString());
        }

        private void label58_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label58, PreProperty.Dodge_Addition.ToString());
        }

        private void label59_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label59, PreProperty.Critical_Addition.ToString());
        }

        private void label61_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label61, PreProperty.DamageGain_Addition.ToString());
        }

        private void label62_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label62, PreProperty.DamageMitigation_Addition.ToString());
        }

        private void label63_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label63, PreProperty.Gain_Addition.ToString());
        }

        private void label64_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label64, PreProperty.SpellResistance_Addition.ToString());
        }

        private void label65_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label65, PreProperty.Exp_Addition.ToString());
        }

        private void label66_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label66, PreProperty.Hide_Addition.ToString());
        }

        private void label67_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label67, PreProperty.Endurance_Addition.ToString());
        }

        private void label68_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label68, PreProperty.Load_Addition.ToString());
        }

        private void label69_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label69, PreProperty.Energy_Addition.ToString());
        }

        private void label41_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label41, PreProperty.SpellDamage_Addition.ToString());
        }

        private void label42_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label42, PreProperty.Nous_Addition.ToString());
        }

        private void label43_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label43, PreProperty.Sanity_Addition.ToString());
        }

        private void label44_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label44, PreProperty.Luck_Addition.ToString());
        }

        private void label45_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label45, PreProperty.HP_Percent.ToString());
        }

        private void label46_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label46, PreProperty.HP_Recovery_Percent.ToString());
        }

        private void label47_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label47, PreProperty.MANA_Percent.ToString());
        }

        private void label48_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label48, PreProperty.MANA_Recovery_Percent.ToString());
        }

        private void label49_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label49, PreProperty.Speed_Percent.ToString());
        }

        private void label70_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label70, PreProperty.Chant_Percent.ToString());
        }

        private void label71_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label71, PreProperty.Accuracy_Percent.ToString());
        }

        private void label72_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label72, PreProperty.Dodge_Percent.ToString());
        }

        private void label73_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label73, PreProperty.Critical_Percent.ToString());
        }

        private void label74_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label74, PreProperty.DamageGain_Percent.ToString());
        }

        private void label75_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label75, PreProperty.DamageMitigation_Percent.ToString());
        }

        private void label76_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label76, PreProperty.Gain_Percent.ToString());
        }

        private void label77_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label77, PreProperty.SpellResistance_Percent.ToString());
        }

        private void label78_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label78, PreProperty.Exp_Percent.ToString());
        }

        private void label79_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label79, PreProperty.Hide_Percent.ToString());
        }

        private void label80_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label80, PreProperty.Endurance_Percent.ToString());
        }

        private void label81_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label81, PreProperty.Load_Percent.ToString());
        }

        private void label82_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label82, PreProperty.Energy_Percent.ToString());
        }

        private void label83_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label83, PreProperty.SpellDamage_Percent.ToString());
        }

        private void label84_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label84, PreProperty.Nous_Percent.ToString());
        }

        private void label85_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label85, PreProperty.Sanity_Percent.ToString());
        }

        private void label86_MouseEnter(object sender, EventArgs e)
        {
            ToolTip.SetToolTip(label86, PreProperty.Luck_Percent.ToString());
        }
        #endregion
    }
}
