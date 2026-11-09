using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanWarEndUI : BannerWindow
    {
        // Fields
        private static System.Action 上丛丏专丆丗东三与;
        private static System.Action 丛丄业丘不丆丄三丞;
        private PGCompany.ClanWarEndUIContainer _promotionContainer;
        private PGCompany.ClanWarEndUIContainer _demotionContainer;
        private PGCompany.ClanWarEndUIContainer _stayContainer;
        private UILabel _rankLabel;
        private PGCompany.ClanLootBoxRewardUI _clanLootBoxRewardUI;
        private UnityEngine.GameObject _giftInfoView;
        private PGCompany.七东万三万丒丏一丁 三丄丄丙丕世丏与丞;
        private PGCompany.三东丏不丗世丅丌丄 丞万东丛万世丁丞万;
        private PGCompany.三东丏不丗世丅丌丄 丐丙东下万丕丈专丕;
        private const string 丅丘丝丙丌丂七上丌 = "Key_8333";
        private const string 丙世丁丂丘丗丕丐与 = "Key_8334";
        private const string 丐丑丑丌丌丌丘一丑 = "Key_8339";
        private const string 三不世丈丄丙丕丅丐 = "Key_8342";
        private System.IDisposable 东三世丝丒三一丈丛;
        private PGCompany.三东丏不丗世丅丌丄 丂丝世丗丏丐丂丕万;
        private bool 丒丙三一丁丛一且丕;
        private bool 丒丝丝丞丏世专丗丘;
        private bool 业丐丅东丂丗上世丞;
        
        // Methods
        internal static void 丁丂丅专与与专丐丄(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  PGCompany.ClanWarEndUI.三不世丈丄丙丕丅丐, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丁丁丆丑丘丘丆不东(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  PGCompany.ClanWarEndUI.三不世丈丄丙丕丅丐, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        internal static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.ClanWarEndUI.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.ClanWarEndUI.丛丄业丘不丆丄三丞 != 1152921505578520584);
        
        }
        internal static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.ClanWarEndUI.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.ClanWarEndUI.丛丄业丘不丆丄三丞 != 1152921505578520584);
        
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarEndUI::丘丙七丄丄丅丈丏丏()), 与且专丈不万东一万:  "ClanWarEndUI_" + this.gameObject.name);
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.东三世丝丒三一丈丛.Dispose();
        }
        public override void Show()
        {
            PGCompany.ClanWarConfig val_13;
            var val_52;
            var val_56;
            PGCompany.七东万三万丒丏一丁 val_58;
            var val_60;
            string val_61;
            var val_64;
            var val_65;
            this.Show();
            val_56 = 1152921505284374528;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._promotionContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._demotionContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._stayContainer, 丏业丟一东丂东丘丛:  false);
            int val_2 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.业三丕丏不丅七丁三();
            int val_4 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丞丕不与万专丕三丐();
            一一万丒与专丙丁丛 val_6 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.下丈丈与上丄丌东丐(专丑丕丄丗丂一丝且:  val_4, 且丒丛与丞世丙丕丌:  val_2);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._rankLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8333"), arg0:  val_2.ToString()));
            this.丞万东丛万世丁丞万 = 0;
            this.丐丙东下万丕丈专丕 = 0;
            this.三丄丄丙丕世丏与丞 = 0;
            PGCompany.丆下丐丁丏世丈上丟 val_12 = this.丑丐丙丄丅世世丑丒();
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_14 = PGCompany.丂丘丞丂丏七丁丄不.东专三丏丞专丙不丝(专世专丟丝丌与丘上:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.业三丕丏不丅七丁三(), 上世丏丁世丟世丆业:  val_13, 丅丅下丟丑专下与一:  val_4);
            if(val_14 != null)
            {
                    if(val_14.Count >= 1)
            {
                    mem2[0] = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三<PGCompany.七东万三万丒丏一丁>(丞世不丒下上上丝丑:  val_14.Item[0].业东丅东丌上丗丑不());
            }
            
            }
            
            PGCompany.丆下丐丁丏世丈上丟 val_20 = this.丑丐丙丄丅世世丑丒();
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_21 = PGCompany.丂丘丞丂丏七丁丄不.东专三丏丞专丙不丝(专世专丟丝丌与丘上:  0, 上世丏丁世丟世丆业:  val_13, 丅丅下丟丑专下与一:  val_4);
            if(((Rilisoft.Singleton<ClansController>.Instance.七丏丌丏丗万东上丝(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) != false) && ((val_21 != null) && ((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丝世丛上三丟丕一丁()) != false)))
            {
                    if((val_21.Count >= 1) && (val_2 == 1))
            {
                    this.丞万东丛万世丁丞万 = val_21.Item[0];
            }
            
            }
            
            PGCompany.丆下丐丁丏世丈上丟 val_29 = this.丑丐丙丄丅世世丑丒();
            this.丐丙东下万丕丈专丕 = PGCompany.丂丘丞丂丏七丁丄不.不不丈丗丅丂世丕丗(专世专丟丝丌与丘上:  val_2, 上世丏丁世丟世丆业:  val_13, 丅丅下丟丑专下与一:  val_4);
            string val_31 = 丞丂丘丒丟丞丑下丄.丂丒丏丞丝丞且丙丁(丅丅下丟丑专下与一:  val_6);
            if(val_6 <= val_4)
            {
                goto label_26;
            }
            
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_32 = null;
            val_58 = val_32;
            val_32 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
            var val_59 = 0;
            val_59 = val_59 + 1;
            goto label_35;
            label_26:
            if(val_6 != val_4)
            {
                goto label_36;
            }
            
            val_60 = 1152921524404748272;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._stayContainer, 丏业丟一东丂东丘丛:  true);
            val_58 = this.三丄丄丙丕世丏与丞;
            val_61 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8342"), arg0:  val_31);
            this._stayContainer.丅丈丞业专丁丈上且(丅丅下丟丑专下与一:  val_4, 丐下丝丘丑丟丟丗丌:  val_58, 丝三一丁一丛丒丄一:  val_61, 丏一丅三不世丐且丄:  this.丞万东丛万世丁丞万, 丐丙东下万丕丈专丕:  this.丐丙东下万丕丈专丕);
            goto label_49;
            label_36:
            val_60 = 1152921524404748272;
            if(val_6 >= val_4)
            {
                goto label_49;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._demotionContainer, 丏业丟一东丂东丘丛:  true);
            val_58 = this.三丄丄丙丕世丏与丞;
            val_61 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8339"), arg0:  val_31);
            this._demotionContainer.与上丘七业丝丞丌世(专丑丕丄丗丂一丝且:  val_4, 东且万丕上丑丁丅丆:  val_6, 丐下丝丘丑丟丟丗丌:  val_58, 丟丅且七丅东丂不丐:  val_61, 丏一丅三不世丐且丄:  this.丞万东丛万世丁丞万, 丐丙东下万丕丈专丕:  this.丐丙东下万丕丈专丕);
            goto label_49;
            label_35:
            System.Collections.Generic.IEnumerator<T> val_41 = PGCompany.丛七世丟丐丒丁丕丆.丑七不且上丗丁一世().七上业世丐专丏丗丆().Values.GetEnumerator();
            label_65:
            var val_60 = 0;
            val_60 = val_60 + 1;
            if(val_41.MoveNext() == false)
            {
                goto label_55;
            }
            
            var val_61 = 0;
            val_61 = val_61 + 1;
            T val_45 = val_41.Current;
            if(val_45.世丝丌一且丝专丑丛() != val_6)
            {
                goto label_65;
            }
            
            val_32.Add(item:  val_45.丒丅丙丄丞丟下丏业());
            goto label_65;
            label_55:
            val_64 = 0;
            val_65 = 0;
            if(val_41 == null)
            {
                
            }
            else
            {
                    var val_62 = 0;
                val_62 = val_62 + 1;
                val_41.Dispose();
            }
            
            if(( != 1) && (412 == 412))
            {
                    val_64 = 0;
            }
            else
            {
                    if( != false)
            {
                    val_65 = 0;
            }
            
            }
            
            List.Enumerator<T> val_50 = 丄丈业一下万且丂丕.世七与丈丂丙丏丂丁().GetEnumerator();
            do
            {
                label_90:
                if(((-1999948672) & 1) == 0)
            {
                goto label_91;
            }
            
                string val_53 = val_52.丐丏七丌丕丗业且上();
            }
            while(val_53.ClanDivision != val_6);
            
            val_32.Add(item:  val_53.一丌世丑丄东丞丘三());
            goto label_90;
            label_91:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(1 == 1)
            {
                goto label_96;
            }
            
            if(( == 0) || (484 == 484))
            {
                goto label_106;
            }
            
            label_105:
            label_106:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._promotionContainer, 丏业丟一东丂东丘丛:  true);
            val_61 = this.三丄丄丙丕世丏与丞;
            val_60 = 1152921524404748272;
            this._promotionContainer.丆丕丕丈三丐上七丑(专丑丕丄丗丂一丝且:  val_4, 东且万丕上丑丁丅丆:  val_6, 丙丙与丕不丞丛丐业:  val_32, 丐下丝丘丑丟丟丗丌:  val_61, 丏一丅三不世丐且丄:  this.丞万东丛万世丁丞万, 丄三丛下丟且万丞丑:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8334"), arg0:  val_31), 丐丙东下万丕丈专丕:  this.丐丙东下万丕丈专丕);
            label_49:
            Rilisoft.Singleton<ClansController>.Instance.东不世丆不丕三丏丙(丅丅下丟丑专下与一:  val_6);
            return;
            label_96:
            if( != 0)
            {
                goto label_105;
            }
            
            goto label_106;
        }
        public void U_OpenClanLootBox()
        {
            ClanWarEventBanner.丐下丒丟专东丏七丆();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  208);
            bool val_2 = this.丁丘丈丙万丘丂一丟(丝一三下丕且丅丟世:  new PGCompany.丛丈下且丐丝不东丈() {上丂丑丄丈七丆丁下 = false, <丟丟丂东世下丗不丝>k__BackingField = false, <且丄丞一下丕丂东丕>k__BackingField = false, <不丅丘丄丝丌丙丅万>k__BackingField = false, <丘下丅丆万丕丆丂世>k__BackingField = false});
            this.丒丙三一丁丛一且丕 = true;
            bool val_3 = this.丐业世不三七丁且丏(丝一三下丕且丅丟世:  new PGCompany.丛丈下且丐丝不东丈() {上丂丑丄丈七丆丁下 = false, <丟丟丂东世下丗不丝>k__BackingField = false, <且丄丞一下丕丂东丕>k__BackingField = false, <不丅丘丄丝丌丙丅万>k__BackingField = false, <丘下丅丆万丕丆丂世>k__BackingField = false});
            this.丒丝丝丞丏世专丗丘 = true;
            bool val_4 = this.与丏东丆专丗上一丛(丝一三下丕且丅丟世:  new PGCompany.丛丈下且丐丝不东丈() {上丂丑丄丈七丆丁下 = false, <丟丟丂东世下丗不丝>k__BackingField = false, <且丄丞一下丕丂东丕>k__BackingField = false, <不丅丘丄丝丌丙丅万>k__BackingField = false, <丘下丅丆万丕丆丂世>k__BackingField = false});
            this.业丐丅东丂丗上世丞 = true;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万丘丁丝七丅专丏与(下上丐丆丝丟丝丒不:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丞与上世世丆丈三丒(), 丐丅一丘丟丄丑三丏:  new System.Nullable<System.Int32>() {HasValue = false});
            if(PGCompany.ClanWarEndUI.三不世丈丄丙丕丅丐 != null)
            {
                    PGCompany.ClanWarEndUI.三不世丈丄丙丕丅丐.Invoke();
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        private bool 丁丘丈丙万丘丂一丟(PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
        {
            var val_6;
            if(this.丞万东丛万世丁丞万 == null)
            {
                    return true;
            }
            
            val_6 = Rilisoft.Singleton<ClansController>.Instance;
            if((val_6.七丏丌丏丗万东上丝(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == false)
            {
                    return true;
            }
            
            val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            1152921554147376624 = public System.Void System.Nullable<PGCompany.丛丈下且丐丝不东丈>::.ctor(PGCompany.丛丈下且丐丝不东丈 value);
            PGCompany.丗丟丄丈东丝丕丄世 val_5 = val_6.丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  this.丞万东丛万世丁丞万, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            return true;
        }
        private bool 丐业世不三七丁且丏(PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
        {
            PGCompany.Analytics.上丒丞上丌丌丘丛一 val_7;
            if(this.三丄丄丙丕世丏与丞 == null)
            {
                    return true;
            }
            
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丆专世丛丞三丌丙业(专业丗丛不丕七丐东:  this.三丄丄丙丕世丏与丞, 丝一三下丕且丅丟世:  new PGCompany.丛丈下且丐丝不东丈() {上丂丑丄丈七丆丁下 = false, <丟丟丂东世下丗不丝>k__BackingField = false, <且丄丞一下丕丂东丕>k__BackingField = false, <不丅丘丄丝丌丙丅万>k__BackingField = false, <丘下丅丆万丕丆丂世>k__BackingField = false});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._clanLootBoxRewardUI, 丏业丟一东丂东丘丛:  true);
            this._clanLootBoxRewardUI.丈且东丑丂且万丒丅(丒丁且东世一丝业丆:  this.三丄丄丙丕世丏与丞, 上业丟世三与七七三:  val_2);
            this._clanLootBoxRewardUI.东丑业丒且业丌丝丙(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionRewardUIAbstract>(object:  this, method:  System.Void PGCompany.ClanWarEndUI::专世丐丂丞丑丒丘下(PGCompany.StorePromotionRewardUIAbstract 万且万且丑丗且丌丆)));
            PGCompany.ClanLootBoxData val_4 = this.三丄丄丙丕世丏与丞.丁专丗万三上丟三丆();
            PGCompany.ClanLootBoxData val_5 = this.三丄丄丙丕世丏与丞.丁专丗万三上丟三丆();
            Rilisoft.丞丛七上丕专丏丌丈.业与专丏东不且东丕(丗万丛丁丟不丆丐七:  val_4.Id, 七三丐丁丟下业专丗:  val_5.Type);
            val_7 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            this = this.三丄丄丙丕世丏与丞;
            PGCompany.Analytics.一业丗丆世世上丁且.七丁专丙丘三不丑丐(丆丛丑世下一丐且丕:  val_7, 专业丗丛不丕七丐东:  this, 丄丛丟世丒丑与丑丌:  0, 丑东与丅丐丅丂丞业:  "war reward", 丏丂不专上丘丂不丅:  0, 上业丟世三与七七三:  val_2);
            return true;
        }
        private bool 与丏东丆专丗上一丛(PGCompany.丛丈下且丐丝不东丈 丝一三下丕且丅丟世)
        {
            var val_3;
            PGCompany.三东丏不丗世丅丌丄 val_4;
            val_3 = 1152921554147962448;
            val_4 = this;
            if(this.丐丙东下万丕丈专丕 == null)
            {
                    return true;
            }
            
            val_4 = this.丐丙东下万丕丈专丕;
            val_3 = public System.Void System.Nullable<PGCompany.丛丈下且丐丝不东丈>::.ctor(PGCompany.丛丈下且丐丝不东丈 value);
            PGCompany.丗丟丄丈东丝丕丄世 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_4, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            return true;
        }
        public void ShowGiftInfo()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._giftInfoView, 丏业丟一东丂东丘丛:  true);
        }
        public void HideGiftInfo()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._giftInfoView, 丏业丟一东丂东丘丛:  false);
        }
        public override void HideSelf()
        {
            this._clanLootBoxRewardUI.丝七一不与不丙丕丈(丙业与丙丗丝不丈东:  new System.Action<PGCompany.StorePromotionRewardUIAbstract>(object:  this, method:  System.Void PGCompany.ClanWarEndUI::专世丐丂丞丑丒丘下(PGCompany.StorePromotionRewardUIAbstract 万且万且丑丗且丌丆)));
            this.HideSelf();
            if(PGCompany.ClanWarEndUI.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            PGCompany.ClanWarEndUI.丛丄业丘不丆丄三丞.Invoke();
        }
        private void 专世丐丂丞丑丒丘下(PGCompany.StorePromotionRewardUIAbstract 万且万且丑丗且丌丆)
        {
            goto typeof(PGCompany.ClanWarEndUI).__il2cppRuntimeField_208;
        }
        public ClanWarEndUI()
        {
        
        }
        private void 丘丙七丄丄丅丈丏丏()
        {
            this.HideGiftInfo();
            if(this._clanLootBoxRewardUI == 0)
            {
                    return;
            }
            
            if(this._clanLootBoxRewardUI.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this = ???;
            goto typeof(PGCompany.ClanLootBoxRewardUI).__il2cppRuntimeField_1A8;
        }
    
    }

}
