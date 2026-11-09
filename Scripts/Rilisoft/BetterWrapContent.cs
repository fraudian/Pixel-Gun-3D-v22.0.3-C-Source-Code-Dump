using UnityEngine;

namespace Rilisoft
{
    public class BetterWrapContent : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject 世丘下下丕丑东世专;
        private int 丈丗丝万万丞丐上业;
        private int _index;
        private int _itemSize;
        private System.Func<int> 上丟不丒丟丘丄丗七;
        private UIPanel 丗丒丟下丕丆丗丆丈;
        private UIScrollView 下七丅一且丂丒专丕;
        private UnityEngine.Coroutine 万丘丂丗世三不丅丕;
        private bool _setCellsOnAwake;
        public int ExtendCellsCount;
        public float ScrollTime;
        public bool ToCenterIfPossible;
        private System.Action<UnityEngine.GameObject, int> 丂上下丟丕东丁丛不;
        private bool <专世丅丁上丝三丈与>k__BackingField;
        
        // Properties
        internal int 下三与不专丏丌上万 { get; }
        internal UIPanel 丆丐且丛丒三丗三世 { get; }
        internal UIScrollView 上丛不专丂丐丝丛一 { get; }
        private int 丟丘丁丝丐且不三丅 { get; }
        public int 与丈丝与与丂丕丅丁 { get; }
        private int 世丁丕丏丐丟丑且丞 { get; }
        private int 丞丞丁与丆世丄上丛 { get; }
        public bool 丐丘丐且业三丑丅丈 { get; set; }
        
