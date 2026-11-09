using UnityEngine;

namespace PGCompany
{
    internal sealed class GoblinAutoCollectorController : PGBehaviour
    {
        // Fields
        private long 丘丕且三与业不七万;
        private UnityEngine.Coroutine 世上丒丐丝丘丟专丏;
        private UnityEngine.Coroutine 丆丙丐专七丐一丞万;
        private UnityEngine.Coroutine <丐丗世三与丝丂专丕>k__BackingField;
        
        // Properties
        internal static PGCompany.GoblinAutoCollectorController 丆丕丝丒不丙且丐丗 { get; }
        internal UnityEngine.Coroutine 丕丁丕丏万丒丅业丁 { get; set; }
        
        // Methods
        internal static PGCompany.GoblinAutoCollectorController 丑七不且上丗丁一世()
        {
            PGCompany.ItemExpiryController val_1 = PGCompany.ItemExpiryController.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.一七丁专丂丛丐丈丞();
            }
            
            return val_1.一七丁专丂丛丐丈丞();
        }
        private void Awake()
        {
            PGCompany.上专丌丂上业丕丌七.下丈东万且丐一一丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GoblinAutoCollectorController::丝丝丞丟丕丛丙丘丘()));
            PGCompany.上专丌丂上业丕丌七.丄丁下丆丞丞东专且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GoblinAutoCollectorController::世丑丁丂丛三丂一丟()));
            PGCompany.世东三上七丂丌下丑.丅与丝丒且丙丕业丕(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void PGCompany.GoblinAutoCollectorController::丐丏东丙三丐三一丗(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)));
            PGCompany.ClanWarController.丝丐丌世且丘丏丅丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GoblinAutoCollectorController::丝丝丞丟丕丛丙丘丘()));
            一丅三东丑丗丅丗丝.东丗丞丘不专丑东业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GoblinAutoCollectorController::专丂丈丕丞丅业不丟()));
            PGCompany.上专丌丂上业丕丌七.下丈东万且丐一一丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GoblinAutoCollectorController::丈三丗且丌丐万丅丙()));
        }
        private void OnDisable()
        {
            if(this.丆丙丐专七丐一丞万 != null)
            {
                    this.StopCoroutine(routine:  this.丆丙丐专七丐一丞万);
            }
            
            this.丆丙丐专七丐一丞万 = 0;
        }
        private void 丐丏东丙三丐三一丗(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 丅一丘丙上东丏丅不)
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丈不下丕丘丌下不丈(与丙丄丈丝且业且与:  丅一丘丙上东丏丅不.一与丆丐丟上丆丅丐, 万丛且上丅丁丗七世:  丅一丘丙上东丏丅不.一且丟丁上丑业丕且));
        }
        private System.Collections.IEnumerator 丈不下丕丘丌下不丈(PGCompany.丗丟丄丈东丝丕丄世 与丙丄丈丝且业且与, PGCompany.三东丏不丗世丅丌丄 万丛且上丅丁丗七世)
        {
            GoblinAutoCollectorController.丅丗丏与丈丛丁丅丄 val_1 = new GoblinAutoCollectorController.丅丗丏与丈丛丁丅丄();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .与丙丄丈丝且业且与 = 与丙丄丈丝且业且与;
                .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[48] = this;
                mem[40] = 与丙丄丈丝且业且与;
            }
            
            .万丛且上丅丁丗七世 = 万丛且上丅丁丗七世;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丝丝丞丟丕丛丙丘丘()
        {
            if(this.世上丒丐丝丘丟专丏 != null)
            {
                    this.StopCoroutine(routine:  this.世上丒丐丝丘丟专丏);
                this.世上丒丐丝丘丟专丏 = 0;
            }
            
            this.世上丒丐丝丘丟专丏 = this.StartCoroutine(routine:  this.丛丕七且世丟一不丌());
        }
        private System.Collections.IEnumerator 丛丕七且世丟一不丌()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new GoblinAutoCollectorController.丏丐丗丁七丒业业丂();
        }
        private void 世与一世丝与丅丂丕()
        {
            if(this.丆丙丐专七丐一丞万 != null)
            {
                    this.StopCoroutine(routine:  this.丆丙丐专七丐一丞万);
            }
            
            this.丆丙丐专七丐一丞万 = 0;
        }
        private System.Collections.IEnumerator 丛丘丘丆一与七丑三(float 丆丐七丅丆丗丛上与)
        {
            GoblinAutoCollectorController.上下丆丄业丒丝不丐 val_1 = new GoblinAutoCollectorController.上下丆丄业丒丝不丐();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[40] = this;
            }
            
            .丆丐七丅丆丗丛上与 = 丆丐七丅丆丗丛上与;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 世丑丁丂丛三丂一丟()
        {
            var val_24;
            var val_25;
            var val_26;
            PGCompany.不丒丄专万丛丁业丌 val_2 = 业丂丏与世一丏业不.丑七不且上丗丁一世().三丝丂丟丒且丐东丘();
            if(val_2 == null)
            {
                    return;
            }
            
            val_24 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  101);
            int val_5 = val_2.丗丛与丏一不东丗丏();
            if(val_24 >= val_5)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  223);
            PGCompany.三东丏不丗世丅丌丄 val_7 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  79);
            val_7.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_2.专丈丐万丕丗丌丁丈());
            PGCompany.三东丏不丗世丅丌丄 val_9 = PGCompany.万丞丘与丕丞下万丌.丐丝不七与丑且丟丝(丈丄不七三万丄丁不:  val_7);
            PGCompany.丗丟丄丈东丝丕丄世 val_11 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_9, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丒丆七丘不下与丈丛(丛世丕丛丁专世丐丐:  val_9.丂丁丏一丙丛业且丌(), 万三丏世丙丏下与不:  val_2.丂不丐一上丐丏丆丅());
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  101, 丙业与丙丗丝不丈东:  val_5);
            int val_16 = val_2.万丄世丑丐丏万万丟();
            val_25 = null;
            val_25 = null;
            if(((丌丅且丗七丘丅丛丑.业丏丐下专东万世丂(丅专与丒丈丗丒丘丌:  丌丅且丗七丘丅丛丑.下万丈且丈上三丟七)) * val_16) >= 1)
            {
                    val_26 = null;
                val_26 = null;
                丌丅且丗七丘丅丛丑.丒下业下下丑下丆与(丅专与丒丈丗丒丘丌:  丌丅且丗七丘丅丛丑.下万丈且丈上三丟七, 丟丗且东万丅丝丐七:  val_16);
            }
            
            PGCompany.Analytics.一业丗丆世世上丁且.丅丕东不丛与下丁业(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丟三丞三丞丁世丙丐:  val_9.丂丁丏一丙丛业且丌(), 专丞丞丈丁丕丑一三:  val_2.丂不丐一上丐丏丆丅(), 丙丌不丕业丙丙丏万:  true);
            val_24 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            val_24.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            Rilisoft.丞丛七上丕专丏丌丈.上丗丝丙丒丂东丅丄();
            Rilisoft.丞丛七上丕专丏丌丈.上丗丝丙丒丂东丅丄();
            Rilisoft.丞丛七上丕专丏丌丈.且丟东丗丙丁丄与丂(丁业丆丛丅丆丟丟丑:  val_2.丂不丐一上丐丏丆丅());
            if((this.<丐丗世三与丝丂专丕>k__BackingField) != null)
            {
                    this.StopCoroutine(routine:  this.<丐丗世三与丝丂专丕>k__BackingField);
            }
            
            this.<丐丗世三与丝丂专丕>k__BackingField = 0;
        }
        internal UnityEngine.Coroutine 丏丌不丌七专且七丂()
        {
            return (UnityEngine.Coroutine)this.<丐丗世三与丝丂专丕>k__BackingField;
        }
        private void 丗丐丒丄丟丑丐丗丙(UnityEngine.Coroutine 丙业与丙丗丝不丈东)
        {
            this.<丐丗世三与丝丂专丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private void 专丂丈丕丞丅业不丟()
        {
            if((this.<丐丗世三与丝丂专丕>k__BackingField) != null)
            {
                    this.StopCoroutine(routine:  this.<丐丗世三与丝丂专丕>k__BackingField);
            }
            
            this.<丐丗世三与丝丂专丕>k__BackingField = 0;
            this.<丐丗世三与丝丂专丕>k__BackingField = this.StartCoroutine(routine:  this.专丗下丝专一业三专());
        }
        private void 丈三丗且丌丐万丅丙()
        {
            if((this.<丐丗世三与丝丂专丕>k__BackingField) != null)
            {
                    this.StopCoroutine(routine:  this.<丐丗世三与丝丂专丕>k__BackingField);
            }
            
            this.<丐丗世三与丝丂专丕>k__BackingField = 0;
        }
        private System.Collections.IEnumerator 专丗下丝专一业三专()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            return (System.Collections.IEnumerator)new GoblinAutoCollectorController.丛丞丙丗万丂丞丙丌();
        }
        public GoblinAutoCollectorController()
        {
        
        }
    
    }

}
