using UnityEngine;

namespace Rilisoft
{
    public class GameEventChestOpenButtonView : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.上专业三丟丁丞专下>
    {
        // Fields
        private Rilisoft.GameEventCurrencyView _mainButton;
        private UnityEngine.GameObject _freeOpenObject;
        private UILabel _freeOpensCount;
        private UnityEngine.GameObject _freeTimerObject;
        private UILabel _freeTimerLabel;
        private UnityEngine.GameObject _freeAwardContainer;
        private UnityEngine.GameObject _freeAwardWatch;
        private UnityEngine.GameObject _freeAwardOpenFree;
        private UnityEngine.GameObject _freeAwardWait;
        private UILabel _freeAwardLeftLabel;
        private UnityEngine.GameObject _notif;
        private float 专一东丒丑丛丆丅世;
        private Rilisoft.上专业三丟丁丞专下 <丅丝丌丝丁丏丙东丞>k__BackingField;
        
        // Properties
        public Rilisoft.上专业三丟丁丞专下 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public Rilisoft.上专业三丟丁丞专下 get_Context()
        {
            return (Rilisoft.上专业三丟丁丞专下)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.上专业三丟丁丞专下 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(Rilisoft.上专业三丟丁丞专下 与且专丈不万东一万)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            丈丞丕丘丕丗与上一 val_26;
            string val_27;
            UnityEngine.GameObject val_28;
            var val_29;
            UnityEngine.GameObject val_30;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            int val_1 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丞上丌丌丕丘专丒丕(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false});
            if(val_1 < 1)
            {
                goto label_2;
            }
            
