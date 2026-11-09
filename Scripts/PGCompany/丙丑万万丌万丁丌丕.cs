using UnityEngine;

namespace PGCompany
{
    internal sealed class 丙丑万万丌万丁丌丕 : 丝丆丌丏丆丆丗丙三
    {
        // Fields
        private System.Type 上丈丄丘丟世丐专丈;
        private bool 丆不丗三丄丕丛丈丏;
        private System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<UnityEngine.MonoBehaviour>> 业丐丏丐丌世不丑丐;
        
        // Methods
        public 丙丑万万丌万丁丌丕(string 丝三丗万丞丁丄丌一, System.Type 丟丒上东丏万丟丐丙, bool 丙业与丙丗丝不丈东)
        {
            this.业丐丏丐丌世不丑丐 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<UnityEngine.MonoBehaviour>>();
            this.上丈丄丘丟世丐专丈 = 丟丒上东丏万丟丐丙;
        }
        protected override void 下与丞三丅丛丄七丕(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            System.Collections.Generic.List<UnityEngine.MonoBehaviour> val_12;
            var val_13;
            UnityEngine.Component val_14;
            int val_2 = 丛丑业万丗丝丒三丗.gameObject.GetInstanceID();
            if((this.业丐丏丐丌世不丑丐.ContainsKey(key:  val_2)) == true)
            {
                goto label_4;
            }
            
            System.Collections.Generic.List<UnityEngine.MonoBehaviour> val_5 = null;
            val_12 = val_5;
            val_5 = new System.Collections.Generic.List<UnityEngine.MonoBehaviour>();
            this.业丐丏丐丌世不丑丐.set_Item(key:  val_2, value:  val_5);
            val_13 = 0;
            goto label_7;
            label_18:
            val_14 = 丛丑业万丗丝丒三丗.GetComponentsInChildren(t:  this.上丈丄丘丟世丐专丈)[0];
            if(val_14 != null)
            {
                    val_14 = 0;
            }
            
            if(val_14 != 0)
            {
                    val_12 = this.业丐丏丐丌世不丑丐.Item[val_2];
                val_12.Add(item:  val_14);
            }
            
            val_13 = 1;
            label_7:
            if(val_13 < val_4.Length)
            {
                goto label_18;
            }
            
            label_4:
            this.业丐丏丐丌世不丑丐.Item[val_2].ForEach(action:  new System.Action<UnityEngine.MonoBehaviour>(object:  this, method:  System.Void PGCompany.丙丑万万丌万丁丌丕::丛丝业丐七丆丆下下(UnityEngine.MonoBehaviour 不丗上三丛丒上东丑)));
        }
        protected override void 丆世与丑丆丅丐万且(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            this.业丐丏丐丌世不丑丐.Item[丛丑业万丗丝丒三丗.gameObject.GetInstanceID()].ForEach(action:  new System.Action<UnityEngine.MonoBehaviour>(object:  this, method:  System.Void PGCompany.丙丑万万丌万丁丌丕::三丕丄丄与万丞丛丅(UnityEngine.MonoBehaviour 不丗上三丛丒上东丑)));
        }
        private void 丛丝业丐七丆丆下下(UnityEngine.MonoBehaviour 不丗上三丛丒上东丑)
        {
            不丗上三丛丒上东丑.enabled = (this.丆不丗三丄丕丛丈丏 == true) ? 1 : 0;
        }
        private void 三丕丄丄与万丞丛丅(UnityEngine.MonoBehaviour 不丗上三丛丒上东丑)
        {
            不丗上三丛丒上东丑.enabled = (this.丆不丗三丄丕丛丈丏 == false) ? 1 : 0;
        }
    
    }

}
