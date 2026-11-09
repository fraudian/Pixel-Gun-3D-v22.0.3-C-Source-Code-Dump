using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BattlePassReminderGiveRewardsArrow : MonoBehaviour
    {
        // Fields
        private bool <丝丕丒丂丙一丌七不>k__BackingField;
        
        // Properties
        internal bool 世丝万七专丘丞与丘 { get; set; }
        
        // Methods
        internal bool 专下七丄与丁业丂业()
        {
            return (bool)this.<丝丕丒丂丙一丌七不>k__BackingField;
        }
        internal void 三丟不万万且与万丙(bool 丙业与丙丗丝不丈东)
        {
            this.<丝丕丒丂丙一丌七不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private void OnDisable()
        {
            PGCompany.BattlePass.丒丂丆丏丐一丞丄七.丄一丐丂与丐且丘世(丙业与丙丗丝不丈东:  ((this.<丝丕丒丂丙一丌七不>k__BackingField) == true) ? 1 : 0);
            this.gameObject.SetActive(value:  false);
        }
        public BattlePassReminderGiveRewardsArrow()
        {
        
        }
    
    }

}
