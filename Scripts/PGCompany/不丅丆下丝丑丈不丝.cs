using UnityEngine;

namespace PGCompany
{
    internal static class 不丅丆下丝丑丈不丝
    {
        // Methods
        internal static bool 三丛不丈丈丆三丘丝(out byte[] 丞丘丐丑万下丒丅丅, out string 丏丞专丏业丗丝七丝)
        {
            MiscAppsMenu val_6;
            string val_7;
            val_6 = MiscAppsMenu.丆丕丝丒不丙且丐丗;
            if(val_6 != 0)
            {
                goto label_3;
            }
            
            val_7 = "MiscAppsMenu.Instance: null";
            goto label_8;
            label_3:
            val_6 = mem[MiscAppsMenu.丆丕丝丒不丙且丐丗 + 24];
            val_6 = MiscAppsMenu.丆丕丝丒不丙且丐丗.misc;
            if(null == 0)
            {
                goto label_6;
            }
            
            if((System.String.IsNullOrWhiteSpace(value:  PersistentCacheManagerKey)) == false)
            {
                goto label_7;
            }
            
            val_7 = "settings.PersistentCacheManagerKey: IsNullOrWhiteSpace";
            goto label_8;
            label_6:
            val_7 = "MiscAppsMenu.Instance.misc: null";
            label_8:
            丞丘丐丑万下丒丅丅 = 0;
            label_11:
            丏丞专丏业丗丝七丝 = val_7;
            return false;
            label_7:
            丞丘丐丑万下丒丅丅 = System.Convert.FromBase64String(s:  PersistentCacheManagerKey);
            goto label_11;
        }
        internal static bool 丂万丅丕三与丕丞一(out byte[] 丕丛丏丈丆万七丕万, out string 丏丞专丏业丗丝七丝)
        {
            string val_5;
            丕丛丏丈丆万七丕万 = System.Array.Empty<System.Byte>();
            if(UnityEngine.Application.platform == 11)
            {
                    val_5 = 0;
                丕丛丏丈丆万七丕万 = Rilisoft.丅丒三丐不丏业丛万.丑七不且上丗丁一世().丒丆专上下东丟丆丛();
            }
            else
            {
                    val_5 = 0;
            }
            
            丏丞专丏业丗丝七丝 = val_5;
            return true;
        }
        internal static bool 丁丂专丝丑丗丅业丑(string 业与丑上丒丐且丕丂, out string 丏丞专丏业丗丝七丝)
        {
            丏丞专丏业丗丝七丝 = 业与丑上丒丐且丕丂;
            return false;
        }
        internal static bool 丁丂专丝丑丗丅业丑(out byte[] 丝丆丁丞丛三丁丑丙)
        {
            丝丆丁丞丛三丁丑丙 = 0;
            return false;
        }
        internal static bool 丁丂专丝丑丗丅业丑(string 业与丑上丒丐且丕丂, out byte[] 丝丆丁丞丛三丁丑丙, out string 丏丞专丏业丗丝七丝)
        {
            丝丆丁丞丛三丁丑丙 = 0;
            丏丞专丏业丗丝七丝 = 业与丑上丒丐且丕丂;
            return false;
        }
    
    }

}
