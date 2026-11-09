using UnityEngine;

namespace ExitGames.UtilityScripts
{
    public class TextToggleIsOnTransition : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
    {
        // Fields
        public UnityEngine.UI.Toggle toggle;
        private UnityEngine.UI.Text _text;
        public UnityEngine.Color NormalOnColor;
        public UnityEngine.Color NormalOffColor;
        public UnityEngine.Color HoverOnColor;
        public UnityEngine.Color HoverOffColor;
        private bool isHover;
        
        // Methods
        public void OnEnable()
        {
            this._text = this.GetComponent<UnityEngine.UI.Text>();
            this.toggle.onValueChanged.AddListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  public System.Void ExitGames.UtilityScripts.TextToggleIsOnTransition::OnValueChanged(bool isOn)));
        }
        public void OnDisable()
        {
            this.toggle.onValueChanged.RemoveListener(call:  new UnityEngine.Events.UnityAction<System.Boolean>(object:  this, method:  public System.Void ExitGames.UtilityScripts.TextToggleIsOnTransition::OnValueChanged(bool isOn)));
        }
        public void OnValueChanged(bool isOn)
        {
            UnityEngine.Color val_1;
            var val_2;
            var val_3;
            var val_4;
            if(isOn == false)
            {
                goto label_0;
            }
            
            if(this.isHover == false)
            {
                goto label_1;
            }
            
            val_1 = this.HoverOnColor;
            val_2 = 1152921541433933740;
            val_3 = 1152921541433933744;
            val_4 = 1152921541433933748;
            goto label_5;
            label_0:
            if(this.isHover == false)
            {
                goto label_3;
            }
            
            val_1 = this.NormalOnColor;
            val_2 = 1152921541433933708;
            val_3 = 1152921541433933712;
            val_4 = 1152921541433933716;
            goto label_5;
            label_1:
            val_1 = this.HoverOffColor;
            val_2 = 1152921541433933756;
            val_3 = 1152921541433933760;
            val_4 = 1152921541433933764;
            goto label_5;
            label_3:
            val_1 = this.NormalOffColor;
            val_2 = 1152921541433933724;
            val_3 = 1152921541433933728;
            val_4 = 1152921541433933732;
            label_5:
            this._text.color = new UnityEngine.Color() {r = this.NormalOffColor.r, g = 1.704592E-11f, b = 1.704592E-11f, a = 1.704592E-11f};
        }
        public void OnPointerEnter(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Color val_2;
            var val_3;
            var val_4;
            var val_5;
            this.isHover = true;
            if(this.toggle.isOn != false)
            {
                    val_2 = this.HoverOnColor;
                val_3 = 1152921541434062124;
                val_4 = 1152921541434062128;
                val_5 = 1152921541434062132;
            }
            else
            {
                    val_2 = this.HoverOffColor;
                val_3 = 1152921541434062140;
                val_4 = 1152921541434062144;
                val_5 = 1152921541434062148;
            }
            
            this._text.color = new UnityEngine.Color() {r = this.HoverOffColor.r, g = 1.704592E-11f, b = 1.704592E-11f, a = 1.704592E-11f};
        }
        public void OnPointerExit(UnityEngine.EventSystems.PointerEventData eventData)
        {
            UnityEngine.Color val_2;
            var val_3;
            var val_4;
            var val_5;
            this.isHover = false;
            if(this.toggle.isOn != false)
            {
                    val_2 = this.NormalOnColor;
                val_3 = 1152921541434198668;
                val_4 = 1152921541434198672;
                val_5 = 1152921541434198676;
            }
            else
            {
                    val_2 = this.NormalOffColor;
                val_3 = 1152921541434198684;
                val_4 = 1152921541434198688;
                val_5 = 1152921541434198692;
            }
            
            this._text.color = new UnityEngine.Color() {r = this.NormalOffColor.r, g = 1.704592E-11f, b = 1.704592E-11f, a = 1.704592E-11f};
        }
        public TextToggleIsOnTransition()
        {
            UnityEngine.Color val_1 = UnityEngine.Color.white;
            this.NormalOnColor = val_1;
            mem[1152921541434322956] = val_1.g;
            mem[1152921541434322960] = val_1.b;
            mem[1152921541434322964] = val_1.a;
            UnityEngine.Color val_2 = UnityEngine.Color.black;
            this.NormalOffColor = val_2;
            mem[1152921541434322972] = val_2.g;
            mem[1152921541434322976] = val_2.b;
            mem[1152921541434322980] = val_2.a;
            UnityEngine.Color val_3 = UnityEngine.Color.black;
            this.HoverOnColor = val_3;
            mem[1152921541434322988] = val_3.g;
            mem[1152921541434322992] = val_3.b;
            mem[1152921541434322996] = val_3.a;
            UnityEngine.Color val_4 = UnityEngine.Color.black;
            this.HoverOffColor = val_4;
            mem[1152921541434323004] = val_4.g;
            mem[1152921541434323008] = val_4.b;
            mem[1152921541434323012] = val_4.a;
        }
    
    }

}
