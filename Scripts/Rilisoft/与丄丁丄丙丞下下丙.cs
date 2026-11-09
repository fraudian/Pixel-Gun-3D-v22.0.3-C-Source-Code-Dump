using UnityEngine;

namespace Rilisoft
{
    internal sealed class 与丄丁丄丙丞下下丙
    {
        // Properties
        internal static bool 业丕与与丗丒上不丐 { get; }
        internal static bool 七丈丈丝丑丈世丞专 { get; }
        internal static UnityEngine.RuntimePlatform 且下丟专世丗丞丑丅 { get; }
        internal static bool 上且七丈下上丐与丑 { get; }
        internal static int 一丆与不丕丝下丂且 { get; }
        internal static int 三丘上丐丆三业东丂 { get; }
        internal static int 丗丌且丐丂丗专丌且 { get; }
        internal static int 专七三丌丁丏丐且丟 { get; }
        internal static int 丐丟丐世丙丐上丆丟 { get; }
        internal static int 丈一丟上丛丝业丞丒 { get; }
        internal static int 上丆且丏丑专业一丛 { get; }
        internal static int 下丁丏东丐不世丏丞 { get; }
        internal static int 丕丟一丛丁丒丏丕丙 { get; }
        
        // Methods
        internal static bool 且丈丙专丁万东上丝()
        {
            return false;
        }
        internal static bool 丒丐丆丘丈丟丂下专()
        {
            return false;
        }
        internal static UnityEngine.RuntimePlatform 世下一丒丂丄丆七下()
        {
            return UnityEngine.Application.platform;
        }
        internal static bool 东下丝上丗一一丛丟()
        {
            return false;
        }
        internal static int 世丝上丁丐丘丗丈丏()
        {
            int val_1 = UnityEngine.LayerMask.NameToLayer(layerName:  "DamageCollider");
            int val_2 = val_1 & 31;
            val_2 = 1 << val_2;
            val_1 = (~val_2) & 4294967291;
            return (int)val_1;
        }
        internal static int 丒丑丗一东丈万丅下()
        {
            int val_2 = UnityEngine.LayerMask.NameToLayer(layerName:  "MyPlayer");
            int val_3 = (UnityEngine.LayerMask.NameToLayer(layerName:  "DamageCollider")) & 31;
            var val_5 = 1;
            val_3 = val_5 << val_3;
            var val_6 = ~val_3;
            val_5 = val_5 << (val_2 & 31);
            val_6 = val_6 & (~val_5);
            val_2 = val_6 & 4294967291;
            return (int)val_2;
        }
        internal static int 丂丂丟世专三不上丙()
        {
            int val_1 = UnityEngine.LayerMask.NameToLayer(layerName:  "MyPlayer");
            int val_2 = val_1 & 31;
            val_2 = 1 << val_2;
            val_1 = (~val_2) & 4294967291;
            return (int)val_1;
        }
        internal static int 业万与丑丟丏丕丕业()
        {
            int val_3 = UnityEngine.LayerMask.NameToLayer(layerName:  "TransparentFX");
            int val_4 = (UnityEngine.LayerMask.NameToLayer(layerName:  "DamageCollider")) & 31;
            var val_8 = 1;
            int val_5 = (UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket")) & 31;
            val_4 = val_8 << val_4;
            val_5 = val_8 << val_5;
            var val_7 = ~val_4;
            val_7 = val_7 & (~val_5);
            val_8 = val_8 << (val_3 & 31);
            val_7 = val_7 & (~val_8);
            val_3 = val_7 & 4294967291;
            return (int)val_3;
        }
        internal static int 丄丏专丑东丟丒且丅()
        {
            int val_4 = UnityEngine.LayerMask.NameToLayer(layerName:  "IgnoreRocketsAndBullets");
            int val_5 = (UnityEngine.LayerMask.NameToLayer(layerName:  "DamageCollider")) & 31;
            var val_10 = 1;
            int val_6 = (UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket")) & 31;
            val_5 = val_10 << val_5;
            int val_7 = (UnityEngine.LayerMask.NameToLayer(layerName:  "TransparentFX")) & 31;
            val_6 = val_10 << val_6;
            var val_9 = ~val_5;
            val_7 = val_10 << val_7;
            val_9 = val_9 & (~val_6);
            val_9 = val_9 & (~val_7);
            val_10 = val_10 << (val_4 & 31);
            val_9 = val_9 & (~val_10);
            val_4 = val_9 & 4294967291;
            return (int)val_4;
        }
        internal static int 丞上万世业丙丗且丆()
        {
            int val_5 = UnityEngine.LayerMask.NameToLayer(layerName:  "IgnoreRocketsAndBullets");
            int val_6 = (UnityEngine.LayerMask.NameToLayer(layerName:  "MyPlayer")) & 31;
            var val_12 = 1;
            int val_7 = (UnityEngine.LayerMask.NameToLayer(layerName:  "DamageCollider")) & 31;
            val_6 = val_12 << val_6;
            int val_8 = (UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket")) & 31;
            val_7 = val_12 << val_7;
            var val_11 = ~val_6;
            int val_9 = (UnityEngine.LayerMask.NameToLayer(layerName:  "TransparentFX")) & 31;
            val_8 = val_12 << val_8;
            val_11 = val_11 & (~val_7);
            val_9 = val_12 << val_9;
            val_11 = val_11 & (~val_8);
            val_11 = val_11 & (~val_9);
            val_12 = val_12 << (val_5 & 31);
            val_11 = val_11 & (~val_12);
            val_5 = val_11 & 4294967291;
            return (int)val_5;
        }
        internal static int 与万与一不丌丈业丞()
        {
            int val_2 = UnityEngine.LayerMask.NameToLayer(layerName:  "NotDetectMobRaycast");
            int val_3 = (UnityEngine.LayerMask.NameToLayer(layerName:  "DamageCollider")) & 31;
            var val_5 = 1;
            val_3 = val_5 << val_3;
            var val_6 = ~val_3;
            val_5 = val_5 << (val_2 & 31);
            val_6 = val_6 & (~val_5);
            val_2 = val_6 & 4294967291;
            return (int)val_2;
        }
        internal static int 丁丝丒丞不丑丈丆下()
        {
            int val_1 = UnityEngine.LayerMask.NameToLayer(layerName:  "DamageCollider");
            int val_2 = val_1 & 31;
            val_2 = 1 << val_2;
            val_1 = (~val_2) & 4294967291;
            return (int)val_1;
        }
        internal static int 丑且丛且丝丞且丗丒()
        {
            int val_4 = UnityEngine.LayerMask.NameToLayer(layerName:  "MyPlayer");
            int val_5 = (UnityEngine.LayerMask.NameToLayer(layerName:  "DamageCollider")) & 31;
            var val_10 = 1;
            int val_6 = (UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket")) & 31;
            val_5 = val_10 << val_5;
            int val_7 = (UnityEngine.LayerMask.NameToLayer(layerName:  "TransparentFX")) & 31;
            val_6 = val_10 << val_6;
            var val_9 = ~val_5;
            val_7 = val_10 << val_7;
            val_9 = val_9 & (~val_6);
            val_9 = val_9 & (~val_7);
            val_10 = val_10 << (val_4 & 31);
            val_9 = val_9 & (~val_10);
            val_4 = val_9 & 4294967291;
            return (int)val_4;
        }
        internal static int 一丄丑丛丕丟万三丞(int 丗丙丆世丆丕万下丒 = 600)
        {
            int val_1 = 专丈专业丆且且业下.丈不丄丛丛丘东丁丙();
            val_1 = val_1 - ((val_1 / 丗丙丆世丆丕万下丒) * 丗丙丆世丆丕万下丒);
            return (int)val_1;
        }
        internal static void 丌世七丑丆丈丑丕丛(UnityEngine.GameObject 与丘东下丈东丛丂万)
        {
            var val_2;
            System.Action<UnityEngine.Transform> val_4;
            val_2 = null;
            val_2 = null;
            val_4 = 与丄丁丄丙丞下下丙.<>c.<>9__28_0;
            if(val_4 == null)
            {
                    System.Action<UnityEngine.Transform> val_1 = null;
                val_4 = val_1;
                val_1 = new System.Action<UnityEngine.Transform>(object:  与丄丁丄丙丞下下丙.<>c.__il2cppRuntimeField_static_fields, method:  System.Void 与丄丁丄丙丞下下丙.<>c::丏丐业丆一丆丘一丆(UnityEngine.Transform 丙丒七丄上与丏丙丙));
                与丄丁丄丙丞下下丙.<>c.<>9__28_0 = val_4;
            }
            
            Player_move_c.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  与丘东下丈东丛丂万, 丌专业且丛丏丞丝且:  val_1);
        }
        internal static void 丏丏丄七且丛丟丁丗(UnityEngine.Transform 丅万专世丈丕丑丗丘, bool 丈七与世丏丕业世丙)
        {
            .丈七与世丏丕业世丙 = 丈七与世丏丕业世丙;
            .丘丝上丑丂丄丕丟丞 = 丅万专世丈丕丑丗丘.gameObject.GetComponent<ShaderNameCollector>();
            Player_move_c.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  丅万专世丈丕丑丗丘.gameObject, 丌专业且丛丏丞丝且:  new System.Action<UnityEngine.Transform>(object:  new 与丄丁丄丙丞下下丙.世丘丛上丞丆丟丟丐(), method:  System.Void 与丄丁丄丙丞下下丙.世丘丛上丞丆丟丟丐::不丑上丌丗三丒一专(UnityEngine.Transform 丙丒七丄上与丏丙丙)));
        }
        internal static void 下丈三丙丙一不世丌(UnityEngine.Transform 丅万专世丈丕丑丗丘, bool 丈七与世丏丕业世丙)
        {
            .丈七与世丏丕业世丙 = 丈七与世丏丕业世丙;
            .丘丝上丑丂丄丕丟丞 = 丅万专世丈丕丑丗丘.gameObject.GetComponent<ShaderNameCollector>();
            Player_move_c.丛专专丗专丕东七丅(万且万且丑丗且丌丆:  丅万专世丈丕丑丗丘.gameObject, 丌专业且丛丏丞丝且:  new System.Action<UnityEngine.Transform>(object:  new 与丄丁丄丙丞下下丙.三丕业丁丗东丂七丝(), method:  System.Void 与丄丁丄丙丞下下丙.三丕业丁丗东丂七丝::丝不丂丙丆丞三丑与(UnityEngine.Transform 丙丒七丄上与丏丙丙)));
        }
        internal static string 专一三丐丑业丆丌丏()
        {
            return UnityEngine.Application.identifier;
        }
        internal static bool 世丐与一丛业丆专丝()
        {
            if(Rilisoft.BackSystem.丁不与丕丐七丝丛丟() == false)
            {
                    return UnityEngine.Input.GetKeyUp(key:  27);
            }
            
            return false;
        }
        private static bool 丗三丏丄丁丝三专丞()
        {
            return (bool)(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != 0) ? 1 : 0;
        }
        internal static UnityEngine.WWW 与丛七丞且专丄丛世(string 七丙不丅丛丘丗万与, UnityEngine.WWWForm 丛丁且丏丁丄上上丄, string 丐丆丐七一上专三丑 = "")
        {
            return Rilisoft.与丄丁丄丙丞下下丙.万丛七不丆丅世下丄(丞三丕世业三丒丅三:  true, 七丙不丅丛丘丗万与:  七丙不丅丛丘丗万与, 丛丁且丏丁丄上上丄:  丛丁且丏丁丄上上丄, 丐丆丐七一上专三丑:  丐丆丐七一上专三丑, 一丞不一不一与世丙:  0, 丝丌丝不丟丞丑丑丗:  true);
        }
        internal static UnityEngine.WWW 三专世丝丝丈丂东与(string 七丙不丅丛丘丗万与, UnityEngine.WWWForm 丛丁且丏丁丄上上丄, string 丐丆丐七一上专三丑 = "", System.Collections.Generic.Dictionary<string, string> 一丞不一不一与世丙)
        {
            bool val_1 = Rilisoft.与丄丁丄丙丞下下丙.丗三丏丄丁丝三专丞();
            val_1 = (~val_1) & 1;
            return Rilisoft.与丄丁丄丙丞下下丙.万丛七不丆丅世下丄(丞三丕世业三丒丅三:  val_1, 七丙不丅丛丘丗万与:  七丙不丅丛丘丗万与, 丛丁且丏丁丄上上丄:  丛丁且丏丁丄上上丄, 丐丆丐七一上专三丑:  丐丆丐七一上专三丑, 一丞不一不一与世丙:  一丞不一不一与世丙, 丝丌丝不丟丞丑丑丗:  true);
        }
        internal static UnityEngine.WWW 万丛七不丆丅世下丄(bool 丞三丕世业三丒丅三, string 七丙不丅丛丘丗万与, UnityEngine.WWWForm 丛丁且丏丁丄上上丄, string 丐丆丐七一上专三丑 = "", System.Collections.Generic.Dictionary<string, string> 一丞不一不一与世丙, bool 丝丌丝不丟丞丑丑丗 = True)
        {
            UnityEngine.WWW val_7;
            if(一丞不一不一与世丙 == null)
            {
                goto label_1;
            }
            
            if(丞三丕世业三丒丅三 == false)
            {
                goto label_2;
            }
            
            label_6:
            UnityEngine.WWW val_2 = null;
            val_7 = val_2;
            val_2 = new UnityEngine.WWW(url:  七丙不丅丛丘丗万与, postData:  丛丁且丏丁丄上上丄.data, headers:  一丞不一不一与世丙);
            goto label_4;
            label_1:
            System.Collections.Generic.Dictionary<System.String, System.String> val_3 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            if(丞三丕世业三丒丅三 == true)
            {
                goto label_6;
            }
            
            label_2:
            val_7 = 0;
            label_4:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return val_7;
            }
            
            if(FriendsController.丘丟专专丘东丈丒上() == false)
            {
                    return val_7;
            }
            
            Rilisoft.且东下世丑业丞丂东.丆丟丟三丗东一丆三(丏丐丝世丄丈丝丌丌:  val_7, 丛丁且丏丁丄上上丄:  丛丁且丏丁丄上上丄, 七丙不丅丛丘丗万与:  七丙不丅丛丘丗万与, 丐丆丐七一上专三丑:  丐丆丐七一上专三丑, 丝丌丝不丟丞丑丑丗:  丝丌丝不丟丞丑丑丗);
            return val_7;
        }
        internal static UnityEngine.WWW 与丛七丞且专丄丛世(string 七丙不丅丛丘丗万与, bool 丝丌丝不丟丞丑丑丗 = True)
        {
            UnityEngine.WWW val_1 = new UnityEngine.WWW(url:  七丙不丅丛丘丗万与);
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return val_1;
            }
            
            if(FriendsController.丘丟专专丘东丈丒上() == false)
            {
                    return val_1;
            }
            
            Rilisoft.且东下世丑业丞丂东.丆丟丟三丗东一丆三(丏丐丝世丄丈丝丌丌:  val_1, 七丙不丅丛丘丗万与:  七丙不丅丛丘丗万与, 丝丌丝不丟丞丑丑丗:  丝丌丝不丟丞丑丑丗);
            return val_1;
        }
        internal static UnityEngine.WWW 三专世丝丝丈丂东与(string 七丙不丅丛丘丗万与, bool 丝丌丝不丟丞丑丑丗 = True)
        {
            UnityEngine.WWW val_6;
            if(Rilisoft.与丄丁丄丙丞下下丙.丗三丏丄丁丝三专丞() != false)
            {
                    val_6 = 0;
            }
            else
            {
                    UnityEngine.WWW val_2 = null;
                val_6 = val_2;
                val_2 = new UnityEngine.WWW(url:  七丙不丅丛丘丗万与);
            }
            
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return val_6;
            }
            
