using UnityEngine;

namespace Rilisoft
{
    internal abstract class 丈丕丅丄七丁丒丅上
    {
        // Fields
        internal const string 上丘丐丐丝丏一丙丏 = "EndTime";
        protected System.Func<bool> 世丆且丗丙业丕丁丙;
        protected System.Collections.Generic.Dictionary<string, object> 丕丘丛丆丝丆丈丆与;
        public bool 下专三丛七且丗上世;
        
        // Properties
        protected virtual bool 丙三丝丏专丘丈丐业 { get; }
        
        // Methods
        protected virtual bool 一业丟丁上丑丘丕丄()
        {
            if(this.世丆且丗丙业丕丁丙 == null)
            {
                    return (bool)this.世丆且丗丙业丕丁丙;
            }
            
            return this.世丆且丗丙业丕丁丙.Invoke();
        }
        protected virtual void 与丐丈丐丏一丒三与()
        {
        
        }
        public virtual void 下丈丂丟丐业丟丂丁(System.Collections.Generic.List<System.Collections.Generic.Dictionary<string, object>> 与万丁丈与且丁三丁)
        {
            if(与万丁丈与且丁三丁 == null)
            {
                    return;
            }
            
            bool val_1 = 与万丁丈与且丁三丁.Contains(item:  this.丕丘丛丆丝丆丈丆与);
            if((this & 1) != 0)
            {
                    if(val_1 == true)
            {
                    return;
            }
            
                if(this.丕丘丛丆丝丆丈丆与 == null)
            {
                    return;
            }
            
                与万丁丈与且丁三丁.Add(item:  this.丕丘丛丆丝丆丈丆与);
                return;
            }
            
            if(val_1 == false)
            {
                    return;
            }
            
            bool val_2 = 与万丁丈与且丁三丁.Remove(item:  this.丕丘丛丆丝丆丈丆与);
        }
        protected 丈丕丅丄七丁丒丅上()
        {
            this.下专三丛七且丗上世 = true;
        }
    
    }

}
