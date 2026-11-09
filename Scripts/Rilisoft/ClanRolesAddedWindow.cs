using UnityEngine;

namespace Rilisoft
{
    public class ClanRolesAddedWindow : MonoBehaviour
    {
        // Fields
        private static Rilisoft.且丈丞一丞丟与上七 下丟丌丐丛丛上丟丈;
        private static Rilisoft.ClanRolesAddedWindow 丝业丆丁业三丈丟东;
        private System.IDisposable 丄丘业与丈丛丛丝世;
        private static System.Action 丛丄业丘不丆丄三丞;
        
        // Properties
        internal static bool 丕世一与业丅万专丑 { get; }
        
        // Methods
        internal static bool 丌七丘七丗下丐七丞()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(Rilisoft.ClanRolesAddedWindow.下丟丌丐丛丛上丟丈.世三丞丅丑丌丈丈一() == 1)
            {
                    return false;
            }
            
            val_3 = null;
            val_3 = null;
            return UnityEngine.Object.op_Equality(x:  Rilisoft.ClanRolesAddedWindow.丝业丆丁业三丈丟东, y:  0);
        }
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.ClanRolesAddedWindow.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.ClanRolesAddedWindow.丛丄业丘不丆丄三丞 != 1152921505435070480);
        
        }
        internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.ClanRolesAddedWindow.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.ClanRolesAddedWindow.丛丄业丘不丆丄三丞 != 1152921505435070480);
        
        }
        internal static void 下与丞三丅丛丄七丕(UnityEngine.Transform 丆丏七丟不丒与七专)
        {
            UnityEngine.Object val_9;
            var val_10;
            var val_11;
            val_9 = 丆丏七丟不丒与七专;
            if(val_9 == 0)
            {
                    return;
            }
            
            val_10 = null;
            val_10 = null;
            if(Rilisoft.ClanRolesAddedWindow.丝业丆丁业三丈丟东 != 0)
            {
                    return;
            }
            
            UnityEngine.GameObject val_3 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/Clan/ClanRankSystem");
            if(val_3 == 0)
            {
                    return;
            }
            
            int val_5 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            val_9 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_3, 丈东丘丏与丌东东下:  val_9, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            val_11 = null;
            val_11 = null;
            Rilisoft.ClanRolesAddedWindow.丝业丆丁业三丈丟东 = val_9.GetComponent<Rilisoft.ClanRolesAddedWindow>();
            if(Rilisoft.ClanRolesAddedWindow.丝业丆丁业三丈丟东 == 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  val_9);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  true);
        }
        private void OnDestroy()
        {
            null = null;
            Rilisoft.ClanRolesAddedWindow.丝业丆丁业三丈丟东 = 0;
        }
        private void OnEnable()
        {
            if(this.丄丘业与丈丛丛丝世 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丄丘业与丈丛丛丝世.Dispose();
            }
            
            this.丄丘业与丈丛丛丝世 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.ClanRolesAddedWindow::Hide()), 与且专丈不万东一万:  0);
        }
        private void OnDisable()
        {
            if(this.丄丘业与丈丛丛丝世 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丄丘业与丈丛丛丝世.Dispose();
        }
        public void Hide()
        {
            null = null;
            Rilisoft.ClanRolesAddedWindow.下丟丌丐丛丛上丟丈.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  1);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.gameObject);
            if(Rilisoft.ClanRolesAddedWindow.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            0.Invoke();
        }
        public void U_Back()
        {
            this.Hide();
        }
        public ClanRolesAddedWindow()
        {
        
        }
        private static ClanRolesAddedWindow()
        {
            Rilisoft.ClanRolesAddedWindow.下丟丌丐丛丛上丟丈 = new Rilisoft.且丈丞一丞丟与上七(丟东丟丑丕丄丂丟丙:  "ClanRolesAddedWindow-viewed");
        }
    
    }

}
