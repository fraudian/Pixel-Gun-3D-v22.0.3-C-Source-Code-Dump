using UnityEngine;

namespace LocalNotification
{
    internal sealed class 丒下丌万丗一丐且丄 : 专丐丛东丄专万下丏
    {
        // Methods
        protected override void 丗七且下上丐世丛且()
        {
            if(true != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_1 = new System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞>();
            mem[1152921540877854600] = val_1;
            .下丄丈不与世丐业专 = "NewPet";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丒下丌万丗一丐且丄::丘丒不不丌丘下丒一());
            val_1.set_Item(key:  "NewPet", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
        }
        private System.TimeSpan 丘丒不不丌丘下丒一()
        {
            var val_18;
            var val_19;
            bool val_14 = false;
            if((Rilisoft.Singleton<Rilisoft.EggsManager>.Instance) == 0)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            System.Collections.Generic.List<PGCompany.EggIncubatorProgress> val_4 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丐丙丛丏专世丛不丄();
            val_18 = 0;
            goto label_5;
            label_13:
            val_19 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance;
            if((val_19.丞丕丞丛丁万丒丏丛(上丕丈丞丌丘丅不与:  val_4.Item[0])) == false)
            {
                goto label_8;
            }
            
            val_19 = Rilisoft.Singleton<Rilisoft.EggsManager>.Instance;
            if((val_19.丒丆丁丘丈丏丆丌丘(上丕丈丞丌丘丅不与:  val_4.Item[0])) == false)
            {
                goto label_11;
            }
            
            label_8:
            val_18 = 1;
            label_5:
            if(val_18 < val_4.Count)
            {
                goto label_13;
            }
            
            return (System.TimeSpan)System.TimeSpan.Zero;
            label_11:
            PGCompany.EggIncubatorProgress val_12 = val_4.Item[0];
            if(val_12 == null)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            if(val_14 == 0)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            System.TimeSpan val_16 = System.TimeSpan.FromSeconds(value:  (double)Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.丁业丐丐丆一丙丕丙(上丕丈丞丌丘丅不与:  val_12, 丕且七业丙万丕丛丞: out  val_14));
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_16._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            return (System.TimeSpan)System.TimeSpan.Zero;
        }
        public 丒下丌万丗一丐且丄()
        {
            val_1 = new System.Object();
        }
    
    }

}
