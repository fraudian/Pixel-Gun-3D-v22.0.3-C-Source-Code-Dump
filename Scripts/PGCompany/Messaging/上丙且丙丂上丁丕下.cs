using UnityEngine;

namespace PGCompany.Messaging
{
    internal class 上丙且丙丂上丁丕下
    {
        // Fields
        private readonly string 丆万丑丄丁丕丁丕一;
        private readonly string <丙丘一专丆丟丌世业>k__BackingField;
        private readonly string <丏丗丙丄丛丌下丌丒>k__BackingField;
        private readonly System.DateTime <丞丌三丌丝一丕丌三>k__BackingField;
        private readonly string <丆一丙世丘三丅丙丆>k__BackingField;
        private readonly int <丂丗丕下丏不丗丂丏>k__BackingField;
        
        // Properties
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        internal string 丐丅与三万丏丏专上 { get; }
        internal string 东丅丝丟丘上丄丒世 { get; }
        internal System.DateTime 业万一丏丌上三丑丟 { get; }
        internal string 不世丏东丄丟世与不 { get; }
        internal int 丘一与丏与七下专丆 { get; }
        internal string 丄上丑丆下三东丑丘 { get; }
        
        // Methods
        internal 上丙且丙丂上丁丕下(string 丄丒且丙三丆丟与丏, string 丌丈不丄丝七丕万专, System.DateTime 一丏一世丘丐丁丄丟, string 丞丞丐丝丝丏丐丛丞, int 三世东丅丁世且专不, string 不丒三业下丑不丞业)
        {
            string val_7;
            val_1 = new System.Object();
            var val_2 = (丄丒且丙三丆丟与丏 == null) ? 0 : (this);
            if(丄丒且丙三丆丟与丏 == null)
            {
                goto label_1;
            }
            
            mem2[0] = 丄丒且丙三丆丟与丏;
            var val_3 = (val_1 == null) ? 0 : (this);
            if(val_1 == null)
            {
                goto label_3;
            }
            
            mem2[0] = val_1;
            var val_4 = (丞丞丐丝丝丏丐丛丞 == null) ? 0 : (this);
            if(丞丞丐丝丝丏丐丛丞 == null)
            {
                goto label_5;
            }
            
            mem2[0] = 丞丞丐丝丝丏丐丛丞;
            this.<丂丗丕下丏不丗丂丏>k__BackingField = 三世东丅丁世且专不;
            this.<丞丌三丌丝一丕丌三>k__BackingField = 一丏一世丘丐丁丄丟;
            this.丆万丑丄丁丕丁丕一 = 不丒三业下丑不丞业;
            return;
            label_1:
            val_7 = "playerId";
            goto label_8;
            label_3:
            val_7 = "version";
            goto label_8;
            label_5:
            val_7 = "language";
            label_8:
            null = new System.ArgumentNullException(paramName:  val_7);
        }
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        internal string 业丄丁丘丝东丗业与()
        {
            return (string)this.<丙丘一专丆丟丌世业>k__BackingField;
        }
        internal string 丟业丅世丟丗丄丞万()
        {
            return (string)this.<丏丗丙丄丛丌下丌丒>k__BackingField;
        }
        internal System.DateTime 且三丅丘世丑丐丛丅()
        {
            return (System.DateTime)this.<丞丌三丌丝一丕丌三>k__BackingField;
        }
        internal string 上与丆丌丛专丛三万()
        {
            return (string)this.<丆一丙世丘三丅丙丆>k__BackingField;
        }
        internal int 世丏丅世丝丏丒丈七()
        {
            return (int)this.<丂丗丕下丏不丗丂丏>k__BackingField;
        }
        internal string 东业下丞丞丂下丆上()
        {
            string val_1 = this.丆万丑丄丁丕丁丕一;
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            val_1 = System.String.alignConst;
            return (string)val_1;
        }
        internal static bool 东一万丈丘业丂丂丑(string 丏丛与丅丛丌万专丌, out PGCompany.Messaging.上丙且丙丂上丁丕下 下上不丄丕丙万丞丌)
        {
            var val_19;
            string val_19 = 丏丛与丅丛丌万专丌;
            string val_5 = 0;
            string val_3 = 0;
            string val_7 = 0;
            string val_12 = 0;
            string val_10 = 0;
            int val_14 = 0;
            string val_16 = 0;
            下上不丄丕丙万丞丌 = 0;
            val_19 = 0;
            if((System.String.IsNullOrEmpty(value:  val_19)) == true)
            {
                    return (bool)val_19;
            }
            
            object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_19);
            if(val_2 == null)
            {
                    return (bool)val_19;
            }
            
            val_19 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
            val_19 = 0;
            return (bool)val_19;
        }
        internal bool 丘下丛上丑丌丌丌丑(out string 不丒三业下丑不丞业)
        {
            不丒三业下丑不丞业 = this.丆万丑丄丁丕丁丕一;
            return (bool)(this.丆万丑丄丁丕丁丕一 != null) ? 1 : 0;
        }
        public override string ToString()
        {
            System.Text.StringBuilder val_1 = PGCompany.丐丝丕一丒丐丄七与.且七七丗专上丝丄丁(丕专七丙丂丅丕与丘:  256);
            System.Text.StringBuilder val_2 = val_1.Append(value:  "{");
            System.Text.StringBuilder val_4 = val_1.Append(value:  "\"playerId\": \""("\"playerId\": \"") + this.<丙丘一专丆丟丌世业>k__BackingField(this.<丙丘一专丆丟丌世业>k__BackingField) + "\"");
            System.Text.StringBuilder val_6 = val_1.Append(value:  ", \"version\": \""(", \"version\": \"") + this.<丏丗丙丄丛丌下丌丒>k__BackingField(this.<丏丗丙丄丛丌下丌丒>k__BackingField) + "\"");
            System.Globalization.CultureInfo val_7 = PGCompany.Messaging.上丙且丙丂上丁丕下.丙专丝世不业下丂丈();
            System.Text.StringBuilder val_9 = val_1.Append(value:  ", \"timestamp\": \""(", \"timestamp\": \"") + this.<丞丌三丌丝一丕丌三>k__BackingField(this.<丞丌三丌丝一丕丌三>k__BackingField) + "\"");
            System.Text.StringBuilder val_11 = val_1.Append(value:  ", \"language\": \""(", \"language\": \"") + this.<丆一丙世丘三丅丙丆>k__BackingField(this.<丆一丙世丘三丅丙丆>k__BackingField) + "\"");
            System.Text.StringBuilder val_15 = val_1.Append(value:  ", \"timeZone\": "(", \"timeZone\": ") + this.<丂丗丕下丏不丗丂丏>k__BackingField.ToString(provider:  PGCompany.Messaging.上丙且丙丂上丁丕下.丙专丝世不业下丂丈())(this.<丂丗丕下丏不丗丂丏>k__BackingField.ToString(provider:  PGCompany.Messaging.上丙且丙丂上丁丕下.丙专丝世不业下丂丈())));
            if(this.丆万丑丄丁丕丁丕一 != null)
            {
                    System.Text.StringBuilder val_17 = val_1.Append(value:  ", \"token\": \""(", \"token\": \"") + this.丆万丑丄丁丕丁丕一 + "\"");
            }
            
            System.Text.StringBuilder val_18 = val_1.Append(value:  "}");
            return (string)PGCompany.丐丝丕一丒丐丄七与.上万丐丄丅七七丄专(东世丞七丏下不丘丞:  val_1);
        }
    
    }

}
