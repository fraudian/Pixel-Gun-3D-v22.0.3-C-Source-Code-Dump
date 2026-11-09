using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class LobbyItemsBundlesHandler : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<Rilisoft.LobbyItemsBundle> Bundles;
        
        // Methods
        internal static System.Collections.Generic.List<Rilisoft.LobbyItemsBundle> 一丁丝丂业丌丏下丕()
        {
            UnityEngine.Object val_6;
            var val_7;
            var val_8;
            System.Func<Rilisoft.LobbyItemsBundle, System.Int32> val_10;
            val_6 = UnityEngine.Resources.Load<Rilisoft.LobbyItemsBundlesHandler>(path:  "lobby-items-bundles");
            val_7 = 0;
            if(val_6 == 0)
            {
                    return (System.Collections.Generic.List<Rilisoft.LobbyItemsBundle>)val_7;
            }
            
            val_6 = val_1.Bundles;
            if(val_6 != null)
            {
                    val_8 = null;
                val_8 = null;
                val_10 = LobbyItemsBundlesHandler.<>c.<>9__1_0;
                if(val_10 == null)
            {
                    System.Func<Rilisoft.LobbyItemsBundle, System.Int32> val_3 = null;
                val_10 = val_3;
                val_3 = new System.Func<Rilisoft.LobbyItemsBundle, System.Int32>(object:  LobbyItemsBundlesHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 LobbyItemsBundlesHandler.<>c::七丌丙丞丕丅丑上万(Rilisoft.LobbyItemsBundle 丌丗丏丏丛东专丁且));
                LobbyItemsBundlesHandler.<>c.<>9__1_0 = val_10;
            }
            
                System.Collections.Generic.List<TSource> val_5 = System.Linq.Enumerable.ToList<Rilisoft.LobbyItemsBundle>(source:  System.Linq.Enumerable.OrderBy<Rilisoft.LobbyItemsBundle, System.Int32>(source:  val_6, keySelector:  val_3));
                return (System.Collections.Generic.List<Rilisoft.LobbyItemsBundle>)val_7;
            }
            
            val_7 = 0;
            return (System.Collections.Generic.List<Rilisoft.LobbyItemsBundle>)val_7;
        }
        public LobbyItemsBundlesHandler()
        {
        
        }
    
    }

}
