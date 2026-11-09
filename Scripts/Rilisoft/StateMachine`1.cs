using UnityEngine;

namespace Rilisoft
{
    internal abstract class StateMachine<T> : VTableHolder
    {
        // Fields
        private string _callHistory;
        private System.Collections.Generic.List<string> 专三业下丐不丈丌丌;
        private int 丙且丄丙且丏丏丟丂;
        private bool 与丒丕丁下世东丅丌;
        private Rilisoft.StateMachine.丘丄下丗丐七一丝业<T, T> 丌丆与且丒丟丙丗一;
        private System.Collections.Generic.Dictionary<T, Rilisoft.StateMachine.丘丄下丗丐七一丝业<T, T>> 专丘丕上丘丐丝丅丏;
        private System.Collections.Generic.List<Rilisoft.StateMachine.业丗丈丏东丞与丆丕<T, T>> 业七丛东丈丌丝丐丈;
        private Rilisoft.StateMachine.丘丄下丗丐七一丝业<T, T> <七丆世丁丄丌丏丏且>k__BackingField;
        private System.Action<T, T> 丁丞丞丝上下且丝丘;
        
        // Properties
        public bool 三不专丗七丄且丝业 { get; set; }
        public Rilisoft.StateMachine.丘丄下丗丐七一丝业<T, T> 上丅丑丌丑丏丏丙东 { get; set; }
        
        // Methods
        public StateMachine<T>()
        {
            mem[1152921543352273816] = 10;
            mem[1152921543352273832] = __RuntimeMethodHiddenParam + 24 + 192;
            mem[1152921543352273840] = __RuntimeMethodHiddenParam + 24 + 192 + 16;
        }
        public bool get_Enabled()
        {
            return (bool)this;
        }
        public void set_Enabled(bool 丙业与丙丗丝不丈东)
        {
            mem[1152921543352497820] = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.StateMachine.丘丄下丗丐七一丝业<T, T> get_CurrentState()
        {
            return (StateMachine.丘丄下丗丐七一丝业<T, T>)this;
        }
        private void 丒丟丛丂丆三三丙丑(Rilisoft.StateMachine.丘丄下丗丐七一丝业<T, T> 丙业与丙丗丝不丈东)
        {
            mem[1152921543352725944] = 丙业与丙丗丝不丈东;
        }
        public void add_OnStateChanged(System.Action<T, T> 丙业与丙丗丝不丈东)
        {
            label_3:
            System.Delegate val_1 = System.Delegate.Combine(a:  X22, b:  丙业与丙丗丝不丈东);
            if(val_1 != null)
            {
                    if(val_1 != null)
            {
                goto label_2;
            }
            
            }
            
            label_2:
            if(X22 != 1152921543352850240)
            {
                goto label_3;
            }
        
        }
        public void remove_OnStateChanged(System.Action<T, T> 丙业与丙丗丝不丈东)
        {
            label_3:
            System.Delegate val_1 = System.Delegate.Remove(source:  X22, value:  丙业与丙丗丝不丈东);
            if(val_1 != null)
            {
                    if(val_1 != null)
            {
                goto label_2;
            }
            
            }
            
            label_2:
            if(X22 != 1152921543352978624)
            {
                goto label_3;
            }
        
        }
        protected Rilisoft.StateMachine<T> 万丂丝丁东丑丕丌丌(Rilisoft.StateMachine.丘丄下丗丐七一丝业<T, T> 丏业丟一东丂东丘丛)
        {
            if((137170944 & 1) == 0)
            {
                    return (Rilisoft.StateMachine<T>)this;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = ;
            UnityEngine.Debug.LogErrorFormat(format:  "state for \'{0}\' allready exists", args:  val_1);
            return (Rilisoft.StateMachine<T>)this;
        }
        protected void 丏丛不下一丝专丕丙()
        {
            mem[1152921543353227344] = 0;
        }
        protected Rilisoft.StateMachine<T> 不三丝丑三三世上丆(Rilisoft.StateMachine.业丗丈丏东丞与丆丕<T, T> 丅丘七丘丈与不丒一)
        {
            if(X21 != 0)
            {
                    return (Rilisoft.StateMachine<T>)this;
            }
            
            return (Rilisoft.StateMachine<T>)this;
        }
        public void To(T 丘丏世丈业丛丞丘丒)
        {
            var val_1;
            Rilisoft.丛七下丌丑不一丄业 val_2;
            System.Object[] val_8;
            Rilisoft.丛七下丌丑不一丄业 val_9;
            var val_10;
            var val_11;
            var val_12;
            val_8 = __RuntimeMethodHiddenParam;
            val_9 = 丘丏世丈业丛丞丘丒;
            if((137170944 & 1) == 0)
            {
                goto label_2;
            }
            
            if(this == null)
            {
                goto label_44;
            }
            
            mem[1152921543353471984] = this;
            label_17:
            if((91907168 & 1) == 0)
            {
                goto label_6;
            }
            
            val_2 = X24;
            if((91907144 & 1) == 0)
            {
                goto label_17;
            }
            
            val_2 = val_9;
            if(((91907120 & 1) == 0) || (val_2.丐丏七丌丕丗业且上() != null))
            {
                goto label_17;
            }
            
            goto label_17;
            label_2:
            object[] val_4 = new object[1];
            val_2 = val_9;
            val_8 = val_4;
            val_8[0] = ;
            UnityEngine.Debug.LogErrorFormat(format:  "state for \'{0}\' not found", args:  val_4);
            return;
            label_6:
            val_10 = 0;
            val_11 = 0;
            val_2 = __RuntimeMethodHiddenParam + 24 + 192 + 184;
            val_1 = val_2;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 286) == 0)
            {
                goto label_42;
            }
            
            var val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 184 + 176;
            var val_7 = 0;
            val_6 = val_6 + 8;
            label_41:
            if(((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 176 + 8) + -8) == null)
            {
                goto label_40;
            }
            
            val_7 = val_7 + 1;
            val_6 = val_6 + 16;
            if(val_7 < (__RuntimeMethodHiddenParam + 24 + 192 + 184 + 286))
            {
                goto label_41;
            }
            
            goto label_42;
            label_40:
            val_12 = ((__RuntimeMethodHiddenParam + 24 + 192 + 184) + (((__RuntimeMethodHiddenParam + 24 + 192 + 184 + 176 + 8)) << 4)) + 296;
            label_42:
            val_2.Dispose();
            label_44:
            if((__RuntimeMethodHiddenParam + 24 + 192 + 120) == 0)
            {
                goto label_46;
            }
            
            if(this != null)
            {
                goto label_52;
            }
            
            label_53:
            label_52:
            if(this == null)
            {
                    return;
            }
            
            if((__RuntimeMethodHiddenParam + 24 + 192 + 56) == 0)
            {
                    return;
            }
            
            return;
            label_46:
            if(this != null)
            {
                goto label_52;
            }
            
            goto label_53;
        }
        protected virtual void 丛丙世丞丌丄业丙丅()
        {
            var val_5 = this;
            if((val_5 & 1) == 0)
            {
                    return;
            }
            
            if(this == null)
            {
                    return;
            }
            
            val_5 = ???;
            goto typeof(Rilisoft.StateMachine<T>).__il2cppRuntimeField_188;
        }
    
    }

}
