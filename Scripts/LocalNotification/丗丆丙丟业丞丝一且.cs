using UnityEngine;

namespace LocalNotification
{
    internal sealed class 丗丆丙丟业丞丝一且 : 专丐丛东丄专万下丏
    {
        // Methods
        protected override void 丗七且下上丐世丛且()
        {
            if(true != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_1 = new System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞>();
            mem[1152921540883929272] = val_1;
            .下丄丈不与世丐业专 = "TournamentOver";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丗丆丙丟业丞丝一且::世丂万丞丂且丅丏专());
            val_1.set_Item(key:  "TournamentOver", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            .下丄丈不与世丐业专 = "TournamentOverHalf";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丗丆丙丟业丞丝一且::七丆下上丑三不丝丈());
            val_1.set_Item(key:  "TournamentOverHalf", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            .下丄丈不与世丐业专 = "TournamentOverReward";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丗丆丙丟业丞丝一且::丐丈丆与丟与丞丅专());
            val_1.set_Item(key:  "TournamentOverReward", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
        }
        private System.TimeSpan 世丂万丞丂且丅丏专()
        {
            System.TimeSpan val_12;
            var val_13;
            if((Rilisoft.Singleton<TournamentController>.Instance) == 0)
            {
                goto label_10;
            }
            
            int val_4 = Rilisoft.Singleton<TournamentController>.Instance.丂三下丒丒丁不上东();
            if(((val_4 <= 0) || ((Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁()) != 1)) || (PixelTime.丒丙专丟世丟丌丁上() == false))
            {
                goto label_10;
            }
            
            System.TimeSpan val_10 = System.TimeSpan.FromSeconds(value:  (double)(long)val_4 - PixelTime.丙丅丅业丟丁世丁丗());
            val_12 = val_10._ticks;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_10._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return val_12;
            }
            
            val_13 = null;
            goto label_16;
            label_10:
            val_13 = null;
            label_16:
            val_12 = System.TimeSpan.Zero;
            return val_12;
        }
        private System.TimeSpan 七丆下上丑三不丝丈()
        {
            UnityEngine.Object val_13;
            var val_15;
            val_13 = Rilisoft.Singleton<TournamentController>.Instance;
            if(val_13 != 0)
            {
                    val_13 = Rilisoft.Singleton<TournamentController>.Instance.丂三下丒丒丁不上东();
                if((val_13 > 0) && ((Rilisoft.Singleton<TournamentController>.Instance.万与丛世丒丅下上丁()) == 1))
            {
                    if(PixelTime.丒丙专丟世丟丌丁上() != false)
            {
                    val_13 = PixelTime.丙丅丅业丟丁世丁丗();
                System.TimeSpan val_10 = System.TimeSpan.FromSeconds(value:  (double)(long)val_13 - val_13);
                System.TimeSpan val_11 = System.TimeSpan.FromHours(value:  12);
                if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = 1152921540884219016}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return (System.TimeSpan)System.TimeSpan.__il2cppRuntimeField_static_fields;
            }
            
                val_15 = null;
                return (System.TimeSpan)System.TimeSpan.__il2cppRuntimeField_static_fields;
            }
            
            }
            
            }
            
            val_15 = null;
            return (System.TimeSpan)System.TimeSpan.__il2cppRuntimeField_static_fields;
        }
        private System.TimeSpan 丐丈丆与丟与丞丅专()
        {
            var val_7;
            System.TimeSpan val_8;
            if((Rilisoft.Singleton<TournamentController>.Instance) == 0)
            {
                    val_7 = null;
            }
            else
            {
                    if((Rilisoft.Singleton<TournamentController>.Instance.丁业世丄专一丁专丙()) != false)
            {
                    System.TimeSpan val_5 = System.TimeSpan.FromHours(value:  1);
                val_8 = val_5._ticks;
                if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_5._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return val_8;
            }
            
            }
            else
            {
                    val_7 = null;
            }
            
            }
            
            val_8 = System.TimeSpan.Zero;
            return val_8;
        }
        public 丗丆丙丟业丞丝一且()
        {
            val_1 = new System.Object();
        }
    
    }

}
