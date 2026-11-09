using UnityEngine;

namespace DataSystem.DataCollectors
{
    internal sealed class 万丕丒专万专万丙丏
    {
        // Methods
        internal static void 丆丐丈万世丈丗且与(PGCompany.GameConditionSettings 丄丒丑东下丛丗七与, System.Collections.Generic.Dictionary<string, string> 丛丛七丝丙丒丝业丙)
        {
            int val_9;
            int val_1 = System.String.alignConst;
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "ConditionType", value: out  val_1)) != false)
            {
                    val_9 = val_1;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_9)) != true)
            {
                    System.Nullable<T> val_4 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<PGCompany.不丝丐丅丄丝丙丌丘>(下业七不丑丂丏丟东:  val_1, 丏丅丗丌丌丞丌专丘:  0);
                val_9 = ;
                丄丒丑东下丛丗七与.Type = val_9;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "ConditionValue", value: out  val_1)) == false)
            {
                    return;
            }
            
            val_9 = 1152921505418293248;
            System.ValueTuple<System.Int32, System.Boolean> val_6 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_1);
            if(((ulong)(val_6.Item2 >> 32) & 255) == 0)
            {
                    return;
            }
            
            System.ValueTuple<System.Int32, System.Boolean> val_7 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_1);
            Rilisoft.丝丑丂丛万丐丈丘且 val_8 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_7.Item2);
            val_9 = val_8.上万三丆专丏丒丗业;
            丄丒丑东下丛丗七与.RequiredValue = val_8;
            mem2[0] = val_9;
        }
        internal static void 丌丐丙下业丌丗丒丘(PGCompany.丌不丞丐世丞三丘丌 三丆业丘万与丄丏业, System.Collections.Generic.Dictionary<string, string> 丛丛七丝丙丒丝业丙)
        {
            int val_22;
            int val_1 = System.String.alignConst;
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "TransitionType", value: out  val_1)) == false)
            {
                goto label_2;
            }
            
            val_22 = val_1;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_22)) == false)
            {
                goto label_5;
            }
            
            label_2:
            if(三丆业丘万与丄丏业 != null)
            {
                goto label_7;
            }
            
            goto label_7;
            label_5:
            System.Nullable<T> val_4 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<PGCompany.丘丁丕丈丘且业三丄>(下业七不丑丂丏丟东:  val_1, 丏丅丗丌丌丞丌专丘:  0);
            val_22;
            三丆业丘万与丄丏业.Type = val_22;
            label_7:
            if(三丆业丘万与丄丏业.Type == 0)
            {
                    return;
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "GameMode", value: out  val_1)) != false)
            {
                    val_22 = val_1;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_22)) != true)
            {
                    val_22 = val_1;
                System.Nullable<T> val_7 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<Rilisoft.七丕丟丏三丈一丄世>(下业七不丑丂丏丟东:  val_22, 丏丅丗丌丌丞丌专丘:  100);
                三丆业丘万与丄丏业.GameMode = val_7.HasValue;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "GameModeGroup", value: out  val_1)) != false)
            {
                    val_22 = val_1;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_22)) != true)
            {
                    val_22 = val_1;
                System.Nullable<T> val_10 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<PGCompany.GameModeHub.丕业丞七丄七丒万东>(下业七不丑丂丏丟东:  val_22, 丏丅丗丌丌丞丌专丘:  0);
                三丆业丘万与丄丏业.GameModeGroup = val_10.HasValue;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "ShopCategory", value: out  val_1)) != false)
            {
                    val_22 = val_1;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_22)) != true)
            {
                    val_22 = val_1;
                System.Nullable<T> val_13 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<CategoryNames>(下业七不丑丂丏丟东:  val_22, 丏丅丗丌丌丞丌专丘:  112);
                三丆业丘万与丄丏业.ShopCategory = val_13.HasValue;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "ItemCategory", value: out  val_1)) != false)
            {
                    val_22 = val_1;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_22)) != true)
            {
                    val_22 = val_1;
                System.Nullable<T> val_16 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<CategoryNames>(下业七不丑丂丏丟东:  val_22, 丏丅丗丌丌丞丌专丘:  112);
                三丆业丘万与丄丏业.ItemCategory = val_16.HasValue;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "IsBrawl", value: out  val_1)) == false)
            {
                    return;
            }
            
            val_22 = 1152921505418293248;
            System.ValueTuple<System.Boolean, System.Boolean> val_18 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
            if((val_18.Item2 & 65280) == false)
            {
                    return;
            }
            
            System.ValueTuple<System.Boolean, System.Boolean> val_20 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
            三丆业丘万与丄丏业.与丑丞与丅丈七丗丗(丙业与丙丗丝不丈东:  (val_20.Item2 != true) ? 1 : 0);
        }
        internal static void 七丌七丏丈丏上丏丝(PGCompany.GameTaskActionSettings 丗七丗丒丌三世丌丁, System.Collections.Generic.Dictionary<string, string> 丛丛七丝丙丒丝业丙)
        {
            int val_130;
            int val_1 = System.String.alignConst;
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "ActionType", value: out  val_1)) == false)
            {
                goto label_2;
            }
            
            val_130 = val_1;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_130)) == false)
            {
                goto label_5;
            }
            
            label_2:
            if(丗七丗丒丌三世丌丁 != null)
            {
                goto label_7;
            }
            
            goto label_7;
            label_5:
            System.Nullable<T> val_4 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<PGCompany.丒丘且上丟专东不丐>(下业七不丑丂丏丟东:  val_1, 丏丅丗丌丌丞丌专丘:  0);
            val_130;
            丗七丗丒丌三世丌丁.Type = val_130;
            label_7:
            if(丗七丗丒丌三世丌丁.Type == 0)
            {
                    return;
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "Points", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Int32, System.Boolean> val_6 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_1);
            }
            
            System.ValueTuple<System.Int32, System.Boolean> val_7 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_1);
            Rilisoft.丝丑丂丛万丐丈丘且 val_8 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_7.Item2);
            丗七丗丒丌三世丌丁.NeededCount = val_8;
            mem2[0] = val_8.上万三丆专丏丒丗业;
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "IntParam", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Int32, System.Boolean> val_10 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_1);
                if(((ulong)(val_10.Item2 >> 32) & 255) != 0)
            {
                    System.ValueTuple<System.Int32, System.Boolean> val_11 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_1);
                Rilisoft.丝丑丂丛万丐丈丘且 val_12 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_11.Item2);
                丗七丗丒丌三世丌丁.IntParam = val_12;
                mem2[0] = val_12.上万三丆专丏丒丗业;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "StrParam", value: out  val_1)) != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != true)
            {
                    丗七丗丒丌三世丌丁.StringParam = val_1;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "GameMode", value: out  val_1)) != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != true)
            {
                    System.Nullable<T> val_17 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<Rilisoft.七丕丟丏三丈一丄世>(下业七不丑丂丏丟东:  val_1, 丏丅丗丌丌丞丌专丘:  100);
                丗七丗丒丌三世丌丁.GameMode = val_17.HasValue;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "PerMatch", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_19 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                if((val_19.Item2 & 65280) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_21 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                丗七丗丒丌三世丌丁.PerMatch = (val_21.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "PerLife", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_24 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                if((val_24.Item2 & 65280) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_26 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                丗七丗丒丌三世丌丁.PerLife = (val_26.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "Map", value: out  val_1)) != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != true)
            {
                    丗七丗丒丌三世丌丁.Map = val_1;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "ShouldWin", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_31 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                if((val_31.Item2 & 65280) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_33 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                丗七丗丒丌三世丌丁.ShouldWin = (val_33.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "KillInHead", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_36 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                if((val_36.Item2 & 65280) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_38 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                丗七丗丒丌三世丌丁.KillInHead = (val_38.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "IsSelfInvisible", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_41 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                if((val_41.Item2 & 65280) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_43 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                丗七丗丒丌三世丌丁.IsSelfInvisible = (val_43.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "IsZoomShot", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_46 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                if((val_46.Item2 & 65280) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_48 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                丗七丗丒丌三世丌丁.IsZoomShot = (val_48.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "IsBrawl", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_51 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                if((val_51.Item2 & 65280) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_53 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                丗七丗丒丌三世丌丁.IsBrawl = (val_53.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "IsCompetition", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_56 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                if((val_56.Item2 & 65280) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_58 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                丗七丗丒丌三世丌丁.IsCompetition = (val_58.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "InParty", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_61 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                if((val_61.Item2 & 65280) != false)
            {
                    System.ValueTuple<System.Boolean, System.Boolean> val_63 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_1);
                丗七丗丒丌三世丌丁.InParty = (val_63.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "ItemIndex", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Int32, System.Boolean> val_66 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_1);
                if(((ulong)(val_66.Item2 >> 32) & 255) != 0)
            {
                    System.ValueTuple<System.Int32, System.Boolean> val_67 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_1);
                Rilisoft.丝丑丂丛万丐丈丘且 val_68 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_67.Item2);
                丗七丗丒丌三世丌丁.ItemIndex = val_68;
                mem2[0] = val_68.上万三丆专丏丒丗业;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "ItemCategory", value: out  val_1)) != false)
            {
                    if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != true)
            {
                    System.Nullable<T> val_71 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<CategoryNames>(下业七不丑丂丏丟东:  val_1, 丏丅丗丌丌丞丌专丘:  112);
                丗七丗丒丌三世丌丁.ItemCategory = val_71.HasValue;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "Rank", value: out  val_1)) != false)
            {
                    System.ValueTuple<System.Int32, System.Boolean> val_73 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_1);
            }
            
            val_130 = val_1;
            System.ValueTuple<System.Int32, System.Boolean> val_74 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_130);
            Rilisoft.丝丑丂丛万丐丈丘且 val_75 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_74.Item2);
            丗七丗丒丌三世丌丁.Rank = val_75;
            mem2[0] = val_75.上万三丆专丏丒丗业;
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "WeaponEffect", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_130)) != true)
            {
                    val_130 = val_1;
                System.Nullable<T> val_78 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<丈不三丛七丑丈丑丆>(下业七不丑丂丏丟东:  val_130, 丏丅丗丌丌丞丌专丘:  159);
                丗七丗丒丌三世丌丁.WeaponEffect = val_78.HasValue;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "ItemRarity", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_130)) != true)
            {
                    val_130 = val_1;
                System.Nullable<T> val_81 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<ItemRarity>(下业七不丑丂丏丟东:  val_130, 丏丅丗丌丌丞丌专丘:  0);
                Rilisoft.丝丑丂丛万丐丈丘且 val_82 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  -1164876248);
                丗七丗丒丌三世丌丁.ItemRarity = val_82;
                mem2[0] = val_82.上万三丆专丏丒丗业;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "IsNoArmor", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Boolean, System.Boolean> val_84 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_130);
                if((val_84.Item2 & 65280) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Boolean, System.Boolean> val_86 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_130);
                丗七丗丒丌三世丌丁.IsNoArmor = (val_86.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "Zone", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_130)) != true)
            {
                    丗七丗丒丌三世丌丁.Zone = val_1;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "EnemyInvisible", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Boolean, System.Boolean> val_91 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_130);
                if((val_91.Item2 & 65280) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Boolean, System.Boolean> val_93 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_130);
                丗七丗丒丌三世丌丁.EnemyInvisible = (val_93.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "NoDamage", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Boolean, System.Boolean> val_96 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_130);
                if((val_96.Item2 & 65280) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Boolean, System.Boolean> val_98 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_130);
                丗七丗丒丌三世丌丁.NoDamage = (val_98.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "NoDeath", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Boolean, System.Boolean> val_101 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_130);
                if((val_101.Item2 & 65280) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Boolean, System.Boolean> val_103 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_130);
                丗七丗丒丌三世丌丁.NoDeath = (val_103.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "NotTakingDamage", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Boolean, System.Boolean> val_106 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_130);
                if((val_106.Item2 & 65280) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Boolean, System.Boolean> val_108 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_130);
                丗七丗丒丌三世丌丁.NotTakingDamage = (val_108.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "NotTakingZoneDamage", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Boolean, System.Boolean> val_111 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_130);
                if((val_111.Item2 & 65280) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Boolean, System.Boolean> val_113 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.且丕丄丈丈丏丈世丝(万且万且丑丗且丌丆:  val_130);
                丗七丗丒丌三世丌丁.NotTakingZoneDamage = (val_113.Item2 != true) ? 1 : 0;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "InARow", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Int32, System.Boolean> val_116 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_130);
                if(((ulong)(val_116.Item2 >> 32) & 255) != 0)
            {
                    val_130 = val_1;
                System.ValueTuple<System.Int32, System.Boolean> val_117 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丈丛与上丆丏不丘不(万且万且丑丗且丌丆:  val_130);
                Rilisoft.丝丑丂丛万丐丈丘且 val_118 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  val_117.Item2);
                丗七丗丒丌三世丌丁.InARow = val_118;
                mem2[0] = val_118.上万三丆专丏丒丗业;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "WeaponSetId", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_130)) != true)
            {
                    丗七丗丒丌三世丌丁.WeaponSetId = val_1;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "ItemObtainPlace", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_130)) != true)
            {
                    val_130 = val_1;
                System.Nullable<T> val_123 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<丈下专丂丑不丑丗丁>(下业七不丑丂丏丟东:  val_130, 丏丅丗丌丌丞丌专丘:  0);
                丗七丗丒丌三世丌丁.ItemObtainPlace = val_123.HasValue;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "PixelPassTaskOpenType", value: out  val_1)) != false)
            {
                    val_130 = val_1;
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_130)) != true)
            {
                    val_130 = val_1;
                System.Nullable<T> val_126 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<PGCompany.PixelPass.丒且丏万业业七业万>(下业七不丑丂丏丟东:  val_130, 丏丅丗丌丌丞丌专丘:  0);
                丗七丗丒丌三世丌丁.PixelPassTaskOpenType = val_126.HasValue;
            }
            
            }
            
            if((丛丛七丝丙丒丝业丙.TryGetValue(key:  "Complexity", value: out  val_1)) == false)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) == true)
            {
                    return;
            }
            
            System.Nullable<T> val_129 = DataSystem.DataCollectors.丌丘丑业万且丛一丟.丅丅丝丟丒丛万丒丙<丐七不丝丆丐丂丐下>(下业七不丑丂丏丟东:  val_1, 丏丅丗丌丌丞丌专丘:  0);
            丗七丗丒丌三世丌丁.Complexity = ;
        }
        public 万丕丒专万专万丙丏()
        {
        
        }
    
    }

}
