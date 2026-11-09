using UnityEngine;

namespace PGCompany
{
    public class DynamicStringWrapGrid : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject baseViewItem;
        private bool 丟丌丛一下丁世万不;
        private System.Collections.Generic.IList<string> 丂上丁丑丈上丛七专;
        private float 丐丂七丞丗丅丁丙丈;
        private bool 七丅丞丆丒丏且丆专;
        public int itemIndexToCenterFromContextMenu;
        private int itemsCount;
        internal DynamicWrapScrollBar scrollBar;
        private bool 丟东不丅丙丆专丝丟;
        private float 丒丅业丈丒丗丆丆丁;
        private int 世丈丞丒七丗一三丕;
        internal bool scaleWidth;
        private float scalingWidthValue;
        public bool disableDragIfFits;
        public bool unlimitedContent;
        private float 世丕丞三一丞世与万;
        internal UIScrollView scrollView;
        private System.Collections.Generic.List<PGCompany.DynamicStringWrapGridItem> <专丐不丛丝丁上丝专>k__BackingField;
        private UnityEngine.Coroutine 丟丝业丛七丟上一三;
        public float smoothScrollSpeed;
        private bool 丆丌丏丅丏丑丂丈丌;
        private UIWrapContent <业丐丈三不东丑专丈>k__BackingField;
        private bool 丕丄世丗丌丄丌三且;
        internal bool 丞且丂丕丙丟专丈丗;
        
        // Properties
        internal int 丕丝七不丒丞丈丑万 { get; }
        public System.Collections.Generic.List<PGCompany.DynamicStringWrapGridItem> 丒丅丗丕专一丂东丆 { get; set; }
        public UIScrollView 上丛不专丂丐丝丛一 { get; }
        public int 世一丑上三丈丁一丗 { get; }
        public UIWrapContent 七丘丑丝丅三丞与丟 { get; set; }
        public bool 七丘不丗上丈丆丕与 { get; }
        
