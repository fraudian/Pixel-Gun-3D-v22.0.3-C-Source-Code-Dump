using UnityEngine;

namespace Rilisoft
{
    public abstract class BaseScrollOfferPackDrawer : BaseOfferPackDrawer, 丄与且丈丘丄三丗丐
    {
        // Fields
        protected Rilisoft.BaseOfferItemCellView _cellItemPrefab;
        protected UICenterOnChild _centerOnChild;
        private bool 丁丙丞下丄丏丒丐丏;
        private float 丁东丄七万万世七丟;
        protected UIScrollView _scroll;
        protected UnityEngine.Transform _scrollCenterObject;
        protected int _scrollVisibleItemsCount;
        private UnityEngine.Color 丒与丑丆丝不业丞业;
        protected UIWrapContent _wrap;
        private bool 上丁专万丗丘丄七丌;
        
        // Methods
        public override bool Show(Rilisoft.业丙丘丆东丈丕丂丄 不专一业下丞丝丑丗, Rilisoft.BonusData 丛丝丙丄七一丁丅三)
        {
            var val_5;
            if((this.Show(不专一业下丞丝丑丗:  不专一业下丞丝丑丗, 丛丝丙丄七一丁丅三:  丛丝丙丄七一丁丅三)) != false)
            {
                    this.StopCoroutine(routine:  this.且丈一三丒丙专与丒());
                UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.且丈一三丒丙专与丒());
                this.东不丞丂万下三与丕();
                val_5 = 1;
                return (bool)val_5;
            }
            
