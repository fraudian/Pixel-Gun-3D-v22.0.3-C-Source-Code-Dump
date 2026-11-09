using UnityEngine;

namespace LocalNotification
{
    internal sealed class 丅且丆丐万丟丛丆专 : 专丐丛东丄专万下丏
    {
        // Methods
        protected override void 丗七且下上丐世丛且()
        {
            if(true != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞> val_1 = new System.Collections.Generic.Dictionary<System.String, 丐丝丒业且丁丁下丞>();
            mem[1152921540874056408] = val_1;
            .下丄丈不与世丐业专 = "CraftLobbyCreate";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丅且丆丐万丟丛丆专::丄万不丟丑丘业丈丐());
            val_1.set_Item(key:  "CraftLobbyCreate", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
            .下丄丈不与世丐业专 = "CraftLobbyVideo";
            .丂丌与专七丟丂三不 = new System.Func<System.TimeSpan>(object:  this, method:  System.TimeSpan LocalNotification.丅且丆丐万丟丛丆专::丏丆丌丗丈丛丈一丈());
            val_1.set_Item(key:  "CraftLobbyVideo", value:  new 专丐丛东丄专万下丏.丐丝丒业且丁丁下丞());
        }
        private System.TimeSpan 丄万不丟丑丘业丈丐()
        {
            System.TimeSpan val_10;
            var val_11;
            if(((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance) == 0) || ((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万()) == null))
            {
                goto label_5;
            }
            
            long val_7 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万().下丞丘丏丂丕丄丐丘();
            if(val_7 <= 0)
            {
                goto label_8;
            }
            
            System.TimeSpan val_8 = System.TimeSpan.FromSeconds(value:  (double)val_7);
            val_10 = val_8._ticks;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_8._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return val_10;
            }
            
            val_11 = null;
            goto label_16;
            label_5:
            val_11 = null;
            goto label_16;
            label_8:
            label_16:
            val_10 = System.TimeSpan.Zero;
            return val_10;
        }
        private System.TimeSpan 丏丆丌丗丈丛丈一丈()
        {
            var val_32;
            var val_33;
            var val_34;
            var val_35;
            var val_36;
            丅丒不上七丘万丙一 val_12 = 0;
            string val_11 = 0;
            丕丄丘不专丘七专与 val_13 = 0;
            val_32 = 1152921524490355520;
            if((Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance) == 0)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            Rilisoft.丏丘七丞丄丙丌丞丁 val_4 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丟丑丒丂万丟专丁万();
            if(val_4 == null)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            if(val_4.丑丆丑三且丛上且丟() == false)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            if(Rilisoft.FreeLobbyCraftController.丑七不且上丗丁一世() == 0)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            if(Rilisoft.FreeLobbyCraftController.丑七不且上丗丁一世().丄丛丅丐世丌丕且丛() == true)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            if(((PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌: out  val_11, 丟丐丗万丅下丗丝万: out  val_12, 丌东丙丝丂一丅三丞: out  val_13, 丏丞专丏业丗丝七丝: out  0)) == false) || (135970152 == 0))
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            var val_34 = 106557164;
            if(0 == 0)
            {
                goto label_21;
            }
            
            var val_32 = 0;
            var val_33 = 107374182407;
            label_20:
            if(mem[107374182399] == null)
            {
                goto label_19;
            }
            
            val_32 = val_32 + 1;
            val_33 = val_33 + 16;
            if(val_32 < 0)
            {
                goto label_20;
            }
            
            goto label_21;
            label_19:
            val_34 = val_34 + ((mem[107374182407]) << 4);
            val_33 = val_34 + 296;
            label_21:
            if(135970152.Count == 0)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            System.Collections.Generic.KeyValuePair<System.DateTime, System.Int32> val_17 = FreeAwardController.且丑丂不丑上七丂丈(丅专与丒丈丗丒丘丌:  val_11);
            var val_37 = 106557164;
            val_32 = System.Math.Max(val1:  0, val2:  1907778200);
            if(0 == 0)
            {
                goto label_28;
            }
            
            var val_35 = 0;
            var val_36 = 107374182407;
            label_27:
            if(mem[107374182399] == null)
            {
                goto label_26;
            }
            
            val_35 = val_35 + 1;
            val_36 = val_36 + 16;
            if(val_35 < 0)
            {
                goto label_27;
            }
            
            goto label_28;
            label_26:
            val_37 = val_37 + ((mem[107374182407]) << 4);
            val_34 = val_37 + 296;
            label_28:
            if(val_32 < 135970152.Count)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            System.TimeSpan val_22 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().业丞不上丞丛三与万(丅专与丒丈丗丒丘丌:  val_11, 丟丐丗万丅下丗丝万:  val_12, 丌东丙丝丂一丅三丞:  val_13);
            val_35 = null;
            val_35 = null;
            if((System.TimeSpan.op_Equality(t1:  new System.TimeSpan() {_ticks = val_22._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.MaxValue})) == true)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            System.DateTime val_24 = PGCompany.万下丂且东丌一丌丆.万下专丒丞丒丘与丐(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_17.Value.丐丏七丌丕丗业且上()}, 丙业与丙丗丝不丈东:  new System.TimeSpan() {_ticks = val_22._ticks});
            System.DateTime val_26 = System.DateTime.Now;
            System.DateTime val_27 = val_26.dateData.AddSeconds(value:  (double)val_4.下丞丘丏丂丕丄丐丘());
            if((System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_27.dateData}, t2:  new System.DateTime() {dateData = val_24.dateData})) == true)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            System.DateTime val_29 = System.DateTime.Now;
            System.TimeSpan val_30 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_24.dateData}, d2:  new System.DateTime() {dateData = val_29.dateData});
            val_36 = null;
            val_36 = null;
            if((System.TimeSpan.op_GreaterThan(t1:  new System.TimeSpan() {_ticks = val_30._ticks}, t2:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero})) == true)
            {
                    return (System.TimeSpan)System.TimeSpan.Zero;
            }
            
            return (System.TimeSpan)System.TimeSpan.Zero;
        }
        public 丅且丆丐万丟丛丆专()
        {
            val_1 = new System.Object();
        }
    
    }

}
