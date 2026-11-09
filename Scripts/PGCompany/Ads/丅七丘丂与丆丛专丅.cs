using UnityEngine;

namespace PGCompany.Ads
{
    internal sealed class 丅七丘丂与丆丛专丅
    {
        // Fields
        private const Progress.与丄东丄丘丐丙丅业 丑下丝万不丝丙东与 = 157;
        private const Progress.与丄东丄丘丐丙丅业 三丂丗丅丝三丒丈丅 = 158;
        private static PGCompany.Ads.丅七丘丂与丆丛专丅 世丒丞七专三与万丕;
        private System.Nullable<bool> 丒丑万丛丈丈丙七不;
        private System.Nullable<bool> 丟七下丁一丑丕丟丞;
        
        // Properties
        internal static PGCompany.Ads.丅七丘丂与丆丛专丅 丆丕丝丒不丙且丐丗 { get; }
        internal bool 且丗丙丗万与丒东丐 { get; }
        internal bool 万丛丗丄丗下丐丄不 { get; }
        
        // Methods
        private 丅七丘丂与丆丛专丅()
        {
        
        }
        internal static PGCompany.Ads.丅七丘丂与丆丛专丅 丑七不且上丗丁一世()
        {
            if(PGCompany.Ads.丅七丘丂与丆丛专丅.世丒丞七专三与万丕 != null)
            {
                    return val_1;
            }
            
            PGCompany.Ads.丅七丘丂与丆丛专丅 val_1 = PGCompany.Ads.丅七丘丂与丆丛专丅.东丝七业丄丑丒世七();
            PGCompany.Ads.丅七丘丂与丆丛专丅.世丒丞七专三与万丕 = val_1;
            return val_1;
        }
        internal bool 丛丝丟丅上下不丒东()
        {
            if((this.丟七下丁一丑丕丟丞 & 1) != 0)
            {
                    return (bool)this.丟七下丁一丑丕丟丞.GetValueOrDefault();
            }
            
            bool val_3 = PGCompany.丆丁业万丁七专且东.丁丅不丈上丝丟丛且(下上丐丆丝丟丝丒不:  157, 丙业与丙丗丝不丈东: out  0);
            mem2[0] = 0;
            return (bool)this.丟七下丁一丑丕丟丞.GetValueOrDefault();
        }
        internal bool 丌丛世丞上丕与丙下()
        {
            if((this.丒丑万丛丈丈丙七不 & 1) != 0)
            {
                    return (bool)this.丒丑万丛丈丈丙七不.GetValueOrDefault();
            }
            
            bool val_3 = PGCompany.丆丁业万丁七专且东.丁丅不丈上丝丟丛且(下上丐丆丝丟丝丒不:  158, 丙业与丙丗丝不丈东: out  0);
            mem2[0] = 0;
            return (bool)this.丒丑万丛丈丈丙七不.GetValueOrDefault();
        }
        private static PGCompany.Ads.丅七丘丂与丆丛专丅 东丝七业丄丑丒世七()
        {
            PGCompany.Ads.丅七丘丂与丆丛专丅 val_1 = new PGCompany.Ads.丅七丘丂与丆丛专丅();
            业丞丝东丅丞丐丌专.丘丒丟丙业丗上与专(丙业与丙丗丝不丈东:  new System.Action(object:  val_1, method:  System.Void PGCompany.Ads.丅七丘丂与丆丛专丅::丆三丁丂三丙七丐一()));
            AuthSceneController.下不丞丒丘丄丈世丝(丙业与丙丗丝不丈东:  new System.Action(object:  val_1, method:  System.Void PGCompany.Ads.丅七丘丂与丆丛专丅::丈下丅丝丈世丑下丗()));
            业丞丝东丅丞丐丌专.上三专七丗丗世丟丏(丙业与丙丗丝不丈东:  new System.Action(object:  val_1, method:  System.Void PGCompany.Ads.丅七丘丂与丆丛专丅::丛丕丁下丒丞丗上丌()));
            return val_1;
        }
        internal static System.TimeSpan 业丞不上丞丛三与万(System.Nullable<float> 丐不丏不丏丐不丅丒)
        {
            var val_3;
            System.TimeSpan val_4;
            float val_1 = 丐不丏不丏丐不丅丒.HasValue.x;
            val_3 = null;
            if(val_1 == 0f)
            {
                    val_3 = null;
                val_4 = System.TimeSpan.MaxValue;
                return (System.TimeSpan)val_2._ticks;
            }
            
            System.TimeSpan val_2 = System.TimeSpan.FromHours(value:  (double)val_1);
            return (System.TimeSpan)val_2._ticks;
        }
        internal bool 丐丕三不丆丁上丄三()
        {
            return this.丛丝丟丅上下不丒东();
        }
        internal bool 丆一丗业专不丈丟丌()
        {
            return (bool)this.丆一丗业专不丈丟丌(丏丞专丏业丗丝七丝: out  0);
        }
        internal bool 丆一丗业专不丈丟丌(out string 丏丞专丏业丗丝七丝)
        {
            string val_6;
            if(this.丌丛世丞上丕与丙下() != false)
            {
                    val_6 = "ChestForNovice.IsExpired: IsMarkedAsExpired";
                return PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_6 = "ChestForNovice.IsExpired: IsExpiredByMaxLevel", 丄丙下丝丛丒七丂丘: out  string val_5 = 丏丞专丏业丗丝七丝);
            }
            
