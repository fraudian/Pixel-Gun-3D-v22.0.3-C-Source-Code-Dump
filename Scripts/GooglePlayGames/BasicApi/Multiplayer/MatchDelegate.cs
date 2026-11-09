using UnityEngine;

namespace GooglePlayGames.BasicApi.Multiplayer
{
    public sealed class MatchDelegate : MulticastDelegate
    {
        // Methods
        public MatchDelegate(object object, IntPtr method)
        {
            mem[1152921541890741568] = object;
            mem[1152921541890741576] = method;
            mem[1152921541890741552] = method;
        }
        public virtual void Invoke(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, bool shouldAutoLaunch)
        {
            var val_34;
            var val_35;
            var val_37;
            var val_38;
            var val_39;
            var val_42;
            var val_43;
            var val_44;
            if(X25 == 0)
            {
                goto label_0;
            }
            
            if((X25 + 24) == 0)
            {
                    return;
            }
            
            var val_45 = 0;
            goto label_65;
            label_0:
            if((X22 & 1) == 0)
            {
                goto label_4;
            }
            
            if((X22 + 74) != 2)
            {
                goto label_5;
            }
            
            if((X22 + 72) == 65535)
            {
                goto label_9;
            }
            
            if(X23 != 0)
            {
                    if(((X23 + 265) & 1) != 0)
            {
                goto label_9;
            }
            
            }
            
            if((X23 + 265) == 0)
            {
                goto label_9;
            }
            
            if(X23 == 0)
            {
                goto label_70;
            }
            
            if(((X23 + 265) & 1) != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = X22.丘一一丆业丂丘丒世();
            if((X22 & 1) == 0)
            {
                goto label_12;
            }
            
            if((val_1 & 1) == 0)
            {
                goto label_13;
            }
            
            var val_53 = X23;
            if((X23 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_31 = X23 + 176;
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_16:
            if(((X23 + 176 + 8) + -8) == (X22 + 24))
            {
                goto label_15;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < (X23 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_59:
            val_34 = mem[X22 + 72];
            val_34 = X22 + 72;
            if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0)) & 1) == 0)
            {
                goto label_18;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = X22.丘一一丆业丂丘丒世();
            var val_33 = 0;
            val_33 = val_33 + 1;
            goto label_22;
            label_60:
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_3 = 1152921505395343360 + ((X22 + 72) << 4);
            val_37 = mem[(1152921505395343360 + (X22 + 72) << 4) + 304];
            goto label_23;
            label_18:
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_5 = 1152921505395343360 + val_34;
            goto label_58;
            label_45:
            if((match.Equals(obj:  shouldAutoLaunch)) == false)
            {
                goto label_25;
            }
            
            if((X22 + 72 + 286) == 0)
            {
                goto label_29;
            }
            
            var val_34 = X22 + 72 + 176;
            var val_35 = 0;
            val_34 = val_34 + 8;
            label_28:
            if(((X22 + 72 + 176 + 8) + -8) == X22.丘一一丆业丂丘丒世())
            {
                goto label_27;
            }
            
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            if(val_35 < (X22 + 72 + 286))
            {
                goto label_28;
            }
            
            goto label_29;
            label_46:
            var val_36 = val_34;
            val_36 = val_36 + ((X22 + 72) << 4);
            val_39 = mem[(X22 + 72 + (X22 + 72) << 4) + 304];
            val_39 = (X22 + 72 + (X22 + 72) << 4) + 304;
            goto label_30;
            label_25:
            var val_37 = val_34;
            bool val_8 = shouldAutoLaunch;
            val_37 = val_37 + (X22 + 72);
            goto label_58;
            label_64:
            val_37 = mem[(((X22 + 72 + X22 + 72) + (((X23 + 176 + 8) + 16) + (shouldAutoLaunch & 1))) + 296) + 8];
            val_37 = (((X22 + 72 + X22 + 72) + (((X23 + 176 + 8) + 16) + (shouldAutoLaunch & 1))) + 296) + 8;
            label_23:
            bool val_10 = shouldAutoLaunch;
            goto label_58;
            label_22:
            var val_40 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(match, typeof(val_2), slot: 0);
            bool val_12 = shouldAutoLaunch;
            goto label_58;
            label_48:
            var val_39 = 1179403647;
            val_39 = val_39 + ((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(match, typeof(val_2), slot: 0) + 8);
            val_40 = val_40 + val_39;
            var val_13 = val_40 + 296;
            label_50:
            val_39 = mem[(((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(match, typeof(val_2), slot: 0) + (1179403647 + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(match, typeof(val_2), slot: 0) + 8)) + 296) + 8];
            val_39 = (((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(match, typeof(val_2), slot: 0) + (1179403647 + (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(match, typeof(val_2), slot: 0) + 8)) + 296) + 8;
            label_30:
            bool val_14 = shouldAutoLaunch;
            goto label_58;
            label_27:
            var val_41 = val_34;
            val_41 = val_41 + (X22 + 72);
            val_41 = val_34 + val_41;
            val_38 = val_41 + 296;
            label_29:
            bool val_15 = shouldAutoLaunch;
            goto label_58;
            label_65:
            var val_16 = X25 + 0;
            val_34 = mem[(X25 + 0) + 32 + 32];
            val_34 = (X25 + 0) + 32 + 32;
            if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_37;
            }
            
            if(((X25 + 0) + 32 + 32 + 8 + 74) != 2)
            {
                goto label_38;
            }
            
            if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
            {
                goto label_42;
            }
            
            if(val_34 != 0)
            {
                    if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_42;
            }
            
            }
            
            if(((X25 + 0) + 32 + 32 + 265) == 0)
            {
                goto label_42;
            }
            
            if(val_34 == 0)
            {
                goto label_56;
            }
            
            if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_58;
            }
            
            if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_45;
            }
            
            if((((X25 + 0) + 32 + 32 + 8.丘一一丆业丂丘丒世()) & 1) == 0)
            {
                goto label_46;
            }
            
            if(((X25 + 0) + 32 + 32 + 286) == 0)
            {
                goto label_50;
            }
            
            var val_42 = (X25 + 0) + 32 + 32 + 176;
            var val_43 = 0;
            val_42 = val_42 + 8;
            label_49:
            if((((X25 + 0) + 32 + 32 + 176 + 8) + -8) == ((X25 + 0) + 32 + 32 + 8 + 24))
            {
                goto label_48;
            }
            
            val_43 = val_43 + 1;
            val_42 = val_42 + 16;
            if(val_43 < ((X25 + 0) + 32 + 32 + 286))
            {
                goto label_49;
            }
            
            goto label_50;
            label_37:
            if(((X25 + 0) + 32 + 32 + 8 + 74) == 2)
            {
                goto label_56;
            }
            
            label_42:
            shouldAutoLaunch = shouldAutoLaunch;
            goto label_58;
            label_38:
            if(((X25 + 0) + 32 + 32 + 8 + 72) == 65535)
            {
                goto label_56;
            }
            
            if(val_34 != 0)
            {
                    if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_56;
            }
            
            }
            
            if(((X25 + 0) + 32 + 32 + 265) == 0)
            {
                goto label_56;
            }
            
            if(val_34 != 0)
            {
                    if((((X25 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_58;
            }
            
            }
            
            if((((X25 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_59;
            }
            
            if((((X25 + 0) + 32 + 32 + 8.丘一一丆业丂丘丒世()) & 1) == 0)
            {
                goto label_60;
            }
            
            var val_44 = 0;
            val_44 = val_44 + 1;
            goto label_64;
            label_56:
            bool val_19 = shouldAutoLaunch;
            label_58:
            val_45 = val_45 + 1;
            if(val_45 != (X25 + 24))
            {
                goto label_65;
            }
            
            return;
            label_4:
            if((X22 + 74) == 2)
            {
                goto label_70;
            }
            
            label_9:
            shouldAutoLaunch = shouldAutoLaunch;
            label_96:
            label_5:
            if((X22 + 72) == 65535)
            {
                goto label_70;
            }
            
            if(X23 != 0)
            {
                    if(((X23 + 265) & 1) != 0)
            {
                goto label_70;
            }
            
            }
            
            if((X23 + 265) == 0)
            {
                goto label_70;
            }
            
            if(X23 != 0)
            {
                    if(((X23 + 265) & 1) != 0)
            {
                    return;
            }
            
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_20 = X22.丘一一丆业丂丘丒世();
            if((X22 & 1) == 0)
            {
                goto label_73;
            }
            
            if((val_20 & 1) == 0)
            {
                goto label_74;
            }
            
            var val_46 = 0;
            val_46 = val_46 + 1;
            goto label_78;
            label_70:
            bool val_21 = shouldAutoLaunch;
            label_94:
            label_73:
            if((val_20 & 1) == 0)
            {
                goto label_79;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_22 = X22.丘一一丆业丂丘丒世();
            var val_47 = 0;
            val_47 = val_47 + 1;
            goto label_83;
            label_74:
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_23 = 1152921505395343360 + ((X22 + 72) << 4);
            val_42 = mem[(1152921505395343360 + (X22 + 72) << 4) + 304];
            goto label_84;
            label_79:
            GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch val_24 = 1152921505395343360 + (X22 + 72);
            goto label_85;
            label_12:
            if((val_1 & 1) == 0)
            {
                goto label_86;
            }
            
            if((X23 + 286) == 0)
            {
                goto label_90;
            }
            
            var val_48 = X23 + 176;
            var val_49 = 0;
            val_48 = val_48 + 8;
            label_89:
            if(((X23 + 176 + 8) + -8) == X22.丘一一丆业丂丘丒世())
            {
                goto label_88;
            }
            
            val_49 = val_49 + 1;
            val_48 = val_48 + 16;
            if(val_49 < (X23 + 286))
            {
                goto label_89;
            }
            
            goto label_90;
            label_13:
            var val_50 = X23;
            val_50 = val_50 + ((X22 + 72) << 4);
            val_44 = mem[(X23 + (X22 + 72) << 4) + 304];
            val_44 = (X23 + (X22 + 72) << 4) + 304;
            goto label_91;
            label_86:
            var val_51 = X23;
            val_51 = val_51 + (X22 + 72);
            goto label_92;
            label_78:
            val_42 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(match, typeof(X22 + 24), slot: 0) + 8];
            val_42 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(match, typeof(X22 + 24), slot: 0) + 8;
            label_84:
            bool val_27 = shouldAutoLaunch;
            goto label_94;
            label_83:
            label_85:
            bool val_29 = shouldAutoLaunch;
            goto label_94;
            label_15:
            var val_52 = val_31;
            val_52 = val_52 + (X22 + 72);
            val_53 = val_53 + val_52;
            val_35 = val_53 + 296;
            label_17:
            val_44 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0) + 8];
            val_44 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X23, typeof(X22 + 24), slot: 0) + 8;
            label_91:
            bool val_30 = shouldAutoLaunch;
            goto label_96;
            label_88:
            var val_54 = val_48;
            val_54 = val_54 + (X22 + 72);
            val_54 = X23 + val_54;
            val_43 = val_54 + 296;
            label_90:
            label_92:
            shouldAutoLaunch = shouldAutoLaunch;
            goto label_96;
        }
        public virtual System.IAsyncResult BeginInvoke(GooglePlayGames.BasicApi.Multiplayer.TurnBasedMatch match, bool shouldAutoLaunch, System.AsyncCallback callback, object object)
        {
            bool val_1 = shouldAutoLaunch;
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
        
        }
    
    }

}
