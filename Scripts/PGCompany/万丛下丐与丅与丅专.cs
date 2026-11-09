using UnityEngine;

namespace PGCompany
{
    internal sealed class 万丛下丐与丅与丅专 : 业丞且丞丁丅丏丏丐, 业世丑丑丞丑丂丘东, 七专丙与东丘丌丘丈
    {
        // Fields
        private System.Lazy<PGCompany.三丙业丆上丏三丈丌> 丛专三业万专丒丅丅;
        private string 不丗丗丗丆丙且万丛;
        private PlaceableItemSettings 丑丝一一三丟三三丞;
        
        // Properties
        internal PGCompany.三丙业丆上丏三丈丌 丏丂丌丈上丂丘上丌 { get; }
        internal PlaceableItemSettings 丛丐业七业下三丁丛 { get; }
        internal override ItemRarity 且丐丟专丛丗丏上丙 { get; }
        private PlaceableItemSettings 丈丛专丕下下丄丝丑 { get; }
        
        // Methods
        internal PGCompany.三丙业丆上丏三丈丌 世东丈丙丑下与三丝()
        {
            if(this.丛专三业万专丒丅丅 != null)
            {
                    return this.丛专三业万专丒丅丅.Value;
            }
            
            return this.丛专三业万专丒丅丅.Value;
        }
        internal PlaceableItemSettings 丈丏专三世七丒丘丑()
        {
            PGCompany.三丙业丆上丏三丈丌 val_1 = this.世东丈丙丑下与三丝();
            if(val_1 != null)
            {
                    return val_1.丈丏专三世七丒丘丑();
            }
            
            return val_1.丈丏专三世七丒丘丑();
        }
        internal override ItemRarity 七东与丄丕丁丛世三()
        {
            PlaceableItemSettings val_1 = this.丈丏专三世七丒丘丑();
            if(val_1 != null)
            {
                    return val_1.ItemRarity;
            }
            
            return val_1.ItemRarity;
        }
        public 万丛下丐与丅与丅专(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.不丗丗丗丆丙且万丛 = PGCompany.丌丂丐丕丑丐丅世丄.世丏丘万丑七专业丂(下丄三丂专丈下七丆:  丈丄不七三万丄丁不.业上丙丞丐丄丆丅七());
            this.丛专三业万专丒丅丅 = new System.Lazy<PGCompany.三丙业丆上丏三丈丌>(valueFactory:  new System.Func<PGCompany.三丙业丆上丏三丈丌>(object:  this, method:  PGCompany.三丙业丆上丏三丈丌 PGCompany.万丛下丐与丅与丅专::丕丁七丛丙与丘专下()));
        }
        internal override PGCompany.丐三丛丑丛丟七丕丛 丝丆丂丆不丟丌丕丝()
        {
            PGCompany.世东三上七丂丌下丑 val_1 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.一丌世丑丄东丞丘三<PGCompany.三丙业丆上丏三丈丌>(丁丅丈丌丟世丗丗丟:  226, 丞丅上丏丂且下丅与:  this.不丗丗丗丆丙且万丛);
            }
            
            return val_1.一丌世丑丄东丞丘三<PGCompany.三丙业丆上丏三丈丌>(丁丅丈丌丟世丗丗丟:  226, 丞丅上丏丂且下丅与:  this.不丗丗丗丆丙且万丛);
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            if(this.丈丏专三世七丒丘丑() == null)
            {
                    return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/unknown_item");
            }
            
