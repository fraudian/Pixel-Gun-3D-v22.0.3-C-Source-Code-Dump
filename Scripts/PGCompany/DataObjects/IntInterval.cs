using UnityEngine;

namespace PGCompany.DataObjects
{
    [Serializable]
    internal class IntInterval : ICloneable
    {
        // Fields
        public const string DELIMER = "-";
        private Rilisoft.丝丑丂丛万丐丈丘且 _from;
        private Rilisoft.丝丑丂丛万丐丈丘且 _to;
        
        // Properties
        internal int From { get; set; }
        internal int To { get; set; }
        
        // Methods
        internal int get_From()
        {
        
        }
        internal void set_From(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._from = val_1;
            mem[1152921560557799528] = val_1.上万三丆专丏丒丗业;
        }
        internal int get_To()
        {
        
        }
        internal void set_To(int 丙业与丙丗丝不丈东)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            this._to = val_1;
            mem[1152921560558023544] = val_1.上万三丆专丏丒丗业;
        }
        internal IntInterval()
        {
        
        }
        internal IntInterval(int 丈丗与丞一上且上上, int 专丂丕丗丗东世丞下)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丈丗与丞一上且上上);
            this._from = val_1;
            mem[1152921560558247528] = val_1.上万三丆专丏丒丗业;
            Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  专丂丕丗丗东世丞下);
            this._to = val_2;
            mem[1152921560558247544] = val_2.上万三丆专丏丒丗业;
        }
        internal bool 上丗不丘上丘丕丟丞(int 下下丏一丙不丘丌丞)
        {
            var val_2;
            if(this._from <= 下下丏一丙不丘丌丞)
            {
                    return (bool)(this._to >= 下下丏一丙不丘丌丞) ? 1 : 0;
            }
            
            val_2 = 0;
            return (bool)(this._to >= 下下丏一丙不丘丌丞) ? 1 : 0;
        }
        internal bool 上丗不丘上丘丕丟丞(decimal 下下丏一丙不丘丌丞)
        {
            decimal val_1 = System.Decimal.op_Implicit(value:  this._from);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 下下丏一丙不丘丌丞.flags, hi = 下下丏一丙不丘丌丞.hi, lo = 下下丏一丙不丘丌丞.lo, mid = 下下丏一丙不丘丌丞.mid}, d2:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid})) == false)
            {
                    return false;
            }
            
            decimal val_3 = System.Decimal.op_Implicit(value:  this._to);
            return System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = 下下丏一丙不丘丌丞.flags, hi = 下下丏一丙不丘丌丞.hi, lo = 下下丏一丙不丘丌丞.lo, mid = 下下丏一丙不丘丌丞.mid}, d2:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid});
        }
        internal bool 上丗不丘上丘丕丟丞(float 下下丏一丙不丘丌丞)
        {
            var val_2;
            if((float)this._from <= 下下丏一丙不丘丌丞)
            {
                    return (bool)((float)this._to >= 下下丏一丙不丘丌丞) ? 1 : 0;
            }
            
            val_2 = 0;
            return (bool)((float)this._to >= 下下丏一丙不丘丌丞) ? 1 : 0;
        }
        internal static PGCompany.DataObjects.IntInterval 东丝七业丄丑丒世七(string 丞丕丒专一下丙业上)
        {
            var val_15;
            var val_16;
            char val_17;
            int val_8 = 0;
            val_15 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞丕丒专一下丙业上)) == true)
            {
                    return (PGCompany.DataObjects.IntInterval)val_15;
            }
            
            char[] val_2 = new char[1];
            val_16 = "-";
            if(("-") == null)
            {
                    val_16 = "-";
            }
            
            val_17 = Chars[0];
            val_2[0] = val_17;
            System.String[] val_4 = 丞丕丒专一下丙业上.Split(separator:  val_2);
            if(val_4.Length < 1)
            {
                goto label_9;
            }
            
            PGCompany.DataObjects.IntInterval val_5 = null;
            val_15 = val_5;
            val_5 = new PGCompany.DataObjects.IntInterval();
            string val_15 = val_4[0];
            Rilisoft.丝丑丂丛万丐丈丘且 val_6 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  -2147483648);
            val_17 = val_15;
            ._from = val_6;
            mem[1152921560558829960] = val_6.上万三丆专丏丒丗业;
            if((System.String.op_Inequality(a:  val_15, b:  "-")) != false)
            {
                    if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_15, 丙业与丙丗丝不丈东: out  val_8)) != false)
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_10 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  0);
                ._from = val_10;
                mem[1152921560558829960] = val_10.上万三丆专丏丒丗业;
            }
            
            }
            
            if(val_4.Length >= 2)
            {
                goto label_16;
            }
            
            label_23:
            Rilisoft.丝丑丂丛万丐丈丘且 val_11 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  117408128);
            ._to = val_11;
            mem[1152921560558829976] = val_11.上万三丆专丏丒丗业;
            return (PGCompany.DataObjects.IntInterval)val_15;
            label_9:
            val_15 = 0;
            return (PGCompany.DataObjects.IntInterval)val_15;
            label_16:
            string val_16 = val_4[1];
            Rilisoft.丝丑丂丛万丐丈丘且 val_12 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  2147483647);
            ._to = val_12;
            mem[1152921560558829976] = val_12.上万三丆专丏丒丗业;
            if((System.String.op_Inequality(a:  val_16, b:  "-")) == false)
            {
                    return (PGCompany.DataObjects.IntInterval)val_15;
            }
            
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_16, 丙业与丙丗丝不丈东: out  val_8)) == false)
            {
                    return (PGCompany.DataObjects.IntInterval)val_15;
            }
            
            goto label_23;
        }
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{0}{1}{2}", arg0:  this._from, arg1:  "-", arg2:  this._to);
        }
        public object Clone()
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  this._from);
            ._from = val_2;
            mem[1152921560559094920] = val_2.上万三丆专丏丒丗业;
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  this._to);
            ._to = val_3;
            mem[1152921560559094936] = val_3.上万三丆专丏丒丗业;
            return (object)new PGCompany.DataObjects.IntInterval();
        }
    
    }

}
