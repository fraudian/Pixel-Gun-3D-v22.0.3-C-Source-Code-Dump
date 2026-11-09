using UnityEngine;

namespace Rilisoft
{
    internal abstract class 丙丐丐丙丈业丒不丁 : 丆专且丆世丟丄与丂
    {
        // Fields
        private string <丑丞东下万一业专与>k__BackingField;
        private bool <专丞一丗丞丂世专丑>k__BackingField;
        
        // Properties
        public override string 丞丕丛业丙下丈丒丌 { get; }
        public override bool 丒丌不丁丏丅丏丙世 { get; }
        protected string 丆丙业丈东万丄与世 { get; set; }
        protected bool 丛上三上丕下丑业丙 { get; set; }
        
        // Methods
        public 丙丐丐丙丈业丒不丁()
        {
        
        }
        public override string 专一东丟丟丗丄丝丐()
        {
            return (string)this.<丑丞东下万一业专与>k__BackingField;
        }
        public override bool 且七丒一专丘专下东()
        {
            return (bool)this.<专丞一丗丞丂世专丑>k__BackingField;
        }
        protected string 丟丏三丁世丏丝不丌()
        {
            return (string)this.<丑丞东下万一业专与>k__BackingField;
        }
        protected void 丄丈上一丙且万丅丞(string 丙业与丙丗丝不丈东)
        {
            this.<丑丞东下万一业专与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        protected bool 且万丐丈与东丄丄东()
        {
            return (bool)this.<专丞一丗丞丂世专丑>k__BackingField;
        }
        protected void 丞专世丗丛不丘丗丘(bool 丙业与丙丗丝不丈东)
        {
            this.<专丞一丗丞丂世专丑>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public override System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 专业丛丂丅与世上丙(bool 与且专丏丅世丐丐丑 = True)
        {
            System.Object[] val_30;
            string val_31;
            var val_33;
            var val_34;
            var val_35;
            System.Exception val_37;
            string val_3 = this.GetType() + ".Pull()";
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
            {
                goto label_3;
            }
            
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
            {
                goto label_6;
            }
            
            if(UnityEngine.Application.isEditor == false)
            {
                goto label_7;
            }
            
            val_30 = new object[1];
            val_30[0] = val_3;
            val_31 = "Skipping `{0}` in Editor";
            goto label_73;
            label_3:
            val_30 = new object[2];
            val_30[0] = val_3;
            UnityEngine.RuntimePlatform val_9 = Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂();
            val_33 = 1152921504831819776;
            goto label_19;
            label_6:
            object[] val_10 = new object[2];
            val_30 = val_10;
            val_30[0] = val_3;
            val_33 = 1152921505171595264;
            label_19:
            val_30[1] = 与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三();
            val_31 = "Skipping `{0}` on {1}";
            label_73:
            UnityEngine.Debug.LogWarningFormat(format:  val_31, args:  val_10);
            return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  2);
            label_7:
            if(AGSClient.IsServiceReady() == false)
            {
                goto label_33;
            }
            
            if(GameCircleSocial.Instance == null)
            {
                goto label_36;
            }
            
            UnityEngine.SocialPlatforms.ILocalUser val_15 = GameCircleSocial.Instance.localUser;
            if(val_15 == null)
            {
                goto label_40;
            }
            
            if(val_15.下丏丗与七丑丅与丅() == false)
            {
                goto label_41;
            }
            
            bool val_18 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
            AGSGameDataMap val_19 = AGSWhispersyncClient.GetGameData();
            if(val_19 == null)
            {
                goto label_46;
            }
            
            AGSWhispersyncClient.Synchronize();
            val_34 = 0;
            val_35 = 0;
            var val_30 = 0;
            val_30 = val_30 + 1;
            goto label_52;
            label_33:
            new object[1][0] = val_3;
            goto label_73;
            label_36:
            new object[1][0] = val_3;
            goto label_73;
            label_40:
            new object[1][0] = val_3;
            goto label_73;
            label_41:
            object[] val_23 = new object[2];
            val_23[0] = val_3;
            val_23[1] = 与且专丏丅世丐丐丑;
            UnityEngine.Debug.LogWarningFormat(format:  "Skipping `{0}`: Not authenticated, silent: {1}", args:  val_23);
            System.Threading.Tasks.Task<TResult> val_25 = System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  1);
            return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  2);
            label_46:
            object[] val_26 = new object[1];
            val_26[0] = val_3;
            UnityEngine.Debug.LogWarningFormat(format:  "Skipping `{0}`: `dataMap` is null", args:  val_26);
            return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  2);
            label_52:
            val_19.Dispose();
            if(val_35 == 1)
            {
                goto label_93;
            }
            
