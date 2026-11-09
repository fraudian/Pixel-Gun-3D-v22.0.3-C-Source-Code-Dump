using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class GameEventChestPriceContainer
    {
        // Fields
        public string Currency;
        public int Price;
        
        // Methods
        internal static Rilisoft.GameEventChestPriceContainer 与丛丆专东丐一且丅(string 丞丕丒专一下丙业上)
        {
            var val_10;
            var val_11;
            string val_12;
            var val_13;
            Rilisoft.GameEventChestPriceContainer val_1 = new Rilisoft.GameEventChestPriceContainer();
            if(val_1 != null)
            {
                    val_10 = val_1;
                .Currency = 0;
            }
            else
            {
                    val_10 = 16;
                mem[16] = 0;
            }
            
            .Price = 0;
            char[] val_2 = new char[1];
            val_2[0] = ':';
            System.String[] val_3 = 丞丕丒专一下丙业上.Split(separator:  val_2);
            if(val_3.Length != 2)
            {
                    return val_1;
            }
            
            string val_10 = val_3[0];
            bool val_5 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_3[1], 丙业与丙丗丝不丈东: out  1152921542105065272);
            if((System.String.op_Equality(a:  val_10, b:  "c")) != false)
            {
                    val_11 = null;
                val_11 = null;
                val_12 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
            }
            else
            {
                    if((System.String.op_Equality(a:  val_10, b:  "g")) != false)
            {
                    val_13 = null;
                val_13 = null;
                val_12 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            }
            else
            {
                    if((System.String.op_Equality(a:  val_10, b:  "i")) != false)
            {
                    val_12 = "inapp";
            }
            
            }
            
            }
            
            mem[16] = Rilisoft.丛且世丐丆上七业丁.丕万丑且上七世丛不(丟丟丄专上丟丁丐丝:  val_10);
            return val_1;
        }
        public override string ToString()
        {
            var val_6;
            var val_7;
            var val_8;
            val_6 = null;
            val_6 = null;
            if((System.String.op_Equality(a:  this.Currency, b:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄)) != false)
            {
                    val_7 = "c";
                return (string)System.String.Format(format:  "{0}:{1}", arg0:  ((System.String.op_Equality(a:  this.Currency, b:  "inapp")) != true) ? "i" : (this.Currency), arg1:  this.Price);
            }
            
            val_8 = null;
            val_8 = null;
            if((System.String.op_Equality(a:  this.Currency, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) != false)
            {
                    val_7 = "g";
                return (string)System.String.Format(format:  "{0}:{1}", arg0:  ((System.String.op_Equality(a:  this.Currency, b:  "inapp")) != true) ? "i" : (this.Currency), arg1:  this.Price);
            }
            
            return (string)System.String.Format(format:  "{0}:{1}", arg0:  ((System.String.op_Equality(a:  this.Currency, b:  "inapp")) != true) ? "i" : (this.Currency), arg1:  this.Price);
        }
        public GameEventChestPriceContainer()
        {
        
        }
    
    }

}
