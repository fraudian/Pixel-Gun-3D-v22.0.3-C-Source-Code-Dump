using UnityEngine;

namespace PGCompany
{
    internal static class 上丕丐万下丙丆丄一
    {
        // Methods
        internal static System.Collections.Generic.List<Rilisoft.七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟> 丈丐丘丄丄三世且丟(System.Collections.Generic.List<object> 丈丕三丆丟且丆一上)
        {
            var val_4;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            object val_31;
            var val_32;
            var val_36;
            var val_37;
            var val_38;
            System.Collections.Generic.List<东丛丏且丆丑丙丅丟> val_1 = null;
            val_28 = val_1;
            val_1 = new System.Collections.Generic.List<东丛丏且丆丑丙丅丟>();
            List.Enumerator<T> val_2 = 丈丕三丆丟且丆一上.GetEnumerator();
            val_29 = 1152921516789171648;
            val_30 = 0;
            goto label_43;
            label_62:
            val_31 = val_4.丐丏七丌丕丗业且上();
            if(val_31 == null)
            {
                goto label_43;
            }
            
            new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟() = new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟();
            .下丄丈不与世丐业专 = 0;
            if((val_31.ContainsKey(key:  "rarity")) == false)
            {
                goto label_7;
            }
            
            .丗丕丂丄丝丄且丄且 = false;
            System.Nullable<T> val_9 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<ItemRarity>(下业七不丑丂丏丟东:  val_31.Item["rarity"], 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            val_27 = ;
            if(((-277105704) & 1) != 0)
            {
                goto label_11;
            }
            
            val_28 = val_28;
            val_29 = val_29;
            val_30 = val_30;
            object[] val_10 = new object[1];
            val_31 = val_31.Item["rarity"];
            val_10[0] = val_31;
            UnityEngine.Debug.LogErrorFormat(format:  "fail to parce offer packs config: unknown rarity: \'{0}\'", args:  val_10);
            goto label_43;
            label_7:
            if((val_31.ContainsKey(key:  "unique")) == false)
            {
                goto label_61;
            }
            
            .丗丕丂丄丝丄且丄且 = true;
            System.Collections.Generic.List<System.String> val_13 = new System.Collections.Generic.List<System.String>();
            .丅三丙专丆丆丈丗且 = null;
            object val_14 = val_31.Item["unique"];
            if(val_14 == null)
            {
                goto label_23;
            }
            
            List.Enumerator<T> val_15 = val_14.GetEnumerator();
            label_34:
            val_32 = -277105808;
            if(((-277105728) & 1) == 0)
            {
                goto label_24;
            }
            
            string val_16 = val_4.丐丏七丌丕丗业且上();
            if(val_16 != null)
            {
                    var val_17 = (null == null) ? (val_16) : 0;
            }
            
            if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  0)) == true) || (((七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟)[1152921555869405248].丅三丙专丆丆丈丗且.Contains(item:  0)) == true))
            {
                goto label_34;
            }
            
            (七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟)[1152921555869405248].丅三丙专丆丆丈丗且.Add(item:  0);
            goto label_34;
            label_11:
            val_28 = val_28;
            .且丐丟专丛丗丏上丙 = val_9.HasValue;
            val_29 = val_29;
            val_30 = -277105808;
            label_61:
            if((val_31.ContainsKey(key:  "count")) != false)
            {
                    val_31 = val_31.Item["count"];
                bool val_23 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_31, 丙业与丙丗丝不丈东: out  (七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟)[1152921555869405248].丒专下与丑丁丆丟业);
            }
            else
            {
                    .丒专下与丑丁丆丟业 = 1;
            }
            
            val_1.Add(item:  new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟());
            goto label_43;
            label_24:
            var val_28 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_28 == 1) || (364 != 364))
            {
                goto label_51;
            }
            
            var val_27 = 0;
            val_27 = val_27 ^ 0;
            val_28 = val_28 + val_27;
            goto label_61;
            label_51:
            label_23:
            object val_24 = val_31.Item["unique"];
            if(val_24 != null)
            {
                    var val_25 = (null == null) ? (val_24) : 0;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  0)) == true)
            {
                goto label_61;
            }
            
            (七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟)[1152921555869405248].丅三丙专丆丆丈丗且.Add(item:  0);
            goto label_61;
            label_43:
            if(((-277105696) & 1) != 0)
            {
                goto label_62;
            }
            
            val_36 = 0;
            val_37 = 0;
            val_38 = val_30 + 1;
            mem2[0] = 456;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_38 != 1)
            {
                    if( == 0)
            {
                    return (System.Collections.Generic.List<东丛丏且丆丑丙丅丟>)val_28;
            }
            
                if((1152921555869348720 + ((val_30 + 1)) << 2) == 456)
            {
                    return (System.Collections.Generic.List<东丛丏且丆丑丙丅丟>)val_28;
            }
            
                return (System.Collections.Generic.List<东丛丏且丆丑丙丅丟>)val_28;
            }
            
            if( != 0)
            {
                    return (System.Collections.Generic.List<东丛丏且丆丑丙丅丟>)val_28;
            }
            
            return (System.Collections.Generic.List<东丛丏且丆丑丙丅丟>)val_28;
        }
        internal static System.Collections.Generic.List<Rilisoft.七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟> 丗丁上专丟丑丙丒丕(System.Collections.Generic.List<object> 与业不下丐一丕丒七)
        {
            var val_4;
            System.Collections.Generic.List<东丛丏且丆丑丙丅丟> val_1 = new System.Collections.Generic.List<东丛丏且丆丑丙丅丟>();
            List.Enumerator<T> val_2 = 与业不下丐一丕丒七.GetEnumerator();
            label_9:
            if(((-276911760) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if((val_5 == null) || (null != null))
            {
                goto label_9;
            }
            
            new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟() = new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟();
            System.Collections.Generic.List<System.String> val_7 = new System.Collections.Generic.List<System.String>();
            null.Add(item:  (null == null) ? (val_5) : 0);
            if(new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟() != null)
            {
                    .丅三丙专丆丆丈丗且 = null;
            }
            else
            {
                    mem[32] = null;
            }
            
            .丒专下与丑丁丆丟业 = 1;
            val_1.Add(item:  new 七丈业与与不七丈丟.世丕三丙七丆丁丂丒.东丛丏且丆丑丙丅丟());
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
    
    }

}
