using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丈丑丟丏丏与丟丙且
    {
        // Fields
        private static readonly Rilisoft.丈丑丟丏丏与丟丙且 世丒丞七专三与万丕;
        private readonly System.Collections.Generic.HashSet<string> 业专丟专丆万万七东;
        private readonly System.Collections.Generic.Dictionary<string, float> 且七东丐万且丘世一;
        private System.Nullable<System.TimeSpan> 丛丏丕丁七丝三三七;
        
        // Properties
        internal static Rilisoft.丈丑丟丏丏与丟丙且 丆丕丝丒不丙且丐丗 { get; }
        internal System.TimeSpan 东业丆丆丏丛丆专丈 { get; set; }
        private static System.TimeSpan 丝丏专不世丂且丏万 { get; }
        
        // Methods
        internal static Rilisoft.丈丑丟丏丏与丟丙且 丑七不且上丗丁一世()
        {
            null = null;
            return (Rilisoft.丈丑丟丏丏与丟丙且)Rilisoft.丈丑丟丏丏与丟丙且.世丒丞七专三与万丕;
        }
        internal System.TimeSpan 上与丈丛世丝业丗专()
        {
            if(( & 1) != 0)
            {
                    string val_1 = this.丛丏丕丁七丝三三七.丐丏七丌丕丗业且上();
                return (System.TimeSpan)val_2._ticks;
            }
            
            System.TimeSpan val_2 = Rilisoft.丈丑丟丏丏与丟丙且.丐丐下丌一丕丗一上();
            return (System.TimeSpan)val_2._ticks;
        }
        internal void 一丄丗一丕丏丛下丒(System.TimeSpan 丙业与丙丗丝不丈东)
        {
            this.丛丏丕丁七丝三三七 = 0;
            mem[1152921542343203672] = 0;
        }
        private static System.TimeSpan 丐丐下丌一丕丗一上()
        {
            if(UnityEngine.Application.isEditor == false)
            {
                    return System.TimeSpan.FromMinutes(value:  15);
            }
            
            return System.TimeSpan.FromSeconds(value:  15);
        }
        internal bool 业一三不七丘与丑一(string 丑三丅丒丕丗三丏丁)
        {
            var val_8;
            if((System.String.IsNullOrEmpty(value:  丑三丅丒丕丗三丏丁)) != false)
            {
                    val_8 = 0;
                return (bool)val_8;
            }
            
            System.Nullable<System.Single> val_2 = this.世三丕丅丂丑丒丄世(丑三丅丒丕丗三丏丁:  丑三丅丒丕丗三丏丁);
            if(((-918132952) & 1) != 0)
            {
                    System.TimeSpan val_4 = this.上与丈丛世丝业丗专();
                var val_7 = (val_4._ticks.TotalSeconds <= ((double)UnityEngine.Time.realtimeSinceStartup - UnityEngine.Time.realtimeSinceStartup)) ? 1 : 0;
                return (bool)val_8;
            }
            
            val_8 = 1;
            return (bool)val_8;
        }
        internal System.Nullable<float> 世三丕丅丂丑丒丄世(string 丑三丅丒丕丗三丏丁)
        {
            var val_3;
            if(丑三丅丒丕丗三丏丁 != null)
            {
                    if((this.且七东丐万且丘世一.TryGetValue(key:  丑三丅丒丕丗三丏丁, value: out  float val_1 = -820489.8f)) != false)
            {
                    val_3 = 0;
                return (System.Nullable<System.Single>)val_3;
            }
            
            }
            
            val_3 = 0;
            return (System.Nullable<System.Single>)val_3;
        }
        internal void 丂专东丝丛丘丙丅东(string 丑三丅丒丕丗三丏丁, float 一丏一世丘丐丁丄丟)
        {
            if(丑三丅丒丕丗三丏丁 == null)
            {
                    return;
            }
            
            this.且七东丐万且丘世一.set_Item(key:  丑三丅丒丕丗三丏丁, value:  一丏一世丘丐丁丄丟);
        }
        internal System.Collections.Generic.IEnumerable<string> 业丆丙丆东上丛三丅()
        {
            return (System.Collections.Generic.IEnumerable<System.String>)this.业专丟专丆万万七东;
        }
        internal void 三上丕丌万丑丝丟与()
        {
            this.业专丟专丆万万七东.Clear();
        }
        internal void 世东丟世丂丝丟专业(string 丑三丅丒丕丗三丏丁, string 丛三三与丁丘丄丑下)
        {
            if((System.String.IsNullOrEmpty(value:  丑三丅丒丕丗三丏丁)) == true)
            {
                    return;
            }
            
            if((System.String.IsNullOrEmpty(value:  丛三三与丁丘丄丑下)) != false)
            {
                    return;
            }
            
            bool val_3 = this.业专丟专丆万万七东.Add(item:  丑三丅丒丕丗三丏丁);
            InfoWindowController.丑七不且上丗丁一世().丏丞丌上丏丁丛一一(三丕业丛丛丙专专丙:  丛三三与丁丘丄丑下);
        }
        public 丈丑丟丏丏与丟丙且()
        {
            this.业专丟专丆万万七东 = new System.Collections.Generic.HashSet<System.String>();
            this.且七东丐万且丘世一 = new System.Collections.Generic.Dictionary<System.String, System.Single>();
        }
        private static 丈丑丟丏丏与丟丙且()
        {
            Rilisoft.丈丑丟丏丏与丟丙且.世丒丞七专三与万丕 = new Rilisoft.丈丑丟丏丏与丟丙且();
        }
    
    }

}
