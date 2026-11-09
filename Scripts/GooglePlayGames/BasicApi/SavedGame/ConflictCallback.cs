using UnityEngine;

namespace GooglePlayGames.BasicApi.SavedGame
{
    public sealed class ConflictCallback : MulticastDelegate
    {
        // Methods
        public ConflictCallback(object object, IntPtr method)
        {
            mem[1152921541880498688] = object;
            mem[1152921541880498696] = method;
            mem[1152921541880498672] = method;
        }
        public virtual void Invoke(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData)
        {
            GooglePlayGames.BasicApi.SavedGame.ConflictCallback val_22;
            var val_23;
            var val_24;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_32;
            var val_33;
            var val_34;
            val_22 = this;
            if(X28 == 0)
            {
                goto label_0;
            }
            
            if((X28 + 24) == 0)
            {
                    return;
            }
            
            goto label_65;
            label_0:
            if((X25 & 1) == 0)
            {
                goto label_4;
            }
            
            if((X25 + 74) != 5)
            {
                goto label_5;
            }
            
            if((X25 + 72) == 65535)
            {
                goto label_9;
            }
            
            if(X26 != 0)
            {
                    if(((X26 + 265) & 1) != 0)
            {
                goto label_9;
            }
            
            }
            
            if((X26 + 265) == 0)
            {
                goto label_9;
            }
            
            if(X26 == 0)
            {
                goto label_70;
            }
            
            if(((X26 + 265) & 1) != 0)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = X25.丘一一丆业丂丘丒世();
            if((X25 & 1) == 0)
            {
                goto label_12;
            }
            
            if((val_1 & 1) == 0)
            {
                goto label_13;
            }
            
            var val_40 = X26;
            if((X26 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_18 = X26 + 176;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_16:
            if(((X26 + 176 + 8) + -8) == (X25 + 24))
            {
                goto label_15;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (X26 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_59:
            if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X26, typeof(X25 + 24), slot: 0)) & 1) == 0)
            {
                goto label_18;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = X25.丘一一丆业丂丘丒世();
            var val_20 = 0;
            val_20 = val_20 + 1;
            goto label_22;
            label_60:
            GooglePlayGames.BasicApi.SavedGame.IConflictResolver val_3 = 1152921505393958912 + ((X25 + 72) << 4);
            val_26 = mem[(1152921505393958912 + (X25 + 72) << 4) + 304];
            goto label_58;
            label_18:
            GooglePlayGames.BasicApi.SavedGame.IConflictResolver val_4 = 1152921505393958912 + (X25 + 72);
            goto label_58;
            label_45:
            val_27 = mem[X25 + 72];
            val_27 = X25 + 72;
            if((resolver & 1) == 0)
            {
                goto label_25;
            }
            
            if((X25 + 72 + 286) == 0)
            {
                goto label_58;
            }
            
            var val_21 = X25 + 72 + 176;
            var val_22 = 0;
            val_21 = val_21 + 8;
            label_28:
            if(((X25 + 72 + 176 + 8) + -8) == X25.丘一一丆业丂丘丒世())
            {
                goto label_27;
            }
            
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            if(val_22 < (X25 + 72 + 286))
            {
                goto label_28;
            }
            
            goto label_58;
            label_46:
            var val_23 = X25 + 72;
            val_23 = val_23 + ((X25 + 72) << 4);
            val_29 = mem[(X25 + 72 + (X25 + 72) << 4) + 304];
            val_29 = (X25 + 72 + (X25 + 72) << 4) + 304;
            goto label_30;
            label_25:
            var val_24 = X25 + 72;
            val_24 = val_24 + val_27;
            goto label_58;
            label_22:
            var val_27 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(resolver, typeof(val_2), slot: 0);
            goto label_58;
            label_48:
            var val_26 = 1179403647;
            val_26 = val_26 + originalData;
            val_27 = val_27 + val_26;
            label_50:
            label_30:
            var val_28 = val_27[296];
            goto label_58;
            label_27:
            var val_29 = val_21;
            val_29 = val_29 + val_27;
            val_29 = (X25 + 72) + val_29;
            val_28 = val_29 + 296;
            goto label_58;
            label_65:
            var val_8 = X28 + 0;
            val_23 = mem[(X28 + 0) + 32 + 32 + 8];
            val_23 = (X28 + 0) + 32 + 32 + 8;
            val_27 = mem[(X28 + 0) + 32 + 16];
            val_27 = (X28 + 0) + 32 + 16;
            if((val_23 & 1) == 0)
            {
                goto label_37;
            }
            
            if(((X28 + 0) + 32 + 32 + 8 + 74) != 5)
            {
                goto label_38;
            }
            
            if(((X28 + 0) + 32 + 32 + 8 + 72) == 65535)
            {
                goto label_58;
            }
            
            if(((X28 + 0) + 32 + 32) != 0)
            {
                    if((((X28 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_58;
            }
            
            }
            
            if(mem[1152921541880733560] == 0)
            {
                goto label_58;
            }
            
            if(((X28 + 0) + 32 + 32) == 0)
            {
                goto label_56;
            }
            
            if((((X28 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_58;
            }
            
            if((val_23 & 1) == 0)
            {
                goto label_45;
            }
            
            if((val_23.丘一一丆业丂丘丒世() & 1) == 0)
            {
                goto label_46;
            }
            
            if(((X28 + 0) + 32 + 32 + 286) == 0)
            {
                goto label_50;
            }
            
            var val_30 = (X28 + 0) + 32 + 32 + 176;
            var val_31 = 0;
            val_30 = val_30 + 8;
            label_49:
            if((((X28 + 0) + 32 + 32 + 176 + 8) + -8) == ((X28 + 0) + 32 + 32 + 8 + 24))
            {
                goto label_48;
            }
            
            val_31 = val_31 + 1;
            val_30 = val_30 + 16;
            if(val_31 < ((X28 + 0) + 32 + 32 + 286))
            {
                goto label_49;
            }
            
            goto label_50;
            label_37:
            if(((X28 + 0) + 32 + 32 + 8 + 74) == 5)
            {
                goto label_56;
            }
            
            goto label_58;
            label_38:
            if(((X28 + 0) + 32 + 32 + 8 + 72) == 65535)
            {
                goto label_56;
            }
            
            if(((X28 + 0) + 32 + 32) != 0)
            {
                    if((((X28 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_56;
            }
            
            }
            
            if(mem[1152921541880733560] == 0)
            {
                goto label_56;
            }
            
            if(((X28 + 0) + 32 + 32) != 0)
            {
                    if((((X28 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_58;
            }
            
            }
            
            if((val_23 & 1) == 0)
            {
                goto label_59;
            }
            
            if((val_23.丘一一丆业丂丘丒世() & 1) == 0)
            {
                goto label_60;
            }
            
            var val_32 = 0;
            val_32 = val_32 + 1;
            goto label_58;
            label_56:
            label_58:
            val_22 = 0 + 1;
            if(val_22 != (X28 + 24))
            {
                goto label_65;
            }
            
            return;
            label_4:
            if((X25 + 74) == 5)
            {
                goto label_70;
            }
            
            label_9:
            label_96:
            label_5:
            if((X25 + 72) == 65535)
            {
                goto label_70;
            }
            
            if(X26 != 0)
            {
                    if(((X26 + 265) & 1) != 0)
            {
                goto label_70;
            }
            
            }
            
            if((X26 + 265) == 0)
            {
                goto label_70;
            }
            
            if(X26 != 0)
            {
                    if(((X26 + 265) & 1) != 0)
            {
                    return;
            }
            
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_11 = X25.丘一一丆业丂丘丒世();
            if((X25 & 1) == 0)
            {
                goto label_73;
            }
            
            if((val_11 & 1) == 0)
            {
                goto label_74;
            }
            
            var val_33 = 0;
            val_33 = val_33 + 1;
            goto label_78;
            label_70:
            label_94:
            label_73:
            if((val_11 & 1) == 0)
            {
                goto label_79;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_12 = X25.丘一一丆业丂丘丒世();
            var val_34 = 0;
            val_34 = val_34 + 1;
            goto label_94;
            label_74:
            GooglePlayGames.BasicApi.SavedGame.IConflictResolver val_13 = 1152921505393958912 + ((X25 + 72) << 4);
            val_32 = mem[(1152921505393958912 + (X25 + 72) << 4) + 304];
            goto label_94;
            label_79:
            GooglePlayGames.BasicApi.SavedGame.IConflictResolver val_14 = 1152921505393958912 + (X25 + 72);
            goto label_94;
            label_12:
            if((val_1 & 1) == 0)
            {
                goto label_86;
            }
            
            if((X26 + 286) == 0)
            {
                goto label_96;
            }
            
            var val_35 = X26 + 176;
            var val_36 = 0;
            val_35 = val_35 + 8;
            label_89:
            if(((X26 + 176 + 8) + -8) == X25.丘一一丆业丂丘丒世())
            {
                goto label_88;
            }
            
            val_36 = val_36 + 1;
            val_35 = val_35 + 16;
            if(val_36 < (X26 + 286))
            {
                goto label_89;
            }
            
            goto label_96;
            label_13:
            var val_37 = X26;
            val_37 = val_37 + ((X25 + 72) << 4);
            val_34 = mem[(X26 + (X25 + 72) << 4) + 304];
            val_34 = (X26 + (X25 + 72) << 4) + 304;
            goto label_96;
            label_86:
            var val_38 = X26;
            val_38 = val_38 + (X25 + 72);
            goto label_96;
            label_78:
            val_32 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(resolver, typeof(X25 + 24), slot: 0) + 8];
            val_32 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(resolver, typeof(X25 + 24), slot: 0) + 8;
            goto label_94;
            label_15:
            var val_39 = val_18;
            val_39 = val_39 + (X25 + 72);
            val_40 = val_40 + val_39;
            val_24 = val_40 + 296;
            label_17:
            val_34 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X26, typeof(X25 + 24), slot: 0) + 8];
            val_34 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X26, typeof(X25 + 24), slot: 0) + 8;
            goto label_96;
            label_88:
            var val_41 = val_35;
            val_41 = val_41 + (X25 + 72);
            val_41 = X26 + val_41;
            val_33 = val_41 + 296;
            goto label_96;
        }
        public virtual System.IAsyncResult BeginInvoke(GooglePlayGames.BasicApi.SavedGame.IConflictResolver resolver, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata original, byte[] originalData, GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata unmerged, byte[] unmergedData, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        public virtual void EndInvoke(System.IAsyncResult result)
        {
            mem2[0] = (127 != 0) ? 1 : 0;
            mem2[0] = 0;
            mem2[0] = (3 != 0) ? 1 : 0;
            mem2[0] = 28563616;
            mem2[0] = 64;
            mem2[0] = 135970152;
        }
    
    }

}
