using UnityEngine;

namespace PGCompany.UpdateBanner
{
    internal sealed class 三世丘三丈丅与七丆
    {
        // Fields
        internal System.Version Version;
        private string <下丑一不且丄丛丑丛>k__BackingField;
        private System.Collections.Generic.Dictionary<string, string> <世丘三万丅丕且丙不>k__BackingField;
        private System.Collections.Generic.Dictionary<string, string> <丈丒丅与丒丑丂下丞>k__BackingField;
        private System.Collections.Generic.List<PGCompany.UpdateBanner.下丕丞丏丘业丏上丙> <万世丟且丏一丛一东>k__BackingField;
        
        // Properties
        internal string BackgroundImageName { get; set; }
        internal System.Collections.Generic.Dictionary<string, string> TitleTextTable { get; set; }
        internal System.Collections.Generic.Dictionary<string, string> MainTextTable { get; set; }
        internal System.Collections.Generic.List<PGCompany.UpdateBanner.下丕丞丏丘业丏上丙> Blocks { get; set; }
        internal string 丞七丒丆丆丘丒丙丝 { get; }
        internal string 丅丙世丘七与上丅丞 { get; }
        internal UnityEngine.Texture 丂丟丁万丗三世七与 { get; }
        
        // Methods
        internal string 与丙丂丛丗不与丐丛()
        {
            return (string)this.<下丑一不且丄丛丑丛>k__BackingField;
        }
        internal void 丝丌不丛三丄丈丐一(string 丙业与丙丗丝不丈东)
        {
            this.<下丑一不且丄丛丑丛>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.Dictionary<string, string> 丟与丈丕万丑丂丝丐()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)this.<世丘三万丅丕且丙不>k__BackingField;
        }
        internal void 丂七上丈丟与丝丞上(System.Collections.Generic.Dictionary<string, string> 丙业与丙丗丝不丈东)
        {
            this.<世丘三万丅丕且丙不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.Dictionary<string, string> 七丈上七丗丒丌丅与()
        {
            return (System.Collections.Generic.Dictionary<System.String, System.String>)this.<丈丒丅与丒丑丂下丞>k__BackingField;
        }
        internal void 丄东七丐丅丛丕不丗(System.Collections.Generic.Dictionary<string, string> 丙业与丙丗丝不丈东)
        {
            this.<丈丒丅与丒丑丂下丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal System.Collections.Generic.List<PGCompany.UpdateBanner.下丕丞丏丘业丏上丙> 丑丁丑丅丞且丙丝丌()
        {
            return (System.Collections.Generic.List<PGCompany.UpdateBanner.下丕丞丏丘业丏上丙>)this.<万世丟且丏一丛一东>k__BackingField;
        }
        internal void 丆丏万丅丈丗且丗丆(System.Collections.Generic.List<PGCompany.UpdateBanner.下丕丞丏丘业丏上丙> 丙业与丙丗丝不丈东)
        {
            this.<万世丟且丏一丛一东>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal string 业丈丂丌丏一一丕上()
        {
            int val_4;
            string val_2 = 0;
            bool val_3 = this.<世丘三万丅丕且丙不>k__BackingField.TryGetValue(key:  丟丏下丂七三下丗丕.丂丁不世且丑丘丅七(), value: out  val_2);
            val_4 = val_2;
            if(val_4 != 0)
            {
                    return (string)val_4;
            }
            
            val_4 = System.String.alignConst;
            return (string)val_4;
        }
        internal string 丒一丞万丆丟丙不丌()
        {
            int val_4;
            string val_2 = 0;
            bool val_3 = this.<丈丒丅与丒丑丂下丞>k__BackingField.TryGetValue(key:  丟丏下丂七三下丗丕.丂丁不世且丑丘丅七(), value: out  val_2);
            val_4 = val_2;
            if(val_4 != 0)
            {
                    return (string)val_4;
            }
            
            val_4 = System.String.alignConst;
            return (string)val_4;
        }
        internal UnityEngine.Texture 且丐业丒丘丈丙丟丝()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "LoadingSeason/loading_active");
        }
        public 三世丘三丈丅与七丆()
        {
        
        }
    
    }

}
