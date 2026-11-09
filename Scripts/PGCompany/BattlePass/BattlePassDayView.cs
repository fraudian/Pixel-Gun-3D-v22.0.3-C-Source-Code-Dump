using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassDayView : MonoBehaviour, 世丙丘下丝丗上下丏<PGCompany.BattlePass.BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞>, 万丟丞不世丛七一专<PGCompany.BattlePass.BattlePassDayView>
    {
        // Fields
        private bool 丏丈丞丙七丛东七丌;
        private PGCompany.BattlePass.BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private System.Action<PGCompany.BattlePass.BattlePassDayView> 丅丕丌丛万丂丈七与;
        private UILabel _levelLabel;
        private UnityEngine.GameObject _completedObj;
        private UnityEngine.GameObject _availableObj;
        private UnityEngine.GameObject _futureObj;
        private UnityEngine.GameObject _selectedObj;
        private UnityEngine.GameObject _ungivenIndicator;
        private UnityEngine.GameObject _isNewMark;
        
        // Properties
        public bool 丟七一丏丈丒丘丝世 { get; set; }
        public PGCompany.BattlePass.BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞 丄丄一丐东丐丝丗七 { get; set; }
        internal UnityEngine.Transform 且业丙丈一丄丑且东 { get; }
        
        // Methods
        public bool get_IsSelected()
        {
            return (bool)this.丏丈丞丙七丛东七丌;
        }
        public void set_IsSelected(bool 丙业与丙丗丝不丈东)
        {
            this.丏丈丞丙七丛东七丌 = 丙业与丙丗丝不丈东;
            this.丝一丅丆三东丂丞七();
        }
        public PGCompany.BattlePass.BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞 get_Context()
        {
            return (丆丐七丗丏丟不丞丞)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(PGCompany.BattlePass.BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(PGCompany.BattlePass.BattlePassChallengesCommonView.丆丐七丗丏丟不丞丞 与且专丈不万东一万)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.丝一丅丆三东丂丞七();
        }
        public void add_Clicked(System.Action<PGCompany.BattlePass.BattlePassDayView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921560075985576);
        
        }
        public void remove_Clicked(System.Action<PGCompany.BattlePass.BattlePassDayView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921560076122152);
        
        }
        private void 丝一丅丆三东丂丞七()
        {
            UnityEngine.GameObject val_9;
            UnityEngine.Transform val_10;
            UnityEngine.GameObject val_11;
            var val_12;
            UnityEngine.GameObject val_13;
            var val_14;
            var val_15;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_17;
            var val_18;
            val_9 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
            if(( & 1) == 0)
            {
                goto label_4;
            }
            
            int val_10 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丙丁丟丘丁丐与丕丝;
            val_10 = val_10 + 1;
            this._levelLabel.text = val_10.ToString();
            if(this.丏丈丞丙七丛东七丌 == false)
            {
                goto label_7;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._completedObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._availableObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._futureObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._selectedObj, 丏业丟一东丂东丘丛:  true);
            val_10 = 1152921505679421440;
            if(PGCompany.BattlePass.BPChallengeViewAwarder.丄丘七三上丕世丞业 == 0)
            {
                goto label_26;
            }
            
            val_10 = this.业丆一丈丝丏丟三丈();
            PGCompany.BattlePass.BPChallengeViewAwarder.丄丘七三上丕世丞业.丆下丙丞丗丙丘一丄(丙业与丙丗丝不丈东:  val_10);
            goto label_26;
            label_4:
            if(this._ungivenIndicator == 0)
            {
                    return;
            }
            
            val_9 = this._ungivenIndicator;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  false);
            return;
            label_7:
            val_10 = 1152921505284374528;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._selectedObj, 丏业丟一东丂东丘丛:  false);
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丙丟与丐三丐万万丆) == 3)
            {
                goto label_24;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丙丟与丐三丐万万丆) == 2)
            {
                goto label_25;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丙丟与丐三丐万万丆) != 1)
            {
                goto label_26;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._completedObj, 丏业丟一东丂东丘丛:  false);
            val_11 = this._availableObj;
            val_12 = 1;
            goto label_29;
            label_24:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._completedObj, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._availableObj, 丏业丟一东丂东丘丛:  false);
            val_13 = this._futureObj;
            val_14 = 1;
            goto label_32;
            label_25:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._completedObj, 丏业丟一东丂东丘丛:  true);
            val_11 = this._availableObj;
            val_12 = 0;
            label_29:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_11, 丏业丟一东丂东丘丛:  false);
            val_13 = this._futureObj;
            val_14 = 0;
            label_32:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  false);
            label_26:
            if(this._ungivenIndicator != 0)
            {
                    if((this.<丅丝丌丝丁丏丙东丞>k__BackingField.万丛东丐丆丐丝万世) != null)
            {
                    val_15 = null;
                val_15 = null;
                val_17 = BattlePassDayView.<>c.<>9__12_0;
                if(val_17 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_7 = null;
                val_17 = val_7;
                val_7 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassDayView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassDayView.<>c::丞专且七专丈丁丄丛(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassDayView.<>c.<>9__12_0 = val_17;
            }
            
                val_18 = System.Linq.Enumerable.Any<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.万丛东丐丆丐丝万世, predicate:  val_7);
            }
            else
            {
                    val_18 = 0;
            }
            
                val_10 = this._ungivenIndicator;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  val_18 & 1);
            }
            
            this.与下丐东丙丟丘丑丕();
        }
        private void 与下丐东丙丟丘丑丕()
        {
            System.Collections.Generic.List<PGCompany.BattlePass.三丛上丁丗丌丆丌东> val_4;
            var val_5;
            System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_7;
            if(this._isNewMark == 0)
            {
                    return;
            }
            
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            val_4 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.万丛东丐丆丐丝万世;
            if(val_4 != null)
            {
                    val_5 = null;
                val_5 = null;
                val_7 = BattlePassDayView.<>c.<>9__13_0;
                if(val_7 == null)
            {
                    System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean> val_2 = null;
                val_7 = val_2;
                val_2 = new System.Func<PGCompany.BattlePass.三丛上丁丗丌丆丌东, System.Boolean>(object:  BattlePassDayView.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BattlePassDayView.<>c::丏丞三下七丄丌业与(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丁丂专业丁丅丅丈丙));
                BattlePassDayView.<>c.<>9__13_0 = val_7;
            }
            
                val_4 = System.Linq.Enumerable.Any<PGCompany.BattlePass.三丛上丁丗丌丆丌东>(source:  val_4, predicate:  val_2);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._isNewMark, 丏业丟一东丂东丘丛:  val_4);
        }
        private void OnClick()
        {
            if(this.丅丕丌丛万丂丈七与 == null)
            {
                    return;
            }
            
            this.丅丕丌丛万丂丈七与.Invoke(obj:  this);
        }
        private void Awake()
        {
            if(this._isNewMark == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东.下丏且丞丈丐丅不东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassDayView::与下丐东丙丟丘丑丕()));
            BPChallengesController.下专丒丌与丙不一与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassDayView::与下丐东丙丟丘丑丕()));
        }
        private void OnDestroy()
        {
            if(this._isNewMark == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.三丛上丁丗丌丆丌东.下且丅丟且丄丌业丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassDayView::与下丐东丙丟丘丑丕()));
            BPChallengesController.与万丟不丝丗丒东丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassDayView::与下丐东丙丟丘丑丕()));
        }
        internal UnityEngine.Transform 业丆一丈丝丏丟三丈()
        {
            if(this._isNewMark == 0)
            {
                    return this.transform;
            }
            
            if(this._isNewMark != null)
            {
                    return this._isNewMark.transform;
            }
            
            return this._isNewMark.transform;
        }
        public BattlePassDayView()
        {
        
        }
    
    }

}
