using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanPromoteBanner : BannerWindow
    {
        // Fields
        private UnityEngine.GameObject[] _pendingRequestObjects;
        private UnityEngine.GameObject[] _priceObjects;
        private UILabel[] _gemsCount;
        private UILabel _membersCountLabel;
        private UILabel _myClanName;
        private UITexture _myClanLogo;
        private UILabel _myClanMotto;
        private System.IDisposable 东三世丝丒三一丈丛;
        
        // Methods
        protected override void OnEnable()
        {
            this.OnEnable();
            if(this.东三世丝丒三一丈丛 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.东三世丝丒三一丈丛.Dispose();
            }
            
            this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.ClanPromoteBanner::U_Hide()), 与且专丈不万东一万:  0);
        }
        protected override void OnDisable()
        {
            this.OnDisable();
            if(this.东三世丝丒三一丈丛 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.东三世丝丒三一丈丛.Dispose();
        }
        private void Update()
        {
            丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_2 != null)
            {
                    if(val_2.丗丅与三不万一丟丐() == false)
            {
                    return;
            }
            
            }
            
            this.HideSelf();
        }
        public override void Show()
        {
            var val_1;
            this.Show();
            this.不丗丝业丏不丞丆丆();
            this.世万丗一丟丞丝丐丈();
            val_1 = null;
            val_1 = null;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._gemsCount, 丕丗丘丑丛与丑业丒:  PGCompany.Clans.Network.丁丌上丁丗丞丞且万.__il2cppRuntimeField_static_fields);
        }
        public void U_Promote()
        {
            string val_22;
            string val_23;
            var val_24;
            string val_25;
            string val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            ClanPromoteBanner.丒丛丁与丅东丒不七 val_1 = new ClanPromoteBanner.丒丛丁与丅东丒不七();
            val_22 = Rilisoft.Singleton<ClansController>.Instance;
            丞丂丘丒丟丞丑下丄 val_3 = val_22.丞丗丑丈一丅丗丌丟();
            if((val_3 == null) || (val_3.丗丅与三不万一丟丐() == true))
            {
                goto label_3;
            }
            
            丞丂丘丒丟丞丑下丄 val_6 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_6 == null)
            {
                goto label_5;
            }
            
            val_23 = val_6.业丐丐三丕一丗丛丁();
            if(val_1 == null)
            {
                goto label_6;
            }
            
            label_8:
            val_24 = val_1;
            .丄丒下业一不丈丝丘 = val_23;
            goto label_7;
            label_5:
            val_25 = 0;
            if(val_1 != null)
            {
                goto label_8;
            }
            
            label_6:
            val_24 = val_1;
            .丄丒下业一不丈丝丘 = val_25;
            val_22 = .丄丒下业一不丈丝丘;
            label_7:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_22)) == false)
            {
                goto label_11;
            }
            
            label_3:
            this.HideSelf();
            return;
            label_11:
            val_26 = Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().世丄丂下丏丝丞丒且();
            val_27 = null;
            val_27 = null;
            val_28 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
            if(val_28.丌丄一丒且下丅丁丏() == false)
            {
                    return;
            }
            
            val_29 = null;
            val_29 = null;
            val_30 = null;
            val_30 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.不丙业丑丙丄一且下;
            val_28 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
            val_31 = null;
            val_31 = null;
            val_26 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
            val_28.丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  val_26, 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.不丙业丑丙丄一且下, 丙丙专丝专上丅丛丏:  true, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
        }
        public void U_Hide()
        {
            this.HideSelf();
        }
        private void 不丗丝业丏不丞丆丆()
        {
            string val_9;
            UnityEngine.GameObject[] val_10;
            UnityEngine.GameObject[] val_11;
            var val_12;
            var val_13;
            if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  138)) == false)
            {
                goto label_4;
            }
            
            丞丂丘丒丟丞丑下丄 val_6 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            val_9 = 0;
            if(val_6 != null)
            {
                    val_9 = val_6.业丐丐三丕一丗丛丁();
            }
            
            val_10 = this._pendingRequestObjects;
            if((System.String.op_Equality(a:  Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  138), b:  val_9)) == false)
            {
                goto label_10;
            }
            
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  true);
            val_11 = this._priceObjects;
            val_12 = 0;
            goto label_13;
            label_4:
            val_10 = this._pendingRequestObjects;
            val_13 = null;
            goto label_16;
            label_10:
            val_13 = null;
            label_16:
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  false);
            val_11 = this._priceObjects;
            val_12 = 1;
            label_13:
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  true);
        }
        private void 世万丗一丟丞丝丐丈()
        {
            丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_2 == null)
            {
                    return;
            }
            
            UnityEngine.Texture2D val_3 = val_2.世丐专丂世丄世丂丌();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._membersCountLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0}/{1}", arg0:  val_2.丁丈丕丆下丙丏业世(), arg1:  val_2.丄丑丙万丌丂一丄丙));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._myClanName, 丕丗丘丑丛与丑业丒:  val_2.东丙上东业丆不丟丘());
            this = this._myClanMotto;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this, 丕丗丘丑丛与丑业丒:  val_2.丆不与丕世丏三丅一());
        }
        public ClanPromoteBanner()
        {
        
        }
    
    }

}
