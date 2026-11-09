using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 业丆丝万专丐丑专下 : IDisposable
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<string, PGCompany.MainStore.业与丝一不丑丕丘与> 丑丗下且且丈丞丌丝;
        
        // Methods
        internal PGCompany.MainStore.业与丝一不丑丕丘与 丒一丂上丛丕丄丏丐(string 丌业专专丞专专丆丌)
        {
            string val_4;
            var val_5;
            val_4 = 丌业专专丞专专丆丌;
            if(val_4 != null)
            {
                    if((this.丑丗下且且丈丞丌丝.ContainsKey(key:  val_4)) == true)
            {
                goto label_3;
            }
            
            }
            
            val_4 = "Default";
            label_3:
            if((this.丑丗下且且丈丞丌丝.ContainsKey(key:  val_4)) != false)
            {
                    PGCompany.MainStore.业与丝一不丑丕丘与 val_3 = this.丑丗下且且丈丞丌丝.Item[val_4];
                return (PGCompany.MainStore.业与丝一不丑丕丘与)val_5;
            }
            
            val_5 = 0;
            return (PGCompany.MainStore.业与丝一不丑丕丘与)val_5;
        }
        internal void 丑东七丏万丌且丝丑(PGCompany.MainStore.业与丝一不丑丕丘与 丗丟上上丒丐丗丞丙)
        {
            if(丗丟上上丒丐丗丞丙 == null)
            {
                    return;
            }
            
            if((this.丑丗下且且丈丞丌丝.ContainsKey(key:  丗丟上上丒丐丗丞丙.<专丟丆丒业丘丝专一>k__BackingField)) != false)
            {
                    bool val_2 = this.丑丗下且且丈丞丌丝.Remove(key:  丗丟上上丒丐丗丞丙.<专丟丆丒业丘丝专一>k__BackingField);
            }
            
            this.丑丗下且且丈丞丌丝.Add(key:  丗丟上上丒丐丗丞丙.<专丟丆丒业丘丝专一>k__BackingField, value:  丗丟上上丒丐丗丞丙);
        }
        internal void 上上丑丈丁丙一七不(string 丌业专专丞专专丆丌)
        {
            if(丌业专专丞专专丆丌 == null)
            {
                    return;
            }
            
            if((this.丑丗下且且丈丞丌丝.ContainsKey(key:  丌业专专丞专专丆丌)) == false)
            {
                    return;
            }
            
            bool val_2 = this.丑丗下且且丈丞丌丝.Remove(key:  丌业专专丞专专丆丌);
        }
        internal bool 丅丛丑丟丒丙一丒丐(string 丌业专专丞专专丆丌)
        {
            if(this.丑丗下且且丈丞丌丝 != null)
            {
                    return this.丑丗下且且丈丞丌丝.ContainsKey(key:  丌业专专丞专专丆丌);
            }
            
            return this.丑丗下且且丈丞丌丝.ContainsKey(key:  丌业专专丞专专丆丌);
        }
        public void Dispose()
        {
        
        }
        public 业丆丝万专丐丑专下()
        {
            this.丑丗下且且丈丞丌丝 = new System.Collections.Generic.Dictionary<System.String, PGCompany.MainStore.业与丝一不丑丕丘与>();
        }
    
    }

}
