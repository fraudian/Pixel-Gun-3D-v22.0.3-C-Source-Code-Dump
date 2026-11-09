using UnityEngine;

namespace PGCompany.PixelPass
{
    internal static class 丘丒丐丟丏丄丌丒万
    {
        // Methods
        internal static PGCompany.三东丏不丗世丅丌丄 与七丞万东丘丗下丒(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, int 丌与丅丌丒丅丄丆丁 = 1)
        {
            PGCompany.三东丏不丗世丅丌丄 val_4;
            if(丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏 == null)
            {
                    return 0;
            }
            
            if(丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common == null)
            {
                    return 0;
            }
            
            if(丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common.LevelPrice == null)
            {
                    return 0;
            }
            
            if((丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏 != null) && (丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common != null))
            {
                    val_4 = 丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common.LevelPrice;
                if(val_4 != null)
            {
                    return PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common.LevelPrice.业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  val_4.丂丁丏一丙丛业且丌() * 丌与丅丌丒丅丄丆丁);
            }
            
            }
            
            val_4 = 0;
            return PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common.LevelPrice.业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  val_4.丂丁丏一丙丛业且丌() * 丌与丅丌丒丅丄丆丁);
        }
        internal static bool 丙不不丘东万业丑丟(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, int 丌与丅丌丒丅丄丆丁 = 1)
        {
            PGCompany.三东丏不丗世丅丌丄 val_8;
            PGCompany.三东丏不丗世丅丌丄 val_9;
            PGCompany.三东丏不丗世丅丌丄 val_10;
            val_8 = 丌与丅丌丒丅丄丆丁;
            if((丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏 == null) || (丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common == null))
            {
                goto label_2;
            }
            
            val_9 = 丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common.LevelPrice;
            if(val_9 == null)
            {
                goto label_8;
            }
            
            if((丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏 == null) || (丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common == null))
            {
                goto label_5;
            }
            
            val_10 = 丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common.LevelPrice;
            if(val_10 != null)
            {
                goto label_6;
            }
            
            label_5:
            val_10 = 0;
            label_6:
            val_8 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_9.业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  val_10.丂丁丏一丙丛业且丌() * val_8);
            val_9 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            bool val_6 = val_9.丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_8, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            goto label_8;
            label_2:
            val_9 = 0;
            label_8:
            val_9 = val_9 & 1;
            return (bool)val_9;
        }
        internal static bool 上丛东丅丑丒丏不丐(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, int 丌与丅丌丒丅丄丆丁 = 1)
        {
            PGCompany.三东丏不丗世丅丌丄 val_15;
            PGCompany.三东丏不丗世丅丌丄 val_16;
            PGCompany.三东丏不丗世丅丌丄 val_3 = 0;
            if(丈丂七世丟丞丂丗丒.丘丗与丝专丑一丙丌() == true)
            {
                    return false;
            }
            
            if((PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丙不不丘东万业丑丟(丈丂七世丟丞丂丗丒:  丈丂七世丟丞丂丗丒, 丌与丅丌丒丅丄丆丁:  丌与丅丌丒丅丄丆丁)) == false)
            {
                    return false;
            }
            
            if((PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.下丞七丄丒丐三丌丒(丈丂七世丟丞丂丗丒:  丈丂七世丟丞丂丗丒, 丗万丒丗丏丒三且丌:  丌与丅丌丒丅丄丆丁, 丌丞不且丁丞与万丑: out  val_3)) == false)
            {
                    return false;
            }
            
            if((丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏 == null) || (丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common == null))
            {
                goto label_7;
            }
            
            val_15 = 丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common.LevelPrice;
            if(val_15 != null)
            {
                goto label_8;
            }
            
            label_7:
            val_15 = 0;
            label_8:
            if((丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏 == null) || (丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common == null))
            {
                goto label_10;
            }
            
            val_16 = 丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common.LevelPrice;
            if(val_16 != null)
            {
                goto label_11;
            }
            
            label_10:
            val_16 = 0;
            label_11:
            PGCompany.三东丏不丗世丅丌丄 val_8 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_15.业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  val_16.丂丁丏一丙丛业且丌() * 丌与丅丌丒丅丄丆丁);
            PGCompany.PixelPass.七丒七与丆下丕丏丅 val_9 = new PGCompany.PixelPass.七丒七与丆下丕丏丅();
            .<丈丏丑不东业丟丗丘>k__BackingField = 丈丂七世丟丞丂丗丒;
            int val_10 = 丈丂七世丟丞丂丗丒.丞丞丘业东丙丏七丌();
            if(val_9 != null)
            {
                    .丂丄与丁上专丘丆丈 = val_10;
            }
            else
            {
                    mem[24] = val_10;
            }
            
            .丒丆丕丁丟业上七丅 = val_8;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  170);
            PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙世丕丒世丞丌丆下(七不丅丄业丞丂专三:  val_8, 丌丄不丒丐丆且丌与:  val_3, 东丆下丌业上丙下七:  new PGCompany.世世丘丝丞业三世一() {且丝丕丆不丅丏丛东 = new PGCompany.丛丈下且丐丝不东丈() {丐丒上丘丙丕且丕七 = 3, 上丂丑丄丈七丆丁下 = false, 丁丁丒丆不丒下丟三 = 143, <丟丟丂东世下丗不丝>k__BackingField = false, <且丄丞一下丕丂东丕>k__BackingField = false, <不丅丘丄丝丌丙丅万>k__BackingField = false, <丘下丅丆万丕丆丂世>k__BackingField = false}, 丁东丑丏丐丏丄一丒 = new PGCompany.丆丈丘东丆丕三丞东()}).丐丙与丙万丑丈业丑(不丕一下丒不世与且:  val_9);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return false;
        }
        internal static bool 丌丒世丗上东上与丘(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, int 丗万丒丗丏丒三且丌, out PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丒万三一丈丟丌丕丝)
        {
            var val_11;
            var val_12;
            Rilisoft.丝丑丂丛万丐丈丘且 val_14;
            val_11 = 1152921560360959792;
            if(丈丂七世丟丞丂丗丒 != null)
            {
                    val_12 = 丈丂七世丟丞丂丗丒.丞丞丘业东丙丏七丌();
            }
            else
            {
                    val_12 = 0.丞丞丘业东丙丏七丌();
            }
            
            .与丘丝且下丁丑上丂 = System.Math.Min(val1:  val_12 + 丗万丒丗丏丒三且丌, val2:  丈丂七世丟丞丂丗丒.丄且东且丕丛与丆丒());
            PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_8 = System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(source:  丈丂七世丟丞丂丗丒.<丗东丏丛丄丈专一七>k__BackingField, predicate:  new System.Func<PGCompany.PixelPass.丆丟丈丕下下丘丅丗, System.Boolean>(object:  new 丘丒丐丟丏丄丌丒万.上丌专丄丘丂东且丒(), method:  System.Boolean 丘丒丐丟丏丄丌丒万.上丌专丄丘丂东且丒::专专一业丕丐丘丕丂(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘)));
            丒万三一丈丟丌丕丝 = val_8;
            if(val_8 == null)
            {
                    return (bool)(val_11 > val_8.东世且丆业丌丕专七()) ? 1 : 0;
            }
            
            if((val_8.<丒下丅丏丄丗上专业>k__BackingField) != null)
            {
                    val_14 = val_8.<丒下丅丏丄丗上专业>k__BackingField.Exp;
                val_11 = val_14;
                return (bool)(val_11 > val_8.东世且丆业丌丕专七()) ? 1 : 0;
            }
            
            val_11 = 0;
            return (bool)(val_11 > val_8.东世且丆业丌丕专七()) ? 1 : 0;
        }
        internal static bool 下丞七丄丒丐三丌丒(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, int 丗万丒丗丏丒三且丌, out PGCompany.三东丏不丗世丅丌丄 丌丞不且丁丞与万丑)
        {
            int val_10;
            Rilisoft.丝丑丂丛万丐丈丘且 val_11;
            var val_12;
            val_10 = 丗万丒丗丏丒三且丌;
            丌丞不且丁丞与万丑 = 0;
            if((PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丌丒世丗上东上与丘(丈丂七世丟丞丂丗丒:  丈丂七世丟丞丂丗丒, 丗万丒丗丏丒三且丌:  val_10, 丒万三一丈丟丌丕丝: out  0)) == false)
            {
                goto label_13;
            }
            
            if(11993091 == 0)
            {
                goto label_3;
            }
            
            val_10 = 11993091 + 56;
            if(丈丂七世丟丞丂丗丒 != null)
            {
                goto label_15;
            }
            
            label_16:
            label_15:
            PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_4 = 丈丂七世丟丞丂丗丒.丛丙丌专丐七丛丘三();
            if((val_4.<丒下丅丏丄丗上专业>k__BackingField) == null)
            {
                goto label_6;
            }
            
            if(丈丂七世丟丞丂丗丒 != null)
            {
                goto label_17;
            }
            
            label_18:
            label_17:
            PGCompany.PixelPass.丆丟丈丕下下丘丅丗 val_5 = 丈丂七世丟丞丂丗丒.丑丄丏且万专业东丘();
            if((val_5.<丒下丅丏丄丗上专业>k__BackingField) == null)
            {
                goto label_9;
            }
            
            val_11 = val_5.<丒下丅丏丄丗上专业>k__BackingField.Exp;
            if(丈丂七世丟丞丂丗丒 != null)
            {
                goto label_19;
            }
            
            label_20:
            val_11 = 0;
            label_19:
            int val_9 = UnityEngine.Mathf.Clamp(value:  val_10 - (val_4.<丒下丅丏丄丗上专业>k__BackingField.Exp), min:  0, max:  val_11 - val_11.东世且丆业丌丕专七());
            if(val_9 >= 1)
            {
                    丌丞不且丁丞与万丑 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丆专且丕专丗与一丏:  183, 丂丕丂丏专丂丄丕且:  val_9);
                val_12 = 1;
                return (bool)val_12;
            }
            
            label_13:
            val_12 = 0;
            return (bool)val_12;
            label_3:
            if(丈丂七世丟丞丂丗丒 != null)
            {
                goto label_15;
            }
            
            goto label_16;
            label_6:
            if(丈丂七世丟丞丂丗丒 != null)
            {
                goto label_17;
            }
            
            goto label_18;
            label_9:
            if(丈丂七世丟丞丂丗丒 != null)
            {
                goto label_19;
            }
            
            goto label_20;
        }
        internal static System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丌丐世丆丒下与丐丟(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
        {
            var val_9;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_11;
            .专与一专丂一上丙与 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_9 = null;
            val_9 = null;
            if((丘丒丐丟丏丄丌丒万.<>c.<>9__5_0) == null)
            {
                goto label_5;
            }
            
            label_14:
            丈丂七世丟丞丂丗丒.<丗东丏丛丄丈专一七>k__BackingField.FindAll(match:  丘丒丐丟丏丄丌丒万.<>c.<>9__5_0).ForEach(action:  new System.Action<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(object:  new 丘丒丐丟丏丄丌丒万.丞丂万丅不丒丘丟丗(), method:  System.Void 丘丒丐丟丏丄丌丒万.丞丂万丅不丒丘丟丗::丞丌且丕丛丝丐丈丌(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘)));
            val_11 = (丘丒丐丟丏丄丌丒万.丞丂万丅不丒丘丟丗)[1152921560361322864].专与一专丂一上丙与;
            val_11.AddRange(collection:  丈丂七世丟丞丂丗丒.上丈下丕丄丗丝三丄());
            if(丈丂七世丟丞丂丗丒.丛世三不专丄一丏丑() == false)
            {
                    return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)(丘丒丐丟丏丄丌丒万.丞丂万丅不丒丘丟丗)[1152921560361322864].专与一专丂一上丙与;
            }
            
            val_11 = (丘丒丐丟丏丄丌丒万.丞丂万丅不丒丘丟丗)[1152921560361322864].专与一专丂一上丙与;
            val_11.AddRange(collection:  丈丂七世丟丞丂丗丒.丆丒丗丝丂东丈丏丒());
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)(丘丒丐丟丏丄丌丒万.丞丂万丅不丒丘丟丗)[1152921560361322864].专与一专丂一上丙与;
            label_5:
            丘丒丐丟丏丄丌丒万.<>c.<>9__5_0 = new System.Predicate<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(object:  丘丒丐丟丏丄丌丒万.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丘丒丐丟丏丄丌丒万.<>c::一专丒丟业丑丙丄世(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘));
            if((丈丂七世丟丞丂丗丒.<丗东丏丛丄丈专一七>k__BackingField) != null)
            {
                goto label_14;
            }
            
            goto label_14;
        }
        internal static System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> 丛东丆丟三专丑丙不(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
        {
            var val_3 = null;
            if((丘丒丐丟丏丄丌丒万.<>c.<>9__6_0) != null)
            {
                    if((丈丂七世丟丞丂丗丒.<丂且丂丄丞丒下万丙>k__BackingField) == null)
            {
                    return System.Linq.Enumerable.ToList<PGCompany.PixelPass.一万丄一丌丆业丐丅>(source:  丈丂七世丟丞丂丗丒.<丂且丂丄丞丒下万丙>k__BackingField.FindAll(match:  丘丒丐丟丏丄丌丒万.<>c.<>9__6_0));
            }
            
                return System.Linq.Enumerable.ToList<PGCompany.PixelPass.一万丄一丌丆业丐丅>(source:  丈丂七世丟丞丂丗丒.<丂且丂丄丞丒下万丙>k__BackingField.FindAll(match:  丘丒丐丟丏丄丌丒万.<>c.<>9__6_0));
            }
            
            丘丒丐丟丏丄丌丒万.<>c.<>9__6_0 = new System.Predicate<PGCompany.PixelPass.一万丄一丌丆业丐丅>(object:  丘丒丐丟丏丄丌丒万.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丘丒丐丟丏丄丌丒万.<>c::丂丕丈丞丐丑业丗丕(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
            if((丈丂七世丟丞丂丗丒.<丂且丂丄丞丒下万丙>k__BackingField) != null)
            {
                    return System.Linq.Enumerable.ToList<PGCompany.PixelPass.一万丄一丌丆业丐丅>(source:  丈丂七世丟丞丂丗丒.<丂且丂丄丞丒下万丙>k__BackingField.FindAll(match:  丘丒丐丟丏丄丌丒万.<>c.<>9__6_0));
            }
            
            return System.Linq.Enumerable.ToList<PGCompany.PixelPass.一万丄一丌丆业丐丅>(source:  丈丂七世丟丞丂丗丒.<丂且丂丄丞丒下万丙>k__BackingField.FindAll(match:  丘丒丐丟丏丄丌丒万.<>c.<>9__6_0));
        }
        internal static System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丛三丑上丝一丕丞丂(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
        {
            var val_6;
            .丑七丞且丙丗丌且丞 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            val_6 = null;
            val_6 = null;
            if((丘丒丐丟丏丄丌丒万.<>c.<>9__7_0) == null)
            {
                goto label_5;
            }
            
            label_11:
            丈丂七世丟丞丂丗丒.<丗东丏丛丄丈专一七>k__BackingField.FindAll(match:  丘丒丐丟丏丄丌丒万.<>c.<>9__7_0).ForEach(action:  new System.Action<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(object:  new 丘丒丐丟丏丄丌丒万.丒丑万一丁丕东一丗(), method:  System.Void 丘丒丐丟丏丄丌丒万.丒丑万一丁丕东一丗::丞三丑丄万丗丌丑与(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘)));
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)(丘丒丐丟丏丄丌丒万.丒丑万一丁丕东一丗)[1152921560361666672].丑七丞且丙丗丌且丞;
            label_5:
            丘丒丐丟丏丄丌丒万.<>c.<>9__7_0 = new System.Predicate<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(object:  丘丒丐丟丏丄丌丒万.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丘丒丐丟丏丄丌丒万.<>c::丁下丗丅万业丌丈且(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘));
            if((丈丂七世丟丞丂丗丒.<丗东丏丛丄丈专一七>k__BackingField) != null)
            {
                goto label_11;
            }
            
            goto label_11;
        }
        internal static System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 与丒丕与下下丛丑丂(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, int 丗万丒丗丏丒三且丌)
        {
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_10;
            var val_11;
            丘丒丐丟丏丄丌丒万.业东下丕世丗丏万丏 val_1 = new 丘丒丐丟丏丄丌丒万.业东下丕世丗丏万丏();
            .丈丂七世丟丞丂丗丒 = 丈丂七世丟丞丂丗丒;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = null;
            val_10 = val_2;
            val_2 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            val_11 = val_1;
            .东且丁丆丛丁丏丘且 = val_10;
            if((PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丌丒世丗上东上与丘(丈丂七世丟丞丂丗丒:  .丈丂七世丟丞丂丗丒, 丗万丒丗丏丒三且丌:  丗万丒丗丏丒三且丌, 丒万三一丈丟丌丕丝: out  1152921560361850376)) == true)
            {
                goto label_3;
            }
            
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)val_11;
            label_2:
            val_11 = 32;
            mem[32] = val_10;
            val_10 = (丘丒丐丟丏丄丌丒万.业东下丕世丗丏万丏)[1152921560361850352].丈丂七世丟丞丂丗丒;
            if((PGCompany.PixelPass.丘丒丐丟丏丄丌丒万.丌丒世丗上东上与丘(丈丂七世丟丞丂丗丒:  val_10, 丗万丒丗丏丒三且丌:  丗万丒丗丏丒三且丌, 丒万三一丈丟丌丕丝: out  24)) == false)
            {
                    return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)val_11;
            }
            
            label_3:
            System.Action<PGCompany.PixelPass.丆丟丈丕下下丘丅丗> val_9 = null;
            val_10 = val_9;
            val_9 = new System.Action<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(object:  val_1, method:  System.Void 丘丒丐丟丏丄丌丒万.业东下丕世丗丏万丏::专上丆丕三与丟专丝(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘));
            (丘丒丐丟丏丄丌丒万.业东下丕世丗丏万丏)[1152921560361850352].丈丂七世丟丞丂丗丒.<丗东丏丛丄丈专一七>k__BackingField.FindAll(match:  new System.Predicate<PGCompany.PixelPass.丆丟丈丕下下丘丅丗>(object:  val_1, method:  System.Boolean 丘丒丐丟丏丄丌丒万.业东下丕世丗丏万丏::丆丌丒丈丙东丟丗与(PGCompany.PixelPass.丆丟丈丕下下丘丅丗 丌丝万上丅丒一丈丘))).ForEach(action:  val_9);
            return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)val_11;
        }
        internal static int 丐世万丄三上丙七丟(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, PGCompany.PixelPass.丒且丏万业业七业万 丌丏与丐东丘东丕不)
        {
            System.Predicate<T> val_6;
            var val_7;
            System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Int32> val_9;
            丘丒丐丟丏丄丌丒万.丌万一一业丝丁丈丝 val_1 = new 丘丒丐丟丏丄丌丒万.丌万一一业丝丁丈丝();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .丌丏与丐东丘东丕不 = 丌丏与丐东丘东丕不;
            .丈丂七世丟丞丂丗丒 = 丈丂七世丟丞丂丗丒;
            if(丈丂七世丟丞丂丗丒 != null)
            {
                goto label_11;
            }
            
            label_12:
            label_11:
            System.Predicate<PGCompany.PixelPass.一万丄一丌丆业丐丅> val_2 = null;
            val_6 = val_2;
            val_2 = new System.Predicate<PGCompany.PixelPass.一万丄一丌丆业丐丅>(object:  val_1, method:  System.Boolean 丘丒丐丟丏丄丌丒万.丌万一一业丝丁丈丝::丒丝丈东七丐丏上一(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
            System.Collections.Generic.List<T> val_3 = 丈丂七世丟丞丂丗丒.<丂且丂丄丞丒下万丙>k__BackingField.FindAll(match:  val_2);
            if(val_3.Count < 1)
            {
                    return 0;
            }
            
            val_7 = null;
            val_7 = null;
            val_9 = 丘丒丐丟丏丄丌丒万.<>c.<>9__9_1;
            if(val_9 != null)
            {
                    return System.Linq.Enumerable.Min<PGCompany.PixelPass.一万丄一丌丆业丐丅>(source:  val_3, selector:  System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Int32> val_5 = null);
            }
            
            val_9 = val_5;
            val_5 = new System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Int32>(object:  丘丒丐丟丏丄丌丒万.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丘丒丐丟丏丄丌丒万.<>c::丒丕丟专东丏丁且业(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
            丘丒丐丟丏丄丌丒万.<>c.<>9__9_1 = val_9;
            return System.Linq.Enumerable.Min<PGCompany.PixelPass.一万丄一丌丆业丐丅>(source:  val_3, selector:  val_5);
            label_1:
            mem[16] = 丌丏与丐东丘东丕不;
            mem[24] = 丈丂七世丟丞丂丗丒;
            if(mem[24] != 0)
            {
                goto label_11;
            }
            
            goto label_12;
        }
        internal static PGCompany.PixelPass.丙一丘一一丟丄丈世 与与业丌丕东七丏东(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, int 东一七丟与丗三丐不)
        {
            .东一七丟与丗三丐不 = 东一七丟与丗三丐不;
            return System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.丙一丘一一丟丄丈世>(source:  丈丂七世丟丞丂丗丒.丈七丒专业丆七丙丏(), predicate:  new System.Func<PGCompany.PixelPass.丙一丘一一丟丄丈世, System.Boolean>(object:  new 丘丒丐丟丏丄丌丒万.下丌丛三下专丘丐丕(), method:  System.Boolean 丘丒丐丟丏丄丌丒万.下丌丛三下专丘丐丕::丙丆丐下且丘丘不丌(PGCompany.PixelPass.丙一丘一一丟丄丈世 万不且且丛丆东丒业)));
        }
        internal static bool 一丝丞丕专丄业丌丛(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业, System.Nullable<long> 丑专丛丅丞下丄丈丞, out int 世世丘且不三与丟丂)
        {
            object val_26;
            var val_27;
            System.Collections.Generic.IEnumerable<TSource> val_28;
            var val_29;
            var val_32;
            var val_33;
            var val_34;
            var val_36;
            var val_37;
            var val_38;
            var val_39;
            var val_40;
            System.Func<PGCompany.PixelPass.丁七业丂与业丒丑丈, System.Int32> val_42;
            var val_43;
            丘丒丐丟丏丄丌丒万.丗丛丘丑丐不丌丑丙 val_1 = null;
            val_26 = val_1;
            val_1 = new 丘丒丐丟丏丄丌丒万.丗丛丘丑丐不丌丑丙();
            if(val_26 != null)
            {
                    val_27 = val_26;
                .丈丂七世丟丞丂丗丒 = 丈丂七世丟丞丂丗丒;
                mem[1152921560362419760] = 万不且且丛丆东丒业;
                mem2[0] = 0;
            }
            else
            {
                    mem[16] = 万不且且丛丆东丒业;
                val_27 = 32;
                mem[32] = 丈丂七世丟丞丂丗丒;
                mem2[0] = 0;
            }
            
            val_28 = val_27.丛丘丞丝丈一丄丐丗().FindAll(match:  new System.Predicate<PGCompany.PixelPass.丁七业丂与业丒丑丈>(object:  val_1, method:  System.Boolean 丘丒丐丟丏丄丌丒万.丗丛丘丑丐不丌丑丙::丂丞七丁丙丗下且三(PGCompany.PixelPass.丁七业丂与业丒丑丈 丙丒七丄上与丏丙丙)));
            System.Collections.Generic.List<System.Int32> val_5 = new System.Collections.Generic.List<System.Int32>();
            if(val_26 != null)
            {
                    val_29 = val_26;
                .丁丑且丏下一七丅不 = val_5;
            }
            else
            {
                    val_29 = 24;
                mem[24] = val_5;
            }
            
            System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>> val_8 = 0.丛丞三丒丌且丝三与().一且三丟业丘丘丒专().GetEnumerator();
            label_28:
            var val_28 = 0;
            val_28 = val_28 + 1;
            if(val_8.MoveNext() == false)
            {
                goto label_15;
            }
            
            new 丘丒丐丟丏丄丌丒万.世世丝丏丙丞丙丏丁() = new System.Object();
            var val_29 = 0;
            val_29 = val_29 + 1;
            .丐丏东世不丅丌且万 = val_8.Current;
            System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean> val_14 = new System.Func<PGCompany.PixelPass.一万丄一丌丆业丐丅, System.Boolean>(object:  new 丘丒丐丟丏丄丌丒万.世世丝丏丙丞丙丏丁(), method:  System.Boolean 丘丒丐丟丏丄丌丒万.世世丝丏丙丞丙丏丁::一丈万丏万万下丝不(PGCompany.PixelPass.一万丄一丌丆业丐丅 丙丒七丄上与丏丙丙));
            PGCompany.PixelPass.一万丄一丌丆业丐丅 val_15 = System.Linq.Enumerable.FirstOrDefault<PGCompany.PixelPass.一万丄一丌丆业丐丅>(source:  丈丂七世丟丞丂丗丒 + 72, predicate:  null);
            if((val_15 == null) || ((val_15.丈丏业丒下丕丘下丅(丑专丛丅丞下丄丈丞:  new System.Nullable<System.Int64>() {HasValue = 丑专丛丅丞下丄丈丞.HasValue})) == false))
            {
                goto label_28;
            }
            
            val_5.Add(item:  -78969280);
            goto label_28;
            label_15:
            val_32 = 1152921560362285936;
            val_33 = 0;
            val_34 = 0;
            if(val_8 == null)
            {
                
            }
            else
            {
                    var val_30 = 0;
                val_30 = val_30 + 1;
                val_8.Dispose();
            }
            
            val_36 = 1152921504616751104;
            System.Predicate<PGCompany.PixelPass.丁七业丂与业丒丑丈> val_18 = new System.Predicate<PGCompany.PixelPass.丁七业丂与业丒丑丈>(object:  val_1, method:  System.Boolean 丘丒丐丟丏丄丌丒万.丗丛丘丑丐不丌丑丙::丏三丒世丛丕丅丟丂(PGCompany.PixelPass.丁七业丂与业丒丑丈 丙丒七丄上与丏丙丙));
            if(val_28 != null)
            {
                    int val_19 = val_28.RemoveAll(match:  val_18);
            }
            else
            {
                    int val_20 = 0.RemoveAll(match:  val_18);
            }
            
            val_37 = 1152921560362328992;
            val_38 = val_28;
            if(val_38.Count == 0)
            {
                    return (bool)val_38;
            }
            
            val_36 = val_28.FindAll(match:  new System.Predicate<PGCompany.PixelPass.丁七业丂与业丒丑丈>(object:  val_1, method:  System.Boolean 丘丒丐丟丏丄丌丒万.丗丛丘丑丐不丌丑丙::丆七不丙下与丛上丅(PGCompany.PixelPass.丁七业丂与业丒丑丈 丙丒七丄上与丏丙丙)));
            val_26 = 1152921505697472512;
            val_39 = null;
            if(val_36.Count > 0)
            {
                    val_37 = X4;
                val_40 = null;
                val_42 = 丘丒丐丟丏丄丌丒万.<>c.<>9__11_3;
                if(val_42 == null)
            {
                    System.Func<PGCompany.PixelPass.丁七业丂与业丒丑丈, System.Int32> val_25 = null;
                val_42 = val_25;
                val_25 = new System.Func<PGCompany.PixelPass.丁七业丂与业丒丑丈, System.Int32>(object:  丘丒丐丟丏丄丌丒万.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丘丒丐丟丏丄丌丒万.<>c::丒七七丑丂丒丈一上(PGCompany.PixelPass.丁七业丂与业丒丑丈 丙丒七丄上与丏丙丙));
                丘丒丐丟丏丄丌丒万.<>c.<>9__11_3 = val_42;
            }
            
                val_28 = val_36;
            }
            else
            {
                    val_37 = X4;
                val_43 = null;
                val_42 = 丘丒丐丟丏丄丌丒万.<>c.<>9__11_4;
                if(val_42 == null)
            {
                    System.Func<PGCompany.PixelPass.丁七业丂与业丒丑丈, System.Int32> val_26 = null;
                val_42 = val_26;
                val_26 = new System.Func<PGCompany.PixelPass.丁七业丂与业丒丑丈, System.Int32>(object:  丘丒丐丟丏丄丌丒万.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丘丒丐丟丏丄丌丒万.<>c::丝丈且丏与不丟丅丄(PGCompany.PixelPass.丁七业丂与业丒丑丈 丙丒七丄上与丏丙丙));
                丘丒丐丟丏丄丌丒万.<>c.<>9__11_4 = val_42;
            }
            
            }
            
            mem2[0] = System.Linq.Enumerable.Min<PGCompany.PixelPass.丁七业丂与业丒丑丈>(source:  val_28, selector:  val_26);
            val_38 = 1;
            return (bool)val_38;
        }
        internal static System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> 丙七丕东丅与丈三不(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, string 丞丁丑丏丄丏七丂不)
        {
            PGCompany.PixelPass.一万丄一丌丆业丐丅 val_8;
            var val_9;
            PGCompany.PixelPass.一万丄一丌丆业丐丅 val_10;
            丘丒丐丟丏丄丌丒万.丒丛丁与丅东丒不七 val_1 = new 丘丒丐丟丏丄丌丒万.丒丛丁与丅东丒不七();
            if(val_1 != null)
            {
                    .上且丗一丏丏万丅丌 = 上且丗一丏丏万丅丌;
            }
            else
            {
                    mem[16] = 上且丗一丏丏万丅丌;
            }
            
            .丞丁丑丏丄丏七丂不 = 丞丁丑丏丄丏七丂不;
            val_8 = 丈丂七世丟丞丂丗丒.三与上七业丟丞丙丛;
            if(((丈丂七世丟丞丂丗丒.三与上七业丟丞丙丛.<下丒丕丌业一世丙丞>k__BackingField) != null) && ((丈丂七世丟丞丂丗丒.三与上七业丟丞丙丛.<下丒丕丌业一世丙丞>k__BackingField.丈丐丞丐上丑且丕万()) != false))
            {
                    label_14:
                System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅> val_3 = null;
                val_9 = val_3;
                val_3 = new System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅>();
                val_10 = 丈丂七世丟丞丂丗丒.三与上七业丟丞丙丛;
                val_3.Add(item:  val_10);
                return (System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅>)val_9;
            }
            
            if(((丈丂七世丟丞丂丗丒.三与上七业丟丞丙丛.<下丒丕丌业一世丙丞>k__BackingField) != null) && ((丈丂七世丟丞丂丗丒.三与上七业丟丞丙丛.<下丒丕丌业一世丙丞>k__BackingField.丞专丅丁丁三丄上专()) != false))
            {
                    if(((丈丂七世丟丞丂丗丒.三与上七业丟丞丙丛.<下丒丕丌业一世丙丞>k__BackingField) == null) || ((丈丂七世丟丞丂丗丒.三与上七业丟丞丙丛.<下丒丕丌业一世丙丞>k__BackingField.丟万下专丟上业丁下()) == false))
            {
                goto label_14;
            }
            
            }
            
            val_10 = 丈丂七世丟丞丂丗丒.<丂且丂丄丞丒下万丙>k__BackingField;
            System.Predicate<PGCompany.PixelPass.一万丄一丌丆业丐丅> val_6 = null;
            val_8 = val_6;
            val_6 = new System.Predicate<PGCompany.PixelPass.一万丄一丌丆业丐丅>(object:  val_1, method:  System.Boolean 丘丒丐丟丏丄丌丒万.丒丛丁与丅东丒不七::一丂丝万不东丕且东(PGCompany.PixelPass.一万丄一丌丆业丐丅 万不且且丛丆东丒业));
            val_9 = val_10.FindAll(match:  val_6);
            return (System.Collections.Generic.List<PGCompany.PixelPass.一万丄一丌丆业丐丅>)val_9;
        }
        internal static void 下丒与丈世七丈丑丒(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒, GuiApplyersGroup 专与万丐七丌丐丁丂)
        {
            GuiApplyersGroup val_6 = 专与万丐七丌丐丁丂;
            if(val_6 == null)
            {
                    return;
            }
            
            if((丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏 != null) && (丈丂七世丟丞丂丗丒.世丂上丌丞且丁七丏.Common != null))
            {
                
            }
            
            val_6 = ???;
            goto typeof(GuiApplyersGroup).__il2cppRuntimeField_168;
        }
        internal static System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丁丒三丗丅专丏一丟(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
        {
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            List.Enumerator<T> val_2 = 丈丂七世丟丞丂丗丒.<丗东丏丛丄丈专一七>k__BackingField.GetEnumerator();
            label_6:
            if(((-78455144) & 1) == 0)
            {
                goto label_3;
            }
            
            val_1.AddRange(collection:  0.丐丏七丌丕丗业且上().丈丏丁东上与东丙丕());
            goto label_6;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        internal static System.Collections.Generic.List<PGCompany.PixelPass.东丄三下丄丈三丌丅> 丅丂业丈三丟丞万丏(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
        {
            var val_5;
            System.Collections.Generic.List<PGCompany.PixelPass.东丄三下丄丈三丌丅> val_21;
            var val_22;
            System.Collections.Generic.List<PGCompany.PixelPass.东丄三下丄丈三丌丅> val_1 = new System.Collections.Generic.List<PGCompany.PixelPass.东丄三下丄丈三丌丅>();
            System.Collections.Generic.Dictionary<System.Int32, PGCompany.PixelPass.东丄三下丄丈三丌丅> val_2 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.PixelPass.东丄三下丄丈三丌丅>();
            val_21 = 丈丂七世丟丞丂丗丒.<下三一丛业业东丌丅>k__BackingField;
            List.Enumerator<T> val_3 = val_21.GetEnumerator();
            label_22:
            if(((-78273552) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_6 = val_5.丐丏七丌丕丗业且上();
            if(val_6.丞七且三与丒丐东丆() == false)
            {
                goto label_22;
            }
            
            if(val_6.一丐专丂丈丏丕丛万() == 0)
            {
                goto label_7;
            }
            
            if((val_2.ContainsKey(key:  val_6.一丐专丂丈丏丕丛万())) != false)
            {
                    if(val_2.Item[val_6.一丐专丂丈丏丕丛万()].丏丘丑丈专丈丁丏世() <= val_6.丏丘丑丈专丈丁丏世())
            {
                goto label_22;
            }
            
            }
            
            if(val_6.丆丑一丑丄丌且丑丗() == false)
            {
                goto label_22;
            }
            
            val_2.set_Item(key:  val_6.一丐专丂丈丏丕丛万(), value:  val_6);
            goto label_22;
            label_7:
            val_1.Add(item:  val_6);
            goto label_22;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_2.Count < 1)
            {
                    return val_1;
            }
            
            val_1.AddRange(collection:  System.Linq.Enumerable.ToList<PGCompany.PixelPass.东丄三下丄丈三丌丅>(source:  val_2.Values));
            val_22 = null;
            val_22 = null;
            if((丘丒丐丟丏丄丌丒万.<>c.<>9__15_0) == null)
            {
                goto label_45;
            }
            
            label_50:
            val_1.Sort(comparison:  丘丒丐丟丏丄丌丒万.<>c.<>9__15_0);
            return val_1;
            label_45:
            丘丒丐丟丏丄丌丒万.<>c.<>9__15_0 = new System.Comparison<PGCompany.PixelPass.东丄三下丄丈三丌丅>(object:  丘丒丐丟丏丄丌丒万.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 丘丒丐丟丏丄丌丒万.<>c::下下丘东丈丒专丕不(PGCompany.PixelPass.东丄三下丄丈三丌丅 丙业丞丑七丗下丟丌, PGCompany.PixelPass.东丄三下丄丈三丌丅 万丙丑三丛丏丝丟与));
            if(val_1 != null)
            {
                goto label_50;
            }
            
            goto label_50;
        }
        internal static bool 丏不丁丒丁与丐丈丘(PGCompany.PixelPass.丙丙丕万东丘下丅丌 丈丂七世丟丞丂丗丒)
        {
            var val_10;
            if(丈丂七世丟丞丂丗丒.丏专上三三丒丙丙丌() < 1)
            {
                    return false;
            }
            
            if(PixelTime.丝业丁丌丘东丏世与() == false)
            {
                    return false;
            }
            
            bool val_3 = 丈丂七世丟丞丂丗丒.三丐丌丏专世丆丞丗();
            if(val_3 != false)
            {
                    return false;
            }
            
            if(丈丂七世丟丞丂丗丒 != null)
            {
                    val_10 = val_3.丏丑上三丝丑万丆与();
            }
            else
            {
                    val_10 = 0.丏丑上三丝丑万丆与();
            }
            
            var val_9 = (PixelTime.丝丗专上三不丄丑丑() >= ((丈丂七世丟丞丂丗丒.丏专上三三丒丙丙丌() + val_10) << )) ? 1 : 0;
            return false;
        }
    
    }

}
