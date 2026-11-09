using UnityEngine;

namespace PGCompany
{
    internal abstract class 丗丟丄丈东丝丕丄世 : 丗丅三丈丙丝上丞七, ICloneable
    {
        // Fields
        private string <上七东下丏不丕丐丑>k__BackingField;
        private Rilisoft.丝丑丂丛万丐丈丘且 丑丁丄丟丟丁且东七;
        private Rilisoft.OfferItemType <且丈丁专东丆丄丂与>k__BackingField;
        private PGCompany.三东丏不丗世丅丌丄 <东三丝丆丏丑不丐丈>k__BackingField;
        private ItemRarity <丑与丛与万丐专东与>k__BackingField;
        private Rilisoft.丝丑丂丛万丐丈丘且 万丙丝丘丑丕万业丟;
        
        // Properties
        internal string 下丄丈不与世丐业专 { get; set; }
        internal int 丐丒且丝丛丁丕丟丅 { get; set; }
        internal Rilisoft.OfferItemType 丒三丝一上丙专丗丒 { get; set; }
        internal PGCompany.三东丏不丗世丅丌丄 丕丈丏丑丌丂且万不 { get; set; }
        internal virtual ItemRarity 且丐丟专丛丗丏上丙 { get; set; }
        internal virtual CategoryNames 七丌丌丏丗东丕且丅 { get; }
        internal virtual int 丒专下与丑丁丆丟业 { get; set; }
        
