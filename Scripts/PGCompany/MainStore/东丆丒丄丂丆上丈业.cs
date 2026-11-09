using UnityEngine;

namespace PGCompany.MainStore
{
    internal sealed class 东丆丒丄丂丆上丈业 : 下丐丒丙丂丁丗丘丘
    {
        // Fields
        private static System.Action 丐专丈万丈丏丈业丌;
        internal System.Collections.Generic.List<PGCompany.MainStore.七丄不下丘丏一丂丌> 不丌东东丌丞丙专丝;
        
        // Properties
        internal int 万丄丅丛下丐丒丞上 { get; }
        internal int 上丁丐三三业业丌丘 { get; }
        internal int 丘丝丑丆丒上丝丛丐 { get; }
        internal bool 与与丈丈丁丂丞丐丏 { get; }
        internal bool 且三一业丆丐丟丟丂 { get; }
        internal bool 丞丁七丁丌与且丆上 { get; }
        internal int 丟与丁丅丝丒下万丙 { get; }
        
        // Methods
        internal static void 丕丝万丂丆丁万下丗(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.MainStore.东丆丒丄丂丆上丈业.丐专丈万丈丏丈业丌, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丞丆丐丝一丞一世东(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.MainStore.东丆丒丄丂丆上丈业.丐专丈万丈丏丈业丌, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal int 丈一下下丞世三丑丄()
        {
            PGCompany.StorePromotionSettings val_2 = this.世丈丁业丛上丘丗丐().Settings;
        }
        internal int 丏丆丑下七丕丗丞丌()
        {
            PGCompany.StorePromotionSettings val_2 = this.世丈丁业丛上丘丗丐().Settings;
            if(val_2.CollectProgress != null)
            {
                    return val_2.CollectProgress.From;
            }
            
            return val_2.CollectProgress.From;
        }
        internal int 丈与专丘丝丕丈丌丟()
        {
            PGCompany.StorePromotionSettings val_2 = this.世丈丁业丛上丘丗丐().Settings;
            if(val_2.CollectProgress != null)
            {
                    return val_2.CollectProgress.To;
            }
            
            return val_2.CollectProgress.To;
        }
        internal bool 丂且与丈且丁专丟丐()
        {
            Progress.丅丝丐三且丘丝上专 val_1 = Progress.七七世万专丕丁上业.业且丛专丟丛丄丗丛();
            if(val_1 != null)
            {
                    return val_1.丂与万丘丘丂下与丌();
            }
            
            return val_1.丂与万丘丘丂下与丌();
        }
        internal bool 丂丕且七丆下丄不丘()
        {
            PGCompany.Piggy.业世且丐丕专丛专丐 val_1 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丂丕且七丆下丄不丘();
            }
            
            return val_1.丂丕且七丆下丄不丘();
        }
        internal bool 丝一丞不丝上丆丄丅()
        {
            Progress.丅丝丐三且丘丝上专 val_1 = Progress.七七世万专丕丁上业.业且丛专丟丛丄丗丛();
            if(val_1 != null)
            {
                    return val_1.一丑丑丞丙三七丂上();
            }
            
            return val_1.一丑丑丞丙三七丂上();
        }
        internal int 丌业万不丟东一丂丄()
        {
            PGCompany.Piggy.业世且丐丕专丛专丐 val_1 = PGCompany.Piggy.业世且丐丕专丛专丐.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丌业万不丟东一丂丄();
            }
            
            return val_1.丌业万不丟东一丂丄();
        }
        internal 东丆丒丄丂丆上丈业(PGCompany.StorePromotionConfig 上世丏丁世丟世丆业, PGCompany.DataObjects.专丅一丄上丗且丑一 且万丄丏专丄丛丌丗)
        {
            this.不丌东东丌丞丙专丝 = new System.Collections.Generic.List<PGCompany.MainStore.七丄不下丘丏一丂丌>();
            this.且上丒三一万丄丛丑();
            PGCompany.Piggy.业世且丐丕专丛专丐.丐丏三万丐且丗专世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.MainStore.东丆丒丄丂丆上丈业::且上丒三一万丄丛丑()));
        }
        private void 且上丒三一万丄丛丑()
        {
            var val_4;
            this.不丌东东丌丞丙专丝.Clear();
            List.Enumerator<T> val_2 = this.丝世丑七丂丄丅专不().GetEnumerator();
            label_13:
            if(((-609092608) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            string val_6 = val_5 + 32;
            val_7.下丐丐丁与丂下世七.Add(item:  val_5);
            val_7.丐与下丁丁丞三丒与 = Progress.七七世万专丕丁上业.业且丛专丟丛丄丗丛().丐丙上丂不丏丕丞丟().Contains(item:  val_6);
            this.不丌东东丌丞丙专丝.Add(item:  this.丟丌丟丒七与丈与下(丈丘丝一丗下丈丐不:  val_6));
            goto label_13;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if(PGCompany.MainStore.东丆丒丄丂丆上丈业.丐专丈万丈丏丈业丌 == null)
            {
                    return;
            }
            
            PGCompany.MainStore.东丆丒丄丂丆上丈业.丐专丈万丈丏丈业丌.Invoke();
        }
        private PGCompany.MainStore.七丄不下丘丏一丂丌 丟丌丟丒七与丈与下(int 丈丘丝一丗下丈丐不)
        {
            var val_4;
            List.Enumerator<T> val_1 = this.不丌东东丌丞丙专丝.GetEnumerator();
            label_4:
            if(((-608935496) & 1) == 0)
            {
                goto label_2;
            }
            
            val_4 = 0.丐丏七丌丕丗业且上();
            if(val_2.m_stringLength != 丈丘丝一丗下丈丐不)
            {
                goto label_4;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (PGCompany.MainStore.七丄不下丘丏一丂丌)val_4;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.MainStore.七丄不下丘丏一丂丌 val_3 = null;
            val_4 = val_3;
            val_3 = new PGCompany.MainStore.七丄不下丘丏一丂丌();
            .万丄丅丛下丐丒丞上 = 丈丘丝一丗下丈丐不;
            return (PGCompany.MainStore.七丄不下丘丏一丂丌)val_4;
        }
    
    }

}
