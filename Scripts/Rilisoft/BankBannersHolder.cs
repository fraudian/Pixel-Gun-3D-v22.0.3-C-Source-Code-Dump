using UnityEngine;

namespace Rilisoft
{
    internal class BankBannersHolder : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private bool _needHideByOnApplicationPause;
        private UnityEngine.Transform content;
        private UnityEngine.GameObject 东一丏七业丙万丞丅;
        public BankBannersHolderInfluencer influencer;
        private readonly System.Collections.Generic.Dictionary<BannerWindowType, UnityEngine.GameObject> 丞丈丞与丐不世一丗;
        
        // Properties
        internal bool 丁东万专丏三不东不 { get; set; }
        public UnityEngine.GameObject 东丄专丑一专丙三丒 { get; }
        
        // Methods
        internal bool 七丑且丒丁不与一丏()
        {
            return (bool)this._needHideByOnApplicationPause;
        }
        internal void 万丙丐丛丟丞专万丏(bool 丙业与丙丗丝不丈东)
        {
            this._needHideByOnApplicationPause = 丙业与丙丗丝不丈东;
        }
        public UnityEngine.GameObject get_CurrentBanner()
        {
            return (UnityEngine.GameObject)this.东一丏七业丙万丞丅;
        }
        private void Update()
        {
            if(this.东一丏七业丙万丞丅 == 0)
            {
                    return;
            }
            
            if(this.东一丏七业丙万丞丅.gameObject == 0)
            {
                    return;
            }
            
            if(this.东一丏七业丙万丞丅.activeSelf != false)
            {
                    return;
            }
            
            this.丝与丒丞丒丛丑世丟(东丅丞丁丗万且丁丗:  false);
        }
        private void OnDisable()
        {
            if(this.influencer != 0)
            {
                    if(this.influencer.CanDisableSelf() == false)
            {
                    return;
            }
            
            }
            
            this.丝与丒丞丒丛丑世丟(东丅丞丁丗万且丁丗:  false);
        }
        private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
        {
            if(丁与丟万丄丒丗专丌 == false)
            {
                    return;
            }
            
            if(this._needHideByOnApplicationPause == false)
            {
                    return;
            }
            
            if(this.influencer != 0)
            {
                    if(this.influencer.CanDisableSelf() == false)
            {
                    return;
            }
            
            }
            
            this.丝与丒丞丒丛丑世丟(东丅丞丁丗万且丁丗:  false);
        }
        private UnityEngine.GameObject 丗丆七丁丟业东东丘(BannerWindowType 丌丅丕一丛丛丄一万)
        {
            UnityEngine.Object val_10;
            if((this.丞丈丞与丐不世一丗.ContainsKey(key:  丌丅丕一丛丛丄一万)) != false)
            {
                    val_10 = this.丞丈丞与丐不世一丗.Item[丌丅丕一丛丛丄一万];
                if(val_10 != 0)
            {
                    return (UnityEngine.GameObject)this.丞丈丞与丐不世一丗.Item[丌丅丕一丛丛丄一万];
            }
            
            }
            
            UnityEngine.Object val_5 = UnityEngine.Resources.Load(path:  "banners/"("banners/") + 丌丅丕一丛丛丄一万);
            if(val_5 != null)
            {
                    var val_6 = (null == null) ? (val_5) : 0;
            }
            else
            {
                    val_10 = 0;
            }
            
            if(val_10 == 0)
            {
                    return (UnityEngine.GameObject)this.丞丈丞与丐不世一丗.Item[丌丅丕一丛丛丄一万];
            }
            
            val_10 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_10);
            this.丞丈丞与丐不世一丗.set_Item(key:  丌丅丕一丛丛丄一万, value:  val_10);
            return (UnityEngine.GameObject)this.丞丈丞与丐不世一丗.Item[丌丅丕一丛丛丄一万];
        }
        public void ShowBanner(BannerWindowType 丌丅丕一丛丛丄一万, System.Func<BannerWindow, bool> 下丒丕丕世三七丕丄, PGCompany.丆下丐丁丏世丈上丟 丌专丟丘一不七丅东)
        {
            UnityEngine.Transform val_21;
            BannerWindow val_22;
            PGCompany.丆下丐丁丏世丈上丟 val_23;
            val_21 = this.content;
            if(val_21 == 0)
            {
                    this.content = this.transform;
            }
            
            UnityEngine.GameObject val_3 = this.丗丆七丁丟业东东丘(丌丅丕一丛丛丄一万:  丌丅丕一丛丛丄一万);
            if(val_3 == 0)
            {
                goto label_6;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  false);
            this.丝与丒丞丒丛丑世丟(东丅丞丁丗万且丁丗:  true);
            this.东一丏七业丙万丞丅 = val_3;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  true);
            this.东一丏七业丙万丞丅.transform.SetParent(p:  this.content);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            this.东一丏七业丙万丞丅.transform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            this.东一丏七业丙万丞丅.transform.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            this.东一丏七业丙万丞丅.transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
            val_21 = this.gameObject.layer;
            System.Collections.Generic.List<System.Int32> val_14 = new System.Collections.Generic.List<System.Int32>();
            val_14.Add(item:  UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket"));
            val_14.Add(item:  UnityEngine.LayerMask.NameToLayer(layerName:  "IndicatorLoading"));
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.东一丏七业丙万丞丅, 不东丛三丂丌丑专丆:  val_21, 三丆丝业且丐三一丕:  val_14);
            val_22 = this.东一丏七业丙万丞丅.GetComponent<BannerWindow>();
            if(下丒丕丕世三七丕丄 != null)
            {
                    UnityEngine.Object val_19 = ((下丒丕丕世三七丕丄.Invoke(arg:  val_22)) != true) ? (val_22) : 0;
            }
            
            if(val_19 != 0)
            {
                goto label_28;
            }
            
            label_6:
            this.丝与丒丞丒丛丑世丟(东丅丞丁丗万且丁丗:  false);
            return;
            label_28:
            if(val_19 != 0)
            {
                    val_23;
                val_19.丟世丛丌丏丙丒丏东(丙业与丙丗丝不丈东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
                return;
            }
            
            val_23;
            0.丟世丛丌丏丙丒丏东(丙业与丙丗丝不丈东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        public void U_HideBanner()
        {
            this.丝与丒丞丒丛丑世丟(东丅丞丁丗万且丁丗:  false);
        }
        public void ClearBackSubscription()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        private void 丝与丒丞丒丛丑世丟(bool 东丅丞丁丗万且丁丗)
        {
            var val_14;
            var val_15;
            if(东丅丞丁丗万且丁丗 == false)
            {
                goto label_1;
            }
            
            if(this.丐丆七且丞丏下三丙 == null)
            {
                goto label_2;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            goto label_6;
            label_1:
            if(this.丐丆七且丞丏下三丙 == null)
            {
                goto label_7;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            goto label_11;
            label_6:
            this.丐丆七且丞丏下三丙.Dispose();
            label_2:
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void Rilisoft.BankBannersHolder::下丁丗丅丌丟三丝业()), 与且专丈不万东一万:  0);
            if((this.东一丏七业丙万丞丅 != 0) && (this.东一丏七业丙万丞丅.gameObject != 0))
            {
                    if(this.东一丏七业丙万丞丅.activeSelf != true)
            {
                    this.丄三不丞世丂丈丆丑();
            }
            
            }
            
            val_14 = this.gameObject;
            val_15 = 1;
            goto label_25;
            label_11:
            this.丐丆七且丞丏下三丙.Dispose();
            label_7:
            this.丄三不丞世丂丈丆丑();
            val_14 = this.gameObject;
            val_15 = 0;
            label_25:
            val_14.SetActive(value:  false);
        }
        private void 丄三不丞世丂丈丆丑()
        {
            if(this.东一丏七业丙万丞丅 == 0)
            {
                    return;
            }
            
            if(this.东一丏七业丙万丞丅.gameObject == 0)
            {
                    return;
            }
            
            if(this.东一丏七业丙万丞丅.gameObject.activeInHierarchy != false)
            {
                    this.东一丏七业丙万丞丅.SetActive(value:  false);
            }
            
            this.东一丏七业丙万丞丅 = 0;
        }
        public BankBannersHolder()
        {
            this._needHideByOnApplicationPause = true;
            this.丞丈丞与丐不世一丗 = new System.Collections.Generic.Dictionary<BannerWindowType, UnityEngine.GameObject>();
        }
        private void 下丁丗丅丌丟三丝业()
        {
            this.丝与丒丞丒丛丑世丟(东丅丞丁丗万且丁丗:  false);
        }
    
    }

}
