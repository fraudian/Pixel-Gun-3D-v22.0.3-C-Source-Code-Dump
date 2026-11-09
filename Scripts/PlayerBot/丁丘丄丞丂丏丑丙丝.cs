using UnityEngine;

namespace PlayerBot
{
    internal class 丁丘丄丞丂丏丑丙丝
    {
        // Fields
        internal UnityEngine.Transform 万东万丆专丌丕丐丗;
        internal UnityEngine.Vector3 七专丑丘丂丞丛一丟;
        internal PlayerBot.NavMeshAgentController 丒丌下丗丕丆专丝七;
        internal PlayerBot.AIBotController 丒专丈丛下丒一丒丛;
        internal bool 丂世丑丝丞丏丆丟丅;
        internal bool 一丙上丗七丈丘世丐;
        internal float 上七不丈下下丛丘与;
        
        // Methods
        internal virtual void 丌一七丌丄丌七上丞(PlayerBot.AIBotController 丒专丈丛下丒一丒丛)
        {
            this.丒专丈丛下丒一丒丛 = 丒专丈丛下丒一丒丛;
            if(丒专丈丛下丒一丒丛 != null)
            {
                    this.万东万丆专丌丕丐丗 = 丒专丈丛下丒一丒丛.transform;
            }
            else
            {
                    this.万东万丆专丌丕丐丗 = 0.transform;
            }
            
            this.丒丌下丗丕丆专丝七 = 丒专丈丛下丒一丒丛._agentController;
        }
        internal virtual void 丑丁业不丏丆丞丞一()
        {
        
        }
        internal virtual void 三万上七丛丁业丑与()
        {
        
        }
        internal virtual void 专丙且七丝丏丞丌下(UnityEngine.Vector3 业下丌下三丕丙丌下)
        {
            float val_10;
            var val_11;
            val_10 = 业下丌下三丕丙丌下.z;
            val_11 = this;
            if((this.丒丌下丗丕丆专丝七 & 1) != 0)
            {
                    return;
            }
            
            if((this.丒丌下丗丕丆专丝七 & 1) != 0)
            {
                    return;
            }
            
            this.丒丌下丗丕丆专丝七.与丞丕丝上三不丞与();
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = 业下丌下三丕丙丌下.x, y = 业下丌下三丕丙丌下.y, z = val_10}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) == false)
            {
                    return;
            }
            
            val_11 = ???;
            val_10 = ???;
            goto typeof(PlayerBot.NavMeshAgentController).__il2cppRuntimeField_188;
        }
        internal bool 丙丛三三与丁丄一万(UnityEngine.Vector3 业下丌下三丕丙丌下)
        {
            UnityEngine.AI.NavMeshPath val_1 = new UnityEngine.AI.NavMeshPath();
            if((this.丒丌下丗丕丆专丝七.agent.CalculatePath(targetPosition:  new UnityEngine.Vector3() {x = 业下丌下三丕丙丌下.x, y = 业下丌下三丕丙丌下.y, z = 业下丌下三丕丙丌下.z}, path:  val_1)) == false)
            {
                    return false;
            }
            
            if(val_1.status != 0)
            {
                    return false;
            }
            
            if(this.丒丌下丗丕丆专丝七.agent.isOnOffMeshLink == true)
            {
                    return false;
            }
            
            if((this.丒丌下丗丕丆专丝七.agent.SetPath(path:  val_1)) != false)
            {
                    this = this.丒丌下丗丕丆专丝七.agent;
                if(this.pathPending == false)
            {
                    return false;
            }
            
            }
            
            return false;
        }
        public 丁丘丄丞丂丏丑丙丝()
        {
        
        }
    
    }

}
