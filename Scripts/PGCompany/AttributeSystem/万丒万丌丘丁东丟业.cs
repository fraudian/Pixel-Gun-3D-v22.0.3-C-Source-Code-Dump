using UnityEngine;

namespace PGCompany.AttributeSystem
{
    internal static class 万丒万丌丘丁东丟业
    {
        // Methods
        internal static System.Nullable<PGCompany.AttributeSystem.丛丅丘东丗丒万丝丝> 丁丒不世丐丂丄万上(int 丂世丒下丁三丄东丆)
        {
            return PGCompany.AttributeSystem.万丒万丌丘丁东丟业.丂上上上且不丄丕丛(丂世丒下丁三丄东丆:  丂世丒下丁三丄东丆, 丙业与丙丗丝不丈东:  PGCompany.AttributeSystem.丒三丝丛丘丛丆丌丂.丂三一丒丄与丁不丄<System.Int32>(丆下丕丅丕一丝丁丛:  丂世丒下丁三丄东丆));
        }
        internal static System.Nullable<PGCompany.AttributeSystem.丛丅丘东丗丒万丝丝> 丂上上上且不丄丕丛(int 丂世丒下丁三丄东丆, int 丙业与丙丗丝不丈东 = -1)
        {
            System.Collections.Generic.List<PGCompany.Attributes.丁世一丗丁丘三丗丘> val_9;
            万丒万丌丘丁东丟业.丝丂下丂丐丄丁丑丄 val_1 = new 万丒万丌丘丁东丟业.丝丂下丂丐丄丁丑丄();
            if(val_1 != null)
            {
                    .丂世丒下丁三丄东丆 = 丂世丒下丁三丄东丆;
            }
            else
            {
                    mem[16] = 丂世丒下丁三丄东丆;
            }
            
            .丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
            PGCompany.Attributes.丙下且上七丏丄丙七 val_2 = PGCompany.业专丐丐丘丌丕世丅<PGCompany.Attributes.丙下且上七丏丄丙七>.丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  130);
            val_9 = val_2;
            if(((val_9 == null) || (val_2.Attributes == null)) || ((System.Linq.Enumerable.FirstOrDefault<PGCompany.Attributes.丗丑丌专丑丈世下与>(source:  val_2.Attributes, predicate:  new System.Func<PGCompany.Attributes.丗丑丌专丑丈世下与, System.Boolean>(object:  val_1, method:  System.Boolean 万丒万丌丘丁东丟业.丝丂下丂丐丄丁丑丄::丙丄丞专丁且丆七丟(PGCompany.Attributes.丗丑丌专丑丈世下与 丆丛丑世下一丐且丕)))) == null))
            {
                goto label_5;
            }
            
            if(((万丒万丌丘丁东丟业.丝丂下丂丐丄丁丑丄)[1152921560572428560].丙业与丙丗丝不丈东 & 2147483648) != 0)
            {
                goto label_6;
            }
            
