using UnityEngine;

namespace Rilisoft
{
    public class ScrollOfferPackDrawer3D : BaseScrollOfferPackDrawer, 丄与且丈丘丄三丗丐
    {
        // Fields
        private Rilisoft.BaseOfferItemCellView 下丕万丒丟丅下业丆;
        private Rilisoft.ScrollOfferPackItemExtendedView _itemExtendedView;
        private UIWidget 丑丗丁世丘丙丝丛丂;
        private UnityEngine.GameObject _leftPlus;
        private UnityEngine.GameObject _positionIndicatorObjectPrototype;
        private UITable _positionIndicatorsTable;
        private UnityEngine.GameObject _rightPlus;
        private System.Threading.CancellationTokenSource 且丈丌东不丐丟东业;
        
        // Properties
        private UIWidget 丑丑丒丑丞世一丞丛 { get; }
        public override int 下丄丈不与世丐业专 { get; }
        
        // Methods
        private UIWidget 丁丝下丙业丝上丅丂()
        {
            UIWidget val_3;
            if(this.丑丗丁世丘丙丝丛丂 == 0)
            {
                    this.丑丗丁世丘丙丝丛丂 = this._itemExtendedView.GetComponent<UIWidget>();
                return val_3;
            }
            
            val_3 = this.丑丗丁世丘丙丝丛丂;
            return val_3;
        }
        public override int get_Id()
        {
            return 3;
        }
        public override bool Show(Rilisoft.业丙丘丆东丈丕丂丄 不专一业下丞丝丑丗, Rilisoft.BonusData 丛丝丙丄七一丁丅三)
        {
            var val_3;
            if((this.Show(不专一业下丞丝丑丗:  不专一业下丞丝丑丗, 丛丝丙丄七一丁丅三:  丛丝丙丄七一丁丅三)) == false)
            {
                goto label_1;
            }
            
            this.丙丁东下不业丗丛丁();
            this.东不丞丂万下三与丕();
            if(丛丝丙丄七一丁丅三.Count != 1)
            {
                goto label_3;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leftPlus, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rightPlus, 丏业丟一东丂东丘丛:  false);
            val_3 = 1;
            return (bool)val_3;
            label_1:
            val_3 = 0;
            return (bool)val_3;
            label_3:
            val_3 = 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._leftPlus, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._rightPlus, 丏业丟一东丂东丘丛:  true);
            return (bool)val_3;
        }
        protected override void Awake()
        {
            var val_12;
            var val_13;
            var val_14;
            this.Awake();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._positionIndicatorObjectPrototype, 丏业丟一东丂东丘丛:  false);
            UIPanel val_1 = this.GetComponent<UIPanel>();
            if(val_1 == 0)
            {
                    return;
            }
            
            float val_13 = val_1.height;
            float val_12 = (float)UnityEngine.Screen.width;
            val_12 = val_12 / (float)UnityEngine.Screen.height;
            val_13 = val_13 * val_12;
            if(val_1 != null)
            {
                    UnityEngine.Vector4 val_6 = val_1.finalClipRegion;
                val_12 = val_6.x;
                UnityEngine.Vector4 val_7 = val_1.finalClipRegion;
                val_13 = val_7.y;
                val_14 = val_1.height;
            }
            else
            {
                    UnityEngine.Vector4 val_9 = val_1.finalClipRegion;
                val_12 = val_9.x;
                UnityEngine.Vector4 val_10 = val_1.finalClipRegion;
                val_13 = val_10.y;
                val_14 = val_1.height;
            }
        
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            this.下丕万丒丟丅下业丆 = 0;
        }
        private void 丙丁东下不业丗丛丁()
        {
            var val_22;
            goto label_1;
            label_8:
            UnityEngine.Transform val_1 = this._positionIndicatorsTable.transform;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._positionIndicatorObjectPrototype, 丈东丘丏与丌东东下:  val_1, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false}), 丏业丟一东丂东丘丛:  true);
            label_1:
            if(this._positionIndicatorsTable.transform.childCount < val_1.Count)
            {
                goto label_8;
            }
            
            goto label_9;
            label_20:
            int val_8 = this._positionIndicatorsTable.transform.childCount;
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this._positionIndicatorsTable.transform.GetChild(index:  val_8 - 1).gameObject);
            label_9:
            if(this._positionIndicatorsTable.transform.childCount > val_8.Count)
            {
                goto label_20;
            }
            
            val_22 = 0;
            goto label_21;
            label_31:
            UnityEngine.Transform val_15 = val_8.transform;
            if(val_15.childCount > val_22)
            {
                    Rilisoft.BaseOfferItemCellView val_20 = this._positionIndicatorsTable.transform.GetChild(index:  0).GetComponent<Rilisoft.BaseOfferItemCellView>();
            }
            
            val_22 = 1;
            label_21:
            if(val_22 < val_15.Item[0].Count)
            {
                goto label_31;
            }
            
            this._positionIndicatorsTable.repositionNow = true;
        }
        protected override void 丈丁丏七丞丑丛东上(Rilisoft.BaseOfferItemCellView 丈丗与丞一上且上上, Rilisoft.BaseOfferItemCellView 专丂丕丗丗东世丞下)
        {
            var val_18;
            if(专丂丕丗丗东世丞下 != 0)
            {
                    this.下丕万丒丟丅下业丆 = 专丂丕丗丗东世丞下;
                if(this.且丈丌东不丐丟东业 != null)
            {
                    this.且丈丌东不丐丟东业.Cancel();
            }
            
                System.Threading.CancellationTokenSource val_2 = new System.Threading.CancellationTokenSource();
                this.且丈丌东不丐丟东业 = val_2;
                System.Threading.CancellationToken val_3 = val_2.Token;
                UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丅丞丏不丄不丁七丛(不丒三业下丑不丞业:  new System.Threading.CancellationToken() {m_source = val_3.m_source}));
            }
            
            val_18 = 0;
            goto label_6;
            label_21:
            Rilisoft.BaseOfferItemCellView val_9 = this._positionIndicatorsTable.transform.GetChild(index:  0).gameObject.GetComponent<Rilisoft.BaseOfferItemCellView>();
            if(val_9 != 0)
            {
                    Rilisoft.OfferItem val_11 = val_9.Item;
                Rilisoft.OfferItem val_12 = 专丂丕丗丗东世丞下.Item;
                var val_15 = (val_9.Item == 专丂丕丗丗东世丞下.Item) ? 1 : 0;
            }
            
            val_18 = 1;
            label_6:
            if(val_18 < this._positionIndicatorsTable.transform.childCount)
            {
                goto label_21;
            }
        
        }
        private System.Collections.IEnumerator 丅丞丏不丄不丁七丛(System.Threading.CancellationToken 不丒三业下丑不丞业)
        {
            ScrollOfferPackDrawer3D.下丒丗丛丝丆丆专丌 val_1 = new ScrollOfferPackDrawer3D.下丒丗丛丝丆丆专丌();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .不丒三业下丑不丞业 = 不丒三业下丑不丞业;
            return (System.Collections.IEnumerator)val_1;
        }
        public ScrollOfferPackDrawer3D()
        {
        
        }
    
    }

}
