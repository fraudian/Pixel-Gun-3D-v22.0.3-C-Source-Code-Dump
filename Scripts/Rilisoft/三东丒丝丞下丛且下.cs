using UnityEngine;

namespace Rilisoft
{
    internal class 三东丒丝丞下丛且下
    {
        // Fields
        private const string 丒且丕东丕且丆不丂 = "leaderboards_minigames";
        private static string 业丂与一三丆丟丁下;
        private const float 丁丐丅丝业下丅丗丈 = 1200;
        private static System.Collections.Generic.List<Rilisoft.LiderboardsMinigamesGameModeData> 业丅丛丏且丑丄业丙;
        private static System.Action 丏三丘万不丄一与丂;
        private static System.Collections.Generic.Dictionary<int, long> 业丐丅业一丛不丕丗;
        
        // Properties
        private static System.Collections.Generic.List<Rilisoft.LiderboardsMinigamesGameModeData> 丂业丄丟丛丑不丌丙 { get; set; }
        
        // Methods
        private static System.Collections.Generic.List<Rilisoft.LiderboardsMinigamesGameModeData> 丈万上丝丝东业不专()
        {
            string val_4;
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if(Rilisoft.三东丒丝丞下丛且下.业丅丛丏且丑丄业丙 == null)
            {
                    val_4 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "leaderboards_minigames", 丞丌丑丛上丕丙丕下:  System.String.alignConst);
                if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) != true)
            {
                    if((UnityEngine.JsonUtility.FromJson<Rilisoft.LiderboardsMinigamesDataHandler>(json:  val_4)) != null)
            {
                    val_6 = null;
                val_6 = null;
                Rilisoft.三东丒丝丞下丛且下.业丅丛丏且丑丄业丙 = val_3.Data;
            }
            
            }
            
            }
            
            val_7 = null;
            val_7 = null;
            return (System.Collections.Generic.List<Rilisoft.LiderboardsMinigamesGameModeData>)Rilisoft.三东丒丝丞下丛且下.业丅丛丏且丑丄业丙;
        }
        private static void 丆上三不丁丛丞丕与(System.Collections.Generic.List<Rilisoft.LiderboardsMinigamesGameModeData> 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.三东丒丝丞下丛且下.业丅丛丏且丑丄业丙 = 丙业与丙丗丝不丈东;
        }
        internal static System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow> 丙丘丝七业丟丁与丛(Rilisoft.七丕丟丏三丈一丄世 上且丗一丏丏万丅丌, Rilisoft.丄丄丑丒丐上丞万下 丁丅丈丌丟世丗丗丟)
        {
            System.Collections.Generic.IEnumerable<TSource> val_7;
            System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow> val_8;
            .上且丗一丏丏万丅丌 = 上且丗一丏丏万丅丌;
            val_7 = 1152921505464672256;
            if(Rilisoft.三东丒丝丞下丛且下.丈万上丝丝东业不专() != null)
            {
                    val_7 = Rilisoft.三东丒丝丞下丛且下.丈万上丝丝东业不专();
                if((System.Linq.Enumerable.FirstOrDefault<Rilisoft.LiderboardsMinigamesGameModeData>(source:  val_7, predicate:  new System.Func<Rilisoft.LiderboardsMinigamesGameModeData, System.Boolean>(object:  new 三东丒丝丞下丛且下.丒丑万一丁丕东一丗(), method:  System.Boolean 三东丒丝丞下丛且下.丒丑万一丁丕东一丗::与世丌丏三专丐丞丕(Rilisoft.LiderboardsMinigamesGameModeData 丐丆丂丒丁万丈丛丅)))) != null)
            {
                    if(丁丅丈丌丟世丗丗丟 == 1)
            {
                    return (System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow>)val_8;
            }
            
                if(丁丅丈丌丟世丗丗丟 == 0)
            {
                    val_8 = val_5.Friends;
                return (System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow>)val_8;
            }
            
            }
            
            }
            
            System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow> val_6 = null;
            val_8 = val_6;
            val_6 = new System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow>();
            return (System.Collections.Generic.List<Rilisoft.LeaderboardsMiniGameDataRow>)val_8;
        }
        internal static void 丘丄丅丛丏丕丒丆丞(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  Rilisoft.三东丒丝丞下丛且下.丏三丘万不丄一与丂, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.三东丒丝丞下丛且下.丏三丘万不丄一与丂 != 1152921505464676368);
        
        }
        internal static void 丕丞上丅丞丁丌丕丐(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  Rilisoft.三东丒丝丞下丛且下.丏三丘万不丄一与丂, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(Rilisoft.三东丒丝丞下丛且下.丏三丘万不丄一与丂 != 1152921505464676368);
        
        }
        internal static void 丏丑万丌丘万三丙与(System.Nullable<Rilisoft.七丕丟丏三丈一丄世> 上且丗一丏丏万丅丌)
        {
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            long val_12;
            var val_13;
            var val_14;
            if(Rilisoft.三东丒丝丞下丛且下.丈万上丝丝东业不专() != null)
            {
                    if(((-244741816) & 1) == 0)
            {
                    return;
            }
            
            }
            
            System.Collections.Generic.List<Rilisoft.LiderboardsMinigamesGameModeData> val_2 = Rilisoft.三东丒丝丞下丛且下.丈万上丝丝东业不专();
            if(((-244741816) & 1) != 0)
            {
                    val_8;
            }
            else
            {
                    val_8 = 0;
            }
            
            val_9 = null;
            val_9 = null;
            val_10 = null;
            if((Rilisoft.三东丒丝丞下丛且下.业丐丅业一丛不丕丗.ContainsKey(key:  0)) != false)
            {
                    val_11 = null;
                val_12 = 1152921505065418752;
                float val_8 = 1200f;
                val_8 = (float)Rilisoft.三东丒丝丞下丛且下.业丐丅业一丛不丕丗.Item[0] + val_8;
                if(val_8 > (float)FriendsController.丝丗专上三不丄丑丑())
            {
                    return;
            }
            
                val_13 = null;
                val_13 = null;
                val_12 = FriendsController.丝丗专上三不丄丑丑();
                Rilisoft.三东丒丝丞下丛且下.业丐丅业一丛不丕丗.set_Item(key:  0, value:  val_12);
            }
            else
            {
                    val_14 = null;
                val_12 = FriendsController.丝丗专上三不丄丑丑();
                Rilisoft.三东丒丝丞下丛且下.业丐丅业一丛不丕丗.Add(key:  0, value:  val_12);
            }
            
            Rilisoft.三东丒丝丞下丛且下.丝东丌丏丂世丁三丑(上且丗一丏丏万丅丌:  0);
        }
        private static void 丝东丌丏丂世丁三丑(int 上且丗一丏丏万丅丌)
        {
            System.Collections.Generic.Dictionary<K, V> val_10;
            var val_11;
            .上且丗一丏丏万丅丌 = 上且丗一丏丏万丅丌;
            val_10 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance;
            if(val_10.丕且一与专丘丄上上() == false)
            {
                    return;
            }
            
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_4 = null;
            val_10 = val_4;
            val_4 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            丞东丑专丛丆丄丝世.丌丁世丙丕丆丗丗世<System.Object, System.Object>(丏丂万业丙专丏丒丒:  val_4, 丞三丕世业三丒丅三:  new System.Func<System.Boolean>(object:  new 三东丒丝丞下丛且下.世东丒与丞七不不东(), method:  System.Boolean 三东丒丝丞下丛且下.世东丒与丞七不不东::丝三丕丏与丙专七万()), 下上丐丆丝丟丝丒不:  "mode", 丙业与丙丗丝不丈东:  (三东丒丝丞下丛且下.世东丒与丞七不不东)[1152921543017009888].上且丗一丏丏万丅丌);
            val_4.set_Item(key:  "platform", value:  ProtocolListGetter.丅三专丐丗丅与丆丑());
            val_11 = null;
            val_11 = null;
            int val_9 = Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丌丝丅下丂丗丁丙且, 一丐丗丁丞丆丅丟丄:  val_4, 业丏丈世世世丞丒世:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  0, 丛丌丙世专世东丕下:  static System.Void Rilisoft.三东丒丝丞下丛且下::不一丈丝下丛东丌丁(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        }
        private static void 不一丈丝下丛东丌丁(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            object val_9;
            System.Collections.Generic.IDictionary<System.String, System.Object> val_24;
            string val_25;
            string val_26;
            string val_27;
            val_24 = 丑与丂丌世丕丆一丗;
            if((val_24.ContainsKey(key:  "err_code")) == true)
            {
                    return;
            }
            
            string val_2 = 0;
            bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.String>(丏丂万业丙专丏丒丒:  val_24, 下上丐丆丝丟丝丒不:  "data", 丙业与丙丗丝不丈东: out  val_2);
            System.Collections.Generic.List<Rilisoft.LiderboardsMinigamesGameModeData> val_4 = Rilisoft.三东丒丝丞下丛且下.丁丂上东专与丈与一(三且丌不丛丂丙世丞:  val_2);
            if(val_4 == null)
            {
                goto label_7;
            }
            
            if(val_4.Count == 0)
            {
                goto label_8;
            }
            
            if(Rilisoft.三东丒丝丞下丛且下.丈万上丝丝东业不专() == null)
            {
                goto label_44;
            }
            
            List.Enumerator<T> val_7 = val_4.GetEnumerator();
            label_23:
            if(((-244359520) & 1) == 0)
            {
                goto label_12;
            }
            
            new 三东丒丝丞下丛且下.丌丟丘丏丕丅七万丕() = new System.Object();
            .丐丂与三丁丅东丂丈 = val_9.丐丏七丌丕丗业且上();
            System.Func<Rilisoft.LiderboardsMinigamesGameModeData, System.Boolean> val_13 = new System.Func<Rilisoft.LiderboardsMinigamesGameModeData, System.Boolean>(object:  new 三东丒丝丞下丛且下.丌丟丘丏丕丅七万丕(), method:  System.Boolean 三东丒丝丞下丛且下.丌丟丘丏丕丅七万丕::业丄丑丆下丛七上七(Rilisoft.LiderboardsMinigamesGameModeData 丐丆丂丒丁万丈丛丅));
            Rilisoft.LiderboardsMinigamesGameModeData val_14 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.LiderboardsMinigamesGameModeData>(source:  Rilisoft.三东丒丝丞下丛且下.丈万上丝丝东业不专(), predicate:  null);
            if(val_14 != null)
            {
                    bool val_16 = Rilisoft.三东丒丝丞下丛且下.丈万上丝丝东业不专().Remove(item:  val_14);
            }
            
            Rilisoft.三东丒丝丞下丛且下.丈万上丝丝东业不专().Add(item:  (三东丒丝丞下丛且下.丌丟丘丏丕丅七万丕)[1152921543017257728].丐丂与三丁丅东丂丈);
            goto label_23;
            label_7:
            val_25 = val_2;
            val_26 = "LeaderboardsMiniGameDataManager: parse responce \'";
            val_27 = "\' error: parsed result is null";
            goto label_24;
            label_8:
            val_25 = val_2;
            val_26 = "LeaderboardsMiniGameDataManager: parse responce \'";
            val_27 = "\' error: parsed result is empty";
            label_24:
            val_24 = val_26 + val_25 + val_27;
            UnityEngine.Debug.LogWarning(message:  val_24);
            return;
            label_12:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            goto label_28;
            label_44:
            Rilisoft.三东丒丝丞下丛且下.丆上三不丁丛丞丕与(丙业与丙丗丝不丈东:  val_9);
            label_28:
            .Data = Rilisoft.三东丒丝丞下丛且下.丈万上丝丝东业不专();
            val_24 = UnityEngine.JsonUtility.ToJson(obj:  new Rilisoft.LiderboardsMinigamesDataHandler());
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "leaderboards_minigames", 下下丏一丙不丘丌丞:  val_24);
            if(Rilisoft.三东丒丝丞下丛且下.丏三丘万不丄一与丂 == null)
            {
                    return;
            }
            
            Rilisoft.三东丒丝丞下丛且下.丏三丘万不丄一与丂.Invoke();
        }
        private static System.Collections.Generic.List<Rilisoft.LiderboardsMinigamesGameModeData> 丁丂上东专与丈与一(string 三且丌不丛丂丙世丞)
        {
            var val_10;
            var val_17;
            int val_52;
            var val_53;
            System.Func<System.Object, System.Collections.Generic.Dictionary<System.String, System.Object>> val_55;
            var val_56;
            var val_57;
            var val_59;
            var val_61;
            var val_63;
            var val_65;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            int val_72;
            Rilisoft.LiderboardsMinigamesGameModeData val_73;
            var val_74;
            val_52 = 三且丌不丛丂丙世丞;
            System.Collections.Generic.List<Rilisoft.LiderboardsMinigamesGameModeData> val_1 = new System.Collections.Generic.List<Rilisoft.LiderboardsMinigamesGameModeData>();
            if(val_52 == null)
            {
                    val_52 = System.String.alignConst;
            }
            
            object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_52);
            if(val_2 == null)
            {
                    return val_1;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_3 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
            if((val_3.ContainsKey(key:  "best_players")) == false)
            {
                goto label_14;
            }
            
            val_53 = null;
            val_53 = null;
            val_55 = 三东丒丝丞下丛且下.<>c.<>9__15_0;
            if(val_55 == null)
            {
                    System.Func<System.Object, System.Collections.Generic.Dictionary<System.String, System.Object>> val_5 = null;
                val_55 = val_5;
                val_5 = new System.Func<System.Object, System.Collections.Generic.Dictionary<System.String, System.Object>>(object:  三东丒丝丞下丛且下.<>c.__il2cppRuntimeField_static_fields, method:  System.Collections.Generic.Dictionary<System.String, System.Object> 三东丒丝丞下丛且下.<>c::丞丟丐丈丘丟丘丟丑(object 丄三丅七丆丛与与上));
                三东丒丝丞下丛且下.<>c.<>9__15_0 = val_55;
            }
            
            System.Collections.Generic.Dictionary<System.String, System.Object> val_6 = 丞东丑专丛丆丄丝世.且丒丁丟上丒丘专且<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  val_3, 丒丘丏上丙丟丑丕丈:  "best_players", 万一一丈丆与不七下:  val_5, 不丐不丕东东丏丄专:  false);
            if(val_6 == null)
            {
                goto label_14;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_7 = val_6.GetEnumerator();
            val_56 = 0;
            var val_51 = 0;
            label_82:
            if(((-244047760) & 1) == 0)
            {
                goto label_15;
            }
            
            ConfiguredValueTaskAwaiter val_11 = val_10.GetAwaiter();
            new Rilisoft.LiderboardsMinigamesGameModeData() = new Rilisoft.LiderboardsMinigamesGameModeData();
            .GameMode = Rilisoft.三东丒丝丞下丛且下.三丂丈丛下下丒一丈(丄三丅七丆丛与与上:  val_11._value._obj.丐丏七丌丕丗业且上());
            val_1.Add(item:  new Rilisoft.LiderboardsMinigamesGameModeData());
            if(val_11._value._obj == 0)
            {
                goto label_82;
            }
            
            List.Enumerator<T> val_15 = val_11._value._obj.GetEnumerator();
            label_58:
            if(((-244047808) & 1) == 0)
            {
                goto label_23;
            }
            
            string val_18 = val_17.丐丏七丌丕丗业且上();
            if(val_18 == null)
            {
                goto label_58;
            }
            
            new Rilisoft.LeaderboardsMiniGameDataRow() = new Rilisoft.LeaderboardsMiniGameDataRow();
            val_57 = null;
            val_57 = null;
            if((三东丒丝丞下丛且下.<>c.<>9__15_1) == null)
            {
                    System.Func<System.Object, System.Int32> val_20 = new System.Func<System.Object, System.Int32>(object:  三东丒丝丞下丛且下.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 三东丒丝丞下丛且下.<>c::丑丁一不丟丒丙丒丞(object 丄三丅七丆丛与与上));
                三东丒丝丞下丛且下.<>c.<>9__15_1 = null;
            }
            
            mem[1152921543017581808] = 丞东丑专丛丆丄丝世.且丒丁丟上丒丘专且<System.Int32>(丏丂万业丙专丏丒丒:  val_18, 丒丘丏上丙丟丑丕丈:  "id", 万一一丈丆与不七下:  null, 不丐不丕东东丏丄专:  false);
            val_59 = null;
            val_59 = null;
            if((三东丒丝丞下丛且下.<>c.<>9__15_2) == null)
            {
                    System.Func<System.Object, System.Int32> val_22 = new System.Func<System.Object, System.Int32>(object:  三东丒丝丞下丛且下.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 三东丒丝丞下丛且下.<>c::三下丏万丘丘万丙世(object 丄三丅七丆丛与与上));
                三东丒丝丞下丛且下.<>c.<>9__15_2 = null;
            }
            
            mem[1152921543017581824] = 丞东丑专丛丆丄丝世.且丒丁丟上丒丘专且<System.Int32>(丏丂万业丙专丏丒丒:  val_18, 丒丘丏上丙丟丑丕丈:  "rank", 万一一丈丆与不七下:  null, 不丐不丕东东丏丄专:  false);
            val_61 = null;
            val_61 = null;
            if((三东丒丝丞下丛且下.<>c.<>9__15_3) == null)
            {
                    System.Func<System.Object, System.Int32> val_24 = new System.Func<System.Object, System.Int32>(object:  三东丒丝丞下丛且下.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 三东丒丝丞下丛且下.<>c::丞三与丈丄丐丞丙丙(object 丄三丅七丆丛与与上));
                三东丒丝丞下丛且下.<>c.<>9__15_3 = null;
            }
            
            mem[1152921543017581828] = 丞东丑专丛丆丄丝世.且丒丁丟上丒丘专且<System.Int32>(丏丂万业丙专丏丒丒:  val_18, 丒丘丏上丙丟丑丕丈:  "scores", 万一一丈丆与不七下:  null, 不丐不丕东东丏丄专:  false);
            val_63 = null;
            val_63 = null;
            if((三东丒丝丞下丛且下.<>c.<>9__15_4) == null)
            {
                    System.Func<System.Object, System.String> val_26 = new System.Func<System.Object, System.String>(object:  三东丒丝丞下丛且下.<>c.__il2cppRuntimeField_static_fields, method:  System.String 三东丒丝丞下丛且下.<>c::丒万万丂与下七且丆(object 丄三丅七丆丛与与上));
                三东丒丝丞下丛且下.<>c.<>9__15_4 = null;
            }
            
            mem[1152921543017581816] = 丞东丑专丛丆丄丝世.且丒丁丟上丒丘专且<System.String>(丏丂万业丙专丏丒丒:  val_18, 丒丘丏上丙丟丑丕丈:  "nick", 万一一丈丆与不七下:  null, 不丐不丕东东丏丄专:  false);
            (Rilisoft.LiderboardsMinigamesGameModeData)[1152921543017573600].BestPlayers.Add(item:  new Rilisoft.LeaderboardsMiniGameDataRow());
            goto label_58;
            label_23:
            val_51 = val_51 + 1;
            mem2[0] = 465;
            val_65 = val_56;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_51 == 1) || ((1152921543017504704 + ((0 + 1)) << 2) != 465))
            {
                goto label_79;
            }
            
            var val_52 = 0;
            val_52 = val_52 ^ (val_51 >> 31);
            val_51 = val_51 + val_52;
            goto label_82;
            label_79:
            if( == 0)
            {
                goto label_82;
            }
            
            goto label_82;
            label_14:
            val_68 = 0;
            val_69 = 0;
            val_70 = 0;
            label_180:
            label_179:
            if((val_3.ContainsKey(key:  "friends")) == false)
            {
                    return val_1;
            }
            
            object val_29 = val_3.Item["friends"];
            if(val_29 == null)
            {
                    return val_1;
            }
            
            val_3 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.List<T>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_29) : 0;
            List.Enumerator<T> val_30 = val_3.GetEnumerator();
            label_96:
            if(((-244047808) & 1) == 0)
            {
                goto label_92;
            }
            
            string val_31 = val_10.丐丏七丌丕丗业且上();
            val_71 = 1;
            if((0.ContainsKey(key:  "id")) == false)
            {
                goto label_96;
            }
            
            val_72 = System.String.alignConst;
            if((0.ContainsKey(key:  "name")) != false)
            {
                    val_72 = 0.Item["name"];
            }
            
            Dictionary.Enumerator<TKey, TValue> val_37 = 0.GetEnumerator();
            label_119:
            if(((-244047760) & 1) == 0)
            {
                goto label_105;
            }
            
            ConfiguredValueTaskAwaiter val_38 = val_10.GetAwaiter();
            new 三东丒丝丞下丛且下.丕丛业丁丏下一七丘() = new System.Object();
            if(((System.String.op_Equality(a:  val_38._value._obj.丐丏七丌丕丗业且上(), b:  "id")) == true) || ((System.String.op_Equality(a:  val_38._value._obj.丐丏七丌丕丗业且上(), b:  "name")) == true))
            {
                goto label_119;
            }
            
            .上且丗一丏丏万丅丌 = Rilisoft.三东丒丝丞下丛且下.三丂丈丛下下丒一丈(丄三丅七丆丛与与上:  val_38._value._obj.丐丏七丌丕丗业且上());
            System.Func<Rilisoft.LiderboardsMinigamesGameModeData, System.Boolean> val_46 = new System.Func<Rilisoft.LiderboardsMinigamesGameModeData, System.Boolean>(object:  new 三东丒丝丞下丛且下.丕丛业丁丏下一七丘(), method:  System.Boolean 三东丒丝丞下丛且下.丕丛业丁丏下一七丘::且丞丏丅三专丂丟业(Rilisoft.LiderboardsMinigamesGameModeData 丐丆丂丒丁万丈丛丅));
            val_73 = System.Linq.Enumerable.FirstOrDefault<Rilisoft.LiderboardsMinigamesGameModeData>(source:  val_1, predicate:  null);
            if(val_73 == null)
            {
                    val_73 = new Rilisoft.LiderboardsMinigamesGameModeData();
                val_73 = new Rilisoft.LiderboardsMinigamesGameModeData();
                .GameMode = (三东丒丝丞下丛且下.丕丛业丁丏下一七丘)[1152921543017626848].上且丗一丏丏万丅丌;
                val_1.Add(item:  new Rilisoft.LiderboardsMinigamesGameModeData());
            }
            
            new Rilisoft.LeaderboardsMiniGameDataRow() = new Rilisoft.LeaderboardsMiniGameDataRow();
            .Id = Rilisoft.三东丒丝丞下丛且下.三丂丈丛下下丒一丈(丄三丅七丆丛与与上:  0.Item["id"]);
            .Scores = Rilisoft.三东丒丝丞下丛且下.三丂丈丛下下丒一丈(丄三丅七丆丛与与上:  val_38._value._obj);
            .PlayerName = val_72;
            (Rilisoft.LiderboardsMinigamesGameModeData)[1152921543017651424].Friends.Add(item:  new Rilisoft.LeaderboardsMiniGameDataRow());
            goto label_119;
            label_105:
            val_70 = val_70 + 1;
            mem2[0] = 863;
            val_74 = val_69;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_70 == 1) || ((1152921543017504704 + ((val_70 + 1)) << 2) != 863))
            {
                goto label_141;
            }
            
            var val_53 = 0;
            val_53 = val_53 ^ (val_70 >> 31);
            val_70 = val_70 + val_53;
            goto label_96;
            label_141:
            if( == 0)
            {
                goto label_96;
            }
            
            goto label_96;
            label_15:
            val_51 = val_51 + 1;
            mem2[0] = 493;
            goto label_145;
            label_92:
            val_70 = val_70 + 1;
            mem2[0] = 891;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_70 != 1)
            {
                    if( == 0)
            {
                    return val_1;
            }
            
                if((1152921543017504704 + ((val_70 + 1)) << 2) == 891)
            {
                    return val_1;
            }
            
                return val_1;
            }
            
            if( != 0)
            {
                    return val_1;
            }
            
            return val_1;
            label_145:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((val_70 == 1) || ((1152921543017504704 + ((val_70 + 1)) << 2) != 493))
            {
                goto label_173;
            }
            
            var val_54 = 0;
            val_54 = val_54 ^ (val_70 >> 31);
            val_70 = val_70 + val_54;
            if((public System.Boolean List.Enumerator<System.Object>::MoveNext()) != 0)
            {
                goto label_179;
            }
            
            goto label_180;
            label_173:
            if( == 0)
            {
                goto label_176;
            }
            
            if((public System.Boolean List.Enumerator<System.Object>::MoveNext()) != 0)
            {
                goto label_179;
            }
            
            goto label_180;
            label_176:
            if((public System.Boolean List.Enumerator<System.Object>::MoveNext()) != 0)
            {
                goto label_179;
            }
            
            goto label_180;
        }
        private static int 三丂丈丛下下丒一丈(object 丄三丅七丆丛与与上)
        {
            return System.Convert.ToInt32(value:  丄三丅七丆丛与与上, provider:  System.Globalization.CultureInfo.InvariantCulture);
        }
        public 三东丒丝丞下丛且下()
        {
        
        }
        private static 三东丒丝丞下丛且下()
        {
            Rilisoft.三东丒丝丞下丛且下.丁丐丅丝业下丅丗丈 = "{\"best_players\":{\"0\":[{\"nick\":\"The Gold Hazop\",\"rank\":17,\"id\":524937,\"scores\":999},{\"nick\":\"khight\",\"rank\":7,\"id\":997506,\"scores\":996}],\"1\":[{\"nick\":\"ricardnavascues\",\"rank\":17,\"id\":614937,\"scores\":998},{\"nick\":\"derpturtle\",\"rank\":27,\"id\":14317,\"scores\":995}]},\"friends\":[{\"id\":50862,\"0\":0,\"1\":0,\"2\":0,\"3\":0,\"4\":0,\"5\":0,\"6\":866},{\"id\":314399,\"0\":0,\"1\":0,\"2\":0,\"3\":856,\"4\":0,\"5\":0,\"6\":0}]}";
            Rilisoft.三东丒丝丞下丛且下.丁丐丅丝业下丅丗丈.__il2cppRuntimeField_3 = 268435464;
            Rilisoft.三东丒丝丞下丛且下.业丐丅业一丛不丕丗 = new System.Collections.Generic.Dictionary<System.Int32, System.Int64>();
        }
    
    }

}
