using UnityEngine;

namespace PGCompany
{
    internal sealed class 丘丛丈与丑丌丑专丐
    {
        // Fields
        internal System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.List<System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>> ScoreResult;
        internal System.Collections.Generic.List<float> leavePenalty;
        internal System.Collections.Generic.List<int> leavePenaltyFixed;
        
        // Methods
        internal int 丛丗七三丄丑丂丗丁(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, RatingSystem.RatingLeague 丙丑七万丆万丆且丌, int 且丒丛与丞世丙丕丌)
        {
            int val_15;
            Rilisoft.七丕丟丏三丈一丄世 val_16;
            System.Collections.Generic.Dictionary<Rilisoft.七丕丟丏三丈一丄世, System.Collections.Generic.List<System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>>> val_17;
            var val_18;
            val_15 = 且丒丛与丞世丙丕丌;
            val_16 = 上且丗一丏丏万丅丌;
            val_17 = this.ScoreResult;
            if((val_17.ContainsKey(key:  val_16)) != false)
            {
                    val_17 = this.ScoreResult.Item[val_16];
                if(val_17.Count > 丙丑七万丆万丆且丌)
            {
                    val_17 = this.ScoreResult.Item[val_16].Item[丙丑七万丆万丆且丌];
                val_18 = val_17;
                if(val_18.Count == 0)
            {
                    return (int)val_18;
            }
            
                val_17 = this.ScoreResult;
                val_16 = val_17.Item[val_16];
                val_15 = System.Math.Min(val1:  val_16.Item[丙丑七万丆万丆且丌].Count - 1, val2:  val_15);
                Rilisoft.丝丑丂丛万丐丈丘且 val_14 = this.ScoreResult.Item[val_16].Item[丙丑七万丆万丆且丌].Item[val_15];
                val_18;
                return (int)val_18;
            }
            
            }
            
            val_18 = 0;
            return (int)val_18;
        }
        internal int 丝专与丆下万七丗与(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, RatingSystem.RatingLeague 丙丑七万丆万丆且丌)
        {
            System.Collections.Generic.List<System.Int32> val_13;
            float val_14;
            var val_15;
            var val_16;
            val_13 = this;
            int val_1 = this.丛丗七三丄丑丂丗丁(上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 丙丑七万丆万丆且丌:  丙丑七万丆万丆且丌, 且丒丛与丞世丙丕丌:  200);
            val_14 = 1f;
            if(this.leavePenalty != null)
            {
                    if(this.leavePenalty.Count != 0)
            {
                    val_14 = this.leavePenalty.Item[System.Math.Min(val1:  this.leavePenalty.Count - 1, val2:  丙丑七万丆万丆且丌)];
            }
            
            }
            
            if((this.leavePenaltyFixed == null) || (this.leavePenaltyFixed.Count == 0))
            {
                goto label_8;
            }
            
            val_13 = this.leavePenaltyFixed;
            val_15 = val_13.Item[System.Math.Min(val1:  val_13.Count - 1, val2:  丙丑七万丆万丆且丌)];
            if((val_1 & 2147483648) == 0)
            {
                goto label_13;
            }
            
            label_17:
            float val_13 = (float)val_1;
            val_13 = val_14 * val_13;
            val_16 = 0;
            int val_12 = UnityEngine.Mathf.RoundToInt(f:  val_13);
            goto label_16;
            label_8:
            val_15 = 1;
            if((val_1 & 2147483648) != 0)
            {
                goto label_17;
            }
            
            label_13:
            val_16 = 0;
            label_16:
            val_16 = val_16 - val_15;
            return (int)val_16;
        }
        public 丘丛丈与丑丌丑专丐()
        {
        
        }
    
    }

}
