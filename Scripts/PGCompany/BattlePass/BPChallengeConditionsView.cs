using UnityEngine;

namespace PGCompany.BattlePass
{
    public class BPChallengeConditionsView : MonoBehaviour, 世丙丘下丝丗上下丏<PGCompany.BattlePass.丘丄上丏不丝不丐丐>
    {
        // Fields
        private PGCompany.BattlePass.丘丄上丏不丝不丐丐 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private PGCompany.BattlePass.BPChallengeConditionsContainerView _oneConditionView;
        private PGCompany.BattlePass.BPChallengeConditionsContainerView _twoConditionView;
        private PGCompany.BattlePass.BPChallengeConditionsContainerView _threeConditionView;
        
        // Properties
        public PGCompany.BattlePass.丘丄上丏不丝不丐丐 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public PGCompany.BattlePass.丘丄上丏不丝不丐丐 get_Context()
        {
            return (PGCompany.BattlePass.丘丄上丏不丝不丐丐)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(PGCompany.BattlePass.丘丄上丏不丝不丐丐 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(PGCompany.BattlePass.丘丄上丏不丝不丐丐 与且专丈不万东一万)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            PGCompany.BattlePass.BPChallengeConditionsContainerView val_6;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            int val_2 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄丆世丌丒世业丅下().Count;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._oneConditionView, 丏业丟一东丂东丘丛:  (val_2 == 1) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._twoConditionView, 丏业丟一东丂东丘丛:  (val_2 == 2) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._threeConditionView, 丏业丟一东丂东丘丛:  (val_2 == 3) ? 1 : 0);
            if(val_2 == 1)
            {
                    val_6 = this._oneConditionView;
            }
            else
            {
                    if(val_2 == 2)
            {
                    val_6 = this._twoConditionView;
            }
            else
            {
                    if(val_2 != 3)
            {
                    return;
            }
            
                val_6 = this._threeConditionView;
            }
            
            }
            
            this._threeConditionView.<丅丝丌丝丁丏丙东丞>k__BackingField = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            val_6.丝一丅丆三东丂丞七();
        }
        public BPChallengeConditionsView()
        {
        
        }
    
    }

}
