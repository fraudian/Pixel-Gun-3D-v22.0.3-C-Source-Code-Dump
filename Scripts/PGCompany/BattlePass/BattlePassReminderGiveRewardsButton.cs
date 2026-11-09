using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BattlePassReminderGiveRewardsButton : MonoBehaviour
    {
        // Fields
        private PGCompany.BattlePass.BattlePassReminderGiveRewardsArrow 丆丙丈丞丁东业不丘;
        
        // Properties
        public PGCompany.BattlePass.BattlePassReminderGiveRewardsArrow 丂专丂丆丗一七丌下 { get; }
        
        // Methods
        public PGCompany.BattlePass.BattlePassReminderGiveRewardsArrow get_Arrow()
        {
            PGCompany.BattlePass.BattlePassReminderGiveRewardsArrow val_3;
            if(this.丆丙丈丞丁东业不丘 == 0)
            {
                    this.丆丙丈丞丁东业不丘 = this.GetComponentInChildren<PGCompany.BattlePass.BattlePassReminderGiveRewardsArrow>(includeInactive:  true);
                return val_3;
            }
            
            val_3 = this.丆丙丈丞丁东业不丘;
            return val_3;
        }
        internal void 丒丕丝丄与不三丅丘()
        {
            if(this.Arrow == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BattlePassReminderGiveRewardsArrow val_3 = this.Arrow;
            val_3.<丝丕丒丂丙一丌七不>k__BackingField = false;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.Arrow.gameObject, 丏业丟一东丂东丘丛:  PGCompany.BattlePass.丒丂丆丏丐一丞丄七.且丑丟一七不一与丑());
        }
        public void U_DisableAndContinue()
        {
            if(this.Arrow == 0)
            {
                    return;
            }
            
            PGCompany.BattlePass.BattlePassReminderGiveRewardsArrow val_3 = this.Arrow;
            val_3.<丝丕丒丂丙一丌七不>k__BackingField = true;
            this.Arrow.gameObject.SetActive(value:  false);
        }
        public BattlePassReminderGiveRewardsButton()
        {
        
        }
    
    }

}
