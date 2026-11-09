using UnityEngine;

namespace PGCompany
{
    public class AddBlinkIndication : PGBehaviour
    {
        // Fields
        public UnityEngine.Color normalColor;
        public UnityEngine.Color blinkColor;
        public bool stopBlinkingOnEnable;
        private string 东东丂一不丗丆不三;
        private UISprite 丘丑且三丙丐一丗丄;
        
        // Properties
        private UISprite 丝丙业丁丟万丑丌专 { get; }
        
        // Methods
        private UISprite 专丘万丅丞丅万一丈()
        {
            UISprite val_3;
            if(this.丘丑且三丙丐一丗丄 == 0)
            {
                    this.丘丑且三丙丐一丗丄 = this.GetComponent<UISprite>();
                return val_3;
            }
            
            val_3 = this.丘丑且三丙丐一丗丄;
            return val_3;
        }
        public void Indicate()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.世丅丟专丄丘万丒丟());
        }
        private System.Collections.IEnumerator 世丅丟专丄丘万丒丟()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new AddBlinkIndication.丛丅丛丒丙丞不丆丘();
        }
        public AddBlinkIndication()
        {
            this.normalColor = 0;
            mem[1152921556097641964] = 0;
            mem[1152921556097641972] = 0;
            this.blinkColor = 0;
            mem[1152921556097641980] = 0;
            mem[1152921556097641988] = 0;
            this.东东丂一不丗丆不三 = System.String.alignConst;
        }
    
    }

}
