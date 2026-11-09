using UnityEngine;

namespace PGCompany
{
    internal sealed class 丏丌丝丕丐七丈且丒 : 业丞且丞丁丅丏丏丐, 七专丙与东丘丌丘丈
    {
        // Fields
        private PGCompany.七且丕丆丘丙下丟丟 丁丘丄丕下专东七不;
        
        // Properties
        internal override int 丒专下与丑丁丆丟业 { get; }
        internal PGCompany.七且丕丆丘丙下丟丟 丞丑且东丌与丏丏丁 { get; }
        internal PGCompany.丗丑丕丕不丄丘丒丆 丏丂丌丈上丂丘上丌 { get; }
        internal PGCompany.丗丑丕丕不丄丘丒丆 七丘丕专专丞丝丝丑 { get; }
        
        // Methods
        internal override int 丂丁丏一丙丛业且丌()
        {
            return 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  (this.丁丕丁三丁丗不三丟() > 0) ? 1 : 0);
        }
        internal PGCompany.七且丕丆丘丙下丟丟 丁专丗万三上丟三丆()
        {
            if(this.丁丘丄丕下专东七不 != null)
            {
                    return val_3;
            }
            
            PGCompany.七且丕丆丘丙下丟丟 val_3 = PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().世丕与丝专丆丐丁丁(丆专且丕专丗与一丏:  this.业东丅东丌上丗丑不());
            this.丁丘丄丕下专东七不 = val_3;
            return val_3;
        }
        internal PGCompany.丗丑丕丕不丄丘丒丆 世东丈丙丑下与三丝()
        {
            return (PGCompany.丗丑丕丕不丄丘丒丆)PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.丗丑丕丕不丄丘丒丆>(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        }
        internal PGCompany.丗丑丕丕不丄丘丒丆 丞万丒丌丈东丄业下()
        {
            if(this == null)
            {
                    return (PGCompany.丗丑丕丕不丄丘丒丆)this;
            }
            
            if(null == null)
            {
                    return (PGCompany.丗丑丕丕不丄丘丒丆)this;
            }
            
            this = 0;
            return (PGCompany.丗丑丕丕不丄丘丒丆)this;
        }
        public 丏丌丝丕丐七丈且丒(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
        
        }
        internal override PGCompany.丐三丛丑丛丟七丕丛 丝丆丂丆不丟丌丕丝()
        {
            PGCompany.世东三上七丂丌下丑 val_1 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.一丌世丑丄东丞丘三<PGCompany.丐三丛丑丛丟七丕丛>(丞世不丒下上上丝丑:  PGCompany.七丄三丝丐业丄丅丝.丌东一世三下丝不丂(丛业业世丌丟丝丁丌:  this.业东丅东丌上丗丑不()));
            }
            
            return val_1.一丌世丑丄东丞丘三<PGCompany.丐三丛丑丛丟七丕丛>(丞世不丒下上上丝丑:  PGCompany.七丄三丝丐业丄丅丝.丌东一世三下丝不丂(丛业业世丌丟丝丁丌:  this.业东丅东丌上丗丑不()));
        }
        public int 丁丕丁三丁丗不三丟()
        {
            丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_2 == null)
            {
                    return (int)val_2;
            }
            
            PGCompany.丁丏丝上丘丝丒丞丒 val_3 = val_2.东万丕丗丅万丄丘丙();
            if(val_3 != null)
            {
                    return val_3.三三三东丑丁且与万(丛丑丅丞丝丈丘丆三:  this.业东丅东丌上丗丑不());
            }
            
