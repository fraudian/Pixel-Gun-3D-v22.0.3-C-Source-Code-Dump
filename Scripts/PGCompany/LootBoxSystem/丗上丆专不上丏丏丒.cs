using UnityEngine;

namespace PGCompany.LootBoxSystem
{
    internal sealed class 丗上丆专不上丏丏丒 : ICloneable
    {
        // Fields
        internal PGCompany.三东丏不丗世丅丌丄 三东丏不丗世丅丌丄;
        internal TagSystem.三与下丘七丘丌丏丄 一丟丘万世一下不下;
        internal PGCompany.LootBoxSystem.丛丂丌丒东丅丌三丅 且丟一丛丈丅丑世七;
        internal bool 丞东丛丅下万不业与;
        internal PGCompany.DataObjects.IntInterval 丞专丏上丈丆下东丛;
        internal int 万丗丂上不下七丅万;
        
        // Methods
        internal 丗上丆专不上丏丏丒(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.一丟丘万世一下不下 = new TagSystem.三与下丘七丘丌丏丄();
            this.三东丏不丗世丅丌丄 = 丈丄不七三万丄丁不;
        }
        public override string ToString()
        {
            string val_15;
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            if(this.丞专丏上丈丆下东丛 != null)
            {
                    object[] val_2 = new object[4];
                val_2[0] = this.三东丏不丗世丅丌丄.业东丅东丌上丗丑不();
                val_2[1] = this.三东丏不丗世丅丌丄.不业丙丒丂丞下丆丙();
                val_2[2] = this.三东丏不丗世丅丌丄.业上丙丞丐丄丆丅七();
                val_2[3] = this.丞专丏上丈丆下东丛;
                string val_6 = System.String.Format(format:  "[{0}]{1}:{2}:{3}", args:  val_2);
            }
            else
            {
                    string val_7 = System.String.Format(format:  "{0}", arg0:  this.三东丏不丗世丅丌丄);
            }
            
            if(val_1 != null)
            {
                    System.Text.StringBuilder val_8 = val_1.Append(value:  val_7);
            }
            else
            {
                    System.Text.StringBuilder val_9 = val_1.Append(value:  val_7);
            }
            
            System.Text.StringBuilder val_10 = val_1.Append(value:  " ");
            string val_11 = System.String.Format(format:  "order={0}", arg0:  this.万丗丂上不下七丅万);
            if(val_1 != null)
            {
                    val_15 = val_11;
                System.Text.StringBuilder val_12 = val_1.Append(value:  val_15);
                return (string)val_1;
            }
            
            val_15 = val_11;
            System.Text.StringBuilder val_13 = val_1.Append(value:  val_15);
            return (string)val_1;
        }
        public object Clone()
        {
            PGCompany.三东丏不丗世丅丌丄 val_9;
            TagSystem.三与下丘七丘丌丏丄 val_10;
            bool val_11;
            PGCompany.DataObjects.IntInterval val_12;
            val_9 = this.三东丏不丗世丅丌丄.Clone();
            if(val_9 != null)
            {
                    val_9 = 0;
            }
            
            new PGCompany.LootBoxSystem.丗上丆专不上丏丏丒() = new PGCompany.LootBoxSystem.丗上丆专不上丏丏丒(丈丄不七三万丄丁不:  val_9);
            if(this.一丟丘万世一下不下 == null)
            {
                goto label_5;
            }
            
            val_10 = this.一丟丘万世一下不下.Clone();
            if(val_10 == null)
            {
                goto label_8;
            }
            
            label_5:
            val_10 = 0;
            label_8:
            if(new PGCompany.LootBoxSystem.丗上丆专不上丏丏丒() != null)
            {
                    .一丟丘万世一下不下 = val_10;
                .且丟一丛丈丅丑世七 = this.且丟一丛丈丅丑世七;
                val_11 = this.丞东丛丅下万不业与;
            }
            else
            {
                    mem[24] = val_10;
                mem[32] = this.且丟一丛丈丅丑世七;
                val_11 = this.丞东丛丅下万不业与;
            }
            
            .丞东丛丅下万不业与 = val_11;
            val_12 = this.丞专丏上丈丆下东丛;
            if(val_12 != null)
            {
                    if(val_12.Clone() != null)
            {
                    val_12 = 0;
            }
            
            }
            
            .丞专丏上丈丆下东丛 = val_12;
            .万丗丂上不下七丅万 = this.万丗丂上不下七丅万;
            return (object)new PGCompany.LootBoxSystem.丗上丆专不上丏丏丒();
        }
        public bool 丟不下下且业丛丄丏(PGCompany.三东丏不丗世丅丌丄 丘丛丏丘丝七世七丅)
        {
            var val_4;
            var val_5;
            if(丘丛丏丘丝七世七丅 == null)
            {
                goto label_5;
            }
            
            if(this == 丘丛丏丘丝七世七丅)
            {
                goto label_2;
            }
            
            if(this.且丟一丛丈丅丑世七 != 3)
            {
                    return this.三东丏不丗世丅丌丄.Equals(丘丛丏丘丝七世七丅:  丘丛丏丘丝七世七丅);
            }
            
            val_4 = this.三东丏不丗世丅丌丄.业东丅东丌上丗丑不();
            if(val_4 == 丘丛丏丘丝七世七丅.业东丅东丌上丗丑不())
            {
                    if(this.丞专丏上丈丆下东丛 != null)
            {
                    return this.丞专丏上丈丆下东丛.上丗不丘上丘丕丟丞(下下丏一丙不丘丌丞:  PGCompany.丁丑上丞业丞丟丛上.不丑不与丟丛丏丘丅(丈丄不七三万丄丁不:  丘丛丏丘丝七世七丅));
            }
            
                return this.丞专丏上丈丆下东丛.上丗不丘上丘丕丟丞(下下丏一丙不丘丌丞:  PGCompany.丁丑上丞业丞丟丛上.不丑不与丟丛丏丘丅(丈丄不七三万丄丁不:  丘丛丏丘丝七世七丅));
            }
            
            label_5:
            val_5 = 0;
            return (bool)val_5;
            label_2:
            val_5 = 1;
            return (bool)val_5;
        }
    
    }

}
