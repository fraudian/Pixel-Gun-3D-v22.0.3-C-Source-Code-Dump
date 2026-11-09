using UnityEngine;

namespace PGCompany
{
    internal sealed class 丒丌东丙丝丂丌丞丂
    {
        // Fields
        private const string 丅丝丕丂丙丅丛三丟 = "Ads.ChestModule.LastTimeUtc";
        private const string 丑上丂万一丛丆丒且 = "Ads.ChestModule.Count";
        private static PGCompany.丒丌东丙丝丂丌丞丂 世丒丞七专三与万丕;
        private static readonly System.DateTime 丗一丄丕且丝专丞且;
        private System.Collections.Generic.KeyValuePair<string, int> 丒丙七专丒东业丘世;
        private System.Collections.Generic.KeyValuePair<string, System.DateTime> 且丛丄丛丛丅丒且丑;
        private Rilisoft.ReusableRewardedVideo 七业下三七一丕丟与;
        private UnityEngine.GameObject 且三丏丒三不且丏丗;
        
        // Properties
        internal static PGCompany.丒丌东丙丝丂丌丞丂 丆丕丝丒不丙且丐丗 { get; }
        private static System.Globalization.CultureInfo 丝业丕丒丌丕丐丂下 { get; }
        private UnityEngine.GameObject 丒不丄三一丂丝丈专 { get; }
        
        // Methods
        private 丒丌东丙丝丂丌丞丂()
        {
        
        }
        internal static PGCompany.丒丌东丙丝丂丌丞丂 丑七不且上丗丁一世()
        {
            var val_2;
            PGCompany.丒丌东丙丝丂丌丞丂 val_3;
            var val_4;
            val_2 = null;
            val_2 = null;
            val_3 = PGCompany.丒丌东丙丝丂丌丞丂.世丒丞七专三与万丕;
            if(val_3 != null)
            {
                    return val_3;
            }
            
            PGCompany.丒丌东丙丝丂丌丞丂 val_1 = null;
            val_3 = val_1;
            val_1 = new PGCompany.丒丌东丙丝丂丌丞丂();
            val_4 = null;
            val_4 = null;
            PGCompany.丒丌东丙丝丂丌丞丂.世丒丞七专三与万丕 = val_3;
            return val_3;
        }
        private static System.Globalization.CultureInfo 丙专丝世不业下丂丈()
        {
            return System.Globalization.CultureInfo.InvariantCulture;
        }
        private UnityEngine.GameObject 丑下一丂丞且一东万()
        {
            UnityEngine.GameObject val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            string val_14;
            if(this.且三丏丒三不且丏丗 != 0)
            {
                    val_8 = this.且三丏丒三不且丏丗;
                return val_6;
            }
            
            val_9 = null;
            val_9 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == 0)
            {
                goto label_9;
            }
            
            val_10 = null;
            val_10 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑.armoryRootPanel == 0)
            {
                goto label_15;
            }
            
            val_11 = null;
            val_11 = null;
            if(gameObject == 0)
            {
                goto label_22;
            }
            
