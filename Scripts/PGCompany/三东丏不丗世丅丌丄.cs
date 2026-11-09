using UnityEngine;

namespace PGCompany
{
    internal class 三东丏不丗世丅丌丄 : 丗丅三丈丙丝上丞七, IEquatable<PGCompany.三东丏不丗世丅丌丄>, ICloneable
    {
        // Fields
        private Rilisoft.丝丑丂丛万丐丈丘且 丑丁丄丟丟丁且东七;
        private PGCompany.丙万丙下三下丄丌丄 <丛万丈丌专丆万东丒>k__BackingField;
        private System.Nullable<int> 丅丘丑不专丆丐丟丞;
        private Rilisoft.丝丑丂丛万丐丈丘且 丒丙七专丒东业丘世;
        private Rilisoft.丝丑丂丛万丐丈丘且 世丆不下一专专丟丆;
        private Rilisoft.丅丌丌丐丘丕丟丏丝 丏专与丟丛丈丏业丂;
        internal int 不丌七丆丏丂丐万丂;
        
        // Properties
        internal int 丐丒且丝丛丁丕丟丅 { get; set; }
        internal Rilisoft.OfferItemType 丒三丝一上丙专丗丒 { get; }
        internal string 下丄丈不与世丐业专 { get; }
        internal PGCompany.丙万丙下三下丄丌丄 丟一一丙一上丝丅丅 { get; set; }
        internal int 不丗丝丘丄三丗丝上 { get; }
        internal int 丒专下与丑丁丆丟业 { get; set; }
        internal int 丂三一不丒丞丘丈且 { get; set; }
        internal long 丘丝万丞丛丄下专丟 { get; set; }
        internal bool 丑丕丈丈不不且丑且 { get; }
        
