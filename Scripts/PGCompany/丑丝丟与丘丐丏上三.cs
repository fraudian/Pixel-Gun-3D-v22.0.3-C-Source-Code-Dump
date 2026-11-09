using UnityEngine;

namespace PGCompany
{
    internal class 丑丝丟与丘丐丏上三
    {
        // Fields
        internal PGCompany.丒与丄丐丛万东丒丕 丞丌丑丁三丙丐上丏;
        internal PGCompany.EggRarity 丝丗东与不丂业专丛;
        internal RatingSystem.RatingLeague 专丂丗东丞七丐丙丑;
        
        // Properties
        internal string 下丄丈不与世丐业专 { get; }
        internal PGCompany.东一业丛丑丂丝七丁 丘丞业丈上三丑丘东 { get; }
        internal bool 世万丏东丐世且丏三 { get; }
        
        // Methods
        internal string 业上丙丞丐丄丆丅七()
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            return (string)this.丞丌丑丁三丙丐上丏.ToString();
        }
        internal PGCompany.东一业丛丑丂丝七丁 丘不丘丏丟丕七专丒()
        {
            return 0;
        }
        internal string 丄丁下丑丛丗丁不丛()
        {
            if((System.String.op_Equality(a:  this.业上丙丞丐丄丆丅七(), b:  "egg_new_unique_time")) != false)
            {
                    return "Key_9380";
            }
            
            if(this.万丂东丏丛丙三丒丝() != false)
            {
                    return PGCompany.丑丝丟与丘丐丏上三.世丑丂东专丐与丞三(丙丑七万丆万丆且丌:  this.专丂丗东丞七丐丙丑);
            }
            
            if(this.丝丗东与不丂业专丛 > 5)
            {
                    return "Key_9380";
            }
            
            var val_4 = 106033120 + (this.丝丗东与不丂业专丛) << 2;
            val_4 = val_4 + 106033120;
            goto (106033120 + (this.丝丗东与不丂业专丛) << 2 + 106033120);
        }
        internal string 丞与丏世丅专丄丝丛()
        {
            string val_7;
            var val_8;
            val_7 = this;
            if((System.String.op_Equality(a:  this.业上丙丞丐丄丆丅七(), b:  "egg_new_unique_time")) != false)
            {
                    val_8 = "Key_9381";
                return (string)val_8;
            }
            
            if((this.业上丙丞丐丄丆丅七().Contains(value:  "egg_tournament_")) != false)
            {
                    val_8 = "Key_6305";
                return (string)val_8;
            }
            
            if(this.丝丗东与不丂业专丛 <= 5)
            {
                    var val_7 = 106033144;
                val_7 = (106033144 + (this.丝丗东与不丂业专丛) << 2) + val_7;
            }
            else
            {
                    val_7 = "LkeyForRarity: incorrect rarity: "("LkeyForRarity: incorrect rarity: ") + this.丝丗东与不丂业专丛;
                UnityEngine.Debug.LogErrorFormat(format:  val_7, args:  System.Array.Empty<System.Object>());
                val_8 = "Key_2685";
                return (string)val_8;
            }
        
        }
        internal static string 世丑丂东专丐与丞三(RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
        {
            var val_1;
            if(丙丑七万丆万丆且丌 <= 7)
            {
                    val_1 = mem[130689392 + (丙丑七万丆万丆且丌) << 3];
                val_1 = 130689392 + (丙丑七万丆万丆且丌) << 3;
                return (string)val_1;
            }
            
            val_1 = "";
            return (string)val_1;
        }
        internal bool 万丂东丏丛丙三丒丝()
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = this;
            if((System.String.IsNullOrEmpty(value:  this.业上丙丞丐丄丆丅七())) != false)
            {
                    val_7 = 0;
                return (bool)val_7;
            }
            
            val_6 = this.业上丙丞丐丄丆丅七();
            val_8 = null;
            val_8 = null;
            val_7 = ((val_6.IndexOf(value:  PGCompany.业专丝专丑东丂丐丑.丌东上丈丝丂丛丐丐)) >> 31) ^ 1;
            return (bool)val_7;
        }
        public 丑丝丟与丘丐丏上三()
        {
            this.专丂丗东丞七丐丙丑 = 0;
        }
    
    }

}
