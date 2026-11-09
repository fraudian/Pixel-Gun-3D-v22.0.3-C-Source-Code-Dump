using UnityEngine;

namespace PGCompany.Ads.AdvertisingChestWindowMachinery
{
    internal abstract class 丙丟与丐三丐万万丆 : IState<PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆>
    {
        // Fields
        private bool 丘丄丆不丛丗上三上;
        
        // Properties
        private static bool 丂与丑三丐丌丐丘丁 { get; }
        protected bool 丅业东万丌丕上丌丄 { get; }
        
        // Methods
        private static bool 世丈且业丆丑丏丐一()
        {
            return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
        }
        protected bool 丈丐丞丐上丑且丕万()
        {
            return (bool)this.丘丄丆不丛丗上三上;
        }
        public bool TryCreateNewState(PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上 丙不不丒丁丄丄与丛, out PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 与丆丌丂丟丛丘丑且)
        {
            if(PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆.世丈且业丆丑丏丐一() == false)
            {
                    return false;
            }
            
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "[{0}] this: {1}, ev: {2}", arg0:  "TryCreateNewState", arg1:  this.GetType(), arg2:  丙不不丒丁丄丄与丛));
            return false;
        }
        public void OnExiting(PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上 丙不不丒丁丄丄与丛, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 与丆丌丂丟丛丘丑且)
        {
            object val_6;
            if(PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆.世丈且业丆丑丏丐一() != false)
            {
                    object[] val_2 = new object[4];
                val_2[0] = "OnExiting";
                val_2[1] = 与丆丌丂丟丛丘丑且.GetType();
                val_2[2] = 丙不不丒丁丄丄与丛;
                val_2[3] = 与丆丌丂丟丛丘丑且.GetType();
                val_6 = System.String.Format(format:  "[{0}] this: {1}, ev: {2}, newState: {3}", args:  val_2);
                UnityEngine.Debug.Log(message:  val_6);
            }
            
            this.丘丄丆不丛丗上三上 = false;
        }
        public void OnRemain(PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上 丙不不丒丁丄丄与丛)
        {
            if(PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆.世丈且业丆丑丏丐一() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "[{0}] this: {1}, ev: {2}", arg0:  "OnRemain", arg1:  this.GetType(), arg2:  丙不不丒丁丄丄与丛));
        }
        public void OnEntered(PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上 丙不不丒丁丄丄与丛, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 且东丁丄业世丞丁不)
        {
            object val_6;
            if(PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆.世丈且业丆丑丏丐一() != false)
            {
                    object[] val_2 = new object[4];
                val_2[0] = "OnEntered";
                val_2[1] = 且东丁丄业世丞丁不.GetType();
                val_2[2] = 丙不不丒丁丄丄与丛;
                val_2[3] = 且东丁丄业世丞丁不.GetType();
                val_6 = System.String.Format(format:  "[{0}] this: {1}, ev: {2}, oldState: {3}", args:  val_2);
                UnityEngine.Debug.Log(message:  val_6);
            }
            
            this.丘丄丆不丛丗上三上 = true;
        }
        protected static bool 丁且丐丘世业丌不一(PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 世一丐上丒丄与丌业, out PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 与丆丌丂丟丛丘丑且)
        {
            与丆丌丂丟丛丘丑且 = 世一丐上丒丄与丌业;
            return true;
        }
        protected static bool 业丅丑业上三下丆与(out PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 与丆丌丂丟丛丘丑且)
        {
            与丆丌丂丟丛丘丑且 = 0;
            return false;
        }
        protected abstract bool 丝丟万上上丛不丒且(PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上 丙不不丒丁丄丄与丛, out PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 与丆丌丂丟丛丘丑且); // 0
        protected virtual void 七业东业与丕万下丂(PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上 丙不不丒丁丄丄与丛, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 与丆丌丂丟丛丘丑且)
        {
        
        }
        protected virtual void 丄东东万丗丂丆上且(PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上 丙不不丒丁丄丄与丛)
        {
        
        }
        protected virtual void 且丘世丘丁丑东丅上(PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七 与且专丈不万东一万, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上 丙不不丒丁丄丄与丛, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 且东丁丄业世丞丁不)
        {
        
        }
        protected bool 专丙丐专丐丁丞丞丏(out PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 与丆丌丂丟丛丘丑且)
        {
            PGCompany.Ads.AdvertisingChestWindowMachinery.丒一丁且专丐丕东不 val_4;
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) != false)
            {
                    val_4 = this.丌丁丘丟丈与丌三丘(业丅与与丝丄专丞七:  new System.DateTime());
            }
            else
            {
                    PGCompany.Ads.AdvertisingChestWindowMachinery.丒一丁且专丐丕东不 val_3 = null;
                val_4 = val_3;
                val_3 = new PGCompany.Ads.AdvertisingChestWindowMachinery.丒一丁且专丐丕东不();
                .下丘与业丗丙且业丑 = "TryGetServerUniversalTime";
            }
            
            与丆丌丂丟丛丘丑且 = val_4;
            return true;
        }
        protected bool 专丙丐专丐丁丞丞丏(System.DateTime 业丅与与丝丄专丞七, out PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 与丆丌丂丟丛丘丑且)
        {
            与丆丌丂丟丛丘丑且 = this.丌丁丘丟丈与丌三丘(业丅与与丝丄专丞七:  new System.DateTime() {dateData = 业丅与与丝丄专丞七.dateData});
            return true;
        }
        private PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 丌丁丘丟丈与丌三丘(System.DateTime 业丅与与丝丄专丞七)
        {
            var val_11;
            string val_2 = 0;
            string val_7 = 0;
            if((PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌: out  val_2, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  val_7)) != false)
            {
                    val_11 = this.丌丁丘丟丈与丌三丘(业丅与与丝丄专丞七:  new System.DateTime() {dateData = 业丅与与丝丄专丞七.dateData}, 丅专与丒丈丗丒丘丌:  val_2);
                return (PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆)val_11;
            }
            
            PGCompany.Ads.AdvertisingChestWindowMachinery.丒一丁且专丐丕东不 val_10 = null;
            val_11 = val_10;
            val_10 = new PGCompany.Ads.AdvertisingChestWindowMachinery.丒一丁且专丐丕东不();
            .下丘与业丗丙且业丑 = val_7;
            return (PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆)val_11;
        }
        private PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 丌丁丘丟丈与丌三丘(System.DateTime 业丅与与丝丄专丞七, string 丅专与丒丈丗丒丘丌)
        {
            丕丄丘不专丘七专与 val_54;
            long val_55;
            string val_56;
            string val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_65;
            var val_66;
            System.TimeSpan val_67;
            string val_3 = 0;
            丕丄丘不专丘七专与 val_5 = 0;
            丅丒不上七丘万丙一 val_4 = 0;
            System.Collections.Generic.IReadOnlyList<PGCompany.三东丏不丗世丅丌丄> val_12 = 0;
            string val_6 = 0;
            string val_14 = 0;
            PGCompany.Ads.AdvertisingChestWindowMachinery.丐不与丞东丛丝丕与 val_37 = 0;
            PGCompany.Ads.AdvertisingChestWindowMachinery.丐不与丞东丛丝丕与 val_28 = 0;
            val_54 = Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世();
            if((val_54.万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  val_3, 丟丐丗万丅下丗丝万: out  val_4, 丌东丙丝丂一丅三丞: out  val_5, 丏丞专丏业丗丝七丝: out  val_6)) == false)
            {
                goto label_39;
            }
            
            if((System.String.Equals(a:  丅专与丒丈丗丒丘丌, b:  "chestInLobbyNovice", comparisonType:  4)) == false)
            {
                goto label_5;
            }
            
            val_54 = PGCompany.Ads.丅七丘丂与丆丛专丅.丑七不且上丗丁一世();
            if((val_54.业且万丝丛东丂丄丑(丏丞专丏业丗丝七丝: out  val_6)) == true)
            {
                goto label_39;
            }
            
            label_5:
            val_55 = 1152921505691721728;
            val_54 = val_5;
            if((PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().丂丗世丕七丈且丒丒(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌, 丌东丙丝丂一丅三丞:  val_54, 上业丟世三与七七三: out  val_12, 丏丞专丏业丗丝七丝: out  val_6)) == false)
            {
                goto label_39;
            }
            
            if((PGCompany.丙丁东丅丒上世与东.丏丙丑丑丘丛丏丗丛(丞丅上丏丂且下丅与: out  val_14)) == false)
            {
                goto label_12;
            }
            
            System.TimeSpan val_17 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().业丞不上丞丛三与万(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌, 丟丐丗万丅下丗丝万:  val_4, 丌东丙丝丂一丅三丞:  val_5);
            val_55 = val_17._ticks;
            System.DateTime val_18 = PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.丝丞且丈东丅丟丏与(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌);
            System.DateTime val_19 = PGCompany.万下丂且东丌一丌丆.万下专丒丞丒丘与丐(不丗万丘丆丗上丗丏:  new System.DateTime() {dateData = val_18.dateData}, 丙业与丙丗丝不丈东:  new System.TimeSpan() {_ticks = val_55});
            val_54 = val_19.dateData;
            丐不与丞东丛丝丕与.丟一丙丑丈丙一与业 val_20 = new 丐不与丞东丛丝丕与.丟一丙丑丈丙一与业();
            if(val_20 == null)
            {
                goto label_20;
            }
            
            .世且丄一丑下丝丟丕 = 丅专与丒丈丗丒丘丌;
            .专丄丌且一丕万与丛 = val_3;
            丐不与丞东丛丝丕与.丟一丙丑丈丙一与业 val_21 = val_20.丄丕丅丙丟丗不下丐(业丅与与丝丄专丞七:  new System.DateTime() {dateData = 业丅与与丝丄专丞七.dateData});
            val_56 = val_14;
            goto label_21;
            label_12:
            val_58 = "TryGetId";
            goto label_22;
            label_20:
            mem[16] = 丅专与丒丈丗丒丘丌;
            mem[24] = val_3;
            丐不与丞东丛丝丕与.丟一丙丑丈丙一与业 val_22 = val_20.丄丕丅丙丟丗不下丐(业丅与与丝丄专丞七:  new System.DateTime() {dateData = 业丅与与丝丄专丞七.dateData});
            val_56 = val_14;
            label_21:
            .不不丗丒丞上丅丌东 = val_56;
            var val_23 = val_4 + 32;
            丐不与丞东丛丝丕与.丟一丙丑丈丙一与业 val_24 = val_20.不丆与丅丝丂与与丘(与丆丞丝丕丁丁丏万:  10f);
            .专丙丌一与业三专丛 = val_12;
            if((System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_54}, t2:  new System.DateTime() {dateData = 业丅与与丝丄专丞七.dateData})) == false)
            {
                goto label_26;
            }
            
            PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.且丂世丈丅丛世丙一(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌, 丂丄业丄丛丅丈丄丂:  new System.DateTime() {dateData = 业丅与与丝丄专丞七.dateData});
            PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.专七一业与丆一三一(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌);
            System.DateTime val_26 = PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.丆丈丗丈业丄丙东专();
            .丆丏世丐丘不丂丘丒 = val_26;
            .不丟丙丛丄丂业丟丏 = -2147483648;
            if((val_20.丟上一与东一丕丂一(一一不丆且丏七七丘:  0).业世上丅丐东丏丛丆(东且丁丆丛丁丏丘且: out  val_28, 丏丞专丏业丗丝七丝: out  val_6)) == false)
            {
                goto label_39;
            }
            
            if(((this == null) || (null != null)) || ((val_5 + 20.GetValueOrDefault()) == false))
            {
                goto label_33;
            }
            
            label_83:
            PGCompany.Ads.AdvertisingChestWindowMachinery.丘万上丏丞丆万丈丌 val_32 = null;
            val_59 = val_32;
            val_32 = new PGCompany.Ads.AdvertisingChestWindowMachinery.丘万上丏丞丆万丈丌(丆世不丝与丁三世业:  val_28);
            return (PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆)val_59;
            label_26:
            System.Collections.Generic.KeyValuePair<System.DateTime, System.Int32> val_33 = PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.东丅丁万与丝丘丐不(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌);
            .丆丏世丐丘不丂丘丒 = val_33.Value.丐丏七丌丕丗业且上();
            .不丟丙丛丄丂业丟丏 = val_33.Value;
            val_55 = System.Math.Max(val1:  0, val2:  -127963592);
            if((val_20.丟上一与东一丕丂一(一一不丆且丏七七丘:  val_55).业世上丅丐东丏丛丆(东且丁丆丛丁丏丘且: out  val_37, 丏丞专丏业丗丝七丝: out  val_6)) == false)
            {
                goto label_39;
            }
            
            var val_61 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_41;
            }
            
            var val_59 = mem[282584257676847];
            var val_60 = 0;
            val_59 = val_59 + 8;
            label_43:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_42;
            }
            
            val_60 = val_60 + 1;
            val_59 = val_59 + 16;
            if(val_60 < mem[282584257676957])
            {
                goto label_43;
            }
            
            label_41:
            val_60 = 0;
            goto label_44;
            label_39:
            val_58 = val_6;
            PGCompany.Ads.AdvertisingChestWindowMachinery.丒一丁且专丐丕东不 val_39 = null;
            label_22:
            val_59 = val_39;
            val_39 = new PGCompany.Ads.AdvertisingChestWindowMachinery.丒一丁且专丐丕东不();
            .下丘与业丗丙且业丑 = val_58;
            return (PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆)val_59;
            label_33:
            System.DateTime val_40 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = 业丅与与丝丄专丞七.dateData}, t:  new System.TimeSpan() {_ticks = val_55});
            label_84:
            PGCompany.Ads.AdvertisingChestWindowMachinery.三与丑丝丌一三丝丞 val_41 = new PGCompany.Ads.AdvertisingChestWindowMachinery.三与丑丝丌一三丝丞(丆世不丝与丁三世业:  val_28, 不丝丂业丙丌丙丗丙:  new System.DateTime() {dateData = val_40.dateData});
            return (PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆)val_59;
            label_42:
            val_61 = val_61 + (((mem[282584257676847] + 8)) << 4);
            val_61 = val_61 + 296;
            label_44:
            if(val_55 < val_12.Count)
            {
                    val_62 = 135970152;
                if(val_62 == 0)
            {
                    val_62 = System.Array.Empty<System.Single>();
            }
            
                var val_62 = 0;
                val_62 = val_62 + 1;
                val_60 = 0;
            }
            else
            {
                    if((System.String.Equals(a:  丅专与丒丈丗丒丘丌, b:  "chestInLobbyNovice", comparisonType:  4)) != false)
            {
                    PGCompany.Ads.丅七丘丂与丆丛专丅.丑七不且上丗丁一世().且丒丟丛丗丌一七丟(丁丂丕与丁丒丕丟丞:  "AllRewardsCollectedState");
                PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.丙丒丛三丛上与一丅(丅专与丒丈丗丒丘丌:  丅专与丒丈丗丒丘丌);
                return (PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆)val_59;
            }
            
                PGCompany.Ads.AdvertisingChestWindowMachinery.丗万丆万一丑上丙丂 val_47 = new PGCompany.Ads.AdvertisingChestWindowMachinery.丗万丆万一丑上丙丂(丆世不丝与丁三世业:  val_37, 不丝丂业丙丌丙丗丙:  new System.DateTime() {dateData = val_54});
                return (PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆)val_59;
            }
            
            if(val_55 >= val_62.Count)
            {
                goto label_63;
            }
            
            var val_63 = 0;
            val_63 = val_63 + 1;
            val_60 = 0;
            goto label_68;
            label_63:
            val_65 = null;
            val_66 = 1152921540874342432;
            val_67 = System.TimeSpan.Zero;
            goto label_72;
            label_68:
            T val_50 = val_62.Item[val_55];
            System.TimeSpan val_51 = System.TimeSpan.FromMinutes(value:  (double)10f);
            val_66 = 1152921540874342432;
            val_67 = val_51._ticks;
            label_72:
            System.DateTime val_53 = System.DateTime.op_Addition(d:  new System.DateTime() {dateData = val_33.Value.丐丏七丌丕丗业且上()}, t:  new System.TimeSpan() {_ticks = val_67});
            System.DateTime val_54 = val_53.dateData.ToUniversalTime();
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime() {dateData = val_54.dateData}, t2:  new System.DateTime() {dateData = 业丅与与丝丄专丞七.dateData})) != false)
            {
                    PGCompany.Ads.AdvertisingChestWindowMachinery.丟丑业丟世丄丒与丅 val_56 = new PGCompany.Ads.AdvertisingChestWindowMachinery.丟丑业丟世丄丒与丅(丆世不丝与丁三世业:  val_37, 不丝丂业丙丌丙丗丙:  new System.DateTime() {dateData = val_54}, 丙与丞与丘丄丝丆三:  new System.DateTime() {dateData = val_54.dateData});
                return (PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆)val_59;
            }
            
            if(((this == null) || (null != null)) || ((val_5 + 20.GetValueOrDefault()) == false))
            {
                goto label_84;
            }
            
            goto label_83;
        }
        protected 丙丟与丐三丐万万丆()
        {
        
        }
    
    }

}