            val_12 = null;
            val_12 = null;
            UnityEngine.GameObject val_6 = gameObject;
            this.且三丏丒三不且丏丗 = val_6;
            return val_6;
            label_9:
            val_14 = "sharedShop";
            goto label_28;
            label_15:
            val_14 = "armoryRootPanel";
            goto label_28;
            label_22:
            val_14 = "gameObject";
            label_28:
            null = new System.InvalidOperationException(message:  val_14);
        }
        private System.DateTime 丈丁丆丁下业丌业一(string 万丄丅丝三丈丆世丟)
        {
            string val_11;
            var val_12;
            val_11 = 万丄丅丝三丈丆世丟;
            val_12 = this;
            if((System.String.Equals(a:  val_11, b:  this.且丛丄丛丛丅丒且丑.丐丏七丌丕丗业且上(), comparisonType:  4)) != false)
            {
                    val_11 = ???;
                val_12 = ???;
            }
            
            System.DateTime val_3 = PGCompany.丒丌东丙丝丂丌丞丂.丝丙丝与丙一万业丆(万丄丅丝三丈丆世丟:  val_11);
            MoonSharp.Interpreter.TablePair val_4 = new MoonSharp.Interpreter.TablePair(key:  val_11, val:  val_3.dateData);
            mem2[0] = val_4.key;
            mem2[0] = val_4.value;
            return (System.DateTime)val_3.dateData;
        }
        private void 丏丙丗一丘丙丈丗与(string 万丄丅丝三丈丆世丟, System.DateTime 丙业与丙丗丝不丈东)
        {
            System.DateTime val_1 = 丙业与丙丗丝不丈东.dateData.ToUniversalTime();
            PGCompany.丒丌东丙丝丂丌丞丂.丌七与上丂下丛丙东(万丄丅丝三丈丆世丟:  万丄丅丝三丈丆世丟, 一丟上丛丛万丛上丛:  new System.DateTime() {dateData = val_1.dateData});
            MoonSharp.Interpreter.TablePair val_2 = new MoonSharp.Interpreter.TablePair(key:  万丄丅丝三丈丆世丟, val:  val_1.dateData);
            this.且丛丄丛丛丅丒且丑 = val_2.key;
            mem[1152921555920301576] = val_2.value;
        }
        private int 与七七丂丈丈丙丘东(string 万丄丅丝三丈丆世丟)
        {
            string val_10;
            var val_11;
            val_10 = 万丄丅丝三丈丆世丟;
            val_11 = this;
            if((System.String.Equals(a:  val_10, b:  this.丒丙七专丒东业丘世.丐丏七丌丕丗业且上(), comparisonType:  4)) != false)
            {
                    val_10 = ???;
                val_11 = ???;
            }
            
            mem2[0] = 0;
            mem2[0] = 0;
            return (int)PGCompany.丒丌东丙丝丂丌丞丂.丂丙丑丌丐专上上丄(万丄丅丝三丈丆世丟:  val_10);
        }
        internal bool 丐丅且丗东丘上与丏(string 万丄丅丝三丈丆世丟, out System.DateTime 与三丂丆丗东下丐丙, out double 丄丅丛不丒丒丅下丄, out double 东一丟丝丗万丐业丁, out string 丐丐丕丌万不丛丏七)
        {
            string val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_31;
            var val_34;
            string val_8 = 0;
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime() {dateData = 与三丂丆丗东下丐丙.dateData})) == false)
            {
                goto label_1;
            }
            
            if((System.String.IsNullOrEmpty(value:  万丄丅丝三丈丆世丟)) == false)
            {
                goto label_2;
            }
            
            val_24 = "userId";
            goto label_32;
            label_1:
            val_24 = "TryGetServerUniversalTime";
            label_32:
            丄丅丛不丒丒丅下丄 = 0;
            东一丟丝丗万丐业丁 = 0;
            label_58:
            丐丐丕丌万不丛丏七 = val_24;
            return false;
            label_2:
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  "moduleChest", 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  val_8)) != false)
            {
                    val_26 = 0;
                if(val_26 == 0)
            {
                    val_26 = System.Array.Empty<System.Double>();
            }
            
                val_27 = 0;
                if(val_27 == 0)
            {
                    val_27 = System.Array.Empty<System.Double>();
            }
            
                var val_30 = 0;
                val_30 = val_30 + 1;
                val_25 = 0;
            }
            else
            {
                    丄丅丛不丒丒丅下丄 = 0;
                东一丟丝丗万丐业丁 = 0;
                丐丐丕丌万不丛丏七 = val_8;
                return false;
            }
            
            if(val_26.Count == 0)
            {
                goto label_32;
            }
            
            int val_14 = this.与七七丂丈丈丙丘东(万丄丅丝三丈丆世丟:  万丄丅丝三丈丆世丟);
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_25 = 0;
            int val_32 = val_26.Count;
            val_32 = val_14 - ((val_14 / val_32) * val_32);
            var val_33 = 0;
            val_33 = val_33 + 1;
            val_25 = 0;
            val_31 = public T System.Collections.Generic.IReadOnlyList<T>::get_Item(int index);
            T val_19 = val_26.Item[val_32];
            丄丅丛不丒丒丅下丄 = ;
            var val_34 = 0;
            val_34 = val_34 + 1;
            val_31 = 0;
            if(val_27.Count == 0)
            {
                goto label_43;
            }
            
            var val_35 = 0;
            val_35 = val_35 + 1;
            val_31 = 0;
            goto label_48;
            label_43:
            东一丟丝丗万丐业丁 = 0;
            val_34 = "Delay count is 0";
            goto label_58;
            label_48:
            int val_36 = val_27.Count;
            val_36 = val_14 - ((val_14 / val_36) * val_36);
            var val_37 = 0;
            val_37 = val_37 + 1;
            val_31 = 0;
            T val_26 = val_27.Item[val_36];
            东一丟丝丗万丐业丁 = ;
            System.DateTime val_27 = this.丈丁丆丁下业丌业一(万丄丅丝三丈丆世丟:  万丄丅丝三丈丆世丟);
            System.DateTime val_28 = val_27.dateData.AddMinutes(value:  东一丟丝丗万丐业丁);
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_28.dateData}, t2:  new System.DateTime() {dateData = 与三丂丆丗东下丐丙.dateData})) == false)
            {
                goto label_57;
            }
            
            val_34 = "Delay";
            goto label_58;
            label_57:
            丐丐丕丌万不丛丏七 = 0;
            return false;
        }
        internal void 丗丘东万不七专丕三(string 万丄丅丝三丈丆世丟, PGCompany.三丘丌上丁万丏丛丟 上丁丗丐丝丛丝世丂, System.DateTime 与三丂丆丗东下丐丙, System.TimeSpan 丆丌丒丐丙丟世七丑, System.Action 七丆丘上专丞上丟丗)
        {
            Rilisoft.ReusableRewardedVideo val_7;
            var val_8;
            Rilisoft.ReusableRewardedVideo val_9;
            丒丌东丙丝丂丌丞丂.业丂七丏丟丕丌丂世 val_1 = new 丒丌东丙丝丂丌丞丂.业丂七丏丟丕丌丂世();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .与三丂丆丗东下丐丙 = 与三丂丆丗东下丐丙;
            mem[1152921555920936408] = 上丁丗丐丝丛丝世丂;
            mem[1152921555920936416] = 丆丌丒丐丙丟世七丑._ticks;
            mem[1152921555920936424] = this;
            mem[1152921555920936432] = 万丄丅丝三丈丆世丟;
            mem[1152921555920936448] = 七丆丘上专丞上丟丗;
            if(万丄丅丝三丈丆世丟 == null)
            {
                goto label_2;
            }
            
            label_10:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    UnityEngine.Debug.Log(message:  "[ChestModuleRewardedVideoController.StartAdvertisingFlow]");
            }
            
            val_7 = this.业丛下万与丝丅业三();
            if(val_1 == null)
            {
                goto label_8;
            }
            
            val_8 = val_1;
            .下丒丗丛丙丆丄丈专 = val_7;
            goto label_9;
            label_1:
            mem[24] = 上丁丗丐丝丛丝世丂;
            mem[32] = 丆丌丒丐丙丟世七丑._ticks;
            mem[40] = this;
            mem[48] = 万丄丅丝三丈丆世丟;
            mem[56] = 与三丂丆丗东下丐丙.dateData;
            mem[64] = 七丆丘上专丞上丟丗;
            if(mem[48] != 0)
            {
                goto label_10;
            }
            
            label_2:
            UnityEngine.Debug.LogError(message:  "[ChestModuleRewardedVideoController.StartAdvertisingFlow] userId: null");
            return;
            label_8:
            val_8 = 16;
            mem[16] = val_7;
            val_7 = mem[16];
            label_9:
            val_7.add_ExitWatchingWithResult(丙业与丙丗丝不丈东:  new System.EventHandler<System.Threading.Tasks.Task<System.String>>(object:  val_1, method:  System.Void 丒丌东丙丝丂丌丞丂.业丂七丏丟丕丌丂世::丐三且丝丗丑专丐丒(object 不丟丗丏丛丕不丁丌, System.Threading.Tasks.Task<string> 丗丛不丁丑专专丂且)));
            val_8.add_EnterIdle(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.与丞专七丙专下丅且>(object:  val_1, method:  System.Void 丒丌东丙丝丂丌丞丂.业丂七丏丟丕丌丂世::东丑一丗万一丛丘不(object 不丟丗丏丛丕不丁丌, Rilisoft.与丞专七丙专下丅且 丗丛不丁丑专专丂且)));
            if(val_1 != null)
            {
                    val_9 = mem[16];
            }
            else
            {
                    val_9 = mem[16];
            }
            
            val_9.不且七上且业丞丈丁(与丕丌丒丗丄丘丙东:  new System.DateTime() {dateData = .与三丂丆丗东下丐丙}, 不丝丈上一七丅丕丐:  true, 业丏丞一丕丆丂丗东:  false);
            mem[16].gameObject.SetActive(value:  true);
        }
        internal Rilisoft.ReusableRewardedVideo 业丛下万与丝丅业三()
        {
            Rilisoft.ReusableRewardedVideo val_14;
            string val_16;
            if(this.七业下三七一丕丟与 != 0)
            {
                    val_14 = this.七业下三七一丕丟与;
                return val_14;
            }
            
            UnityEngine.GameObject val_2 = this.丑下一丂丞且一东万();
            Rilisoft.ReusableRewardedVideo val_3 = UnityEngine.Resources.Load<Rilisoft.ReusableRewardedVideo>(path:  "SpeedUpModuleChestRewardedVideo");
            if(val_3 == null)
            {
                goto label_5;
            }
            
            val_14 = UnityEngine.Object.Instantiate<Rilisoft.ReusableRewardedVideo>(original:  val_3, parent:  val_2.transform);
            if(val_14 == null)
            {
                goto label_9;
            }
            
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_14.gameObject, 不东丛三丂丌丑专丆:  val_2.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            UnityEngine.Transform val_8 = val_14.transform;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
            val_8.localPosition = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
            val_8.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            bool val_11 = val_14.丝不丒三下万丅不丛(丅上专丁丘丈不丞丒:  "moduleChest");
            val_14.gameObject.SetActive(value:  false);
            this.七业下三七一丕丟与 = val_14;
            return val_14;
            label_5:
            val_16 = "rewardedVideoPrefab";
            goto label_18;
            label_9:
            val_16 = "rewardedVideo";
            label_18:
            null = new System.InvalidOperationException(message:  val_16);
        }
        internal bool 世丆且丏丒且下下七(out Rilisoft.ReusableRewardedVideo 东且丁丆丛丁丏丘且)
        {
            Rilisoft.ReusableRewardedVideo val_14;
            var val_15;
            if(this.七业下三七一丕丟与 == 0)
            {
                goto label_3;
            }
            
            val_14 = this.七业下三七一丕丟与;
            label_19:
            val_15 = 1;
            goto label_4;
            label_3:
            if((this.丐丛丈七丛下丂丒专(东且丁丆丛丁丏丘且: out  0)) == false)
            {
                goto label_10;
            }
            
            Rilisoft.ReusableRewardedVideo val_4 = UnityEngine.Resources.Load<Rilisoft.ReusableRewardedVideo>(path:  "SpeedUpItemRewardedVideo");
            if(val_4 == null)
            {
                goto label_10;
            }
            
            Rilisoft.ReusableRewardedVideo val_6 = UnityEngine.Object.Instantiate<Rilisoft.ReusableRewardedVideo>(original:  val_4, parent:  val_2.transform);
            if(val_6 == null)
            {
                goto label_10;
            }
            
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_6.gameObject, 不东丛三丂丌丑专丆:  val_2.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            UnityEngine.Transform val_9 = val_6.transform;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_9.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            val_9.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            bool val_12 = val_6.丝不丒三下万丅不丛(丅上专丁丘丈不丞丒:  "moduleChest");
            val_6.gameObject.SetActive(value:  false);
            this.七业下三七一丕丟与 = val_6;
            goto label_19;
            label_10:
            val_14 = 0;
            val_15 = 0;
            label_4:
            东且丁丆丛丁丏丘且 = val_14;
            return (bool)val_15;
        }
        private static int 丂丙丑丌丐专上上丄(string 万丄丅丝三丈丆世丟)
        {
            string val_1 = PGCompany.丒丌东丙丝丂丌丞丂.丛七丈丞丂丅丁丁与(下上丐丆丝丟丝丒不:  "Ads.ChestModule.Count", 万丄丅丝三丈丆世丟:  万丄丅丝三丈丆世丟);
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_1)) == false)
            {
                    return 0;
            }
            
            return System.Math.Max(val1:  0, val2:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_1, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false));
        }
        private static System.DateTime 丝丙丝与丙一万业丆(string 万丄丅丝三丈丆世丟)
        {
            string val_7;
            System.DateTime val_8;
            var val_9;
            val_7 = PGCompany.丒丌东丙丝丂丌丞丂.丛七丈丞丂丅丁丁与(下上丐丆丝丟丝丒不:  "Ads.ChestModule.LastTimeUtc", 万丄丅丝三丈丆世丟:  万丄丅丝三丈丆世丟);
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  val_7)) != false)
            {
                    val_7 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  val_7);
                if((System.DateTime.TryParse(s:  val_7, provider:  PGCompany.丒丌东丙丝丂丌丞丂.丙专丝世不业下丂丈(), styles:  64, result: out  new System.DateTime())) != false)
            {
                    System.DateTime val_6 = 0.ToUniversalTime();
                return val_8;
            }
            
            }
            
            val_9 = null;
            val_9 = null;
            val_8 = PGCompany.丒丌东丙丝丂丌丞丂.丗一丄丕且丝专丞且;
            return val_8;
        }
        private static void 丌七与上丂下丛丙东(string 万丄丅丝三丈丆世丟, System.DateTime 一丟上丛丛万丛上丛)
        {
            System.Globalization.CultureInfo val_1 = PGCompany.丒丌东丙丝丂丌丞丂.丙专丝世不业下丂丈();
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  PGCompany.丒丌东丙丝丂丌丞丂.丛七丈丞丂丅丁丁与(下上丐丆丝丟丝丒不:  "Ads.ChestModule.LastTimeUtc", 万丄丅丝三丈丆世丟:  万丄丅丝三丈丆世丟), 下下丏一丙不丘丌丞:  一丟上丛丛万丛上丛.dateData);
        }
        private static string 丛七丈丞丂丅丁丁与(string 下上丐丆丝丟丝丒不, string 万丄丅丝三丈丆世丟)
        {
            return 下上丐丆丝丟丝丒不 + "/"("/") + 万丄丅丝三丈丆世丟;
        }
        private bool 丐丛丈七丛下丂丒专(out UnityEngine.GameObject 东且丁丆丛丁丏丘且)
        {
            UnityEngine.GameObject val_7;
            UnityEngine.GameObject val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            val_7 = this.且三丏丒三不且丏丗;
            if(val_7 == 0)
            {
                goto label_3;
            }
            
            val_8 = this.且三丏丒三不且丏丗;
            label_29:
            val_9 = 1;
            goto label_4;
            label_3:
            val_10 = null;
            val_10 = null;
            val_7 = ShopNGUIController.丏丙丅丕一丑丕丑丑;
            if(val_7 == 0)
            {
                goto label_15;
            }
            
            val_11 = null;
            val_11 = null;
            val_7 = mem[ShopNGUIController.丏丙丅丕一丑丕丑丑 + 360];
            val_7 = ShopNGUIController.丏丙丅丕一丑丕丑丑.armoryRootPanel;
            if(val_7 == 0)
            {
                goto label_15;
            }
            
            val_12 = null;
            val_12 = null;
            val_7 = gameObject;
            if(val_7 != 0)
            {
                goto label_22;
            }
            
            label_15:
            val_8 = 0;
            val_9 = 0;
            label_4:
            东且丁丆丛丁丏丘且 = val_8;
            return (bool)val_9;
            label_22:
            val_13 = null;
            val_13 = null;
            this.且三丏丒三不且丏丗 = gameObject;
            goto label_29;
        }
        private void 丅丁丑丕丗业且丞丏(string 万丄丅丝三丈丆世丟)
        {
            var val_5 = mem[static_value_081D9970 + 295];
            val_5 = static_value_081D9970 + 295;
            val_5 = mem[static_value_081D9970 + 216];
            val_5 = static_value_081D9970 + 216;
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  PGCompany.丒丌东丙丝丂丌丞丂.丛七丈丞丂丅丁丁与(下上丐丆丝丟丝丒不:  "Ads.ChestModule.Count", 万丄丅丝三丈丆世丟:  万丄丅丝三丈丆世丟), 下下丏一丙不丘丌丞:  ((this.与七七丂丈丈丙丘东(万丄丅丝三丈丆世丟:  万丄丅丝三丈丆世丟)) + 1) & 2147483647, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            this.丒丙七专丒东业丘世 = 0;
            mem[1152921555922125192] = 0;
        }
        private static void 上丅不丞丂丝丑东丁(string 丗万不不丞丁丁丛丁, int 丙丂丏丛丌丏下丝不)
        {
            string val_3 = 丗万不不丞丁丁丛丁;
            PGCompany.七丑一上且三世丝三<K, V> val_1 = PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不();
            if(val_3 == null)
            {
                    val_3 = System.String.alignConst;
            }
            
            val_1.set_Item(key:  val_3, value:  丙丂丏丛丌丏下丝不);
            Rilisoft.丝丄三业丙专丛与不.丝丌不东丑丁丞下七(丝丏业丅丈东业丝丒:  "Module Chest Ad", 丛东不丒丏丈丄且丕:  val_1);
            if((PGCompany.七丑一上且三世丝三<System.String, System.Object>.万世丅七一专丕丞不()) != null)
            {
                    return;
            }
        
        }
        private static 丒丌东丙丝丂丌丞丂()
        {
            PGCompany.丒丌东丙丝丂丌丞丂.丗一丄丕且丝专丞且 = 0;
        }
        internal static bool 东丞丅丒与万不东且(string 丝丏丙丁丏丑专丆世, out double 丝丈业丂丄专业丆丟, out double 丞丐丄丁丁丐丞丈丌, out string 丛世丘七丆与丂丁世)
        {
            丝丈业丂丄专业丆丟 = 0;
            丞丐丄丁丁丐丞丈丌 = 0;
            丛世丘七丆与丂丁世 = 丝丏丙丁丏丑专丆世;
            return false;
        }
        private bool 不专丁专丄丞专且丑(out Rilisoft.ReusableRewardedVideo 丌世丈业丐丌七丒丛)
        {
            丌世丈业丐丌七丒丛 = this.七业下三七一丕丟与;
            return true;
        }
        internal static bool 丟不世丅丏丈丁丈且(out Rilisoft.ReusableRewardedVideo 丌世丈业丐丌七丒丛)
        {
            丌世丈业丐丌七丒丛 = 0;
            return false;
        }
        private bool 三丄上与丈丘丗丈丑(out UnityEngine.GameObject 丈东丘丏与丌东东下)
        {
            丈东丘丏与丌东东下 = this.且三丏丒三不且丏丗;
            return true;
        }
        internal static bool 专丌七业丟丈丂丌世(out UnityEngine.GameObject 丈东丘丏与丌东东下)
        {
            丈东丘丏与丌东东下 = 0;
            return false;
        }
    
    }

}
