using UnityEngine;

namespace PGCompany
{
    internal sealed class ItemCurrencyUI : PGBehaviour
    {
        // Fields
        private static readonly System.Collections.Generic.List<PGCompany.ItemCurrencyUI> 丅丐三丏下东万丟丄;
        private WidgetLayout widgetLayout;
        private UIWidget widget;
        private UnityEngine.Coroutine 丗且三一一三丅丒丟;
        private UnityEngine.Color 下丏丝丒丝与万丂丆;
        private UnityEngine.Color 不世丑业上丒丒丁七;
        internal bool useItemTexure;
        public RewardParticlesReceiver rewardParticlesReceiver;
        private PGCompany.丌丑丕丙丅丈丈丘丄 丐丙丒丈丄不一丈与;
        private int 丒丙七专丒东业丘世;
        private UIBasicSprite _icon;
        private UILabel _value;
        private UIBasicSprite _blinkBG;
        private int _blinkIteration;
        private float _blinkTime;
        
        // Properties
        internal PGCompany.丌丑丕丙丅丈丈丘丄 不下下丞三一丘丗丐 { get; }
        internal int 丒专下与丑丁丆丟业 { get; set; }
        
        // Methods
        internal static System.Collections.Generic.List<PGCompany.ItemCurrencyUI> 丞万丟业丟与七丅上(PGCompany.三丌上丁一丟丐丟丈 丟丒上丄丏丄丝丁丙)
        {
            var val_4;
            .丟丒上丄丏丄丝丁丙 = 丟丒上丄丏丄丝丁丙;
            val_4 = null;
            val_4 = null;
            return System.Linq.Enumerable.ToList<PGCompany.ItemCurrencyUI>(source:  System.Linq.Enumerable.Where<PGCompany.ItemCurrencyUI>(source:  PGCompany.ItemCurrencyUI.丅丐三丏下东万丟丄, predicate:  new System.Func<PGCompany.ItemCurrencyUI, System.Boolean>(object:  new ItemCurrencyUI.丝丂下丂丐丄丁丑丄(), method:  System.Boolean ItemCurrencyUI.丝丂下丂丐丄丁丑丄::丑丗世丗丙且世丌丟(PGCompany.ItemCurrencyUI 七丞丙丒三丕且丌丟))));
        }
        private void Awake()
        {
            if(this._blinkBG != 0)
            {
                    UnityEngine.Color val_2 = this._blinkBG.color;
            }
            else
            {
                    UnityEngine.Color val_3 = UnityEngine.Color.clear;
            }
            
            this.下丏丝丒丝与万丂丆 = val_3;
            mem[1152921555547574340] = val_3.g;
            mem[1152921555547574344] = val_3.b;
            mem[1152921555547574348] = val_3.a;
            GoblinAutoCollectorUi.且丝一丌丈丅三丛丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ItemCurrencyUI::丄不丛业丌七丆丒丘()));
        }
        private void OnDestroy()
        {
            GoblinAutoCollectorUi.丟不丌丁丆丝丟东丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ItemCurrencyUI::丄不丛业丌七丆丒丘()));
        }
        internal PGCompany.丌丑丕丙丅丈丈丘丄 丂丑丞丝且万丐万丟()
        {
            return (PGCompany.丌丑丕丙丅丈丈丘丄)this.丐丙丒丈丄不一丈与;
        }
        internal int 丂丁丏一丙丛业且丌()
        {
            return (int)this.丒丙七专丒东业丘世;
        }
        internal void 业与一丏丟丌万丐丛(int 丙业与丙丗丝不丈东)
        {
            this.丒丙七专丒东业丘世 = 丙业与丙丗丝不丈东;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._value, 丕丗丘丑丛与丑业丒:  丙业与丙丗丝不丈东);
            this.丙丕上世丈丈七丒丙();
        }
        private void 丙丕上世丈丈七丒丙()
        {
            if(this.widget != 0)
            {
                    int val_5 = this._value.width;
                val_5 = this._icon.width + val_5;
                this.widget.width = val_5;
            }
            
            if(this.widgetLayout == 0)
            {
                    return;
            }
            
            this.widgetLayout.Reposition();
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.丌丑丕丙丅丈丈丘丄 三七业丂不丄业下七, int 丌丒丝东丌下丕丁丅, bool 丗丂丞丛丒丒丟万丗 = False)
        {
            var val_9;
            if(丗丂丞丛丒丒丟万丗 != false)
            {
                    var val_1 = (this.丒丙七专丒东业丘世 != 丌丒丝东丌下丕丁丅) ? 1 : 0;
            }
            else
            {
                    val_9 = 0;
            }
            
            this.丐丙丒丈丄不一丈与 = 三七业丂不丄业下七;
            PGCompany.丌丑丕丙丅丈丈丘丄 val_3 = 1152921505613074432 + ((this.useItemTexure == true) ? 160 : 176);
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._icon, 与万丆丛丒万丝丙丑:  三七业丂不丄业下七.Equals(obj:  mem[(1152921505613074432 + this.useItemTexure == true ? 160 : 176) + 296 + 8]));
            this.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  丌丒丝东丌下丕丁丅);
            UnityEngine.Color val_7 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CurrencyBlinkColor" + 三七业丂不丄业下七.业上丙丞丐丄丆丅七());
            this.不世丑业上丒丒丁七 = val_7;
            mem[1152921555548361156] = val_7.g;
            mem[1152921555548361160] = val_7.b;
            mem[1152921555548361164] = val_7.a;
            if(val_9 == 0)
            {
                    return;
            }
            
            this.丙丘与丒七丒丞丗丈(丐一业丏上七丆下丌:  三七业丂不丄业下七.业上丙丞丐丄丆丅七());
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.三东丏不丗世丅丌丄 丈丄不七三万丄丁不, bool 丗丂丞丛丒丒丟万丗 = False)
        {
            if(丈丄不七三万丄丁不 == null)
            {
                    return;
            }
            
            PGCompany.丌丑丕丙丅丈丈丘丄 val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丌丑丕丙丅丈丈丘丄>(丞世不丒下上上丝丑:  丈丄不七三万丄丁不.业东丅东丌上丗丑不());
            if(val_3 == null)
            {
                    return;
            }
            
            this.丈且东丑丂且万丒丅(三七业丂不丄业下七:  val_3, 丌丒丝东丌下丕丁丅:  丈丄不七三万丄丁不.丂丁丏一丙丛业且丌(), 丗丂丞丛丒丒丟万丗:  丗丂丞丛丒丒丟万丗);
        }
        internal void 丈且东丑丂且万丒丅(丈丞丕丘丕丗与上一 万丐丏丐丒万不丟三, bool 丗丂丞丛丒丒丟万丗 = False)
        {
            if(万丐丏丐丒万不丟三 == null)
            {
                    return;
            }
            
            PGCompany.丌丑丕丙丅丈丈丘丄 val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.丌丑丕丙丅丈丈丘丄>(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  万丐丏丐丒万不丟三.东与三丌丅三丒丏业());
            if(val_3 == null)
            {
                    return;
            }
            
            this.丈且东丑丂且万丒丅(三七业丂不丄业下七:  val_3, 丌丒丝东丌下丕丁丅:  万丐丏丐丒万不丟三.丟丂丞不专丆万丒世(), 丗丂丞丛丒丒丟万丗:  丗丂丞丛丒丒丟万丗);
        }
        private void OnEnable()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((PGCompany.ItemCurrencyUI.丅丐三丏下东万丟丄.Contains(item:  this)) != true)
            {
                    val_4 = null;
                val_4 = null;
                PGCompany.ItemCurrencyUI.丅丐三丏下东万丟丄.Add(item:  this);
            }
            
            if(this._blinkBG == 0)
            {
                    return;
            }
            
            this._blinkBG.color = new UnityEngine.Color() {r = this.下丏丝丒丝与万丂丆, g = V9.16B, b = V10.16B, a = V11.16B};
        }
        private void OnDisable()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((PGCompany.ItemCurrencyUI.丅丐三丏下东万丟丄.Contains(item:  this)) != false)
            {
                    val_4 = null;
                val_4 = null;
                bool val_2 = PGCompany.ItemCurrencyUI.丅丐三丏下东万丟丄.Remove(item:  this);
            }
            
            if(this.丗且三一一三丅丒丟 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丗且三一一三丅丒丟);
            this.丗且三一一三丅丒丟 = 0;
        }
        private void 丙丘与丒七丒丞丗丈(string 丐一业丏上七丆下丌)
        {
            if(this.丗且三一一三丅丒丟 != null)
            {
                    return;
            }
            
            if(this.丐丙丒丈丄不一丈与 == null)
            {
                    return;
            }
            
            if(this.丐丙丒丈丄不一丈与.业东丅东丌上丗丑不() != (new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  丐一业丏上七丆下丌).业东丅东丌上丗丑不()))
            {
                    return;
            }
            
            this.丗且三一一三丅丒丟 = this.StartCoroutine(routine:  this.丛丒丝下业丐丝上七());
        }
        private void 丄不丛业丌七丆丒丘()
        {
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            this.丙丘与丒七丒丞丗丈(丐一业丏上七丆下丌:  "ClanSilver");
        }
        private void 丛三丑且且业丛丏丅()
        {
            if(this.丗且三一一三丅丒丟 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丗且三一一三丅丒丟);
            this.丗且三一一三丅丒丟 = 0;
        }
        private System.Collections.IEnumerator 丛丒丝下业丐丝上七()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ItemCurrencyUI.丑丄东丛下丘上丙且();
        }
        public ItemCurrencyUI()
        {
            this._blinkIteration = 15;
            this._blinkTime = 7.346868E-41f;
        }
        private static ItemCurrencyUI()
        {
            PGCompany.ItemCurrencyUI.丅丐三丏下东万丟丄 = new System.Collections.Generic.List<PGCompany.ItemCurrencyUI>();
        }
    
    }

}
