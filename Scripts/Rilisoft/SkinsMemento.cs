using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public struct SkinsMemento : IEquatable<Rilisoft.SkinsMemento>
    {
        // Fields
        private readonly bool _conflicted;
        private Rilisoft.CapeMemento cape;
        private System.Collections.Generic.List<Rilisoft.SkinMemento> skins;
        private System.Collections.Generic.List<string> deletedSkins;
        
        // Properties
        public bool Conflicted { get; }
        public Rilisoft.CapeMemento Cape { get; }
        public System.Collections.Generic.List<Rilisoft.SkinMemento> Skins { get; }
        public System.Collections.Generic.List<string> DeletedSkins { get; }
        
        // Methods
        public SkinsMemento(System.Collections.Generic.IEnumerable<Rilisoft.SkinMemento> 专丗丕丐七丅下七丟, System.Collections.Generic.IEnumerable<string> 丆三丘业七丐世丄丘, Rilisoft.CapeMemento 丈丐丕业下丟业丛一)
        {
        
        }
        public SkinsMemento(System.Collections.Generic.IEnumerable<Rilisoft.SkinMemento> 专丗丕丐七丅下七丟, System.Collections.Generic.IEnumerable<string> 丆三丘业七丐世丄丘, Rilisoft.CapeMemento 丈丐丕业下丟业丛一, bool 下丐上丐丗七丕专业)
        {
            bool val_1 = 下丐上丐丗七丕专业;
        }
        public bool get_Conflicted()
        {
            return (bool)this;
        }
        public Rilisoft.CapeMemento get_Cape()
        {
            Rilisoft.CapeMemento val_0;
            val_0._capeHashCode.HasValue = this.deletedSkins;
            val_0.id = ;
            return val_0;
        }
        public System.Collections.Generic.List<Rilisoft.SkinMemento> get_Skins()
        {
        
        }
        public System.Collections.Generic.List<string> get_DeletedSkins()
        {
        
        }
        public System.Collections.Generic.Dictionary<string, Rilisoft.SkinMemento> 东丛且丐丘丁丕丛一()
        {
        
        }
        public bool Equals(Rilisoft.SkinsMemento 丘丛丏丘丝七世七丅)
        {
            return false;
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
            mem2[0] = null;
            mem2[0] = this.skins;
            return (string)this.skins;
        }
        internal static Rilisoft.SkinsMemento 丝丅丌丁丒丟三丏上(Rilisoft.SkinsMemento 丈丂丕下丏丈丞丗业, Rilisoft.SkinsMemento 丂丌丌丛丆丆丙丌丈)
        {
            bool val_5;
            string val_7;
            bool val_8;
            string val_9;
            string val_10;
            bool val_13;
            string val_14;
            string val_15;
            int val_23;
            int val_24;
            int val_25;
            int val_26;
            var val_27;
            var val_28;
            var val_29;
            Rilisoft.SkinsMemento val_0;
            System.Collections.Generic.HashSet<System.String> val_2 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.Concat<System.String>(first:  丈丂丕下丏丈丞丗业._conflicted, second:  丂丌丌丛丆丆丙丌丈._conflicted));
            System.Collections.Generic.Dictionary<System.String, Rilisoft.SkinMemento> val_3 = new System.Collections.Generic.Dictionary<System.String, Rilisoft.SkinMemento>();
            List.Enumerator<T> val_4 = 丈丂丕下丏丈丞丗业._conflicted.GetEnumerator();
            label_12:
            if((387559312 & 1) == 0)
            {
                goto label_2;
            }
            
            val_23 = val_10;
            if(val_10 == 0)
            {
                goto label_4;
            }
            
            if(val_2 != null)
            {
                goto label_7;
            }
            
            goto label_6;
            label_4:
            val_23 = System.String.alignConst;
            if(val_2 != null)
            {
                goto label_7;
            }
            
            label_6:
            label_7:
            if((val_2.Contains(item:  val_23)) == true)
            {
                goto label_12;
            }
            
            val_24 = val_10;
            if(val_10 == 0)
            {
                    val_24 = System.String.alignConst;
            }
            
            val_5 = val_8;
            val_7 = val_9;
            val_3.set_Item(key:  val_24, value:  new Rilisoft.SkinMemento() {id = val_10, name = val_7, skin = val_7, _skinHashCode = new System.Nullable<System.Int32>() {HasValue = val_5}});
            goto label_12;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            List.Enumerator<T> val_12 = 丂丌丌丛丆丆丙丌丈._conflicted.GetEnumerator();
            label_31:
            if((387559312 & 1) == 0)
            {
                goto label_21;
            }
            
            val_25 = val_15;
            if(val_15 == 0)
            {
                goto label_23;
            }
            
            if(val_2 != null)
            {
                goto label_26;
            }
            
            goto label_25;
            label_23:
            val_25 = System.String.alignConst;
            if(val_2 != null)
            {
                goto label_26;
            }
            
            label_25:
            label_26:
            if((val_2.Contains(item:  val_25)) == true)
            {
                goto label_31;
            }
            
            val_26 = val_15;
            if(val_15 == 0)
            {
                    val_26 = System.String.alignConst;
            }
            
            val_15 = val_14;
            val_7 = val_15;
            val_3.set_Item(key:  val_26, value:  new Rilisoft.SkinMemento() {id = val_7, name = val_15, skin = val_15, _skinHashCode = new System.Nullable<System.Int32>() {HasValue = val_13}});
            goto label_31;
            label_21:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_27 = 1152921543649156160;
            val_28 = 1152921543649172560;
            if( != false)
            {
                    val_29 = 1;
            }
            else
            {
                    var val_17 = ( == true) ? 1 : 0;
            }
            
            Rilisoft.CapeMemento val_18 = Rilisoft.CapeMemento.丐下丙丄丌丒三丐专(丈丂丕下丏丈丞丗业:  new Rilisoft.CapeMemento() {id = 丈丂丕下丏丈丞丗业.cape.id, _capeHashCode = new System.Nullable<System.Int32>() {HasValue = 丈丂丕下丏丈丞丗业.cape._capeHashCode.HasValue}}, 丂丌丌丛丆丆丙丌丈:  new Rilisoft.CapeMemento() {id = 丂丌丌丛丆丆丙丌丈.cape.id, _capeHashCode = new System.Nullable<System.Int32>() {HasValue = 丂丌丌丛丆丆丙丌丈.cape._capeHashCode.HasValue}});
            System.Collections.Generic.List<TSource> val_22 = System.Linq.Enumerable.ToList<Rilisoft.SkinMemento>(source:  val_3.Values);
            val_0.cape.cape = 0;
            val_0.skins = 0;
            val_0._conflicted = 0;
            mem[1152921543649188961] = 0;
            return val_0;
        }
    
    }

}
