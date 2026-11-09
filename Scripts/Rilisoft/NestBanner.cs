using UnityEngine;

namespace Rilisoft
{
    public class NestBanner : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private Rilisoft.TextGroup _conditionText;
        private PGCompany.EggIncubatorProgress 丛且丞丛丙丂东丄万;
        private Rilisoft.TextGroup _eggNameText;
        private UnityEngine.Renderer _eggRenderer;
        private Rilisoft.TextGroup _headerText;
        private UnityEngine.GameObject _touchBlock;
        private UnityEngine.GameObject _window;
        private static System.Action 丄丑上丕丂丈丘丙七;
        
        // Properties
        public bool 七七业丒丟丝丘不丞 { get; }
        
        // Methods
        public bool get_IsVisible()
        {
            if(this._window != null)
            {
                    return this._window.activeInHierarchy;
            }
            
            return this._window.activeInHierarchy;
        }
        internal static void 丘万丟丕业不万丂丁(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  Rilisoft.NestBanner.丄丑上丕丂丈丘丙七, b:  丙业与丙丗丝不丈东);
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
        internal static void 丅七丅丐丗丛一丑丁(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  Rilisoft.NestBanner.丄丑上丕丂丈丘丙七, value:  丙业与丙丗丝不丈东);
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
        internal void 下与丞三丅丛丄七丕(PGCompany.EggIncubatorProgress 三万万丒丏丒不丐丙)
        {
        
        }
        private void 且不丅万丕丙丕丆且(PGCompany.丆七丗丂世丞丗丙三 丝丘三万上世丑丑丂, object 丙业与丙丗丝不丈东)
        {
        
        }
        public void Hide()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
                this.丐丆七且丞丏下三丙 = 0;
            }
            
            this.丛且丞丛丙丂东丄万 = 0;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._window, 丏业丟一东丂东丘丛:  false);
            if(Rilisoft.NestBanner.丄丑上丕丂丈丘丙七 == null)
            {
                    return;
            }
            
            Rilisoft.NestBanner.丄丑上丕丂丈丘丙七.Invoke();
        }
        public void EnableTouchBlocker(bool 丝三丄专丗丞丄丄丌)
        {
            丝三丄专丗丞丄丄丌 = 丝三丄专丗丞丄丄丌;
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._touchBlock, 丏业丟一东丂东丘丛:  丝三丄专丗丞丄丄丌);
        }
        public NestBanner()
        {
        
        }
    
    }

}
