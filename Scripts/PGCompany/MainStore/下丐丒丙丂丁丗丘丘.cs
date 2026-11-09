using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 下丐丒丙丂丁丗丘丘 : 东丑丆丗丏丐丟下丄
    {
        // Fields
        private static System.Action<PGCompany.东丑丆丗丏丐丟下丄> 丐且丌丟丛万丗丙丑;
        private readonly System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> <丝不丕丑一丙专丘三>k__BackingField;
        private PGCompany.DataObjects.专丅一丄上丗且丑一 丗专丄丑下丄丘丁与;
        
        // Properties
        internal string 东专丏世世专上世丗 { get; }
        internal string 丘丏丐丞丈专三且世 { get; }
        internal System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> 丞丙上丐万上丁丟东 { get; }
        internal sealed override System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丌丙丏丄下万万丄上 { get; }
        
        // Methods
        internal static void 七七东专世丘一丆丏(System.Action<PGCompany.东丑丆丗丏丐丟下丄> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.MainStore.下丐丒丙丂丁丗丘丘.丐且丌丟丛万丗丙丑, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丆丆丑丒丛七不丈丆(System.Action<PGCompany.东丑丆丗丏丐丟下丄> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.MainStore.下丐丒丙丂丁丗丘丘.丐且丌丟丛万丗丙丑, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal string 丝丒丙一丙丄不三丞()
        {
            if(this.丗专丄丑下丄丘丁与 != null)
            {
                    return (string)this.丗专丄丑下丄丘丁与.丄丑丘专丄七不专丆;
            }
            
            return (string)this.丗专丄丑下丄丘丁与.丄丑丘专丄七不专丆;
        }
        internal string 丅上万丛一丐上上丕()
        {
            if(this.丗专丄丑下丄丘丁与 != null)
            {
                    return (string)this.丗专丄丑下丄丘丁与.丘丏丐丞丈专三且世;
            }
            
            return (string)this.丗专丄丑下丄丘丁与.丘丏丐丞丈专三且世;
        }
        internal System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> 丝世丑七丂丄丅专不()
        {
            if(this.丗专丄丑下丄丘丁与 != null)
            {
                    return (System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>)this.丗专丄丑下丄丘丁与.下丐丐丁与丂下世七;
            }
            
            return (System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅>)this.丗专丄丑下丄丘丁与.下丐丐丁与丂下世七;
        }
        internal sealed override System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 七万三丟丞丆丞东业()
        {
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)this.<丝不丕丑一丙专丘三>k__BackingField;
        }
        internal bool 丞丞丈丌且业丘丑三()
        {
            var val_8;
            var val_9;
            val_8 = this;
            var val_8 = (long)this.上丟丄与丁三丌丘专();
            val_8 = val_8 - PixelTime.丙丅丅业丟丁世丁丗();
            if(val_8 > 0)
            {
                    val_9 = 1;
                return (bool)val_9;
            }
            
            if(Initializer.丑七不且上丗丁一世() != 0)
            {
                    val_8 = this.丒丒与丑丏世且丂业();
                var val_7 = (val_8.业东丅东丌上丗丑不() == 17015) ? 1 : 0;
                return (bool)val_9;
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        internal 下丐丒丙丂丁丗丘丘(PGCompany.StorePromotionConfig 上世丏丁世丟世丆业, PGCompany.DataObjects.专丅一丄上丗且丑一 且万丄丏专丄丛丌丗)
        {
            this.<丝不丕丑一丙专丘三>k__BackingField = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            this.丗专丄丑下丄丘丁与 = 且万丄丏专丄丛丌丗;
            this.丙丛东七丛一世一丕(且万丄丏专丄丛丌丗:  且万丄丏专丄丛丌丗);
        }
        internal void 丙丛东七丛一世一丕(PGCompany.DataObjects.专丅一丄上丗且丑一 且万丄丏专丄丛丌丗)
        {
            this.丗专丄丑下丄丘丁与 = 且万丄丏专丄丛丌丗;
            this.Clear();
            if(this.丗专丄丑下丄丘丁与 == null)
            {
                goto label_2;
            }
            
            if(this.丗专丄丑下丄丘丁与.下丐丐丁与丂下世七 == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_1 = this.丗专丄丑下丄丘丁与.下丐丐丁与丂下世七.GetEnumerator();
            label_8:
            if(((-612420792) & 1) == 0)
            {
                goto label_4;
            }
            
            if((0.丐丏七丌丕丗业且上() == null) || (val_2.m_stringLength == 0))
            {
                goto label_8;
            }
            
            this.Add(item:  val_2.m_stringLength);
            goto label_8;
            label_2:
            this = System.String.Format(format:  "promotion without config: \'{0}\'", arg0:  this.七丈丒丒下下且万与());
            UnityEngine.Debug.LogError(message:  this);
            return;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal PGCompany.DataObjects.专丅一丄上丗且丑一 丅世丄丆不丆且丐七()
        {
            return (PGCompany.DataObjects.专丅一丄上丗且丑一)this.丗专丄丑下丄丘丁与;
        }
        internal bool 一丂丞东丄上丐上丟(string 丆万一不丌且东丐丐)
        {
            var val_4;
            List.Enumerator<T> val_1 = this.丗专丄丑下丄丘丁与.下丐丐丁与丂下世七.GetEnumerator();
            label_6:
            if(((-612147624) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if((0 == 0) || ((0.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  丆万一不丌且东丐丐)) == false))
            {
                goto label_6;
            }
            
            val_4 = 1;
            goto label_7;
            label_3:
            val_4 = 0;
            label_7:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool);
        }
        internal void 丘丙丁丅七一与且丈(string 丆万一不丌且东丐丐, ref System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> 专丂丕丗丗东世丞下)
        {
            var val_4;
            System.Collections.Generic.List<PGCompany.丄与丘丑业专丞七丅> val_5;
            val_4 = 1152921559829471152;
            val_5 = this;
            if(专丂丕丗丗东世丞下 == null)
            {
                    return;
            }
            
            val_5 = this.丗专丄丑下丄丘丁与.下丐丐丁与丂下世七;
            List.Enumerator<T> val_1 = val_5.GetEnumerator();
            label_9:
            if(((-611998872) & 1) == 0)
            {
                goto label_4;
            }
            
            if((0 == 0) || ((0.且丄丄丛丏丑丕丕上(丆万一不丌且东丐丐:  丆万一不丌且东丐丐)) == false))
            {
                goto label_9;
            }
            
            专丂丕丗丗东世丞下.Add(item:  0.丐丏七丌丕丗业且上());
            goto label_9;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        internal void 专不丗丈丒丄三三丙()
        {
            if(PGCompany.MainStore.下丐丒丙丂丁丗丘丘.丐且丌丟丛万丗丙丑 == null)
            {
                    return;
            }
            
            PGCompany.MainStore.下丐丒丙丂丁丗丘丘.丐且丌丟丛万丗丙丑.Invoke(obj:  this);
        }
    
    }

}
