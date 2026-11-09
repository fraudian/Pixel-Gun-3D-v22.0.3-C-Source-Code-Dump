using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BPWelcomeScreenUI : MonoBehaviour
    {
        // Fields
        internal static readonly string 不不丗丂丆专丝专一;
        private PGCompany.BattlePass.BPWelcomeDot[] 丛丏丞与丄丒丝丝丞;
        private System.Collections.Generic.List<UIWidget> 一丌七业上丄丂丑丗;
        private float _minAlpha;
        private float 三丁与丈丁丛不丙丒;
        private bool 上丛丏丙丙丁一丙业;
        private float 丒丅丘丈三且丗不丁;
        private UIScrollView _scrollView;
        private UICenterOnChild _centerOnChild;
        private PGCompany.BattlePass.BPWelcomeDot _slideDotExample;
        
        // Methods
        private void OnEnable()
        {
            if(PGCompany.BattlePass.BattlePassSettings.Instance == 0)
            {
                    return;
            }
            
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
            {
                    return;
            }
            
            UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  PGCompany.BattlePass.BattlePassSettings.Instance.OpenBPWelcomeScreen);
        }
        private void Start()
        {
            且丐丁世专丝丕丆丁 val_24;
            七丁丌丒万丄专三三 val_25;
            七丁丌丒万丄专三三 val_26;
            var val_27;
            var val_28;
            System.Action<PGCompany.BattlePass.BPWelcomeDot> val_30;
            val_24 = System.Delegate.Combine(a:  this._centerOnChild.onCenter, b:  new UICenterOnChild.且丐丁世专丝丕丆丁(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.BattlePass.BPWelcomeScreenUI::世丆下丈与丈丆七丑(UnityEngine.GameObject 下且专丒下丙丈丈丒)));
            if(this._centerOnChild == null)
            {
                goto label_2;
            }
            
            if(val_24 != null)
            {
                goto label_3;
            }
            
            goto label_6;
            label_2:
            if(val_24 == null)
            {
                goto label_6;
            }
            
            label_3:
            if(null != null)
            {
                    val_24 = 0;
            }
            
            label_6:
            this._centerOnChild.onCenter = val_24;
            val_25 = System.Delegate.Combine(a:  this._scrollView.onDragStarted, b:  new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.BattlePass.BPWelcomeScreenUI::七丑丂且丌下上七丞()));
            if(this._scrollView == null)
            {
                goto label_8;
            }
            
            if(val_25 != null)
            {
                goto label_9;
            }
            
            goto label_12;
            label_8:
            if(val_25 == null)
            {
                goto label_12;
            }
            
            label_9:
            if(null != null)
            {
                    val_25 = 0;
            }
            
            label_12:
            this._scrollView.onDragStarted = val_25;
            val_26 = System.Delegate.Combine(a:  this._scrollView.onStoppedMoving, b:  new UIScrollView.七丁丌丒万丄专三三(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.BattlePass.BPWelcomeScreenUI::丅不丒丆三丙且三丘()));
            if(this._scrollView == null)
            {
                goto label_14;
            }
            
            if(val_26 != null)
            {
                goto label_15;
            }
            
            goto label_18;
            label_14:
            if(val_26 == null)
            {
                goto label_18;
            }
            
            label_15:
            if(null != null)
            {
                    val_26 = 0;
            }
            
            label_18:
            this._scrollView.onStoppedMoving = val_26;
            UnityEngine.Transform val_8 = this._scrollView.transform;
            int val_9 = val_8.childCount;
            this.丛丏丞与丄丒丝丝丞 = new PGCompany.BattlePass.BPWelcomeDot[0];
            val_27 = 0;
            goto label_21;
            label_45:
            UnityEngine.GameObject val_14 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this._slideDotExample.gameObject, 丈东丘丏与丌东东下:  this._slideDotExample.transform.parent, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            PGCompany.BattlePass.BPWelcomeDot val_15 = val_14.GetComponent<PGCompany.BattlePass.BPWelcomeDot>();
            if(this.丛丏丞与丄丒丝丝丞 == null)
            {
                goto label_28;
            }
            
            if(val_15 != null)
            {
                goto label_29;
            }
            
            goto label_32;
            label_28:
            if(val_15 == null)
            {
                goto label_32;
            }
            
            label_29:
            label_32:
            this.丛丏丞与丄丒丝丝丞[136169176] = val_15;
            val_14.SetActive(value:  true);
            UnityEngine.Transform val_16 = val_8.GetChild(index:  1152921505091350528);
            if(1152921505091350528 >= 1)
            {
                    UnityEngine.Vector3 val_18 = val_8.GetChild(index:  0).position;
                UnityEngine.Vector3 val_19 = val_16.position;
                val_19.x = val_18.x - val_19.x;
                this.丒丅丘丈三且丗不丁 = UnityEngine.Mathf.Max(a:  this.丒丅丘丈三且丗不丁, b:  System.Math.Abs(val_19.x));
            }
            
            this.一丌七业上丄丂丑丗.Add(item:  val_16.GetComponent<UIWidget>());
            val_27 = 1;
            label_21:
            if(2 < val_8.childCount)
            {
                goto label_45;
            }
            
            val_28 = null;
            val_28 = null;
            val_30 = BPWelcomeScreenUI.<>c.<>9__8_0;
            if(val_30 == null)
            {
                    System.Action<PGCompany.BattlePass.BPWelcomeDot> val_23 = null;
                val_30 = val_23;
                val_23 = new System.Action<PGCompany.BattlePass.BPWelcomeDot>(object:  BPWelcomeScreenUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BPWelcomeScreenUI.<>c::丑丟与丅丂丂七七丈(PGCompany.BattlePass.BPWelcomeDot 三丟东丕丄丄下下丑));
                BPWelcomeScreenUI.<>c.<>9__8_0 = val_30;
            }
            
            丞东丑专丛丆丄丝世.且三丁且与丆一世下<PGCompany.BattlePass.BPWelcomeDot>(丌丛丏业世丄丞三丌:  this.丛丏丞与丄丒丝丝丞, 七丐丅专且专七三丆:  val_23);
            this.下业七且丛丐丆丙丕(丞世不丒下上上丝丑:  0);
        }
        public void NextSlide()
        {
            if(this.上丛丏丙丙丁一丙业 != true)
            {
                    int val_5 = this.丆丑丕且下丒丟丏七();
                val_5 = val_5 + 1;
                if(val_5 < this._scrollView.transform.childCount)
            {
                    this.下业七且丛丐丆丙丕(丞世不丒下上上丝丑:  val_5);
            }
            else
            {
                    this.gameObject.SetActive(value:  false);
            }
            
            }
            
            this.上丛丏丙丙丁一丙业 = false;
        }
        private void Update()
        {
            goto label_1;
            label_11:
            float val_11 = this.丒丅丘丈三且丗不丁;
            UnityEngine.Vector3 val_3 = this.一丌七业上丄丂丑丗.Item[0].transform.position;
            UnityEngine.Vector3 val_5 = this.transform.position;
            val_5.x = val_3.x - val_5.x;
            val_11 = (UnityEngine.Mathf.Min(a:  val_11, b:  System.Math.Abs(val_5.x))) / this.丒丅丘丈三且丗不丁;
            val_11 = 1f - val_11;
            UIWidget val_7 = this.一丌七业上丄丂丑丗.Item[0];
            float val_8 = 1f - this._minAlpha;
            val_8 = val_11 * val_8;
            val_8 = this._minAlpha + val_8;
            0 = 1;
            label_1:
            if(0 < this.一丌七业上丄丂丑丗.Count)
            {
                goto label_11;
            }
        
        }
        private void 七丑丂且丌下上七丞()
        {
            this.上丛丏丙丙丁一丙业 = true;
        }
        private void 丅不丒丆三丙且三丘()
        {
            this.上丛丏丙丙丁一丙业 = false;
        }
        private void 下业七且丛丐丆丙丕(int 丞世不丒下上上丝丑)
        {
            if(this._scrollView.transform.childCount <= 丞世不丒下上上丝丑)
            {
                    return;
            }
            
            this._centerOnChild.CenterOn(丞下万上三丘上与专:  this._scrollView.transform.GetChild(index:  丞世不丒下上上丝丑));
        }
        private int 丆丑丕且下丒丟丏七()
        {
            var val_7;
            UnityEngine.Transform val_1 = this._scrollView.transform;
            val_7 = 0;
            goto label_2;
            label_10:
            if((val_1.GetChild(index:  0).gameObject) == this._centerOnChild.centeredObject)
            {
                    return 0;
            }
            
            val_7 = 1;
            label_2:
            if(val_7 < val_1.childCount)
            {
                goto label_10;
            }
            
            return 0;
        }
        private void 世丆下丈与丈丆七丑(UnityEngine.GameObject 下且专丒下丙丈丈丒)
        {
            var val_3 = 0;
            goto label_0;
            label_5:
            this.丛丏丞与丄丒丝丝丞[0].世不丅东世丌丏丗三(丂丛丑东不丅丈一东:  (this.丆丑丕且下丒丟丏七() == val_3) ? 1 : 0);
            val_3 = 1;
            label_0:
            if(val_3 < this.丛丏丞与丄丒丝丝丞.Length)
            {
                goto label_5;
            }
        
        }
        public BPWelcomeScreenUI()
        {
            this.一丌七业上丄丂丑丗 = new System.Collections.Generic.List<UIWidget>();
        }
        private static BPWelcomeScreenUI()
        {
            PGCompany.BattlePass.BPWelcomeScreenUI.不不丗丂丆专丝专一 = "BPWelcomeScreenUI_LastSeasonIdSeen";
        }
    
    }

}