        // Methods
        internal int 丟丟丁下丒业丅丄万()
        {
            if(this.丂上丁丑丈上丛七专 == null)
            {
                    return 0;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.丂上丁丑丈上丛七专.Count;
        }
        public System.Collections.Generic.List<PGCompany.DynamicStringWrapGridItem> get_GridItems()
        {
            return (System.Collections.Generic.List<PGCompany.DynamicStringWrapGridItem>)this.<专丐不丛丝丁上丝专>k__BackingField;
        }
        private void 丑三且一丒丑不丄丙(System.Collections.Generic.List<PGCompany.DynamicStringWrapGridItem> 丙业与丙丗丝不丈东)
        {
            this.<专丐不丛丝丁上丝专>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public UIScrollView get_ScrollView()
        {
            return (UIScrollView)this.scrollView;
        }
        public int get_ScaledItemWidth()
        {
            return (int)this.世丈丞丒七丗一三丕;
        }
        public UIWrapContent get_wrapContent()
        {
            return (UIWrapContent)this.<业丐丈三不东丑专丈>k__BackingField;
        }
        private void 丌丞业丗丗不专丗丑(UIWrapContent 丙业与丙丗丝不丈东)
        {
            this.<业丐丈三不东丑专丈>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_isScrollingSmoothNow()
        {
            return (bool)(this.丟丝业丛七丟上一三 != 0) ? 1 : 0;
        }
        private void Awake()
        {
            if(this.丕丄世丗丌丄丌三且 == true)
            {
                    return;
            }
            
            this.丒丅业丈丒丗丆丆丁 = 0f;
            this.<业丐丈三不东丑专丈>k__BackingField = this.gameObject.GetComponent<UIWrapContent>();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.baseViewItem, 丏业丟一东丂东丘丛:  false);
            this.丕丄世丗丌丄丌三且 = true;
        }
        private void 丘上丐世丆丑且丞丒()
        {
            float val_14;
            var val_15;
            float val_16;
            float val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            if(this.丕丄世丗丌丄丌三且 != true)
            {
                    this.Awake();
            }
            
            this.<业丐丈三不东丑专丈>k__BackingField.onInitializeItem = new UIWrapContent.丙丏丒丐丑三丆丝世(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.DynamicStringWrapGrid::丐丄丘东世丆专丆不(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛));
            val_14 = this.丐丂七丞丗丅丁丙丈;
            if(val_14 < 0)
            {
                    int val_3 = UnityEngine.Screen.width;
                if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
            {
                    val_15 = null;
                val_15 = null;
                val_16 = IphoneXCameraScaler.不丅七丘丈不丌丝丏 * (float)val_3;
                val_17 = IphoneXCameraScaler.且下丒丘丙丒丈丏万 * (float)UnityEngine.Screen.height;
            }
            else
            {
                    val_16 = (float)val_3;
                val_17 = (float)UnityEngine.Screen.height;
            }
            
                val_17 = val_17 / 768f;
                val_14 = val_16 / val_17;
                this.丐丂七丞丗丅丁丙丈 = val_14;
            }
            
            if(this.世丈丞丒七丗一三丕 != 1)
            {
                goto label_15;
            }
            
            if((this.scalingWidthValue <= 0f) || (this.scalingWidthValue < 1f))
            {
                goto label_12;
            }
            
            val_18 = val_14 - this.scalingWidthValue;
            goto label_13;
            label_12:
            if((this.scalingWidthValue <= 0f) || (this.scalingWidthValue >= 0))
            {
                goto label_15;
            }
            
            val_18 = this.scalingWidthValue * val_14;
            label_13:
            this.世丈丞丒七丗一三丕 = (int)val_18;
            label_15:
            this.<专丐不丛丝丁上丝专>k__BackingField = new System.Collections.Generic.List<PGCompany.DynamicStringWrapGridItem>(capacity:  this.itemsCount);
            if(this.itemsCount >= 1)
            {
                    val_19 = 1152921504622075904;
                val_20 = 1152921505284374528;
                val_21 = 1152921555288478272;
                val_22 = 1152921555288479296;
                object val_14 = 0;
                do
            {
                UnityEngine.GameObject val_8 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.gameObject, 丑且不丕与专丄业丙:  this.baseViewItem);
                val_8.name = System.String.Format(format:  "{0}_{1:000}", arg0:  val_8.name, arg1:  val_14);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
                if((this.世丈丞丒七丗一三丕 >= 1) && (this.scaleWidth != false))
            {
                    val_8.GetComponent<UIWidget>().width = this.世丈丞丒七丗一三丕;
                val_19 = val_19;
                val_20 = val_20;
                val_21 = val_21;
                val_22 = 1152921555288479296;
            }
            
                this.<专丐不丛丝丁上丝专>k__BackingField.Add(item:  val_8.GetComponent<PGCompany.DynamicStringWrapGridItem>());
                val_14 = val_14 + 1;
            }
            while(val_14 < this.itemsCount);
            
            }
            
            this.<业丐丈三不东丑专丈>k__BackingField.cullContent = false;
            this.scrollView.disableDragIfFits = this.disableDragIfFits;
            if(this.scrollBar != 0)
            {
                    this.scrollBar.Init(丙丈丟万丁丒丂与一:  this);
            }
            
            this.七丅丞丆丒丏且丆专 = true;
        }
        private void 丐丄丘东世丆专丆不(UnityEngine.GameObject 丝三丁东丈丒世丅业, int 丘丆丙丛七下丄丝业, int 一丁丂丈下世丗丟丛)
        {
            val_1.wrapIndex = UnityEngine.Mathf.Abs(value:  一丁丂丈下世丗丟丛);
            this.UpdateViewItem(丘不丈与丆七丛丞七:  丝三丁东丈丒世丅业.GetComponent<PGCompany.DynamicStringWrapGridItem>());
        }
        public void AddContentInner(string 下丅丙一丂丗丅丝七)
        {
            if(this.丂上丁丑丈上丛七专 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丂上丁丑丈上丛七专.Add(item:  null);
        }
        public void AddContentItem(string 下丅丙一丂丗丅丝七)
        {
            this.AddContentInner(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
            if(this.丂丑东丆七东丕丐丆() != true)
            {
                    if(this.丞且丂丕丙丟专丈丗 == false)
            {
                    return;
            }
            
            }
            
            this.SetContent(三丏丑不业丏不丂丈:  this.丂上丁丑丈上丛七专, 业丛丛世上丈丘丄东:  false);
        }
        public void UpdateViewItem(PGCompany.DynamicStringWrapGridItem 丘不丈与丆七丛丞七)
        {
            System.Collections.Generic.IList<System.String> val_7;
            UnityEngine.Object val_8;
            var val_9;
            var val_10;
            System.Collections.Generic.IList<System.String> val_11;
            var val_12;
            int val_14;
            var val_16;
            var val_19;
            var val_20;
            val_8 = 丘不丈与丆七丛丞七;
            val_9 = this;
            if(val_8 == 0)
            {
                    return;
            }
            
            if(this.unlimitedContent == false)
            {
                goto label_4;
            }
            
            val_10 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  true);
            if(this.丟丌丛一下丁世万不 == false)
            {
                    return;
            }
            
            val_11 = this.丂上丁丑丈上丛七专;
            if(val_8 == null)
            {
                    val_11 = this.丂上丁丑丈上丛七专;
            }
            
            var val_9 = 0;
            val_12 = 1152921504691335176;
            val_9 = val_9 + 1;
            val_12 = 1152921504691335192;
            val_10 = 0;
            goto label_13;
            label_4:
            val_14 = 丘不丈与丆七丛丞七.wrapIndex;
            if((val_14 & 2147483648) != 0)
            {
                goto label_27;
            }
            
            val_7 = this.丂上丁丑丈上丛七专;
            val_16 = null;
            var val_10 = 0;
            val_12 = 1152921504691335176;
            val_10 = val_10 + 1;
            goto label_20;
            label_13:
            int val_11 = val_11.Count;
            val_11 = 丘不丈与丆七丛丞七.wrapIndex - ((丘不丈与丆七丛丞七.wrapIndex / val_11) * val_11);
            var val_12 = 0;
            val_12 = 1152921504691335176;
            val_12 = val_12 + 1;
            val_12 = 1152921504691335192;
            val_10 = 0;
            label_39:
            val_16 = this.丂上丁丑丈上丛七专.Item[val_11];
            val_9 = ???;
            val_8 = ???;
            val_14 = ???;
            val_7 = ???;
            goto typeof(PGCompany.DynamicStringWrapGridItem).__il2cppRuntimeField_178;
            label_20:
            if(val_14 >= val_7.Count)
            {
                goto label_27;
            }
            
            val_19 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  true);
            if((val_9 + 32) == 0)
            {
                    return;
            }
            
            var val_15 = val_9 + 40;
            if((val_9 + 40 + 286) == 0)
            {
                goto label_33;
            }
            
            var val_13 = val_9 + 40 + 176;
            var val_14 = 0;
            val_13 = val_13 + 8;
            label_35:
            if(((val_9 + 40 + 176 + 8) + -8) == null)
            {
                goto label_34;
            }
            
            val_14 = val_14 + 1;
            val_13 = val_13 + 16;
            if(val_14 < (val_9 + 40 + 286))
            {
                goto label_35;
            }
            
            label_33:
            val_19 = 0;
            goto label_39;
            label_27:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  false);
            return;
            label_34:
            val_15 = val_15 + (((val_9 + 40 + 176 + 8)) << 4);
            val_20 = val_15 + 296;
            goto label_39;
        }
        private bool 丑丛丘丝丌一丏丕丂()
        {
            var val_11;
            System.Collections.Generic.IList<System.String> val_12;
            var val_14;
            val_11 = 0;
            goto label_1;
            label_20:
            if(((this.<专丐不丛丝丁上丝专>k__BackingField.Item[0].Widget) == 0) || ((this.<专丐不丛丝丁上丝专>k__BackingField.Item[0].Widget.isVisible) == false))
            {
                goto label_10;
            }
            
            PGCompany.DynamicStringWrapGridItem val_7 = this.<专丐不丛丝丁上丝专>k__BackingField.Item[0];
            val_12 = this.丂上丁丑丈上丛七专;
            var val_12 = 0;
            val_12 = val_12 + 1;
            if(val_7.wrapIndex == (val_12.Count - 2))
            {
                goto label_18;
            }
            
            label_10:
            val_11 = 1;
            label_1:
            val_12 = this.<专丐不丛丝丁上丝专>k__BackingField;
            if(val_11 < val_12.Count)
            {
                goto label_20;
            }
            
            val_14 = 0;
            return (bool)val_14;
            label_18:
            val_14 = 1;
            return (bool)val_14;
        }
        private int 丒丙七下丈且且丐业()
        {
            int val_5;
            var val_6;
            PGCompany.DynamicStringWrapGridItem val_1 = this.<专丐不丛丝丁上丝专>k__BackingField.Item[0];
            val_5 = val_1.wrapIndex;
            val_6 = 0;
            goto label_3;
            label_10:
            PGCompany.DynamicStringWrapGridItem val_2 = this.<专丐不丛丝丁上丝专>k__BackingField.Item[0];
            if(val_2.wrapIndex > val_5)
            {
                    PGCompany.DynamicStringWrapGridItem val_3 = this.<专丐不丛丝丁上丝专>k__BackingField.Item[0];
                val_5 = val_3.wrapIndex;
            }
            
            val_6 = 1;
            label_3:
            if(val_6 < (this.<专丐不丛丝丁上丝专>k__BackingField.Count))
            {
                goto label_10;
            }
            
            return val_5;
        }
        public void SetContent(System.Collections.Generic.IList<string> 三丏丑不业丏不丂丈, bool 业丛丛世上丈丘丄东 = False)
        {
            var val_9;
            var val_11;
            if(三丏丑不业丏不丂丈 == null)
            {
                goto label_1;
            }
            
            label_12:
            this.丂上丁丑丈上丛七专 = 三丏丑不业丏不丂丈;
            if(this.七丅丞丆丒丏且丆专 != true)
            {
                    this.丘上丐世丆丑且丞丒();
            }
            
            if(this.unlimitedContent == false)
            {
                goto label_4;
            }
            
            if((this.<业丐丈三不东丑专丈>k__BackingField) != null)
            {
                goto label_19;
            }
            
            label_20:
            label_19:
            this.<业丐丈三不东丑专丈>k__BackingField.minIndex = 0;
            bool val_11 = ~业丛丛世上丈丘丄东;
            val_11 = val_11 & 1;
            this.丟丌丛一下丁世万不 = val_11;
            List.Enumerator<T> val_2 = this.<专丐不丛丝丁上丝专>k__BackingField.GetEnumerator();
            val_9 = 1152921555289623936;
            label_10:
            if(((-856791000) & 1) == 0)
            {
                goto label_9;
            }
            
            this.UpdateViewItem(丘不丈与丆七丛丞七:  0.丐丏七丌丕丗业且上());
            goto label_10;
            label_1:
            System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>();
            if(this != null)
            {
                goto label_12;
            }
            
            goto label_12;
            label_4:
            System.Collections.Generic.IList<System.String> val_13 = this.丂上丁丑丈上丛七专;
            var val_12 = 0;
            val_12 = val_12 + 1;
            goto label_17;
            label_9:
            val_11 = public System.Void List.Enumerator<PGCompany.DynamicStringWrapGridItem>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_23;
            label_17:
            val_13 = 1 - val_13.Count;
            if((this.<业丐丈三不东丑专丈>k__BackingField) != null)
            {
                goto label_19;
            }
            
            goto label_20;
            label_23:
            if(this.丞且丂丕丙丟专丈丗 == false)
            {
                goto label_24;
            }
            
            if(this.丑丛丘丝丌一丏丕丂() == false)
            {
                    return;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            goto label_30;
            label_24:
            this.scrollView.ResetPosition();
            goto label_33;
            label_30:
            this.ScrollFromStart(丙业与丙丗丝不丈东:  this.丌丕世丞世丏万丌东(丌丈丒丞七七丟丄业:  0f, 世万专丛与丐丌专不:  this.丂上丁丑丈上丛七专.Count - 1), 且丈丌丅业丅下万三:  true);
            label_33:
            this.丒丅业丈丒丗丆丆丁 = 0f;
        }
        public int GetItemContentIndex(string 下丛丅一丌丏丏丕丐)
        {
            if(this.丂上丁丑丈上丛七专 == null)
            {
                    return 0;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            return this.丂上丁丑丈上丛七专.IndexOf(item:  null);
        }
        public void ScrollFromStart(float 丙业与丙丗丝不丈东, bool 且丈丌丅业丅下万三)
        {
            if(this.丟丝业丛七丟上一三 != null)
            {
                    this.StopCoroutine(routine:  this.丟丝业丛七丟上一三);
            }
            
            this.scrollView.ResetPosition();
            this.丒丅业丈丒丗丆丆丁 = 0f;
            this.世丕丞三一丞世与万 = 丙业与丙丗丝不丈东;
            this.丟东不丅丙丆专丝丟 = true;
            this.丆丌丏丅丏丑丂丈丌 = 且丈丌丅业丅下万三;
        }
        private float 丄丗丁不丘丁上丛丗(float 丌丈丒丞七七丟丄业, int 世万专丛与丐丌专不)
        {
            var val_14;
            var val_15;
            float val_17;
            UIScrollView val_19;
            UIWrapContent val_21;
            UIWrapContent val_22;
            float val_23;
            val_14 = 世万专丛与丐丌专不;
            val_15 = this;
            if(this.丂上丁丑丈上丛七专 != null)
            {
                    val_14 = val_14 & (~(val_14 >> 31));
                var val_15 = 0;
                val_15 = val_15 + 1;
            }
            else
            {
                    val_17 = 0f;
                return (float)val_17;
            }
            
            if(val_14 > (this.丂上丁丑丈上丛七专.Count - 1))
            {
                    var val_16 = 0;
                val_16 = val_16 + 1;
                val_14 = this.丂上丁丑丈上丛七专.Count - 1;
            }
            
            val_19 = this.scrollView;
            if(val_19 != null)
            {
                    var val_6 = (this.scrollView.movement == 0) ? 1 : 0;
            }
            else
            {
                    val_19 = this.scrollView;
            }
            
            UnityEngine.Vector2 val_9 = val_19.panel.GetViewSize();
            val_21 = this.<业丐丈三不东丑专丈>k__BackingField;
            float val_10 = (((this.scrollView.movement == 0) ? 1 : 0) != 0) ? val_9.x : val_9.y;
            if(val_21 == null)
            {
                goto label_17;
            }
            
            val_22 = val_21;
            float val_17 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            val_17 = val_17 * (-0.5f);
            val_23 = val_10 + val_17;
            goto label_20;
            label_17:
            val_22 = this.<业丐丈三不东丑专丈>k__BackingField;
            float val_18 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            val_18 = val_18 * (-0.5f);
            val_23 = val_10 + val_18;
            if(val_22 == null)
            {
                goto label_19;
            }
            
            val_21 = val_22;
            goto label_20;
            label_19:
            val_21 = this.<业丐丈三不东丑专丈>k__BackingField;
            if(val_21 == null)
            {
                goto label_21;
            }
            
            label_20:
            int val_19 = this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            val_19 = val_19 * val_14;
            float val_20 = (float)val_19;
            val_20 = val_20 - val_23;
            float val_22 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_20 = val_20 - 丌丈丒丞七七丟丄业;
            val_22 = val_22 * 0.5f;
            int val_24 = this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            var val_23 = ~val_14;
            val_23 = this.丂上丁丑丈上丛七专.Count + val_23;
            val_24 = val_24 * val_23;
            val_17 = val_20 + val_22;
            if(val_23 > (float)val_24)
            {
                    val_15 = this.<专丐不丛丝丁上丝专>k__BackingField.Count;
                int val_25 = this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
                var val_14 = (val_15 < 0) ? (val_15 + 1) : (val_15);
                val_14 = val_14 >> 1;
                val_25 = val_25 * val_14;
                float val_26 = (float)val_25;
                val_26 = val_26 * (-0.5f);
                val_17 = val_17 + val_26;
            }
            
            val_26 = val_17 + 丌丈丒丞七七丟丄业;
            if(val_26 >= 0)
            {
                    return (float)val_17;
            }
            
            val_17 = 0f - 丌丈丒丞七七丟丄业;
            return (float)val_17;
            label_21:
        }
        private float 丌丕世丞世丏万丌东(float 丌丈丒丞七七丟丄业, int 世万专丛与丐丌专不)
        {
            var val_21;
            UIWrapContent val_22;
            float val_24;
            UIScrollView val_26;
            UIWrapContent val_29;
            UIWrapContent val_30;
            UIScrollView val_32;
            val_21 = 世万专丛与丐丌专不;
            val_22 = this;
            if(this.丂上丁丑丈上丛七专 != null)
            {
                    val_21 = val_21 & (~(val_21 >> 31));
                var val_22 = 0;
                val_22 = val_22 + 1;
            }
            else
            {
                    val_24 = 0f;
                return (float)val_24;
            }
            
            if(val_21 > (this.丂上丁丑丈上丛七专.Count - 1))
            {
                    var val_23 = 0;
                val_23 = val_23 + 1;
                val_21 = this.丂上丁丑丈上丛七专.Count - 1;
            }
            
            val_26 = this.scrollView;
            if(val_26 != null)
            {
                    var val_6 = (this.scrollView.movement == 0) ? 1 : 0;
            }
            else
            {
                    val_26 = this.scrollView;
            }
            
            UnityEngine.Vector2 val_9 = val_26.panel.GetViewSize();
            val_29 = this.<业丐丈三不东丑专丈>k__BackingField;
            if((this.<业丐丈三不东丑专丈>k__BackingField) == null)
            {
                    val_29 = this.<业丐丈三不东丑专丈>k__BackingField;
            }
            
            int val_25 = this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            val_30 = val_29;
            if(val_29 != null)
            {
                goto label_18;
            }
            
            val_30 = this.<业丐丈三不东丑专丈>k__BackingField;
            if(val_30 == null)
            {
                goto label_19;
            }
            
            label_18:
            float val_24 = (float)val_25;
            val_9.y = ((((this.scrollView.movement == 0) ? 1 : 0) != 0) ? val_9.x : val_9.y) * 0.5f;
            val_24 = val_24 * 0.5f;
            val_25 = val_9.y - val_24;
            float val_26 = (float)(this.<业丐丈三不东丑专丈>k__BackingField.itemSize) * val_21;
            val_26 = val_26 - val_25;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_26 = val_26 - 丌丈丒丞七七丟丄业;
            int val_29 = this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            var val_28 = ~val_21;
            val_28 = this.丂上丁丑丈上丛七专.Count + val_28;
            val_24 = val_26 + (((float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize) * 0.5f);
            val_29 = val_29 * val_28;
            if(val_25 > (float)val_29)
            {
                    val_32 = this.scrollView;
                if(val_32 != null)
            {
                    var val_15 = (this.scrollView.movement == 0) ? 1 : 0;
            }
            else
            {
                    val_32 = this.scrollView;
            }
            
                UnityEngine.Vector2 val_18 = val_32.panel.clipSoftness;
                val_22 = this.<业丐丈三不东丑专丈>k__BackingField;
                float val_30 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
                val_30 = val_30 * 0.5f;
                val_30 = (val_25 - (float)val_29) + val_30;
                val_30 = val_24 - val_30;
                val_24 = (((((this.scrollView.movement == 0) ? 1 : 0) != 0) ? val_18.x : val_18.y) + ((((this.scrollView.movement == 0) ? 1 : 0) != 0) ? val_18.x : val_18.y)) + val_30;
            }
            
            val_30 = val_24 + 丌丈丒丞七七丟丄业;
            if(val_30 >= 0)
            {
                    return (float)val_24;
            }
            
            val_24 = 0f - 丌丈丒丞七七丟丄业;
            return (float)val_24;
            label_19:
        }
        public void ScrollToEndOnItem(int 世万专丛与丐丌专不)
        {
            this.ScrollFromStart(丙业与丙丗丝不丈东:  this.丄丗丁不丘丁上丛丗(丌丈丒丞七七丟丄业:  0f, 世万专丛与丐丌专不:  世万专丛与丐丌专不), 且丈丌丅业丅下万三:  true);
            this.丒丅业丈丒丗丆丆丁 = 0f;
        }
        public void ScrollToCenterOnItem(int 世万专丛与丐丌专不)
        {
            this.ScrollFromStart(丙业与丙丗丝不丈东:  this.丌丕世丞世丏万丌东(丌丈丒丞七七丟丄业:  0f, 世万专丛与丐丌专不:  世万专丛与丐丌专不), 且丈丌丅业丅下万三:  true);
            this.丒丅业丈丒丗丆丆丁 = 0f;
        }
        public void ScrollToCenterOnItem(string 丙丈下丕丑专上丕丛)
        {
            if(this.丂上丁丑丈上丛七专 == null)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.ScrollFromStart(丙业与丙丗丝不丈东:  this.丌丕世丞世丏万丌东(丌丈丒丞七七丟丄业:  0f, 世万专丛与丐丌专不:  this.丂上丁丑丈上丛七专.IndexOf(item:  ???)), 且丈丌丅业丅下万三:  true);
            this.丒丅业丈丒丗丆丆丁 = 0f;
        }
        public void ScrollToCenterOnItemSmoothBySpeed(int 世万专丛与丐丌专不, float 丗丒丛下与万丗丙丝)
        {
            if(this.丟丝业丛七丟上一三 != null)
            {
                    this.StopCoroutine(routine:  this.丟丝业丛七丟上一三);
            }
            
            this.丟丝业丛七丟上一三 = this.StartCoroutine(routine:  this.业丝下世丑丌丅专与(丙业与丙丗丝不丈东:  this.丌丕世丞世丏万丌东(丌丈丒丞七七丟丄业:  this.丒丅业丈丒丗丆丆丁, 世万专丛与丐丌专不:  世万专丛与丐丌专不), 丗丒丛下与万丗丙丝:  丗丒丛下与万丗丙丝));
        }
        public void ScrollToCenterOnItemSmoothByTime(int 世万专丛与丐丌专不, float 七不丞世丁丝业丌专)
        {
            if(this.丟丝业丛七丟上一三 != null)
            {
                    this.StopCoroutine(routine:  this.丟丝业丛七丟上一三);
            }
            
            float val_1 = this.丌丕世丞世丏万丌东(丌丈丒丞七七丟丄业:  this.丒丅业丈丒丗丆丆丁, 世万专丛与丐丌专不:  世万专丛与丐丌专不);
            float val_6 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            val_6 = System.Math.Abs(val_1) / val_6;
            this.丟丝业丛七丟上一三 = this.StartCoroutine(routine:  this.业丝下世丑丌丅专与(丙业与丙丗丝不丈东:  val_1, 丗丒丛下与万丗丙丝:  val_6 / 七不丞世丁丝业丌专));
        }
        private System.Collections.IEnumerator 业丝下世丑丌丅专与(float 丙业与丙丗丝不丈东, float 丗丒丛下与万丗丙丝)
        {
            DynamicStringWrapGrid.三丒一丂丟不七丁上 val_1 = new DynamicStringWrapGrid.三丒一丂丟不七丁上(丗丏丅丕丆世丁专丟:  0);
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
            }
            else
            {
                    mem[40] = this;
                mem[32] = 丙业与丙丗丝不丈东;
            }
            
            .丗丒丛下与万丗丙丝 = 丗丒丛下与万丗丙丝;
            return (System.Collections.IEnumerator)val_1;
        }
        private void LateUpdate()
        {
            float val_8;
            var val_10;
            float val_11;
            int val_12;
            UIScrollView val_13;
            var val_14;
            if(this.丟东不丅丙丆专丝丟 == false)
            {
                    return;
            }
            
            float val_8 = this.丒丅业丈丒丗丆丆丁;
            val_8 = this.世丕丞三一丞世与万;
            val_8 = val_8 + val_8;
            this.丒丅业丈丒丗丆丆丁 = val_8;
            if(val_8 == 0f)
            {
                goto label_22;
            }
            
            float val_9 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            val_9 = val_8 / val_9;
            int val_1 = UnityEngine.Mathf.Abs(value:  (int)val_9);
            val_10 = 0;
            float val_3 = (UnityEngine.Mathf.Sign(f:  this.世丕丞三一丞世与万)) * ((float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize);
            if(this.scrollView.movement == 0)
            {
                    float val_10 = (float)this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
                val_10 = (UnityEngine.Mathf.Sign(f:  this.世丕丞三一丞世与万)) * val_10;
                val_10 = 0;
            }
            
            if(val_1 >= 1)
            {
                    var val_11 = val_1;
                do
            {
                val_11 = val_11 - 1;
            }
            while(val_11 != 0);
            
            }
            
            val_11 = this.世丕丞三一丞世与万;
            if((this.<业丐丈三不东丑专丈>k__BackingField) == null)
            {
                    val_11 = this.世丕丞三一丞世与万;
            }
            
            val_12 = this.<业丐丈三不东丑专丈>k__BackingField.itemSize;
            val_11 = (UnityEngine.Mathf.Sign(f:  val_11)) * ((float)val_12 * val_1);
            val_13 = this.scrollView;
            if(this.scrollView == null)
            {
                    val_13 = this.scrollView;
            }
            
            val_8 = this.世丕丞三一丞世与万 - val_11;
            if(this.scrollView.movement != 1)
            {
                goto label_19;
            }
            
            val_14 = val_8;
            goto label_20;
            label_19:
            if(this.scrollView.movement != 0)
            {
                goto label_22;
            }
            
            val_13 = this.scrollView;
            val_14 = 0f;
            label_20:
            label_22:
            if(this.丆丌丏丅丏丑丂丈丌 == false)
            {
                goto label_24;
            }
            
            this.丟丌丛一下丁世万不 = true;
            val_12 = 0;
            goto label_26;
            label_29:
            this.UpdateViewItem(丘不丈与丆七丛丞七:  this.<业丐丈三不东丑专丈>k__BackingField.GetComponentsInChildren<PGCompany.DynamicStringWrapGridItem>(includeInactive:  true)[0]);
            val_12 = 1;
            label_26:
            if(val_12 < val_7.Length)
            {
                goto label_29;
            }
            
            label_24:
            this.丟东不丅丙丆专丝丟 = false;
            this.世丕丞三一丞世与万 = 0f;
        }
        public void UpdateContent(System.Collections.Generic.IList<string> 三丏丑不业丏不丂丈)
        {
            System.Collections.Generic.IList<System.String> val_4;
            var val_7;
            this.丟丌丛一下丁世万不 = true;
            if(三丏丑不业丏不丂丈 == null)
            {
                goto label_11;
            }
            
            val_4 = this.丂上丁丑丈上丛七专;
            if(val_4 == null)
            {
                goto label_11;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_4 = val_4.Count;
            var val_7 = 0;
            val_7 = val_7 + 1;
            if(val_4 != 三丏丑不业丏不丂丈.Count)
            {
                goto label_11;
            }
            
            this.丂上丁丑丈上丛七专 = 三丏丑不业丏不丂丈;
            val_7 = 0;
            goto label_13;
            label_16:
            this.UpdateViewItem(丘不丈与丆七丛丞七:  this.<业丐丈三不东丑专丈>k__BackingField.GetComponentsInChildren<PGCompany.DynamicStringWrapGridItem>(includeInactive:  true)[0]);
            val_7 = 1;
            label_13:
            if(val_7 < val_5.Length)
            {
                goto label_16;
            }
            
            return;
            label_11:
            this.SetContent(三丏丑不业丏不丂丈:  三丏丑不业丏不丂丈, 业丛丛世上丈丘丄东:  false);
        }
        public void CenterOnItemContext()
        {
            this.ScrollFromStart(丙业与丙丗丝不丈东:  this.丌丕世丞世丏万丌东(丌丈丒丞七七丟丄业:  0f, 世万专丛与丐丌专不:  this.itemIndexToCenterFromContextMenu), 且丈丌丅业丅下万三:  true);
            this.丒丅业丈丒丗丆丆丁 = 0f;
        }
        public void CenterOnItemSmoothRelativeContext()
        {
            this.ScrollToCenterOnItemSmoothBySpeed(世万专丛与丐丌专不:  this.itemIndexToCenterFromContextMenu, 丗丒丛下与万丗丙丝:  this.smoothScrollSpeed);
        }
        public DynamicStringWrapGrid()
        {
            this.丐丂七丞丗丅丁丙丈 = -1f;
            this.itemIndexToCenterFromContextMenu = 15;
            this.itemsCount = 10;
            this.世丈丞丒七丗一三丕 = 0;
            this.scalingWidthValue = 20f;
            this.丟丌丛一下丁世万不 = true;
            this.scaleWidth = true;
            this.disableDragIfFits = true;
            this.smoothScrollSpeed = 10f;
        }
        private bool 丂丑东丆七东丕丐丆()
        {
            var val_8;
            var val_9;
            System.Collections.Generic.List<PGCompany.DynamicStringWrapGridItem> val_10;
            var val_11;
            val_8 = this;
            if(this.scrollView.isDragging == true)
            {
                goto label_2;
            }
            
            val_9 = 0;
            goto label_3;
            label_8:
            PGCompany.DynamicStringWrapGridItem val_2 = this.<专丐不丛丝丁上丝专>k__BackingField.Item[0];
            if(val_2.wrapIndex == 1)
            {
                goto label_6;
            }
            
            val_9 = 1;
            label_3:
            val_10 = this.<专丐不丛丝丁上丝专>k__BackingField;
            if(val_9 < val_10.Count)
            {
                goto label_8;
            }
            
            label_2:
            val_11 = 0;
            return (bool)(S8 >= S0) ? 1 : 0;
            label_6:
            val_10 = this.scrollView.panel;
            val_8 = this.<专丐不丛丝丁上丝专>k__BackingField.Item[0].Widget;
            return (bool)(S8 >= S0) ? 1 : 0;
        }
    
    }

}
