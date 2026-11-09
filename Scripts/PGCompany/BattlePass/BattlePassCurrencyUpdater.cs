using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassCurrencyUpdater : CurrencyUpdater
    {
        // Fields
        private UnityEngine.GameObject discountShineGO;
        private System.Nullable<UnityEngine.Color> 三一丑丘丛丆丘丟专;
        private UnityEngine.Coroutine 丑丞丝丒丏丙东一丄;
        private int 丒丙七专丒东业丘世;
        
        // Properties
        protected override string 世丟丑丘丘业七丑不 { get; }
        protected override UnityEngine.Color 丝三东三丆不业丞业 { get; }
        
        // Methods
        protected override string 丌东世丁丁丌丐丕丟()
        {
            return "BattlePassCurrencyUpdater_blink_sequence";
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
            UnityEngine.GameObject val_9;
            this.OnEnable();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.discountShineGO, 丏业丟一东丂东丘丛:  false);
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if((val_2 != null) && (val_2.丁丙丞下丅丘丛丈且() != null))
            {
                    val_9 = val_2.丁丙丞下丅丘丛丈且();
                if(val_9.Count >= 1)
            {
                    val_9 = this.discountShineGO;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  val_2.万东丁丆丈丑丁丈丏());
            }
            
            }
            
            BankController.丆丗丛与世丈业三丕(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Single>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassCurrencyUpdater::丅丆丛丐世丞丌丞丝(int 丌丒丝东丌下丕丁丅, float 丕丕世且下一与丝与)));
        }
        protected override void OnDisable()
        {
            BankController.专东丟丅不丂丅丝且(丙业与丙丗丝不丈东:  new System.Action<System.Int32, System.Single>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassCurrencyUpdater::丅丆丛丐世丞丌丞丝(int 丌丒丝东丌下丕丁丅, float 丕丕世且下一与丝与)));
            this.OnDisable();
        }
        protected void 丅丆丛丐世丞丌丞丝(int 丌丒丝东丌下丕丁丅, float 丕丕世且下一与丝与)
        {
            int val_3 = this.丒丙七专丒东业丘世;
            val_3 = val_3 + 丌丒丝东丌下丕丁丅;
            this.丒丙七专丒东业丘世 = val_3;
            if(this.丑丞丝丒丏丙东一丄 != null)
            {
                    this.StopCoroutine(routine:  this.丑丞丝丒丏丙东一丄);
            }
            
            this.丑丞丝丒丏丙东一丄 = this.StartCoroutine(routine:  this.丈世丐万丏世下丒丗(丕丕世且下一与丝与:  丕丕世且下一与丝与));
        }
        private System.Collections.IEnumerator 丈世丐万丏世下丒丗(float 丕丕世且下一与丝与)
        {
            BattlePassCurrencyUpdater.专丙与丄不丗丙丛世 val_1 = new BattlePassCurrencyUpdater.专丙与丄不丗丙丛世();
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
            return BankController.七丞且七一丑下丒丞();
        }
        public BattlePassCurrencyUpdater()
        {
        
        }
    
    }

}