        // Methods
        internal int 上且东万七丘下东丂()
        {
            return (int)this._itemSize;
        }
        internal UIPanel 专丘东丁丆与丒世丝()
        {
            return (UIPanel)this.丗丒丟下丕丆丗丆丈;
        }
        internal UIScrollView 丂三专丂丂下丙丆丏()
        {
            return (UIScrollView)this.下七丅一且丂丒专丕;
        }
        private int 丛丝丑东七丒丒丅业()
        {
            if(this.上丟不丒丟丘丄丗七 == null)
            {
                    return (int)this.上丟不丒丟丘丄丗七;
            }
            
            return this.上丟不丒丟丘丄丗七.Invoke();
        }
        public int get_VisibleCellsCount()
        {
            if(this.下七丅一且丂丒专丕.movement == 1)
            {
                    float val_1 = this.丗丒丟下丕丆丗丆丈.height;
            }
            else
            {
                    float val_2 = this.丗丒丟下丕丆丗丆丈.width;
            }
            
            val_2 = val_2 / (float)this._itemSize;
            return (int)(int)val_2;
        }
        private int 丈丟丅丌丙丄丆丏丌()
        {
            int val_1 = this.VisibleCellsCount;
            val_1 = this.ExtendCellsCount + val_1;
            return (int)val_1;
        }
        private int 丗丐丁三七一丝丘七()
        {
            var val_3;
            if((this.丈丗丝万万丞丐上业 & 2147483648) == 0)
            {
                    val_3 = (this.VisibleCellsCount + this.丈丗丝万万丞丐上业) + this.ExtendCellsCount;
                return (int)val_3;
            }
            
            val_3 = 0;
            return (int)val_3;
        }
        public void add_OnUpdateCell(System.Action<UnityEngine.GameObject, int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丂上下丟丕东丁丛不, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丂上下丟丕东丁丛不 != 1152921543577552704);
        
        }
        public void remove_OnUpdateCell(System.Action<UnityEngine.GameObject, int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丂上下丟丕东丁丛不, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丂上下丟丕东丁丛不 != 1152921543577689280);
        
        }
        private void Awake()
        {
            this.Initialize();
            if(this._setCellsOnAwake == false)
            {
                    return;
            }
            
            if(UnityEngine.Application.isEditor != false)
            {
                    return;
            }
            
            this.ResetCells();
        }
        public bool get_IsInitialized()
        {
            return (bool)this.<专世丅丁上丝三丈与>k__BackingField;
        }
        private void 东丐丝七丞世丅丘一(bool 丙业与丙丗丝不丈东)
        {
            this.<专世丅丁上丝三丈与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Initialize()
        {
            UIPanel val_2 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIPanel>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
            this.丗丒丟下丕丆丗丆丈 = val_2;
            UIScrollView val_3 = val_2.GetComponent<UIScrollView>();
            this.下七丅一且丂丒专丕 = val_3;
            UIPanel val_4 = val_3.GetComponent<UIPanel>();
            val_4.onClipMove = new UIPanel.上丟丟且丁且丅丏丆(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.BetterWrapContent::业丟业丆丒业丆丒三(UIPanel 丛丘下丗业丂一且业));
            if(this.丗丒丟下丕丆丗丆丈 == 0)
            {
                    return;
            }
            
            if(this.下七丅一且丂丒专丕 == 0)
            {
                    return;
            }
            
            this.<专世丅丁上丝三丈与>k__BackingField = true;
        }
        public void Initialize(System.Func<int> 下丛一丂不丕东万丐, System.Action<UnityEngine.GameObject, int> 丆丄丟东专与且丂业)
        {
            this.Initialize();
            this.上丟不丒丟丘丄丗七 = 下丛一丂不丕东万丐;
            this.remove_OnUpdateCell(丙业与丙丗丝不丈东:  丆丄丟东专与且丂业);
            this.add_OnUpdateCell(丙业与丙丗丝不丈东:  丆丄丟东专与且丂业);
            this.ResetCells();
        }
        public void AligmentToCenterIfPossible()
        {
            var val_24;
            var val_25;
            var val_26;
            int val_27;
            float val_28;
            var val_32;
            val_24 = this;
            val_25 = 0;
            val_26 = 0;
            goto label_0;
            label_7:
            val_26 = val_26 + (this.gameObject.transform.GetChild(index:  0).gameObject.activeSelf);
            val_25 = 1;
            label_0:
            val_27 = this.gameObject.transform;
            if(val_25 < val_27.childCount)
            {
                goto label_7;
            }
            
            if(val_26 >= this.VisibleCellsCount)
            {
                    return;
            }
            
            if(this.下七丅一且丂丒专丕.movement == 1)
            {
                    UnityEngine.Vector3 val_13 = this.transform.localPosition;
                val_28 = val_13.x;
                val_27 = this._itemSize;
                val_24 = this.transform;
                UnityEngine.Vector3 val_16 = val_24.localPosition;
                var val_17 = (val_27 < 0) ? (val_27 + 1) : (val_27);
                val_17 = val_17 >> 1;
                float val_24 = 0.5f;
                val_17 = val_17 * val_26;
                val_24 = this.丗丒丟下丕丆丗丆丈.height * val_24;
                val_32 = val_24 - (float)val_17;
            }
            else
            {
                    val_28 = this.丗丒丟下丕丆丗丆丈.width;
                val_27 = this.transform;
                UnityEngine.Vector3 val_20 = val_27.localPosition;
                val_24 = this.transform;
                UnityEngine.Vector3 val_22 = val_24.localPosition;
                var val_23 = (this._itemSize < 0) ? (this._itemSize + 1) : this._itemSize;
                val_23 = val_23 >> 1;
                float val_25 = 0.5f;
                val_23 = val_23 * val_26;
                val_25 = val_28 * val_25;
                val_25 = val_25 - (float)val_23;
                val_32 = val_20.y;
            }
            
            this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public void ResetCells()
        {
            System.Action<UnityEngine.GameObject, System.Int32> val_35;
            var val_39;
            var val_40;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            int val_5 = this.gameObject.transform.childCount;
            if(val_5 < 1)
            {
                    return;
            }
            
            this.世丘下下丕丑东世专 = this.transform.GetChild(index:  0).gameObject;
            丞东丑专丛丆丄丝世.丒丑东世丛不上丈丛(七万上丐一丈丏丏专:  this.gameObject, 丌丝三丌丗丄丌丈且:  true, 与丐丌万丁丒不业丕:  false, 丈与丗且丐专一一丌:  true);
            int val_38 = this.ExtendCellsCount;
            val_38 = val_38 + this.VisibleCellsCount;
            if(val_5 <= val_38)
            {
                goto label_11;
            }
            
            val_35 = 1152921543578688800;
            goto label_12;
            label_18:
            UnityEngine.GameObject val_13 = System.Linq.Enumerable.Last<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this.gameObject));
            if(val_13 != null)
            {
                    val_13.SetActive(value:  false);
            }
            else
            {
                    val_13.SetActive(value:  false);
            }
            
            val_13.transform.SetParent(p:  0);
            UnityEngine.Object.Destroy(obj:  val_13);
            label_12:
            int val_39 = this.ExtendCellsCount;
            val_39 = val_39 + this.VisibleCellsCount;
            if((System.Linq.Enumerable.Count<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this.gameObject))) > val_39)
            {
                goto label_18;
            }
            
            goto label_20;
            label_11:
            int val_40 = this.ExtendCellsCount;
            val_40 = val_40 + this.VisibleCellsCount;
            if(val_5 >= val_40)
            {
                goto label_20;
            }
            
            val_35 = 1152921505093320704;
            goto label_21;
            label_25:
            UnityEngine.GameObject val_22 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.gameObject, 丑且不丕与专丄业丙:  this.世丘下下丕丑东世专.gameObject);
            label_21:
            int val_41 = this.ExtendCellsCount;
            val_41 = val_41 + this.VisibleCellsCount;
            if((System.Linq.Enumerable.Count<UnityEngine.GameObject>(source:  Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this.gameObject))) < val_41)
            {
                goto label_25;
            }
            
            label_20:
            this.丆丞丒丘专丙专丛丆();
            this.丈丗丝万万丞丐上业 = 0;
            var val_42 = 0;
            val_42 = val_42 + 1;
            System.Collections.Generic.IEnumerator<T> val_30 = Unity.Linq.丅丆万丟丐丏丏下丄.丅丅丙上三丏丌丞三(丈丆上丅丘世专丑丕:  this.gameObject).GetEnumerator();
            goto label_31;
            label_50:
            var val_43 = 0;
            val_43 = val_43 + 1;
            T val_32 = val_30.Current;
            if(this.丛丝丑东七丒丒丅业() < 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_32, 丏业丟一东丂东丘丛:  false);
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_32, 丏业丟一东丂东丘丛:  true);
                val_35 = this.丂上下丟丕东丁丛不;
                if(val_35 != null)
            {
                    val_35.Invoke(arg1:  val_32.gameObject, arg2:  0);
            }
            
            }
            
            label_31:
            var val_44 = 0;
            val_44 = val_44 + 1;
            if(val_30.MoveNext() == true)
            {
                goto label_50;
            }
            
            val_39 = 0;
            val_40 = 0;
            if(val_30 == null)
            {
                
            }
            else
            {
                    var val_45 = 0;
                val_45 = val_45 + 1;
                val_30.Dispose();
            }
            
            this.下七丅一且丂丒专丕.Restrict();
            this.下七丅一且丂丒专丕.ResetPosition();
            if(this.ToCenterIfPossible == false)
            {
                    return;
            }
            
            this.AligmentToCenterIfPossible();
        }
        private void 丆丞丒丘专丙专丛丆()
        {
            var val_8;
            float val_9;
            val_8 = 0;
            goto label_0;
            label_8:
            UnityEngine.Transform val_2 = this.transform.GetChild(index:  0);
            UnityEngine.Vector3 val_3 = val_2.localPosition;
            if(this.下七丅一且丂丒专丕.movement == 1)
            {
                    val_9 = (float)this._itemSize * 0;
            }
            else
            {
                    int val_5 = this._itemSize * val_8;
                val_9 = 0f;
            }
            
            val_2.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_8 = 1;
            label_0:
            if(val_8 < this.transform.childCount)
            {
                goto label_8;
            }
        
        }
        private void 世与世丛丐丗丝丒丁()
        {
            this.ScrollTo(丘丒丌下丕专且七专:  this._index, 与丑丑丑丂丛一丝一:  false);
        }
        public System.Collections.Generic.List<UnityEngine.GameObject> GetAllCellsObjects()
        {
            var val_7;
            System.Collections.Generic.List<UnityEngine.GameObject> val_1 = new System.Collections.Generic.List<UnityEngine.GameObject>();
            val_7 = 0;
            goto label_1;
            label_6:
            val_1.Add(item:  this.transform.GetChild(index:  0).gameObject);
            val_7 = 1;
            label_1:
            if(val_7 < this.transform.childCount)
            {
                goto label_6;
            }
            
            return val_1;
        }
        private UnityEngine.Vector3 丐丆丒一丒丑丁丕丝(int 一丆丈东万丙丞丕下)
        {
            UIPanel val_46;
            var val_47;
            var val_48;
            float val_50;
            val_46 = this;
            if((一丆丈东万丙丞丕下 & 2147483648) != 0)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            if(this.丛丝丑东七丒丒丅业() < 一丆丈东万丙丞丕下)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            val_47 = 1152921504838422528;
            val_48 = UnityEngine.Mathf.Max(a:  0, b:  (this.丛丝丑东七丒丒丅业() + 1) - this.VisibleCellsCount);
            var val_7 = (val_48 > 一丆丈东万丙丞丕下) ? 一丆丈东万丙丞丕下 : (val_48);
            UnityEngine.Vector4 val_8 = this.丗丒丟下丕丆丗丆丈.finalClipRegion;
            if(this.下七丅一且丂丒专丕.movement == 1)
            {
                    UnityEngine.Vector4 val_9 = this.丗丒丟下丕丆丗丆丈.finalClipRegion;
                UnityEngine.Transform val_11 = this.transform.GetChild(index:  0);
                if(val_11 == 0)
            {
                    return UnityEngine.Vector3.zero;
            }
            
                UnityEngine.Vector3 val_13 = val_11.localPosition;
                float val_46 = (float)this._itemSize;
                val_46 = val_13.y / val_46;
                val_48 = UnityEngine.Mathf.Abs(value:  UnityEngine.Mathf.RoundToInt(f:  val_46));
                float val_47 = 0.5f;
                int val_17 = val_11.GetComponent<UIWidget>().height;
                val_47 = val_9.w * val_47;
                UnityEngine.Vector3 val_18 = val_11.localPosition;
                val_47 = val_8.y + val_47;
                UnityEngine.Vector3 val_20 = this.transform.localPosition;
                UnityEngine.Vector2 val_21 = this.丗丒丟下丕丆丗丆丈.clipSoftness;
                int val_49 = this._itemSize;
                float val_48 = (float)((val_17 < 0) ? (val_17 + 1) : (val_17)) >> 1;
                val_48 = val_18.y + val_48;
                val_48 = val_48 + val_20.y;
                val_48 = val_48 - val_47;
                val_49 = val_49 * (val_7 - val_48);
                val_48 = val_48 + val_21.y;
                val_50 = (float)val_49 - val_48;
                UnityEngine.Vector3 val_25 = UnityEngine.Vector3.up;
                return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, d:  val_50 = val_50 + (float)(int)val_44.x);
            }
            
            UnityEngine.Vector4 val_26 = this.丗丒丟下丕丆丗丆丈.finalClipRegion;
            UnityEngine.Transform val_28 = this.transform.GetChild(index:  0);
            if(val_28 == 0)
            {
                    return UnityEngine.Vector3.zero;
            }
            
            UnityEngine.Vector3 val_30 = val_28.localPosition;
            float val_50 = (float)this._itemSize;
            val_50 = val_30.x / val_50;
            val_47 = UnityEngine.Mathf.Abs(value:  UnityEngine.Mathf.RoundToInt(f:  val_50));
            float val_51 = -0.5f;
            int val_34 = val_28.GetComponent<UIWidget>().width;
            val_51 = val_26.z * val_51;
            UnityEngine.Vector3 val_35 = val_28.localPosition;
            val_51 = val_8.x + val_51;
            UnityEngine.Vector3 val_37 = this.transform.localPosition;
            UnityEngine.Vector2 val_38 = this.丗丒丟下丕丆丗丆丈.clipSoftness;
            var val_39 = (val_34 < 0) ? (val_34 + 1) : (val_34);
            int val_53 = this._itemSize;
            val_39 = val_39 >> 1;
            float val_52 = (float)val_39;
            val_52 = val_35.x - val_52;
            val_52 = val_52 + val_37.x;
            val_53 = val_53 * (val_47 - val_7);
            val_52 = val_52 - val_51;
            val_38.x = val_52 - val_38.x;
            val_50 = (float)val_53 - val_38.x;
            if(val_48 <= 一丆丈东万丙丞丕下)
            {
                    var val_54 = 1;
                val_54 = val_54 - val_7;
                val_48 = (val_54 + this.丛丝丑东七丒丒丅业()) * this._itemSize;
                UnityEngine.Vector4 val_43 = this.丗丒丟下丕丆丗丆丈.finalClipRegion;
                val_46 = this.丗丒丟下丕丆丗丆丈;
                UnityEngine.Vector2 val_44 = val_46.clipSoftness;
                val_44.x = val_43.z + val_44.x;
                if(val_44.x > (float)val_48)
            {
                    val_44.x = val_44.x - (float)val_48;
            }
            
            }
            
            UnityEngine.Vector3 val_45 = UnityEngine.Vector3.right;
            return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_45.x, y = val_45.y, z = val_45.z}, d:  val_50);
        }
        public void ScrollTo(int 丘丒丌下丕专且七专, bool 与丑丑丑丂丛一丝一 = False)
        {
            var val_12;
            var val_13;
            if(this.万丘丂丗世三不丅丕 != null)
            {
                    this.StopCoroutine(routine:  this.万丘丂丗世三不丅丕);
            }
            
            丞东丑专丛丆丄丝世.不不丏专丟丆丕丛丗(丄丑三东丘丆丂丟丙:  this.下七丅一且丂丒专丕);
            val_12 = 0;
            val_13 = 0;
            goto label_4;
            label_11:
            val_13 = val_13 + (this.gameObject.transform.GetChild(index:  0).gameObject.activeSelf);
            val_12 = 1;
            label_4:
            if(val_12 < this.gameObject.transform.childCount)
            {
                goto label_11;
            }
            
            if(val_13 < this.VisibleCellsCount)
            {
                    this.ResetCells();
                return;
            }
            
            UnityEngine.Vector3 val_11 = this.丐丆丒一丒丑丁丕丝(一丆丈东万丙丞丕下:  丘丒丌下丕专且七专);
            if(this.下七丅一且丂丒专丕 == null)
            {
                
            }
        
        }
        private System.Collections.IEnumerator 丐丛丟丅丝七业丛丞(float 专丂丕丗丗东世丞下, float 七不丞世丁丝业丌专)
        {
            BetterWrapContent.世丌业丌且不七与下 val_1 = new BetterWrapContent.世丌业丌且不七与下();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .专丂丕丗丗东世丞下 = 专丂丕丗丗东世丞下;
            }
            else
            {
                    mem[32] = this;
                mem[40] = 专丂丕丗丗东世丞下;
            }
            
            .七不丞世丁丝业丌专 = 七不丞世丁丝业丌专;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 业丟业丆丒业丆丒三(UIPanel 丛丘下丗业丂一且业)
        {
            this.万丞且丒丗丙丂世丝();
        }
        private void 万丞且丒丗丙丂世丝()
        {
            float val_57;
            var val_58;
            System.Action<UnityEngine.GameObject, System.Int32> val_59;
            var val_60;
            float val_62;
            var val_63;
            int val_64;
            int val_65;
            var val_69;
            int val_70;
            var val_71;
            UnityEngine.GameObject val_72;
            var val_76;
            float val_4 = ((float)this.transform.childCount * this._itemSize) * 0.5f;
            var val_51 = 0;
            UIPanel val_5 = this.丗丒丟下丕丆丗丆丈 + 40;
            do
            {
                UnityEngine.Vector3 val_7 = this.transform.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = 2.766919E-21f, y = 2.766919E-21f, z = 2.766919E-21f});
                val_51 = val_51 + 1;
                mem2[0] = val_7.x;
                mem2[0] = val_7.y;
                mem2[0] = val_7.z;
            }
            while(val_51 != 4);
            
            if(this.下七丅一且丂丒专丕.movement != 1)
            {
                goto label_9;
            }
            
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B}, t:  0.5f);
            val_57 = val_8.y;
            val_58 = this.transform.GetChild(index:  0);
            val_59 = this.transform.GetChild(index:  this.transform.childCount - 1);
            UnityEngine.Vector3 val_16 = val_58.localPosition;
            UnityEngine.Vector3 val_17 = val_59.localPosition;
            if((val_16.y - val_57) <= val_4)
            {
                goto label_19;
            }
            
            if((this.丈丗丝万万丞丐上业 & 2147483648) != 0)
            {
                goto label_20;
            }
            
            val_60 = (this.VisibleCellsCount + this.丈丗丝万万丞丐上业) + this.ExtendCellsCount;
            goto label_21;
            label_9:
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B}, t:  0.5f);
            val_57 = val_21.x;
            val_58 = this.transform.GetChild(index:  0);
            val_59 = this.transform.GetChild(index:  this.transform.childCount - 1);
            UnityEngine.Vector3 val_29 = val_58.localPosition;
            UnityEngine.Vector3 val_30 = val_59.localPosition;
            val_62 = val_57 - val_29.x;
            if(val_62 <= val_4)
            {
                goto label_31;
            }
            
            if((this.丈丗丝万万丞丐上业 & 2147483648) != 0)
            {
                goto label_32;
            }
            
            val_63 = (this.VisibleCellsCount + this.丈丗丝万万丞丐上业) + this.ExtendCellsCount;
            goto label_33;
            label_19:
            if((val_17.y - val_57) >= 0)
            {
                    return;
            }
            
            int val_52 = this.丈丗丝万万丞丐上业;
            val_52 = val_52 - 1;
            if((val_52 & 2147483648) != 0)
            {
                    return;
            }
            
            val_59.SetAsFirstSibling();
            if(val_58 == null)
            {
                goto label_37;
            }
            
            UnityEngine.Vector3 val_34 = val_58.localPosition;
            val_57 = val_34.x;
            goto label_38;
            label_31:
            val_30.x = val_30.x - val_57;
            if(val_30.x <= val_4)
            {
                    return;
            }
            
            int val_53 = this.丈丗丝万万丞丐上业;
            val_53 = val_53 - 1;
            if((val_53 & 2147483648) != 0)
            {
                    return;
            }
            
            val_59.SetAsFirstSibling();
            if(val_58 == null)
            {
                goto label_42;
            }
            
            UnityEngine.Vector3 val_35 = val_58.localPosition;
            val_64 = this._itemSize;
            val_57 = val_35.x;
            goto label_43;
            label_20:
            val_60 = 0;
            label_21:
            if(val_60 > this.丛丝丑东七丒丒丅业())
            {
                    return;
            }
            
            if(val_58 == null)
            {
                goto label_45;
            }
            
            val_58.SetAsLastSibling();
            goto label_46;
            label_32:
            val_63 = 0;
            label_33:
            if(val_63 > this.丛丝丑东七丒丒丅业())
            {
                    return;
            }
            
            val_58.SetAsLastSibling();
            if(val_59 == null)
            {
                goto label_49;
            }
            
            UnityEngine.Vector3 val_38 = val_59.localPosition;
            val_65 = this._itemSize;
            val_57 = val_38.x;
            goto label_50;
            label_45:
            0.SetAsLastSibling();
            label_46:
            UnityEngine.Vector3 val_39 = val_58.localPosition;
            val_57 = val_39.x;
            UnityEngine.Vector3 val_40 = val_59.localPosition;
            val_69 = val_40.y - (float)this._itemSize;
            goto label_52;
            label_49:
            UnityEngine.Vector3 val_41 = 0.localPosition;
            val_65 = this._itemSize;
            val_57 = val_41.x;
            label_50:
            UnityEngine.Vector3 val_42 = val_59.localPosition;
            float val_54 = (float)val_65;
            val_54 = val_57 + val_54;
            label_52:
            val_58.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            int val_55 = this.丈丗丝万万丞丐上业;
            val_59 = this.丂上下丟丕东丁丛不;
            val_55 = val_55 + 1;
            this.丈丗丝万万丞丐上业 = val_55;
            if(val_59 == null)
            {
                    return;
            }
            
            if((this.丈丗丝万万丞丐上业 & 2147483648) == 0)
            {
                    int val_56 = this.ExtendCellsCount;
                val_56 = (this.丈丗丝万万丞丐上业 + this.VisibleCellsCount) + val_56;
                val_70 = val_56 - 1;
            }
            else
            {
                    val_70 = -2;
            }
            
            val_71 = 1152921543578747184;
            val_72 = val_58.gameObject;
            goto label_58;
            label_37:
            UnityEngine.Vector3 val_46 = 0.localPosition;
            val_57 = val_46.x;
            label_38:
            UnityEngine.Vector3 val_47 = val_58.localPosition;
            val_76 = val_47.y + (float)this._itemSize;
            goto label_59;
            label_42:
            UnityEngine.Vector3 val_48 = 0.localPosition;
            val_64 = this._itemSize;
            val_57 = val_48.x;
            label_43:
            UnityEngine.Vector3 val_49 = val_58.localPosition;
            float val_57 = (float)val_64;
            val_57 = val_57 - val_57;
            label_59:
            val_59.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            int val_58 = this.丈丗丝万万丞丐上业;
            val_58 = val_58 - 1;
            this.丈丗丝万万丞丐上业 = val_58;
            if(this.丂上下丟丕东丁丛不 == null)
            {
                    return;
            }
            
            val_70 = this.丈丗丝万万丞丐上业;
            val_71 = 1152921543578747184;
            val_72 = val_59.gameObject;
            label_58:
            this.丂上下丟丕东丁丛不.Invoke(arg1:  val_72, arg2:  val_70);
        }
        public void UpdateVisibleCells()
        {
            var val_9 = 0;
            goto label_1;
            label_8:
            if(this.丂上下丟丕东丁丛不 != null)
            {
                    this.丂上下丟丕东丁丛不.Invoke(arg1:  this.gameObject.transform.GetChild(index:  0).gameObject, arg2:  val_9 + this.丈丗丝万万丞丐上业);
            }
            
            val_9 = 1;
            label_1:
            if(val_9 < this.gameObject.transform.childCount)
            {
                goto label_8;
            }
        
        }
        public BetterWrapContent()
        {
            this.丈丗丝万万丞丐上业 = 17179869183;
            this._index = 3;
            this._itemSize = 100;
            this._setCellsOnAwake = true;
            this.ExtendCellsCount = 2;
            this.ScrollTime = 1f;
        }
    
    }

}