        // Methods
        internal static PGCompany.三东丏不丗世丅丌丄 东丝七业丄丑丒世七(int 丞世不丒下上上丝丑)
        {
            return (PGCompany.三东丏不丗世丅丌丄)new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
        }
        internal static PGCompany.三东丏不丗世丅丌丄 东丝七业丄丑丒世七(PGCompany.三丌上丁一丟丐丟丈 丞世不丒下上上丝丑)
        {
            return PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
        }
        internal static PGCompany.三东丏不丗世丅丌丄 东丝七业丄丑丒世七(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, string 丞丅上丏丂且下丅与)
        {
            return (PGCompany.三东丏不丗世丅丌丄)new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与);
        }
        internal static PGCompany.三东丏不丗世丅丌丄 东丝七业丄丑丒世七(PGCompany.三丌上丁一丟丐丟丈 丆专且丕专丗与一丏, int 丂丕丂丏专丂丄丕且)
        {
            return PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丆专且丕专丗与一丏, 丂丕丂丏专丂丄丕且:  丂丕丂丏专丂丄丕且);
        }
        internal static PGCompany.三东丏不丗世丅丌丄 东丝七业丄丑丒世七(int 丞世不丒下上上丝丑, int 丂丕丂丏专丂丄丕且)
        {
            PGCompany.三东丏不丗世丅丌丄 val_1 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
            bool val_2 = PGCompany.万丞丘与丕丞下万丌.与世丝上东丗不东丕(丈丄不七三万丄丁不:  val_1);
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(val_2 == false)
            {
                goto label_4;
            }
            
            label_6:
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丂丕丂丏专丂丄丕且);
            .世丆不下一专专丟丆 = val_3;
            mem[1152921555661255688] = val_3.上万三丆专丏丒丗业;
            return val_1;
            label_3:
            if(val_2 == true)
            {
                goto label_6;
            }
            
            label_4:
            int val_4 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            .丒丙七专丒东业丘世 = 0;
            mem[1152921555661255672] = 0;
            return val_1;
        }
        internal static PGCompany.三东丏不丗世丅丌丄 东丝七业丄丑丒世七(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, string 丞丅上丏丂且下丅与, int 丂丕丂丏专丂丄丕且)
        {
            PGCompany.三东丏不丗世丅丌丄 val_1 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与);
            bool val_2 = PGCompany.万丞丘与丕丞下万丌.与世丝上东丗不东丕(丈丄不七三万丄丁不:  val_1);
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(val_2 == false)
            {
                goto label_4;
            }
            
            label_6:
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丂丕丂丏专丂丄丕且);
            .世丆不下一专专丟丆 = val_3;
            mem[1152921555661392264] = val_3.上万三丆专丏丒丗业;
            return val_1;
            label_3:
            if(val_2 == true)
            {
                goto label_6;
            }
            
            label_4:
            int val_4 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            .丒丙七专丒东业丘世 = 0;
            mem[1152921555661392248] = 0;
            return val_1;
        }
        internal int 业东丅东丌上丗丑不()
        {
        
        }
        internal void 东三七丟一不丑东丕(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this.丑丁丄丟丟丁且东七 = val_1;
            mem[1152921555661588312] = val_1.上万三丆专丏丒丗业;
        }
        internal Rilisoft.OfferItemType 不业丙丒丂丞下丆丙()
        {
            if((this.<丛万丈丌专丆万东丒>k__BackingField) == null)
            {
                    return (Rilisoft.OfferItemType)this.<丛万丈丌专丆万东丒>k__BackingField;
            }
            
            return this.<丛万丈丌专丆万东丒>k__BackingField.不业丙丒丂丞下丆丙();
        }
        internal string 业上丙丞丐丄丆丅七()
        {
            if((this.<丛万丈丌专丆万东丒>k__BackingField) == null)
            {
                    return (string)System.String.alignConst;
            }
            
            return this.<丛万丈丌专丆万东丒>k__BackingField.业上丙丞丐丄丆丅七();
        }
        internal PGCompany.丙万丙下三下丄丌丄 丐丑丞丑丟丏丆丑丈()
        {
            return (PGCompany.丙万丙下三下丄丌丄)this.<丛万丈丌专丆万东丒>k__BackingField;
        }
        private void 上不与世丁丙专丑专(PGCompany.丙万丙下三下丄丌丄 丙业与丙丗丝不丈东)
        {
            this.<丛万丈丌专丆万东丒>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal int 与丄丁丆丂丒丅丆与()
        {
            if((this.丅丘丑不专丆丐丟丞 & 1) != 0)
            {
                    return (int)this.丅丘丑不专丆丐丟丞;
            }
            
            if((this.<丛万丈丌专丆万东丒>k__BackingField) != null)
            {
                    Rilisoft.OfferItemType val_1 = this.<丛万丈丌专丆万东丒>k__BackingField.不业丙丒丂丞下丆丙();
            }
            
            mem2[0] = 0;
            return (int)this.丅丘丑不专丆丐丟丞;
        }
        internal 三东丏不丗世丅丌丄(PGCompany.三丌上丁一丟丐丟丈 丆专且丕专丗与一丏)
        {
        
        }
        internal 三东丏不丗世丅丌丄(int 丞世不丒下上上丝丑)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丞世不丒下上上丝丑);
            this.丑丁丄丟丟丁且东七 = val_1;
            mem[1152921555662437848] = val_1.上万三丆专丏丒丗业;
            this.<丛万丈丌专丆万东丒>k__BackingField = PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丙丏丘业丌丒上东丈(丞世不丒下上上丝丑:  丞世不丒下上上丝丑);
        }
        internal 三东丏不丗世丅丌丄(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, string 丞丅上丏丂且下丅与)
        {
            Rilisoft.OfferItemType val_8;
            val_1 = new System.Object();
            this.<丛万丈丌专丆万东丒>k__BackingField = new PGCompany.丙万丙下三下丄丌丄(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丞一丁业丄一一业且:  string val_1 = 丞丅上丏丂且下丅与);
            if((this.<丛万丈丌专丆万东丒>k__BackingField) != null)
            {
                    val_8 = this.<丛万丈丌专丆万东丒>k__BackingField.不业丙丒丂丞下丆丙();
            }
            else
            {
                    val_8 = 0;
            }
            
            Rilisoft.丝丑丂丛万丐丈丘且 val_7 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  val_8, 丞一丁业丄一一业且:  this.业上丙丞丐丄丆丅七()));
            this.丑丁丄丟丟丁且东七 = val_7;
            mem[1152921555662586712] = val_7.上万三丆专丏丒丗业;
        }
        internal 三东丏不丗世丅丌丄(Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟, string 丞丅上丏丂且下丅与, int 丞世不丒下上上丝丑)
        {
            val_1 = new System.Object();
            this.<丛万丈丌专丆万东丒>k__BackingField = new PGCompany.丙万丙下三下丄丌丄(丁丅丈丌丟世丗丗丟:  丁丅丈丌丟世丗丗丟, 丞一丁业丄一一业且:  string val_1 = 丞丅上丏丂且下丅与);
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丞世不丒下上上丝丑);
            this.丑丁丄丟丟丁且东七 = val_3;
            mem[1152921555662739672] = val_3.上万三丆专丏丒丗业;
        }
        internal int 丂丁丏一丙丛业且丌()
        {
        
        }
        internal void 业与一丏丟丌万丐丛(int 丙业与丙丗丝不丈东)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.丒丙七专丒东业丘世 = 0;
            mem[1152921555662975992] = 0;
        }
        internal int 丙丑丁专一专世万丕()
        {
        
        }
        internal void 丅丁业不且上业丘且(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this.世丆不下一专专丟丆 = val_1;
            mem[1152921555663200008] = val_1.上万三丆专丏丒丗业;
        }
        internal long 丕不丐专丒专下下丗()
        {
            return this.丏专与丟丛丈丏业丂.世三丞丅丑丌丈丈一();
        }
        internal void 丒上七丐三业丅丈一(long 丙业与丙丗丝不丈东)
        {
            Rilisoft.丅丌丌丐丘丕丟丏丝 val_1 = Rilisoft.丅丌丌丐丘丕丟丏丝.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this.丏专与丟丛丈丏业丂 = val_1;
            mem[1152921555663424024] = val_1.丑丒丄下丁丐专丄丞;
        }
        internal PGCompany.三东丏不丗世丅丌丄 丙丕丑丟丛丅业丝丙(int 下下丏一丙不丘丌丞)
        {
            int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            this.丒丙七专丒东业丘世 = 0;
            mem[1152921555663535992] = 0;
            return (PGCompany.三东丏不丗世丅丌丄)this;
        }
        public object Clone()
        {
            return this.与下不与丐丈丁丈万();
        }
        internal PGCompany.三东丏不丗世丅丌丄 与下不与丐丈丁丈万()
        {
            int val_2 = Rilisoft.丝丑丂丛万丐丈丘且.不丗下丈丏丒业业丑();
            .丒丙七专丒东业丘世 = 0;
            mem[1152921555663796088] = 0;
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  this.世丆不下一专专丟丆);
            .世丆不下一专专丟丆 = val_3;
            mem[1152921555663796104] = val_3.上万三丆专丏丒丗业;
            .不丌七丆丏丂丐万丂 = this.不丌七丆丏丂丐万丂;
            return (PGCompany.三东丏不丗世丅丌丄)new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  this.丑丁丄丟丟丁且东七);
        }
        internal bool 丕丐一丙专丛丒丑万()
        {
            var val_5;
            var val_6;
            val_5 = null;
            val_5 = null;
            if((this.丑丁丄丟丟丁且东七 != 丐丏七丈且丌丄三丏.丛七丞丂下丘丘丘东) && ((this.<丛万丈丌专丆万东丒>k__BackingField) != null))
            {
                    if((this.<丛万丈丌专丆万东丒>k__BackingField.不业丙丒丂丞下丆丙()) != 0)
            {
                    val_6 = (System.String.IsNullOrEmpty(value:  this.业上丙丞丐丄丆丅七())) ^ 1;
                return (bool)val_6 & 1;
            }
            
            }
            
            val_6 = 0;
            return (bool)val_6 & 1;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            var val_2 = 0;
            val_2 = val_2 & 1;
            return (bool)val_2;
        }
        public bool Equals(PGCompany.三东丏不丗世丅丌丄 丘丛丏丘丝七世七丅)
        {
            var val_2;
            if(丘丛丏丘丝七世七丅 == null)
            {
                goto label_3;
            }
            
            if(this == 丘丛丏丘丝七世七丅)
            {
                goto label_1;
            }
            
            if((this.丑丁丄丟丟丁且东七 == 丘丛丏丘丝七世七丅.丑丁丄丟丟丁且东七) && (this.丒丙七专丒东业丘世 == 丘丛丏丘丝七世七丅.丒丙七专丒东业丘世))
            {
                    var val_1 = (this.世丆不下一专专丟丆 == 丘丛丏丘丝七世七丅.世丆不下一专专丟丆) ? 1 : 0;
                return (bool)val_2;
            }
            
            label_3:
            val_2 = 0;
            return (bool)val_2;
            label_1:
            val_2 = 1;
            return (bool)val_2;
        }
        public override string ToString()
        {
            PGCompany.丙万丙下三下丄丌丄 val_7;
            object[] val_3 = new object[4];
            if(val_3 == null)
            {
                goto label_3;
            }
            
            if(this.丑丁丄丟丟丁且东七 != 0)
            {
                goto label_4;
            }
            
            goto label_7;
            label_3:
            if(this.丑丁丄丟丟丁且东七 == 0)
            {
                goto label_7;
            }
            
            label_4:
            label_7:
            val_3[0] = this.丑丁丄丟丟丁且东七;
            val_7 = this.<丛万丈丌专丆万东丒>k__BackingField;
            val_3[1] = val_7.不业丙丒丂丞下丆丙();
            val_3[2] = this.业上丙丞丐丄丆丅七();
            val_3[3] = ((PGCompany.万丞丘与丕丞下万丌.与世丝上东丗不东丕(丈丄不七三万丄丁不:  this)) != true) ? this.世丆不下一专专丟丆 : this.丒丙七专丒东业丘世;
            return (string)System.String.Format(format:  "[{0}]{1}:{2}:{3}", args:  val_3);
        }
        public static PGCompany.三东丏不丗世丅丌丄 丂东专丙丒丏且丛丁(string 丞丕丒专一下丙业上)
        {
            var val_6;
            Rilisoft.OfferItemType val_1 = 0;
            string val_2 = 0;
            val_6 = 0;
            if((Rilisoft.不丗上万丟丏不丄下.与丛丆专东丐一且丅(丞丕丒专一下丙业上:  丞丕丒专一下丙业上, 丁丅丈丌丟世丗丗丟: out  val_1, 丞丅上丏丂且下丅与: out  val_2, 丌丒丝东丌下丕丁丅: out  0)) == false)
            {
                    return (PGCompany.三东丏不丗世丅丌丄)PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  val_1, 丞丅上丏丂且下丅与:  val_2, 丂丕丂丏专丂丄丕且:  0);
            }
            
            return (PGCompany.三东丏不丗世丅丌丄)PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  val_1, 丞丅上丏丂且下丅与:  val_2, 丂丕丂丏专丂丄丕且:  0);
        }
    
    }

}