            if(FriendsController.丘丟专专丘东丈丒上() == false)
            {
                    return val_6;
            }
            
            Rilisoft.且东下世丑业丞丂东.丆丟丟三丗东一丆三(丏丐丝世丄丈丝丌丌:  val_2, 七丙不丅丛丘丗万与:  七丙不丅丛丘丗万与, 丝丌丝不丟丞丑丑丗:  丝丌丝不丟丞丑丑丗);
            return val_6;
        }
        internal static void 丁丑丗上丗丞上一与(int 业业丑丂丛丆业丝七)
        {
            Rilisoft.TechnicalCloudInfo val_9;
            int val_10;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  52, 丙业与丙丗丝不丈东:  业业丑丂丛丆业丝七);
            val_9 = UnityEngine.JsonUtility.FromJson<Rilisoft.TechnicalCloudInfo>(json:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "TechnicalCloudInfo.TECHNICAL_CLOUD_INFO_STORAGER_KEY"));
            if(val_9 == null)
            {
                    val_9 = new Rilisoft.TechnicalCloudInfo();
                val_9 = new Rilisoft.TechnicalCloudInfo();
            }
            
            val_10 = System.Math.Max(val1:  new Rilisoft.TechnicalCloudInfo().SessionDayCount, val2:  业业丑丂丛丆业丝七);
            if(new Rilisoft.TechnicalCloudInfo().SessionDayCount == val_10)
            {
                    return;
            }
            
            new Rilisoft.TechnicalCloudInfo().SessionDayCount = val_10;
            val_10 = UnityEngine.JsonUtility.ToJson(obj:  new Rilisoft.TechnicalCloudInfo());
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "TechnicalCloudInfo.TECHNICAL_CLOUD_INFO_STORAGER_KEY", 下下丏一丙不丘丌丞:  val_10);
        }
        internal static System.Nullable<float> 丞丈丌专丙三丒丘丈()
        {
            string val_5;
            var val_6;
            val_5 = 1152921505266909184;
            if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  "PlayTime")) != false)
            {
                    val_5 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  "PlayTime");
                if((丞东丑专丛丆丄丝世.丝丐丐丝丒丈且专专(丞丕丒专一下丙业上:  val_5, 丙业与丙丗丝不丈东: out  float val_3 = 1.755115E-29f)) != false)
            {
                    val_6 = 0;
                return (System.Nullable<System.Single>)val_6;
            }
            
            }
            
            val_6 = 0;
            return (System.Nullable<System.Single>)val_6;
        }
        internal static void 与丛丟且丕丒业一丘()
        {
            string val_20;
            if(AuthSceneController.一不丆丏与丐丏丈丄() == false)
            {
                    return;
            }
            
            UnityEngine.PlayerPrefs.SetInt(key:  与丂丏丛丞丞丒丟丄.丐丂丅一丕丘丑丅丄(), value:  (UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.丐丂丅一丕丘丑丅丄(), defaultValue:  1)) + 1);
            val_20 = UnityEngine.PlayerPrefs.GetString(key:  与丂丏丛丞丞丒丟丄.丐丕丒丂七丞丙上丐(), defaultValue:  System.String.alignConst);
            System.DateTime val_8 = System.DateTime.UtcNow;
            if((System.DateTime.TryParse(s:  val_20, result: out  new System.DateTime())) == false)
            {
                goto label_12;
            }
            
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == true)
            {
                goto label_9;
            }
            
            val_20 = val_8.dateData;
            System.TimeSpan val_11 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_20}, d2:  new System.DateTime());
            if(val_11._ticks.TotalHours > 23)
            {
                goto label_12;
            }
            
            label_9:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return;
            }
            
            val_20 = val_8.dateData;
            System.TimeSpan val_14 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_20}, d2:  new System.DateTime());
            if(val_14._ticks.TotalMinutes <= 3)
            {
                    return;
            }
            
            label_12:
            val_20 = (Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  52)) + 1;
            Rilisoft.与丄丁丄丙丞下下丙.丁丑丗上丗丞上一与(业业丑丂丛丆业丝七:  val_20);
            UnityEngine.PlayerPrefs.SetString(key:  与丂丏丛丞丞丒丟丄.丐丕丒丂七丞丙上丐(), value:  val_8.dateData);
            丟丌丁且且世丈丈丟.与丅丌丝东七丈万丕(丙业与丙丗丝不丈东:  丟丌丁且且世丈丈丟.丟与丌丏丞丕丒丌丗());
            Rilisoft.一丟专且三万丞丁丂.东丛丛丏且丆丅专丕(丏不丛不丘专丈丄且:  val_20);
        }
        internal static UnityEngine.Rect 七丏与一丏三丝丈丏()
        {
            int val_1 = UnityEngine.Screen.width;
            int val_5 = UnityEngine.Screen.height;
            float val_9 = (float)UnityEngine.Screen.height;
            float val_10 = 0.5f;
            val_9 = val_9 * val_10;
            val_10 = (float)UnityEngine.Screen.height * val_10;
            val_9 = ((float)((val_1 < 0) ? (val_1 + 1) : (val_1)) >> 1) - val_9;
            float val_11 = (float)UnityEngine.Screen.height;
            val_11 = val_11 * (-0.0525f);
            val_10 = val_10 + val_11;
            float val_12 = (float)UnityEngine.Screen.height;
            val_12 = val_12 * 0.105f;
            return new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f};
        }
        internal static void 上丝丗一丗丙丒丅丒(UnityEngine.GameObject 丂丟三三丂且业与丆, bool 不与万丌一丈下丑丈)
        {
            UIWidget val_1 = 丂丟三三丂且业与丆.GetComponent<UIWidget>();
            if(val_1 == 0)
            {
                    return;
            }
            
            var val_3 = (不与万丌一丈下丑丈 != true) ? 1f : 0.001f;
            if(val_1 == null)
            {
                
            }
        
        }
        internal static void 世丙丆业世丝与丝七(UnityEngine.GameObject 万且万且丑丗且丌丆, int 不东丛三丂丌丑专丆)
        {
            var val_7;
            if(0 == 万且万且丑丗且丌丆)
            {
                    return;
            }
            
            if(万且万且丑丗且丌丆 != null)
            {
                    万且万且丑丗且丌丆.layer = 不东丛三丂丌丑专丆;
            }
            else
            {
                    0.layer = 不东丛三丂丌丑专丆;
            }
            
            UnityEngine.Transform val_2 = 万且万且丑丗且丌丆.transform;
            val_7 = val_2.childCount;
            if(val_7 < 1)
            {
                    return;
            }
            
            var val_7 = 0;
            do
            {
                UnityEngine.Transform val_4 = val_2.GetChild(index:  0);
                if(0 != val_4)
            {
                    UnityEngine.GameObject val_6 = val_4.gameObject;
            }
            
                val_7 = val_7 + 1;
            }
            while(val_7 != val_7);
        
        }
        internal static void 且丁丞业丝万丄三丗(UnityEngine.GameObject 万且万且丑丗且丌丆, UnityEngine.Texture 丐丅丁丂丐下丘世丄, UnityEngine.GameObject[] 丕丂丝丗丈三与东专)
        {
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            UnityEngine.GameObject val_19;
            var val_20;
            if(万且万且丑丗且丌丆 != null)
            {
                    val_15 = 万且万且丑丗且丌丆.transform;
            }
            else
            {
                    val_15 = 0.transform;
            }
            
            int val_4 = 万且万且丑丗且丌丆.transform.childCount;
            if(val_4 < 1)
            {
                    return;
            }
            
            var val_16 = 0;
            label_32:
            val_16 = 0;
            UnityEngine.Transform val_5 = val_15.GetChild(index:  0);
            val_17 = 0;
            label_11:
            if(val_17 >= 丕丂丝丗丈三与东专.Length)
            {
                goto label_7;
            }
            
            if(val_17 >= 丕丂丝丗丈三与东专.Length)
            {
                    val_18 = 0;
            }
            
            val_19 = 丕丂丝丗丈三与东专[0];
            val_17 = val_17 + 1;
            if((val_5.gameObject & 1) == 0)
            {
                goto label_11;
            }
            
            goto label_28;
            label_7:
            val_19 = val_5.gameObject.GetComponent<UnityEngine.Renderer>();
            if((UnityEngine.Object.op_Implicit(exists:  val_19)) != false)
            {
                    if((UnityEngine.Object.op_Implicit(exists:  val_19.material)) != false)
            {
                    val_19 = val_19.material;
                val_20 = 0;
                val_19.mainTexture = 丐丅丁丂丐下丘世丄;
            }
            
            }
            
            if(丕丂丝丗丈三与东专.Length < 1)
            {
                goto label_24;
            }
            
            label_29:
            val_17 = 0;
            if(0 >= 丕丂丝丗丈三与东专.Length)
            {
                    val_20 = 0;
            }
            
            val_19 = 丕丂丝丗丈三与东专[val_17];
            if((val_5.gameObject & 1) != 0)
            {
                goto label_28;
            }
            
            if((val_17 + 1) < 丕丂丝丗丈三与东专.Length)
            {
                goto label_29;
            }
            
            label_24:
            UnityEngine.GameObject val_15 = val_5.gameObject;
            label_28:
            val_16 = val_16 + 1;
            if(val_16 != val_4)
            {
                goto label_32;
            }
        
        }
        internal static UnityEngine.Color[] 一不一东与丗七下不(UnityEngine.Color[] 丅丏东三丆丙且业专, int 业与三万七丝不万东, int 丟丌丐丘丆丙丑丑一)
        {
            UnityEngine.Color val_2;
            UnityEngine.Color[] val_1 = new UnityEngine.Color[0];
            int val_3 = 业与三万七丝不万东;
            val_3 = val_3 - 1;
            if()
            {
                    return val_1;
            }
            
            var val_10 = 0;
            do
            {
                if(丟丌丐丘丆丙丑丑一 >= 1)
            {
                    int val_8 = 丟丌丐丘丆丙丑丑一;
                var val_9 = 0;
                do
            {
                int val_4 = val_3;
                val_4 = val_4 + val_9;
                val_2 = 丅丏东三丆丙且业专[(long)val_4];
                val_1[(long)val_10 + val_9] = 丅丏东三丆丙且业专[(long)val_4];
                val_1[(long)val_10 + val_9] = 丅丏东三丆丙且业专[(long)val_4];
                val_1[(long)val_10 + val_9] = val_2;
                val_1[(long)val_10 + val_9] = 丅丏东三丆丙且业专[(long)val_4];
                val_8 = val_8 - 1;
                val_9 = val_9 + 业与三万七丝不万东;
            }
            while(val_8 != 0);
            
            }
            
                val_10 = val_10 + 1;
                int val_11 = val_3;
                val_11 = val_11 - 1;
            }
            while(val_10 != 业与三万七丝不万东);
            
            return val_1;
        }
        internal static UnityEngine.Texture2D 丒丘上丌上七丕丟丟(string 丘丈下丛丙丝世丗丏, Rilisoft.与丄丁丄丙丞下下丙.不专丂丑丕下三丝丟 丁丅丈丌丟世丗丗丟)
        {
            string val_49;
            UnityEngine.Texture val_50;
            System.Byte[] val_51;
            UnityEngine.Texture2D val_52;
            UnityEngine.Texture2D val_53;
            var val_54;
            var val_55;
            int val_56;
            UnityEngine.Color[] val_58;
            var val_59;
            var val_60;
            var val_61;
            val_49 = 丘丈下丛丙丝世丗丏;
            if(((System.String.IsNullOrEmpty(value:  val_49)) == true) || ((val_49.Equals(value:  "empty")) == true))
            {
                goto label_29;
            }
            
            if((val_49.Contains(value:  "avatar")) == false)
            {
                goto label_5;
            }
            
            val_49 = UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "RoyaleAvatars/"("RoyaleAvatars/") + val_49.Replace(oldValue:  ".txt", newValue:  System.String.alignConst)(val_49.Replace(oldValue:  ".txt", newValue:  System.String.alignConst)));
            val_50 = 0;
            if(val_49 != 0)
            {
                    val_49 = val_49.GetComponent<RoyaleAvatar>();
                val_50 = 0;
                if(val_49 != 0)
            {
                    val_50 = val_8.skinTexture;
                if((val_50 != null) && (null != null))
            {
                    val_50 = 0;
            }
            
            }
            
            }
            
            if(val_50 != 0)
            {
                goto label_65;
            }
            
            val_51 = public static UnityEngine.Texture2D UnityEngine.Resources::Load<UnityEngine.Texture2D>(string path);
            val_52 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  与丂丏丛丞丞丒丟丄.与丘丈丙丄与丁丅丟(), 丌丗丏丏丛东专丁且:  "multi_skin_1"));
            if(val_52 != null)
            {
                goto label_28;
            }
            
            goto label_25;
            label_5:
            UnityEngine.Texture2D val_15 = null;
            val_52 = val_15;
            val_15 = new UnityEngine.Texture2D(width:  64, height:  32, textureFormat:  4, mipChain:  false);
            val_51 = System.Convert.FromBase64String(s:  val_49);
            bool val_17 = UnityEngine.ImageConversion.LoadImage(tex:  val_15, data:  val_51);
            if(val_52 != null)
            {
                goto label_28;
            }
            
            label_25:
            label_28:
            if(val_15.width == 64)
            {
                    if(val_15.height == 32)
            {
                goto label_30;
            }
            
            }
            
            label_29:
            val_52 = UnityEngine.Resources.Load<UnityEngine.Texture2D>(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  与丂丏丛丞丞丒丟丄.与丘丈丙丄与丁丅丟(), 丌丗丏丏丛东专丁且:  "multi_skin_1"));
            label_30:
            label_65:
            if(丁丅丈丌丟世丗丗丟 == 1)
            {
                goto label_35;
            }
            
            if(丁丅丈丌丟世丗丗丟 != 0)
            {
                goto label_36;
            }
            
            val_53 = new UnityEngine.Texture2D();
            if(0 == 0)
            {
                goto label_37;
            }
            
            val_54 = 16;
            val_55 = 16;
            goto label_38;
            label_35:
            UnityEngine.Texture2D val_25 = null;
            val_56 = (0 != 0) ? 32 : 16;
            val_53 = val_25;
            val_25 = new UnityEngine.Texture2D(width:  val_56, height:  (0 != 0) ? 28 : 14, textureFormat:  5, mipChain:  false);
            val_49 = 0;
            goto label_39;
            label_43:
            val_56 = public System.Int32 UnityEngine.Texture::get_height();
            if(val_25.height >= 1)
            {
                    var val_49 = 0;
                do
            {
                UnityEngine.Color val_27 = UnityEngine.Color.clear;
                val_25.SetPixel(x:  0, y:  0, color:  new UnityEngine.Color() {r = val_27.r, g = val_27.g, b = val_27.b, a = val_27.a});
                val_49 = val_49 + 1;
                val_56 = public System.Int32 UnityEngine.Texture::get_height();
            }
            while(val_49 < val_25.height);
            
            }
            
            val_49 = 1;
            label_39:
            if(val_49 < val_25.width)
            {
                goto label_43;
            }
            
            if(val_52 == null)
            {
                goto label_44;
            }
            
            if(0 == 0)
            {
                goto label_45;
            }
            
            label_59:
            val_25.SetPixels(x:  8, y:  12, blockWidth:  16, blockHeight:  16, colors:  val_52.GetPixels(x:  16, y:  32, blockWidth:  16, blockHeight:  16));
            if(val_52 == null)
            {
                goto label_46;
            }
            
            val_25.SetPixels(x:  8, y:  0, blockWidth:  16, blockHeight:  12, colors:  val_52.GetPixels(x:  40, y:  12, blockWidth:  16, blockHeight:  12));
            goto label_47;
            label_36:
            0.anisoLevel = 1;
            0.mipMapBias = -0.5f;
            0.Apply();
            val_53 = 0;
            goto label_48;
            label_37:
            val_54 = 8;
            val_55 = 8;
            label_38:
            val_53 = new UnityEngine.Texture2D(width:  8, height:  8, textureFormat:  5, mipChain:  false);
            val_49 = 0;
            goto label_49;
            label_53:
            val_54 = public System.Int32 UnityEngine.Texture::get_height();
            if(new UnityEngine.Texture2D().height >= 1)
            {
                    var val_50 = 0;
                do
            {
                UnityEngine.Color val_34 = UnityEngine.Color.clear;
                new UnityEngine.Texture2D().SetPixel(x:  0, y:  0, color:  new UnityEngine.Color() {r = val_34.r, g = val_34.g, b = val_34.b, a = val_34.a});
                val_50 = val_50 + 1;
                val_54 = public System.Int32 UnityEngine.Texture::get_height();
            }
            while(val_50 < new UnityEngine.Texture2D().height);
            
            }
            
            val_49 = 1;
            label_49:
            if(val_49 < new UnityEngine.Texture2D().width)
            {
                goto label_53;
            }
            
            if(val_52 == null)
            {
                goto label_54;
            }
            
            if(0 == 0)
            {
                goto label_55;
            }
            
            label_57:
            val_58 = val_52.GetPixels(x:  16, y:  32, blockWidth:  16, blockHeight:  16);
            val_59 = 16;
            val_60 = 16;
            goto label_56;
            label_54:
            if(0 != 0)
            {
                goto label_57;
            }
            
            label_55:
            val_58 = val_52.GetPixels(x:  8, y:  16, blockWidth:  8, blockHeight:  8);
            val_59 = 8;
            val_60 = 8;
            label_56:
            val_61 = 0;
            goto label_58;
            label_44:
            if(0 != 0)
            {
                goto label_59;
            }
            
            label_45:
            val_25.SetPixels(x:  4, y:  6, blockWidth:  8, blockHeight:  8, colors:  val_52.GetPixels(x:  8, y:  16, blockWidth:  8, blockHeight:  8));
            if(val_52 == null)
            {
                goto label_60;
            }
            
            val_25.SetPixels(x:  4, y:  0, blockWidth:  8, blockHeight:  6, colors:  val_52.GetPixels(x:  20, y:  6, blockWidth:  8, blockHeight:  6));
            goto label_61;
            label_46:
            val_25.SetPixels(x:  8, y:  0, blockWidth:  16, blockHeight:  12, colors:  0.GetPixels(x:  40, y:  12, blockWidth:  16, blockHeight:  12));
            label_47:
            val_25.SetPixels(x:  0, y:  0, blockWidth:  8, blockHeight:  12, colors:  val_52.GetPixels(x:  88, y:  12, blockWidth:  8, blockHeight:  12));
            val_58 = Rilisoft.与丄丁丄丙丞下下丙.一不一东与丗七下不(丅丏东三丆丙且业专:  val_52.GetPixels(x:  88, y:  12, blockWidth:  8, blockHeight:  12), 业与三万七丝不万东:  8, 丟丌丐丘丆丙丑丑一:  12);
            val_61 = 24;
            val_59 = 8;
            val_60 = 12;
            goto label_63;
            label_60:
            val_25.SetPixels(x:  4, y:  0, blockWidth:  8, blockHeight:  6, colors:  0.GetPixels(x:  20, y:  6, blockWidth:  8, blockHeight:  6));
            label_61:
            val_25.SetPixels(x:  0, y:  0, blockWidth:  4, blockHeight:  6, colors:  val_52.GetPixels(x:  44, y:  6, blockWidth:  4, blockHeight:  6));
            val_58 = Rilisoft.与丄丁丄丙丞下下丙.一不一东与丗七下不(丅丏东三丆丙且业专:  val_52.GetPixels(x:  44, y:  6, blockWidth:  4, blockHeight:  6), 业与三万七丝不万东:  4, 丟丌丐丘丆丙丑丑一:  6);
            val_61 = 12;
            val_59 = 4;
            val_60 = 6;
            label_63:
            label_58:
            val_25.SetPixels(x:  12, y:  0, blockWidth:  4, blockHeight:  6, colors:  val_58);
            val_25.anisoLevel = 1;
            val_25.mipMapBias = -0.5f;
            val_25.Apply();
            label_48:
            val_25.filterMode = 0;
            return (UnityEngine.Texture2D)val_53;
        }
        internal static T 丌丙与丘下丘与三专<T>(string 丌且专不丙丕专丅万)
        {
            bool val_2;
            long val_3;
            bool val_5;
            Rilisoft.CapeMemento val_0;
            val_5 = true;
            if((System.String.IsNullOrEmpty(value:  丌且专不丙丕专丅万)) != false)
            {
                    val_0.cape = 0;
                val_0._capeHashCode.HasValue = false;
                mem[1152921543527458241] = 0;
                val_0.id = 0;
                return val_0;
            }
            
            val_5 = val_2;
            val_0._capeHashCode.HasValue = val_5;
            val_0.id = val_3;
            return val_0;
        }
        internal static long 与丌与丛丂丟丑专与(object[] 丏丆且丟丈丞一专不)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            object val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_23;
            float val_24;
            float val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            if(丏丆且丟丈丞一专不 == null)
            {
                goto label_1;
            }
            
            val_13 = 0;
            if(丏丆且丟丈丞一专不.Length == 0)
            {
                    return (long)val_13;
            }
            
            if(丏丆且丟丈丞一专不.Length < 1)
            {
                    return (long)val_13;
            }
            
            val_14 = 1152921505721910208;
            val_15 = 1152921504624312320;
            val_13 = 0;
            goto label_54;
            label_51:
            if(X21 == null)
            {
                goto label_5;
            }
            
            if(X21 == 0)
            {
                goto label_6;
            }
            
            val_16 = X21;
            if(val_16 == 0)
            {
                    val_16 = 0;
            }
            
            val_17 = 0;
            goto label_8;
            label_12:
            val_18 = 64;
            val_13 = val_13 + ((val_18.Length << 1) << );
            val_17 = 1;
            label_8:
            if(val_17 < 28563616)
            {
                goto label_12;
            }
            
            val_14 = 1152921505721910208;
            val_15 = 1152921504624312320;
            goto label_50;
            label_5:
            label_39:
            val_13 = val_13 + ((X21.Length << 1) << );
            goto label_50;
            label_6:
            if(X21 == 0)
            {
                goto label_15;
            }
            
            val_19 = 1152921506388643840;
            if(X21 == 0)
            {
                    val_19 = 1152921506388643840;
            }
            
            if(X21 == 0)
            {
                    goto label_56;
            }
            
            val_21 = mem[X21 + 24];
            val_21 = X21 + 24;
            val_15 = 1152921504624312320;
            goto label_18;
            label_15:
            if(X21 == 0)
            {
                goto label_19;
            }
            
            val_22 = 1152921504683683840;
            val_23 = X21;
            if(val_23 == 0)
            {
                    val_23 = 0;
            }
            
            val_25 = 8.96831E-44f;
            val_24 = 0f;
            val_18 = 1152921504624312320;
            val_26 = public static System.Int32 System.Runtime.InteropServices.Marshal::SizeOf<UnityEngine.Vector3>(UnityEngine.Vector3 structure);
            int val_6 = System.Runtime.InteropServices.Marshal.SizeOf<UnityEngine.Vector3>(structure:  new UnityEngine.Vector3() {x = val_25, y = val_24, z = 4.656534E-34f});
            goto label_24;
            label_19:
            if(X21 == 0)
            {
                goto label_25;
            }
            
            val_22 = 1152921504683683840;
            val_23 = X21;
            if(val_23 == 0)
            {
                    val_23 = 0;
            }
            
            val_25 = 0f;
            val_24 = 0f;
            val_18 = 1152921504624312320;
            val_26 = public static System.Int32 System.Runtime.InteropServices.Marshal::SizeOf<UnityEngine.Quaternion>(UnityEngine.Quaternion structure);
            label_24:
            var val_14 = 28563616;
            val_14 = 1152921505721910208;
            val_14 = (System.Runtime.InteropServices.Marshal.SizeOf<UnityEngine.Quaternion>(structure:  new UnityEngine.Quaternion() {x = 8.96831E-44f, y = val_25, z = 4.656534E-34f, w = val_24})) * val_14;
            val_13 = val_13 + (val_14 << );
            val_15 = val_18;
            goto label_50;
            label_25:
            if(X21 == 0)
            {
                goto label_31;
            }
            
            val_27 = X21;
            if(val_27 != 0)
            {
                goto label_32;
            }
            
            goto label_33;
            label_31:
            if(X21 == 0)
            {
                goto label_34;
            }
            
            val_27 = X21;
            if(val_27 == 0)
            {
                goto label_35;
            }
            
            label_32:
            var val_15 = X21 + 24;
            val_15 = val_15 << 2;
            goto label_39;
            label_34:
            if(X21 == 0)
            {
                goto label_37;
            }
            
            if(X21 == 0)
            {
                goto label_38;
            }
            
            var val_16 = X21 + 24;
            val_16 = val_16 << 1;
            goto label_39;
            label_37:
            val_18 = "not value type " + X21.GetType();
            UnityEngine.Debug.Log(message:  val_18);
            goto label_50;
            label_54:
            val_18 = 丏丆且丟丈丞一专不[0];
            if(val_18 == null)
            {
                goto label_50;
            }
            
            if(val_18.GetType().IsValueType == false)
            {
                goto label_47;
            }
            
            val_13 = val_13 + ((System.Runtime.InteropServices.Marshal.SizeOf(structure:  val_18)) << );
            goto label_50;
            label_47:
            if(val_18 == null)
            {
                goto label_51;
            }
            
            val_20 = null;
            if(val_18 == null)
            {
                goto label_53;
            }
            
            label_18:
            label_50:
            if((0 + 1) < 丏丆且丟丈丞一专不.Length)
            {
                goto label_54;
            }
            
            return (long)val_13;
            label_1:
            val_13 = 0;
            return (long)val_13;
            label_53:
            label_56:
            goto label_56;
            label_33:
            val_28 = 0;
            goto label_59;
            label_35:
            val_28 = 0;
            goto label_59;
            label_38:
            val_28 = 0;
            label_59:
            val_29 = 0;
        }
        internal static void 丛丗丕丝丁丆丘丝丝(string 丄丙下丝丛丒七丂丘)
        {
            Rilisoft.与丄丁丄丙丞下下丙.丛丗丕丝丁丆丘丝丝(丄丙下丝丛丒七丂丘:  丄丙下丝丛丒七丂丘, 丟丂丈万一不丛万丌:  new System.Action<System.Object>(object:  0, method:  public static System.Void UnityEngine.Debug::Log(object message)));
        }
        internal static void 且且丟丐丞一丌丘东(string 丄丙下丝丛丒七丂丘)
        {
            Rilisoft.与丄丁丄丙丞下下丙.丛丗丕丝丁丆丘丝丝(丄丙下丝丛丒七丂丘:  丄丙下丝丛丒七丂丘, 丟丂丈万一不丛万丌:  new System.Action<System.Object>(object:  0, method:  public static System.Void UnityEngine.Debug::LogWarning(object message)));
        }
        internal static void 丁七丐万丕上丘一丄(string 丄丙下丝丛丒七丂丘)
        {
            Rilisoft.与丄丁丄丙丞下下丙.丛丗丕丝丁丆丘丝丝(丄丙下丝丛丒七丂丘:  丄丙下丝丛丒七丂丘, 丟丂丈万一不丛万丌:  new System.Action<System.Object>(object:  0, method:  public static System.Void UnityEngine.Debug::LogError(object message)));
        }
        private static void 丛丗丕丝丁丆丘丝丝(string 丄丙下丝丛丒七丂丘, System.Action<object> 丟丂丈万一不丛万丌)
        {
            var val_16;
            object val_17;
            var val_18;
            var val_19;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丄丙下丝丛丒七丂丘)) != false)
            {
                    丟丂丈万一不丛万丌.Invoke(obj:  丄丙下丝丛丒七丂丘);
                return;
            }
            
            if(丄丙下丝丛丒七丂丘 != null)
            {
                    val_16 = 丄丙下丝丛丒七丂丘.Length;
            }
            else
            {
                    val_16 = 0.Length;
            }
            
            uint32_t val_4 = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished >> 63;
            丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished >> 38;
            int val_5 = 丄丙下丝丛丒七丂丘.Length;
            uint32_t val_6 = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished >> 63;
            丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished = 丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished >> 38;
            val_18 = 0;
            goto label_7;
            label_16:
            if(1000 <= 丄丙下丝丛丒七丂丘.Length)
            {
                goto label_9;
            }
            
            val_19 = 丄丙下丝丛丒七丂丘.Length - val_18;
            if(丄丙下丝丛丒七丂丘 != null)
            {
                goto label_13;
            }
            
            goto label_12;
            label_9:
            val_19 = 1000;
            if(丄丙下丝丛丒七丂丘 != null)
            {
                goto label_13;
            }
            
            label_12:
            label_13:
            val_17 = System.String.Format(format:  "{0} [{1}/{2}]", arg0:  丄丙下丝丛丒七丂丘.Substring(startIndex:  0, length:  232), arg1:  1, arg2:  ((val_5 - ((((丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished >> 38) >> 38) + ((丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished >> 38) >> 63)) * 1000)) != 0) ? ((((丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished >> 38) + (丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished >> 63))) + 1) : (((丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished >> 38) + (丞东丑专丛丆丄丝世.__il2cppRuntimeField_cctor_finished >> 63))));
            丟丂丈万一不丛万丌.Invoke(obj:  val_17);
            val_18 = 1000 + val_18;
            label_7:
            if(val_18 < 丄丙下丝丛丒七丂丘.Length)
            {
                goto label_16;
            }
        
        }
        public 与丄丁丄丙丞下下丙()
        {
        
        }
    
    }

}