        // Methods
        internal string 业上丙丞丐丄丆丅七()
        {
            return (string)this.<上七东下丏不丕丐丑>k__BackingField;
        }
        private void 丒丞东丈丁丄丑丅且(string 丙业与丙丗丝不丈东)
        {
            this.<上七东下丏不丕丐丑>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 业东丅东丌上丗丑不()
        {
        
        }
        private void 东三七丟一不丑东丕(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this.丑丁丄丟丟丁且东七 = val_1;
            mem[1152921555579704256] = val_1.上万三丆专丏丒丗业;
        }
        internal Rilisoft.OfferItemType 不业丙丒丂丞下丆丙()
        {
            return (Rilisoft.OfferItemType)this.<且丈丁专东丆丄丂与>k__BackingField;
        }
        private void 东丝丕专丒丏三三与(Rilisoft.OfferItemType 丙业与丙丗丝不丈东)
        {
            this.<且丈丁专东丆丄丂与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.三东丏不丗世丅丌丄 丑丐丙丄丅世世丑丒()
        {
            return (PGCompany.三东丏不丗世丅丌丄)this.<东三丝丆丏丑不丐丈>k__BackingField;
        }
        private void 丟世丛丌丏丙丒丏东(PGCompany.三东丏不丗世丅丌丄 丙业与丙丗丝不丈东)
        {
            this.<东三丝丆丏丑不丐丈>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal virtual ItemRarity 七东与丄丕丁丛世三()
        {
            return (ItemRarity)this.<丑与丛与万丐专东与>k__BackingField;
        }
        private void 一世下丐丝丞与上丅(ItemRarity 丙业与丙丗丝不丈东)
        {
            this.<丑与丛与万丐专东与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal virtual CategoryNames 丒万丕七专不丏丞丌()
        {
            return 9990000;
        }
        internal virtual string 丐丁丈丟丒丗丑丒丙()
        {
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this);
        }
        internal virtual string 丝七丟丈一丌东且一()
        {
            return (string)System.String.Format(format:  "CategoryName_{0}", arg0:  this);
        }
        internal virtual int 丂丁丏一丙丛业且丌()
        {
        
        }
        private void 业与一丏丟丌万丐丛(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this.万丙丝丘丑丕万业丟 = val_1;
            mem[1152921555581001944] = val_1.上万三丆专丏丒丗业;
        }
        internal 丗丟丄丈东丝丕丄世(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            if(丈丄不七三万丄丁不 != null)
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丈丄不七三万丄丁不.业东丅东丌上丗丑不());
                this.丑丁丄丟丟丁且东七 = val_2;
                mem[1152921555581138480] = val_2.上万三丆专丏丒丗业;
                this.<且丈丁专东丆丄丂与>k__BackingField = 丈丄不七三万丄丁不.不业丙丒丂丞下丆丙();
                this.<上七东下丏不丕丐丑>k__BackingField = 丈丄不七三万丄丁不.业上丙丞丐丄丆丅七();
            }
            else
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_6 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0.业东丅东丌上丗丑不());
                this.丑丁丄丟丟丁且东七 = val_6;
                mem[1152921555581138480] = val_6.上万三丆专丏丒丗业;
                this.<且丈丁专东丆丄丂与>k__BackingField = 0.不业丙丒丂丞下丆丙();
                this.<上七东下丏不丕丐丑>k__BackingField = 0.业上丙丞丐丄丆丅七();
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_10 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌());
            this.万丙丝丘丑丕万业丟 = val_10;
            mem[1152921555581138520] = val_10.上万三丆专丏丒丗业;
            this.<东三丝丆丏丑不丐丈>k__BackingField = 丈丄不七三万丄丁不.与下不与丐丈丁丈万();
        }
        internal virtual UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + this.<上七东下丏不丕丐丑>k__BackingField(this.<上七东下丏不丕丐丑>k__BackingField) + "_icon");
        }
        internal UnityEngine.Texture 丗丁丆丝丐丆丛与丕()
        {
            return 丏丄丑上丛不丈且万.丌一下丙丄不丄世丛(丆万一不丌且东丐丐:  this.<上七东下丏不丕丐丑>k__BackingField);
        }
        internal virtual UnityEngine.Texture 三丗一丄不丆不丏三()
        {
            return 0;
        }
        internal virtual string 七业丑不七丐业丟丂()
        {
            if((丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this)) == null)
            {
                    return "#" + this.<上七东下丏不丕丐丑>k__BackingField(this.<上七东下丏不丕丐丑>k__BackingField);
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this);
        }
        internal virtual string 专专三世丘丙丗丂丝()
        {
            if((System.String.IsNullOrEmpty(value:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  this))) == false)
            {
                    return 丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  this);
            }
            
            return (string)this.<上七东下丏不丕丐丑>k__BackingField;
        }
        internal virtual string 七丝七丈丆东三丞丞()
        {
            return (string)System.String.Format(format:  "{0}_Title_{1}", arg0:  this.<且丈丁专东丆丄丂与>k__BackingField, arg1:  this.<上七东下丏不丕丐丑>k__BackingField);
        }
        internal virtual string 东且丏丆万与东丙万()
        {
            return (string)I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  "{0}_Description_{1}", arg0:  this.<且丈丁专东丆丄丂与>k__BackingField, arg1:  this.<上七东下丏不丕丐丑>k__BackingField));
        }
        internal virtual string 丐丞丐丝下上上丐丂()
        {
            return (string)I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  "CategoryName_{0}", arg0:  this.<且丈丁专东丆丄丂与>k__BackingField));
        }
        internal virtual string 丟七万东万七丙丘丌()
        {
            return (string)System.String.alignConst;
        }
        internal virtual UnityEngine.Texture 丘丕且业丑丒下丆七()
        {
            return PGCompany.万丞丘与丕丞下万丌.丑东丐下专丞丕丘世(七丆丒与丗丌丄且丂:  this);
        }
        internal virtual 丈丞丕丘丕丗与上一 下丐丙七丑万且丕不()
        {
            return 0;
        }
        internal virtual UnityEngine.Color 丝一丙丝上丛三丄丈()
        {
            ItemRarity val_3;
            PGCompany.丗丟丄丈东丝丕丄世 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  this.丑丁丄丟丟丁且东七);
            if(val_2 != null)
            {
                    val_3 = val_2;
                return 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_3 = 0);
            }
            
            return 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_3);
        }
        internal virtual string 与一专丗丅且丟丛丞()
        {
            ItemRarity val_3;
            PGCompany.丗丟丄丈东丝丕丄世 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丞世不丒下上上丝丑:  this.丑丁丄丟丟丁且东七);
            if(val_2 != null)
            {
                    val_3 = val_2;
                return 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_3 = 0);
            }
            
            return 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  val_3);
        }
        internal virtual UnityEngine.Color 专且丈七丈丛丆东丈(int 且丐且与丟丞业丈丗 = 0)
        {
            return RarityColorEntry.丝一丙丝上丛三丄丈(丈下丑丆上丏丗丈专:  this, 且丐且与丟丞业丈丗:  且丐且与丟丞业丈丗);
        }
        internal virtual bool 丛七丈丄不丟下丑丈()
        {
            return false;
        }
        internal virtual bool 七丄与不丁丙丑丞不()
        {
            return true;
        }
        protected void 丗丈丌丛业丘丆不丑(ItemRarity 东东世丝业丝一丂丄)
        {
            this.<丑与丛与万丐专东与>k__BackingField = 东东世丝业丝一丂丄;
        }
        internal virtual bool 丞丟丑丆丁丟丁丒万()
        {
            return true;
        }
        protected abstract PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不(); // 0
        public object Clone()
        {
            goto typeof(PGCompany.丗丟丄丈东丝丕丄世).__il2cppRuntimeField_2C8;
        }
        internal virtual PGCompany.丗丟丄丈东丝丕丄世 专丒业丘七丞不丗丛(int 丌丒丝东丌下丕丁丅)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丌丒丝东丌下丕丁丅);
            mem[64] = val_3.七丄不丐丗三丝丑一;
            mem[68] = val_3.丑丒丄下丁丐专丄丞;
            mem[72] = val_3.上万三丆专丏丒丗业;
            return 0;
        }
    
    }

}
