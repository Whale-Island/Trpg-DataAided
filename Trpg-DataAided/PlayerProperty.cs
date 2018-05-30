using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trpg_DataAided
{
    [Serializable]
    public class PlayerProperty
    {
        public int Level { get; set; }

        #region 基本属性
        public float Strength { get; set; }
        public float Physique { get; set; }
        public float Nimble { get; set; }
        public float Magic { get; set; }
        public float Lore { get; set; }
        public float Inspiration { get; set; }
        public float Perception { get; set; }
        public float Glamour { get; set; }
        public float Resolution { get; set; }

        public float HP { get; set; } = 20;
        public float HP_Recovery { get; set; } = 4;
        public float MANA { get; set; }
        public float MANA_Recovery { get; set; }
        public float Speed { get; set; } = 100;
        public float Chant { get; set; }
        public float Accuracy { get; set; } = 0.15f;
        public float Dodge { get; set; }
        public float Critical { get; set; }
        public float DamageGain { get; set; }
        public float DamageMitigation { get; set; }
        public float Gain { get; set; }
        public float SpellResistance { get; set; }
        public float Exp { get; set; }
        public float Hide { get; set; }
        public float Endurance { get; set; } = 20;
        public float Load { get; set; } = 15;
        public float Energy { get; set; } = 100;
        public float SpellDamage { get; set; }
        public float Nous { get; set; } = 50;
        public float Sanity { get; set; }
        public float Luck { get; set; }
        #endregion

        #region 成长值
        public float Strength_Grow { get; set; }
        public float Physique_Grow { get; set; }
        public float Nimble_Grow { get; set; }
        public float Magic_Grow { get; set; }
        public float Lore_Grow { get; set; }
        public float Inspiration_Grow { get; set; }
        public float Perception_Grow { get; set; }
        public float Glamour_Grow { get; set; }
        public float Resolution_Grow { get; set; }
        #endregion

        #region 属性数值加成
        public float Strength_Addition { get; set; }
        public float Physique_Addition { get; set; }
        public float Nimble_Addition { get; set; }
        public float Magic_Addition { get; set; }
        public float Lore_Addition { get; set; }
        public float Inspiration_Addition { get; set; }
        public float Perception_Addition { get; set; }
        public float Glamour_Addition { get; set; }
        public float Resolution_Addition { get; set; }
        #endregion

        #region 属性百分比加成
        public float Strength_Percent { get; set; } = 1;
        public float Physique_Percent { get; set; } = 1;
        public float Nimble_Percent { get; set; } = 1;
        public float Magic_Percent { get; set; } = 1;
        public float Lore_Percent { get; set; } = 1;
        public float Inspiration_Percent { get; set; } = 1;
        public float Perception_Percent { get; set; } = 1;
        public float Glamour_Percent { get; set; } = 1;
        public float Resolution_Percent { get; set; } = 1;
        #endregion

        #region 特性数值加成
        public float HP_Addition { get; set; }
        public float HP_Recovery_Addition { get; set; }
        public float MANA_Addition { get; set; }
        public float MANA_Recovery_Addition { get; set; }
        public float Speed_Addition { get; set; }
        public float Chant_Addition { get; set; }
        public float Accuracy_Addition { get; set; }
        public float Dodge_Addition { get; set; }
        public float Critical_Addition { get; set; }
        public float DamageGain_Addition { get; set; }
        public float DamageMitigation_Addition { get; set; }
        public float Gain_Addition { get; set; }
        public float SpellResistance_Addition { get; set; }
        public float Exp_Addition { get; set; }
        public float Hide_Addition { get; set; }
        public float Endurance_Addition { get; set; }
        public float Load_Addition { get; set; }
        public float Energy_Addition { get; set; }
        public float SpellDamage_Addition { get; set; }
        public float Nous_Addition { get; set; }
        public float Sanity_Addition { get; set; }
        public float Luck_Addition { get; set; }
        #endregion

        #region 特性百分比加成
        public float HP_Percent { get; set; } = 1;
        public float HP_Recovery_Percent { get; set; } = 1;
        public float MANA_Percent { get; set; } = 1;
        public float MANA_Recovery_Percent { get; set; } = 1;
        public float Speed_Percent { get; set; } = 1;
        public float Chant_Percent { get; set; } = 1;
        public float Accuracy_Percent { get; set; } = 1;
        public float Dodge_Percent { get; set; } = 1;
        public float Critical_Percent { get; set; } = 1;
        public float DamageGain_Percent { get; set; } = 1;
        public float DamageMitigation_Percent { get; set; } = 1;
        public float Gain_Percent { get; set; } = 1;
        public float SpellResistance_Percent { get; set; } = 1;
        public float Exp_Percent { get; set; } = 1;
        public float Hide_Percent { get; set; } = 1;
        public float Endurance_Percent { get; set; } = 1;
        public float Load_Percent { get; set; } = 1;
        public float Energy_Percent { get; set; } = 1;
        public float SpellDamage_Percent { get; set; } = 1;
        public float Nous_Percent { get; set; } = 1;
        public float Sanity_Percent { get; set; } = 1;
        public float Luck_Percent { get; set; } = 1;
        #endregion

    }
}
