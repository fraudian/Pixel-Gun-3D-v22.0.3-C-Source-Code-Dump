using UnityEngine;

namespace PGCompany
{
    internal abstract class 丌丐下丌丘下丝丞业 : 丗丟丄丈东丝丕丄世
    {
        // Fields
        private Rilisoft.丅丌丌丐丘丕丟丏丝 丏专与丟丛丈丏业丂;
        
        // Properties
        internal override int 丒专下与丑丁丆丟业 { get; }
        internal long 丘丝万丞丛丄下专丟 { get; set; }
        internal int 丌与丁不下丅丆丘丞 { get; }
        
        // Methods
        internal override int 丂丁丏一丙丛业且丌()
        {
            var val_5;
            var val_6;
            val_5 = this;
            if(PixelTime.丝丗专上三不丄丑丑() >= 1)
            {
                    val_5 = this.丏专与丟丛丈丏业丂.世三丞丅丑丌丈丈一();
                var val_4 = (val_5 > PixelTime.丝丗专上三不丄丑丑()) ? 1 : 0;
                return (int)val_6;
            }
            
            val_6 = 0;
            return (int)val_6;
        }
        internal long 丕不丐专丒专下下丗()
        {
            return this.丏专与丟丛丈丏业丂.世三丞丅丑丌丈丈一();
        }
        private void 丒上七丐三业丅丈一(long 丙业与丙丗丝不丈东)
        {
            Rilisoft.丅丌丌丐丘丕丟丏丝 val_1 = Rilisoft.丅丌丌丐丘丕丟丏丝.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this.丏专与丟丛丈丏业丂 = val_1;
            mem[1152921555617043160] = val_1.丑丒丄下丁丐专丄丞;
        }
        internal int 丙世丑丅丒丑业与不()
        {
            var val_6;
            var val_7;
            val_6 = this;
            if(PixelTime.丝丗专上三不丄丑丑() >= 1)
            {
                    val_6 = this.丏专与丟丛丈丏业丂.世三丞丅丑丌丈丈一();
                long val_5 = System.Math.Max(val1:  0, val2:  val_6 - PixelTime.丝丗专上三不丄丑丑());
                return (int)val_7;
            }
            
            val_7 = 0;
            return (int)val_7;
        }
        protected 丌丐下丌丘下丝丞业(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不)
        {
            Rilisoft.丅丌丌丐丘丕丟丏丝 val_2 = Rilisoft.丅丌丌丐丘丕丟丏丝.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丈丄不七三万丄丁不.丕不丐专丒专下下丗());
            this.丏专与丟丛丈丏业丂 = val_2;
            mem[1152921555617271256] = val_2.丑丒丄下丁丐专丄丞;
        }
        public override string ToString()
        {
            System.DateTime val_5 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  this.丏专与丟丛丈丏业丂.世三丞丅丑丌丈丈一());
            return (string)System.String.Format(format:  "{0} s={1} e={2}", arg0:  this.ToString(), arg1:  this.丑丐丙丄丅世世丑丒().丙丑丁专一专世万丕(), arg2:  val_5);
        }
        internal override PGCompany.丗丟丄丈东丝丕丄世 专丒业丘七丞不丗丛(int 专丌万丑三丙丕丙丝)
        {
            this.Clone() = 0;
            Rilisoft.丅丌丌丐丘丕丟丏丝 val_4 = Rilisoft.丅丌丌丐丘丕丟丏丝.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  (long)专丌万丑三丙丕丙丝);
            mem[80] = val_4.七丄不丐丗三丝丑一;
            mem[88] = val_4.丑丒丄下丁丐专丄丞;
            return (PGCompany.丗丟丄丈东丝丕丄世)this.Clone();
        }
    
    }

}
