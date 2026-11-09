using UnityEngine;

namespace RilisoftBot
{
    internal class SwitchLogicBaseBot : MonoBehaviour
    {
        // Fields
        public System.Collections.Generic.List<RilisoftBot.SwitchLogicBaseBot.LogicInfoBaseBot> listLogicMob;
        private System.Collections.Generic.List<RilisoftBot.SwitchLogicBaseBot.LogicInfoBaseBot> 丁万丝丞丈七七三丂;
        public RilisoftBot.BotAiController botController;
        private System.Action<RilisoftBot.BaseBot> 丕东丒七且不丗丌丕;
        private System.Action 丕丂丁丛丆七丕丘万;
        private RilisoftBot.BaseBot 丅七三丙丈下下丈下;
        public UnityEngine.Animation animation;
        private float 丟丈丕上丒上丌丗世;
        private bool 丝丕丆丂不丞丆世丗;
        
        // Methods
        internal void 万丁丒世丁丗丐丐专(System.Action<RilisoftBot.BaseBot> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丕东丒七且不丗丌丕, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丕东丒七且不丗丌丕 != 1152921541012213504);
        
        }
        internal void 丗上上不七丙丏丒丝(System.Action<RilisoftBot.BaseBot> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丕东丒七且不丗丌丕, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丕东丒七且不丗丌丕 != 1152921541012350080);
        
        }
        internal void 一且业丏世丞丂丙丙(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丕丂丁丛丆七丕丘万, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丕丂丁丛丆七丕丘万 != 1152921541012486664);
        
        }
        internal void 丝专业下丌丟世一丌(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丕丂丁丛丆七丕丘万, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丕丂丁丛丆七丕丘万 != 1152921541012623240);
        
        }
        private void Start()
        {
            var val_3;
            List.Enumerator<T> val_1 = this.listLogicMob.GetEnumerator();
            label_17:
            if((2046183776 & 1) == 0)
            {
                goto label_2;
            }
            
            X21.enabled = false;
            System.Action<RilisoftBot.BaseBot, System.Single, System.Boolean, 世不丟丂上丟与丌下> val_5 = new System.Action<RilisoftBot.BaseBot, System.Single, System.Boolean, 世不丟丂上丟与丌下>(object:  this, method:  System.Void RilisoftBot.SwitchLogicBaseBot::业丅丛世上丙丗丒丏(RilisoftBot.BaseBot 业丘东且七丕丞东不, float 丞丈专下丈专业三丞, bool 业一丘不万丂七上丝, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三));
            X21.丑且丑世丑世东专上(丙业与丙丗丝不丈东:  null);
            System.Action<RilisoftBot.BaseBot, System.Single> val_6 = new System.Action<RilisoftBot.BaseBot, System.Single>(object:  this, method:  System.Void RilisoftBot.SwitchLogicBaseBot::不丒丁上一丑上专七(RilisoftBot.BaseBot 业丘东且七丕丞东不, float 世丙丟上丘上七万万));
            X21.万丁丈丄丆丄不丄万(丙业与丙丗丝不丈东:  null);
            bool val_7 = UnityEngine.Object.op_Inequality(x:  X21, y:  0);
            if((val_7 != false) && (val_7 != false))
            {
                    X21.name = val_7.丒丈丆七丞丁七丌丈();
            }
            
            if(val_4.m_stringLength != 1f)
            {
                goto label_17;
            }
            
            this.丁万丝丞丈七七三丂.Add(item:  val_3.丐丏七丌丕丗业且上());
            goto label_17;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void OnDestroy()
        {
            List.Enumerator<T> val_1 = this.listLogicMob.GetEnumerator();
            label_6:
            if((2046336760 & 1) == 0)
            {
                goto label_2;
            }
            
            System.Action<RilisoftBot.BaseBot, System.Single, System.Boolean, 世不丟丂上丟与丌下> val_3 = new System.Action<RilisoftBot.BaseBot, System.Single, System.Boolean, 世不丟丂上丟与丌下>(object:  this, method:  System.Void RilisoftBot.SwitchLogicBaseBot::业丅丛世上丙丗丒丏(RilisoftBot.BaseBot 业丘东且七丕丞东不, float 丞丈专下丈专业三丞, bool 业一丘不万丂七上丝, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三));
            X21.丁丙丌与丑丘丄丝丘(丙业与丙丗丝不丈东:  null);
            System.Action<RilisoftBot.BaseBot, System.Single> val_4 = new System.Action<RilisoftBot.BaseBot, System.Single>(object:  this, method:  System.Void RilisoftBot.SwitchLogicBaseBot::不丒丁上一丑上专七(RilisoftBot.BaseBot 业丘东且七丕丞东不, float 世丙丟上丘上七万万));
            0.丐丏七丌丕丗业且上().丁丂丝丗丕丂丗三且(丙业与丙丗丝不丈东:  null);
            goto label_6;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void Update()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.丟丈丕上丒上丌丗世 - val_1;
            this.丟丈丕上丒上丌丗世 = val_1;
            if(val_1 > 0f)
            {
                    return;
            }
            
            if(this.botController.丅丂丟丁三丐丕三丈() == false)
            {
                    return;
            }
            
            if(this.丝丕丆丂不丞丆世丗 != false)
            {
                    return;
            }
            
            this.丌丑丗丛丛丐丄丘丕(丙丛丂丈丛上丙且丈:  this.丙丌丘上万丟丐七丛());
        }
        private void 丌丑丗丛丛丐丄丘丕(RilisoftBot.SwitchLogicBaseBot.LogicInfoBaseBot 丙丛丂丈丛上丙且丈)
        {
            RilisoftBot.BaseBot val_8 = 丙丛丂丈丛上丙且丈.baseBot;
            if(val_8 == this.丅七三丙丈下下丈下)
            {
                    return;
            }
            
            if(this.丅七三丙丈下下丈下 != 0)
            {
                    if(this.丅七三丙丈下下丈下 != null)
            {
                    this.animation.RemoveClip(clipName:  this.丅七三丙丈下下丈下.丒丈丆七丞丁七丌丈());
            }
            
                this.botController.业丐与丐丒丈七七丄();
                this.丅七三丙丈下下丈下.enabled = false;
            }
            
            this.丅七三丙丈下下丈下 = 丙丛丂丈丛上丙且丈.baseBot;
            丙丛丂丈丛上丙且丈.baseBot.transform.SetParent(p:  this.transform);
            this.botController.丕丒一丕下业下且丈(丗不丛七丏丄业三丁:  this.丅七三丙丈下下丈下);
            this.丅七三丙丈下下丈下.PlayVoiceSound();
            if(丙丛丂丈丛上丙且丈.clip == 0)
            {
                goto label_24;
            }
            
            if(this.丅七三丙丈下下丈下 == null)
            {
                goto label_26;
            }
            
            this.animation.AddClip(clip:  丙丛丂丈丛上丙且丈.clip, newName:  this.丅七三丙丈下下丈下.丒丈丆七丞丁七丌丈());
            label_24:
            if(this.丅七三丙丈下下丈下 != null)
            {
                    val_8 = this.丅七三丙丈下下丈下;
                val_8.enabled = true;
                this.丟丈丕上丒上丌丗世 = 丙丛丂丈丛上丙且丈.mechanicalTime;
                if(this.丕东丒七且不丗丌丕 == null)
            {
                    return;
            }
            
                this.丕东丒七且不丗丌丕.Invoke(obj:  this.丅七三丙丈下下丈下);
                return;
            }
            
            label_26:
        }
        private void 不丒丁上一丑上专七(RilisoftBot.BaseBot 业丘东且七丕丞东不, float 世丙丟上丘上七万万)
        {
            List.Enumerator<T> val_1 = this.listLogicMob.GetEnumerator();
            label_8:
            if((2046922632 & 1) == 0)
            {
                goto label_2;
            }
            
            if(static_value_082C2000 == 业丘东且七丕丞东不)
            {
                goto label_8;
            }
            
            0.丐丏七丌丕丗业且上().丂丟丙丂丕专丂七下(上上丗丁丏丙丄丏七:  世丙丟上丘上七万万, 一丁世三丈专且七东:  false);
            goto label_8;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        private void 业丅丛世上丙丗丒丏(RilisoftBot.BaseBot 业丘东且七丕丞东不, float 丞丈专下丈专业三丞, bool 业一丘不万丂七上丝 = True, Player_move_c.世不丟丂上丟与丌下 丅业下不东丗丄与三 = 0)
        {
            var val_3;
            var val_10;
            LogicInfoBaseBot val_15;
            var val_17;
            var val_18;
            var val_21;
            RilisoftBot.BaseBot val_22;
            float val_23;
            val_15 = 1152921541012727568;
            List.Enumerator<T> val_1 = this.listLogicMob.GetEnumerator();
            var val_15 = 0;
            label_19:
            if((2047101136 & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if((X21 + 280) > 0f)
            {
                goto label_19;
            }
            
            this.丝丕丆丂不丞丆世丗 = true;
            if(this.丕丂丁丛丆七丕丘万 != null)
            {
                    this.丕丂丁丛丆七丕丘万.Invoke();
            }
            
            List.Enumerator<T> val_5 = this.listLogicMob.GetEnumerator();
            label_11:
            if((2047101104 & 1) == 0)
            {
                goto label_8;
            }
            
            val_3.丐丏七丌丕丗业且上().丄一丟丄万丐东不七();
            goto label_11;
            label_8:
            val_15 = val_15 + 1;
            val_18 = 0;
            mem2[0] = 306;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_15 != 1)
            {
                    if((2047101024 + ((0 + 1)) << 2) == 306)
            {
                goto label_17;
            }
            
            }
            
            if( == 0)
            {
                goto label_19;
            }
            
            goto label_19;
            label_2:
            val_18 = 0;
            val_21 = val_15 + 1;
            mem2[0] = 148;
            goto label_20;
            label_17:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return;
            label_20:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_15 == 1)
            {
                goto label_31;
            }
            
            if((2047101024 + ((0 + 1)) << 2) == 306)
            {
                    return;
            }
            
            if((2047101024 + ((0 + 1)) << 2) != 148)
            {
                goto label_31;
            }
            
            var val_16 = 0;
            val_16 = val_16 ^ (val_15 >> 31);
            val_21 = val_15 + val_16;
            goto label_33;
            label_31:
            if( != 0)
            {
                    val_18 = 0;
            }
            
            label_33:
            val_22 = this.丅七三丙丈下下丈下;
            if(val_22 != null)
            {
                    val_23 = this.丅七三丙丈下下丈下.health;
            }
            else
            {
                    val_23 = this.丅七三丙丈下下丈下.health;
                if(this.丅七三丙丈下下丈下 != null)
            {
                    val_22 = this.丅七三丙丈下下丈下;
            }
            else
            {
                    val_22 = 0;
            }
            
            }
            
            float val_17 = val_22.maxHealth;
            val_17 = val_23 / val_17;
            List.Enumerator<T> val_8 = this.listLogicMob.GetEnumerator();
            val_17 = 1152921504848912384;
            val_15 = 0;
            label_49:
            label_47:
            if((2047101136 & 1) == 0)
            {
                goto label_39;
            }
            
            string val_12 = val_10.丐丏七丌丕丗业且上();
            if(50 != 业丘东且七丕丞东不)
            {
                    306.业丂丛丟上且丂东丂(丞丈专下丈专业三丞:  丞丈专下丈专业三丞, 一丗丈丛万丄世一丘:  0, 业一丘不万丂七上丝:  业一丘不万丂七上丝, 丅业下不东丗丄与三:  丅业下不东丗丄与三, 丝丅且丁万下业七万:  false);
            }
            
            if((val_17 > val_12.m_stringLength) || ((this.丁万丝丞丈七七三丂.Contains(item:  val_12)) == true))
            {
                goto label_47;
            }
            
            this.丁万丝丞丈七七三丂.Add(item:  val_12);
            goto label_49;
            label_39:
            val_15 = val_15 + 1;
            mem2[0] = 296;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_15 == 1)
            {
                goto label_57;
            }
            
            if(( == 0) || ((2047101024 + (((0 + 1) + 1)) << 2) == 296))
            {
                goto label_62;
            }
            
            label_61:
            label_62:
            if(val_15 == 0)
            {
                    return;
            }
            
            this.丌丑丗丛丛丐丄丘丕(丙丛丂丈丛上丙且丈:  val_15);
            return;
            label_57:
            if( != 0)
            {
                goto label_61;
            }
            
            goto label_62;
        }
        private RilisoftBot.SwitchLogicBaseBot.LogicInfoBaseBot 丅世丌上丟丂丞丆丏()
        {
            if(this.丁万丝丞丈七七三丂 != null)
            {
                    return this.丁万丝丞丈七七三丂.Item[UnityEngine.Random.Range(min:  0, max:  this.丁万丝丞丈七七三丂.Count)];
            }
            
            return this.丁万丝丞丈七七三丂.Item[UnityEngine.Random.Range(min:  0, max:  this.丁万丝丞丈七七三丂.Count)];
        }
        private RilisoftBot.SwitchLogicBaseBot.LogicInfoBaseBot 丙丌丘上万丟丐七丛()
        {
            var val_8;
            System.Collections.Generic.List<LogicInfoBaseBot> val_9;
            System.Collections.Generic.List<LogicInfoBaseBot> val_10;
            var val_11;
            val_8 = this;
            if(this.丅七三丙丈下下丈下 != 0)
            {
                goto label_3;
            }
            
            val_9 = this.丁万丝丞丈七七三丂;
            if(val_9 == null)
            {
                    val_9 = 0;
            }
            
            val_8 = 0;
            goto label_14;
            label_3:
            var val_8 = 0;
            label_12:
            val_10 = this.丁万丝丞丈七七三丂;
            if(val_8 >= val_10.Count)
            {
                goto label_7;
            }
            
            LogicInfoBaseBot val_3 = this.丁万丝丞丈七七三丂.Item[0];
            val_8 = val_8 + 1;
            if(this.丅七三丙丈下下丈下 != val_3.baseBot)
            {
                goto label_12;
            }
            
            val_10 = this.丁万丝丞丈七七三丂;
            val_9 = this.丁万丝丞丈七七三丂;
            if(val_9 == null)
            {
                    val_9 = 0;
            }
            
            label_14:
            LogicInfoBaseBot val_7 = val_9.Item[(val_8 < val_10.Count) ? (val_8) : 0];
            return (LogicInfoBaseBot)val_11;
            label_7:
            val_11 = 0;
            return (LogicInfoBaseBot)val_11;
        }
        public SwitchLogicBaseBot()
        {
            this.listLogicMob = new System.Collections.Generic.List<LogicInfoBaseBot>();
            this.丁万丝丞丈七七三丂 = new System.Collections.Generic.List<LogicInfoBaseBot>();
        }
    
    }

}
