using UnityEngine;

namespace Progress
{
    internal sealed class 三丕丕业丗七东专丗 : 丛世丞丆七一七丁七
    {
        // Fields
        private bool 与丒丁丏与万丌专丘;
        private string 丒一丄丗丞丗丄丐丂;
        internal const int 丂丈一不丏不丙丌七 = 1504;
        internal const int 业与上丂丆七丁万与 = 1603;
        private string 丕丑丌丕丁丁丛一丐;
        private System.Collections.Generic.List<string> 三丆专丑东丁丕三丅;
        private readonly string 一专丅丙丗丏与丝丅;
        
        // Methods
        internal 三丕丕业丗七东专丗(string 专丈丙丌丑一世下丄)
        {
        
        }
        internal 三丕丕业丗七东专丗(bool 丑七丏专丗丛丟专世, string 丅丞东丄万一七一丛)
        {
            System.Collections.IEnumerable val_9;
            System.Collections.Generic.List<System.String> val_10;
            this.一专丅丙丗丏与丝丅 = "LocalProgress_Migration.Used_hashes";
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  this.一专丅丙丗丏与丝丅)) != true)
            {
                    丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this.一专丅丙丗丏与丝丅, 下下丏一丙不丘丌丞:  "[]");
            }
            
            val_9 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  this.一专丅丙丗丏与丝丅));
            System.Collections.Generic.List<System.Object> val_4 = null;
            val_9 = val_4;
            val_4 = new System.Collections.Generic.List<System.Object>();
            val_10 = System.Linq.Enumerable.ToList<System.String>(source:  System.Linq.Enumerable.OfType<System.String>(source:  val_4));
            if(val_10 == null)
            {
                    System.Collections.Generic.List<System.String> val_7 = null;
                val_10 = val_7;
                val_7 = new System.Collections.Generic.List<System.String>();
            }
            
            this.三丆专丑东丁丕三丅 = val_10;
            this.与丒丁丏与万丌专丘 = 丑七丏专丗丛丟专世;
            this.丒一丄丗丞丗丄丐丂 = 丅丞东丄万一七一丛;
        }
        internal override System.Threading.Tasks.Task<Progress.丘丟丆丝丁丏丄专一> 丕丌丈丂丝丝七业下(System.Collections.Generic.Dictionary<string, object> 上丕丈丞丌丘丅不与)
        {
            System.Threading.Tasks.TaskCompletionSource<TResult> val_10;
            object val_11;
            var val_12;
            System.Threading.Tasks.TaskCompletionSource<Progress.丘丟丆丝丁丏丄专一> val_1 = null;
            val_10 = val_1;
            val_1 = new System.Threading.Tasks.TaskCompletionSource<Progress.丘丟丆丝丁丏丄专一>();
            mem[1152921541091583456] = val_10;
            if((this & 1) == 0)
            {
                goto label_1;
            }
            
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_2 = this.三东上世与丈丘业三(上丕丈丞丌丘丅不与:  上丕丈丞丌丘丅不与, 丝不丄业丛三上丕丄:  0, 七与业丕丆丕丁丞丅:  0);
            val_2.set_Item(key:  "rewrite", value:  this.与丒丁丏与万丌专丘);
            val_2.set_Item(key:  "player_id", value:  this.丒一丄丗丞丗丄丐丂);
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "V7_WeaponManager.WEAPON_LEVELS_KEY")) != true)
            {
                    丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "V7_WeaponManager.WEAPON_LEVELS_KEY", 下下丏一丙不丘丌丞:  "{}");
            }
            
            val_11 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "V7_WeaponManager.WEAPON_LEVELS_KEY");
            val_2.set_Item(key:  "weaponPrefs", value:  val_11);
            val_10 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟().丂丄丕世世专东丈丒();
            if(val_10.Count != 0)
            {
                goto label_23;
            }
            
            val_12 = null;
            val_12 = null;
            val_2.set_Item(key:  "rewriteErrors", value:  Progress.与丂丌且丏丌丗丅万.与丙专丟丛专与丐丞);
            val_10 = Progress.与丂丌且丏丌丗丅万.丈丐丅丙丞不东丏丙;
            val_11 = val_10;
            val_2.set_Item(key:  "exceptions", value:  val_11);
            goto label_23;
            label_1:
            val_11 = System.String.alignConst;
            System.Collections.Generic.Dictionary<System.Object, System.Object> val_8 = this.三东上世与丈丘业三(上丕丈丞丌丘丅不与:  上丕丈丞丌丘丅不与, 丝不丄业丛三上丕丄:  val_11, 七与业丕丆丕丁丞丅:  0);
            label_23:
            this.丕丑丌丕丁丁丛一丐 = 0;
            return (System.Threading.Tasks.Task<Progress.丘丟丆丝丁丏丄专一>)上丕丈丞丌丘丅不与.Task;
        }
        protected override bool 丄且丙丁世丝丄丐丅(out string 丝不丄业丛三上丕丄)
        {
            return false;
        }
        protected override bool 丄且丙丁世丝丄丐丅(out string 丝不丄业丛三上丕丄, out int 丌丈不丄丝七丕万专)
        {
            int val_5;
            string val_6;
            var val_7;
            val_5 = 1;
            丌丈不丄丝七丕万专 = val_5;
            丝不丄业丛三上丕丄 = System.String.alignConst;
            goto label_1;
            label_11:
            val_6 = 丅丂丌丗丈七业七丕.下丐丌丞东万丝与丛(丌丈不丄丝七丕万专:  1, 丞丅上丏丂且下丅与:  this.丒一丄丗丞丗丄丐丂);
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_6)) != false)
            {
                    if((this.三丆专丑东丁丕三丅.Contains(item:  val_6)) == false)
            {
                goto label_8;
            }
            
            }
            
            val_5 = 2;
            label_1:
            val_6 = val_5 - 1;
            if(val_6 < 丅丂丌丗丈七业七丕.与丗丟丘与丅丐丕丞())
            {
                goto label_11;
            }
            
            val_7 = 0;
            return (bool)val_7;
            label_8:
            丌丈不丄丝七丕万专 = val_5;
            丝不丄业丛三上丕丄 = val_6;
            val_7 = 1;
            return (bool)val_7;
        }
        internal override bool 丄且丙丁世丝丄丐丅()
        {
            return false;
        }
        protected override void 丈丂丑丒三一下丏七(System.Collections.Generic.Dictionary<object, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_9;
            var val_10;
            var val_11;
            val_9 = null;
            val_9 = null;
            一丐丗丁丞丆丅丟丄.set_Item(key:  "prop", value:  GameConnect.一世丝上上丙丆丒丆);
            if(UnityEngine.Application.platform == 8)
            {
                    val_10 = null;
                val_10 = null;
                一丐丗丁丞丆丅丟丄.set_Item(key:  "prop_v2", value:  业专丝丘东丌丂丌丒.一丏七与与丕丙且丑);
                一丐丗丁丞丆丅丟丄.set_Item(key:  "prop_v2_m", value:  UnityEngine.SystemInfo.deviceModel);
                一丐丗丁丞丆丅丟丄.set_Item(key:  "prop_v2_o", value:  UnityEngine.SystemInfo.operatingSystem);
            }
            
            val_11 = null;
            val_11 = null;
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丟三丟丆一东上丟丘, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Progress.三丕丕业丗七东专丗::丏与丞且下且丏丅下(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.下丌业业丐丘丐丘三(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丟三丟丆一东上丟丘, 七丐丅专且专七三丆:  new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Progress.三丕丕业丗七东专丗::丏与丞且下且丏丅下(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)));
        }
        private void 丏与丞且下且丏丅下(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不)
        {
            var val_9;
            Progress.丘丟丆丝丁丏丄专一 val_10;
            var val_11;
            Progress.丘丟丆丝丁丏丄专一 val_12;
            val_9 = null;
            val_9 = null;
            Rilisoft.WebSocket.丌东丏丆丞丐丙丟上 val_1 = new Rilisoft.WebSocket.丌东丏丆丞丐丙丟上(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void Progress.三丕丕业丗七东专丗::丏与丞且下且丏丅下(System.Collections.Generic.Dictionary<string, object> 丑与丂丌世丕丆一丗, System.Collections.Generic.Dictionary<object, object> 东丞丒丙世丏三下丟, System.Collections.Generic.List<byte[]> 丁不七丙下七丐与不));
            Rilisoft.WebSocket.且丗丙丆丕东世与丈.万不丒上丕丗丂丘丒(丈丂丒丄丘丕丌上与:  Rilisoft.WebSocket.业丛世业世不丄丐三.丟三丟丆一东上丟丘, 七丐丅专且专七三丆:  val_1);
            val_10 = this.丁丂上东专与丈与一(一丐丗丁丞丆丅丟丄:  丑与丂丌世丕丆一丗);
            if(val_10 == 1603)
            {
                goto label_5;
            }
            
            if(val_10 == 1504)
            {
                goto label_6;
            }
            
            if(val_10 != 0)
            {
                goto label_7;
            }
            
            Progress.丘丟丆丝丁丏丄专一 val_3 = null;
            val_10 = val_3;
            val_3 = new Progress.丘丟丆丝丁丏丄专一(上丞丌丂业专丟下丌:  true, 上丕丈丞丌丘丅不与:  val_1);
            if(丑与丂丌世丕丆一丗 != null)
            {
                goto label_12;
            }
            
            label_13:
            label_12:
            bool val_4 = 丑与丂丌世丕丆一丗.TrySetResult(result:  val_3);
            this.丄丈一丈丄丄万丗丒(丝不丄业丛三上丕丄:  this.丕丑丌丕丁丁丛一丐);
            goto label_9;
            label_5:
            Progress.丘丟丆丝丁丏丄专一 val_5 = null;
            val_10 = val_5;
            val_5 = new Progress.丘丟丆丝丁丏丄专一(上丞丌丂业专丟下丌:  false, 上丕丈丞丌丘丅不与:  val_1, 世专丞丂上丁丛丑丟:  67);
            val_11 = 1152921541090879248;
            val_12 = val_10;
            goto label_11;
            label_6:
            Progress.丘丟丆丝丁丏丄专一 val_6 = new Progress.丘丟丆丝丁丏丄专一(上丞丌丂业专丟下丌:  false, 上丕丈丞丌丘丅不与:  val_1, 世专丞丂上丁丛丑丟:  224);
            if(丑与丂丌世丕丆一丗 != null)
            {
                goto label_12;
            }
            
            goto label_13;
            label_7:
            Progress.丘丟丆丝丁丏丄专一 val_7 = new Progress.丘丟丆丝丁丏丄专一(上丞丌丂业专丟下丌:  false, 上丕丈丞丌丘丅不与:  X23, 世专丞丂上丁丛丑丟:  val_10);
            val_11 = 1152921541090879248;
            val_12 = val_7;
            label_11:
            bool val_8 = 丑与丂丌世丕丆一丗.TrySetResult(result:  val_7);
            label_9:
            this.丕丑丌丕丁丁丛一丐 = System.String.alignConst;
        }
        private int 丁丂上东专与丈与一(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄)
        {
            var val_7;
            var val_8;
            var val_9;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                goto label_1;
            }
            
            val_7 = 1152921516630043280;
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  "progress")) == false)
            {
                goto label_2;
            }
            
            object val_2 = 一丐丗丁丞丆丅丟丄.Item["progress"];
            val_8 = 0;
            goto label_5;
            label_1:
            val_9 = 1;
            return (int)val_9;
            label_5:
            mem[1152921541092502344] = ;
            label_2:
            if((一丐丗丁丞丆丅丟丄.ContainsKey(key:  "err_code")) != false)
            {
                    return System.Convert.ToInt32(value:  一丐丗丁丞丆丅丟丄.Item["err_code"], provider:  System.Globalization.CultureInfo.InvariantCulture);
            }
            
            val_9 = 0;
            return (int)val_9;
        }
        private void 丄丈一丈丄丄万丗丒(string 丝不丄业丛三上丕丄)
        {
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丝不丄业丛三上丕丄)) == true)
            {
                    return;
            }
            
            if((this.三丆专丑东丁丕三丅.Contains(item:  丝不丄业丛三上丕丄)) != false)
            {
                    return;
            }
            
            this.三丆专丑东丁丕三丅.Add(item:  丝不丄业丛三上丕丄);
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  this.一专丅丙丗丏与丝丅, 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.三丆专丑东丁丕三丅));
        }
    
    }

}
