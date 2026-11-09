using UnityEngine;

namespace Progress
{
    internal class 丑丑丕丘一三上丕丙 : 丑丌三七不丅万且一
    {
        // Fields
        internal static readonly string 丕丟一七丑丙丂丆丙;
        internal static readonly string 丐丌丞上世丛丐丏丛;
        
        // Properties
        internal override string 丞丘丗丑丏下东三丘 { get; }
        internal override string 丛业丐丈三丏丘世丆 { get; }
        
        // Methods
        internal override int 丈七丞丁丕东丌丄丘()
        {
            return 10;
        }
        internal override string 与丐且丂丆万丛丘丕()
        {
            null = null;
            return (string)Progress.丑丑丕丘一三上丕丙.丕丟一七丑丙丂丆丙;
        }
        internal override string 三丄丈丞一专丝丛丛()
        {
            null = null;
            return (string)Progress.丑丑丕丘一三上丕丙.丐丌丞上世丛丐丏丛;
        }
        internal override bool 丟不下下且业丛丄丏(string 下上丐丆丝丟丝丒不)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((SkinsController.丈丁业下丕上丐与丈.ContainsKey(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不)) == false)
            {
                    return false;
            }
            
            val_4 = null;
            val_4 = null;
            return this.丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  SkinsController.丈丁业下丕上丐与丈.Item[下上丐丆丝丟丝丒不]);
        }
        internal override System.Collections.Generic.List<int> 一丆丞丆上丘万丐不()
        {
            var val_6;
            System.Collections.Generic.IEnumerable<T> val_15;
            var val_16;
            var val_17;
            var val_18;
            System.Collections.Generic.List<System.Int32> val_1 = new System.Collections.Generic.List<System.Int32>();
            val_15 = SkinsController.丂丈与丙丏丁丘三下();
            List.Enumerator<T> val_4 = new System.Collections.Generic.List<System.String>(collection:  val_15).GetEnumerator();
            label_14:
            if(((-1919608064) & 1) == 0)
            {
                goto label_4;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            if(((val_7 == null) || ((System.String.IsNullOrEmpty(value:  val_7)) == true)) || ((丌丝世丞世丛丆丅丟.丑丞丞东丟丒丂上不(丌丘不丆丈丈世万上:  val_7, 丝丒上丑一三丑丐丛:  true)) == false))
            {
                goto label_14;
            }
            
            val_16 = null;
            val_16 = null;
            val_1.Add(item:  SkinsController.丈丁业下丕上丐与丈.Item[val_7]);
            goto label_14;
            label_4:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if(FacebookController.丌丛且丑丈丈丅丗七() == false)
            {
                    return val_1;
            }
            
            val_17 = null;
            val_17 = null;
            val_15 = "super_socialman";
            if((val_1.Contains(item:  SkinsController.丈丁业下丕上丐与丈.Item["super_socialman"])) == true)
            {
                    return val_1;
            }
            
            val_18 = null;
            val_18 = null;
            val_1.Add(item:  SkinsController.丈丁业下丕上丐与丈.Item["super_socialman"]);
            return val_1;
        }
        public 丑丑丕丘一三上丕丙()
        {
        
        }
        private static 丑丑丕丘一三上丕丙()
        {
            Progress.丑丑丕丘一三上丕丙.丕丟一七丑丙丂丆丙 = "Skins_idSlot";
            Progress.丑丑丕丘一三上丕丙.丐丌丞上世丛丐丏丛 = "Skins_idSlot_2018";
        }
    
    }

}
