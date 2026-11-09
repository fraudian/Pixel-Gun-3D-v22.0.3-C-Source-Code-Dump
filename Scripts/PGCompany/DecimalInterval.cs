using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class DecimalInterval : ICloneable
    {
        // Fields
        public const string DELIMER = "-";
        internal decimal From;
        internal decimal To;
        
        // Methods
        internal DecimalInterval()
        {
        
        }
        internal DecimalInterval(decimal 丈丗与丞一上且上上, decimal 专丂丕丗丗东世丞下)
        {
            this.From = 丈丗与丞一上且上上;
            mem[1152921555868364776] = 丈丗与丞一上且上上.lo;
            mem[1152921555868364780] = 丈丗与丞一上且上上.mid;
            this.To = 专丂丕丗丗东世丞下;
            mem[1152921555868364792] = 专丂丕丗丗东世丞下.lo;
            mem[1152921555868364796] = 专丂丕丗丗东世丞下.mid;
        }
        internal bool 上丗不丘上丘丕丟丞(int 下下丏一丙不丘丌丞)
        {
            decimal val_1 = System.Decimal.op_Implicit(value:  下下丏一丙不丘丌丞);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, d2:  new System.Decimal() {flags = this.From, hi = this.From})) == false)
            {
                    return false;
            }
            
            decimal val_3 = System.Decimal.op_Implicit(value:  下下丏一丙不丘丌丞);
            return System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid}, d2:  new System.Decimal() {flags = this.To, hi = this.To});
        }
        internal bool 上丗不丘上丘丕丟丞(decimal 下下丏一丙不丘丌丞)
        {
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = 下下丏一丙不丘丌丞.flags, hi = 下下丏一丙不丘丌丞.hi, lo = 下下丏一丙不丘丌丞.lo, mid = 下下丏一丙不丘丌丞.mid}, d2:  new System.Decimal() {flags = this.From, hi = this.From, lo = 137125888})) == false)
            {
                    return false;
            }
            
            return System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = 下下丏一丙不丘丌丞.flags, hi = 下下丏一丙不丘丌丞.hi, lo = 下下丏一丙不丘丌丞.lo, mid = 下下丏一丙不丘丌丞.mid}, d2:  new System.Decimal() {flags = this.To, hi = this.To, lo = -277865776, mid = 268435467});
        }
        internal bool 上丗不丘上丘丕丟丞(float 下下丏一丙不丘丌丞)
        {
            decimal val_1 = System.Decimal.op_Explicit(value:  下下丏一丙不丘丌丞);
            if((System.Decimal.op_GreaterThanOrEqual(d1:  new System.Decimal() {flags = val_1.flags, hi = val_1.hi, lo = val_1.lo, mid = val_1.mid}, d2:  new System.Decimal() {flags = this.From, hi = this.From})) == false)
            {
                    return false;
            }
            
            decimal val_3 = System.Decimal.op_Explicit(value:  下下丏一丙不丘丌丞);
            return System.Decimal.op_LessThanOrEqual(d1:  new System.Decimal() {flags = val_3.flags, hi = val_3.hi, lo = val_3.lo, mid = val_3.mid}, d2:  new System.Decimal() {flags = this.To, hi = this.To});
        }
        internal static PGCompany.DecimalInterval 东丝七业丄丑丒世七(string 丞丕丒专一下丙业上)
        {
            var val_10;
            var val_11;
            char val_12;
            decimal val_13;
            val_10 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞丕丒专一下丙业上)) == true)
            {
                    return (PGCompany.DecimalInterval)val_10;
            }
            
            char[] val_2 = new char[1];
            val_11 = "-";
            if(("-") == null)
            {
                    val_11 = "-";
            }
            
            val_12 = Chars[0];
            val_2[0] = val_12;
            System.String[] val_4 = 丞丕丒专一下丙业上.Split(separator:  val_2);
            if(val_4.Length < 1)
            {
                goto label_9;
            }
            
            PGCompany.DecimalInterval val_5 = null;
            val_10 = val_5;
            val_5 = new PGCompany.DecimalInterval();
            val_12 = val_4[0];
            if((System.String.op_Equality(a:  val_12, b:  "-")) != true)
            {
                    if((丞东丑专丛丆丄丝世.丛丐东丟丛丘丁世丁(丞丕丒专一下丙业上:  val_12, 丙业与丙丗丝不丈东: out  new System.Decimal() {flags = (PGCompany.DecimalInterval)[1152921555868947184].From, hi = (PGCompany.DecimalInterval)[1152921555868947184].From, lo = (PGCompany.DecimalInterval)[1152921555868947184].From, mid = (PGCompany.DecimalInterval)[1152921555868947184].From})) == true)
            {
                goto label_15;
            }
            
            }
            
            .From = 0m;
            mem[1152921555868947208] = 0;
            label_15:
            if(val_4.Length >= 2)
            {
                goto label_17;
            }
            
            if(val_10 == null)
            {
                goto label_18;
            }
            
            val_13 = (PGCompany.DecimalInterval)[1152921555868947184].From;
            goto label_19;
            label_9:
            val_10 = 0;
            return (PGCompany.DecimalInterval)val_10;
            label_17:
            string val_10 = val_4[1];
            if((System.String.op_Equality(a:  val_10, b:  "-")) != true)
            {
                    val_12 = (PGCompany.DecimalInterval)[1152921555868947184].To;
                if((丞东丑专丛丆丄丝世.丛丐东丟丛丘丁世丁(丞丕丒专一下丙业上:  val_10, 丙业与丙丗丝不丈东: out  new System.Decimal() {flags = val_12, hi = val_12, lo = val_12, mid = val_12})) == true)
            {
                    return (PGCompany.DecimalInterval)val_10;
            }
            
            }
            
            .To = 0m;
            mem[1152921555868947224] = 0;
            return (PGCompany.DecimalInterval)val_10;
            label_18:
            val_13 = 11993091m;
            val_12 = 28563616;
            label_19:
            .To = val_13;
            mem[1152921555868947224] = val_12;
            return (PGCompany.DecimalInterval)val_10;
        }
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{0}{1}{2}", arg0:  this.From, arg1:  "-", arg2:  this.To);
        }
        public object Clone()
        {
            .From = this.From;
            mem[1152921555869212168] = ???;
            .To = this.To;
            mem[1152921555869212184] = this;
            return (object)new PGCompany.DecimalInterval();
        }
    
    }

}
