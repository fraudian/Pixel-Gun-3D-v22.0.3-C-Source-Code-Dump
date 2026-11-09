using UnityEngine;

namespace Rilisoft
{
    internal class GameEventItemsView : MonoBehaviour
    {
        // Fields
        private System.IDisposable 丐丆七且丞丏下三丙;
        private UIGrid _grid;
        private System.Collections.Generic.List<Rilisoft.GameEventItemData> 专丙丌一与业三专丛;
        private UILabel _rewardCountLabel;
        private UIScrollView _scroll;
        private GameEventItemGui _viewPrototype;
        private System.Action 专世丐丂世丞丌且丛;
        
        // Methods
        private void 丘丒丛丌一丐不且丛(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.专世丐丂世丞丌且丛, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专世丐丂世丞丌且丛 != 1152921542838126488);
        
        }
        private void 一且丑上三丕丄丑丛(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.专世丐丂世丞丌且丛, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.专世丐丂世丞丌且丛 != 1152921542838263064);
        
        }
        private void Awake()
        {
            this._viewPrototype.gameObject.SetActive(value:  false);
        }
        private void OnEnable()
        {
            if(this.专丙丌一与业三专丛 != null)
            {
                    this.丂三丗丐丆丌丌丏七();
            }
            
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.GameEventItemsView::Hide()), 与且专丈不万东一万:  0);
        }
        protected virtual void OnDisable()
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
        public void ShowAsReward(System.Action 丌不丞丁七丂万上丏)
        {
            if(this.gameObject.activeSelf != false)
            {
                    return;
            }
            
            this.专世丐丂世丞丌且丛 = 丌不丞丁七丂万上丏;
            this.gameObject.SetActive(value:  true);
            this.丂三丗丐丆丌丌丏七();
        }
        public void SetItems(System.Collections.Generic.List<Rilisoft.GameEventItemData> 丑七不与丛丆一丂丞, bool 丒丄丒丌上丂下专丑 = True)
        {
            this.专丙丌一与业三专丛 = 丑七不与丛丆一丂丞;
        }
        private void 丂三丗丐丆丌丌丏七()
        {
            UIScrollView val_33;
            var val_34;
            var val_35;
            val_33 = this;
            if(this.专丙丌一与业三专丛 == null)
            {
                    return;
            }
            
            val_34 = 1152921504848912384;
            if(this._rewardCountLabel == 0)
            {
                goto label_9;
            }
            
            this._rewardCountLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_3916"), arg0:  this.专丙丌一与业三专丛.Count);
            goto label_9;
            label_29:
            UnityEngine.GameObject val_6 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._viewPrototype.gameObject);
            val_6.transform.SetParent(p:  this._grid.transform);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_6.transform.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.identity;
            val_6.transform.localRotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w};
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.one;
            val_6.transform.localScale = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
            label_9:
            if(this._grid.transform.childCount < this.专丙丌一与业三专丛.Count)
            {
                goto label_29;
            }
            
            goto label_30;
            label_41:
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this._grid.transform.GetChild(index:  this._grid.transform.childCount - 1).gameObject);
            label_30:
            if(this._grid.transform.childCount > this.专丙丌一与业三专丛.Count)
            {
                goto label_41;
            }
            
            val_35 = 0;
            goto label_42;
            label_52:
            Rilisoft.GameEventItemData val_27 = this.专丙丌一与业三专丛.Item[0];
            UnityEngine.Transform val_29 = this._grid.transform.GetChild(index:  0);
            val_34 = val_29.GetComponent<GameEventItemGui>();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_29.gameObject, 丏业丟一东丂东丘丛:  true);
            val_35 = 1;
            label_42:
            if(val_35 < this.专丙丌一与业三专丛.Count)
            {
                goto label_52;
            }
            
            this._scroll.Restrict();
            val_33 = this._scroll;
            val_33.ResetPosition();
        }
        public void Hide()
        {
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  false);
            if(this.专世丐丂世丞丌且丛 == null)
            {
                    return;
            }
            
            this.专世丐丂世丞丌且丛 = 0;
            this.专世丐丂世丞丌且丛.Invoke();
        }
        public GameEventItemsView()
        {
        
        }
    
    }

}
