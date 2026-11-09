using UnityEngine;

namespace Rilisoft
{
    public class GameEventMultyDrop : MonoBehaviour
    {
        // Fields
        public float autoHideTime;
        public UIWidget[] dropWidgets;
        public UIBasicSprite[] dropTextures;
        public UIBasicSprite[] dropBackgrounds;
        public UILabel[] labels;
        public UILabel[] countLabels;
        public UnityEngine.Transform[] drops;
        public UnityEngine.Transform[] slots;
        private float[] 且丑丛一上丗丘一丞;
        private float[] 专丞世丅丆专丏丈丐;
        public bool _Test;
        public UnityEngine.AnimationCurve curva;
        public UIWidget[][] widgets;
        private bool 丆下丅丌万丟丙丛与;
        
        // Methods
        private UIBasicSprite 丌丟三丅上丅上丗丞(int 丞丅上丏丂且下丅与)
        {
            mem2[0] = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.dropTextures[(long)丞丅上丏丂且下丅与]);
            return (UIBasicSprite)this.dropTextures[(long)丞丅上丏丂且下丅与];
        }
        private UIBasicSprite 丛丞且丗丒七丏丛丙(int 丞丅上丏丂且下丅与)
        {
            UIBasicSprite val_3;
            UIBasicSprite val_4;
            if(this.dropBackgrounds != null)
            {
                    if((this.dropBackgrounds.Length - 1) >= 丞丅上丏丂且下丅与)
            {
                goto label_2;
            }
            
            }
            
            val_4 = 0;
            return val_4;
            label_2:
            val_3 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.dropBackgrounds[(long)丞丅上丏丂且下丅与]);
            mem2[0] = val_3;
            val_4 = this.dropBackgrounds[(long)丞丅上丏丂且下丅与];
            return val_4;
        }
        private void 且丅丟丂三丆丏七丛()
        {
            goto label_0;
            label_5:
            if(this.且丑丛一上丗丘一丞[0] == 2f)
            {
                goto label_3;
            }
            
            0 = 1;
            label_0:
            if(0 < this.且丑丛一上丗丘一丞.Length)
            {
                goto label_5;
            }
            
            return;
            label_3:
            this.且丑丛一上丗丘一丞[0] = 0f;
            this.三专丒东丐三丆丒丂(丞丅上丏丂且下丅与:  0);
            this.drops[0].gameObject.SetActive(value:  true);
        }
        private void Awake()
        {
            var val_11;
            UIBasicSprite[] val_12;
            var val_13;
            if(this.丆下丅丌万丟丙丛与 == true)
            {
                    return;
            }
            
            this.丆下丅丌万丟丙丛与 = true;
            this.且丑丛一上丗丘一丞 = new float[4] {8.96831E-44f, 8.96831E-44f, 8.96831E-44f, 8.96831E-44f};
            this.专丞世丅丆专丏丈丐 = new float[4];
            val_11 = 0;
            goto label_2;
            label_14:
            UIBasicSprite val_3 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.dropTextures[0]);
            if(this.dropTextures == null)
            {
                goto label_7;
            }
            
            if(val_3 != null)
            {
                goto label_8;
            }
            
            goto label_11;
            label_7:
            if(val_3 == null)
            {
                goto label_11;
            }
            
            label_8:
            label_11:
            val_11 = 1;
            this.dropTextures[0] = val_3;
            label_2:
            if(val_11 < this.dropTextures.Length)
            {
                goto label_14;
            }
            
            val_12 = this.dropBackgrounds;
            if(val_12 == null)
            {
                goto label_15;
            }
            
            val_13 = 0;
            goto label_16;
            label_31:
            UIBasicSprite val_12 = this.dropBackgrounds[0];
            if(val_12 == 0)
            {
                goto label_21;
            }
            
            UIBasicSprite val_5 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  val_12);
            if(this.dropBackgrounds == null)
            {
                goto label_24;
            }
            
            if(val_5 != null)
            {
                goto label_25;
            }
            
            goto label_28;
            label_24:
            if(val_5 == null)
            {
                goto label_28;
            }
            
            label_25:
            label_28:
            this.dropBackgrounds[0] = val_5;
            label_21:
            val_12 = this.dropBackgrounds;
            val_13 = 1;
            label_16:
            if(val_13 < this.dropBackgrounds.Length)
            {
                goto label_31;
            }
            
            label_15:
            UIWidget[][] val_10 = new UIWidget[][4];
            val_10[0] = this.drops[0].GetComponentsInChildren<UIWidget>(includeInactive:  true);
            val_10[1] = this.drops[1].GetComponentsInChildren<UIWidget>(includeInactive:  true);
            val_10[2] = this.drops[2].GetComponentsInChildren<UIWidget>(includeInactive:  true);
            val_10[3] = this.drops[3].GetComponentsInChildren<UIWidget>(includeInactive:  true);
            this.widgets = val_10;
        }
        private void 三专丒东丐三丆丒丂(int 丞丅上丏丂且下丅与)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            UIWidget[] val_17;
            var val_18;
            val_13 = 0;
            val_14 = (long)丞丅上丏丂且下丅与;
            var val_17 = 4;
            do
            {
                var val_1 = val_17 - 4;
                this.dropWidgets[val_14] = this.dropWidgets[0].depth - this.dropWidgets[val_14].depth;
                if(this.dropWidgets[val_14] > val_13)
            {
                    val_13 = this.dropWidgets[0].depth - this.dropWidgets[val_14].depth;
            }
            
                val_17 = val_17 + 1;
            }
            while(val_17 != 8);
            
            val_15 = 0;
            val_13 = val_13 + 7;
            goto label_14;
            label_24:
            UIWidget val_19 = this.widgets[val_14][0];
            if(val_19 != null)
            {
                    val_16 = val_19.depth;
            }
            else
            {
                    val_16 = 0.depth;
            }
            
            val_19.depth = val_13 + val_16;
            val_15 = 1;
            label_14:
            UIWidget[] val_20 = this.widgets[val_14];
            if(val_15 < this.widgets[(long)(int)(丞丅上丏丂且下丅与)][0].Length)
            {
                goto label_24;
            }
            
            val_17 = this.dropWidgets;
            if(val_17[val_14].depth < 1001)
            {
                    return;
            }
            
            val_18 = 0;
            goto label_29;
            label_42:
            val_14 = 0;
            goto label_30;
            label_40:
            UIWidget val_23 = this.widgets[0][0];
            if(val_23 != null)
            {
                    val_17 = val_23.depth;
            }
            else
            {
                    val_17 = 0.depth;
            }
            
            val_23.depth = val_17 - 1000;
            val_14 = 1;
            label_30:
            UIWidget[] val_24 = this.widgets[0];
            if(val_14 < this.widgets[0x0][0].Length)
            {
                goto label_40;
            }
            
            val_18 = 1;
            label_29:
            if(val_18 < this.widgets.Length)
            {
                goto label_42;
            }
        
        }
        private void Update()
        {
            var val_3;
            var val_4;
            if(this._Test != false)
            {
                    this.且丅丟丂三丆丏七丛();
                this._Test = false;
            }
            
            val_3 = 0;
            goto label_1;
            label_10:
            if(this.且丑丛一上丗丘一丞[0] < 0)
            {
                    this.丛七丄丕一丁丂丐丗(丈不业下丌七丆丒丙:  this.drops[0], 丛东丄不下丄上丕不: ref  this.且丑丛一上丗丘一丞[0][32], 丞丅上丏丂且下丅与:  0);
            }
            
            val_3 = 1;
            label_1:
            if(val_3 < this.且丑丛一上丗丘一丞.Length)
            {
                goto label_10;
            }
            
            val_4 = 0;
            goto label_11;
            label_20:
            if(this.专丞世丅丆专丏丈丐[0] > 0f)
            {
                    this.丛业丐丕丟上上万丁(业一丑专上丑丒世丟:  this.dropWidgets[0], 丂三丟丂丈丐丆丗丟: ref  this.专丞世丅丆专丏丈丐[0][32], 丞丅上丏丂且下丅与:  0);
            }
            
            val_4 = 1;
            label_11:
            if(val_4 < this.专丞世丅丆专丏丈丐.Length)
            {
                goto label_20;
            }
        
        }
        private void OnDisable()
        {
            UnityEngine.GameObject val_2;
            var val_3;
            var val_4;
            val_2 = this;
            val_3 = 0;
            goto label_1;
            label_5:
            val_3 = 1;
            this.专丞世丅丆专丏丈丐[0] = 0f;
            label_1:
            if(val_3 < this.专丞世丅丆专丏丈丐.Length)
            {
                goto label_5;
            }
            
            val_4 = 0;
            goto label_6;
            label_12:
            val_2 = this.drops[0].gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  false);
            val_4 = 1;
            label_6:
            if(val_4 < this.drops.Length)
            {
                goto label_12;
            }
        
        }
        public void Show(Rilisoft.GameEventItemData 下丅丙一丂丗丅丝七)
        {
            int val_50;
            var val_51;
            var val_52;
            float val_53;
            UnityEngine.Object val_54;
            var val_55;
            var val_56;
            UnityEngine.Color val_57;
            val_50 = 下丅丙一丂丗丅丝七;
            val_51 = this;
            if(this.丆下丅丌万丟丙丛与 != true)
            {
                    this.Awake();
            }
            
            val_52 = 0;
            val_53 = 2f;
            goto label_2;
            label_7:
            if(this.且丑丛一上丗丘一丞[0] == val_53)
            {
                goto label_5;
            }
            
            val_52 = 1;
            label_2:
            if(val_52 < this.且丑丛一上丗丘一丞.Length)
            {
                goto label_7;
            }
            
            return;
            label_5:
            this.且丑丛一上丗丘一丞[0] = 0f;
            UIBasicSprite val_1 = this.丌丟三丅上丅上丗丞(丞丅上丏丂且下丅与:  0);
            val_54 = val_50.丑东丐下专丞丕丘世();
            UILabel val_51 = this.labels[0];
            if(val_50.Type == 500)
            {
                    if(val_50.Count > 0)
            {
                goto label_20;
            }
            
            }
            
            if(val_50.Type != 800)
            {
                    if(val_50.Type != 1600)
            {
                goto label_22;
            }
            
            }
            
            label_20:
            val_51.gameObject.SetActive(value:  true);
            string val_9 = val_50.Count.ToString();
            if(val_51 != null)
            {
                    val_51.text = val_9;
            }
            else
            {
                    0.text = val_9;
            }
            
            string val_52 = "CoinsCurrency";
            val_52 = System.String.op_Equality(a:  val_50.Id, b:  val_52);
            val_51.transform.GetChild(index:  0).gameObject.SetActive(value:  val_52);
            string val_53 = "GemsCurrency";
            val_53 = System.String.op_Equality(a:  val_50.Id, b:  val_53);
            val_51.transform.GetChild(index:  1).gameObject.SetActive(value:  val_53);
            string val_54 = "EventCurrency";
            val_54 = System.String.op_Equality(a:  val_50.Id, b:  val_54);
            val_51.transform.GetChild(index:  2).gameObject.SetActive(value:  val_54);
            val_54 = val_51.transform.GetChild(index:  3).gameObject;
            if(val_50.Type != 800)
            {
                goto label_46;
            }
            
            val_55 = 1;
            if(val_54 != null)
            {
                goto label_50;
            }
            
            goto label_48;
            label_46:
            if(val_54 != null)
            {
                goto label_50;
            }
            
            label_48:
            label_50:
            val_54.SetActive(value:  (val_50.Type == 1600) ? 1 : 0);
            if(val_50.Type != 800)
            {
                goto label_58;
            }
            
            val_54 = val_51.transform.GetChild(index:  3).GetComponent<UISprite>();
            if(val_54 == 0)
            {
                goto label_58;
            }
            
            三丅丁丗丗丝丂万且 val_37 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_50.Id);
            if(val_37 == null)
            {
                goto label_62;
            }
            
            val_56 = (long)val_37;
            goto label_63;
            label_22:
            val_51.gameObject.SetActive(value:  false);
            val_50 = System.String.alignConst;
            val_51.text = val_50;
            goto label_81;
            label_62:
            val_56 = 5;
            label_63:
            val_57 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5];
            val_53 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5];
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_54, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5], g = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄()[5], b = val_57, a = val_53});
            label_58:
            if(val_50.Type == 1600)
            {
                    UISprite val_43 = val_51.transform.GetChild(index:  3).GetComponent<UISprite>();
                if(val_43 != 0)
            {
                    PGCompany.七丟丘不下万丙丄下 val_47 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.七丟丘不下万丙丄下>(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  val_50.Id);
                if(val_47 != null)
            {
                    val_54 = (long)val_47;
            }
            else
            {
                    val_54 = 5;
            }
            
                val_50 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
                val_57 = val_50[5];
                val_53 = val_50[5];
                丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  val_43, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_50[5], g = val_50[5], b = val_57, a = val_53});
            }
            
            }
            
            label_81:
            this.三专丒东丐三丆丒丂(丞丅上丏丂且下丅与:  0);
            val_51 = this.drops[0].gameObject;
            val_51.SetActive(value:  true);
        }
        public void Show(ClanItem 下丅丙一丂丗丅丝七)
        {
            string val_14;
            var val_15;
            var val_16;
            string val_17;
            val_14 = 下丅丙一丂丗丅丝七;
            val_15 = this;
            if(this.丆下丅丌万丟丙丛与 != true)
            {
                    this.Awake();
            }
            
            val_16 = 0;
            goto label_2;
            label_7:
            if(this.且丑丛一上丗丘一丞[0] == 2f)
            {
                goto label_5;
            }
            
            val_16 = 1;
            label_2:
            if(val_16 < this.且丑丛一上丗丘一丞.Length)
            {
                goto label_7;
            }
            
            return;
            label_5:
            this.且丑丛一上丗丘一丞[0] = 0f;
            UIBasicSprite val_1 = this.丌丟三丅上丅上丗丞(丞丅上丏丂且下丅与:  0);
            UnityEngine.Texture val_2 = val_14.Texture;
            if((this.丛丞且丗丒七丏丛丙(丞丅上丏丂且下丅与:  0)) != 0)
            {
                    UnityEngine.Texture val_5 = val_14.BackgroundTexture;
            }
            
            val_17 = val_14.LocalizedName;
            this.labels[0].text = val_17;
            if((this.countLabels != null) && (val_16 <= (this.countLabels.Length - 1)))
            {
                    UILabel val_16 = this.countLabels[0];
                if(val_16 != 0)
            {
                    val_17 = val_16.gameObject;
                if(val_14.Type == 100)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_17, 丏业丟一东丂东丘丛:  false);
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_17, 丏业丟一东丂东丘丛:  true);
                val_14 = System.String.Format(format:  "x{0}", arg0:  val_14.Count);
                val_16.text = val_14;
            }
            
            }
            
            }
            
            this.三专丒东丐三丆丒丂(丞丅上丏丂且下丅与:  0);
            val_15 = this.drops[0].gameObject;
            val_15.SetActive(value:  true);
        }
        private void 丛七丄丕一丁丂丐丗(UnityEngine.Transform 丈不业下丌七丆丒丙, ref float 丛东丄不下丄上丕不, int 丞丅上丏丂且下丅与)
        {
            System.Single[] val_10;
            var val_11;
            val_10 = 1152921542123790592;
            UIWidget val_10 = this.dropWidgets[(long)丞丅上丏丂且下丅与];
            if(S0 != 1f)
            {
                    if(this.dropWidgets.Length <= 丞丅上丏丂且下丅与)
            {
                    val_11 = 0;
            }
            
                UIWidget val_11 = this.dropWidgets[(long)丞丅上丏丂且下丅与];
            }
            
            float val_12 = 丛东丄不下丄上丕不;
            float val_1 = UnityEngine.Time.unscaledDeltaTime;
            val_12 = val_12 + val_1;
            丛东丄不下丄上丕不 = val_12;
            val_1 = val_12 + val_12;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_4 = this.slots[(long)丞丅上丏丂且下丅与].localPosition;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.LerpUnclamped(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, t:  this.curva.Evaluate(time:  val_1));
            丈不业下丌七丆丒丙.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, t:  丛东丄不下丄上丕不 * 4f);
            丈不业下丌七丆丒丙.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            if(丛东丄不下丄上丕不 < 1f)
            {
                    return;
            }
            
            val_10 = this.专丞世丅丆专丏丈丐;
            val_10[(long)丞丅上丏丂且下丅与] = this.autoHideTime;
        }
        private void 丛业丐丕丟上上万丁(UIWidget 业一丑专上丑丒世丟, ref float 丂三丟丂丈丐丆丗丟, int 丞丅上丏丂且下丅与)
        {
            float val_5 = 丂三丟丂丈丐丆丗丟;
            val_5 = val_5 - UnityEngine.Time.unscaledDeltaTime;
            丂三丟丂丈丐丆丗丟 = val_5;
            float val_3 = UnityEngine.Mathf.Lerp(a:  0f, b:  1f, t:  val_5 / this.autoHideTime);
            if(丂三丟丂丈丐丆丗丟 > 0f)
            {
                    return;
            }
            
            1152921542124164608 = this.drops[(long)丞丅上丏丂且下丅与].gameObject;
            1152921542124164608.SetActive(value:  false);
            this.且丑丛一上丗丘一丞[(long)丞丅上丏丂且下丅与] = 2f;
        }
        public GameEventMultyDrop()
        {
            this.autoHideTime = 2f;
        }
    
    }

}
