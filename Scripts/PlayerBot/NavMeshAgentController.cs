using UnityEngine;

namespace PlayerBot
{
    internal class NavMeshAgentController : MonoBehaviour
    {
        // Fields
        internal UnityEngine.AI.NavMeshAgent agent;
        private UnityEngine.Vector3 丙与下丄专丟丞丄丒;
        private UnityEngine.Vector3 丄东丛丏一丗丟丞丑;
        private UnityEngine.AI.NavMeshPath 丛丄业丕且丗下一万;
        
        // Methods
        private void Awake()
        {
            this.丛丄业丕且丗下一万 = new UnityEngine.AI.NavMeshPath();
        }
        internal void 上丛丌丆丑上七世三(UnityEngine.GameObject 下丐三丆丝与不丗丕)
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            this.丙与下丄专丟丞丄丒 = val_2;
            mem[1152921540804742484] = val_2.y;
            mem[1152921540804742488] = val_2.z;
            this.agent.updateRotation = false;
            if(this.agent != 0)
            {
                    return;
            }
            
            UnityEngine.AI.NavMeshAgent val_4 = 下丐三丆丝与不丗丕.GetComponent<UnityEngine.AI.NavMeshAgent>();
            if(val_4 != 0)
            {
                    this.agent = val_4;
                return;
            }
            