            return val_3.三三三东丑丁且与万(丛丑丅丞丝丈丘丆三:  this.业东丅东丌上丗丑不());
        }
        public int 万丙东丙丐丕专丈丕()
        {
            PGCompany.七且丕丆丘丙下丟丟 val_1 = this.丁专丗万三上丟三丆();
            if(val_1 == null)
            {
                    return (int)val_1;
            }
            
            if(val_1.UpSettings != null)
            {
                    return val_1.UpSettings.Count;
            }
            
            return val_1.UpSettings.Count;
        }
        internal bool 丁丟丈丌丑丅丞世丏()
        {
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            val_19 = this;
            val_20 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().七不世与一丛丐丕丛();
            int val_18 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东万丂丙业与丆东丐();
            if(this.丙丅丗丏丆丆世世丙() == false)
            {
                goto label_5;
            }
            
            丟上丛丏丙丙丄丟业 val_10 = this.不丛七丌丂丌专下三(丞丌东丟且丒丐丑丂:  this.丁丕丁三丁丗不三丟());
            if(val_10 == null)
            {
                goto label_6;
            }
            
            int val_11 = val_10.丕丆丆世万丆丁丕丘();
            val_21 = 0;
            goto label_7;
            label_5:
            val_22 = 0;
            return (bool)val_22;
            label_6:
            val_21 = 0;
            label_7:
            val_20 = val_21.丙东专丂世丈丏丁丂();
            val_22 = 0;
            if((val_20 + 1) < val_20)
            {
                    return (bool)val_22;
            }
            
            if(( & 1) == 0)
            {
                    return (bool)val_22;
            }
            
            val_18 = val_18 + 1;
            丟上丛丏丙丙丄丟业 val_14 = this.不丛七丌丂丌专下三(丞丌东丟且丒丐丑丂:  this.丁丕丁三丁丗不三丟());
            if(val_14 != null)
            {
                    int val_15 = val_14.丘不丈丟不丅上丄业();
                val_23 = 0;
            }
            else
            {
                    val_23 = 0;
            }
            
            val_19 = val_23.丙东专丂世丈丏丁丂();
            val_22 = ((val_18 >= val_19) ? 1 : 0) & 1152921555593495752;
            return (bool)val_22;
        }
        internal bool 丙丅丗丏丆丆世世丙()
        {
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return (bool)(val_2.UpSettings.Count > this.丁丕丁三丁丗不三丟()) ? 1 : 0;
            }
            
            PGCompany.七且丕丆丘丙下丟丟 val_2 = this.丁专丗万三上丟三丆();
            return (bool)(val_2.UpSettings.Count > this.丁丕丁三丁丗不三丟()) ? 1 : 0;
        }
        private PGCompany.七且丕丆丘丙下丟丟.丟上丛丏丙丙丄丟业 不丛七丌丂丌专下三(int 丞丌东丟且丒丐丑丂)
        {
            var val_6;
            if(this.丁专丗万三上丟三丆() == null)
            {
                    return (丟上丛丏丙丙丄丟业)val_6;
            }
            
            PGCompany.七且丕丆丘丙下丟丟 val_2 = this.丁专丗万三上丟三丆();
            if(val_2.UpSettings.Count > 丞丌东丟且丒丐丑丂)
            {
                    PGCompany.七且丕丆丘丙下丟丟 val_4 = this.丁专丗万三上丟三丆();
                丟上丛丏丙丙丄丟业 val_5 = val_4.UpSettings.Item[丞丌东丟且丒丐丑丂];
                return (丟上丛丏丙丙丄丟业)val_6;
            }
            
            val_6 = 0;
            return (丟上丛丏丙丙丄丟业)val_6;
        }
        public PGCompany.七且丕丆丘丙下丟丟.丟上丛丏丙丙丄丟业 丁丙丑万丒丒世不丕()
        {
            return this.不丛七丌丂丌专下三(丞丌东丟且丒丐丑丂:  this.丁丕丁三丁丗不三丟());
        }
        internal int 丏丈丁专专丘丒丂丂()
        {
            丟上丛丏丙丙丄丟业 val_2 = this.不丛七丌丂丌专下三(丞丌东丟且丒丐丑丂:  this.丁丕丁三丁丗不三丟());
            if(val_2 == null)
            {
                    return (int)val_2;
            }
            
            return val_2.丛业上下业丒丛与丞();
        }
        internal int 丌与一丏丏丌不不丒()
        {
            return UnityEngine.Mathf.Max(a:  0, b:  this.丏丈丁专专丘丒丂丂() - this.且丆丟业丞丕丑上且());
        }
        internal int 且丆丟业丞丕丑上且()
        {
            return (int)PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
        }
        public override string ToString()
        {
            object[] val_1 = new object[5];
            string val_2 = this.ToString();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_1[0] = val_2;
            val_1[1] = this.丁丕丁三丁丗不三丟();
            val_1[2] = this.且丆丟业丞丕丑上且();
            val_1[3] = this.丏丈丁专专丘丒丂丂();
            val_1[4] = this.丌与一丏丏丌不不丒();
            return (string)System.String.Format(format:  "{0} up={1} {2}/{3}[{4}]", args:  val_1);
        }
        public void 丑丆丞业丗丐丂丏丄()
        {
            BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  this.丆丅不丛一丆丕丏丒(), 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        private BannerWindowType 丆丅不丛一丆丕丏丒()
        {
            var val_4;
            if(this.业东丅东丌上丗丑不() != 100015)
            {
                    return (BannerWindowType)(this.业东丅东丌上丗丑不() == (100015 + 2000)) ? 57 : (!0);
            }
            
            val_4 = 56;
            return (BannerWindowType)(this.业东丅东丌上丗丑不() == (100015 + 2000)) ? 57 : (!0);
        }
        public bool 丛丕丅一一一丟业丌()
        {
            if(BannerWindowController.与丅与丒丅专丙丐丗() == 0)
            {
                    return false;
            }
            
            if(BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner == 0)
            {
                    return false;
            }
            
            if(BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner.type != this.丆丅不丛一丆丕丏丒())
            {
                    return false;
            }
            
            BannerWindow val_11 = BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner;
            if(val_11 != null)
            {
                    return val_11.IsShow;
            }
            
            return val_11.IsShow;
        }
        internal UnityEngine.Texture 丆丞不丅万世七一丝()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + this.业上丙丞丐丄丆丅七() + "_icon_big");
        }
        internal override UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "Clans/ClanBuildingGraphics/Icons/"("Clans/ClanBuildingGraphics/Icons/") + this.业上丙丞丐丄丆丅七() + "_icon");
        }
        internal UnityEngine.Texture 丏三丏丅三且且丄丗()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "Clans/ClanBuildingGraphics/Icons/"("Clans/ClanBuildingGraphics/Icons/") + this.业上丙丞丐丄丆丅七() + "_icon_empty");
        }
        internal UnityEngine.Texture 与丙丘丟七丘丄专丟()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "Clans/ClanBuildingGraphics/Patterns/"("Clans/ClanBuildingGraphics/Patterns/") + this.业上丙丞丐丄丆丅七() + "_pattern");
        }
        internal UnityEngine.Color 上一丂丟丑丕丕丘且()
        {
            return PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  this.业上丙丞丐丄丆丅七() + "_main_color");
        }
        internal UnityEngine.Color 丞丂丟下一业与丐丆()
        {
            return PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  this.业上丙丞丐丄丆丅七() + "_secondary_color");
        }
        internal UnityEngine.Color 丌丕上丟七不东一丗()
        {
            return PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  this.业上丙丞丐丄丆丅七() + "_extra_color");
        }
        internal string 丆丛丐上丄丅丄丒丁()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "ClanBuilding_Upgrade_Description_" + this.业上丙丞丐丄丆丅七());
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.丏丌丝丕丐七丈且丒(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
    
    }

}
