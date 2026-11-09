using UnityEngine;

namespace PGCompany.BattlePass
{
    internal static class 丒丂丆丏丐一丞丄七
    {
        // Fields
        internal static readonly int 丗丆七一万世世且三;
        internal static readonly int 丌与丅丌丒丅丄丆丁;
        internal static readonly int 丛丄世丞丒丐丂丛专;
        internal static readonly string 一丈丈丞丒丗丟丘丄;
        private static bool 丛世丁且丁上东丏丝;
        
        // Properties
        internal static bool 丏上丄东丙上万丘万 { get; set; }
        
        // Methods
        internal static bool 且丑丟一七不一与丑()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(PGCompany.BattlePass.丒丂丆丏丐一丞丄七.丛世丁且丁上东丏丝 != false)
            {
                    var val_2 = (PGCompany.BattlePass.万丈上下三丅丘丛丒.丂不丄与丅丑万丏业() > 0) ? 1 : 0;
                return (bool)val_4;
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        internal static void 丄一丐丂与丐且丘世(bool 丙业与丙丗丝不丈东)
        {
            null = null;
            PGCompany.BattlePass.丒丂丆丏丐一丞丄七.丛世丁且丁上东丏丝 = 丙业与丙丗丝不丈东;
        }
        internal static bool 丏万一丕三下丒丗三()
        {
            var val_15;
            int val_16;
            var val_17;
            int val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            val_15 = null;
            val_15 = null;
            val_16 = 1152921505683361792;
            val_17 = null;
            val_18 = MainMenuController.与不丒下丕丐万丗丞;
            val_17 = null;
            if((val_18 < PGCompany.BattlePass.丒丂丆丏丐一丞丄七.丗丆七一万世世且三) || ((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0))
            {
                goto label_27;
            }
            
            val_19 = null;
            val_19 = null;
            int val_2 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  PGCompany.BattlePass.丒丂丆丏丐一丞丄七.一丈丈丞丒丗丟丘丄, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
            if(val_2 < 1)
            {
                goto label_13;
            }
            
            val_20 = null;
            val_20 = null;
            val_18 = (long)val_2;
            System.TimeSpan val_3 = System.TimeSpan.FromHours(value:  (double)PGCompany.BattlePass.丒丂丆丏丐一丞丄七.丛丄世丞丒丐丂丛专);
            long val_15 = (long)val_3._ticks.TotalSeconds;
            val_15 = val_15 + val_18;
            if(val_15 > FriendsController.丝丗专上三不丄丑丑())
            {
                goto label_27;
            }
            
            label_13:
            val_18 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_18 == null)
            {
                    return (bool)val_21;
            }
            
            val_22 = null;
            val_22 = null;
            val_16 = val_18.丄且东且丕丛与丆丒();
            val_18 = val_18.丞丆丝七丛世且丒专(丈丘丝一丗下丈丐不:  UnityEngine.Mathf.Min(a:  PGCompany.BattlePass.丒丂丆丏丐一丞丄七.丌与丅丌丒丅丄丆丁 + val_18.业丈丅丂且丁与丄丂(), b:  val_16));
            if(val_18 >= 1)
            {
                    var val_14 = (PGCompany.BattlePass.万丈上下三丅丘丛丒.丂不丄与丅丑万丏业() >= val_18) ? 1 : 0;
                return (bool)val_21;
            }
            
            label_27:
            val_21 = 0;
            return (bool)val_21;
        }
        private static 丒丂丆丏丐一丞丄七()
        {
            PGCompany.BattlePass.丒丂丆丏丐一丞丄七.丗丆七一万世世且三 = 2;
            PGCompany.BattlePass.丒丂丆丏丐一丞丄七.丌与丅丌丒丅丄丆丁 = 2;
            PGCompany.BattlePass.丒丂丆丏丐一丞丄七.丛丄世丞丒丐丂丛专 = 24;
            PGCompany.BattlePass.丒丂丆丏丐一丞丄七.一丈丈丞丒丗丟丘丄 = "BattlePassReminderGiveRewardsUI_LastShowTimestamp";
        }
    
    }

}
