using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BattlePassDoubleStateChallengeView : MonoBehaviour, 世丙丘下丝丗上下丏<PGCompany.BattlePass.三丛上丁丗丌丆丌东>, 万丟丞不世丛七一专<PGCompany.BattlePass.BattlePassDoubleStateChallengeView>
    {
        // Fields
        private PGCompany.BattlePass.三丛上丁丗丌丆丌东 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private System.Action<PGCompany.BattlePass.BattlePassDoubleStateChallengeView> 丅丕丌丛万丂丈七与;
        private PGCompany.BattlePass.BattlePassChallengeView _availableView;
        private PGCompany.BattlePass.BattlePassChallengeView _notAvailableView;
        
        // Properties
        public PGCompany.BattlePass.三丛上丁丗丌丆丌东 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public PGCompany.BattlePass.三丛上丁丗丌丆丌东 get_Context()
        {
            return (PGCompany.BattlePass.三丛上丁丗丌丆丌东)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(PGCompany.BattlePass.三丛上丁丗丌丆丌东 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(PGCompany.BattlePass.三丛上丁丗丌丆丌东 与且专丈不万东一万)
        {
            PGCompany.BattlePass.BattlePassChallengeView val_5;
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            PGCompany.BattlePass.上丕丁专三丗丝万丆 val_2 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_2 == null)
            {
                    return;
            }
            
            if((val_2.专丟专一丒且丘与丌() != 100) && ((this.<丅丝丌丝丁丏丙东丞>k__BackingField.丏丐七上业丆与丘专()) != 0))
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._availableView, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._notAvailableView, 丏业丟一东丂东丘丛:  true);
                val_5 = this._notAvailableView;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._availableView, 丏业丟一东丂东丘丛:  true);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._notAvailableView, 丏业丟一东丂东丘丛:  false);
                val_5 = this._availableView;
            }
            
            val_5.Setup(与且专丈不万东一万:  this.<丅丝丌丝丁丏丙东丞>k__BackingField);
        }
        public void add_Clicked(System.Action<PGCompany.BattlePass.BattlePassDoubleStateChallengeView> 丙业与丙丗丝不丈东)
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
            while(this.丅丕丌丛万丂丈七与 != 1152921560078330528);
        
        }
        public void remove_Clicked(System.Action<PGCompany.BattlePass.BattlePassDoubleStateChallengeView> 丙业与丙丗丝不丈东)
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
            while(this.丅丕丌丛万丂丈七与 != 1152921560078467104);
        
        }
        private void OnEnable()
        {
            this._availableView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BattlePassChallengeView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassDoubleStateChallengeView::与丑不七东丝且上七(PGCompany.BattlePass.BattlePassChallengeView 丁世丛业丟下丕三丟)));
            this._availableView.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BattlePassChallengeView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassDoubleStateChallengeView::与丑不七东丝且上七(PGCompany.BattlePass.BattlePassChallengeView 丁世丛业丟下丕三丟)));
            this._notAvailableView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BattlePassChallengeView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassDoubleStateChallengeView::与丑不七东丝且上七(PGCompany.BattlePass.BattlePassChallengeView 丁世丛业丟下丕三丟)));
            this._notAvailableView.add_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BattlePassChallengeView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassDoubleStateChallengeView::与丑不七东丝且上七(PGCompany.BattlePass.BattlePassChallengeView 丁世丛业丟下丕三丟)));
        }
        private void OnDisable()
        {
            this._availableView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BattlePassChallengeView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassDoubleStateChallengeView::与丑不七东丝且上七(PGCompany.BattlePass.BattlePassChallengeView 丁世丛业丟下丕三丟)));
            this._notAvailableView.remove_Clicked(丙业与丙丗丝不丈东:  new System.Action<PGCompany.BattlePass.BattlePassChallengeView>(object:  this, method:  System.Void PGCompany.BattlePass.BattlePassDoubleStateChallengeView::与丑不七东丝且上七(PGCompany.BattlePass.BattlePassChallengeView 丁世丛业丟下丕三丟)));
        }
        private void 与丑不七东丝且上七(PGCompany.BattlePass.BattlePassChallengeView 丁世丛业丟下丕三丟)
        {
            if(this.丅丕丌丛万丂丈七与 == null)
            {
                    return;
            }
            
            this.丅丕丌丛万丂丈七与.Invoke(obj:  this);
        }
        private void OnClick()
        {
            if(this.丅丕丌丛万丂丈七与 == null)
            {
                    return;
            }
            
            this.丅丕丌丛万丂丈七与.Invoke(obj:  this);
        }
        public BattlePassDoubleStateChallengeView()
        {
        
        }
    
    }

}