            bool val_2 = this.丛丝丟丅上下不丒东();
            if(val_2 != false)
            {
                    if(val_2.丂丕丂一丕丗丗丏丞() == false)
            {
                    return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "ChestForNovice.IsExpired: false", 丄丙下丝丛丒七丂丘: out  val_5);
            }
            
                this.且丒丟丛丗丌一七丟(丁丂丕与丁丒丕丟丞:  "IsExpiredBySeriesDuration");
                val_6 = "ChestForNovice.IsExpired: IsExpiredBySeriesDuration";
                return PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_6, 丄丙下丝丛丒七丂丘: out  val_5);
            }
            
            if(val_2.丑万丑专丑且下与丁() == false)
            {
                    return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "ChestForNovice.IsExpired: false", 丄丙下丝丛丒七丂丘: out  val_5);
            }
            
            return PGCompany.七丂丛丞丏下七业业.下丟丂丌丛丁上上丑(东丒丝不上丛丒丌丄:  val_6, 丄丙下丝丛丒七丂丘: out  val_5);
        }
        internal bool 业且万丝丛东丂丄丑()
        {
            return (bool)this.业且万丝丛东丂丄丑(丏丞专丏业丗丝七丝: out  0);
        }
        internal bool 业且万丝丛东丂丄丑(out string 丏丞专丏业丗丝七丝)
        {
            if(this.丛丝丟丅上下不丒东() != false)
            {
                    return PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  "ChestForNovice.IsLocked: IsMarkedAsStarted", 丄丙下丝丛丒七丂丘: out  string val_2 = 丏丞专丏业丗丝七丝);
            }
            
            bool val_3 = 丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.adschest");
            val_3 = (~val_3) & 1;
            丏丞专丏业丗丝七丝 = (val_3 != true) ? "ChestForNovice.IsLocked: false" : "ChestForNovice.IsLocked: feature.adschest";
            return (bool)val_3;
        }
        internal bool 丄业丐丟丙万不世丈(out string 丏丞专丏业丗丝七丝)
        {
            var val_4;
            if((this.业且万丝丛东丂丄丑(丏丞专丏业丗丝七丝: out  string val_1 = 丏丞专丏业丗丝七丝)) != true)
            {
                    if((this.丆一丗业专不丈丟丌(丏丞专丏业丗丝七丝: out  val_1)) == false)
            {
                goto label_2;
            }
            
            }
            
            val_4 = 1;
            return (bool)val_4;
            label_2:
            val_4 = 0;
            丏丞专丏业丗丝七丝 = "ChestForNovice.IsLockedOrExpired: false";
            return (bool)val_4;
        }
        internal bool 业七丗东丅丞业丆丁(out string 丏丞专丏业丗丝七丝)
        {
            string val_13;
            string val_4 = 0;
            if(业丞丝东丅丞丐丌专.丑七不且上丗丁一世().下不丙丌丙丞丞万上() == false)
            {
                goto label_4;
            }
            
            if((PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌: out  val_4, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  string val_9 = 丏丞专丏业丗丝七丝)) == false)
            {
                goto label_8;
            }
            
            if((System.String.Equals(a:  "chestInLobbyNovice", b:  val_4, comparisonType:  4)) == false)
            {
                goto label_12;
            }
            
            val_13 = 1;
            goto label_11;
            label_4:
            val_13 = "IsAuthorized: false";
            label_12:
            bool val_12 = PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_13, 丄丙下丝丛丒七丂丘: out  val_9);
            goto label_11;
            label_8:
            val_13 = 0;
            label_11:
            val_13 = val_13 & 1;
            return (bool)val_13;
        }
        internal void 丏丈丌丐丟丝丞丈业(System.Collections.Generic.IReadOnlyList<PGCompany.三东丏不丗世丅丌丄> 上业丟世三与七七三)
        {
            object val_8;
            var val_9;
            val_8 = 上业丟世三与七七三;
            if(val_8 == null)
            {
                    return;
            }
            
            if(this.丟七下丁一丑丕丟丞.GetValueOrDefault() == true)
            {
                    return;
            }
            
            val_9 = 0;
            mem2[0] = 0;
            if((PGCompany.丆丁业万丁七专且东.丁丅不丈上丝丟丛且(下上丐丆丝丟丝丒不:  157, 丙业与丙丗丝不丈东: out  0)) == true)
            {
                    return;
            }
            
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = 0;
            val_8 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_8);
            PGCompany.丆丁业万丁七专且东.且且世专与丒丌专世(下上丐丆丝丟丝丒不:  157, 丙业与丙丗丝不丈东:  val_8);
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() == false)
            {
                    return;
            }
            
            UnityEngine.PlayerPrefs.SetString(key:  System.String.Format(format:  "Ads.Debug.{0}", arg0:  157), value:  val_8);
        }
        internal void 且丒丟丛丗丌一七丟(string 丁丂丕与丁丒丕丟丞)
        {
            if((System.String.IsNullOrEmpty(value:  丁丂丕与丁丒丕丟丞)) == true)
            {
                    return;
            }
            
            if(this.丒丑万丛丈丈丙七不.GetValueOrDefault() == true)
            {
                    return;
            }
            
            mem2[0] = 0;
            if((PGCompany.丆丁业万丁七专且东.丁丅不丈上丝丟丛且(下上丐丆丝丟丝丒不:  158, 丙业与丙丗丝不丈东: out  0)) == true)
            {
                    return;
            }
            
            PGCompany.丆丁业万丁七专且东.且且世专与丒丌专世(下上丐丆丝丟丝丒不:  158, 丙业与丙丗丝不丈东:  丁丂丕与丁丒丕丟丞);
        }
        internal bool 丕不一东下丅丒业丏(out PGCompany.三东丏不丗世丅丌丄 丙业与丙丗丝不丈东, out string 丏丞专丏业丗丝七丝)
        {
            string val_18;
            丕丄丘不专丘七专与 val_19;
            var val_20;
            var val_21;
            var val_22;
            string val_23;
            var val_24;
            丕丄丘不专丘七专与 val_6 = 0;
            string val_2 = 0;
            System.Collections.Generic.IReadOnlyList<PGCompany.三东丏不丗世丅丌丄> val_11 = 0;
            丙业与丙丗丝不丈东 = 0;
            val_18 = PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世();
            if((val_18.万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌: out  val_2, 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  val_6, 丏丞专丏业丗丝七丝: out  string val_7 = 丏丞专丏业丗丝七丝)) == false)
            {
                goto label_9;
            }
            
            val_18 = val_2;
            if((System.String.Equals(a:  val_18, b:  "chestInLobbyNovice", comparisonType:  4)) == false)
            {
                goto label_5;
            }
            
            val_19 = val_6;
            if((PGCompany.Ads.丈丑丝一一一丅上且.丑七不且上丗丁一世().丂丗世丕七丈且丒丒(丅专与丒丈丗丒丘丌:  val_18, 丌东丙丝丂一丅三丞:  val_19, 上业丟世三与七七三: out  val_11, 丏丞专丏业丗丝七丝: out  val_7)) == false)
            {
                goto label_9;
            }
            
            val_18 = val_11;
            var val_20 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_11;
            }
            
            var val_18 = mem[282584257676847];
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_13:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_12;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < mem[282584257676957])
            {
                goto label_13;
            }
            
            label_11:
            val_19 = 0;
            goto label_14;
            label_9:
            val_21 = 0;
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_23 = "lastReward: 0", 丄丙下丝丛丒七丂丘: out  val_7);
            label_5:
            val_21 = val_18;
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_23, 丄丙下丝丛丒七丂丘: out  val_7);
            label_12:
            val_20 = val_20 + (((mem[282584257676847] + 8)) << 4);
            val_20 = val_20 + 296;
            label_14:
            if(val_18.Count == 0)
            {
                goto label_17;
            }
            
            var val_23 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_19;
            }
            
            var val_21 = mem[282584257676847];
            var val_22 = 0;
            val_21 = val_21 + 8;
            label_21:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_20;
            }
            
            val_22 = val_22 + 1;
            val_21 = val_21 + 16;
            if(val_22 < mem[282584257676957])
            {
                goto label_21;
            }
            
            label_19:
            val_19 = 0;
            goto label_22;
            label_17:
            val_23 = "Count: 0";
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_23, 丄丙下丝丛丒七丂丘: out  val_7);
            label_20:
            val_23 = val_23 + (((mem[282584257676847] + 8)) << 4);
            val_22 = val_23 + 296;
            label_22:
            int val_24 = val_18.Count;
            var val_27 = 1179403647;
            val_24 = val_24 - 1;
            if(mem[282584257676957] == 0)
            {
                goto label_25;
            }
            
            var val_25 = mem[282584257676847];
            var val_26 = 0;
            val_25 = val_25 + 8;
            label_27:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_26;
            }
            
            val_26 = val_26 + 1;
            val_25 = val_25 + 16;
            if(val_26 < mem[282584257676957])
            {
                goto label_27;
            }
            
            label_25:
            val_19 = 0;
            goto label_28;
            label_26:
            val_27 = val_27 + (((mem[282584257676847] + 8)) << 4);
            val_24 = val_27 + 296;
            label_28:
            T val_15 = val_18.Item[val_24];
            if(val_15 != 0)
            {
                    丙业与丙丗丝不丈东 = val_15;
                val_21 = 1;
                return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_23, 丄丙下丝丛丒七丂丘: out  val_7);
            }
            
            return (bool)PGCompany.七丂丛丞丏下七业业.丁丂专丝丑丗丅业丑(东丒丝不上丛丒丌丄:  val_23, 丄丙下丝丛丒七丂丘: out  val_7);
        }
        internal PGCompany.三东丏不丗世丅丌丄 丈七丑三丞与丟三专()
        {
            PGCompany.三东丏不丗世丅丌丄 val_1 = 0;
            bool val_3 = this.丕不一东下丅丒业丏(丙业与丙丗丝不丈东: out  val_1, 丏丞专丏业丗丝七丝: out  0);
            return val_1;
        }
        private void 丆三丁丂三丙七丐一()
        {
            this.丒丑万丛丈丈丙七不 = 0;
        }
        private void 丈下丅丝丈世丑下丗()
        {
            this.丒丑万丛丈丈丙七不 = 0;
        }
        private void 丛丕丁下丒丞丗上丌()
        {
            this.丒丑万丛丈丈丙七不 = 0;
        }
        private void 丐丌丏丛与丒专丁七()
        {
            this.丒丑万丛丈丈丙七不 = 0;
        }
        private bool 丂丕丂一丕丗丗丏丞()
        {
            var val_13;
            ulong val_14;
            if((PGCompany.且世万丐七丆丛丄丌.丗上丌与三丟东东世(东且丁丆丛丁丏丘且: out  new System.DateTime())) == false)
            {
                goto label_8;
            }
            
            val_13 = Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世();
            if(((val_13.万丞丆丁一丆丑丈丕(丅专与丒丈丗丒丘丌:  "chestInLobbyNovice", 上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  0, 丌东丙丝丂一丅三丞: out  0, 丏丞专丏业丗丝七丝: out  0)) == false) || ((PGCompany.Ads.AdvertisingChestWindowMachinery.东丆东丆丒七东上丒.丝丁丈丄上一丅丛丒(丅专与丒丈丗丒丘丌:  "chestInLobbyNovice", 丙业与丙丗丝不丈东: out  new System.DateTime())) == false))
            {
                goto label_8;
            }
            
            System.TimeSpan val_10 = PGCompany.Ads.丅七丘丂与丆丛专丅.业丞不上丞丛三与万(丐不丏不丏丐不丅丒:  new System.Nullable<System.Single>() {HasValue = false});
            System.DateTime val_11 = PGCompany.万下丂且东丌一丌丆.万下专丒丞丒丘与丐(不丗万丘丆丗上丗丏:  new System.DateTime(), 丙业与丙丗丝不丈东:  new System.TimeSpan() {_ticks = val_10._ticks});
            val_13 = 0;
            val_14 = val_11.dateData;
            bool val_12 = System.DateTime.op_LessThanOrEqual(t1:  new System.DateTime() {dateData = val_14}, t2:  new System.DateTime());
            goto label_14;
            label_8:
            val_14 = 0;
            label_14:
            val_14 = val_14 & 1;
            return (bool)val_14;
        }
        private bool 丑万丑专丑且下与丁()
        {
            var val_8;
            丅丒不上七丘万丙一 val_4 = 0;
            if((Rilisoft.万丅丐丄丑万东不丑.丑七不且上丗丁一世().丑丛丞三下业丁下三(上世丏丁世丟世丆业: out  0, 七丆丒与丗丌丄且丂: out  0, 丟丐丗万丅下丗丝万: out  val_4, 丏丞专丏业丗丝七丝: out  0)) != false)
            {
                    if(ExperienceController.丞丞丘业东丙丏七丌() >= (val_4 + 48))
            {
                goto label_8;
            }
            
            }
            
            val_8 = 0;
            return (bool)val_8;
            label_8:
            val_8 = 1;
            return (bool)val_8;
        }
    
    }

}
