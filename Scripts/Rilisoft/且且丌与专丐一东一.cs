using UnityEngine;

namespace Rilisoft
{
    internal sealed class 且且丌与专丐一东一
    {
        // Fields
        private const float 丄一丑丑丂世丆丞世 = 960;
        private static readonly Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.且且丌与专丐一东一> 世丒丞七专三与万丕;
        private static readonly System.Collections.Generic.Dictionary<string, object> 下丁一下业下丆不丘;
        private System.Collections.Generic.Dictionary<string, object> 丄业丟丘专一丂上专;
        
        // Properties
        internal static Rilisoft.且且丌与专丐一东一 丆丕丝丒不丙且丐丗 { get; }
        public System.Collections.Generic.Dictionary<string, object> 丈七且三丈丁丏丄丙 { get; }
        
        // Methods
        private 且且丌与专丐一东一()
        {
            this.丄业丟丘专一丂上专 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  0);
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void Rilisoft.且且丌与专丐一东一::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            this.且丛一三业丈丝丞丅();
        }
        private void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 41)
            {
                    return;
            }
            
            this.且丛一三业丈丝丞丅();
        }
        private void 且丛一三业丈丝丞丅()
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = null;
            Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  41)) = val_4;
            val_4 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  0);
            this.丄业丟丘专一丂上专 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  41));
        }
        internal static Rilisoft.且且丌与专丐一东一 丑七不且上丗丁一世()
        {
            null = null;
            if(Rilisoft.且且丌与专丐一东一.世丒丞七专三与万丕 != null)
            {
                    return Rilisoft.且且丌与专丐一东一.世丒丞七专三与万丕.世三丞丅丑丌丈丈一();
            }
            
            return Rilisoft.且且丌与专丐一东一.世丒丞七专三与万丕.世三丞丅丑丌丈丈一();
        }
        public System.Collections.Generic.Dictionary<string, object> 世七丑丑丕丄丌丗丈()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)this.丄业丟丘专一丂上专;
        }
        internal Rilisoft.丆丆丕丟不一丝丕世 专万丗丁丗下不丂丈(string 七丆丒与丗丌丄且丂)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_30;
            string val_32;
            object val_6 = 0;
            object val_8 = 0;
            val_30 = this.丄业丟丘专一丂上专;
            if(val_30.Count == 0)
            {
                goto label_2;
            }
            
            if((System.String.IsNullOrEmpty(value:  七丆丒与丗丌丄且丂)) == false)
            {
                goto label_3;
            }
            
            val_32 = "Category is empty";
            goto label_11;
            label_2:
            val_32 = "Last loaded config is empty";
            goto label_11;
            label_3:
            val_30 = 1152921516595658096;
            if((this.丄业丟丘专一丂上专.TryGetValue(key:  "mainMenu", value: out  0)) != false)
            {
                    val_32 = "Root object is not dictionary";
            }
            else
            {
                    Rilisoft.丆丆丕丟不一丝丕世 val_5 = null;
                val_32 = "Root object not found";
            }
            
            label_11:
            val_5 = new Rilisoft.丆丆丕丟不一丝丕世(丂七东不不丈一丐不:  val_32);
            return val_5;
        }
        private static object 且丏三丝下丒丄东下(System.Collections.Generic.Dictionary<string, object> 七万上丐一丈丏丏专, System.Collections.Generic.Dictionary<string, object> 三三丆专世上三丈丞, string 下上丐丆丝丟丝丒不)
        {
            var val_5;
            object val_1 = 0;
            if((三三丆专世上三丈丞.TryGetValue(key:  下上丐丆丝丟丝丒不, value: out  val_1)) == false)
            {
                    return (object)((七万上丐一丈丏丏专.TryGetValue(key:  下上丐丆丝丟丝丒不, value: out  val_1)) != true) ? (val_1) : 0;
            }
            
            val_5 = val_1;
            return (object)((七万上丐一丈丏丏专.TryGetValue(key:  下上丐丆丝丟丝丒不, value: out  val_1)) != true) ? (val_1) : 0;
        }
        private static 且且丌与专丐一东一()
        {
            null = null;
            Rilisoft.且且丌与专丐一东一.世丒丞七专三与万丕 = new Rilisoft.七丞丞丅东丞专丙丝<Rilisoft.且且丌与专丐一东一>(丙丂丌且丌世丒丐三:  new System.Func<Rilisoft.且且丌与专丐一东一>(object:  且且丌与专丐一东一.<>c.<>9, method:  Rilisoft.且且丌与专丐一东一 且且丌与专丐一东一.<>c::专丛三丑丏丝丝丆业()));
            Rilisoft.且且丌与专丐一东一.下丁一下业下丆不丘 = new System.Collections.Generic.Dictionary<System.String, System.Object>(capacity:  0);
        }
    
    }

}