            PlaceableItemSettings val_2 = this.丈丏专三世七丒丘丑();
            this = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + val_2.iconName);
            if(this != 0)
            {
                    return (UnityEngine.Texture)this;
            }
            
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/unknown_item");
        }
        internal override string 七丝七丈丆东三丞丞()
        {
            var val_3;
            string val_4;
            val_3 = this;
            if(this.丈丏专三世七丒丘丑() != null)
            {
                    val_3 = this.丈丏专三世七丒丘丑();
                val_4 = val_2.nameLocalizationKey;
                return (string)val_4;
            }
            
            val_4 = "Key_8778";
            return (string)val_4;
        }
        internal override string 七业丑不七丐业丟丂()
        {
            string val_1 = this.七业丑不七丐业丟丂();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) == true)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8778");
            }
            
            if((val_1.StartsWith(value:  "Key_")) == false)
            {
                    return val_1;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8778");
        }
        internal override string 专专三世丘丙丗丂丝()
        {
            string val_1 = this.专专三世丘丙丗丂丝();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) == true)
            {
                    return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_8778");
            }
            
            if((val_1.StartsWith(value:  "Key_")) == false)
            {
                    return val_1;
            }
            
            return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  "Key_8778");
        }
        internal override string 东且丏丆万与东丙万()
        {
            string val_6;
            var val_7;
            val_6 = this;
            if(this.丈丏专三世七丒丘丑() != null)
            {
                    PlaceableItemSettings val_2 = this.丈丏专三世七丒丘丑();
                val_6 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_2.descriptionLocalizationKey);
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != true)
            {
                    if((val_6.StartsWith(value:  "Key_")) == false)
            {
                    return val_6;
            }
            
            }
            
                val_7 = null;
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8779");
            }
            
            val_7 = null;
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8779");
        }
        public int 丁丕丁三丁丗不三丟()
        {
            丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_2 == null)
            {
                    return (int)val_2;
            }
            
            PGCompany.Clans.业丟业世世七丈三丄 val_5 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丐丌与丏丂东业业上();
            if(val_5 != null)
            {
                    return val_5.一丞万丂丐专丛丟上(丟丘丙不丑一丁丙丗:  this.丑丐丙丄丅世世丑丒());
            }
            
            return val_5.一丞万丂丐专丛丟上(丟丘丙不丑一丁丙丗:  this.丑丐丙丄丅世世丑丒());
        }
        public int 万丙东丙丐丕专丈丕()
        {
            if(this.丈丏专三世七丒丘丑().IsUpgradable == false)
            {
                    return 1;
            }
            
            PlaceableItemSettings val_3 = this.丈丏专三世七丒丘丑();
            if(val_3 != null)
            {
                    return val_3.MaxUpgrade;
            }
            
            return val_3.MaxUpgrade;
        }
        public int 丏丈丁专专丘丒丂丂()
        {
            return this.丈丏专三世七丒丘丑().东上丆丄丘丙七丞丙(丞丌东丟且丒丐丑丂:  this.丁丕丁三丁丗不三丟() + 1);
        }
        public int 且丆丟业丞丕丑上且()
        {
            return UnityEngine.Mathf.Max(a:  this.丗不丞三丄丞下丏且() - (this.且七万业丄丌丕丏三(丞丌东丟且丒丐丑丂:  this.丁丕丁三丁丗不三丟())), b:  0);
        }
        internal int 丟不一丌丘万丛东业()
        {
            return System.Math.Max(val1:  this.丏丈丁专专丘丒丂丂() - this.且丆丟业丞丕丑上且(), val2:  0);
        }
        internal int 专专丛丞丌丞丒丁丟()
        {
            int val_1 = this.且丆丟业丞丕丑上且();
            val_1 = this - val_1;
            return (int)val_1;
        }
        internal override int 丁丝丞与丟与丟丌三()
        {
            return this.且七万业丄丌丕丏三(丞丌东丟且丒丐丑丂:  this.万丙东丙丐丕专丈丕());
        }
        internal int 且七万业丄丌丕丏三(int 丞丌东丟且丒丐丑丂)
        {
            var val_3 = 0;
            if((丞丌东丟且丒丐丑丂 & 2147483648) != 0)
            {
                    return (int)val_3;
            }
            
            var val_3 = 0;
            do
            {
                val_3 = val_3 + 1;
                val_3 = (this.丈丏专三世七丒丘丑().东上丆丄丘丙七丞丙(丞丌东丟且丒丐丑丂:  0)) + val_3;
            }
            while(val_3 <= 丞丌东丟且丒丐丑丂);
            
            return (int)val_3;
        }
        internal int 丟丝业世丞三世丛丑(int 丛丛丆丛丏丟业万上)
        {
            丛丛丆丛丏丟业万上 = this.丗不丞三丄丞下丏且() + 丛丛丆丛丏丟业万上;
            return 丄丈业一下万且丂丕.东专丁丝与丆丗丄丈(与不丕丆丈不丙丟丛:  this.丈丏专三世七丒丘丑(), 东上业丐丄专七丑业:  丛丛丆丛丏丟业万上);
        }
        internal bool 丌丐专专与丂丄丗丛()
        {
            return (bool)(this.丁丕丁三丁丗不三丟() >= this.万丙东丙丐丕专丈丕()) ? 1 : 0;
        }
        internal int 丗不丞三丄丞下丏且()
        {
            var val_6;
            var val_7;
            val_6 = this;
            val_7 = val_6;
            if(this == null)
            {
                    return (int)val_3.丂丁丏一丙丛业且丌();
            }
            
            val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.三丙业丆上丏三丈丌 val_3 = val_6.上丟丘下世七与丁世<PGCompany.三丙业丆上丏三丈丌>(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = false});
            if(val_3 == null)
            {
                    return (int)val_3.丂丁丏一丙丛业且丌();
            }
            
            return (int)val_3.丂丁丏一丙丛业且丌();
        }
        internal override 丈丞丕丘丕丗与上一 下丐丙七丑万且丕不()
        {
            PlaceableItemSettings val_1 = this.丈丏专三世七丒丘丑();
            if(val_1 != null)
            {
                    return val_1.PurchasePrice;
            }
            
            return val_1.PurchasePrice;
        }
        internal override string 丟七万东万七丙丘丌()
        {
            int val_7;
            string val_8;
            var val_9;
            string val_10;
            var val_11;
            string val_12;
            val_7 = System.String.alignConst;
            PlaceableItemSettings val_1 = this.丈丏专三世七丒丘丑();
            val_8 = val_1.supercategory;
            val_9 = null;
            val_9 = null;
            if((System.String.op_Equality(a:  val_8, b:  PGCompany.丕万丞且丄丌丛一丒.丗三与丞丝丞上业丄)) != false)
            {
                    val_10 = "Key_8448";
            }
            else
            {
                    PlaceableItemSettings val_3 = this.丈丏专三世七丒丘丑();
                val_11 = null;
                val_8 = val_3.supercategory;
                val_11 = null;
                val_12 = PGCompany.丕万丞且丄丌丛一丒.丒丝丈丐与七且三丛;
                if((System.String.op_Equality(a:  val_8, b:  val_12)) == false)
            {
                    return val_7 + " / "(" / ") + 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this));
            }
            
                val_10 = "Key_8449";
            }
            
            val_12 = 0;
            val_7 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_10);
            return val_7 + " / "(" / ") + 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this));
        }
        private PlaceableItemSettings 丛丐业三丏丏丕丘丏()
        {
            if(this.丑丝一一三丟三三丞 != null)
            {
                    return val_2;
            }
            
            PlaceableItemSettings val_2 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞世不丒下上上丝丑:  this.业东丅东丌上丗丑不());
            this.丑丝一一三丟三三丞 = val_2;
            return val_2;
        }
        internal override string 丐丞丐丝下上上丐丂()
        {
            var val_5;
            string val_6;
            var val_7;
            PlaceableItemSettings val_1 = this.丈丏专三世七丒丘丑();
            val_5 = null;
            val_5 = null;
            if((System.String.op_Equality(a:  val_1.supercategory, b:  PGCompany.丕万丞且丄丌丛一丒.丗三与丞丝丞上业丄)) != false)
            {
                    val_6 = "Key_8115";
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6 = "Key_8114");
            }
            
            PlaceableItemSettings val_3 = this.丈丏专三世七丒丘丑();
            val_7 = null;
            val_7 = null;
            if((System.String.op_Equality(a:  val_3.supercategory, b:  PGCompany.丕万丞且丄丌丛一丒.丒丝丈丐与七且三丛)) == false)
            {
                    return this.丐丞丐丝下上上丐丂();
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6);
        }
        internal override bool 丞丟丑丆丁丟丁丒万()
        {
            PlaceableItemSettings val_1 = this.丈丏专三世七丒丘丑();
            if(val_1 == null)
            {
                    return (bool)val_1;
            }
            
            return 丄丈业一下万且丂丕.丞丟丑丆丁丟丁丒万(丆专且丕专丗与一丏:  this.业东丅东丌上丗丑不());
        }
        internal bool 上万丞丌与丆丝丂万()
        {
            丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_2 == null)
            {
                    return (bool)val_2;
            }
            
            return val_2.丌下丑丆东丈东丛丗(下丅丙一丂丗丅丝七:  this);
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)new PGCompany.万丛下丐与丅与丅专(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
        }
        private PGCompany.三丙业丆上丏三丈丌 丕丁七丛丙与丘专下()
        {
            if(this == null)
            {
                    return (PGCompany.三丙业丆上丏三丈丌)this;
            }
            
            if(null == null)
            {
                    return (PGCompany.三丙业丆上丏三丈丌)this;
            }
            
            this = 0;
            return (PGCompany.三丙业丆上丏三丈丌)this;
        }
    
    }

}
