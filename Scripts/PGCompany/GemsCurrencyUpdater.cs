using UnityEngine;

namespace PGCompany
{
    internal class GemsCurrencyUpdater : CurrencyUpdater
    {
        // Fields
        private System.Nullable<UnityEngine.Color> 三一丑丘丛丆丘丟专;
        private UnityEngine.Coroutine 且万专丑丂业丆丒丏;
        private int 丒丙七专丒东业丘世;
        
        // Properties
        protected override string 世丟丑丘丘业七丑不 { get; }
        protected override UnityEngine.Color 丝三东三丆不业丞业 { get; }
        
        // Methods
        protected override string 丌东世丁丁丌丐丕丟()
        {
            return "CraftCurrencyUpdater_blink_sequence";
        }
        protected override UnityEngine.Color 丐业丅丒丅丁丞且丝()
        {
            if(this.三一丑丘丛丆丘丟专.HasValue == true)
            {
                    return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
            }
            
            mem2[0] = 0;
            mem2[0] = 0;
            return new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            BankController.与丆丗丞丟七丙与七(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void CurrencyUpdater::上业丝丙丅东业丟丅(int 丌丒丝东丌下丕丁丅)));
        }
        protected override void OnDisable()
        {
            BankController.专万丒丛三丗专丈业(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void CurrencyUpdater::上业丝丙丅东业丟丅(int 丌丒丝东丌下丕丁丅)));
            this.OnDisable();
        }
        protected void 上业丝丙丅东业丟丅(int 丌丒丝东丌下丕丁丅, float 丕丕世且下一与丝与)
        {
            int val_3 = this.丒丙七专丒东业丘世;
            val_3 = val_3 + 丌丒丝东丌下丕丁丅;
            this.丒丙七专丒东业丘世 = val_3;
            if(this.且万专丑丂业丆丒丏 != null)
            {
                    this.StopCoroutine(routine:  this.且万专丑丂业丆丒丏);
            }
            
            this.且万专丑丂业丆丒丏 = this.StartCoroutine(routine:  this.丈丈三丟丄且丙丆丄(丕丕世且下一与丝与:  丕丕世且下一与丝与));
        }
        private System.Collections.IEnumerator 丈丈三丟丄且丙丆丄(float 丕丕世且下一与丝与)
        {
            GemsCurrencyUpdater.不世丝丙丁一业丟丏 val_1 = new GemsCurrencyUpdater.不世丝丙丁一业丟丏();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
            return (System.Collections.IEnumerator)val_1;
        }
        protected override int 丞下丂下东东丅一七()
        {
            return BankController.七丐三丑上丘且丛丛();
        }
        public GemsCurrencyUpdater()
        {
        
        }
    
    }

}
