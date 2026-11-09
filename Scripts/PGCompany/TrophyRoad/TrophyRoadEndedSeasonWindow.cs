using UnityEngine;

namespace PGCompany.TrophyRoad
{
    internal sealed class TrophyRoadEndedSeasonWindow : PGBehaviour
    {
        // Fields
        private System.Action 丛丄业丘不丆丄三丞;
        private UnityEngine.GameObject _holder;
        private WidgetLayout _widgetLayout;
        private PGCompany.TrophyRoad.TrophyRoadSlotCell _prefabCell;
        private UnityEngine.GameObject _rewardContainer;
        private PGCompany.InventoryItemView _rewardItemView;
        private System.Collections.Generic.List<PGCompany.TrophyRoad.TrophyRoadSlotCell> 丁丕丛丏丕丈下丗丑;
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Methods
        internal void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛丄业丘不丆丄三丞 != 1152921559544121848);
        
        }
        internal void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丛丄业丘不丆丄三丞 != 1152921559544258424);
        
        }
        internal bool 丅业东万丌丕上丌丄()
        {
            if(this._holder == 0)
            {
                    return false;
            }
            
            if(this._holder != null)
            {
                    return this._holder.activeSelf;
            }
            
            return this._holder.activeSelf;
        }
        internal void 下与丞三丅丛丄七丕(System.Action 丞丟万丝七丁丈丌丝)
        {
            this.丛丄业丘不丆丄三丞 = 丞丟万丝七丁丈丌丝;
            System.Collections.Generic.List<PGCompany.TrophyRoad.丑与丅下丂丑丌业专> val_2 = PGCompany.丗丌一丌丗丑丌丄丈.丑七不且上丗丁一世().丙万丕丘上丅一且丑();
            if(val_2 != null)
            {
                    if(val_2.Count != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  true);
                this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.TrophyRoad.TrophyRoadEndedSeasonWindow::三专丛丁丌下丏世丟()), 与且专丈不万东一万:  0);
                this.丌丅丅下丗下专丌丏(丙丌丅丆丑丙丗丅不:  val_2);
                this.丙丐丅丁丈上丕丝丝();
                return;
            }
            
            }
            
            this.丆世与丑丆丅丐万且();
        }
        public void U_Hide()
        {
            this.丆世与丑丆丅丐万且();
        }
        private void 丆世与丑丆丅丐万且()
        {
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_2 = 0;
                val_2 = val_2 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._holder, 丏业丟一东丂东丘丛:  false);
            if(this.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            this.丛丄业丘不丆丄三丞.Invoke();
        }
        private void 三专丛丁丌下丏世丟()
        {
        
        }
        private void 丙丐丅丁丈上丕丝丝()
        {
            PGCompany.三东丏不丗世丅丌丄 val_2 = PGCompany.TrophyRoad.与丂三专且丅万世一.丑七不且上丗丁一世().丙下丕丗东与上七丒();
            if(val_2 != null)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rewardContainer, 丏业丟一东丂东丘丛:  true);
                if(this._rewardItemView == 0)
            {
                    return;
            }
            
                this._rewardItemView.Setup(丈丄不七三万丄丁不:  val_2);
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rewardContainer, 丏业丟一东丂东丘丛:  false);
        }
        private void 丌丅丅下丗下专丌丏(System.Collections.Generic.List<PGCompany.TrophyRoad.丑与丅下丂丑丌业专> 丙丌丅丆丑丙丗丅不)
        {
            var val_8;
            this.丑一丘丁丌丛三丙丄(丌丒丝东丌下丕丁丅:  丙丌丅丆丑丙丗丅不.Count);
            val_8 = 0;
            goto label_2;
            label_12:
            if(丙丌丅丆丑丙丗丅不.Item[0] != null)
            {
                    this.丁丕丛丏丕丈下丗丑.Item[0].gameObject.SetActive(value:  true);
                this.丁丕丛丏丕丈下丗丑.Item[0].丈且东丑丂且万丒丅(上丙丙丒丏下世与丂:  丙丌丅丆丑丙丗丅不.Item[0]);
            }
            
            val_8 = 1;
            label_2:
            if(val_8 < 丙丌丅丆丑丙丗丅不.Count)
            {
                goto label_12;
            }
            
            this._widgetLayout.CollectWidgets();
            this._widgetLayout.Reposition();
        }
        private void 丑一丘丁丌丛三丙丄(int 丌丒丝东丌下丕丁丅)
        {
            int val_14;
            var val_15;
            System.Collections.Generic.List<PGCompany.TrophyRoad.TrophyRoadSlotCell> val_16;
            val_14 = 丌丒丝东丌下丕丁丅;
            if(this.丁丕丛丏丕丈下丗丑.Count <= val_14)
            {
                goto label_2;
            }
            
            val_15 = 1152921559545176080;
            goto label_3;
            label_8:
            this.丁丕丛丏丕丈下丗丑.Item[val_14].gameObject.SetActive(value:  false);
            val_14 = val_14 + 1;
            label_3:
            val_16 = this.丁丕丛丏丕丈下丗丑;
            if(val_14 < val_16.Count)
            {
                goto label_8;
            }
            
            return;
            label_2:
            val_16 = this.丁丕丛丏丕丈下丗丑;
            if(val_16.Count >= val_14)
            {
                    return;
            }
            
            val_16 = this.丁丕丛丏丕丈下丗丑;
            int val_7 = val_14 - val_16.Count;
            if(val_7 < 1)
            {
                    return;
            }
            
            val_15 = 1152921504848912384;
            do
            {
                PGCompany.TrophyRoad.TrophyRoadSlotCell val_9 = UnityEngine.Object.Instantiate<PGCompany.TrophyRoad.TrophyRoadSlotCell>(original:  this._prefabCell, parent:  this._widgetLayout.transform);
                UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
                val_9.transform.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
                UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.identity;
                val_9.transform.rotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
                this.丁丕丛丏丕丈下丗丑.Add(item:  val_9);
                val_16 = this._widgetLayout;
                val_16.AddElement(世丌丌丙丞丟下东丞:  val_9._widget);
                val_7 = val_7 - 1;
            }
            while(val_7 != 0);
        
        }
        public TrophyRoadEndedSeasonWindow()
        {
            this.丁丕丛丏丕丈下丗丑 = new System.Collections.Generic.List<PGCompany.TrophyRoad.TrophyRoadSlotCell>();
        }
    
    }

}
