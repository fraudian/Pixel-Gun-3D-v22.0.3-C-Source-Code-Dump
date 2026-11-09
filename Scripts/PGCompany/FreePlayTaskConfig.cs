using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class FreePlayTaskConfig
    {
        // Fields
        internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PGCompany.FreePlayTaskConfig.TaskConfig>> Tasks;
        public bool enabled;
        internal int maxActiveTask;
        internal int serverHourReset;
        internal int maxActiveTaskReset;
        internal int maxActiveTaskResetVip;
        internal int startWeightForCategory;
        internal int decreaseValueForCategory;
        internal int increeaseValueForCategory;
        internal int intervalToReset;
        
        // Methods
        public FreePlayTaskConfig()
        {
        
        }
    
    }

}
