using UnityEngine;

namespace Rilisoft
{
    public class TextGroup : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UILabel> _labels;
        private string _localizationKey;
        private string _text;
        
        // Properties
        public string 不三世丏丙丁与丑丒 { get; set; }
        public string 丁丗下一丒丕三下丛 { get; set; }
        public bool 丐丐三丐丒丁业丝一 { get; }
        
        // Methods
        public string get_Text()
        {
            return (string)this._text;
        }
        public void set_Text(string 丙业与丙丗丝不丈东)
        {
            this._text = 丙业与丙丗丝不丈东;
            if(this._labels != null)
            {
                    if(this._labels.Count != 0)
            {
                goto label_2;
            }
            
            }
            
            this.东世丒上上万上丅丏();
            label_2:
            this._labels.ForEach(action:  new System.Action<UILabel>(object:  this, method:  System.Void Rilisoft.TextGroup::万丘丕丝三丙丗丛丏(UILabel 丐三丞七丝丅不万丛)));
        }
        public string get_LocalizationKey()
        {
            return (string)this._localizationKey;
        }
        public void set_LocalizationKey(string 丙业与丙丗丝不丈东)
        {
            string val_4;
            this._localizationKey = 丙业与丙丗丝不丈东;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丙业与丙丗丝不丈东)) != false)
            {
                    val_4 = this._text;
            }
            else
            {
                    if(this.UseLocalizationComponents != false)
            {
                    this.丛丐丆丆丞七丙丁丂();
                return;
            }
            
                val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  丙业与丙丗丝不丈东);
            }
            
            this.Text = val_4;
        }
        public bool get_UseLocalizationComponents()
        {
            var val_5;
            var val_6;
            int val_7;
            T[] val_1 = this.GetComponents<I2.Loc.Localize>();
            val_5 = 0;
            val_6 = 0;
            goto label_1;
            label_5:
            val_7 = val_1.Length;
            if(val_5 >= val_1.Length)
            {
                    return (bool)(val_6 > val_7) ? 1 : 0;
            }
            
            label_6:
            val_1[0] = System.String.op_Equality(a:  val_1[0].Term, b:  "Key_04B_03");
            val_6 = val_6 + val_1[0];
            val_5 = 1;
            label_1:
            if(val_1 == null)
            {
                goto label_5;
            }
            
            val_7 = val_1.Length;
            if(val_5 < val_7)
            {
                goto label_6;
            }
            
            return (bool)(val_6 > val_7) ? 1 : 0;
        }
        private void OnEnable()
        {
            string val_5;
            丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.TextGroup::丞丛一丙丂世丈丅丗()));
            this.东世丒上上万上丅丏();
            if(this.UseLocalizationComponents != false)
            {
                    this.丛丐丆丆丞七丙丁丂();
                return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._localizationKey)) != false)
            {
                    val_5 = this._text;
            }
            else
            {
                    val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._localizationKey);
            }
            
            this.Text = val_5;
        }
        private void OnDisable()
        {
            丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Rilisoft.TextGroup::丞丛一丙丂世丈丅丗()));
        }
        private void 东世丒上上万上丅丏()
        {
            System.Collections.Generic.List<UILabel> val_3;
            if(this._labels != null)
            {
                    this._labels.Clear();
                val_3 = this._labels;
            }
            else
            {
                    System.Collections.Generic.List<UILabel> val_1 = null;
                val_3 = val_1;
                val_1 = new System.Collections.Generic.List<UILabel>();
                this._labels = val_3;
            }
            
            val_1.AddRange(collection:  this.GetComponentsInChildren<UILabel>(includeInactive:  true));
        }
        private void 丞丛一丙丂世丈丅丗()
        {
            string val_4;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this._localizationKey)) != false)
            {
                    val_4 = this._text;
            }
            else
            {
                    if(this.UseLocalizationComponents != false)
            {
                    this.丛丐丆丆丞七丙丁丂();
                return;
            }
            
                val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._localizationKey);
            }
            
            this.Text = val_4;
        }
        private void 丛丐丆丆丞七丙丁丂()
        {
            var val_3;
            UnityEngine.Object val_11;
            List.Enumerator<T> val_1 = this._labels.GetEnumerator();
            label_11:
            if((297374704 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            val_11 = val_4.gameObject.GetComponent<I2.Loc.Localize>();
            if(val_11 == 0)
            {
                    val_11 = val_4.gameObject.AddComponent<I2.Loc.Localize>();
            }
            
            val_11.Term = this._localizationKey;
            goto label_11;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            this.Text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._localizationKey);
        }
        public TextGroup()
        {
            this._labels = new System.Collections.Generic.List<UILabel>();
        }
        private void 万丘丕丝三丙丗丛丏(UILabel 丐三丞七丝丅不万丛)
        {
            丐三丞七丝丅不万丛.text = this._text;
        }
    
    }

}
