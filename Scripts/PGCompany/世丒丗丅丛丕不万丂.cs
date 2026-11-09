using UnityEngine;

namespace PGCompany
{
    internal class 世丒丗丅丛丕不万丂 : 丗丟丄丈东丝丕丄世, 业世丑丑丞丑丂丘东, 七专丙与东丘丌丘丈
    {
        // Fields
        private PetInfo 丑丅丘丄下七丒世下;
        private CategoryNames <丄上丞不三与一丅丒>k__BackingField;
        
        // Properties
        internal PetInfo 丌专丝丟丒东丙世丑 { get; }
        internal CategoryNames 七丌丌丏丗东丕且丅 { get; set; }
        internal int 业丂上丘业丂且丏丗 { get; }
        internal override ItemRarity 且丐丟专丛丗丏上丙 { get; }
        internal int 丂丛丐丆一丄丑丄丆 { get; }
        internal int 东业世世一且丆丅丒 { get; }
        internal PGCompany.三东丏不丗世丅丌丄 专丙七丑丑丈不世丝 { get; }
        internal bool 丁专丌丕丕七一下丛 { get; }
        
        // Methods
        internal PetInfo 丕东专业七丑丄不万()
        {
            if(this.丑丅丘丄下七丒世下 != null)
            {
                    return val_3;
            }
            
            PetInfo val_3 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七());
            this.丑丅丘丄下七丒世下 = val_3;
            return val_3;
        }
        public 世丒丗丅丛丕不万丂(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.<丄上丞不三与一丅丒>k__BackingField = 25000;
        }
        internal CategoryNames 丒万丕七专不丏丞丌()
        {
            return (CategoryNames)this.<丄上丞不三与一丅丒>k__BackingField;
        }
        private void 与丘丑丒丅丕丞七丈(CategoryNames 丙业与丙丗丝不丈东)
        {
            this.<丄上丞不三与一丅丒>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 一丏丑丅丟世丗丈丒()
        {
            return BalanceController.丅上丂上丅七丑下七(丄丈丞丒且东丝下一:  this.业东丅东丌上丗丑不(), 丘三丟三丁丂丙丑丆:  this.丁丕丁三丁丗不三丟(), 丕一丈丐万丏专丘东:  new System.Nullable<ItemRarity>() {HasValue = false});
        }
        internal override string 七丝七丈丆东三丞丞()
        {
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七())) != null)
            {
                    return (string)val_3.Lkey;
            }
            
            return (string)val_3.Lkey;
        }
        internal override ItemRarity 七东与丄丕丁丛世三()
        {
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七())) != null)
            {
                    return (ItemRarity)val_3.Rarity;
            }
            
            return (ItemRarity)val_3.Rarity;
        }
        internal override string 七业丑不七丐业丟丂()
        {
            string val_4;
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七())) != null)
            {
                    val_4 = val_3.Lkey;
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4 = 0);
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_4);
        }
        internal override string 东且丏丆万与东丙万()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3811");
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  168, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        }
        internal override bool 丞丟丑丆丁丟丁丒万()
        {
            return Rilisoft.PetsManager.丌丈万丆一丒不世三(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七());
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferMiniIcons/pet");
        }
        internal override bool 七丄与不丁丙丑丞不()
        {
            return false;
        }
        internal int 专专丛丞丌丞丒丁丟()
        {
            Rilisoft.PetsManager val_1 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance;
            if(val_1 != null)
            {
                    return val_1.丝丑专不丝丌下丘丄(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七());
            }
            
            return val_1.丝丑专不丝丌下丘丄(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七());
        }
        public int 丁丕丁三丁丗不三丟()
        {
            PetInfo val_3 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七());
            if(val_3 != null)
            {
                    return val_3.CurrentLevel;
            }
            
            return val_3.CurrentLevel;
        }
        public int 万丙东丙丐丕专丈丕()
        {
            return BalanceController.三丞丗丌丟丂上丆三(丄丈丞丒且东丝下一:  this.业东丅东丌上丗丑不());
        }
        public bool 不且丅丏丁世上丙丁()
        {
            return Rilisoft.PetsManager.丌丝丄丟丅业且丗丂(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七());
        }
        public bool 丛不东三一上丈世丛()
        {
            if(this.不且丅丏丁世上丙丁() == true)
            {
                    return false;
            }
            
            if(this.丅丏下丕丛丛与丆丌() < 1)
            {
                    return false;
            }
            
            if(this.一丙专七下万七丅世() < 1)
            {
                    return false;
            }
            
            if(this.一丙专七下万七丅世() < this.丅丏下丕丛丛与丆丌())
            {
                    return false;
            }
            
            var val_8 = (ExperienceController.丞丞丘业东丙丏七丌() >= this.万丑丗丗万丕丏丝与()) ? 1 : 0;
            return false;
        }
        public string 专三丏丏东丌七丅且()
        {
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七())) != null)
            {
                    return (string)val_3.专丕与丒丗丁丘专丟;
            }
        
        }
        public void 下丘丞丙丛丙丙丄与(string 丒丘丏上丙丟丑丕丈)
        {
            Rilisoft.PetsManager val_1 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance;
            if(丒丘丏上丙丟丑丕丈 == null)
            {
                goto label_1;
            }
            
            label_4:
            val_1.下丘丞丙丛丙丙丄与(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七(), 专丐下丙丐七丑丑丂:  丒丘丏上丙丟丑丕丈);
            return;
            label_1:
            if(val_1 != null)
            {
                goto label_4;
            }
            
            goto label_4;
        }
        internal int 一丙专七下万七丅世()
        {
            int val_4;
            if((Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七())) == null)
            {
                    return val_4;
            }
            
            val_4 = val_3.专下与丑三丏丂不丆;
            return val_4;
        }
        internal int 丅丏下丕丛丛与丆丌()
        {
            return BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  this.业东丅东丌上丗丑不(), 且万丛丒丁丏七丅东:  this.丁丕丁三丁丗不三丟(), 丐丏上业丈丂与万丞:  false);
        }
        internal PGCompany.三东丏不丗世丅丌丄 且与丏三不丟丂丙丏()
        {
            var val_9;
            丈丞丕丘丕丗与上一 val_3 = BalanceController.丝丕丗丗丆与丄且三(丄丈丞丒且东丝下一:  this.业东丅东丌上丗丑不(), 且万丛丒丁丏七丅东:  this.丁丕丁三丁丗不三丟(), 丐丏上业丈丂与万丞:  false);
            val_9 = null;
            val_9 = null;
            PGCompany.三东丏不丗世丅丌丄 val_7 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  ((System.String.op_Equality(a:  val_3.东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != true) ? 2015 : 1015);
            if(val_7 != null)
            {
                    return val_7.丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  val_3.丟丂丞不专丆万丒世());
            }
            
            return val_7.丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  val_3.丟丂丞不专丆万丒世());
        }
        internal int 万丑丗丗万丕丏丝与()
        {
            return BalanceController.丆万丐不丆上不东上(丄丈丞丒且东丝下一:  this.业东丅东丌上丗丑不(), 且万丛丒丁丏七丅东:  this.丁丕丁三丁丗不三丟(), 丐丏上业丈丂与万丞:  false);
        }
        internal PGCompany.三东丏不丗世丅丌丄 世与丄三业丐丙丘丕(int 丒七且一东丂丐丛丒)
        {
            PGCompany.三东丏不丗世丅丌丄 val_5 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  247);
            if(val_5 != null)
            {
                    return val_5.丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  UnityEngine.Mathf.Max(a:  0, b:  (Rilisoft.PetsManager.丑丑专丕上七丑丕丐(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七())) * 丒七且一东丂丐丛丒));
            }
            
            return val_5.丙丕丑丟丛丅业丝丙(下下丏一丙不丘丌丞:  UnityEngine.Mathf.Max(a:  0, b:  (Rilisoft.PetsManager.丑丑专丕上七丑丕丐(世丐丗专丅三丝丑丆:  this.业上丙丞丐丄丆丅七())) * 丒七且一东丂丐丛丒));
        }
        internal System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂> 世丙万丞上与一丌丅()
        {
            System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂> val_1 = new System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂>();
            val_1.Add(item:  new PGCompany.丗丒下万与下丂万丂(丒与丏丛且万丘业丆:  8, 丙业与丙丗丝不丈东:  UnityEngine.Mathf.RoundToInt(f:  (float)this.一丏丑丅丟世丗丈丒())));
            return val_1;
        }
        internal bool 丗不丁丅丆不且丏丘()
        {
            return (bool)(this.丁丕丁三丁丗不三丟() == this.万丙东丙丐丕专丈丕()) ? 1 : 0;
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            .<丄上丞不三与一丅丒>k__BackingField = 25000;
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.世丒丗丅丛丕不万丂(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
        public int 丏丈丁专专丘丒丂丂()
        {
            return this.丅丏下丕丛丛与丆丌();
        }
        public int 且丆丟业丞丕丑上且()
        {
            return this.一丙专七下万七丅世();
        }
    
    }

}
