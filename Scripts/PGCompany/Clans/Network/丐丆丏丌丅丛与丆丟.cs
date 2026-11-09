using UnityEngine;

namespace PGCompany.Clans.Network
{
    internal class 丐丆丏丌丅丛与丆丟
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.Clans.Network.丐丆丏丌丅丛与丆丟.业丁丐且且上与丞丏> 丝丘且且不丞丏丒丛;
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.Clans.Network.丐丆丏丌丅丛与丆丟.丅丛且丘三丙与丆三> 丁东丙丑上一丆丅专;
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.Clans.Network.丐丆丏丌丅丛与丆丟.下丙丒丂一丒一丒丒> 丑丄丏丙丆丞丄不三;
        
        // Methods
        internal 丐丆丏丌丅丛与丆丟()
        {
            var val_6;
            this.丁东丙丑上一丆丅专 = new System.Collections.Generic.Dictionary<System.Int32, 丅丛且丘三丙与丆三>();
            this.丑丄丏丙丆丞丄不三 = new System.Collections.Generic.Dictionary<System.Int32, 下丙丒丂一丒一丒丒>();
            this.丝丘且且不丞丏丒丛 = new System.Collections.Generic.Dictionary<System.Int32, 业丁丐且且上与丞丏>();
            val_6 = null;
            val_6 = null;
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丕且七丆丘七丁丄业, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.Clans.Network.丐丆丏丌丅丛与丆丟::丝丘专一专丟一丁丗(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丟且万丕丐丈且丆丑, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PGCompany.Clans.Network.丐丆丏丌丅丛与丆丟::上丞丌丅丄丛七丕丟(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        }
        private void 丝丘专一专丟一丁丗(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            System.Collections.Generic.Dictionary<System.Int32, 业丁丐且且上与丞丏> val_13;
            var val_14;
            int val_3 = 0;
            业丁丐且且上与丞丏 val_7 = 0;
            丅丛且丘三丙与丆三 val_5 = 0;
            bool val_2 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "req_id", 丙业与丙丗丝不丈东: out  0);
            bool val_4 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "err_code", 丙业与丙丗丝不丈东: out  val_3);
            bool val_6 = this.丁东丙丑上一丆丅专.TryGetValue(key:  0, value: out  val_5);
            bool val_8 = this.丝丘且且不丞丏丒丛.TryGetValue(key:  0, value: out  val_7);
            bool val_9 = this.丁东丙丑上一丆丅专.Remove(key:  0);
            val_13 = this.丝丘且且不丞丏丒丛;
            bool val_10 = val_13.Remove(key:  0);
            if(val_5 == 0)
            {
                    return;
            }
            
            if(val_7 == 0)
            {
                    return;
            }
            
            丐丆丏丌丅丛与丆丟.丛丄丒丟丛丏丘业丞 val_11 = null;
            val_13 = val_11;
            val_11 = new 丐丆丏丌丅丛与丆丟.丛丄丒丟丛丏丘业丞();
            .<一万丂丟不丛丟下世>k__BackingField = 11993091;
            val_14 = val_7;
            if(val_14 == 0)
            {
                goto label_11;
            }
            
            .<七专万丆上丝三丏丏>k__BackingField = 1;
            goto label_12;
            label_11:
            .<七专万丆上丝三丏丏>k__BackingField = 1;
            if(val_7 == 0)
            {
                goto label_13;
            }
            
            val_14 = val_7;
            label_12:
            .<丅丝专一下丑丙一与>k__BackingField = 28563616;
            label_15:
            .<丑与丆丞丑丐丂专业>k__BackingField = 0;
            .<业丌上一上丟丒丁三>k__BackingField = (val_3 == 0) ? 1 : 0;
            val_5.Invoke(东一丁世丑丞业丄丐:  val_11);
            return;
            label_13:
            .<丅丝专一下丑丙一与>k__BackingField = 28563616;
            if(val_7 != 0)
            {
                goto label_15;
            }
        
        }
        private void 上丞丌丅丄丛七丕丟(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            丒丌丝丆东上下下专 val_18;
            System.Collections.Generic.Dictionary<System.Int32, 业丁丐且且上与丞丏> val_19;
            int val_1 = 0;
            int val_3 = 0;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_5 = 0;
            int val_7 = 0;
            业丁丐且且上与丞丏 val_11 = 0;
            下丙丒丂一丒一丒丒 val_9 = 0;
            bool val_2 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "req_id", 丙业与丙丗丝不丈东: out  val_1);
            bool val_4 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "err_code", 丙业与丙丗丝不丈东: out  val_3);
            bool val_6 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Collections.Generic.Dictionary<System.String, System.Object>>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "upgrade_data", 丙业与丙丗丝不丈东: out  val_5);
            bool val_8 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丑与丂丌世丕丆一丗, 下上丐丆丝丟丝丒不:  "current_level", 丙业与丙丗丝不丈东: out  val_7);
            bool val_10 = this.丑丄丏丙丆丞丄不三.TryGetValue(key:  0, value: out  val_9);
            bool val_12 = this.丝丘且且不丞丏丒丛.TryGetValue(key:  0, value: out  val_11);
            val_18 = val_1;
            bool val_13 = this.丑丄丏丙丆丞丄不三.Remove(key:  0);
            val_19 = this.丝丘且且不丞丏丒丛;
            bool val_14 = val_19.Remove(key:  0);
            if(val_9 == 0)
            {
                    return;
            }
            
            if(val_11 == 0)
            {
                    return;
            }
            
            val_19 = val_7;
            val_18 = 丂与业丕丐专东东上.丒丌丝丆东上下下专.丅东东下丆不丟一三(一丐丗丁丞丆丅丟丄:  val_5);
            val_9.Invoke(东一丁世丑丞业丄丐:  val_18, 丐万丗丒下七丟丁三:  (val_3 == 0) ? 1 : 0, 业丁丁丕丆丛丕专且:  (val_3 != 1711) ? 1 : 0, 丟丝三不世与专且三:  0);
        }
        internal void 三世一丁丑丄丗丕丞(int 世上丅丙东丛一且丕, int 与丗丟丝丞上东且丞, int 丁丅丄丗不丁丟丈世, int 不世专丆丏丘三三上, PGCompany.Clans.Network.丐丆丏丌丅丛与丆丟.丅丛且丘三丙与丆三 业丏丈世世世丞丒世)
        {
            var val_11;
            var val_12;
            bool val_13;
            bool val_14;
            var val_15;
            PlaceableItemSettings val_1 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞世不丒下上上丝丑:  世上丅丙东丛一且丕);
            if(val_1 != null)
            {
                    val_11 = null;
                val_11 = null;
                val_12 = null;
                val_12 = null;
                val_13 = val_1.SupercategoryName.Equals(value:  PGCompany.丕万丞且丄丌丛一丒.丒丝丈丐与七且三丛);
                val_14 = val_1.SupercategoryName.Equals(value:  PGCompany.丕万丞且丄丌丛一丒.丗三与丞丝丞上业丄);
            }
            else
            {
                    val_13 = false;
                val_14 = false;
            }
            
            丐丆丏丌丅丛与丆丟.业丁丐且且上与丞丏 val_6 = new 丐丆丏丌丅丛与丆丟.业丁丐且且上与丞丏();
            if(val_6 != null)
            {
                    .<一万丂丟不丛丟下世>k__BackingField = 世上丅丙东丛一且丕;
                .<七专万丆上丝三丏丏>k__BackingField = 与丗丟丝丞上东且丞;
                .<丅丝专一下丑丙一与>k__BackingField = 丁丅丄丗不丁丟丈世;
                .<丑与丆丞丑丐丂专业>k__BackingField = 不世专丆丏丘三三上;
                .<且丈丄丒与万且万丆>k__BackingField = val_13;
            }
            else
            {
                    mem[16] = 世上丅丙东丛一且丕;
                .<七专万丆上丝三丏丏>k__BackingField = 与丗丟丝丞上东且丞;
                mem[24] = 丁丅丄丗不丁丟丈世;
                .<丑与丆丞丑丐丂专业>k__BackingField = 不世专丆丏丘三三上;
                val_15 = 0;
                mem[32] = val_13;
            }
            
            .<丐丒丅丒一丅七丐一>k__BackingField = val_14;
            int val_7 = this.三世一丁丑丄丗丕丞(丙丁丌丛业不丄丝丈:  val_6);
            if((val_7 & 2147483648) == 0)
            {
                    this.丝丘且且不丞丏丒丛.set_Item(key:  val_7, value:  val_6);
                this.丁东丙丑上一丆丅专.set_Item(key:  val_7, value:  业丏丈世世世丞丒世);
                return;
            }
            
            丐丆丏丌丅丛与丆丟.丛丄丒丟丛丏丘业丞 val_8 = new 丐丆丏丌丅丛与丆丟.丛丄丒丟丛丏丘业丞();
            if(val_8 != null)
            {
                    .<一万丂丟不丛丟下世>k__BackingField = 世上丅丙东丛一且丕;
                .<七专万丆上丝三丏丏>k__BackingField = 与丗丟丝丞上东且丞;
                .<丅丝专一下丑丙一与>k__BackingField = 丁丅丄丗不丁丟丈世;
                .<丑与丆丞丑丐丂专业>k__BackingField = 不世专丆丏丘三三上;
            }
            else
            {
                    .<一万丂丟不丛丟下世>k__BackingField = 世上丅丙东丛一且丕;
                mem[24] = 与丗丟丝丞上东且丞;
                .<丅丝专一下丑丙一与>k__BackingField = 丁丅丄丗不丁丟丈世;
                mem[32] = 不世专丆丏丘三三上;
            }
            
            .<业丌上一上丟丒丁三>k__BackingField = false;
            业丏丈世世世丞丒世.Invoke(东一丁世丑丞业丄丐:  val_8);
        }
        internal void 万与且东东丅业丛与(int 丞世不丒下上上丝丑, int 与丗丟丝丞上东且丞, int 丁丅丄丗不丁丟丈世, PGCompany.三东丏不丗世丅丌丄 丒世丘丘上丆丝东丞, Progress.丂与业丕丐专东东上.丒丌丝丆东上下下专 上丆东丝业万丟丆丑, PGCompany.Clans.Network.丐丆丏丌丅丛与丆丟.下丙丒丂一丒一丒丒 业丏丈世世世丞丒世)
        {
            var val_3;
            丐丆丏丌丅丛与丆丟.业丁丐且且上与丞丏 val_1 = new 丐丆丏丌丅丛与丆丟.业丁丐且且上与丞丏();
            if(val_1 != null)
            {
                    .<一万丂丟不丛丟下世>k__BackingField = 丞世不丒下上上丝丑;
                .<七专万丆上丝三丏丏>k__BackingField = 与丗丟丝丞上东且丞;
                .<丅丝专一下丑丙一与>k__BackingField = 丁丅丄丗不丁丟丈世;
            }
            else
            {
                    mem[16] = 丞世不丒下上上丝丑;
                .<七专万丆上丝三丏丏>k__BackingField = 与丗丟丝丞上东且丞;
                val_3 = 0;
                mem[24] = 丁丅丄丗不丁丟丈世;
            }
            
            .<丑七不丛一丁世丏业>k__BackingField = 丒世丘丘上丆丝东丞;
            int val_2 = this.下世丆丂丑万一丘丕(丙丁丌丛业不丄丝丈:  val_1, 上丆东丝业万丟丆丑:  上丆东丝业万丟丆丑);
            if((val_2 & 2147483648) != 0)
            {
                    return;
            }
            
            this.丝丘且且不丞丏丒丛.set_Item(key:  val_2, value:  val_1);
            this.丑丄丏丙丆丞丄不三.set_Item(key:  val_2, value:  业丏丈世世世丞丒世);
        }
        private int 三世一丁丑丄丗丕丞(PGCompany.Clans.Network.丐丆丏丌丅丛与丆丟.业丁丐且且上与丞丏 丙丁丌丛业不丄丝丈)
        {
            var val_10;
            丐丆丏丌丅丛与丆丟.丒丛丁与丅东丒不七 val_1 = new 丐丆丏丌丅丛与丆丟.丒丛丁与丅东丒不七();
            .丙丁丌丛业不丄丝丈 = 丙丁丌丛业不丄丝丈;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_2 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_2.set_Item(key:  "item_index", value:  (丐丆丏丌丅丛与丆丟.丒丛丁与丅东丒不七)[1152921559888499424].丙丁丌丛业不丄丝丈.<一万丂丟不丛丟下世>k__BackingField);
            val_2.set_Item(key:  "from_level", value:  (丐丆丏丌丅丛与丆丟.丒丛丁与丅东丒不七)[1152921559888499424].丙丁丌丛业不丄丝丈.<七专万丆上丝三丏丏>k__BackingField);
            val_2.set_Item(key:  "to_level", value:  (丐丆丏丌丅丛与丆丟.丒丛丁与丅东丒不七)[1152921559888499424].丙丁丌丛业不丄丝丈.<丅丝专一下丑丙一与>k__BackingField);
            val_2.set_Item(key:  "finish_at", value:  (丐丆丏丌丅丛与丆丟.丒丛丁与丅东丒不七)[1152921559888499424].丙丁丌丛业不丄丝丈.<丑与丆丞丑丐丂专业>k__BackingField);
            val_2.set_Item(key:  "clan_id", value:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丁丈丞一专下丛丕三());
            丞东丑专丛丆丄丝世.丌丁世丙丕丆丗丗世<System.Object, System.Object>(丏丂万业丙专丏丒丒:  val_2, 丞三丕世业三丒丅三:  new System.Func<System.Boolean>(object:  val_1, method:  System.Boolean 丐丆丏丌丅丛与丆丟.丒丛丁与丅东丒不七::不与丐业丝丛万丌与()), 下上丐丆丝丟丝丒不:  "item_type", 丙业与丙丗丝不丈东:  1);
            丞东丑专丛丆丄丝世.丌丁世丙丕丆丗丗世<System.Object, System.Object>(丏丂万业丙专丏丒丒:  val_2, 丞三丕世业三丒丅三:  new System.Func<System.Boolean>(object:  val_1, method:  System.Boolean 丐丆丏丌丅丛与丆丟.丒丛丁与丅东丒不七::丘七万丟与丐三丌丕()), 下上丐丆丝丟丝丒不:  "item_type", 丙业与丙丗丝不丈东:  2);
            val_10 = null;
            val_10 = null;
            return (int)Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丕且七丆丘七丁丄业, 一丐丗丁丞丆丅丟丄:  val_2);
        }
        private int 下世丆丂丑万一丘丕(PGCompany.Clans.Network.丐丆丏丌丅丛与丆丟.业丁丐且且上与丞丏 丙丁丌丛业不丄丝丈, Progress.丂与业丕丐专东东上.丒丌丝丆东上下下专 上丆东丝业万丟丆丑)
        {
            var val_10;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Object, System.Object>();
            val_1.set_Item(key:  "item_index", value:  丙丁丌丛业不丄丝丈.<一万丂丟不丛丟下世>k__BackingField);
            val_1.set_Item(key:  "from_level", value:  丙丁丌丛业不丄丝丈.<七专万丆上丝三丏丏>k__BackingField);
            val_1.set_Item(key:  "to_level", value:  丙丁丌丛业不丄丝丈.<丅丝专一下丑丙一与>k__BackingField);
            val_1.set_Item(key:  "upgrade_data", value:  上丆东丝业万丟丆丑.丏东丐丗丘下专丅上());
            if((丙丁丌丛业不丄丝丈.<丑七不丛一丁世丏业>k__BackingField) != null)
            {
                    val_1.set_Item(key:  "price", value:  丙丁丌丛业不丄丝丈.<丑七不丛一丁世丏业>k__BackingField.丂丁丏一丙丛业且丌().ToString());
            }
            
            val_1.set_Item(key:  "clan_id", value:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丁丈丞一专下丛丕三());
            val_10 = null;
            val_10 = null;
            return (int)Rilisoft.Singleton<Rilisoft.WebSocket.WebSocketManager>.Instance.丈丂丑丒三一下丏七(丒丞专丄丝东丐丁万:  Rilisoft.WebSocket.业丛世业世不丄丐三.丟且万丕丐丈且丆丑, 一丐丗丁丞丆丅丟丄:  val_1);
        }
    
    }

}
