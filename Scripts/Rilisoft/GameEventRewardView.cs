using UnityEngine;

namespace Rilisoft
{
    public class GameEventRewardView : MonoBehaviour
    {
        // Fields
        private ArmoryInfoScreenController 下丏丗且丅丟丄丂与;
        private UnityEngine.Coroutine 不丏丅上丁且七与丐;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private Rilisoft.GameEventItemData _data;
        private Rilisoft.GameEventItem _item;
        private bool 万丄丄丝丙一丐七东;
        private 三丅丁丗丗丝丂万且 三丐三丞丘丕不丒专;
        private UnityEngine.GameObject _collectButtonGo;
        private UIButton _okButtonComponent;
        private System.Action 专世丐丂世丞丌且丛;
        private UnityEngine.GameObject _window;
        private UnityEngine.GameObject _touchBlocker;
        private float _autoHideDelay;
        private UIBasicSprite _itemTexture;
        private Rilisoft.TextGroup _headerText;
        private Rilisoft.TextGroup _rewardText;
        private UILabel _rewardDescriptionLabel;
        
        // Properties
        private UIBasicSprite 下丝万丄丕世丝丝与 { get; }
        private Rilisoft.GameEventItemData 丞丑且东丌与丏丏丁 { get; }
        
        // Methods
        private UIBasicSprite 丑世丝世丈世丌丝七()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._itemTexture);
            this._itemTexture = val_1;
            return val_1;
        }
        private Rilisoft.GameEventItemData 丁专丗万三上丟三丆()
        {
            if(this._item == null)
            {
                    return (Rilisoft.GameEventItemData)this._data;
            }
            
            return this._item.Data;
        }
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
            while(this.专世丐丂世丞丌且丛 != 1152921542842453072);
        
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
            while(this.专世丐丂世丞丌且丛 != 1152921542842589648);
        
        }
        private void OnEnable()
        {
            this.万丄丄丝丙一丐七东 = false;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.一业上万一万丟三丕());
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void Rilisoft.GameEventRewardView::Hide()), 与且专丈不万东一万:  0);
            TweenScale val_8 = this.gameObject.GetComponentInChildren<TweenScale>();
            if(val_8 != 0)
            {
                    val_8.enabled = true;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._collectButtonGo, 丏业丟一东丂东丘丛:  true);
            if(this._okButtonComponent == 0)
            {
                    return;
            }
            
            this._okButtonComponent.enabled = false;
        }
        private void OnDisable()
        {
            this.万丄丄丝丙一丐七东 = false;
            if(this.不丏丅上丁且七与丐 != null)
            {
                    CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this.不丏丅上丁且七与丐);
                this.不丏丅上丁且七与丐 = 0;
            }
            
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        private void Update()
        {
        
        }
        private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
        {
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            this.Hide();
        }
        private System.Collections.IEnumerator 一业上万一万丟三丕()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new GameEventRewardView.东丑与丌丌上不七不();
        }
        public void ShowAsReward(System.Action 丌不丞丁七丂万上丏)
        {
            if(this.gameObject.activeSelf == true)
            {
                    return;
            }
            
            this.专世丐丂世丞丌且丛 = 丌不丞丁七丂万上丏;
            this.gameObject.SetActive(value:  true);
            this.丂三丗丐丆丌丌丏七(丗丛丑不丕丟万丒丆:  false);
            this = this.不丏丅上丁且七与丐;
            if(this == null)
            {
                    return;
            }
            
            CoroutineRunner.丌丄丏下七丁专丂世(丂丒丐下丑丏丐专上:  this);
        }
        public void ShowAsInfo(Rilisoft.GameEventItem 下丅丙一丂丗丅丝七)
        {
            UnityEngine.Debug.LogError(message:  " ********* ShowAsInfo ********* ");
            if(this.gameObject.activeSelf == true)
            {
                    return;
            }
            
            this.专世丐丂世丞丌且丛 = 0;
            this.gameObject.SetActive(value:  true);
            this._data = 0;
            this._item = 下丅丙一丂丗丅丝七;
            this.丂三丗丐丆丌丌丏七(丗丛丑不丕丟万丒丆:  true);
            this = this.gameObject.GetComponentInChildren<TweenScale>();
            if(this == 0)
            {
                    return;
            }
            
            if(this != null)
            {
                    this.enabled = false;
            }
            else
            {
                    0.enabled = false;
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        }
        internal void 丘丌丙与不丝下万丐()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._collectButtonGo, 丏业丟一东丂东丘丛:  false);
            if(this._okButtonComponent == 0)
            {
                    return;
            }
            
            this._okButtonComponent.enabled = true;
        }
        public void ShowAsInfo(Rilisoft.GameEventItemData 一丐丗丁丞丆丅丟丄)
        {
            if(this.gameObject.activeSelf == true)
            {
                    return;
            }
            
            this.专世丐丂世丞丌且丛 = 0;
            this.gameObject.SetActive(value:  true);
            this._data = 一丐丗丁丞丆丅丟丄;
            this._item = 0;
            this.丂三丗丐丆丌丌丏七(丗丛丑不丕丟万丒丆:  true);
            this = this.gameObject.GetComponentInChildren<TweenScale>();
            if(this == 0)
            {
                    return;
            }
            
            if(this != null)
            {
                    this.enabled = false;
            }
            else
            {
                    0.enabled = false;
            }
            
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
            this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        }
        public void SetItem(Rilisoft.GameEventItem 下丅丙一丂丗丅丝七)
        {
            this._data = 0;
            this._item = 下丅丙一丂丗丅丝七;
            this.丂三丗丐丆丌丌丏七(丗丛丑不丕丟万丒丆:  false);
        }
        public void SetData(Rilisoft.GameEventItemData 一丐丗丁丞丆丅丟丄)
        {
            this._data = 一丐丗丁丞丆丅丟丄;
            this._item = 0;
            this.丂三丗丐丆丌丌丏七(丗丛丑不丕丟万丒丆:  false);
        }
        public void Hide()
        {
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  25);
            this.gameObject.SetActive(value:  false);
            if(this.下丏丗且丅丟丄丂与 != 0)
            {
                    if(this.下丏丗且丅丟丄丂与.gameObject != 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.下丏丗且丅丟丄丂与.gameObject);
                this.下丏丗且丅丟丄丂与 = 0;
            }
            
            }
            
            if(this.专世丐丂世丞丌且丛 != null)
            {
                    this.专世丐丂世丞丌且丛 = 0;
                this.专世丐丂世丞丌且丛.Invoke();
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        public void U_HideRequest()
        {
            if(this.万丄丄丝丙一丐七东 == false)
            {
                    return;
            }
            
            this.Hide();
        }
        private void 丂三丗丐丆丌丌丏七(bool 丗丛丑不丕丟万丒丆)
        {
            string val_123;
            object val_124;
            var val_125;
            丙且上东下丏丏丟下 val_126;
            CategoryNames val_127;
            string val_129;
            var val_130;
            Rilisoft.GameEventItemData val_131;
            Rilisoft.GameEventItemData val_132;
            Rilisoft.GameEventItemData val_133;
            Rilisoft.GameEventItemData val_135;
            Rilisoft.GameEventItemData val_136;
            Rilisoft.GameEventItemData val_137;
            string val_139;
            var val_140;
            Rilisoft.GameEventItemData val_141;
            Rilisoft.GameEventItemData val_142;
            Rilisoft.GameEventItemData val_143;
            Rilisoft.GameEventItemData val_144;
            val_124 = this;
            if(this._item == null)
            {
                goto label_1;
            }
            
            if(this._item.Data != null)
            {
                goto label_2;
            }
            
            return;
            label_1:
            if(this._data == null)
            {
                    return;
            }
            
            label_2:
            if(this._item == null)
            {
                goto label_5;
            }
            
            Rilisoft.GameEventItemData val_2 = this._item.Data;
            if(val_2 != null)
            {
                goto label_44;
            }
            
            label_45:
            label_44:
            val_125 = 1152921505317388288;
            三丅丁丗丗丝丂万且 val_4 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_2.Id);
            this.三丐三丞丘丕不丒专 = val_4;
            if(val_4 != null)
            {
                goto label_9;
            }
            
            if(this._item == null)
            {
                goto label_10;
            }
            
            Rilisoft.GameEventItemData val_5 = this._item.Data;
            if(val_5 != null)
            {
                goto label_86;
            }
            
            label_87:
            label_86:
            this.三丐三丞丘丕不丒专 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  val_5.Id);
            label_9:
            if(this._item == null)
            {
                goto label_14;
            }
            
            val_123 = this._item.Data;
            if(val_123 != null)
            {
                goto label_46;
            }
            
            label_47:
            label_46:
            if((val_123.Type == 100) && (this.三丐三丞丘丕不丒专 != null))
            {
                    if(this.三丐三丞丘丕不丒专.东七与与不丅丙上上() == false)
            {
                goto label_18;
            }
            
            }
            
            if(this._item == null)
            {
                goto label_19;
            }
            
            val_123 = this._item.Data;
            if(val_123 != null)
            {
                goto label_48;
            }
            
            label_49:
            label_48:
            if(val_123.Type != 1300)
            {
                goto label_21;
            }
            
            label_18:
            if(this._item == null)
            {
                goto label_22;
            }
            
            Rilisoft.GameEventItemData val_13 = this._item.Data;
            if(val_13 != null)
            {
                goto label_50;
            }
            
            label_51:
            label_50:
            Rilisoft.GameEventItemType val_14 = val_13.Type;
            if(val_14 == 100)
            {
                goto label_24;
            }
            
            if(val_14 != 1300)
            {
                    return;
            }
            
            if(this._item == null)
            {
                goto label_26;
            }
            
            Rilisoft.GameEventItemData val_15 = this._item.Data;
            if(val_15 != null)
            {
                goto label_166;
            }
            
            label_167:
            label_166:
            val_123 = val_15.Id;
            val_126 = new 丙且上东下丏丏丟下();
            val_127 = 7;
            goto label_28;
            label_21:
            this._window.gameObject.SetActive(value:  true);
            this._touchBlocker.gameObject.SetActive(value:  true);
            UIBasicSprite val_19 = this.丑世丝世丈世丌丝七();
            if(this._item == null)
            {
                goto label_33;
            }
            
            Rilisoft.GameEventItemData val_20 = this._item.Data;
            if(val_20 != null)
            {
                goto label_82;
            }
            
            label_83:
            label_82:
            UnityEngine.Texture val_21 = val_20.丑东丐下专丞丕丘世();
            if(this._item == null)
            {
                goto label_36;
            }
            
            Rilisoft.GameEventItemData val_22 = this._item.Data;
            if(val_22 != null)
            {
                goto label_84;
            }
            
            label_85:
            label_84:
            if(val_22.Type != 800)
            {
                goto label_38;
            }
            
            if(this._item == null)
            {
                goto label_41;
            }
            
            Rilisoft.GameEventItemData val_25 = this._item.Data;
            if(val_25 != null)
            {
                goto label_156;
            }
            
            label_157:
            label_156:
            string val_27 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4726"), arg0:  val_25.Count);
            goto label_59;
            label_5:
            if(this._data != null)
            {
                goto label_44;
            }
            
            goto label_45;
            label_14:
            if(this._data != null)
            {
                goto label_46;
            }
            
            goto label_47;
            label_19:
            if(this._data != null)
            {
                goto label_48;
            }
            
            goto label_49;
            label_22:
            if(this._data != null)
            {
                goto label_50;
            }
            
            goto label_51;
            label_38:
            if(this._item == null)
            {
                goto label_52;
            }
            
            Rilisoft.GameEventItemData val_28 = this._item.Data;
            if(val_28 != null)
            {
                goto label_158;
            }
            
            label_159:
            label_158:
            if(this._item == null)
            {
                goto label_54;
            }
            
            Rilisoft.GameEventItemData val_30 = this._item.Data;
            if(val_30 != null)
            {
                goto label_160;
            }
            
            label_161:
            label_160:
            if(val_28.Type != 500)
            {
                goto label_56;
            }
            
            if(this._item == null)
            {
                goto label_57;
            }
            
            Rilisoft.GameEventItemData val_32 = this._item.Data;
            if(val_32 != null)
            {
                goto label_182;
            }
            
            label_183:
            label_182:
            string val_34 = System.String.Format(format:  "{0} {1}", arg0:  val_30.Count, arg1:  val_32.与丆业丅上丗七丆一());
            goto label_59;
            label_24:
            val_123 = this.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛();
            val_126 = new 丙且上东下丏丏丟下();
            val_127 = this.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() - 1;
            label_28:
            val_126 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_123, 七丆丒与丗丌丄且丂:  val_127);
            if(val_126 == null)
            {
                    return;
            }
            
            this._window.gameObject.SetActive(value:  false);
            this._touchBlocker.gameObject.SetActive(value:  false);
            val_125 = 1152921504848912384;
            if(this.下丏丗且丅丟丄丂与 != 0)
            {
                    if(this.下丏丗且丅丟丄丂与.gameObject != 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.下丏丗且丅丟丄丂与.gameObject);
                this.下丏丗且丅丟丄丂与 = 0;
            }
            
            }
            
            ArmoryInfoScreenController.丘万丕丟丄丂丁东丈(丙业与丙丗丝不丈东:  true);
            UnityEngine.Object val_45 = UnityEngine.Object.Instantiate(original:  UnityEngine.Resources.Load(path:  "ArmoryInfoScreenForEvent"));
            if(val_45 == null)
            {
                goto label_79;
            }
            
            var val_46 = (null == null) ? (val_45) : 0;
            goto label_81;
            label_33:
            if(this._data != null)
            {
                goto label_82;
            }
            
            goto label_83;
            label_36:
            if(this._data != null)
            {
                goto label_84;
            }
            
            goto label_85;
            label_10:
            if(this._data != null)
            {
                goto label_86;
            }
            
            goto label_87;
            label_56:
            label_59:
            val_129 = val_30.与丆业丅上丗七丆一();
            if(this._item == null)
            {
                goto label_88;
            }
            
            Rilisoft.GameEventItemData val_48 = this._item.Data;
            if(val_48 != null)
            {
                goto label_122;
            }
            
            label_123:
            label_122:
            if(val_48.Count < 2)
            {
                goto label_96;
            }
            
            if(this._item == null)
            {
                goto label_91;
            }
            
            Rilisoft.GameEventItemData val_50 = this._item.Data;
            if(val_50 != null)
            {
                goto label_162;
            }
            
            label_163:
            label_162:
            if(val_50.Type == 1100)
            {
                goto label_93;
            }
            
            if(this._item == null)
            {
                goto label_94;
            }
            
            Rilisoft.GameEventItemData val_52 = this._item.Data;
            if(val_52 != null)
            {
                goto label_184;
            }
            
            label_185:
            label_184:
            if(val_52.Type != 1200)
            {
                goto label_96;
            }
            
            label_93:
            if(this._item == null)
            {
                goto label_97;
            }
            
            Rilisoft.GameEventItemData val_54 = this._item.Data;
            if(val_54 != null)
            {
                goto label_168;
            }
            
            label_169:
            label_168:
            if(this._item == null)
            {
                goto label_99;
            }
            
            Rilisoft.GameEventItemData val_56 = this._item.Data;
            if(val_56 != null)
            {
                goto label_170;
            }
            
            label_171:
            label_170:
            val_129 = System.String.Format(format:  "{0} x{1}", arg0:  val_54.与丆业丅上丗七丆一(), arg1:  val_56.Count);
            label_96:
            if(this._rewardText != 0)
            {
                    this._rewardText.Text = val_129;
            }
            
            if(this._item == null)
            {
                goto label_105;
            }
            
            Rilisoft.GameEventItemData val_60 = this._item.Data;
            if(val_60 != null)
            {
                goto label_124;
            }
            
            label_125:
            label_124:
            this._rewardDescriptionLabel.text = val_60.丟世三不一下丕丒万();
            val_123 = this._headerText;
            if(val_123 == 0)
            {
                    return;
            }
            
            val_123 = System.String.alignConst;
            if(this._item == null)
            {
                goto label_111;
            }
            
            Rilisoft.GameEventItemData val_63 = this._item.Data;
            if(val_63 != null)
            {
                goto label_164;
            }
            
            label_165:
            label_164:
            Rilisoft.GameEventItemType val_64 = val_63.Type;
            if(丗丛丑不丕丟万丒丆 == false)
            {
                goto label_113;
            }
            
            if(val_64 <= 500)
            {
                goto label_114;
            }
            
            if(val_64 <= 900)
            {
                goto label_115;
            }
            
            if(val_64 == 1000)
            {
                goto label_116;
            }
            
            if(val_64 == 1300)
            {
                goto label_117;
            }
            
            if(val_64 != 1400)
            {
                goto label_276;
            }
            
            val_130 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if(this._item == null)
            {
                goto label_119;
            }
            
            val_131 = this._item.Data;
            if(val_131 != null)
            {
                goto label_246;
            }
            
            goto label_121;
            label_88:
            if(this._data != null)
            {
                goto label_122;
            }
            
            goto label_123;
            label_105:
            if(this._data != null)
            {
                goto label_124;
            }
            
            goto label_125;
            label_113:
            if(val_64 != 800)
            {
                goto label_126;
            }
            
            label_187:
            if(this._item == null)
            {
                goto label_127;
            }
            
            val_132 = this._item.Data;
            if(val_132 != null)
            {
                goto label_197;
            }
            
            goto label_129;
            label_79:
            label_81:
            ArmoryInfoScreenController val_68 = 0.GetComponent<ArmoryInfoScreenController>();
            this.下丏丗且丅丟丄丂与 = val_68;
            val_68.transform.parent = this.transform.parent;
            UnityEngine.Vector3 val_73 = UnityEngine.Vector3.zero;
            this.下丏丗且丅丟丄丂与.transform.localPosition = new UnityEngine.Vector3() {x = val_73.x, y = val_73.y, z = val_73.z};
            this.下丏丗且丅丟丄丂与.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            int val_78 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.下丏丗且丅丟丄丂与.gameObject, 不东丛三丂丌丑专丆:  this.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            this.下丏丗且丅丟丄丂与.丙业丁丅丗万丞丙且 = true;
            this.下丏丗且丅丟丄丂与.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  new 丙且上东下丏丏丟下(), 丁业丗丈丂七丟东与:  true, 下丗丐丙丙丞与与三:  0, 丙丂丒一丗下丘下丟:  0, 丝丞丄丝一丞丗丄丛:  0);
            this.下丏丗且丅丟丄丂与.丅七丅丐丗丛一丑丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  public System.Void Rilisoft.GameEventRewardView::Hide()));
            System.Action val_80 = null;
            val_123 = val_80;
            val_80 = new System.Action(object:  this, method:  public System.Void Rilisoft.GameEventRewardView::Hide());
            this.下丏丗且丅丟丄丂与.丘万丟丕业不万丂丁(丙业与丙丗丝不丈东:  val_80);
            val_124 = this.gameObject.GetComponent<UIPanel>();
            UIPanel val_83 = this.下丏丗且丅丟丄丂与.GetComponent<UIPanel>();
            if(val_124 == 0)
            {
                    return;
            }
            
            if(val_83 == 0)
            {
                    return;
            }
            
            val_124 = val_124.depth;
            val_83.depth = val_124 + 5;
            return;
            label_41:
            if(this._data != null)
            {
                goto label_156;
            }
            
            goto label_157;
            label_52:
            if(this._data != null)
            {
                goto label_158;
            }
            
            goto label_159;
            label_54:
            if(this._data != null)
            {
                goto label_160;
            }
            
            goto label_161;
            label_91:
            if(this._data != null)
            {
                goto label_162;
            }
            
            goto label_163;
            label_111:
            if(this._data != null)
            {
                goto label_164;
            }
            
            goto label_165;
            label_26:
            if(this._data != null)
            {
                goto label_166;
            }
            
            goto label_167;
            label_97:
            if(this._data != null)
            {
                goto label_168;
            }
            
            goto label_169;
            label_99:
            if(this._data != null)
            {
                goto label_170;
            }
            
            goto label_171;
            label_114:
            if(val_64 <= 200)
            {
                goto label_172;
            }
            
            if((val_64 == 300) || (val_64 == 400))
            {
                goto label_288;
            }
            
            if(val_64 != 500)
            {
                goto label_276;
            }
            
            if(this._item == null)
            {
                goto label_176;
            }
            
            val_133 = this._item.Data;
            if(val_133 != null)
            {
                goto label_251;
            }
            
            goto label_178;
            label_126:
            label_288:
            string val_89 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1676");
            goto label_249;
            label_57:
            if(this._data != null)
            {
                goto label_182;
            }
            
            goto label_183;
            label_94:
            if(this._data != null)
            {
                goto label_184;
            }
            
            goto label_185;
            label_115:
            if(val_64 == 600)
            {
                goto label_288;
            }
            
            if(val_64 == 800)
            {
                goto label_187;
            }
            
            if(val_64 != 900)
            {
                goto label_276;
            }
            
            goto label_288;
            label_172:
            if(val_64 == 100)
            {
                goto label_192;
            }
            
            if(val_64 != 200)
            {
                goto label_276;
            }
            
            goto label_288;
            label_127:
            val_132 = this._data;
            if(val_132 != null)
            {
                goto label_197;
            }
            
            label_129:
            label_197:
            label_249:
            val_123 = val_132.与丆业丅上丗七丆一();
            label_276:
            val_124 = this._headerText;
            val_124.Text = val_123;
            return;
            label_192:
            if(this._item == null)
            {
                goto label_199;
            }
            
            val_135 = this._item.Data;
            if(val_135 != null)
            {
                goto label_217;
            }
            
            goto label_201;
            label_116:
            if(this._item == null)
            {
                goto label_202;
            }
            
            val_136 = this._item.Data;
            if(val_136 != null)
            {
                goto label_225;
            }
            
            goto label_204;
            label_117:
            val_130 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if(this._item == null)
            {
                goto label_205;
            }
            
            val_137 = this._item.Data;
            if(val_137 != null)
            {
                goto label_230;
            }
            
            goto label_207;
            label_199:
            val_135 = this._data;
            if(val_135 != null)
            {
                goto label_217;
            }
            
            label_201:
            label_217:
            三丅丁丗丗丝丂万且 val_96 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_135.Id);
            if(val_96 == null)
            {
                goto label_276;
            }
            
            if(val_96.东七与与不丅丙上上() == true)
            {
                goto label_288;
            }
            
            string val_100 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_96.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  val_96.万上丄下业丛丌不丈());
            goto label_249;
            label_202:
            val_136 = this._data;
            if(val_136 != null)
            {
                goto label_225;
            }
            
            label_204:
            label_225:
            if(((丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_136.Id)) & 2147483648) != 0)
            {
                goto label_228;
            }
            
            goto label_229;
            label_205:
            val_137 = this._data;
            if(val_137 != null)
            {
                goto label_230;
            }
            
            label_207:
            label_230:
            val_139 = val_137.Id;
            val_140 = 20;
            goto label_232;
            label_228:
            label_229:
            if(( & 1) == 0)
            {
                goto label_234;
            }
            
            if( != 210000)
            {
                goto label_234;
            }
            
            goto label_288;
            label_234:
            if(( & 1) == 0)
            {
                goto label_288;
            }
            
            if( != 160000)
            {
                goto label_288;
            }
            
            goto label_288;
            label_119:
            val_131 = this._data;
            if(val_131 != null)
            {
                goto label_246;
            }
            
            label_121:
            label_246:
            val_139 = val_131.Id;
            val_140 = 1450;
            label_232:
            if((val_130.一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  170, 丞丅上丏丂且下丅与:  val_139)) == null)
            {
                goto label_276;
            }
            
            goto label_249;
            label_176:
            val_133 = this._data;
            if(val_133 != null)
            {
                goto label_251;
            }
            
            label_178:
            label_251:
            if((System.String.op_Equality(a:  val_133.Id, b:  "Coins")) == false)
            {
                goto label_252;
            }
            
            goto label_288;
            label_252:
            if(this._item == null)
            {
                goto label_256;
            }
            
            val_141 = this._item.Data;
            if(val_141 != null)
            {
                goto label_259;
            }
            
            goto label_258;
            label_256:
            val_141 = this._data;
            if(val_141 != null)
            {
                goto label_259;
            }
            
            label_258:
            label_259:
            if((System.String.op_Equality(a:  val_141.Id, b:  "Gems")) == false)
            {
                goto label_260;
            }
            
            goto label_288;
            label_260:
            if(this._item == null)
            {
                goto label_264;
            }
            
            val_142 = this._item.Data;
            if(val_142 != null)
            {
                goto label_267;
            }
            
            goto label_266;
            label_264:
            val_142 = this._data;
            if(val_142 != null)
            {
                goto label_267;
            }
            
            label_266:
            label_267:
            if((System.String.op_Equality(a:  val_142.Id, b:  "Tickets")) == false)
            {
                goto label_268;
            }
            
            goto label_288;
            label_268:
            if(this._item == null)
            {
                goto label_272;
            }
            
            val_143 = this._item.Data;
            if(val_143 != null)
            {
                goto label_275;
            }
            
            goto label_274;
            label_272:
            val_143 = this._data;
            if(val_143 != null)
            {
                goto label_275;
            }
            
            label_274:
            label_275:
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_143.Id)) == false)
            {
                goto label_276;
            }
            
            if(this._item == null)
            {
                goto label_277;
            }
            
            val_144 = this._item.Data;
            if(val_144 != null)
            {
                goto label_280;
            }
            
            goto label_279;
            label_277:
            val_144 = this._data;
            if(val_144 != null)
            {
                goto label_280;
            }
            
            label_279:
            label_280:
            string val_119 = Rilisoft.丛且世丐丆上七业丁.丁丂丈世丘丂丕丘东(丈上下与丌丘丅丙丒:  val_144.Id);
            if(((System.String.op_Equality(a:  val_119, b:  "sniper_tournament")) == true) || ((System.String.op_Equality(a:  val_119, b:  "sniper2_roulette")) == false))
            {
                goto label_288;
            }
            
            goto label_288;
        }
        public GameEventRewardView()
        {
            this._autoHideDelay = 3f;
        }
    
    }

}