            val_5 = 0;
            return (bool)val_5;
        }
        protected override void Awake()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._cellItemPrefab.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            UnityEngine.Color val_1 = PGCompany.丟丝世世且丗丈丈丞.丄丐丒丆与丅不丗不();
            this.丒与丑丆丝不业丞业 = val_1;
            mem[1152921543282888048] = val_1.g;
            mem[1152921543282888052] = val_1.b;
            mem[1152921543282888056] = val_1.a;
            this.丁丙丞下丄丏丒丐丏 = PGCompany.丟丝世世且丗丈丈丞.东七一丈七专丅不丙();
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a});
            PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  false);
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            PGCompany.丟丝世世且丗丈丈丞.丙丐东丆丒业下下丙(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = this.丒与丑丆丝不业丞业});
            PGCompany.丟丝世世且丗丈丈丞.丅下业丏丈七专丗东(丙业与丙丗丝不丈东:  this.丁丙丞下丄丏丒丐丏);
        }
        private System.Collections.IEnumerator 且丈一三丒丙专与丒()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new BaseScrollOfferPackDrawer.与一丅三丙世丏与一();
        }
        protected virtual void 业丑丈丁丙丁世丂丁()
        {
            object val_8;
            var val_46;
            float val_47;
            int val_48;
            int val_49;
            goto label_1;
            label_9:
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this._wrap.transform.GetChild(index:  0).gameObject);
            label_1:
            UnityEngine.Transform val_4 = this._wrap.transform;
            if(val_4.childCount > 0)
            {
                goto label_9;
            }
            
            List.Enumerator<T> val_6 = val_4.GetEnumerator();
            val_46 = 1152921504622075904;
            goto label_11;
            label_42:
            string val_9 = val_8.丐丏七丌丕丗业且上();
            Rilisoft.BaseOfferItemCellView val_10 = UnityEngine.Object.Instantiate<Rilisoft.BaseOfferItemCellView>(original:  this._cellItemPrefab);
            val_8 = 1;
            val_10.gameObject.name = System.String.Format(format:  "cell_{0}", arg0:  val_8);
            val_10.gameObject.transform.SetParent(p:  this._wrap.gameObject.transform);
            UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.identity;
            val_10.gameObject.transform.localRotation = new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w};
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
            val_10.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z};
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.zero;
            val_10.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
            int val_44 = this._wrap.itemSize;
            val_44 = val_44 * 0;
            val_47 = 0f;
            val_10.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = val_47, y = 0f, z = 0f};
            val_10.gameObject.SetActive(value:  true);
            Rilisoft.BaseOfferItemCellView val_29 = val_10.GetComponent<Rilisoft.BaseOfferItemCellView>();
            System.Action<Rilisoft.BaseOfferItemCellView> val_30 = new System.Action<Rilisoft.BaseOfferItemCellView>(object:  this, method:  System.Void Rilisoft.BaseScrollOfferPackDrawer::丟丕丒下丅丆丛丁万(Rilisoft.BaseOfferItemCellView 丟丄丛专丏丆与丑一));
            val_46 = 1152921504622075904;
            label_11:
            if((21851488 & 1) != 0)
            {
                goto label_42;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this._scroll.GetComponent<UIPanel>().ResetAnchors();
            this._scroll.Restrict();
            val_48 = this._scrollVisibleItemsCount;
            if(val_48 <= 0)
            {
                    val_48 = this._wrap.Count - 1;
            }
            
            UIPanel val_33 = this._scroll.panel;
            int val_35 = this._wrap.itemSize * val_48;
            if(val_33.width < 0)
            {
                    val_49 = 0;
            }
            else
            {
                    val_49 = val_33.Count - 1;
            }
            
            this._wrap.maxIndex = val_49;
            this._scroll.ResetPosition();
            int val_37 = this._scroll.Count;
            this._scroll.disableDragIfFits = (val_37 < 2) ? 1 : 0;
            this.丐丄东七丅丘丛丞上(丟丄丛专丏丆与丑一:  this.业七专一丌世且丂丛(与业下丟丛万丗丑丆:  this.丘上丅丅丐丅丒上下()));
            if(val_37.Count == 1)
            {
                    this._scroll.movement = 3;
                UnityEngine.Vector2 val_42 = UnityEngine.Vector2.zero;
                val_47 = val_42.x;
                this._scroll.customMovement = val_42;
                mem2[0] = val_42.y;
            }
            else
            {
                    this._scroll.movement = 0;
                val_8 = 0;
                UnityEngine.Vector2 val_43 = new UnityEngine.Vector2(x:  1f, y:  0f);
                this._scroll.customMovement = val_43.x;
                mem2[0] = val_43.y;
            }
            
            this.丂丏一丞丗丈下丕七();
        }
        protected override void 丟且丆丙丆丁丆一万()
        {
            var val_18;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_20;
            var val_21;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_23;
            int val_24;
            var val_25;
            if(11859 == 0)
            {
                    return;
            }
            
            if(11859.Count < 2)
            {
                    return;
            }
            
            Sort(comparison:  new System.Comparison<Rilisoft.OfferItem>(object:  this, method:  typeof(Rilisoft.BaseScrollOfferPackDrawer).__il2cppRuntimeField_320));
            if((public System.Void System.Collections.Generic.List<Rilisoft.OfferItem>::Sort(System.Comparison<T> comparison)) != 0)
            {
                    val_18 = null;
                val_18 = null;
                val_20 = BaseScrollOfferPackDrawer.<>c.<>9__16_0;
                if(val_20 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_3 = null;
                val_20 = val_3;
                val_3 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BaseScrollOfferPackDrawer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BaseScrollOfferPackDrawer.<>c::丟万丞与与上世丅一(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                BaseScrollOfferPackDrawer.<>c.<>9__16_0 = val_20;
            }
            
                Rilisoft.OfferItem val_4 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  static_value_082C8000, predicate:  val_3);
                if((val_4 != null) && ((val_3.IndexOf(item:  val_4)) != 0))
            {
                    val_21 = null;
                val_21 = null;
                val_23 = BaseScrollOfferPackDrawer.<>c.<>9__16_1;
                if(val_23 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_6 = null;
                val_23 = val_6;
                val_6 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BaseScrollOfferPackDrawer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BaseScrollOfferPackDrawer.<>c::七丒万与一丌丙丘且(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                BaseScrollOfferPackDrawer.<>c.<>9__16_1 = val_23;
            }
            
                System.Collections.Generic.IEnumerable<TSource> val_7 = System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  val_3, predicate:  val_6);
                if((System.Linq.Enumerable.Count<Rilisoft.OfferItem>(source:  val_7)) < 2)
            {
                    val_24 = 0;
            }
            else
            {
                    int val_9 = System.Linq.Enumerable.Count<Rilisoft.OfferItem>(source:  val_7);
                val_24 = ((val_9 < 0) ? (val_9 + 1) : (val_9)) >> 1;
            }
            
                bool val_11 = Remove(item:  val_4);
                Insert(index:  val_24, item:  val_4);
            }
            
            }
            
            Rilisoft.OfferItem val_12 = this.丘上丅丅丐丅丒上下();
            bool val_13 = val_24.Remove(item:  val_12);
            if(this != null)
            {
                    val_25 = this.Count;
            }
            else
            {
                    val_25 = 0.Count;
            }
            
            this.Insert(index:  ((val_25 < 0) ? (val_25 + 1) : (val_25)) >> 1, item:  val_12);
        }
        protected virtual int 丒丏与丞七丝丐万三(Rilisoft.OfferItem 丏丆丑丗七丄丙丝与, Rilisoft.OfferItem 丒丈丙丐丏丕丆万丗)
        {
            var val_8;
            var val_9;
            if(丏丆丑丗七丄丙丝与 == null)
            {
                goto label_4;
            }
            
            if(丒丈丙丐丏丕丆万丗 == null)
            {
                goto label_3;
            }
            
            丈丞丕丘丕丗与上一 val_1 = 丏丆丑丗七丄丙丝与.PriceOfThisItem;
            丈丞丕丘丕丗与上一 val_2 = 丒丈丙丐丏丕丆万丗.PriceOfThisItem;
            if((val_1 == null) || (val_1.丟丂丞不专丆万丒世() < 1))
            {
                goto label_3;
            }
            
            if(val_2 == null)
            {
                goto label_4;
            }
            
            val_8 = 0;
            if(val_2.丟丂丞不专丆万丒世() < 1)
            {
                goto label_7;
            }
            
            var val_7 = (丏丆丑丗七丄丙丝与.PriceInGems <= 丒丈丙丐丏丕丆万丗.PriceInGems) ? (-val_8) : (val_8);
            return (int)val_9;
            label_3:
            val_8 = 1;
            goto label_7;
            label_4:
            val_8 = 0;
            label_7:
            val_9 = val_8;
            return (int)val_9;
        }
        private void 丟丑业三丑丙一丏丒(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丆丘丝丟丑丘丂丘专, int 丞丂业丅丟丙丏七丗)
        {
            object val_16;
            int val_17;
            val_16 = this;
            val_17 = UnityEngine.Mathf.Abs(value:  丞丂业丅丟丙丏七丗 - 1);
            int val_3 = Count;
            if((丝三丁东丈丒世丅业.GetComponent<Rilisoft.BaseOfferItemCellView>()) == 0)
            {
                    return;
            }
            
            val_17 = val_17 - ((val_17 / val_3) * val_3);
            Rilisoft.OfferItem val_7 = X23.Item[val_17];
            System.Action<Rilisoft.BaseOfferItemCellView> val_8 = new System.Action<Rilisoft.BaseOfferItemCellView>(object:  this, method:  System.Void Rilisoft.BaseScrollOfferPackDrawer::丟丕丒下丅丆丛丁万(Rilisoft.BaseOfferItemCellView 丟丄丛专丏丆与丑一));
            val_16 = ???;
            val_17 = ???;
            goto typeof(Rilisoft.BaseOfferItemCellView).__il2cppRuntimeField_178;
        }
        private Rilisoft.OfferItem 丘上丅丅丐丅丒上下()
        {
            var val_19;
            var val_20;
            var val_21;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_23;
            var val_24;
            var val_25;
            System.Func<Rilisoft.OfferItem, System.Boolean> val_27;
            Rilisoft.OfferItem val_28;
            var val_30;
            val_19 = this;
            if((11854 == 0) || (11854.Count == 0))
            {
                goto label_2;
            }
            
            val_20 = null;
            if(X9 == 0)
            {
                goto label_3;
            }
            
            val_21 = null;
            val_23 = BaseScrollOfferPackDrawer.<>c.<>9__19_0;
            if(val_23 == null)
            {
                    System.Func<Rilisoft.OfferItem, System.Boolean> val_2 = null;
                val_23 = val_2;
                val_2 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BaseScrollOfferPackDrawer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BaseScrollOfferPackDrawer.<>c::丛且下丆丕下丗丒丁(Rilisoft.OfferItem 七丞丙丒三丕且丌丟));
                BaseScrollOfferPackDrawer.<>c.<>9__19_0 = val_23;
            }
            
            val_24 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.OfferItem>(source:  static_value_082C8000, predicate:  val_2);
            if(val_24 != null)
            {
                    return (Rilisoft.OfferItem)val_24;
            }
            
            val_24 = this.Item[0];
            return (Rilisoft.OfferItem)val_24;
            label_2:
            val_24 = 0;
            return (Rilisoft.OfferItem)val_24;
            label_3:
            val_25 = null;
            val_27 = BaseScrollOfferPackDrawer.<>c.<>9__19_1;
            if(val_27 == null)
            {
                    val_27 = null;
                val_27 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BaseScrollOfferPackDrawer.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BaseScrollOfferPackDrawer.<>c::且丗不万丛上丑丛丁(Rilisoft.OfferItem 丙丒七丄上与丏丙丙));
                BaseScrollOfferPackDrawer.<>c.<>9__19_1 = val_27;
            }
            
            Rilisoft.OfferItem val_6 = System.Linq.Enumerable.First<Rilisoft.OfferItem>(source:  static_value_082C8000, predicate:  null);
            if(val_6 != null)
            {
                    return (Rilisoft.OfferItem)val_24;
            }
            
            val_28 = val_6.Item[0];
            List.Enumerator<T> val_8 = null.GetEnumerator();
            goto label_20;
            label_23:
            string val_9 = 0.丐丏七丌丕丗业且上();
            label_20:
            if((22634392 & 1) != 0)
            {
                goto label_23;
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(((val_9.PriceInGems > val_28.PriceInGems) ? (val_9) : (val_28)) == 0)
            {
                    return (Rilisoft.OfferItem)val_24;
            }
            
            if(mem[8].Count < 3)
            {
                    return (Rilisoft.OfferItem)val_24;
            }
            
            bool val_14 = mem[8].Remove(item:  null);
            if(this != null)
            {
                    val_30 = this.Count;
            }
            else
            {
                    val_30 = 0.Count;
            }
            
            this.Insert(index:  ((val_30 < 0) ? (val_30 + 1) : (val_30)) >> 1, item:  null);
            return (Rilisoft.OfferItem)val_24;
        }
        private static int 业丑世上丗东丄丟上(Rilisoft.OfferItem 丏丆丑丗七丄丙丝与, Rilisoft.OfferItem 丒丈丙丐丏丕丆万丗)
        {
            var val_28;
            float val_29;
            var val_30;
            三丅丁丗丗丝丂万且 val_1 = 丏丆丑丗七丄丙丝与.Record;
            三丅丁丗丗丝丂万且 val_2 = 丒丈丙丐丏丕丆万丗.Record;
            val_29 = val_1.丙下业七一一下世万();
            if(val_29 != val_2.丙下业七一一下世万())
            {
                goto label_6;
            }
            
            if((val_1.且丅万下业下三丛与() == null) || (val_2.且丅万下业下三丛与() == null))
            {
                goto label_9;
            }
            
            val_30 = null;
            val_30 = null;
            val_28 = System.String.op_Equality(a:  val_1.且丅万下业下三丛与().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝);
            if((val_28 ^ (System.String.op_Equality(a:  val_2.且丅万下业下三丛与().东与三丌丅三丒丏业(), b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝))) == false)
            {
                goto label_16;
            }
            
            goto label_17;
            label_9:
            label_17:
            var val_15 = (val_1.且丅万下业下三丛与() == 0) ? (-0) : 0;
            return (int)(val_29 > val_2.丙下业七一一下世万()) ? 0 : (0 + 1);
            label_6:
            val_29 = val_1.丙下业七一一下世万();
            return (int)(val_29 > val_2.丙下业七一一下世万()) ? 0 : (0 + 1);
            label_16:
            if(val_1.且丅万下业下三丛与().丟丂丞不专丆万丒世() == val_2.且丅万下业下三丛与().丟丂丞不专丆万丒世())
            {
                    return Rilisoft.Offers.丁且丕专万丈丒丏丗.上万万丑业丌丌丅丝(丏丆丑丗七丄丙丝与:  val_1, 丒丈丙丐丏丕丆万丗:  val_2);
            }
            
            var val_27 = (val_1.且丅万下业下三丛与().丟丂丞不专丆万丒世() <= val_2.且丅万下业下三丛与().丟丂丞不专丆万丒世()) ? (-0) : 0;
            return (int)(val_29 > val_2.丙下业七一一下世万()) ? 0 : (0 + 1);
        }
        private void 丐丄东七丅丘丛丞上(Rilisoft.BaseOfferItemCellView 丟丄丛专丏丆与丑一)
        {
            UICenterOnChild val_4;
            UICenterOnChild val_5;
            UICenterOnChild val_6;
            val_5 = this;
            if(丟丄丛专丏丆与丑一 == 0)
            {
                    return;
            }
            
            val_6 = this._centerOnChild;
            if(this._centerOnChild != null)
            {
                goto label_4;
            }
            
            val_6 = this._centerOnChild;
            if(val_6 == null)
            {
                goto label_5;
            }
            
            label_4:
            this._centerOnChild.springStrength = 100500f;
            val_4 = this._centerOnChild;
            val_4.CenterOn(丞下万上三丘上与专:  丟丄丛专丏丆与丑一.gameObject.transform);
            val_5 = this._centerOnChild;
            this._centerOnChild.springStrength = this._centerOnChild.springStrength;
            return;
            label_5:
        }
        private void 丟丕丒下丅丆丛丁万(Rilisoft.BaseOfferItemCellView 丟丄丛专丏丆与丑一)
        {
            this._centerOnChild.CenterOn(丞下万上三丘上与专:  丟丄丛专丏丆与丑一.gameObject.transform);
        }
        private Rilisoft.BaseOfferItemCellView 业七专一丌世且丂丛(Rilisoft.OfferItem 与业下丟丛万丗丑丆)
        {
            var val_8;
            UnityEngine.Object val_9;
            val_8 = 0;
            goto label_1;
            label_13:
            val_9 = this._wrap.gameObject.transform.GetChild(index:  0).GetComponent<Rilisoft.BaseOfferItemCellView>();
            if(val_9 != 0)
            {
                    if(val_4._item == 与业下丟丛万丗丑丆)
            {
                    return (Rilisoft.BaseOfferItemCellView)val_9;
            }
            
            }
            
            val_8 = 1;
            label_1:
            if(val_8 < this._wrap.transform.childCount)
            {
                goto label_13;
            }
            
            val_9 = 0;
            return (Rilisoft.BaseOfferItemCellView)val_9;
        }
        protected int 专丄一丏丛丙丛丅丌(Rilisoft.BaseOfferItemCellView 丟丄丛专丏丆与丑一)
        {
            goto label_1;
            label_14:
            Rilisoft.BaseOfferItemCellView val_4 = this._wrap.gameObject.transform.GetChild(index:  0).GetComponent<Rilisoft.BaseOfferItemCellView>();
            if(val_4 != 0)
            {
                    if(val_4 == 丟丄丛专丏丆与丑一)
            {
                    return 0;
            }
            
            }
            
            0 = 1;
            label_1:
            if(0 < this._wrap.transform.childCount)
            {
                goto label_14;
            }
            
            return 0;
        }
        protected override void Update()
        {
            this.Update();
            UnityEngine.Vector3 val_3 = this._scroll.gameObject.transform.position;
            if(this.丁东丄七万万世七丟 == val_3.x)
            {
                    return;
            }
            
            this.丁东丄七万万世七丟 = val_3.x;
            this.丂丏一丞丗丈下丕七();
        }
        private void 丂丏一丞丗丈下丕七()
        {
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            val_22 = this;
            val_23 = 1152921504848912384;
            val_24 = 0;
            val_25 = 0;
            val_26 = 0;
            goto label_1;
            label_11:
            Rilisoft.BaseOfferItemCellView val_5 = this._wrap.gameObject.transform.GetChild(index:  0).GetComponent<Rilisoft.BaseOfferItemCellView>();
            Rilisoft.BaseOfferItemCellView val_22 = this.丌不与丗下丗丞丆上();
            val_22 = UnityEngine.Object.op_Equality(x:  val_5, y:  val_22);
            val_24 = 1;
            label_1:
            if(val_24 < this._wrap.transform.childCount)
            {
                goto label_11;
            }
            
            if((((val_5.<丝专丘不丌丟东丗丝>k__BackingField) == true) ? (val_5) : (val_26)) == (((val_5.<丝专丘不丌丟东丗丝>k__BackingField) == true) ? (val_5) : (val_25)))
            {
                    return;
            }
            
            val_22 = ???;
            val_26 = ???;
            val_24 = ???;
            val_23 = ???;
            goto typeof(Rilisoft.BaseScrollOfferPackDrawer).__il2cppRuntimeField_328;
        }
        protected abstract void 丈丁丏七丞丑丛东上(Rilisoft.BaseOfferItemCellView 丈丗与丞一上且上上, Rilisoft.BaseOfferItemCellView 专丂丕丗丗东世丞下); // 0
        private Rilisoft.BaseOfferItemCellView 丌不与丗下丗丞丆上()
        {
            var val_4;
            UnityEngine.GameObject val_1 = this.丈下业丙下上专一东();
            val_4 = 0;
            if(val_1 == 0)
            {
                    return (Rilisoft.BaseOfferItemCellView)val_1.GetComponent<Rilisoft.BaseOfferItemCellView>();
            }
            
            return (Rilisoft.BaseOfferItemCellView)val_1.GetComponent<Rilisoft.BaseOfferItemCellView>();
        }
        private UnityEngine.GameObject 丈下业丙下上专一东()
        {
            var val_10;
            var val_11;
            val_10 = 0;
            val_11 = 0;
            goto label_1;
            label_14:
            UnityEngine.Transform val_3 = this._wrap.gameObject.transform.GetChild(index:  0);
            UnityEngine.Vector3 val_4 = this._scrollCenterObject.position;
            UnityEngine.Vector3 val_6 = val_3.transform.position;
            val_6.x = val_4.x - val_6.x;
            if(System.Math.Abs(val_6.x) < 0)
            {
                    val_11 = val_3.gameObject;
            }
            
            val_10 = 1;
            label_1:
            if(val_10 < this._wrap.transform.childCount)
            {
                goto label_14;
            }
            
            return (UnityEngine.GameObject)val_11;
        }
        protected BaseScrollOfferPackDrawer()
        {
            this.上丁专万丗丘丄七丌 = true;
        }
    
    }

}
