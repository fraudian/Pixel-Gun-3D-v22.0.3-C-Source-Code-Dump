using UnityEngine;

namespace PGCompany
{
    internal abstract class 丕业丛世丒且丞丞丘
    {
        // Fields
        private System.Action 丌丗万与丗丞三丝丞;
        private UnityEngine.Coroutine 丌丈丂专丟丘业丂丁;
        private PGCompany.丗不上业丙丆世丁丘 丒丄丅丟丞丅丄七丕;
        
        // Properties
        internal virtual bool 丄丈丅一丂丈丄东专 { get; }
        internal virtual float 丝丏丏一丒上丂不丆 { get; }
        internal bool 且三万丝丐丛与专丞 { get; }
        protected abstract bool 丙丅丛不丄七丟业丌 { get; }
        internal virtual PGCompany.丗不上业丙丆世丁丘 丅万丂世不丘丕下一 { get; set; }
        
        // Methods
        internal void 七上丑丝七丒业丈业(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丌丗万与丗丞三丝丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丌丗万与丗丞三丝丞 != 1152921555493753600);
        
        }
        internal void 与且东与丏下三业丞(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丌丗万与丗丞三丝丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丌丗万与丗丞三丝丞 != 1152921555493890176);
        
        }
        internal virtual bool 丐丝丝丝丞三与丘丒()
        {
            return false;
        }
        internal virtual float 丆丆下丅丅七且且万()
        {
            return 0.5f;
        }
        protected virtual void 与且丙丑且且丂丂丂()
        {
            this.且上上丌丅丟丆丕丒();
        }
        private System.Collections.IEnumerator 丁三三与丗丐三丟丛()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new 丕业丛世丒且丞丞丘.丅丂世上丅丞七丞丐();
        }
        internal void 下丌业业丐丘丐丘三()
        {
            System.Collections.IEnumerator val_4;
            if((this & 1) != 0)
            {
                    val_4 = this.丁三三与丗丐三丟丛();
                this.丌丈丂专丟丘业丂丁 = CoroutineRunner.Instance.StartCoroutine(routine:  val_4);
            }
        
        }
        internal void 不与丞下业丑丒丙万()
        {
            UnityEngine.Coroutine val_2;
            if((this & 1) != 0)
            {
                    val_2 = this.丌丈丂专丟丘业丂丁;
                CoroutineRunner.Instance.StopCoroutine(routine:  val_2);
            }
        
        }
        internal abstract void 丈且东丑丂且万丒丅(); // 0
        internal abstract void 丏丟业下与丝丕丈丘(); // 0
        internal bool 不丌丈专丟丒丕专丏()
        {
            var val_1;
            var val_5;
            var val_8;
            var val_9;
            if(val_1 != false)
            {
                    val_8 = 1;
            }
            else
            {
                    var val_4 = (ExperienceController.丞丞丘业东丙丏七丌() >= BalanceController.丌与东一专丌且上丒()) ? 1 : 0;
            }
            
            if(val_5 == false)
            {
                goto label_7;
            }
            
            if(val_4 == 0)
            {
                goto label_13;
            }
            
            label_16:
            val_9 = this;
            goto label_9;
            label_7:
            if(val_4 != 0)
            {
                    if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
            {
                    if(PixelTime.丝丗专上三不丄丑丑() > 0)
            {
                goto label_16;
            }
            
            }
            
            }
            
            label_13:
            val_9 = 0;
            label_9:
            val_9 = val_9 & 1;
            return (bool)val_9;
        }
        internal virtual string 万丌丂上丈三丗丟丑()
        {
            return (string)System.String.alignConst;
        }
        protected abstract bool 丆丏丗业丝丘上不东(); // 0
        internal virtual PGCompany.丗不上业丙丆世丁丘 丏丘下丞丘不丑万丏()
        {
            PGCompany.丗不上业丙丆世丁丘 val_0;
            val_0.丒丂丌丑丟东东丒专 = ;
            val_0.丒三丝一上丙专丗丒 = this.丒丄丅丟丞丅丄七丕;
            return val_0;
        }
        internal virtual void 上丗丆丈丒下丘丏丛(PGCompany.丗不上业丙丆世丁丘 丙业与丙丗丝不丈东)
        {
            mem[1152921555495108272] = 丙业与丙丗丝不丈东.丒丂丌丑丟东东丒专;
            this.丒丄丅丟丞丅丄七丕 = 丙业与丙丗丝不丈东.丒三丝一上丙专丗丒;
        }
        internal void 且上上丌丅丟丆丕丒()
        {
            if(this.丌丗万与丗丞三丝丞 == null)
            {
                    return;
            }
            
            this.丌丗万与丗丞三丝丞.Invoke();
        }
        protected 丕业丛世丒且丞丞丘()
        {
        
        }
    
    }

}
