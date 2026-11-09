using UnityEngine;

namespace PGCompany.BattlePass
{
    internal class BPResourceLoader : MonoBehaviour
    {
        // Fields
        private static readonly string 丅丕丒丄丌一丂不丐;
        private string _resourceName;
        private PGCompany.BattlePass.丄下丐丕万丆丙丟丐 _resourceType;
        private UIBasicSprite 三与丕丘丌丈一丆七;
        private UnityEngine.MeshRenderer 丂丞丑丏丛丙世七丝;
        
        // Methods
        private void Awake()
        {
            if(this._resourceType == 3)
            {
                goto label_1;
            }
            
            if(this._resourceType != 1)
            {
                goto label_3;
            }
            
            this.三与丕丘丌丈一丆七 = this.GetComponent<UIBasicSprite>();
            goto label_3;
            label_1:
            this.丂丞丑丏丛丙世七丝 = this.GetComponent<UnityEngine.MeshRenderer>();
            label_3:
            this.Load();
        }
        private void Load()
        {
            var val_22;
            var val_23;
            var val_24;
            UnityEngine.Object val_25;
            var val_26;
            double val_27;
            UnityEngine.Object val_28;
            val_22 = this;
            val_23 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_23 == null)
            {
                    return;
            }
            
            if(this._resourceType == 3)
            {
                goto label_3;
            }
            
            if(this._resourceType == 2)
            {
                goto label_4;
            }
            
            if(this._resourceType != 1)
            {
                    return;
            }
            
            val_24 = 1152921560146293952;
            val_25 = val_23.三丈专世专不业丝丆().Load<UnityEngine.Texture>(丒丘丏上丙丟丑丕丈:  this._resourceName, 丗业三丝丁三丘一丟:  true);
            if(val_25 == 0)
            {
                    return;
            }
            
            val_26 = null;
            val_26 = null;
            val_25 = this._resourceName + "_" + PGCompany.BattlePass.BPResourceLoader.丅丕丒丄丌一丂不丐;
            if((val_23.三丈专世专不业丝丆().Load<UnityEngine.Texture>(丒丘丏上丙丟丑丕丈:  val_25, 丗业三丝丁三丘一丟:  true)) == 0)
            {
                    return;
            }
            
            val_23 = ???;
            val_22 = ???;
            val_24 = ???;
            val_27 = ???;
            goto typeof(UIBasicSprite).__il2cppRuntimeField_308;
            label_4:
            val_25 = 1152921504848912384;
            val_28 = val_23.三丈专世专不业丝丆().Load<UnityEngine.Object>(丒丘丏上丙丟丑丕丈:  val_22 + 24, 丗业三丝丁三丘一丟:  true);
            if(val_28 == 0)
            {
                    return;
            }
            
            if((val_28 != null) && (null != null))
            {
                    val_28 = 0;
            }
            
            val_22 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_28, parent:  val_22.transform).transform;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.one;
            val_22.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.one;
            val_27 = val_18.x;
            val_22.localPosition = new UnityEngine.Vector3() {x = val_27, y = val_18.y, z = val_18.z};
            return;
            label_3:
            val_25 = val_23.三丈专世专不业丝丆();
            UnityEngine.Material val_20 = val_25.Load<UnityEngine.Material>(丒丘丏上丙丟丑丕丈:  this._resourceName, 丗业三丝丁三丘一丟:  true);
            if(val_20 == 0)
            {
                    return;
            }
            
            this.丂丞丑丏丛丙世七丝.material = val_20;
        }
        public BPResourceLoader()
        {
            this._resourceType = 1;
        }
        private static BPResourceLoader()
        {
            PGCompany.BattlePass.BPResourceLoader.丅丕丒丄丌一丂不丐 = "alpha";
        }
    
    }

}
