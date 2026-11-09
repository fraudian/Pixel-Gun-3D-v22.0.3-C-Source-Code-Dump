using UnityEngine;

namespace Rilisoft
{
    internal class 三丄丄与且与丂万与
    {
        // Fields
        private static Rilisoft.丛丞丛丑丑万世丛万 丂万不丙上丄丐丑丞;
        
        // Properties
        internal static Rilisoft.丛丞丛丑丑万世丛万 丛丞丛丑丑万世丛万 { get; }
        
        // Methods
        internal static Rilisoft.丛丞丛丑丑万世丛万 丌丁丐丒业丅丙丝丁()
        {
            System.Byte[] val_11;
            Rilisoft.丛丞丛丑丑万世丛万 val_12;
            HiddenSettings val_13;
            System.Exception val_14;
            val_12 = Rilisoft.三丄丄与且与丂万与.丂万不丙上丄丐丑丞;
            if(val_12 != null)
            {
                    return val_12;
            }
            
            if(MiscAppsMenu.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_13 = mem[MiscAppsMenu.丆丕丝丒不丙且丐丗 + 24];
                val_13 = MiscAppsMenu.丆丕丝丒不丙且丐丗.misc;
            }
            else
            {
                    val_13 = 0;
            }
            
            if(val_13 == 0)
            {
                    UnityEngine.Debug.LogError(message:  "Settings are null.");
                val_11 = new byte[40];
            }
            else
            {
                    val_11 = System.Convert.FromBase64String(s:  val_13.PersistentCacheManagerKey);
            }
            
            val_14 = System.Math.Min(val1:  val_7.Length, val2:  val_5.Length);
            if(val_14 != 0)
            {
                    do
            {
                long val_13 = 0;
                val_13 = val_13 + 1;
                mem2[0] = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().丒丆专上下东丟丆丛()[val_13] ^ val_11[val_13];
            }
            while(val_14 != val_13);
            
            }
            
            Rilisoft.三丄丄与且与丂万与.丂万不丙上丄丐丑丞 = new Rilisoft.丛丞丛丑丑万世丛万(丅丄三丅丑丑丞且万:  val_11);
            val_12 = Rilisoft.三丄丄与且与丂万与.丂万不丙上丄丐丑丞;
            return val_12;
        }
        internal static void 丟下三不一丌三三丟(string 下上丐丆丝丟丝丒不)
        {
            上七丈七三七七且丛.丟下三不一丌三三丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            Rilisoft.三丄丄与且与丂万与.丌丁丐丒业丅丙丝丁().丟下三不一丌三三丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
        }
        internal static int 与上万业专丘三丅万(string 下上丐丆丝丟丝丒不)
        {
            int val_12;
            string val_2 = Rilisoft.三丄丄与且与丂万与.丌丁丐丒业丅丙丝丁().丒丙丝丆丄丆丄且专(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            if((System.String.IsNullOrEmpty(value:  val_2)) == false)
            {
                    return (int)((System.Int32.TryParse(s:  val_2, style:  111, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  0)) != true) ? 0 : 0;
            }
            
            int val_4 = 上七丈七三七七且丛.与上万业专丘三丅万(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 专不三上丏专丄且丞:  0);
            Rilisoft.三丄丄与且与丂万与.丌丁丐丒业丅丙丝丁().丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丙业与丙丗丝不丈东:  val_4.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
            val_12 = val_4;
            return (int)((System.Int32.TryParse(s:  val_2, style:  111, provider:  System.Globalization.CultureInfo.InvariantCulture, result: out  0)) != true) ? 0 : 0;
        }
        internal static string 丒丙丝丆丄丆丄且专(string 下上丐丆丝丟丝丒不)
        {
            if((Rilisoft.三丄丄与且与丂万与.丌丁丐丒业丅丙丝丁().丌丟三丘世下与丆丘(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不)) != false)
            {
                    Rilisoft.丛丞丛丑丑万世丛万 val_3 = Rilisoft.三丄丄与且与丂万与.丌丁丐丒业丅丙丝丁();
                if(val_3 != null)
            {
                    return val_3.丒丙丝丆丄丆丄且专(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            }
            
                return val_3.丒丙丝丆丄丆丄且专(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            }
            
            string val_4 = 上七丈七三七七且丛.丒丙丝丆丄丆丄且专(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 专不三上丏专丄且丞:  "");
            Rilisoft.三丄丄与且与丂万与.丌丁丐丒业丅丙丝丁().丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丙业与丙丗丝不丈东:  val_4);
            return val_4;
        }
        internal static bool 丌丟三丘世下与丆丘(string 下上丐丆丝丟丝丒不)
        {
            if((Rilisoft.三丄丄与且与丂万与.丌丁丐丒业丅丙丝丁().丌丟三丘世下与丆丘(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不)) == false)
            {
                    return 上七丈七三七七且丛.丌丟三丘世下与丆丘(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不);
            }
            
            return true;
        }
        internal static void 丂丟丝与上丌丆丅东(string 下上丐丆丝丟丝丒不, int 下下丏一丙不丘丌丞)
        {
            Rilisoft.三丄丄与且与丂万与.丌丁丐丒业丅丙丝丁().丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丙业与丙丗丝不丈东:  下下丏一丙不丘丌丞.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture));
        }
        internal static void 丞丅丁与丞丒丗下丟(string 下上丐丆丝丟丝丒不, string 下下丏一丙不丘丌丞)
        {
            Rilisoft.三丄丄与且与丂万与.丌丁丐丒业丅丙丝丁().丞丅丁与丞丒丗下丟(下上丐丆丝丟丝丒不:  下上丐丆丝丟丝丒不, 丙业与丙丗丝不丈东:  下下丏一丙不丘丌丞);
        }
        internal static void 丂且不业丂专丛丆东()
        {
            UnityEngine.PlayerPrefs.Save();
        }
        public 三丄丄与且与丂万与()
        {
        
        }
    
    }

}
