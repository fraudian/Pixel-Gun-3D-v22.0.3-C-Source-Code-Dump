using UnityEngine;

namespace PGCompany
{
    internal sealed class 七东万三万丒丏一丁 : 丆丒丏不丄丝世丁专
    {
        // Fields
        private System.Lazy<PGCompany.ClanLootBoxData> 丁丘丄丕下专东七不;
        private UnityEngine.Texture 三与丕丘丌丈一丆七;
        
        // Properties
        internal PGCompany.ClanLootBoxData 丞丑且东丌与丏丏丁 { get; }
        
        // Methods
        internal PGCompany.ClanLootBoxData 丁专丗万三上丟三丆()
        {
            if(this.丁丘丄丕下专东七不 != null)
            {
                    return this.丁丘丄丕下专东七不.Value;
            }
            
            return this.丁丘丄丕下专东七不.Value;
        }
        public 七东万三万丒丏一丁(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            PGCompany.三东丏不丗世丅丌丄 val_4 = 丈丄不七三万丄丁不;
            七东万三万丒丏一丁.上丌专丄丘丂东且丒 val_1 = new 七东万三万丒丏一丁.上丌专丄丘丂东且丒();
            if(val_1 != null)
            {
                    .丈丄不七三万丄丁不 = val_4;
            }
            else
            {
                    mem[16] = val_4;
                val_4 = mem[16];
            }
            
            this.丁丘丄丕下专东七不 = new System.Lazy<PGCompany.ClanLootBoxData>(valueFactory:  new System.Func<PGCompany.ClanLootBoxData>(object:  val_1, method:  PGCompany.ClanLootBoxData 七东万三万丒丏一丁.上丌专丄丘丂东且丒::下不丕丈万丑不丛下()));
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            var val_8;
            if(this.三与丕丘丌丈一丆七 != 0)
            {
                    return (UnityEngine.Texture)this.三与丕丘丌丈一丆七;
            }
            
            string[] val_2 = new string[7];
            val_2[0] = "OfferIcons/";
            val_8 = null;
            val_8 = null;
            val_2[1] = 不丕与丐不丁丌丅丗.丘丙丝丒三不丞丁丘;
            val_2[2] = "/";
            val_2[3] = 不丕与丐不丁丌丅丗.丘丙丝丒三不丞丁丘;
            val_2[4] = "_";
            val_2[5] = this.业上丙丞丐丄丆丅七();
            val_2[6] = "_icon";
            string val_4 = +val_2;
            UnityEngine.Texture val_5 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_4);
            this.三与丕丘丌丈一丆七 = val_5;
            if(val_5 != 0)
            {
                    return (UnityEngine.Texture)this.三与丕丘丌丈一丆七;
            }
            
            丆丟丟三丗东一丆三.丅丟丝丏七业下丟丗(丕丗丘丑丛与丑业丒:  "Don`t load texture for lootBox: path=\'"("Don`t load texture for lootBox: path=\'") + val_4 + "\'.");
            return (UnityEngine.Texture)this.三与丕丘丌丈一丆七;
        }
        internal bool 丆丝丆万丘丙丐丁丒()
        {
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return false;
            }
            
            if(val_1.Id == null)
            {
                    return false;
            }
            
            string val_2 = this.业上丙丞丐丄丆丅七();
            if(val_2 != null)
            {
                    return val_2.Contains(value:  "wargift_");
            }
            
            return val_2.Contains(value:  "wargift_");
        }
        internal bool 世一下丕丟不不丌丈()
        {
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return false;
            }
            
            if(val_1.Id == null)
            {
                    return false;
            }
            
            string val_2 = this.业上丙丞丐丄丆丅七();
            if(val_2 != null)
            {
                    return val_2.Contains(value:  "craft_super");
            }
            
            return val_2.Contains(value:  "craft_super");
        }
        internal bool 丆万丝丞七丌不丁业()
        {
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return false;
            }
            
            if(val_1.Id == null)
            {
                    return false;
            }
            
            string val_2 = this.业上丙丞丐丄丆丅七();
            if(val_2 != null)
            {
                    return val_2.Contains(value:  "craft_small");
            }
            
            return val_2.Contains(value:  "craft_small");
        }
        internal bool 丁丙丅七丕专与上丂()
        {
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return false;
            }
            
            if(val_1.Id == null)
            {
                    return false;
            }
            
            string val_2 = this.业上丙丞丐丄丆丅七();
            if(val_2 != null)
            {
                    return val_2.Contains(value:  "craft_medium");
            }
            
            return val_2.Contains(value:  "craft_medium");
        }
        internal bool 不七不丁专丌专丄丅()
        {
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return false;
            }
            
            if(val_1.Id == null)
            {
                    return false;
            }
            
            string val_2 = this.业上丙丞丐丄丆丅七();
            if(val_2 != null)
            {
                    return val_2.Contains(value:  "craft_big");
            }
            
            return val_2.Contains(value:  "craft_big");
        }
        internal PGCompany.ClanLootBoxData.DivisionConfig 丟东丆丙东丄丅不丝()
        {
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                    return 0;
            }
            
            this = this.丁专丗万三上丟三丆();
            if(this == null)
            {
                    return 0;
            }
            
            return this.丒不丝丒丑丕丌不丛(丅丅下丟丑专下与一:  (Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丑与丏丈丕七丙丂()) + 1);
        }
        internal override string 七丝七丈丆东三丞丞()
        {
            null = null;
            return 不丕与丐不丁丌丅丗.丘丙丝丒三不丞丁丘 + "_Title_" + this.业上丙丞丐丄丆丅七();
        }
        internal override string 东且丏丆万与东丙万()
        {
            null = null;
            return I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  不丕与丐不丁丌丅丗.丘丙丝丒三不丞丁丘 + "_Description_" + this.业上丙丞丐丄丆丅七());
        }
        internal int 丂万丞与丈丙丅丝七()
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_4;
            if(this.丟东丆丙东丄丅不丝() == null)
            {
                    return (int)val_4;
            }
            
            val_4 = val_1.Points;
            return (int)val_4;
        }
        internal string 丂与丙业且不不下丗()
        {
            object val_3;
            if(this.丁专丗万三上丟三丆() != null)
            {
                    val_3 = 0;
                return (string)System.String.Format(format:  "NguiWindows/Clan/ClanLootBox{0}Info", arg0:  val_3 = 0);
            }
            
            return (string)System.String.Format(format:  "NguiWindows/Clan/ClanLootBox{0}Info", arg0:  val_3);
        }
        internal string 一丄丅丑丌丕丈丘不()
        {
            return "NguiWindows/Clan/ClanLootBoxCraftInfo";
        }
        internal override string 丟七万东万七丙丘丌()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5693");
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.七东万三万丒丏一丁(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
