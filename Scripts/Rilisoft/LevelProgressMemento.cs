using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal sealed class LevelProgressMemento : IEquatable<Rilisoft.LevelProgressMemento>
    {
        // Fields
        private string levelId;
        private int coinCount;
        private int gemCount;
        private int starCount;
        
        // Properties
        internal string LevelId { get; set; }
        internal int CoinCount { get; set; }
        internal int GemCount { get; set; }
        internal int StarCount { get; set; }
        
        // Methods
        public LevelProgressMemento(string 丒丘丑丅且丆丘东丂)
        {
            if(丒丘丑丅且丆丘东丂 != null)
            {
                    this.levelId = 丒丘丑丅且丆丘东丂;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "levelId");
        }
        internal string get_LevelId()
        {
            string val_1 = this.levelId;
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            val_1 = System.String.alignConst;
            this.levelId = val_1;
            return (string)val_1;
        }
        internal void set_LevelId(string 丙业与丙丗丝不丈东)
        {
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_1;
            }
            
            label_5:
            this.levelId = 丙业与丙丗丝不丈东;
            return;
            label_1:
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_5;
        }
        internal int get_CoinCount()
        {
            return (int)this.coinCount;
        }
        internal void set_CoinCount(int 丙业与丙丗丝不丈东)
        {
            this.coinCount = 丙业与丙丗丝不丈东;
        }
        internal int get_GemCount()
        {
            return (int)this.gemCount;
        }
        internal void set_GemCount(int 丙业与丙丗丝不丈东)
        {
            this.gemCount = 丙业与丙丗丝不丈东;
        }
        internal int get_StarCount()
        {
            return (int)this.starCount;
        }
        internal void set_StarCount(int 丙业与丙丗丝不丈东)
        {
            this.starCount = 丙业与丙丗丝不丈东;
        }
        public bool Equals(Rilisoft.LevelProgressMemento 丘丛丏丘丝七世七丅)
        {
            var val_4;
            if((((丘丛丏丘丝七世七丅 != null) && (this.coinCount == 丘丛丏丘丝七世七丅.coinCount)) && (this.gemCount == 丘丛丏丘丝七世七丅.gemCount)) && (this.starCount == 丘丛丏丘丝七世七丅.starCount))
            {
                    val_4 = (~(System.String.op_Inequality(a:  this.LevelId, b:  丘丛丏丘丝七世七丅.LevelId))) & 1;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆 == null)
            {
                    return false;
            }
            
            if(null == null)
            {
                    return this.Equals(丘丛丏丘丝七世七丅:  万且万且丑丗且丌丆);
            }
            
            return false;
        }
        public override int GetHashCode()
        {
            int val_4 = this.starCount.GetHashCode();
            int val_5 = this.coinCount.GetHashCode() ^ this.LevelId;
            val_5 = val_5 ^ this.gemCount.GetHashCode();
            val_4 = val_5 ^ val_4;
            return (int)val_4;
        }
        public override string ToString()
        {
            return UnityEngine.JsonUtility.ToJson(obj:  this);
        }
        internal static Rilisoft.LevelProgressMemento 丝丅丌丁丒丟三丏上(Rilisoft.LevelProgressMemento 丈丂丕下丏丈丞丗业, Rilisoft.LevelProgressMemento 丂丌丌丛丆丆丙丌丈)
        {
            string val_12;
            var val_13;
            if(丈丂丕下丏丈丞丗业 == null)
            {
                goto label_1;
            }
            
            if(丂丌丌丛丆丆丙丌丈 == null)
            {
                goto label_2;
            }
            
            if((System.String.op_Inequality(a:  丈丂丕下丏丈丞丗业.LevelId, b:  丂丌丌丛丆丆丙丌丈.LevelId)) == true)
            {
                goto label_3;
            }
            
            .coinCount = System.Math.Max(val1:  丈丂丕下丏丈丞丗业.coinCount, val2:  丂丌丌丛丆丆丙丌丈.coinCount);
            .gemCount = System.Math.Max(val1:  丈丂丕下丏丈丞丗业.gemCount, val2:  丂丌丌丛丆丆丙丌丈.gemCount);
            .starCount = System.Math.Max(val1:  丈丂丕下丏丈丞丗业.starCount, val2:  丂丌丌丛丆丆丙丌丈.starCount);
            return (Rilisoft.LevelProgressMemento)new Rilisoft.LevelProgressMemento(丒丘丑丅且丆丘东丂:  丈丂丕下丏丈丞丗业.LevelId);
            label_1:
            val_12 = "left";
            goto label_9;
            label_2:
            System.ArgumentNullException val_9 = null;
            val_12 = "right";
            label_9:
            val_13 = val_9;
            val_9 = new System.ArgumentNullException(paramName:  val_12);
            goto label_10;
            label_3:
            System.ArgumentException val_10 = null;
            val_13 = val_10;
            val_10 = new System.ArgumentException(message:  "Level ids shoud be equal.");
            label_10:
        }
    
    }

}