            UnityEngine.Debug.Log(message:  "No Agent Found!");
        }
        private void Update()
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.丙与下丄专丟丞丄丒, y = V11.16B, z = V10.16B});
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  UnityEngine.Time.deltaTime);
            this.丄东丛丏一丗丟丞丑 = val_5;
            mem[1152921540804883168] = val_5.y;
            mem[1152921540804883172] = val_5.z;
            UnityEngine.Vector3 val_7 = this.transform.position;
            this.丙与下丄专丟丞丄丒 = val_7;
            mem[1152921540804883156] = val_7.y;
            mem[1152921540804883160] = val_7.z;
        }
        internal virtual bool 丒丒东丆世不东丘丂(UnityEngine.Vector3 业下丌下三丕丙丌下)
        {
            if(this.agent.enabled == false)
            {
                    return false;
            }
            
            if(this.agent != null)
            {
                    return this.agent.SetDestination(target:  new UnityEngine.Vector3() {x = 业下丌下三丕丙丌下.x, y = 业下丌下三丕丙丌下.y, z = 业下丌下三丕丙丌下.z});
            }
            
            return this.agent.SetDestination(target:  new UnityEngine.Vector3() {x = 业下丌下三丕丙丌下.x, y = 业下丌下三丕丙丌下.y, z = 业下丌下三丕丙丌下.z});
        }
        internal virtual bool 世丆上丌与丑丄丏专(UnityEngine.Vector3 业下丌下三丕丙丌下)
        {
            if(this.agent.enabled == false)
            {
                    return false;
            }
            
            if((this.agent.CalculatePath(targetPosition:  new UnityEngine.Vector3() {x = 业下丌下三丕丙丌下.x, y = 业下丌下三丕丙丌下.y, z = 业下丌下三丕丙丌下.z}, path:  this.丛丄业丕且丗下一万)) == false)
            {
                    return false;
            }
            
            if(this.丛丄业丕且丗下一万.status != 0)
            {
                    return false;
            }
            
            if(this.agent.isOnOffMeshLink != false)
            {
                    return false;
            }
            
            if(this.agent != null)
            {
                    return this.agent.SetPath(path:  this.丛丄业丕且丗下一万);
            }
            
            return this.agent.SetPath(path:  this.丛丄业丕且丗下一万);
        }
        internal virtual void 丌丆丛丙世万丄世丈(UnityEngine.Vector3 业下丌下三丕丙丌下)
        {
            if(this.agent.enabled == false)
            {
                    return;
            }
            
            if((this.agent.CalculatePath(targetPosition:  new UnityEngine.Vector3() {x = 业下丌下三丕丙丌下.x, y = 业下丌下三丕丙丌下.y, z = 业下丌下三丕丙丌下.z}, path:  this.丛丄业丕且丗下一万)) == false)
            {
                    return;
            }
            
            if(this.丛丄业丕且丗下一万.status != 0)
            {
                    return;
            }
            
            if(this.agent.isOnOffMeshLink != false)
            {
                    return;
            }
            
            bool val_5 = this.agent.SetPath(path:  this.丛丄业丕且丗下一万);
        }
        internal virtual bool 丂且丘丈丏下且与专()
        {
            if(this.agent.enabled == false)
            {
                    return (bool)0 & 1;
            }
            
            if(this.agent.remainingDistance != Infinityf)
            {
                    if(this.agent.remainingDistance <= 0f)
            {
                goto label_5;
            }
            
            }
            
            return (bool)0 & 1;
            label_5:
            bool val_6 = this.agent.pathPending ^ 1;
            return (bool)0 & 1;
        }
        internal virtual bool 丄丈与世且丈业三不()
        {
            return (bool)(this.agent.pathStatus == 1) ? 1 : 0;
        }
        internal virtual UnityEngine.Vector3 丆丛丆丈丝丗丆专丈()
        {
            return new UnityEngine.Vector3() {x = this.丄东丛丏一丗丟丞丑};
        }
        internal virtual bool 丈与丙丘丆丙丄丟丐()
        {
            if(this.agent != null)
            {
                    return this.agent.pathPending;
            }
            
            return this.agent.pathPending;
        }
        internal virtual bool 万七丟万丁丈丒七世()
        {
            if(this.agent != null)
            {
                    return this.agent.hasPath;
            }
            
            return this.agent.hasPath;
        }
        internal virtual UnityEngine.Vector3[] 不丌丏世丐丗丆上丅()
        {
            var val_2;
            UnityEngine.AI.NavMeshTriangulation val_1 = UnityEngine.AI.NavMesh.CalculateTriangulation();
            return (UnityEngine.Vector3[])val_2;
        }
        internal virtual void 丝丏丗丘丞丄丘丅且(float 与丕丁三万专世不丅)
        {
            this.agent.speed = 与丕丁三万专世不丅;
        }
        internal virtual float 丒丏丆世丗丗丕世不()
        {
            if(this.agent != null)
            {
                    return this.agent.speed;
            }
            
            return this.agent.speed;
        }
        internal virtual void 丈不一丁丈丅丂丕丁(float 与丕丁三万专世不丅)
        {
            this.agent.acceleration = 与丕丁三万专世不丅;
        }
        internal virtual float 丟上丏丛丞丒丒丟业()
        {
            if(this.agent != null)
            {
                    return this.agent.acceleration;
            }
            
            return this.agent.acceleration;
        }
        internal virtual void 丑丄东业丄万丆丝七(float 与丕丁三万专世不丅)
        {
            this.agent.stoppingDistance = 与丕丁三万专世不丅;
        }
        internal virtual float 不丒丅且丁丈不丛上()
        {
            if(this.agent != null)
            {
                    return this.agent.stoppingDistance;
            }
            
            return this.agent.stoppingDistance;
        }
        internal virtual float 丝丌且三丘丙下丕东()
        {
            if(this.agent.enabled == false)
            {
                    return 0f;
            }
            
            if(this.agent != null)
            {
                    return this.agent.remainingDistance;
            }
            
            return this.agent.remainingDistance;
        }
        internal virtual bool 业下丙丁丟东丒丕丏()
        {
            if(this.agent != null)
            {
                    return this.agent.isOnOffMeshLink;
            }
            
            return this.agent.isOnOffMeshLink;
        }
        internal virtual void 丕上丒东上丄业丒七()
        {
            this.agent.CompleteOffMeshLink();
        }
        internal virtual void 三丈丛丆下东业上丞()
        {
            this.agent.enabled = false;
        }
        internal virtual void 丞丑下丞丈丕丛三世()
        {
            this.agent.enabled = true;
        }
        internal void 与丞丕丝上三不丞与()
        {
            this.agent.ResetPath();
        }
        internal void 丞三七丑业丄丞丙且(UnityEngine.Vector3 下业丕七东丌丝下且)
        {
            bool val_1 = this.agent.Warp(newPosition:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z});
        }
        internal virtual bool 不丂丒丘三世丄丝丌()
        {
            var val_4;
            UnityEngine.AI.OffMeshLinkData val_1 = this.agent.nextOffMeshLinkData;
            return (bool)val_4.valid;
        }
        public NavMeshAgentController()
        {
        
        }
    
    }

}
