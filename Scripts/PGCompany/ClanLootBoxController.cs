using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanLootBoxController : Singleton<PGCompany.ClanLootBoxController>
    {
        // Fields
        internal static string 七丗丏与万一且七丕;
        internal static string 丟丈丏丞丘丒丙东丌;
        internal static string 丈业丗万万丅丁与丞;
        internal static string 丙专丄丏丐丟不丅丑;
        private static System.Action 丕丛三丈丄专丅三丆;
        private static System.Action 且三丆丌业丌七丑丟;
        private readonly System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 丒丕丆且三万与丞丄;
        private readonly System.Collections.Generic.Dictionary<PGCompany.专丟专世丅丂丁且专, PGCompany.三东丏不丗世丅丌丄> 丒与下与丝丈三丞丟;
        private bool <丂上丄丒一一丐且丌>k__BackingField;
        private readonly System.Collections.Generic.Dictionary<int, PGCompany.ClanLootBoxData> 丄专丄丐丄上丂丈七;
        private const int 丟丘丆丘下丏丟丕三 = 20;
        private 丅七下丏与丙不丐下 丅世丘丗丅丙丗东丄;
        private System.Nullable<Rilisoft.丅丌丌丐丘丕丟丏丝> 丝丌七丌丄丘丅七丙;
        
        // Properties
        internal System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 丏专一丗丙丙丆丌丕 { get; }
        internal bool 丂丌万丂丈丛丏丒丕 { get; set; }
        private 丅七下丏与丙不丐下 丅七下丏与丙不丐下 { get; }
        private int 丌丟与丕丒丒上丁丙 { get; }
        internal bool 丐丙三不万一东上丆 { get; }
        private long 丛丌业丞三丄丅万丄 { get; set; }
        
        // Methods
        internal static void 丁与丄东一万不丄丙(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.ClanLootBoxController.丕丛三丈丄专丅三丆, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanLootBoxController.丕丛三丈丄专丅三丆 != 1152921505575112736);
        
        }
        internal static void 丟丐东丆丐丄世丛丝(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.ClanLootBoxController.丕丛三丈丄专丅三丆, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanLootBoxController.丕丛三丈丄专丅三丆 != 1152921505575112736);
        
        }
        internal static void 丛丑丂且丘丙丆东专(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.ClanLootBoxController.且三丆丌业丌七丑丟, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanLootBoxController.且三丆丌业丌七丑丟 != 1152921505575112744);
        
        }
        internal static void 丞丞丂丁与七下一不(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.ClanLootBoxController.且三丆丌业丌七丑丟, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ClanLootBoxController.且三丆丌业丌七丑丟 != 1152921505575112744);
        
        }
        private void OnInstanceCreated()
        {
            PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  this, method:  System.Void PGCompany.ClanLootBoxController::丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)));
            PGCompany.ClanWarEndUI.丁丂丅专与与专丐丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanLootBoxController::丙一丗丁专丘与上万()));
            ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanLootBoxController::丙一丗丁专丘与上万()));
            ClansController.丒世丒业丙丟丌世上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanLootBoxController::丄不丕丑与丄丂丙丈()));
            专丈专业丆且且业下.一丆丂丈且丈丞下丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanLootBoxController::不不丝丘丑且不专不()));
            this.丗专丟丂东丝七丈丝();
        }
        private void 不不丝丘丑且不专不()
        {
            mem[1152921554078980504] = 0;
            mem[1152921554078980512] = 0;
            this.丝丌七丌丄丘丅七丙 = 0;
        }
        private void 丙一丗丁专丘与上万()
        {
            this.丐与丆丂丟万下万且();
            PGCompany.三东丏不丗世丅丌丄 val_1 = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  "ClanLootBoxPoints");
            PGCompany.丗丟丄丈东丝丕丄世 val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.丗丟丄丈东丝丕丄世>(丈丄不七三万丄丁不:  val_1, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(val_3 == null)
            {
                    return;
            }
            
            val_1.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_3);
            PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().下且上丛丞一东不不(丈丄不七三万丄丁不:  val_1, 不丁丟专专专丒上丝:  new System.Nullable<PGCompany.丆丈丘东丆丕三丞东>() {HasValue = false}, 业丏丈世世世丞丒世:  0);
        }
        private void 丂三丈三丝丗丄丝不(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            if(丗丛不丁丑专专丂且.丐丂丏丑丄丑丛丂丝() != 68)
            {
                    return;
            }
            
            this.丗专丟丂东丝七丈丝();
        }
        private void 丗专丟丂东丝七丈丝()
        {
            this.丛不丄与丅丘丙丁与(丛七丅东丒丅丘不业:  PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  68));
        }
        internal System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄> 不丁万丗丐下丗东丂()
        {
            var val_3;
            var val_44;
            var val_45;
            val_44 = this;
            List.Enumerator<T> val_1 = this.丒丕丆且三万与丞丄.GetEnumerator();
            label_49:
            if(((-2066813968) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            if((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  val_4)) == false)
            {
                goto label_49;
            }
            
            int val_7 = val_4.Item[0].业东丅东丌上丗丑不();
            if((val_7 != 1018) || (val_7.上专三下一丒丘丄丌() <= 0))
            {
                goto label_8;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_9 = val_4.Item[0];
            if((this.丅丏丘丑丌七业丒不(丏专丒丅丙七三专丐:  val_9.业东丅东丌上丗丑不())) == false)
            {
                goto label_11;
            }
            
            val_45 = val_44;
            if(val_4.业东丅东丌上丗丑不() != 11015)
            {
                goto label_13;
            }
            
            label_11:
            if(((((this.丅丏丘丑丌七业丒不(丏专丒丅丙七三专丐:  val_9.业东丅东丌上丗丑不())) == true) || (val_4.业东丅东丌上丗丑不() != 11015)) || ((this.丒与下与丝丈三丞丟.ContainsKey(key:  val_4.七丈丒丒下下且万与())) == false)) || ((val_4.Equals(丘丛丏丘丝七世七丅:  this.丒与下与丝丈三丞丟.Item[val_4.七丈丒丒下下且万与()])) == true))
            {
                goto label_49;
            }
            
            PGCompany.StorePromotionConfig val_21 = val_4.丘丑下丆上业丛一丄();
            PGCompany.StorePromotionSettings val_22 = val_21.Settings;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_23 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            null.Add(item:  this.丒与下与丝丈三丞丟.Item[val_4.七丈丒丒下下且万与()].与下不与丐丈丁丈万());
            val_22.PurchaseSettings.Price = null;
            val_4.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_21);
            goto label_49;
            label_8:
            if(((val_4.业东丅东丌上丗丑不() != 11015) || ((this.丒与下与丝丈三丞丟.ContainsKey(key:  val_4.七丈丒丒下下且万与())) == false)) || ((val_4.Equals(丘丛丏丘丝七世七丅:  this.丒与下与丝丈三丞丟.Item[val_4.七丈丒丒下下且万与()])) == true))
            {
                goto label_49;
            }
            
            PGCompany.StorePromotionConfig val_33 = val_4.丘丑下丆上业丛一丄();
            PGCompany.StorePromotionSettings val_34 = val_33.Settings;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_35 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            null.Add(item:  this.丒与下与丝丈三丞丟.Item[val_4.七丈丒丒下下且万与()].与下不与丐丈丁丈万());
            val_34.PurchaseSettings.Price = null;
            val_4.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_33);
            goto label_49;
            label_13:
            PGCompany.StorePromotionConfig val_39 = val_4.丘丑下丆上业丛一丄();
            PGCompany.StorePromotionSettings val_40 = val_39.Settings;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_41 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  7);
            new PGCompany.三东丏不丗世丅丌丄().业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  0);
            null.Add(item:  new PGCompany.三东丏不丗世丅丌丄());
            val_40.PurchaseSettings.Price = null;
            val_4.丟丈与丕三丐丒丐丑(上世丏丁世丟世丆业:  val_39);
            goto label_49;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return (System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄>)System.Linq.Enumerable.ToList<PGCompany.东丑丆丗丏丐丟下丄>(source:  X19 + 24);
        }
        internal bool 与丟下丒丏丐且三丑()
        {
            return (bool)this.<丂上丄丒一一丐且丌>k__BackingField;
        }
        private void 丁下世丌丁丅丆下丞(bool 丙业与丙丗丝不丈东)
        {
            this.<丂上丄丒一一丐且丌>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private 丅七下丏与丙不丐下 丞丗上丘七丛丟下专()
        {
            丅七下丏与丙不丐下 val_2 = this.丅世丘丗丅丙丗东丄;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            丅七下丏与丙不丐下 val_1 = null;
            val_2 = val_1;
            val_1 = new 丅七下丏与丙不丐下(丐三业丘不丘丟三丅:  1, 专丅下与三丗丝丆丙:  "LOOT_BOX_REWARD_HISTORY", 一下丒丞丑丞七丙且:  20);
            this.丅世丘丗丅丙丗东丄 = val_2;
            return val_2;
        }
        internal System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 七丈与丄丘丁世丟丆()
        {
            int val_11;
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_1 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
            val_11 = this.丞丗上丘七丛丟下专().丝上三丌丙七三七丏().Count - 1;
            if((val_11 & 2147483648) != 0)
            {
                    return val_1;
            }
            
            label_19:
            PGCompany.丗丟丄丈东丝丕丄世 val_8 = PGCompany.丙下丗丛业丞三丞丅.丒丅丙丄丞丟下丏业(丈丄不七三万丄丁不:  this.丞丗上丘七丛丟下专().丝上三丌丙七三七丏().Item[val_11]);
            if(val_8 == null)
            {
                goto label_8;
            }
            
            val_1.Add(item:  val_8);
            goto label_10;
            label_8:
            object[] val_9 = new object[1];
            string val_10 = 0.业上丙丞丐丄丆丅七();
            if(val_9 == null)
            {
                goto label_11;
            }
            
            if(val_10 != null)
            {
                goto label_12;
            }
            
            goto label_15;
            label_11:
            if(val_10 == null)
            {
                goto label_15;
            }
            
            label_12:
            label_15:
            val_9[0] = val_10;
            UnityEngine.Debug.LogErrorFormat(format:  "Not can get ItemBase on id: {0}", args:  val_9);
            label_10:
            val_11 = val_11 - 1;
            if((val_11 & 2147483648) == 0)
            {
                goto label_19;
            }
            
            return val_1;
        }
        internal int 丕丑丏下世丞丁丟东()
        {
            丅七下丏与丙不丐下 val_1 = this.丞丗上丘七丛丟下专();
            if(val_1 != null)
            {
                    return val_1.三丆万丁丕丄不丏业();
            }
            
            return val_1.三丆万丁丕丄不丏业();
        }
        internal bool 丘七丙丅丄丆丅七一()
        {
            丅七下丏与丙不丐下 val_1 = this.丞丗上丘七丛丟下专();
            if(val_1 != null)
            {
                    return val_1.丘七丙丅丄丆丅七一();
            }
            
            return val_1.丘七丙丅丄丆丅七一();
        }
        internal PGCompany.ClanLootBoxData 丙丟丐丒业三丘丈万(int 丞世不丒下上上丝丑)
        {
            var val_3;
            if((this.丄专丄丐丄上丂丈七.ContainsKey(key:  丞世不丒下上上丝丑)) != false)
            {
                    PGCompany.ClanLootBoxData val_2 = this.丄专丄丐丄上丂丈七.Item[丞世不丒下上上丝丑];
                return (PGCompany.ClanLootBoxData)val_3;
            }
            
            val_3 = 0;
            return (PGCompany.ClanLootBoxData)val_3;
        }
        internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丆专世丛丞三丌丙业(PGCompany.七东万三万丒丏一丁 专业丗丛不丕七丐东, PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
        {
            var val_10;
            System.Action val_11;
            ClanLootBoxController.且下七业七业一上丈 val_1 = new ClanLootBoxController.且下七业七业一上丈();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(专业丗丛不丕七丐东 != null)
            {
                goto label_20;
            }
            
            label_21:
            label_20:
            (ClanLootBoxController.且下七业七业一上丈)[1152921554080977280].丝一三下丕且丅丟世.tweenMode = 专业丗丛不丕七丐东.业东丅东丌上丗丑不();
            不丐丅丁丂七丐丘丛 = 23;
            int val_10 = 专业丗丛不丕七丐东.丂万丞与丈丙丅丝七();
            val_10 = (PGCompany.丁丑上丞业丞丟丛上.丂丘丒丕丑七丙丈丑(与丁专世丈且东丌丅:  专业丗丛不丕七丐东)) + val_10;
            if(val_10 >= 1)
            {
                    bool val_5 = BankController.丘丛丕丐下丗世丅丆(丌丒丝东丌下丕丁丅:  val_10, 三上丆世丞丏丁一上:  52, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0);
            }
            
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_6 = PGCompany.专丆上世丏丅且丕丑.丆下丒万丙丅丘三丈(专业丗丛不丕七丐东:  专业丗丛不丕七丐东);
            val_6.ForEach(action:  new System.Action<PGCompany.三东丏不丗世丅丌丄>(object:  val_1, method:  System.Void ClanLootBoxController.且下七业七业一上丈::丆且万丅三丏万丗丌(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑)));
            bool val_9 = this.丞丗上丘七丛丟下专().丁且丒丙丛一丅东世(丄丄丆不丂丗丛丙专:  val_6, 业丟丏丈丄丙万一下:  true);
            val_10 = null;
            val_10 = null;
            val_11 = PGCompany.ClanLootBoxController.丕丛三丈丄专丅三丆;
            if(val_11 != null)
            {
                    val_11 = PGCompany.ClanLootBoxController.丕丛三丈丄专丅三丆;
                if(val_11 == null)
            {
                    val_11 = 0;
            }
            
                val_11.Invoke();
            }
            
            丌丅且丗七丘丅丛丑.万东丟丘丝丏丂且万(专业丗丛不丕七丐东:  专业丗丛不丕七丐东);
            return val_6;
            label_1:
            if(专业丗丛不丕七丐东 != null)
            {
                goto label_20;
            }
            
            goto label_21;
        }
        internal UnityEngine.Texture 丂丟丈丈下丑丆上丟()
        {
            return UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/ClanLootBox/ClanLootBox_craft_super_icon");
        }
        internal int 丗丕丂丅与七丕丅丝()
        {
            var val_10;
            var val_11;
            val_10 = PGCompany.丄且丗且下上七世丂.丑七不且上丗丁一世();
            val_11 = 0;
            if((val_10.世世丌丛丝三与且且(下丅丙一丂丗丅丝七:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  206, 丞丅上丏丂且下丅与:  "craft_super"), 丕丙丏一业世丘不丈:  0, 丞丞且且一丘丒丟万: out  0)) == false)
            {
                    return (int)val_8;
            }
            
            val_10 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.丗丟丄丈东丝丕丄世 val_8 = val_10.上丟丘下世七与丁世(丈丄不七三万丄丁不:  val_3.Item[0].Item1, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(val_8 == null)
            {
                    return (int)val_8;
            }
            
            return (int)val_8;
        }
        internal int 丏丘丒丗丛丁且七丐()
        {
            var val_8;
            var val_9;
            val_8 = PGCompany.丄且丗且下上七世丂.丑七不且上丗丁一世();
            val_9 = 0;
            if((val_8.世世丌丛丝三与且且(下丅丙一丂丗丅丝七:  new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  206, 丞丅上丏丂且下丅与:  "craft_super"), 丕丙丏一业世丘不丈:  0, 丞丞且且一丘丒丟万: out  0)) == false)
            {
                    return (int)val_9.丂丁丏一丙丛业且丌();
            }
            
            val_8 = val_3.Item[0].Item1;
            val_9 = val_8;
            return (int)val_9.丂丁丏一丙丛业且丌();
        }
        private void 世丝丐七丕世丈丒丌()
        {
            this.<丂上丄丒一一丐且丌>k__BackingField = false;
            this.丄专丄丐丄上丂丈七.Clear();
            this.丒丕丆且三万与丞丄.Clear();
            this.丒与下与丝丈三丞丟.Clear();
        }
        private void 丛不丄与丅丘丙丁与(string 丛七丅东丒丅丘不业)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.丛不丄与丅丘丙丁与(上世丏丁世丟世丆业:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝());
        }
        private void 丛不丄与丅丘丙丁与(PGCompany.ClanLootBoxCommonData 上世丏丁世丟世丆业)
        {
            var val_3;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            val_23 = this;
            if(上世丏丁世丟世丆业 == null)
            {
                    return;
            }
            
            this.世丝丐七丕世丈丒丌();
            if(上世丏丁世丟世丆业.LootBoxes == null)
            {
                goto label_19;
            }
            
            List.Enumerator<T> val_1 = 上世丏丁世丟世丆业.LootBoxes.GetEnumerator();
            val_24 = 1152921554081748080;
            val_25 = 1152921505611689984;
            label_11:
            if(((-2064623632) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_4 = val_3.丐丏七丌丕丗业且上();
            string val_6 = val_4 + 24;
            if((PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().且丄丑丆丝丐丕丕丗(丞世不丒下上上丝丑:  val_6)) == false)
            {
                goto label_11;
            }
            
            this.丄专丄丐丄上丂丈七.set_Item(key:  val_6, value:  val_4);
            goto label_11;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_19:
            if(上世丏丁世丟世丆业.Promotions == null)
            {
                goto label_52;
            }
            
            List.Enumerator<T> val_8 = 上世丏丁世丟世丆业.Promotions.GetEnumerator();
            val_24 = 1152921553993681232;
            val_25 = 1152921536589689280;
            var val_21 = 0;
            label_33:
            if(((-2064623664) & 1) == 0)
            {
                goto label_21;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_10 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  0);
            if(val_10 == null)
            {
                goto label_33;
            }
            
            PGCompany.七东万三万丒丏一丁 val_13 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.七东万三万丒丏一丁>(丞世不丒下上上丝丑:  val_10.业东丅东丌上丗丑不());
            if((val_13 == null) || (val_13.丆丝丆万丘丙丐丁丒() == true))
            {
                goto label_33;
            }
            
            mem2[0] = "StorePromotion/SPClanLootBoxView";
            mem2[0] = val_13.丂与丙业且不不下丗();
            mem2[0] = "NguiWindows/Clan/ClanLootBoxReward";
            mem2[0] = 5;
            mem2[0] = 23;
            new PGCompany.世丏丘丛丗丑专丈下() = new PGCompany.世丏丘丛丗丑专丈下(下上丐丆丝丟丝丒不:  0);
            new PGCompany.StorePromotionConfig() = new PGCompany.StorePromotionConfig(丁丅丈丌丟世丗丗丟:  1, 与不丕丆丈不丙丟丛:  val_3.丐丏七丌丕丗业且上(), 一丗与一专丙丙丅丄:  new PGCompany.世丏丘丛丗丑专丈下());
            new PGCompany.东丑丆丗丏丐丟下丄() = new PGCompany.东丑丆丗丏丐丟下丄(上世丏丁世丟世丆业:  new PGCompany.StorePromotionConfig());
            this.丒丕丆且三万与丞丄.Add(item:  new PGCompany.东丑丆丗丏丐丟下丄());
            val_21 = val_21 + 1;
            this.丒与下与丝丈三丞丟.Add(key:  new PGCompany.东丑丆丗丏丐丟下丄().七丈丒丒下下且万与(), value:  new PGCompany.东丑丆丗丏丐丟下丄().与下不与丐丈丁丈万());
            goto label_33;
            label_21:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            label_52:
            this.<丂上丄丒一一丐且丌>k__BackingField = true;
            val_23 = 1152921505575108608;
            val_26 = null;
            val_26 = null;
            if(PGCompany.ClanLootBoxController.且三丆丌业丌七丑丟 == null)
            {
                    return;
            }
            
            PGCompany.ClanLootBoxController.且三丆丌业丌七丑丟.Invoke();
        }
        internal void 与不世一丂丙世丁且()
        {
            bool val_1 = BankController.丘丛丕丐下丗世丅丆(丌丒丝东丌下丕丁丅:  232, 三上丆世丞丏丁一上:  52, 丛丞万三下丘七丌丅:  true, 丅丅丞丙丁丕丌世东:  0);
        }
        internal void 丗三东下一丒丘上不()
        {
            bool val_1 = BankController.上丛丙与且不丁丗丙(丌丒丝东丌下丕丁丅:  232, 三上丆世丞丏丁一上:  115);
        }
        private void 丄不丕丑与丄丂丙丈()
        {
            this.丐与丆丂丟万下万且();
        }
        private int 上专三下一丒丘丄丌()
        {
            var val_4;
            var val_5;
            PGCompany.丛七世丟丐丒丁丕丆 val_1 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世();
            if((val_1 != null) && (val_1.万丑世丗丐丞下丟丄() != null))
            {
                    val_4 = 0;
            }
            else
            {
                    val_4 = 0;
            }
            
            if(((-2064089512) & 1) != 0)
            {
                    int val_3 = val_4.丙东专丂世丈丏丁丂();
                return (int)val_5;
            }
            
            val_5 = 0;
            return (int)val_5;
        }
        internal bool 三丂丈下下丒丒一东()
        {
            return this.丝丌七丌丄丘丅七丙.HasValue;
        }
        private long 丗东丝丘且丄丝丐丕()
        {
            long val_14;
            if(this.丝丌七丌丄丘丅七丙.HasValue == true)
            {
                    return (long)this.丝丌七丌丄丘丅七丙.世三丞丅丑丌丈丈一();
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  98))) == true)
            {
                goto label_17;
            }
            
            DataSystem.丈且丈上不下且丝丒 val_5 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            var val_12 = 0;
            val_12 = val_12 + 1;
            string val_7 = val_5.丛丘丒东丟三丒丑丝();
            if((val_7 == null) || ((val_5.ContainsKey(key:  val_7)) == false))
            {
                goto label_17;
            }
            
            long val_9 = val_5.Item[val_7];
            goto label_19;
            label_17:
            val_14 = 0;
            label_19:
            Rilisoft.丅丌丌丐丘丕丟丏丝 val_10 = Rilisoft.丅丌丌丐丘丕丟丏丝.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  val_14);
            mem2[0] = 0;
            mem2[0] = 0;
            return (long)this.丝丌七丌丄丘丅七丙.世三丞丅丑丌丈丈一();
        }
        private void 丂与丝丕万下上下丛(long 丙业与丙丗丝不丈东)
        {
            object val_26;
            long val_27;
            var val_29;
            var val_30;
            System.Func<System.String, System.Boolean> val_32;
            var val_33;
            var val_35;
            val_27 = 丙业与丙丗丝不丈东;
            ClansController val_1 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_1 == null)
            {
                    return;
            }
            
            if(val_1.丞丗丑丈一丅丗丌丟() == null)
            {
                    return;
            }
            
            if(this.丝丌七丌丄丘丅七丙.HasValue != false)
            {
                    if(this.丝丌七丌丄丘丅七丙.世三丞丅丑丌丈丈一() == val_27)
            {
                    return;
            }
            
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  98))) != false)
            {
                    System.Collections.Generic.Dictionary<System.String, System.Int64> val_8 = null;
                val_26 = val_8;
                val_8 = new System.Collections.Generic.Dictionary<System.String, System.Int64>();
            }
            else
            {
                    DataSystem.丈且丈上不下且丝丒 val_9 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
                var val_26 = 0;
                val_26 = val_26 + 1;
                val_26 = val_9;
            }
            
            string val_11 = val_9.丛丘丒东丟三丒丑丝();
            if(val_26 == null)
            {
                goto label_19;
            }
            
            val_29 = val_26;
            if((val_26.ContainsKey(key:  val_11)) == false)
            {
                goto label_20;
            }
            
            label_22:
            val_29.set_Item(key:  val_11, value:  val_27);
            goto label_21;
            label_19:
            val_29 = 0;
            if((0.ContainsKey(key:  val_11)) == true)
            {
                goto label_22;
            }
            
            label_20:
            val_30 = null;
            val_30 = null;
            val_32 = ClanLootBoxController.<>c.<>9__49_0;
            if(val_32 == null)
            {
                    System.Func<System.String, System.Boolean> val_15 = null;
                val_32 = val_15;
                val_15 = new System.Func<System.String, System.Boolean>(object:  ClanLootBoxController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanLootBoxController.<>c::业丕丒丞上丗丗丛丌(string 丟三下万一丄七一丗));
                ClanLootBoxController.<>c.<>9__49_0 = val_32;
            }
            
            if((System.Linq.Enumerable.Any<System.String>(source:  val_29.Keys, predicate:  val_15)) != false)
            {
                    val_33 = null;
                val_33 = null;
                val_32 = ClanLootBoxController.<>c.<>9__49_1;
                if(val_32 == null)
            {
                    System.Func<System.String, System.Boolean> val_18 = null;
                val_32 = val_18;
                val_18 = new System.Func<System.String, System.Boolean>(object:  ClanLootBoxController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanLootBoxController.<>c::业丏丗丐丈丌七不上(string 丟三下万一丄七一丗));
                ClanLootBoxController.<>c.<>9__49_1 = val_32;
            }
            
                bool val_20 = val_29.Remove(key:  System.Linq.Enumerable.FirstOrDefault<System.String>(source:  val_29.Keys, predicate:  val_18));
            }
            
            val_29.Add(key:  val_11, value:  val_27);
            label_21:
            Rilisoft.丅丌丌丐丘丕丟丏丝 val_21 = Rilisoft.丅丌丌丐丘丕丟丏丝.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  val_27);
            val_35 = val_21.丑丒丄下丁丐专丄丞;
            mem2[0] = 0;
            mem2[0] = 0;
            var val_27 = 0;
            val_27 = val_27 + 1;
            val_35 = 0;
            val_27 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_26);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  98, 丙业与丙丗丝不丈东:  val_27);
        }
        private string 丛丘丒东丟三丒丑丝()
        {
            string val_7;
            string val_1 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            ClansController val_2 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_2 == null)
            {
                goto label_2;
            }
            
            丞丂丘丒丟丞丑下丄 val_3 = val_2.丞丗丑丈一丅丗丌丟();
            if(val_3 == null)
            {
                goto label_2;
            }
            
            val_7 = val_3.业丐丐三丕一丗丛丁();
            goto label_3;
            label_2:
            val_7 = 0;
            label_3:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) == true)
            {
                    return 0;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) == false)
            {
                    return val_1 + ":"(":") + val_7;
            }
            
            return 0;
        }
        internal bool 丝丞东业丌丐与不丕(int 丏专丒丅丙七三专丐)
        {
            if(丏专丒丅丙七三专丐 != 1018)
            {
                    return false;
            }
            
            return (bool)(this.上专三下一丒丘丄丌() > 0) ? 1 : 0;
        }
        internal System.TimeSpan 丝三丅下丂丘下丐专(int 丏专丒丅丙七三专丐)
        {
            long val_11;
            long val_13;
            double val_14;
            val_11 = FriendsController.丝丗专上三不丄丑丑();
            if(val_11 <= 0)
            {
                goto label_3;
            }
            
            if(this.丗东丝丘且丄丝丐丕() <= 0)
            {
                    this.丂与丝丕万下上下丛(丙业与丙丗丝不丈东:  val_11);
            }
            
            if(this.丗东丝丘且丄丝丐丕() <= 0)
            {
                goto label_5;
            }
            
            val_13 = this.丗东丝丘且丄丝丐丕();
            goto label_6;
            label_3:
            val_14 = 0;
            goto label_9;
            label_5:
            System.TimeSpan val_5 = System.TimeSpan.FromDays(value:  1);
            val_13 = (long)val_5._ticks.TotalSeconds;
            label_6:
            val_11 = (val_13 - val_11) + (val_5._ticks.上专三下一丒丘丄丌() << );
            val_11 = System.Math.Max(val1:  0, val2:  val_11);
            val_14 = (double)val_11;
            label_9:
            System.TimeSpan val_10 = System.TimeSpan.FromSeconds(value:  val_14);
            return (System.TimeSpan)val_10._ticks;
        }
        internal void 丐与丆丂丟万下万且()
        {
            long val_3 = FriendsController.丝丗专上三不丄丑丑();
            if(val_3 <= 0)
            {
                    val_3 = 专七专下且专三一且.上且一丈丐三丄一丆();
            }
            
            this.丂与丝丕万下上下丛(丙业与丙丗丝不丈东:  val_3);
        }
        internal bool 丅丏丘丑丌七业丒不(int 丏专丒丅丙七三专丐)
        {
            var val_9;
            if(((丏专丒丅丙七三专丐 == 1018) && (this.上专三下一丒丘丄丌() >= 1)) && (FriendsController.丝丗专上三不丄丑丑() >= 1))
            {
                    ClansController val_3 = Rilisoft.Singleton<ClansController>.Instance;
                if(val_3 == null)
            {
                    return (bool)val_9;
            }
            
                if(val_3.丞丗丑丈一丅丗丌丟() == null)
            {
                    return (bool)val_9;
            }
            
                if(this.丗东丝丘且丄丝丐丕() >= 1)
            {
                    System.TimeSpan val_6 = this.丝三丅下丂丘下丐专(丏专丒丅丙七三专丐:  0);
                var val_8 = (val_6._ticks.TotalSeconds <= 0f) ? 1 : 0;
                return (bool)val_9;
            }
            
            }
            
            val_9 = 0;
            return (bool)val_9;
        }
        internal bool 丕丟丏丟丙丗丞丈上()
        {
            return this.丅丏丘丑丌七业丒不(丏专丒丅丙七三专丐:  250);
        }
        public ClanLootBoxController()
        {
            this.丒丕丆且三万与丞丄 = new System.Collections.Generic.List<PGCompany.东丑丆丗丏丐丟下丄>();
            this.丒与下与丝丈三丞丟 = new System.Collections.Generic.Dictionary<PGCompany.专丟专世丅丂丁且专, PGCompany.三东丏不丗世丅丌丄>();
            this.丄专丄丐丄上丂丈七 = new System.Collections.Generic.Dictionary<System.Int32, PGCompany.ClanLootBoxData>();
        }
        private static ClanLootBoxController()
        {
            PGCompany.ClanLootBoxController.丟丘丆丘下丏丟丕三 = "wargift_small";
            PGCompany.ClanLootBoxController.丟丘丆丘下丏丟丕三.__il2cppRuntimeField_3 = 268435463;
            PGCompany.ClanLootBoxController.丟丈丏丞丘丒丙东丌 = "craft_super";
            PGCompany.ClanLootBoxController.丈业丗万万丅丁与丞 = "clanwar_place_1";
            PGCompany.ClanLootBoxController.丙专丄丏丐丟不丅丑 = "clanwar_place_2_3";
        }
    
    }

}
