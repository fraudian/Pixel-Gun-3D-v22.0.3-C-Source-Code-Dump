using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public struct TrophiesMemento : IEquatable<Rilisoft.TrophiesMemento>
    {
        // Fields
        private readonly bool _conflicted;
        private int trophiesNegative;
        private int trophiesPositive;
        private int season;
        
        // Properties
        public bool Conflicted { get; }
        public int TrophiesNegative { get; }
        public int TrophiesPositive { get; }
        public int Trophies { get; }
        public int Season { get; }
        
        // Methods
        public TrophiesMemento(int 丞且专丈丄丅丟丑下, int 丑万下丞上专丕不丈, int 不丘不丏上丙专上丒)
        {
            mem[1152921543649690736] = 0;
            mem[1152921543649690740] = 丞且专丈丄丅丟丑下;
            mem[1152921543649690744] = 丑万下丞上专丕不丈;
            mem[1152921543649690748] = 不丘不丏上丙专上丒;
        }
        public TrophiesMemento(int 丞且专丈丄丅丟丑下, int 丑万下丞上专丕不丈, int 不丘不丏上丙专上丒, bool 下丐上丐丗七丕专业)
        {
            mem[1152921543649802740] = 丞且专丈丄丅丟丑下;
            mem[1152921543649802744] = 丑万下丞上专丕不丈;
            mem[1152921543649802736] = 下丐上丐丗七丕专业;
            mem[1152921543649802748] = 不丘不丏上丙专上丒;
        }
        public bool get_Conflicted()
        {
            return (bool)this;
        }
        public int get_TrophiesNegative()
        {
            return (int)this;
        }
        public int get_TrophiesPositive()
        {
            return (int)this;
        }
        public int get_Trophies()
        {
            return (int)W9 - W8;
        }
        public int get_Season()
        {
            return (int)this;
        }
        internal static Rilisoft.TrophiesMemento 丝丅丌丁丒丟三丏上(Rilisoft.TrophiesMemento 丈丂丕下丏丈丞丗业, Rilisoft.TrophiesMemento 丂丌丌丛丆丆丙丌丈)
        {
            var val_10;
            int val_11;
            int val_12;
            bool val_10 = 丂丌丌丛丆丆丙丌丈._conflicted;
            bool val_9 = 丈丂丕下丏丈丞丗业._conflicted;
            val_10 = 丈丂丕下丏丈丞丗业.trophiesPositive >> 32;
            int val_1 = 丂丌丌丛丆丆丙丌丈.trophiesPositive >> 32;
            if(val_10 == val_1)
            {
                    val_9 = val_9 >> 32;
                val_10 = val_10 >> 32;
                val_11 = System.Math.Max(val1:  val_9, val2:  val_10);
                val_12 = 丈丂丕下丏丈丞丗业.trophiesPositive;
                int val_4 = System.Math.Max(val1:  val_12, val2:  丂丌丌丛丆丆丙丌丈.trophiesPositive);
                return new Rilisoft.TrophiesMemento() {_conflicted = ((val_10 | val_9) != true) ? 1 : 0, trophiesNegative = val_11, trophiesPositive = (val_10 < val_1) ? 丂丌丌丛丆丆丙丌丈.trophiesPositive : 丈丂丕下丏丈丞丗业.trophiesPositive, season = (val_10 < val_1) ? (val_1) : (val_10)};
            }
            
            val_11 = ((val_10 < val_1) ? (val_10) : (val_9)) >> 32;
            return new Rilisoft.TrophiesMemento() {_conflicted = ((val_10 | val_9) != true) ? 1 : 0, trophiesNegative = val_11, trophiesPositive = (val_10 < val_1) ? 丂丌丌丛丆丆丙丌丈.trophiesPositive : 丈丂丕下丏丈丞丗业.trophiesPositive, season = (val_10 < val_1) ? (val_1) : (val_10)};
        }
        public bool Equals(Rilisoft.TrophiesMemento 丘丛丏丘丝七世七丅)
        {
            if(W8 != (丘丛丏丘丝七世七丅._conflicted >> 32))
            {
                    return false;
            }
            
            if(W8 != 丘丛丏丘丝七世七丅.trophiesPositive)
            {
                    return false;
            }
            
            return (bool)(W8 == (丘丛丏丘丝七世七丅.trophiesPositive >> 32)) ? 1 : 0;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
        
        }
        public override int GetHashCode()
        {
        
        }
        public override string ToString()
        {
            mem2[0] = null;
            mem2[0] = ???;
            return (string)new Rilisoft.TrophiesMemento();
        }
    
    }

}
