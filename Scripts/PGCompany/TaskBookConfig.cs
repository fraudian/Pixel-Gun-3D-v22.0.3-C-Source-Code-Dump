using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class TaskBookConfig
    {
        // Fields
        internal System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<PGCompany.TaskBookConfig.TaskConfig>> Tasks;
        
        // Methods
        public TaskBookConfig()
        {
        
        }
    
    }

}