            if(this._freeOpenObject == 0)
            {
                goto label_5;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeOpenObject, 丏业丟一东丂东丘丛:  true);
            this._freeOpensCount.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5005"), arg0:  val_1);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainButton.gameObject, 丏业丟一东丂东丘丛:  false);
            goto label_19;
            label_2:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeOpenObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainButton.gameObject, 丏业丟一东丂东丘丛:  true);
            val_26 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            this._mainButton.Set(一下世丆丙万丞东丆:  new Rilisoft.GameCurrencyData(丏丂不专上丘丂不丅:  this.<丅丝丌丝丁丏丙东丞>k__BackingField, 丒世丘丘上丆丝东丞:  val_26));
            goto label_19;
            label_5:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._mainButton.gameObject, 丏业丟一东丂东丘丛:  true);
            this._mainButton.SetAsFree(丟丂丄丌万丞丝丗丑:  val_1, 丆丗丘丕且丈丘丁不:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4885"));
            label_19:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeTimerObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeAwardContainer, 丏业丟一东丂东丘丛:  false);
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.东丙且丛不不丙丌丑()) == false)
            {
                goto label_31;
            }
            
            System.Nullable<System.TimeSpan> val_11 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.三东丂丝丒丆万丙一();
            if(((-432637440) & 1) == 0)
            {
                goto label_31;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeTimerObject, 丏业丟一东丂东丘丛:  true);
            System.Nullable<System.TimeSpan> val_13 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.三东丂丝丒丆万丙一();
            val_27 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5003"), arg0:  专七专下且专三一且.丒下丒丄且且丂丟丘(丄专万丏丘上丑与一:  new System.TimeSpan() {}, 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0));
            label_65:
            this._freeTimerLabel.text = val_27;
            goto label_63;
            label_31:
            val_26 = 1152921504848912384;
            if(Rilisoft.FreeChestController.世丒丞七专三与万丕 == 0)
            {
                goto label_63;
            }
            
            bool val_17 = Rilisoft.FreeChestController.世丒丞七专三与万丕.丄丛丅丐世丌丕且丛();
            val_27 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            int val_18 = val_27.丞上丌丌丕丘专丒丕(一丒一万丏三丞七丙:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false});
            if((val_18 > 0) || (val_17 ^ 1 == true))
            {
                goto label_49;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeAwardContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeAwardWait, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._freeAwardWatch, 丏业丟一东丂东丘丛:  true);
            val_28 = this._freeAwardOpenFree;
            goto label_52;
            label_49:
            var val_20 = (val_18 > 0) ? 1 : 0;
            val_20 = val_17 | val_20;
            if(val_20 == false)
            {
                goto label_53;
            }
            
            val_29 = null;
            val_30 = this._freeAwardContainer;
            goto label_67;
            label_53:
            System.TimeSpan val_21 = val_18.丘丒不不丌丘下丒一();
            val_29 = null;
            val_30 = this._freeTimerObject;
            if(val_21._ticks.TotalSeconds <= 0f)
            {
                goto label_56;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_30, 丏业丟一东丂东丘丛:  true);
            val_27 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5003");
            if(this._freeTimerLabel == 0)
            {
                goto label_63;
            }
            
            string val_25 = System.String.Format(format:  val_27, arg0:  val_21._ticks);
            if(this._freeTimerLabel != null)
            {
                goto label_65;
            }
            
            goto label_65;
            label_56:
            label_67:
            val_28 = val_30;
            label_52:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_28, 丏业丟一东丂东丘丛:  false);
            label_63:
            this.万丘丟丏丄丅上不丕();
        }
        private void 万丘丟丏丄丅上不丕()
        {
            int val_8;
            bool val_9;
            if(this._notif == 0)
            {
                    return;
            }
            
            val_8 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.业上丙丞丐丄丆丅七();
            if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().业不丕丐丐不专丏且(丐东业丕丕丂丗丅丙:  val_8, 丁丅丈丌丟世丗丗丟:  new System.Nullable<七专丁东丘丈丄丐丐>() {HasValue = false})) != false)
            {
                    val_9 = 1;
            }
            else
            {
                    val_8 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丅丙丛丑丌丆丌丕丒();
                string val_8 = val_8;
                val_9 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().与丝丛丁七丞丏专丌(丟丛东东丙世丛专丆:  val_8);
            }
            
            val_8 = val_9;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._notif, 丏业丟一东丂东丘丛:  val_8);
        }
        private System.TimeSpan 丘丒不不丌丘下丒一()
        {
            ulong val_7;
            System.Nullable<System.DateTime> val_1 = Rilisoft.AdsRewardWatchController.丝丆丙丝且上丆一丐();
            System.Nullable<System.DateTime> val_2 = FriendsController.业丈丏丏丞丘丛丈丛();
            val_7 = 1152921516340667232;
            if((((-432192224) & 1) != 0) && (((-432192240) & 1) != 0))
            {
                    System.DateTime val_4 = val_1.HasValue.AddMinutes(value:  Rilisoft.FreeChestController.世丒丞七专三与万丕.DelayTimeinMinutes);
                val_7 = val_4.dateData;
                System.TimeSpan val_5 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_7}, d2:  new System.DateTime() {});
                return (System.TimeSpan)val_6._ticks;
            }
            
            System.TimeSpan val_6 = System.TimeSpan.FromSeconds(value:  -1);
            return (System.TimeSpan)val_6._ticks;
        }
        private void Update()
        {
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.专一东丒丑丛丆丅世 - val_1;
            this.专一东丒丑丛丆丅世 = val_1;
            if(val_1 > 0f)
            {
                    return;
            }
            
            this.专一东丒丑丛丆丅世 = 0.3f;
            this.丝一丅丆三东丂丞七();
        }
        private void OnEnable()
        {
            PGCompany.世东三上七丂丌下丑.丅与丝丒且丙丕业丕(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void Rilisoft.GameEventChestOpenButtonView::丛丏七不丒专丕业丆(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 万且万且丑丗且丌丆)));
            BankController.丕丝丌丅七丌三万丛(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void Rilisoft.GameEventChestOpenButtonView::丙丌丏丏业丄下丙丕(int 万且万且丑丗且丌丆)));
        }
        private void OnDisable()
        {
            PGCompany.世东三上七丂丌下丑.世丝丛丏丑下丐丝丏(丙业与丙丗丝不丈东:  new System.Action<丕丝丝丝丅丕专丅丝>(object:  this, method:  System.Void Rilisoft.GameEventChestOpenButtonView::丛丏七不丒专丕业丆(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 万且万且丑丗且丌丆)));
            BankController.丘与丗丆专丘丞丂丞(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void Rilisoft.GameEventChestOpenButtonView::丙丌丏丏业丄下丙丕(int 万且万且丑丗且丌丆)));
        }
        private void 丛丏七不丒专丕业丆(PGCompany.世东三上七丂丌下丑.丕丝丝丝丅丕专丅丝 万且万且丑丗且丌丆)
        {
            if(万且万且丑丗且丌丆.一且丟丁上丑业丕且 == null)
            {
                    return;
            }
            
            if(万且万且丑丗且丌丆.一且丟丁上丑业丕且.业东丅东丌上丗丑不() != 6015)
            {
                    return;
            }
            
            this.万丘丟丏丄丅上不丕();
        }
        private void 丙丌丏丏业丄下丙丕(int 万且万且丑丗且丌丆)
        {
            this.万丘丟丏丄丅上不丕();
        }
        public GameEventChestOpenButtonView()
        {
        
        }
    
    }

}