            val_9 = val_2.AttributeImages;
            var val_7 = ((System.Linq.Enumerable.FirstOrDefault<PGCompany.Attributes.丁世一丗丁丘三丗丘>(source:  val_9, predicate:  new System.Func<PGCompany.Attributes.丁世一丗丁丘三丗丘, System.Boolean>(object:  val_1, method:  System.Boolean 万丒万丌丘丁东丟业.丝丂下丂丐丄丁丑丄::丑不世一专丒与丁世(PGCompany.Attributes.丁世一丗丁丘三丗丘 七丞丙丒三丕且丌丟)))) == 0) ? val_4.ImageIcon : val_6.ImageIcon;
            goto label_7;
            label_5:
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
            return (System.Nullable<PGCompany.AttributeSystem.丛丅丘东丗丒万丝丝>)val_2;
            label_6:
            label_7:
            mem2[0] = 0;
            mem2[0] = 0;
            mem2[0] = 0;
        }
        internal static bool 丒丁丗与丏上专丞丘(PGCompany.Attributes.丝万专丆丂丘丌世丟 下丝三业上业专丐丂)
        {
            if(下丝三业上业专丐丂 == null)
            {
                    return true;
            }
            
            if(下丝三业上业专丐丂.Type == 0)
            {
                    return true;
            }
            
            return PGCompany.AttributeSystem.世丆丆丁与七不丁丞.丂丆世世丕丅丕丅上<System.Int32>(三丏丅下专丛七丒丂:  下丝三业上业专丐丂.Type, 一业丑七东世丛丒丕:  PGCompany.AttributeSystem.丟丙丂丗丈丂丆丁丒<System.Int32>.丄丞丛业且丛专丁上(丆下丕丅丕一丝丁丛:  下丝三业上业专丐丂.AttributeIndex, 丙业与丙丗丝不丈东:  下丝三业上业专丐丂.Value));
        }
        internal static bool 丒丁丗与丏上专丞丘(System.Collections.Generic.List<PGCompany.Attributes.丝万专丆丂丘丌世丟> 丕下丂丒丌丟东丟一)
        {
            var val_5;
            if((丕下丂丒丌丟东丟一 == null) || ((System.Linq.Enumerable.Any<PGCompany.Attributes.丝万专丆丂丘丌世丟>(source:  丕下丂丒丌丟东丟一)) == false))
            {
                goto label_9;
            }
            
            List.Enumerator<T> val_2 = 丕下丂丒丌丟东丟一.GetEnumerator();
            label_4:
            if((131272696 & 1) == 0)
            {
                goto label_3;
            }
            
            if((PGCompany.AttributeSystem.万丒万丌丘丁东丟业.丒丁丗与丏上专丞丘(下丝三业上业专丐丂:  0.丐丏七丌丕丗业且上())) == true)
            {
                goto label_4;
            }
            
            val_5 = 0;
            goto label_5;
            label_3:
            val_5 = 1;
            label_5:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (bool)val_5;
            label_9:
            val_5 = 1;
            return (bool)val_5;
        }
        internal static string 丙业不丝丗丌丗世下(PGCompany.Attributes.丝万专丆丂丘丌世丟 万且万且丑丗且丌丆)
        {
            var val_2;
            if(万且万且丑丗且丌丆 != null)
            {
                    string val_1 = System.String.Format(format:  "{0}:{1}:{2}", arg0:  万且万且丑丗且丌丆.AttributeIndex, arg1:  万且万且丑丗且丌丆.Type, arg2:  万且万且丑丗且丌丆.Value);
                return (string)val_2;
            }
            
            val_2 = 0;
            return (string)val_2;
        }
        internal static bool 丙丛丈下丘丝丘万上(string 丞丕丒专一下丙业上, ref System.Collections.Generic.List<PGCompany.Attributes.丝万专丆丂丘丌世丟> 专丂丕丗丗东世丞下)
        {
            System.Char[] val_5;
            var val_6;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丞丕丒专一下丙业上)) != false)
            {
                    return false;
            }
            
            char[] val_2 = new char[1];
            val_5 = val_2;
            val_5[0] = ',';
            val_6 = 0;
            goto label_7;
            label_12:
            System.ValueTuple<PGCompany.Attributes.丝万专丆丂丘丌世丟, System.Boolean> val_4 = PGCompany.AttributeSystem.万丒万丌丘丁东丟业.丞丄万七万丒丅丛上(丞丕丒专一下丙业上:  丞丕丒专一下丙业上.Split(separator:  val_2)[0]);
            val_5 = val_4.Item2;
            if((0 & 255) != 0)
            {
                    专丂丕丗丗东世丞下.Add(item:  val_5);
            }
            
            val_6 = 1;
            label_7:
            if(val_6 < val_3.Length)
            {
                goto label_12;
            }
            
            return System.Linq.Enumerable.Any<PGCompany.Attributes.丝万专丆丂丘丌世丟>(source:  专丂丕丗丗东世丞下);
        }
        internal static System.ValueTuple<PGCompany.Attributes.丝万专丆丂丘丌世丟, bool> 丞丄万七万丒丅丛上(string 丞丕丒专一下丙业上)
        {
            var val_15;
            var val_16;
            PGCompany.Common.丗七业丏东且丟丕一 val_17;
            var val_18;
            int val_4 = 0;
            char[] val_2 = new char[1];
            val_2[0] = ':';
            val_15 = 丞丕丒专一下丙业上.Trim().Split(separator:  val_2);
            if(val_3.Length <= 2)
            {
                goto label_9;
            }
            
            val_16 = 1152921505284374528;
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_15[0], 丙业与丙丗丝不丈东: out  val_4)) == false)
            {
                goto label_9;
            }
            
            System.Nullable<T> val_6 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<PGCompany.Common.丗七业丏东且丟丕一>(下业七不丑丂丏丟东:  val_15[1], 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  false);
            bool val_7 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_15[2], 丙业与丙丗丝不丈东: out  val_4);
            PGCompany.Attributes.丝万专丆丂丘丌世丟 val_8 = null;
            val_15 = val_8;
            val_8 = new PGCompany.Attributes.丝万专丆丂丘丌世丟();
            Rilisoft.丝丑丂丛万丐丈丘且 val_9 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
            .AttributeIndex = val_9;
            mem[1152921560573369416] = val_9.上万三丆专丏丒丗业;
            val_16 = 1152921560573249888;
            if((131842032 & 1) == 0)
            {
                goto label_15;
            }
            
            int val_10 = val_6.HasValue.丙东专丂世丈丏丁丂();
            goto label_16;
            label_9:
            val_18 = 0;
            return 0;
            label_15:
            val_17 = 0;
            label_16:
            .Type = val_17;
            Rilisoft.丝丑丂丛万丐丈丘且 val_11 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
            .Value = val_11;
            mem[1152921560573369440] = val_11.上万三丆专丏丒丗业;
            if(0 >= 1)
            {
                    var val_14 = ((val_6.HasValue.丙东专丂世丈丏丁丂() > 0) ? 1 : 0) & 1152921560573263856;
            }
            
            val_18 = val_15;
            return 0;
        }
        internal static string 丙业不丝丗丌丗世下(PGCompany.Attributes.丒丏丆且丕三丘丘丐 万且万且丑丗且丌丆)
        {
            PGCompany.Attributes.丒丏丆且丕三丘丘丐 val_3 = 万且万且丑丗且丌丆;
            if(val_3 == null)
            {
                    return (string)val_3;
            }
            
            val_3 = System.String.Format(format:  "{0}:{1}:{2}", arg0:  万且万且丑丗且丌丆.Type, arg1:  万且万且丑丗且丌丆.AttributeIndex, arg2:  万且万且丑丗且丌丆.Value);
            if(万且万且丑丗且丌丆.Trigger == 0)
            {
                    return (string)val_3;
            }
            
            val_3 = System.String.Format(format:  "{0}:{1}", arg0:  val_3, arg1:  万且万且丑丗且丌丆.Trigger);
            return (string)val_3;
        }
        internal static System.ValueTuple<PGCompany.Attributes.丒丏丆且丕三丘丘丐, bool> 丗丘万业丆丐丞业丄(string 丞丕丒专一下丙业上)
        {
            bool val_16;
            PGCompany.Common.专一与丁丒丝丞丂三 val_17;
            var val_18;
            var val_19;
            int val_5 = 0;
            val_16 = 丞丕丒专一下丙业上.Trim();
            char[] val_2 = new char[1];
            val_2[0] = ':';
            System.String[] val_3 = val_16.Split(separator:  val_2);
            if(val_3.Length <= 2)
            {
                goto label_10;
            }
            
            System.Nullable<T> val_4 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<PGCompany.Common.专一与丁丒丝丞丂三>(下业七不丑丂丏丟东:  val_3[0], 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  false);
            val_16 = val_4.HasValue;
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_3[1], 丙业与丙丗丝不丈东: out  val_5)) == false)
            {
                goto label_10;
            }
            
            bool val_7 = 丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_3[2], 丙业与丙丗丝不丈东: out  val_5);
            Rilisoft.丝丑丂丛万丐丈丘且 val_9 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
            .AttributeIndex = val_9;
            mem[1152921560573810536] = val_9.上万三丆专丏丒丗业;
            if((132283136 & 1) == 0)
            {
                goto label_15;
            }
            
            int val_10 = val_16.丙东专丂世丈丏丁丂();
            goto label_16;
            label_10:
            val_18 = 0;
            return 0;
            label_15:
            val_17 = 0;
            label_16:
            .Type = val_17;
            Rilisoft.丝丑丂丛万丐丈丘且 val_11 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  0);
            .Value = val_11;
            mem[1152921560573810560] = val_11.上万三丆专丏丒丗业;
            if(val_3.Length >= 4)
            {
                    System.Nullable<T> val_12 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<PGCompany.丏业且丛丌一专丝世>(下业七不丑丂丏丟东:  val_3[3], 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  false);
                val_19 = 0;
                .Trigger = val_12.HasValue;
            }
            
            if(0 >= 1)
            {
                    val_16 = val_16.丙东专丂世丈丏丁丂();
                var val_15 = ((val_16 > 0) ? 1 : 0) & 1152921560573704960;
            }
            
            val_18 = new PGCompany.Attributes.丒丏丆且丕三丘丘丐();
            return 0;
        }
    
    }

}
