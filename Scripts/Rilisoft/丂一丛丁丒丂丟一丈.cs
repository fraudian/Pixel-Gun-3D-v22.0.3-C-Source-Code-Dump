using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丂一丛丁丒丂丟一丈
    {
        // Fields
        private readonly System.Collections.Generic.IDictionary<UnityEngine.Material, Rilisoft.一万丟一下不丕丕丛> 业东下丈且与丏专丅;
        private readonly System.Collections.Generic.IDictionary<UnityEngine.Mesh, Rilisoft.丁丑丐丙丒丙丌丅与> 丛丘丏丆上三且且七;
        
        // Methods
        public void 上专丄丑专丑丘业丌()
        {
            T[] val_14;
            var val_15;
            var val_16;
            Rilisoft.一万丟一下不丕丕丛 val_19;
            var val_20;
            val_14 = UnityEngine.Object.FindObjectsOfType<UnityEngine.Renderer>();
            val_15 = 0;
            T[] val_4 = val_14;
            goto label_3;
            label_23:
            T val_17 = val_14[0];
            val_16 = 0;
            goto label_6;
            label_21:
            UnityEngine.Material val_18 = val_17.sharedMaterials[0];
            var val_19 = 0;
            val_19 = val_19 + 1;
            if((this.业东下丈且与丏专丅.TryGetValue(key:  null, value: out  val_4)) != true)
            {
                    Rilisoft.一万丟一下不丕丕丛 val_6 = new Rilisoft.一万丟一下不丕丕丛();
                var val_20 = 0;
                val_20 = val_20 + 1;
                this.业东下丈且与丏专丅.Add(key:  null, value:  val_4);
            }
            
            val_19 = val_6;
            bool val_8 = val_6.不一七丒丑专三与丈(丟不丅丄丙丟丝业上:  val_17);
            val_16 = 1;
            label_6:
            if(val_16 < val_2.Length)
            {
                goto label_21;
            }
            
            val_14 = val_4;
            val_15 = 1;
            label_3:
            if(val_15 < (val_1 + 24))
            {
                goto label_23;
            }
            
            val_20 = 0;
            goto label_26;
            label_45:
            val_14 = UnityEngine.Object.FindObjectsOfType<UnityEngine.MeshFilter>()[0];
            if(val_14.sharedMesh != 0)
            {
                    val_19 = this.丛丘丏丆上三且且七;
                var val_21 = 0;
                val_21 = val_21 + 1;
                if((val_19.TryGetValue(key:  null, value: out  val_4)) != true)
            {
                    Rilisoft.丁丑丐丙丒丙丌丅与 val_14 = null;
                val_19 = val_14;
                val_14 = new Rilisoft.丁丑丐丙丒丙丌丅与();
                var val_22 = 0;
                val_22 = val_22 + 1;
                this.丛丘丏丆上三且且七.Add(key:  null, value:  val_4);
            }
            
                bool val_16 = val_14.不七丘下丌丐一且与(世丒丗丝丆丑不丐丒:  val_14);
            }
            
            val_20 = 1;
            label_26:
            if(val_20 < val_9.Length)
            {
                goto label_45;
            }
        
        }
        public 丂一丛丁丒丂丟一丈()
        {
            this.业东下丈且与丏专丅 = new System.Collections.Generic.Dictionary<UnityEngine.Material, Rilisoft.一万丟一下不丕丕丛>();
            this.丛丘丏丆上三且且七 = new System.Collections.Generic.Dictionary<UnityEngine.Mesh, Rilisoft.丁丑丐丙丒丙丌丅与>();
        }
    
    }

}