            if(400 != 400)
            {
                goto label_122;
            }
            
            return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  2);
            label_93:
            val_35 = 0;
            label_122:
            if(val_34 != 0)
            {
                    val_37 = 0;
                val_34 = val_37;
            }
            else
            {
                    val_37 = 0;
            }
            
            object[] val_28 = new object[2];
            val_28[0] = val_3;
            val_28[1] = val_37.GetType();
            UnityEngine.Debug.LogWarningFormat(format:  "Handled exception in `{0}`: `{1}`", args:  val_28);
            UnityEngine.Debug.LogException(exception:  val_37);
            if(1 != 1)
            {
                    if(398 == 398)
            {
                    return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  2);
            }
            
                if(398 == 400)
            {
                    return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  2);
            }
            
            }
            
            if(val_34 == 0)
            {
                    return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  2);
            }
            
            return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  2);
        }
        public override void 丅万丞丘与丏丝丕丅(string 一丐丗丁丞丆丅丟丄)
        {
            object val_20;
            System.Object[] val_21;
            string val_22;
            var val_24;
            var val_25;
            var val_26;
            val_20 = this.GetType() + ".Push()";
            if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
            {
                goto label_1;
            }
            
            if(与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三() != 1)
            {
                goto label_4;
            }
            
            if(UnityEngine.Application.isEditor == false)
            {
                goto label_5;
            }
            
            val_21 = new object[1];
            val_21[0] = val_20;
            val_22 = "Skipping `{0}` in Editor";
            goto label_49;
            label_1:
            val_21 = new object[2];
            val_21[0] = val_20;
            UnityEngine.RuntimePlatform val_8 = Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂();
            val_24 = 1152921504831819776;
            goto label_17;
            label_4:
            object[] val_9 = new object[2];
            val_21 = val_9;
            val_21[0] = val_20;
            val_24 = 1152921505171595264;
            label_17:
            val_20 = 与丂丏丛丞丞丒丟丄.丏丄专丞丌万与下三();
            val_21[1] = val_20;
            val_22 = "Skipping `{0}` on {1}";
            label_49:
            UnityEngine.Debug.LogWarningFormat(format:  val_22, args:  val_9);
            return;
            label_5:
            if(AGSClient.IsServiceReady() == false)
            {
                goto label_31;
            }
            
            bool val_13 = 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
            AGSGameDataMap val_14 = AGSWhispersyncClient.GetGameData();
            if(val_14 == null)
            {
                goto label_36;
            }
            
            AGSWhispersyncClient.Synchronize();
            val_25 = 0;
            val_26 = 0;
            var val_21 = 0;
            val_21 = val_21 + 1;
            goto label_42;
            label_31:
            new object[1][0] = val_20;
            goto label_49;
            label_36:
            object[] val_16 = new object[1];
            val_16[0] = val_20;
            UnityEngine.Debug.LogWarningFormat(format:  "Skipping `{0}`: `dataMap` is null", args:  val_16);
            return;
            label_42:
            val_14.Dispose();
            if(val_26 == 1)
            {
                goto label_57;
            }
            
            if(275 == 227)
            {
                goto label_58;
            }
            
            if(275 != 275)
            {
                goto label_73;
            }
            
            return;
            label_57:
            val_26 = 0;
            label_73:
            if(val_25 == 0)
            {
                goto label_62;
            }
            
            val_25 = 0;
            goto label_62;
            label_58:
            val_26 = 0;
            label_62:
            mem2[0] = 275;
            if((0 + 1) != 1)
            {
                    if((1152921542494504544 + ((0 + 1)) << 2) == 275)
            {
                    return;
            }
            
            }
            
            if(val_25 == 0)
            {
                    return;
            }
        
        }
        protected abstract System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 下丟不上丏丝丞丒丟(AGSGameDataMap 丟丝上三丙丁丁世丁); // 0
        protected abstract void 且且且丝丆一丄丗一(AGSGameDataMap 丟丝上三丙丁丁世丁, string 一丐丗丁丞丆丅丟丄); // 0
        protected bool 下丏丗与七丑丅与丅()
        {
            var val_7;
            if(GameCircleSocial.Instance == null)
            {
                    return false;
            }
            
            val_7 = GameCircleSocial.Instance;
            if(val_7.localUser == null)
            {
                    return false;
            }
            
            var val_7 = 0;
            val_7 = val_7 + 1;
            return GameCircleSocial.Instance.localUser.authenticated;
        }
    
    }

}
