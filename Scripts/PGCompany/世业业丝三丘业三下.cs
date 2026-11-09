using UnityEngine;

namespace PGCompany
{
    internal sealed class 世业业丝三丘业三下 : 丗丟丄丈东丝丕丄世, 七专丙与东丘丌丘丈
    {
        // Fields
        private CategoryNames 专丄丌且一丕万与丛;
        private 丕丈丏丝丗下丟丅丂 丏万不丁丝不丆且丝;
        
        // Properties
        internal int 丐业丌且万丐丁丟丝 { get; }
        internal int 世专丄且不丌上丘丐 { get; }
        internal override ItemRarity 且丐丟专丛丗丏上丙 { get; }
        internal int 丂丝丌丙丞专上七丕 { get; }
        internal int 业丂上丘业丂且丏丗 { get; }
        internal override CategoryNames 七丌丌丏丗东丕且丅 { get; }
        internal 丕丈丏丝丗下丟丅丂 丁丏专且丙下丒丕不 { get; }
        
        // Methods
        internal int 七世与丝丘丝丅丁丙()
        {
            return UnityEngine.Mathf.Clamp(value:  Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒().三三三东丑丁且与万(丞世不丒下上上丝丑:  this.业东丅东丌上丗丑不()), min:  0, max:  this.万与丁丙丞业专丞下());
        }
        internal int 万与丁丙丞业专丞下()
        {
            return BalanceController.丈丅三丙东丕东下丐(丞世不丒下上上丝丑:  this.业东丅东丌上丗丑不());
        }
        internal override ItemRarity 七东与丄丕丁丛世三()
        {
            return BalanceController.丘丛丄业丒一丝丆东(丞世不丒下上上丝丑:  this.丑丐丙丄丅世世丑丒().业东丅东丌上丗丑不());
        }
        internal int 世丘丅一丏丆与业丗()
        {
            if(this.七世与丝丘丝丅丁丙() > 0)
            {
                    return this.七世与丝丘丝丅丁丙();
            }
            
            丕丈丏丝丗下丟丅丂 val_2 = this.丙丕丞且丕不丘丙丑();
            if(val_2 != null)
            {
                    return val_2.专丂丏世且丗丏丌丝();
            }
            
            return val_2.专丂丏世且丗丏丌丝();
        }
        internal int 一丏丑丅丟世丗丈丒()
        {
            return BalanceController.丂丛且丑丞丘丅不丅(丞世不丒下上上丝丑:  this.业东丅东丌上丗丑不(), 丂丄丆丁丘丝丞丐不:  this.世丘丅一丏丆与业丗());
        }
        internal override CategoryNames 丒万丕七专不丏丞丌()
        {
            CategoryNames val_3 = this.专丄丌且一丕万与丛;
            if(val_3 != 9990000)
            {
                    return (CategoryNames)val_2;
            }
            
            val_3 = this.业上丙丞丐丄丆丅七();
            int val_2 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_3);
            this.专丄丌且一丕万与丛 = val_2;
            return (CategoryNames)val_2;
        }
        internal 丕丈丏丝丗下丟丅丂 丙丕丞且丕不丘丙丑()
        {
            丕丈丏丝丗下丟丅丂 val_5 = this.丏万不丁丝不丆且丝;
            if(val_5 != null)
            {
                    return val_5;
            }
            
            丕丈丏丝丗下丟丅丂 val_2 = 丁下万丟且丟丛下业.丛丝与一丕丆丌丟丏(丗丑丐丕丟丝且下丕:  this.业上丙丞丐丄丆丅七());
            this.丏万不丁丝不丆且丝 = val_2;
            if(val_2 != null)
            {
                    return val_5;
            }
            
            丆丟丟三丗东一丆三.丅丟丝丏七业下丟丗(丕丗丘丑丛与丑业丒:  "In GadgetsInfo not info by gadget: "("In GadgetsInfo not info by gadget: ") + this.业上丙丞丐丄丆丅七() + " !!!"(" !!!"));
            val_5 = this.丏万不丁丝不丆且丝;
            return val_5;
        }
        public 世业业丝三丘业三下(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            this.专丄丌且一丕万与丛 = 9990000;
        }
        internal override string 七丝七丈丆东三丞丞()
        {
            int val_3;
            丕丈丏丝丗下丟丅丂 val_1 = this.丙丕丞且丕不丘丙丑();
            if(val_1 != null)
            {
                    if(val_1.丛丈丅丞丏丅丛丛丐() != null)
            {
                    return (string)val_3;
            }
            
            }
            
            val_3 = System.String.alignConst;
            return (string)val_3;
        }
        internal override string 东且丏丆万与东丙万()
        {
            int val_3;
            丕丈丏丝丗下丟丅丂 val_1 = this.丙丕丞且丕不丘丙丑();
            if(val_1 != null)
            {
                    val_3 = val_1.丄东且丘丄丑下丑东();
                if(val_3 != null)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3 = System.String.alignConst);
            }
            
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_3);
        }
        internal override UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            return 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  this, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        }
        internal override string 丟七万东万七丙丘丌()
        {
            null = null;
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.丏丁丐下丐丌丂丆万.Item[this])(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  上丑三丁丄丛丁万丑.丏丁丐下丐丌丂丆万.Item[this])) + " / "(" / ") + 丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this)(丏丄丑上丛不丈且万.七不丝丝一专丗丕上(丁专业丛三丛一丁丒:  this));
        }
        internal System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂> 世丙万丞上与一丌丅()
        {
            var val_6;
            System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂> val_1 = new System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂>();
            List.Enumerator<T> val_4 = this.丙丕丞且丕不丘丙丑().丘一一丆业丂丘丒世().GetEnumerator();
            label_27:
            if(((-519240336) & 1) == 0)
            {
                goto label_3;
            }
            
            int val_7 = val_6.丙东专丂世丈丏丁丂();
            if(val_7 > 3)
            {
                goto label_4;
            }
            
            if(val_7 == 2)
            {
                goto label_5;
            }
            
            if(val_7 != 3)
            {
                goto label_27;
            }
            
            new PGCompany.丗丒下万与下丂万丂() = new PGCompany.丗丒下万与下丂万丂(丒与丏丛且万丘业丆:  6, 丙业与丙丗丝不丈东:  UnityEngine.Mathf.RoundToInt(f:  this.丙丕丞且丕不丘丙丑().丌丛丟丙丘丝丂一不()));
            val_1.Add(item:  new PGCompany.丗丒下万与下丂万丂());
            goto label_27;
            label_4:
            if(val_7 == 4)
            {
                goto label_12;
            }
            
            if(val_7 != 16)
            {
                goto label_27;
            }
            
            new PGCompany.丗丒下万与下丂万丂() = new PGCompany.丗丒下万与下丂万丂(丒与丏丛且万丘业丆:  8, 丙业与丙丗丝不丈东:  UnityEngine.Mathf.RoundToInt(f:  (float)this.一丏丑丅丟世丗丈丒()));
            val_1.Add(item:  new PGCompany.丗丒下万与下丂万丂());
            goto label_27;
            label_5:
            new PGCompany.丗丒下万与下丂万丂() = new PGCompany.丗丒下万与下丂万丂(丒与丏丛且万丘业丆:  7, 丙业与丙丗丝不丈东:  UnityEngine.Mathf.RoundToInt(f:  this.丙丕丞且丕不丘丙丑().丅上丟丙丏丗丕丟专()));
            val_1.Add(item:  new PGCompany.丗丒下万与下丂万丂());
            goto label_27;
            label_12:
            new PGCompany.丗丒下万与下丂万丂() = new PGCompany.丗丒下万与下丂万丂(丒与丏丛且万丘业丆:  5, 丙业与丙丗丝不丈东:  UnityEngine.Mathf.RoundToInt(f:  this.丙丕丞且丕不丘丙丑().丙丈丗丌丘三丄业且()));
            val_1.Add(item:  new PGCompany.丗丒下万与下丂万丂());
            goto label_27;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public int 丁丕丁三丁丗不三丟()
        {
            return this.七世与丝丘丝丅丁丙();
        }
        public int 万丙东丙丐丕专丈丕()
        {
            return this.万与丁丙丞业专丞下();
        }
        internal int 三三三东丑丁且与万()
        {
            var val_11;
            var val_12;
            val_11 = this;
            丕丈丏丝丗下丟丅丂 val_8 = 0;
            val_12 = Progress.七七世万专丕丁上业.丆丁三三丟东丐丁丒();
            if((val_12.三三三东丑丁且与万(丞世不丒下上上丝丑:  this.丑丐丙丄丅世世丑丒().业东丅东丌上丗丑不())) != 0)
            {
                    return (int)val_12.专丂丏世且丗丏丌丝();
            }
            
            bool val_9 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().TryGetValue(key:  this.丑丐丙丄丅世世丑丒().业上丙丞丐丄丆丅七(), value: out  val_8);
            val_11 = val_8;
            val_12 = val_11;
            return (int)val_12.专丂丏世且丗丏丌丝();
        }
        internal int 且且世专丏丁下丙丄()
        {
            return BalanceController.世丅丄丗丄丌三世且(丞世不丒下上上丝丑:  this.业东丅东丌上丗丑不());
        }
        internal PGCompany.三东丏不丗世丅丌丄 丂一丆丂且三丟丗一()
        {
            return Rilisoft.Offers.丁且丕专万丈丒丏丗.丙丏丗世丒丒丙丁丙(万丐丏丐丒万不丟三:  BalanceController.世下下丙丑与丄丌丂(丞世不丒下上上丝丑:  this.业东丅东丌上丗丑不()));
        }
        internal PGCompany.三东丏不丗世丅丌丄 不一专丒七丝丆丑业(int 丈丘丝一丗下丈丐不, bool 丐丏上业丈丂与万丞)
        {
            丐丏上业丈丂与万丞 = 丐丏上业丈丂与万丞;
            return Rilisoft.Offers.丁且丕专万丈丒丏丗.丙丏丗世丒丒丙丁丙(万丐丏丐丒万不丟三:  BalanceController.丏丈丐丏丈一且与与(丞世不丒下上上丝丑:  this.业东丅东丌上丗丑不(), 丈丘丝一丗下丈丐不:  丈丘丝一丗下丈丐不, 丐丏上业丈丂与万丞:  丐丏上业丈丂与万丞));
        }
        protected override PGCompany.丗丟丄丈东丝丕丄世 一丗丌专下丒丆三不()
        {
            PGCompany.世业业丝三丘业三下 val_2 = null;
            .专丄丌且一丕万与丛 = 9990000;
            val_2 = new PGCompany.世业业丝三丘业三下(丈丄不七三万丄丁不:  this.丑丐丙丄丅世世丑丒());
            return (PGCompany.丗丟丄丈东丝丕丄世)val_2;
        }
    
    }

}
