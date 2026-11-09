using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal struct CampaignProgressMemento : IEquatable<Rilisoft.CampaignProgressMemento>
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.LevelProgressMemento> levels;
        private bool _conflicted;
        
        // Properties
        internal bool Conflicted { get; }
        internal System.Collections.Generic.List<Rilisoft.LevelProgressMemento> Levels { get; }
        
        // Methods
        internal bool get_Conflicted()
        {
            return (bool)this;
        }
        internal System.Collections.Generic.List<Rilisoft.LevelProgressMemento> get_Levels()
        {
        
        }
        internal void 下业丛丟丘丆丘下下()
        {
            mem[1152921543635198952] = 1;
        }
        internal CampaignProgressMemento(bool 下丐上丐丗七丕专业)
        {
            bool val_1 = 下丐上丐丗七丕专业;
        }
        public bool Equals(Rilisoft.CampaignProgressMemento 丘丛丏丘丝七世七丅)
        {
        
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
        
        }
        public override int GetHashCode()
        {
        
        }
        public override string ToString()
        {
            return 106040369;
        }
        internal static Rilisoft.CampaignProgressMemento 丝丅丌丁丒丟三丏上(Rilisoft.CampaignProgressMemento 丈丂丕下丏丈丞丗业, Rilisoft.CampaignProgressMemento 丂丌丌丛丆丆丙丌丈)
        {
            var val_17;
            System.Func<Rilisoft.LevelProgressMemento, System.Boolean> val_19;
            var val_23;
            var val_24;
            Rilisoft.LevelProgressMemento val_12 = 0;
            System.Collections.Generic.Dictionary<System.String, Rilisoft.LevelProgressMemento> val_1 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.LevelProgressMemento>();
            val_17 = null;
            val_17 = null;
            val_19 = CampaignProgressMemento.<>c.<>9__11_0;
            if(val_19 == null)
            {
                    System.Func<Rilisoft.LevelProgressMemento, System.Boolean> val_3 = null;
                val_19 = val_3;
                val_3 = new System.Func<Rilisoft.LevelProgressMemento, System.Boolean>(object:  CampaignProgressMemento.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean CampaignProgressMemento.<>c::丙与丒丟丅上一七三(Rilisoft.LevelProgressMemento 丐三丞七丝丅不万丛));
                CampaignProgressMemento.<>c.<>9__11_0 = val_19;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            System.Collections.Generic.IEnumerator<T> val_6 = System.Linq.Enumerable.Where<Rilisoft.LevelProgressMemento>(source:  System.Linq.Enumerable.Concat<Rilisoft.LevelProgressMemento>(first:  丈丂丕下丏丈丞丗业.levels, second:  丂丌丌丛丆丆丙丌丈.levels), predicate:  val_3).GetEnumerator();
            label_30:
            var val_21 = 0;
            val_21 = val_21 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_16;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            T val_10 = val_6.Current;
            if((val_1.TryGetValue(key:  val_10.LevelId, value: out  val_12)) == false)
            {
                goto label_24;
            }
            
            val_1.set_Item(key:  val_10.LevelId, value:  Rilisoft.LevelProgressMemento.丝丅丌丁丒丟三丏上(丈丂丕下丏丈丞丗业:  val_12, 丂丌丌丛丆丆丙丌丈:  val_10));
            goto label_30;
            label_24:
            val_1.Add(key:  val_10.LevelId, value:  val_10);
            goto label_30;
            label_16:
            val_23 = 0;
            val_24 = 0;
            if(val_6 == null)
            {
                
            }
            else
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_6.Dispose();
            }
            
            bool val_24 = 丈丂丕下丏丈丞丗业._conflicted;
            val_24 = 丂丌丌丛丆丆丙丌丈._conflicted | val_24;
            var val_18 = (val_24 != true) ? 1 : 0;
            0.AddRange(collection:  val_1.Values);
            return new Rilisoft.CampaignProgressMemento() {_conflicted = false};
        }
    
    }

}
