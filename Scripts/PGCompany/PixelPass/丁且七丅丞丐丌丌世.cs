using UnityEngine;

namespace PGCompany.PixelPass
{
    internal static class 丁且七丅丞丐丌丌世
    {
        // Methods
        internal static bool 三丈与丞上丘专丈丆()
        {
            var val_10;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  "pixelPass", 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  0)) != false)
            {
                    val_10 = PGCompany.Ads.下丙丏丈三上丕丈一.丑七不且上丗丁一世();
                bool val_9 = val_10.三丈与丞上丘专丈丆();
            }
            else
            {
                    val_10 = 0;
            }
            
            val_10 = val_10 & 1;
            return (bool)val_10;
        }
        internal static bool 丁丘丑丗丂上丞丄三()
        {
            var val_6;
            if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  87)) != true)
            {
                    if(PGCompany.BattlePass.BPTutorialController.世丑丐丅丆丂丘不丁() != false)
            {
                    val_6 = (PGCompany.丁东丌世与丕东丆上.丂世一丞丗与丂丐且(丞丅上丏丂且下丅与:  252)) ^ 1;
                return (bool)val_6 & 1;
            }
            
            }
            
            val_6 = 0;
            return (bool)val_6 & 1;
        }
        internal static bool 丟丂下七且七东丛丞()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  252);
            }
            
            return val_1.丟丂下七且七东丛丞(不七丆万丁一丞七下:  252);
        }
        internal static bool 丂世三丅一万东三三()
        {
            PGCompany.丗三万丁三丗上专丟 val_1 = PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丂世三丅一万东三三(不七丆万丁一丞七下:  252);
            }
            
            return val_1.丂世三丅一万东三三(不七丆万丁一丞七下:  252);
        }
        internal static ExpOpenSystem.丅一丐丌与丄上三丗 丑且丁不丅丅上东东()
        {
            ExpOpenSystem.丌下上业与且丁丄三 val_1 = ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世();
            if(val_1 != null)
            {
                    return val_1.丑且丁不丅丅上东东(丆万一不丌且东丐丐:  "feature.pixelpass");
            }
            
            return val_1.丑且丁不丅丅上东东(丆万一不丌且东丐丐:  "feature.pixelpass");
        }
        internal static PGCompany.丙一丟与且丞丏丈一 下丛丌丐丗丒且且业(int 丞世不丒下上上丝丑, int 与丕丌丒丗丄丘丙东)
        {
            return (PGCompany.丙一丟与且丞丏丈一)new PGCompany.丙一丟与且丞丏丈一(下上丐丆丝丟丝丒不:  System.String.Format(format:  "pixel-pass-{0}_{1}", arg0:  丞世不丒下上上丝丑, arg1:  与丕丌丒丗丄丘丙东));
        }
        internal static int 与上丞业丁丗丒业世(PGCompany.丙一丟与且丞丏丈一 一丗与一专丙丙丅丄)
        {
            string val_7;
            object val_8;
            char[] val_3 = new char[1];
            val_3[0] = '_';
            val_7 = 一丗与一专丙丙丅丄.七万丅丆且丁世丏丈().Replace(oldValue:  "pixel-pass-", newValue:  "").Split(separator:  val_3);
            if(val_4.Length >= 1)
            {
                    System.ValueTuple<System.Int32, System.Boolean> val_5 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_7[0]);
                if(((ulong)(val_5.Item2 >> 32) & 255) != 0)
            {
                    val_7 = val_7[0];
                val_8 = val_7;
                System.ValueTuple<System.Int32, System.Boolean> val_6 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_8);
                return (int)val_8;
            }
            
            }
            
            val_8 = 0;
            return (int)val_8;
        }
        internal static int 下丟丑丝丌业上丂丂(PGCompany.丙一丟与且丞丏丈一 一丗与一专丙丙丅丄)
        {
            string val_7;
            object val_8;
            char[] val_3 = new char[1];
            val_3[0] = '_';
            val_7 = 一丗与一专丙丙丅丄.七万丅丆且丁世丏丈().Replace(oldValue:  "pixel-pass-", newValue:  "").Split(separator:  val_3);
            if(val_4.Length >= 2)
            {
                    System.ValueTuple<System.Int32, System.Boolean> val_5 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_7[1]);
                if(((ulong)(val_5.Item2 >> 32) & 255) != 0)
            {
                    val_7 = val_7[1];
                val_8 = val_7;
                System.ValueTuple<System.Int32, System.Boolean> val_6 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_8);
                return (int)val_8;
            }
            
            }
            
            val_8 = 0;
            return (int)val_8;
        }
        internal static string 丄三东丟丒三万世丄(PGCompany.丙一丟与且丞丏丈一 一丗与一专丙丙丅丄)
        {
            return (string)System.String.Format(format:  "{0}_{1}", arg0:  PGCompany.PixelPass.丁且七丅丞丐丌丌世.与上丞业丁丗丒业世(一丗与一专丙丙丅丄:  一丗与一专丙丙丅丄), arg1:  PGCompany.PixelPass.丁且七丅丞丐丌丌世.下丟丑丝丌业上丂丂(一丗与一专丙丙丅丄:  一丗与一专丙丙丅丄));
        }
        internal static System.Collections.Generic.List<丕丐丟丒丆丒丟丅丈> 专丕不丆丆丆丒丘东(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
        {
            var val_38;
            System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_40;
            var val_41;
            System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_43;
            var val_44;
            System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_46;
            var val_48;
            PGCompany.PixelPass.丙丙丕万东丘下丅丌 val_49;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            .丈丂七世丟丞丂丗丒 = 丈丂七世丟丞丂丗丒;
            System.Collections.Generic.List<丕丐丟丒丆丒丟丅丈> val_2 = new System.Collections.Generic.List<丕丐丟丒丆丒丟丅丈>();
            丕丐丟丒丆丒丟丅丈 val_4 = new 丕丐丟丒丆丒丟丅丈(丈丂七世丟丞丂丗丒:  (丁且七丅丞丐丌丌世.丌万一一业丝丁丈丝)[1152921560368923904].丈丂七世丟丞丂丗丒, 丌丏与丐东丘东丕不:  3, 丞丗上不丂一丘且丙:  new System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅>());
            丕丐丟丒丆丒丟丅丈 val_6 = new 丕丐丟丒丆丒丟丅丈(丈丂七世丟丞丂丗丒:  (丁且七丅丞丐丌丌世.丌万一一业丝丁丈丝)[1152921560368923904].丈丂七世丟丞丂丗丒, 丌丏与丐东丘东丕不:  1, 丞丗上不丂一丘且丙:  new System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅>());
            System.Collections.Generic.List<丕丐丟丒丆丒丟丅丈> val_7 = new System.Collections.Generic.List<丕丐丟丒丆丒丟丅丈>();
            if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丂世三丅一万东三三() != false)
            {
                    if(((丁且七丅丞丐丌丌世.丌万一一业丝丁丈丝)[1152921560368923904].丈丂七世丟丞丂丗丒.三与上七业丟丞丙丛.<下丒丕丌业一世丙丞>k__BackingField) != null)
            {
                    if(((丁且七丅丞丐丌丌世.丌万一一业丝丁丈丝)[1152921560368923904].丈丂七世丟丞丂丗丒.三与上七业丟丞丙丛.<下丒丕丌业一世丙丞>k__BackingField.丟万下专丟上业丁下()) == true)
            {
                goto label_8;
            }
            
            }
            
                val_6.与丑丛下且专七万丄().Add(item:  (丁且七丅丞丐丌丌世.丌万一一业丝丁丈丝)[1152921560368923904].丈丂七世丟丞丂丗丒.三与上七业丟丞丙丛);
            }
            
            label_8:
            System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> val_11 = new System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅>(capacity:  2);
            val_38 = null;
            val_38 = null;
            val_40 = 丁且七丅丞丐丌丌世.<>c.<>9__9_1;
            if(val_40 == null)
            {
                    System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_14 = null;
                val_40 = val_14;
                val_14 = new System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(object:  丁且七丅丞丐丌丌世.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丁且七丅丞丐丌丌世.<>c::丁不一万丗业世丁万(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
                丁且七丅丞丐丌丌世.<>c.<>9__9_1 = val_40;
            }
            
            val_41 = null;
            val_41 = null;
            val_43 = 丁且七丅丞丐丌丌世.<>c.<>9__9_2;
            if(val_43 == null)
            {
                    System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_16 = null;
                val_43 = val_16;
                val_16 = new System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(object:  丁且七丅丞丐丌丌世.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丁且七丅丞丐丌丌世.<>c::且丟丕世丘下丁丈丐(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
                丁且七丅丞丐丌丌世.<>c.<>9__9_2 = val_43;
            }
            
            val_44 = null;
            val_44 = null;
            val_46 = 丁且七丅丞丐丌丌世.<>c.<>9__9_3;
            if(val_46 == null)
            {
                    System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_18 = null;
                val_46 = val_18;
                val_18 = new System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(object:  丁且七丅丞丐丌丌世.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丁且七丅丞丐丌丌世.<>c::专丘丆与丅丝丁丆丂(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
                丁且七丅丞丐丌丌世.<>c.<>9__9_3 = val_46;
            }
            
            var val_41 = 0;
            val_41 = val_41 + 1;
            val_48 = 1152921530823984048;
            val_49 = System.Linq.Enumerable.ThenByDescending<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(source:  System.Linq.Enumerable.ThenByDescending<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(source:  (丁且七丅丞丐丌丌世.丌万一一业丝丁丈丝)[1152921560368923904].丈丂七世丟丞丂丗丒.<丂且丂丄丞丒下万丙>k__BackingField.FindAll(match:  new System.Predicate<PGCompany.PixelPass.一万丄一丌丆业丐丅>(object:  new 丁且七丅丞丐丌丌世.丌万一一业丝丁丈丝(), method:  System.Boolean 丁且七丅丞丐丌丌世.丌万一一业丝丁丈丝::与丆丗丌丛丑下丛与(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业))), keySelector:  val_14), keySelector:  val_16), keySelector:  val_18).GetEnumerator();
            label_65:
            label_58:
            var val_42 = 0;
            val_42 = val_42 + 1;
            if(val_49.MoveNext() == false)
            {
                goto label_39;
            }
            
            var val_43 = 0;
            val_43 = val_43 + 1;
            T val_25 = val_49.Current;
            val_52 = mem[val_25 + 16];
            val_52 = val_25 + 16;
            if(val_52 == 0)
            {
                goto label_55;
            }
            
            if((val_25 + 16 + 64) != 3)
            {
                goto label_47;
            }
            
            val_4.与丑丛下且专七万丄().Add(item:  val_25);
            val_52 = mem[val_25 + 16];
            val_52 = val_25 + 16;
            val_53 = val_48;
            if(val_52 == 0)
            {
                goto label_55;
            }
            
            label_47:
            if((val_25 + 16 + 64) != 1)
            {
                goto label_51;
            }
            
            val_6.与丑丛下且专七万丄().Add(item:  val_25);
            val_52 = mem[val_25 + 16];
            val_52 = val_25 + 16;
            val_53 = val_53;
            if(val_52 == 0)
            {
                goto label_55;
            }
            
            label_51:
            if((val_25 + 16 + 64) == 2)
            {
                    val_11.Add(item:  val_25);
            }
            
            label_55:
            if(val_11.Count < 2)
            {
                goto label_58;
            }
            
            new 丕丐丟丒丆丒丟丅丈() = new 丕丐丟丒丆丒丟丅丈(丈丂七世丟丞丂丗丒:  (丁且七丅丞丐丌丌世.丌万一一业丝丁丈丝)[1152921560368923904].丈丂七世丟丞丂丗丒, 丌丏与丐东丘东丕不:  2, 丞丗上不丂一丘且丙:  System.Linq.Enumerable.ToList<PGCompany.PixelPass.一万丄一丌丆业丐丅>(source:  val_11));
            val_7.Add(item:  new 丕丐丟丒丆丒丟丅丈());
            val_11.Clear();
            if((0 & 1) != 0)
            {
                goto label_65;
            }
            
            丕丐丟丒丆丒丟丅丈 val_31 = val_7.Item[0];
            val_31.丝丐丄丕东世丙七丏 = true;
            goto label_65;
            label_39:
            val_54 = 1152921505242681344;
            val_55 = 0;
            val_56 = 0;
            if(val_49 == null)
            {
                
            }
            else
            {
                    var val_44 = 0;
                val_44 = val_44 + 1;
                val_49.Dispose();
            }
            
            if(val_11.Count != 0)
            {
                    val_49 = (丁且七丅丞丐丌丌世.丌万一一业丝丁丈丝)[1152921560368923904].丈丂七世丟丞丂丗丒;
                val_7.Add(item:  new 丕丐丟丒丆丒丟丅丈(丈丂七世丟丞丂丗丒:  val_49, 丌丏与丐东丘东丕不:  2, 丞丗上不丂一丘且丙:  System.Linq.Enumerable.ToList<PGCompany.PixelPass.一万丄一丌丆业丐丅>(source:  val_11)));
                val_11.Clear();
            }
            
            if(val_4.与丑丛下且专七万丄().Count >= 1)
            {
                    val_2.Add(item:  val_4);
            }
            
            if(val_6.与丑丛下且专七万丄().Count >= 1)
            {
                    val_2.Add(item:  val_6);
            }
            
            if(val_7.Count < 1)
            {
                    return val_2;
            }
            
            val_2.AddRange(collection:  val_7);
            return val_2;
        }
        internal static System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> 丙七丕东丅与丈三不(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, string 丞丁丑丏丄丏七丂不)
        {
            if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丈万丙东东丒丏丆丝() == false)
            {
                    return (System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅>)new System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅>();
            }
            
            if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丟丂下七且七东丛丞() != true)
            {
                    if(PGCompany.PixelPass.丁且七丅丞丐丌丌世.丂世三丅一万东三三() == false)
            {
                    return (System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅>)new System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅>();
            }
            
            }
            
            if(PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世() != null)
            {
                    return PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丙七丕东丅与丈三不(丈丂七世丟丞丂丗丒:  val_5.<丈丏丑不东业丟丗丘>k__BackingField, 上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 丞丁丑丏丄丏七丂不:  丞丁丑丏丄丏七丂不);
            }
            
            return PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丙七丕东丅与丈三不(丈丂七世丟丞丂丗丒:  val_5.<丈丏丑不东业丟丗丘>k__BackingField, 上且丗一丏丏万丅丌:  上且丗一丏丏万丅丌, 丞丁丑丏丄丏七丂不:  丞丁丑丏丄丏七丂不);
        }
        internal static T 丒丒一丕世丟三丂丌<T>(UnityEngine.Transform 丄三下丙下世丅丘丙, string 丟丈一下东业一丝丆)
        {
            string val_10;
            var val_11;
            var val_12;
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_13;
            val_10 = 丟丈一下东业一丝丆;
            val_11 = 0;
            if(丄三下丙下世丅丘丙 == 0)
            {
                    return (PGCompany.PixelPass.PixelPassTasksInConnectSceneUI)val_11;
            }
            
            val_12 = null;
            val_12 = null;
            val_13 = GameConnect.丈丝丂丐丟万丙丑丕;
            if(val_13 != null)
            {
                    val_13 = GameConnect.丈丝丂丐丟万丙丑丕;
                if(val_13 == null)
            {
                    val_13 = 0;
            }
            
                System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = val_13.丌不丅不丞东万专专();
                val_11 = 0;
                if(val_2.HasValue.丙东专丂世丈丏丁丂() != 3)
            {
                    return (PGCompany.PixelPass.PixelPassTasksInConnectSceneUI)val_11;
            }
            
                if(( & 1) == 0)
            {
                    return (PGCompany.PixelPass.PixelPassTasksInConnectSceneUI)val_11;
            }
            
            }
            
            val_10 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "PixelPass/"("PixelPass/") + val_10);
            val_11 = 0;
            if(val_10 == 0)
            {
                    return (PGCompany.PixelPass.PixelPassTasksInConnectSceneUI)val_11;
            }
            
            int val_7 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            UnityEngine.GameObject val_8 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  val_10, 丈东丘丏与丌东东下:  丄三下丙下世丅丘丙, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            val_11 = 0;
            if(val_8 == 0)
            {
                    return (PGCompany.PixelPass.PixelPassTasksInConnectSceneUI)val_11;
            }
            
            val_11 = val_8;
            return (PGCompany.PixelPass.PixelPassTasksInConnectSceneUI)val_11;
        }
        internal static string 丗丏丛丄三万丝下丟(int 三专三丐丁世丑丁丅)
        {
            return (string)System.String.Format(format:  "PixelPassTaskView_{0}", arg0:  三专三丐丁世丑丁丅);
        }
        internal static string 丞丈世丆七丄七丌丕(int 丈丁丆三丅上丂丘丟)
        {
            return (string)System.String.Format(format:  "PixelPassCellView_{0}", arg0:  丈丁丆三丅上丂丘丟);
        }
        internal static PGCompany.丕万丅丗丏三丙丈丁 丁丗且丗丐且专丘丂(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
        {
            var val_5;
            if(丈丂七世丟丞丂丗丒 == null)
            {
                    return 0;
            }
            
            .Type = 22;
            val_5 = null;
            val_5 = null;
            if((丁且七丅丞丐丌丌世.<>c.<>9__14_0) == null)
            {
                goto label_5;
            }
            
            label_15:
            if((丈丂七世丟丞丂丗丒.<丂且丂丄丞丒下万丙>k__BackingField.Exists(match:  丁且七丅丞丐丌丌世.<>c.<>9__14_0)) != true)
            {
                    if(丈丂七世丟丞丂丗丒.三与上七业丟丞丙丛.且世丝三不丂丟丞丑() == false)
            {
                    return PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌());
            }
            
            }
            
            .Type = 23;
            return PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌());
            label_5:
            丁且七丅丞丐丌丌世.<>c.<>9__14_0 = new System.Predicate<PGCompany.PixelPass.一万丄一丌丆业丐丅>(object:  丁且七丅丞丐丌丌世.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丁且七丅丞丐丌丌世.<>c::世专丙丌丈丅丗万丗(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
            if((丈丂七世丟丞丂丗丒.<丂且丂丄丞丒下万丙>k__BackingField) != null)
            {
                goto label_15;
            }
            
            goto label_15;
        }
    
    }

}
