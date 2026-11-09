using UnityEngine;

namespace Rilisoft
{
    public class 一专丑丂丛丄与上丁 : 丈上丛丕业丂丕丝世
    {
        // Fields
        private static bool <丙丙丅上丗东丗三丞>k__BackingField;
        
        // Properties
        internal static bool 丝丟丙丝丝一丌丟丈 { get; set; }
        
        // Methods
        public 一专丑丂丛丄与上丁(Rilisoft.丆专且丆世丟丄与丂 丌万且丕丕业上丈丞)
        {
        
        }
        internal static bool 七丞丌丅丝业不与下()
        {
            return (bool)Rilisoft.一专丑丂丛丄与上丁.<丙丙丅上丗东丗三丞>k__BackingField;
        }
        private static void 丑一上丛丟丙丆丙与(bool 丙业与丙丗丝不丈东)
        {
            Rilisoft.一专丑丂丛丄与上丁.<丙丙丅上丗东丗三丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public override System.Collections.IEnumerator 三业丒丑丂三丕上丛(bool 丟东丈丗丏丛世万一, bool 且丏下一下上丟与丐)
        {
            一专丑丂丛丄与上丁.三丈丐丈丞丙业世丙 val_1 = new 一专丑丂丛丄与上丁.三丈丐丈丞丙业世丙();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丟东丈丗丏丛世万一 = 丟东丈丗丏丛世万一;
            }
            else
            {
                    mem[40] = this;
                mem[48] = 丟东丈丗丏丛世万一;
            }
            
            .且丏下一下上丟与丐 = 且丏下一下上丟与丐;
            return (System.Collections.IEnumerator)val_1;
        }
        private static Rilisoft.AchievementProgressSyncObject 专丑丘丌丆丏丁丞丅()
        {
            return (Rilisoft.AchievementProgressSyncObject)new Rilisoft.AchievementProgressSyncObject(丕丞且丂丒丄东不丘:  System.Linq.Enumerable.ToList<Rilisoft.AchievementProgressData>(source:  Rilisoft.AchievementsManager.丏三不丐丛丕丛丝丝()));
        }
        private static void 丈丁不丙丝三三专下(Rilisoft.AchievementProgressSyncObject 丝世丄下丁与万上一)
        {
            Rilisoft.AchievementProgressSyncObject val_7 = 丝世丄下丁与万上一;
            Rilisoft.一专丑丂丛丄与上丁.<丙丙丅上丗东丗三丞>k__BackingField = true;
            if(Rilisoft.AchievementsManager.Instance == 0)
            {
                    return;
            }
            
            Progress.丛丂丅丄丘丞丕丅丂 val_3 = Progress.七七世万专丕丁上业.万东下东一丄三丝且();
            val_3.丂专丌下丈与丕三丘 = val_7.ProgressData;
            Progress.丛丂丅丄丘丞丕丅丂 val_5 = Progress.七七世万专丕丁上业.万东下东一丄三丝且();
            val_7 = Rilisoft.AchievementsManager.Instance;
            val_7.丒丟丛丅丈不一业三();
            Rilisoft.一专丑丂丛丄与上丁.<丙丙丅上丗东丗三丞>k__BackingField = false;
        }
    
    }

}
