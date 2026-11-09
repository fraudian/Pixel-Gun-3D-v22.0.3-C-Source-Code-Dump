using UnityEngine;

namespace Rilisoft
{
    public class BuySpecialCurrenciesWindowBase : MonoBehaviour, 丁丝与丅丏且丂丙下, 丈丕丑且丘丘丆东丑
    {
        // Fields
        private static System.Action<bool> 丗一丘丗丌丐丂丟丛;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private UnityEngine.AudioClip _openSound;
        private UnityEngine.GameObject 丅丙与下丈丗丆丞丅;
        
        // Properties
        private UnityEngine.GameObject 上丙丝丆专东七丄丈 { get; }
        public bool 东且世与一东丂一丆 { get; }
        
        // Methods
        public static void add_OnVisibleStateChanged(System.Action<bool> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  Rilisoft.BuySpecialCurrenciesWindowBase.丗一丘丗丌丐丂丟丛, b:  丙业与丙丗丝不丈东);
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
        public static void remove_OnVisibleStateChanged(System.Action<bool> 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  Rilisoft.BuySpecialCurrenciesWindowBase.丗一丘丗丌丐丂丟丛, value:  丙业与丙丗丝不丈东);
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
        private UnityEngine.GameObject 下一丕丆丘丒丕丛丈()
        {
            if(this.丅丙与下丈丗丆丞丅 != 0)
            {
                    return (UnityEngine.GameObject)this.丅丙与下丈丗丆丞丅;
            }
            
            UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "PurchaseProgressIndicator"));
            this.丅丙与下丈丗丆丞丅 = val_3;
            UnityEngine.Transform val_4 = val_3.transform;
            val_4.parent = this.transform;
            val_4.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.identity;
            val_4.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            val_4.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.丅丙与下丈丗丆丞丅, 不东丛三丂丌丑专丆:  this.gameObject.layer);
            return (UnityEngine.GameObject)this.丅丙与下丈丗丆丞丅;
        }
        public bool get___InterfaceEnabled()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void ShowWindow()
        {
        
        }
        public void HideWindow()
        {
            goto typeof(Rilisoft.BuySpecialCurrenciesWindowBase).__il2cppRuntimeField_1A8;
        }
        protected virtual void OnEnable()
        {
            this.丑丂丒上东丙丟丕三();
            new System.Action() = new System.Action(object:  this, method:  typeof(Rilisoft.BuySpecialCurrenciesWindowBase).__il2cppRuntimeField_1B0);
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  0);
            if(this._openSound != 0)
            {
                    if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    this = this._openSound;
                UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this);
            }
            
            }
            
            if(Rilisoft.BuySpecialCurrenciesWindowBase.丗一丘丗丌丐丂丟丛 == null)
            {
                    return;
            }
            
            Rilisoft.BuySpecialCurrenciesWindowBase.丗一丘丗丌丐丂丟丛.Invoke(obj:  true);
        }
        private void 丑丂丒上东丙丟丕三()
        {
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        private void OnDisable()
        {
            this.丑丂丒上东丙丟丕三();
            if(Rilisoft.BuySpecialCurrenciesWindowBase.丗一丘丗丌丐丂丟丛 == null)
            {
                    return;
            }
            
            Rilisoft.BuySpecialCurrenciesWindowBase.丗一丘丗丌丐丂丟丛.Invoke(obj:  false);
        }
        private void Update()
        {
            bool val_4;
            var val_5;
            if(StoreKitEventListener.三丘丈不丝丕丞东丌() != false)
            {
                    val_4 = 1;
            }
            else
            {
                    val_5 = null;
                val_5 = null;
                val_4 = StoreKitEventListener.丌丗丆丟丈丆丝丝丄;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.下一丕丆丘丒丕丛丈(), 丏业丟一东丂东丘丛:  (val_4 == true) ? 1 : 0);
        }
        public virtual void U_Hide()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public BuySpecialCurrenciesWindowBase()
        {
        
        }
    
    }

}
