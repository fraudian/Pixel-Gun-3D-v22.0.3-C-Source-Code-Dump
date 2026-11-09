using UnityEngine;

namespace HexTiles
{
    [Serializable]
    public class HexCoords
    {
        // Fields
        public int Q;
        public int R;
        
        // Methods
        public HexCoords(int 丒世且丒丅丆一万丝, int 东七上世万下丗丄丛)
        {
            this.Q = 丒世且丒丅丆一万丝;
            this.R = 东七上世万下丗丄丛;
        }
        public static HexTiles.HexCoords 七万丘且丅世丝丈东(HexTiles.HexCoords 丆丛丑世下一丐且丕, HexTiles.HexCoords 丌丗丏丏丛东专丁且)
        {
            int val_2;
            int val_3;
            int val_2 = 丆丛丑世下一丐且丕.Q;
            if(丌丗丏丏丛东专丁且 != null)
            {
                    val_2 = 丌丗丏丏丛东专丁且.Q;
                val_3 = 丆丛丑世下一丐且丕.R;
            }
            else
            {
                    val_2 = 11993091;
                val_3 = 丆丛丑世下一丐且丕.R;
            }
            
            HexTiles.HexCoords val_1 = null;
            val_2 = val_2 + val_2;
            val_3 = 丌丗丏丏丛东专丁且.R + val_3;
            val_1 = new HexTiles.HexCoords();
            .Q = val_2;
            .R = val_3;
            return val_1;
        }
        public static HexTiles.HexCoords 丗丏丙丈不丛丆七丂(HexTiles.HexCoords 丆丛丑世下一丐且丕, HexTiles.HexCoords 丌丗丏丏丛东专丁且)
        {
            int val_2;
            int val_3;
            int val_2 = 丆丛丑世下一丐且丕.Q;
            if(丌丗丏丏丛东专丁且 != null)
            {
                    val_2 = 丌丗丏丏丛东专丁且.Q;
                val_3 = 丆丛丑世下一丐且丕.R;
            }
            else
            {
                    val_2 = 11993091;
                val_3 = 丆丛丑世下一丐且丕.R;
            }
            
            HexTiles.HexCoords val_1 = null;
            val_2 = val_2 - val_2;
            val_3 = val_3 - 丌丗丏丏丛东专丁且.R;
            val_1 = new HexTiles.HexCoords();
            .Q = val_2;
            .R = val_3;
            return val_1;
        }
        public int 上丗世丝七丟丗丈且(HexTiles.HexCoords 丘丛丏丘丝七世七丅)
        {
            int val_8 = 丘丛丏丘丝七世七丅.Q;
            int val_8 = this.Q;
            int val_1 = this.Q - 丘丛丏丘丝七世七丅.Q;
            val_8 = this.R + val_8;
             = val_8 - ;
             =  - 丘丛丏丘丝七世七丅.R;
            var val_3 = (<0) ? (-) : ();
            int val_4 = this.R - 丘丛丏丘丝七世七丅.R;
            val_3 = val_3 + ((<0) ? (-val_1) : (val_1));
            val_3 = val_3 + ((<0) ? (-val_4) : (val_4));
            return (int)((val_3 < 0) ? (val_3 + 1) : (val_3)) >> 1;
        }
        public bool 一专丗丐丐上专世且(HexTiles.HexCoords 丆丛丑世下一丐且丕, HexTiles.HexCoords 丌丗丏丏丛东专丁且)
        {
            if((this.Q < 丆丛丑世下一丐且丕.Q) || (this.Q >= 丌丗丏丏丛东专丁且.Q))
            {
                    return false;
            }
            
            if(this.R < 丆丛丑世下一丐且丕.R)
            {
                    return false;
            }
            
            var val_1 = (this.R < 丌丗丏丏丛东专丁且.R) ? 1 : 0;
            return false;
        }
        public HexTiles.HexCoords[] 上丒且丝丛丌丗专丛(int 下丈丌三且三丝丄与)
        {
            var val_12;
            var val_13;
            int val_14;
            var val_15;
            if((下丈丌三且三丝丄与 & 2147483648) != 0)
            {
                goto label_1;
            }
            
            if(下丈丌三且三丝丄与 == 0)
            {
                goto label_2;
            }
            
            System.Collections.Generic.List<HexTiles.HexCoords> val_1 = null;
            val_12 = val_1;
            val_1 = new System.Collections.Generic.List<HexTiles.HexCoords>();
            if((-下丈丌三且三丝丄与) > 下丈丌三且三丝丄与)
            {
                goto label_3;
            }
            
            int val_11 = -下丈丌三且三丝丄与;
            label_11:
            val_13 = System.Math.Max(val1:  -下丈丌三且三丝丄与, val2:  (-val_11) - 下丈丌三且三丝丄与);
            val_14 = 下丈丌三且三丝丄与 - val_13;
            goto label_6;
            label_10:
            .Q = val_11;
            .R = val_14;
            val_1.Add(item:  HexTiles.HexCoords.七万丘且丅世丝丈东(丆丛丑世下一丐且丕:  this, 丌丗丏丏丛东专丁且:  new HexTiles.HexCoords()));
            val_13 = val_13 + 1;
            val_14 = val_14 - 1;
            label_6:
            if(val_13 <= (System.Math.Min(val1:  下丈丌三且三丝丄与, val2:  下丈丌三且三丝丄与 - val_11)))
            {
                goto label_10;
            }
            
            int val_12 = 下丈丌三且三丝丄与;
            val_11 = val_11 + 1;
            val_12 = val_12 - 1;
            if(val_11 <= 下丈丌三且三丝丄与)
            {
                goto label_11;
            }
            
            label_3:
            val_15 = val_1.ToArray();
            return (HexTiles.HexCoords[])val_15;
            label_2:
            val_15 = new HexTiles.HexCoords[1];
            val_15[0] = this;
            return (HexTiles.HexCoords[])val_15;
            label_1:
            System.ArgumentOutOfRangeException val_10 = new System.ArgumentOutOfRangeException(paramName:  "range", message:  "Range must be at least 1");
        }
        public UnityEngine.Vector2 与丙丏专世丗不丂丞()
        {
            int val_2 = this.Q;
            val_2 = val_2 & 4294967294;
            float val_3 = (float)val_2;
            float val_4 = (float)this.R;
            val_3 = val_3 * 0.5f;
            val_4 = val_3 + val_4;
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  (float)val_2, y:  val_4);
            return new UnityEngine.Vector2() {x = val_1.x, y = val_1.y};
        }
        public override int GetHashCode()
        {
            int val_2 = this.R.GetHashCode();
            val_2 = (val_2 + (this.Q.GetHashCode() * 23)) + 8993;
            return (int)val_2;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            System.Type val_7;
            var val_8;
            if(万且万且丑丗且丌丆 != null)
            {
                    val_7 = this.GetType();
                if(((System.Type.op_Inequality(left:  val_7, right:  万且万且丑丗且丌丆.GetType())) != true) && (null == this.Q))
            {
                    var val_5 = (null == this.R) ? 1 : 0;
                return (bool)val_8;
            }
            
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        public static bool 丌且丕丐丛上丅且丁(HexTiles.HexCoords 丆丛丑世下一丐且丕, HexTiles.HexCoords 丌丗丏丏丛东专丁且)
        {
            var val_2;
            if(丆丛丑世下一丐且丕 == 丌丗丏丏丛东专丁且)
            {
                    return true;
            }
            
            val_2 = 0;
            if(丆丛丑世下一丐且丕 == null)
            {
                    return (bool)(丆丛丑世下一丐且丕.R == 丌丗丏丏丛东专丁且.R) ? 1 : 0;
            }
            
            if(丌丗丏丏丛东专丁且 == null)
            {
                    return (bool)(丆丛丑世下一丐且丕.R == 丌丗丏丏丛东专丁且.R) ? 1 : 0;
            }
            
            if(丆丛丑世下一丐且丕.Q != 丌丗丏丏丛东专丁且.Q)
            {
                    return false;
            }
            
            return (bool)(丆丛丑世下一丐且丕.R == 丌丗丏丏丛东专丁且.R) ? 1 : 0;
        }
        public static bool 万丌专丅丘丘丟万东(HexTiles.HexCoords 丆丛丑世下一丐且丕, HexTiles.HexCoords 丌丗丏丏丛东专丁且)
        {
            var val_2;
            if(丆丛丑世下一丐且丕 == 丌丗丏丏丛东专丁且)
            {
                    return false;
            }
            
            val_2 = 1;
            if(丆丛丑世下一丐且丕 == null)
            {
                    return (bool)(丆丛丑世下一丐且丕.R != 丌丗丏丏丛东专丁且.R) ? 1 : 0;
            }
            
            if(丌丗丏丏丛东专丁且 == null)
            {
                    return (bool)(丆丛丑世下一丐且丕.R != 丌丗丏丏丛东专丁且.R) ? 1 : 0;
            }
            
            if(丆丛丑世下一丐且丕.Q != 丌丗丏丏丛东专丁且.Q)
            {
                    return true;
            }
            
            return (bool)(丆丛丑世下一丐且丕.R != 丌丗丏丏丛东专丁且.R) ? 1 : 0;
        }
        public override string ToString()
        {
            return (string)System.String.Format(format:  "({0}, {1})", arg0:  this.Q, arg1:  this.R);
        }
    
    }

}
