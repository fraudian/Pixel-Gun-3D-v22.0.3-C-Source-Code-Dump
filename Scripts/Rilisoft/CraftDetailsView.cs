using UnityEngine;

namespace Rilisoft
{
    public class CraftDetailsView : MonoBehaviour
    {
        // Fields
        private UILabel _count;
        private UILabel _countDetails;
        private UILabel _itemName;
        private UILabel _price;
        private UIBasicSprite _texture;
        private UnityEngine.GameObject enoughToCraftIcon;
        private UnityEngine.GameObject enoughToPetCraftIcon;
        private UILabel enoughToPetCraftLabel;
        private UIBasicSprite gearIcon;
        private UIBasicSprite footIcon;
        private Rilisoft.GameCurrencyData <不丑丂上丘丒丙与丅>k__BackingField;
        private string <七七七丒业丗丅且丛>k__BackingField;
        private System.Action<Rilisoft.CraftDetailsView> 一万东丛且不丌丁丈;
        
        // Properties
        private UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
        public Rilisoft.GameCurrencyData 丈且丌业上一丌不丞 { get; set; }
        public string 与丙丌丈下万业丙丕 { get; set; }
        
        // Methods
        private UIBasicSprite 丆下世世丟七专丞丒()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
            this._texture = val_1;
            return val_1;
        }
        public Rilisoft.GameCurrencyData get_CurrencyData()
        {
            return (Rilisoft.GameCurrencyData)this.<不丑丂上丘丒丙与丅>k__BackingField;
        }
        private void 丛且上丅丕丘不丙丄(Rilisoft.GameCurrencyData 丙业与丙丗丝不丈东)
        {
            this.<不丑丂上丘丒丙与丅>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public string get_ItemId()
        {
            return (string)this.<七七七丒业丗丅且丛>k__BackingField;
        }
        private void 丆世丄丐丐与丄下三(string 丙业与丙丗丝不丈东)
        {
            this.<七七七丒业丗丅且丛>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void add_Click(System.Action<Rilisoft.CraftDetailsView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.一万东丛且不丌丁丈, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.一万东丛且不丌丁丈 != 1152921542360528360);
        
        }
        public void remove_Click(System.Action<Rilisoft.CraftDetailsView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.一万东丛且不丌丁丈, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.一万东丛且不丌丁丈 != 1152921542360664936);
        
        }
        public void Set(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆, string 丞一丁业丄一一业且)
        {
            this.<不丑丂上丘丒丙与丅>k__BackingField = 一下世丆丙万丞东丆;
            this.<七七七丒业丗丅且丛>k__BackingField = 丞一丁业丄一一业且;
            this.UpdateView();
            this.丘丈丅丝丙丌不一丆(一下世丆丙万丞东丆:  一下世丆丙万丞东丆);
            if(this._count == 0)
            {
                    return;
            }
            
            this = this._count;
            this.text = 一下世丆丙万丞东丆.CurrencyCount.ToString();
        }
        public void UpdateView()
        {
            int val_72;
            var val_110;
            int val_111;
            UILabel val_112;
            var val_113;
            string val_114;
            UnityEngine.Color val_115;
            UnityEngine.Color val_116;
            var val_121;
            var val_122;
            float val_123;
            float val_124;
            float val_125;
            float val_126;
            float val_127;
            float val_128;
            float val_129;
            float val_130;
            int val_132;
            string val_133;
            UnityEngine.GameObject val_134;
            var val_135;
            UILabel val_136;
            object val_137;
            var val_139;
            UnityEngine.GameObject val_140;
            var val_141;
            val_110 = this;
            int val_97 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enoughToPetCraftIcon, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enoughToCraftIcon, 丏业丟一东丂东丘丛:  false);
            val_111 = 1152921504848912384;
            if(this.丆下世世丟七专丞丒() == 0)
            {
                    return;
            }
            
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  this.<七七七丒业丗丅且丛>k__BackingField)) == false)
            {
                goto label_8;
            }
            
            val_112 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  this.<七七七丒业丗丅且丛>k__BackingField);
            if(val_112 == null)
            {
                goto label_10;
            }
            
            val_113 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_112.丙三专万丛丟万丝丘());
            if(this.gearIcon != 0)
            {
                    val_114 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
                val_115 = val_114[(long)val_112.七东与丄丕丁丛世三()];
                val_116 = val_114[(long)val_112.七东与丄丕丁丛世三()];
                this.gearIcon.color = new UnityEngine.Color() {r = val_115, g = val_114[(long)val_112.七东与丄丕丁丛世三()], b = val_116, a = val_114[(long)val_112.七东与丄丕丁丛世三()]};
            }
            
            if(this._count != 0)
            {
                    val_114 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
                val_115 = val_114[(long)val_112.七东与丄丕丁丛世三()];
                val_116 = val_114[(long)val_112.七东与丄丕丁丛世三()];
                this._count.color = new UnityEngine.Color() {r = val_115, g = val_114[(long)val_112.七东与丄丕丁丛世三()], b = val_116, a = val_114[(long)val_112.七东与丄丕丁丛世三()]};
            }
            
            if(this._itemName != 0)
            {
                    val_114 = val_112.丙丕丞且丕不丘丙丑().东丙上东业丆不丟丘();
                this._itemName.text = val_114;
            }
            
            if(this._countDetails == 0)
            {
                goto label_119;
            }
            
            if((val_112.三丐丟丒业丞东三丕() * val_112.丄且丞且且且世丂丅()) >= val_112.丗三三丐丁东丘丌一())
            {
                goto label_35;
            }
            
            val_111 = val_112.丄且丞且且且世丂丅() * val_112.三丐丟丒业丞东三丕();
            goto label_36;
            label_8:
            if((Rilisoft.PetsManager.丌丈万丆一丒不世三(世丐丗专丅三丝丑丆:  this.<七七七丒业丗丅且丛>k__BackingField)) == false)
            {
                goto label_39;
            }
            
            int val_28 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  this.<七七七丒业丗丅且丛>k__BackingField);
            val_112 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.<七七七丒业丗丅且丛>k__BackingField);
            if(val_112 == null)
            {
                goto label_43;
            }
            
            goto label_48;
            label_39:
            int val_32 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  this.<七七七丒业丗丅且丛>k__BackingField);
            三丅丁丗丗丝丂万且 val_33 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.<七七七丒业丗丅且丛>k__BackingField);
            if(val_33 == null)
            {
                goto label_51;
            }
            
            val_121 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
            val_122 = val_33;
            goto label_54;
            label_10:
            val_113 = 0;
            goto label_119;
            label_43:
            UnityEngine.Color[] val_35 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
            label_48:
            UnityEngine.Color32 val_36 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = -8.193231E-16f, g = -8.193231E-16f, b = -8.193231E-16f, a = -8.193231E-16f});
            if(this.footIcon != 0)
            {
                    UnityEngine.Color val_39 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_36.r & 4294967295, g = val_36.r & 4294967295, b = val_36.r & 4294967295, a = val_36.r & 4294967295});
                val_115 = val_39.r;
                val_116 = val_39.b;
                val_125 = val_115;
                val_124 = val_39.g;
                val_123 = val_116;
                val_126 = val_39.a;
                this.footIcon.color = new UnityEngine.Color() {r = val_125, g = val_124, b = val_123, a = val_126};
            }
            
            if(this._count != 0)
            {
                    UnityEngine.Color val_42 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_36.r & 4294967295, g = val_36.r & 4294967295, b = val_36.r & 4294967295, a = val_36.r & 4294967295});
                val_115 = val_42.r;
                val_116 = val_42.b;
                this._count.color = new UnityEngine.Color() {r = val_115, g = val_42.g, b = val_116, a = val_42.a};
            }
            
            val_114 = this._itemName;
            val_113 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.<七七七丒业丗丅且丛>k__BackingField, 七丆丒与丗丌丄且丂:  val_28, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            if(val_114 != 0)
            {
                    val_114 = this._itemName;
                val_114.text = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  this.<七七七丒业丗丅且丛>k__BackingField, 七丆丒与丗丌丄且丂:  val_28);
            }
            
            if(val_112 == null)
            {
                goto label_116;
            }
            
            if(this._countDetails == 0)
            {
                goto label_119;
            }
            
            val_114 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance;
            if((val_114.丆万一与世丒丙丌丝(世丐丗专丅三丝丑丆:  this.<七七七丒业丗丅且丛>k__BackingField)) == null)
            {
                goto label_119;
            }
            
            int val_51 = BalanceController.丄丘上三丕丟业世世(丄丈丞丒且东丝下一:  val_112.Index, 且万丛丒丁丏七丅东:  val_112.CurrentLevel, 丐丏上业丈丂与万丞:  false);
            Rilisoft.GameCurrencyData val_111 = this.<不丑丂上丘丒丙与丅>k__BackingField;
            val_111 = val_48.专下与丑三丏丂不丆;
            val_111 = val_111.CurrencyCount + val_111;
            if(val_51 <= val_111)
            {
                goto label_86;
            }
            
            this.enoughToPetCraftIcon.SetActive(value:  false);
            goto label_87;
            label_51:
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  this.<七七七丒业丗丅且丛>k__BackingField)) == false)
            {
                goto label_91;
            }
            
            val_121 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
            label_54:
            label_141:
            UnityEngine.Color32 val_59 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = -8.193231E-16f, g = -8.193231E-16f, b = -8.193231E-16f, a = -8.193231E-16f});
            if(this.gearIcon != 0)
            {
                    UnityEngine.Color val_62 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_59.r & 4294967295, g = val_59.r & 4294967295, b = val_59.r & 4294967295, a = val_59.r & 4294967295});
                val_115 = val_62.r;
                val_116 = val_62.b;
                val_129 = val_115;
                val_128 = val_62.g;
                val_127 = val_116;
                val_130 = val_62.a;
                this.gearIcon.color = new UnityEngine.Color() {r = val_129, g = val_128, b = val_127, a = val_130};
            }
            
            if(this._count != 0)
            {
                    UnityEngine.Color val_65 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color32() {r = val_59.r & 4294967295, g = val_59.r & 4294967295, b = val_59.r & 4294967295, a = val_59.r & 4294967295});
                val_115 = val_65.r;
                val_116 = val_65.b;
                this._count.color = new UnityEngine.Color() {r = val_115, g = val_65.g, b = val_116, a = val_65.a};
            }
            
            val_114 = this._itemName;
            val_113 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.<七七七丒业丗丅且丛>k__BackingField, 七丆丒与丗丌丄且丂:  val_32, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            if(val_114 != 0)
            {
                    val_114 = this._itemName;
                val_114.text = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  this.<七七七丒业丗丅且丛>k__BackingField, 七丆丒与丗丌丄且丂:  val_32);
            }
            
            if(val_33 == null)
            {
                goto label_116;
            }
            
            val_112 = this._countDetails;
            if(val_112 == 0)
            {
                goto label_119;
            }
            
            Rilisoft.丞丟丙丅丗且丈丞丏 val_70 = Rilisoft.丞丟丙丅丗且丈丞丏.丐下下丅与上东丙丑(三不三丟专丘东东丂:  this.<七七七丒业丗丅且丛>k__BackingField);
            if(val_72.与丕丞七一且且上上() == false)
            {
                goto label_120;
            }
            
            int val_75 = val_72.丅东丄丛上丁丐万丏();
            goto label_121;
            label_116:
            val_132 = BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  this.<七七七丒业丗丅且丛>k__BackingField);
            val_133 = this.<七七七丒业丗丅且丛>k__BackingField;
            int val_77 = Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_133);
            goto label_126;
            label_35:
            val_111 = val_112.丗三三丐丁东丘丌一() - (val_112.丝丗丑万万丗不丙丁() * val_112.三丐丟丒业丞东三丕());
            label_36:
            int val_112 = val_112.丗三三丐丁东丘丌一();
            val_112 = val_112 + (this.<不丑丂上丘丒丙与丅>k__BackingField.CurrencyCount);
            if(((val_112.丝丗丑万万丗不丙丁() + 1) * val_112.三丐丟丒业丞东三丕()) > val_112)
            {
                    val_134 = this.enoughToCraftIcon;
                val_135 = 0;
            }
            else
            {
                    val_135 = 1;
                val_134 = this.enoughToCraftIcon;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_134, 丏业丟一东丂东丘丛:  true);
            val_136 = this._countDetails;
            val_114 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4771");
            val_72 = val_111;
            val_137 = val_72;
            int val_85 = val_112.三丐丟丒业丞东三丕();
            val_139 = null;
            goto label_136;
            label_91:
            UnityEngine.Color[] val_86 = 丏丄丑上丛不丈且万.丆丐丈不丆丑丗丗丄();
            goto label_141;
            label_120:
            label_121:
            val_132 = val_72.丞丟一丟丗丐业丁丅();
            int val_88 = val_72.丙东专丂世丈丏丁丂();
            label_126:
            var val_113 = this.<不丑丂上丘丒丙与丅>k__BackingField.CurrencyCount;
            val_113 = val_113 + val_88;
            if(val_132 > val_113)
            {
                    val_140 = this.enoughToCraftIcon;
                val_141 = 0;
            }
            else
            {
                    val_141 = 1;
                val_140 = this.enoughToCraftIcon;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_140, 丏业丟一东丂东丘丛:  true);
            val_114 = this._countDetails;
            val_111 = 1152921504622075904;
            val_72 = val_88;
            val_112 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4771"), arg0:  System.String.Format(format:  "{0}/{1}", arg0:  val_72, arg1:  val_132));
            if(val_114 != null)
            {
                goto label_152;
            }
            
            goto label_152;
            label_86:
            this.enoughToPetCraftIcon.SetActive(value:  true);
            int val_95 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛七七专丞且丅丄万(世丐丗专丅三丝丑丆:  this.<七七七丒业丗丅且丛>k__BackingField, 丒七且一东丂丐丛丒:  this.<不丑丂上丘丒丙与丅>k__BackingField.CurrencyCount);
            bool val_98 = 丟下七丘下下丙丗丅.丗丁七东丂丌丙与丕().TryGetValue(key:  this.<七七七丒业丗丅且丛>k__BackingField, value: out  val_97);
            if((val_97 >= 1) && (val_95 == (BalanceController.三丞丗丌丟丂上丆三(丄丈丞丒且东丝下一:  0))))
            {
                    string val_100 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8792");
            }
            else
            {
                    val_72 = val_95;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.enoughToPetCraftLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8791"), arg0:  val_72));
            label_87:
            val_136 = this._countDetails;
            val_114 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6456");
            val_72 = val_111;
            val_137 = val_72;
            val_139 = null;
            label_136:
            val_112 = System.String.Format(format:  val_114, arg0:  System.String.Format(format:  "{0}/{1}", arg0:  val_72, arg1:  val_51));
            label_152:
            val_136.text = val_112;
            label_119:
            val_110 = this.丆下世世丟七专丞丒();
        }
        private void OnClick()
        {
            if(this.一万东丛且不丌丁丈 == null)
            {
                    return;
            }
            
            this.一万东丛且不丌丁丈.Invoke(obj:  this);
        }
        public void U_Click()
        {
            this.OnClick();
        }
        private void 丘丈丅丝丙丌不一丆(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)
        {
            UnityEngine.Object val_5 = this.gameObject;
            if(val_5 == 0)
            {
                    return;
            }
            
            val_5 = this._price;
            if(val_5 == 0)
            {
                    return;
            }
            
            this._price.text = 一下世丆丙万丞东丆.丛不专与三丅万丌下();
        }
        private void Awake()
        {
            FriendsController.东东万丑丄丘三丈上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CraftDetailsView::专丈且丆丄专丒丁丅()));
        }
        private void 专丈且丆丄专丒丁丅()
        {
            if((this.<不丑丂上丘丒丙与丅>k__BackingField) == null)
            {
                    return;
            }
            
            this.丘丈丅丝丙丌不一丆(一下世丆丙万丞东丆:  this.<不丑丂上丘丒丙与丅>k__BackingField);
        }
        private void OnDestroy()
        {
            FriendsController.丈丘丗丈与丝丑丗丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.CraftDetailsView::专丈且丆丄专丒丁丅()));
        }
        public CraftDetailsView()
        {
        
        }
    
    }

}
