using UnityEngine;

namespace BestHTTP
{
    public sealed class OnBeforeRedirectionDelegate : MulticastDelegate
    {
        // Methods
        public OnBeforeRedirectionDelegate(object object, IntPtr method)
        {
            mem[1152921553628315792] = object;
            mem[1152921553628315800] = method;
            mem[1152921553628315776] = method;
        }
        public virtual bool Invoke(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response, System.Uri redirectUri)
        {
            var val_23;
            var val_24;
            long val_26;
            var val_27;
            var val_28;
            var val_29;
            long val_32;
            var val_33;
            var val_34;
            if(X26 == 0)
            {
                goto label_0;
            }
            
            if((X26 + 24) == 0)
            {
                goto label_1;
            }
            
            val_23 = 0;
            var val_34 = 0;
            goto label_65;
            label_0:
            if((X23 & 1) == 0)
            {
                goto label_4;
            }
            
            if((X23 + 74) != 3)
            {
                goto label_5;
            }
            
            if((X23 + 72) == 65535)
            {
                goto label_9;
            }
            
            if(X24 != 0)
            {
                    if(((X24 + 265) & 1) != 0)
            {
                goto label_9;
            }
            
            }
            
            if((X24 + 265) == 0)
            {
                goto label_9;
            }
            
            if(X24 == 0)
            {
                    return (bool)val_23 & 1;
            }
            
            if(((X24 + 265) & 1) != 0)
            {
                    return (bool)val_23 & 1;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = X23.丘一一丆业丂丘丒世();
            if((X23 & 1) == 0)
            {
                goto label_12;
            }
            
            if((val_1 & 1) == 0)
            {
                goto label_13;
            }
            
            var val_42 = X24;
            if((X24 + 286) == 0)
            {
                goto label_17;
            }
            
            var val_20 = X24 + 176;
            var val_21 = 0;
            val_20 = val_20 + 8;
            label_16:
            if(((X24 + 176 + 8) + -8) == (X23 + 24))
            {
                goto label_15;
            }
            
            val_21 = val_21 + 1;
            val_20 = val_20 + 16;
            if(val_21 < (X24 + 286))
            {
                goto label_16;
            }
            
            goto label_17;
            label_59:
            if((((VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X24, typeof(X23 + 24), slot: 0)) & 1) == 0)
            {
                goto label_18;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_2 = X23.丘一一丆业丂丘丒世();
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_22;
            label_60:
            BestHTTP.HTTPRequest val_3 = 1152921505554128896 + ((X23 + 72) << 4);
            val_26 = mem[(1152921505554128896 + (X23 + 72) << 4) + 304];
            val_26 = (1152921505554128896 + (X23 + 72) << 4).<Uploaded>k__BackingField;
            goto label_23;
            label_18:
            val_27 = originalRequest;
            BestHTTP.HTTPRequest val_4 = 1152921505554128896 + (X23 + 72);
            goto label_52;
            label_45:
            if((val_27 & 1) == 0)
            {
                goto label_25;
            }
            
            if((X23 + 72 + 286) == 0)
            {
                goto label_29;
            }
            
            var val_23 = X23 + 72 + 176;
            var val_24 = 0;
            val_23 = val_23 + 8;
            label_28:
            if(((X23 + 72 + 176 + 8) + -8) == X23.丘一一丆业丂丘丒世())
            {
                goto label_27;
            }
            
            val_24 = val_24 + 1;
            val_23 = val_23 + 16;
            if(val_24 < (X23 + 72 + 286))
            {
                goto label_28;
            }
            
            goto label_29;
            label_46:
            var val_25 = X23 + 72;
            val_25 = val_25 + ((X23 + 72) << 4);
            val_29 = mem[(X23 + 72 + (X23 + 72) << 4) + 304];
            val_29 = (X23 + 72 + (X23 + 72) << 4) + 304;
            goto label_30;
            label_25:
            var val_26 = X23 + 72;
            val_27 = X23 + 72;
            val_26 = val_26 + (X23 + 72);
            goto label_52;
            label_64:
            label_23:
            val_27 = originalRequest;
            goto label_52;
            label_22:
            var val_29 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(originalRequest, typeof(val_2), slot: 0);
            val_27 = originalRequest;
            goto label_52;
            label_48:
            var val_28 = 1179403647;
            val_28 = val_28 + redirectUri;
            val_29 = val_29 + val_28;
            System.Uri val_8 = val_29 + 296;
            label_50:
            label_30:
            val_27 = X23 + 72;
            goto label_52;
            label_27:
            var val_30 = val_23;
            val_30 = val_30 + (X23 + 72);
            val_30 = (X23 + 72) + val_30;
            val_28 = val_30 + 296;
            label_29:
            val_27 = X23 + 72;
            goto label_52;
            label_65:
            var val_9 = X26 + 0;
            if((((X26 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_37;
            }
            
            if(((X26 + 0) + 32 + 32 + 8 + 74) != 3)
            {
                goto label_38;
            }
            
            if(((X26 + 0) + 32 + 32 + 8 + 72) == 65535)
            {
                goto label_42;
            }
            
            if(((X26 + 0) + 32 + 32) != 0)
            {
                    if((((X26 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_42;
            }
            
            }
            
            if(mem[1152921553628476936] == 0)
            {
                goto label_42;
            }
            
            if(((X26 + 0) + 32 + 32) == 0)
            {
                goto label_56;
            }
            
            if((((X26 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_58;
            }
            
            if((((X26 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_45;
            }
            
            if((((X26 + 0) + 32 + 32 + 8.丘一一丆业丂丘丒世()) & 1) == 0)
            {
                goto label_46;
            }
            
            if(((X26 + 0) + 32 + 32 + 286) == 0)
            {
                goto label_50;
            }
            
            var val_31 = (X26 + 0) + 32 + 32 + 176;
            var val_32 = 0;
            val_31 = val_31 + 8;
            label_49:
            if((((X26 + 0) + 32 + 32 + 176 + 8) + -8) == ((X26 + 0) + 32 + 32 + 8 + 24))
            {
                goto label_48;
            }
            
            val_32 = val_32 + 1;
            val_31 = val_31 + 16;
            if(val_32 < ((X26 + 0) + 32 + 32 + 286))
            {
                goto label_49;
            }
            
            goto label_50;
            label_37:
            if(((X26 + 0) + 32 + 32 + 8 + 74) == 3)
            {
                goto label_56;
            }
            
            label_42:
            val_27 = (X26 + 0) + 32 + 32;
            goto label_52;
            label_38:
            if(((X26 + 0) + 32 + 32 + 8 + 72) == 65535)
            {
                goto label_56;
            }
            
            if(((X26 + 0) + 32 + 32) != 0)
            {
                    if((((X26 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_56;
            }
            
            }
            
            if(mem[1152921553628476936] == 0)
            {
                goto label_56;
            }
            
            if(((X26 + 0) + 32 + 32) != 0)
            {
                    if((((X26 + 0) + 32 + 32 + 265) & 1) != 0)
            {
                goto label_58;
            }
            
            }
            
            if((((X26 + 0) + 32 + 32 + 8) & 1) == 0)
            {
                goto label_59;
            }
            
            if((((X26 + 0) + 32 + 32 + 8.丘一一丆业丂丘丒世()) & 1) == 0)
            {
                goto label_60;
            }
            
            var val_33 = 0;
            val_33 = val_33 + 1;
            goto label_64;
            label_56:
            val_27 = originalRequest;
            label_52:
            val_23 = val_27 & 1;
            label_58:
            val_34 = val_34 + 1;
            if(val_34 != (X26 + 24))
            {
                goto label_65;
            }
            
            return (bool)val_23 & 1;
            label_1:
            val_23 = 0;
            return (bool)val_23 & 1;
            label_4:
            if((X23 + 74) == 3)
            {
                    return (bool)val_23 & 1;
            }
            
            label_9:
            label_98:
            label_5:
            if((X23 + 72) == 65535)
            {
                    return (bool)val_23 & 1;
            }
            
            if(X24 != 0)
            {
                    if(((X24 + 265) & 1) != 0)
            {
                    return (bool)val_23 & 1;
            }
            
            }
            
            if((X24 + 265) == 0)
            {
                    return (bool)val_23 & 1;
            }
            
            if(X24 != 0)
            {
                    if(((X24 + 265) & 1) != 0)
            {
                    return (bool)val_23 & 1;
            }
            
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_13 = X23.丘一一丆业丂丘丒世();
            if((X23 & 1) == 0)
            {
                goto label_74;
            }
            
            if((val_13 & 1) == 0)
            {
                goto label_75;
            }
            
            var val_35 = 0;
            val_35 = val_35 + 1;
            goto label_79;
            label_74:
            if((val_13 & 1) == 0)
            {
                goto label_81;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_14 = X23.丘一一丆业丂丘丒世();
            var val_36 = 0;
            val_36 = val_36 + 1;
            return (bool)val_23 & 1;
            label_75:
            BestHTTP.HTTPRequest val_15 = 1152921505554128896 + ((X23 + 72) << 4);
            val_32 = mem[(1152921505554128896 + (X23 + 72) << 4) + 304];
            val_32 = (1152921505554128896 + (X23 + 72) << 4).<Uploaded>k__BackingField;
            return (bool)val_23 & 1;
            label_81:
            BestHTTP.HTTPRequest val_16 = 1152921505554128896 + (X23 + 72);
            return (bool)val_23 & 1;
            label_12:
            if((val_1 & 1) == 0)
            {
                goto label_88;
            }
            
            if((X24 + 286) == 0)
            {
                goto label_98;
            }
            
            var val_37 = X24 + 176;
            var val_38 = 0;
            val_37 = val_37 + 8;
            label_91:
            if(((X24 + 176 + 8) + -8) == X23.丘一一丆业丂丘丒世())
            {
                goto label_90;
            }
            
            val_38 = val_38 + 1;
            val_37 = val_37 + 16;
            if(val_38 < (X24 + 286))
            {
                goto label_91;
            }
            
            goto label_98;
            label_13:
            var val_39 = X24;
            val_39 = val_39 + ((X23 + 72) << 4);
            val_34 = mem[(X24 + (X23 + 72) << 4) + 304];
            val_34 = (X24 + (X23 + 72) << 4) + 304;
            goto label_98;
            label_88:
            var val_40 = X24;
            val_40 = val_40 + (X23 + 72);
            goto label_98;
            label_79:
            val_32 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(originalRequest, typeof(X23 + 24), slot: 0) + 8];
            val_32 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(originalRequest, typeof(X23 + 24), slot: 0) + 8;
            return (bool)val_23 & 1;
            label_15:
            var val_41 = val_20;
            val_41 = val_41 + (X23 + 72);
            val_42 = val_42 + val_41;
            val_24 = val_42 + 296;
            label_17:
            val_34 = mem[(VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X24, typeof(X23 + 24), slot: 0) + 8];
            val_34 = (VirtualInvokeData*)GetInterfaceInvokeDataFromVTable(X24, typeof(X23 + 24), slot: 0) + 8;
            goto label_98;
            label_90:
            var val_43 = val_37;
            val_43 = val_43 + (X23 + 72);
            val_43 = X24 + val_43;
            val_33 = val_43 + 296;
            goto label_98;
        }
        public virtual System.IAsyncResult BeginInvoke(BestHTTP.HTTPRequest originalRequest, BestHTTP.HTTPResponse response, System.Uri redirectUri, System.AsyncCallback callback, object object)
        {
            return (System.IAsyncResult)this;
        }
        public virtual bool EndInvoke(System.IAsyncResult result)
        {
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  result);
            return (bool)null;
        }
    
    }

}
