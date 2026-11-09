using UnityEngine;

namespace Rilisoft
{
    public class FortItemSceneView : FortItemSceneViewBase, 丕丂丒丁丏东且一七
    {
        // Fields
        private string[] 丘丂与丆万丒三丕丞;
        
        // Properties
        protected override UnityEngine.GameObject 丘三业丒世丘世丞丟 { get; }
        private string[] 下专丘丂万丒丞丐丟 { get; }
        
        // Methods
        protected override UnityEngine.GameObject 且丆上丂且下丙丐东()
        {
            return this.gameObject;
        }
        private string[] 丙丌丞世东下丄与一()
        {
            if(this.丘丂与丆万丒三丕丞 != null)
            {
                    return (System.String[])val_3;
            }
            
            if((System.Enum.GetNames(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))) == null)
            {
                    string[] val_3 = new string[0];
            }
            
            this.丘丂与丆万丒三丕丞 = val_3;
            return (System.String[])val_3;
        }
        public override void Setup(UnityEngine.Transform 七万上丐一丈丏丏专, Rilisoft.FortCraftController 丒专丈丛下丒一丒丛, Rilisoft.东且东丒丐世丐丞丒 下丅丙一丂丗丅丝七, 丞东丌丟与丅丅万丝.丗丞丏丙七丑丕且丐 丆丐专丘丅万丂丐不 = 0)
        {
            this.Setup(七万上丐一丈丏丏专:  七万上丐一丈丏丏专, 丒专丈丛下丒一丒丛:  丒专丈丛下丒一丒丛, 下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 与丄不丌一世东丁丙:  丆丐专丘丅万丂丐不);
            this.gameObject.SetActive(value:  true);
        }
        public override void UpdateView()
        {
            this.gameObject.SetActive(value:  true);
            this.七丌三东一一丗且七();
        }
        public override void Hide()
        {
            this.gameObject.SetActive(value:  false);
        }
        public override void Kill()
        {
            this.gameObject.SetActive(value:  false);
            this.gameObject.transform.SetParent(p:  0);
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public override void Kill(bool 不丟一丄丁丆丅上丒)
        {
            this.gameObject.SetActive(value:  false);
            this.gameObject.transform.SetParent(p:  0);
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        protected override void 丌不丂丌丁丛丆丟与()
        {
            X19.SelectItemOnSceneRequest(丂三七下丗且丌上一:  X20, 与丄不丌一世东丁丙:  W21);
        }
        protected override void 丐丟丟丈丅三丄丛丌()
        {
            object val_4;
            object val_21;
            var val_22;
            var val_23;
            val_21 = this;
            if(true == 0)
            {
                    return;
            }
            
            System.Func<UnityEngine.Mesh, System.Boolean> val_1 = new System.Func<UnityEngine.Mesh, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.FortItemSceneView::丕丒丅专丁丑下丁与(UnityEngine.Mesh 丑与丗丛丝丈丙丆丌));
            List.Enumerator<T> val_2 = X21.GetEnumerator();
            label_27:
            if(((-583993648) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if(val_5 == 0)
            {
                goto label_27;
            }
            
            UnityEngine.MeshFilter val_7 = val_5.GetComponent<UnityEngine.MeshFilter>();
            if((val_7 != 0) && (val_7.sharedMesh != 0))
            {
                    if((null.Invoke(arg:  val_7.sharedMesh)) != true)
            {
                    UnityEngine.Resources.UnloadAsset(assetToUnload:  val_7.sharedMesh);
            }
            
            }
            
            if(((val_5 == null) || (val_5.sharedMesh == 0)) || ((null.Invoke(arg:  val_5.sharedMesh)) == true))
            {
                goto label_27;
            }
            
            UnityEngine.Resources.UnloadAsset(assetToUnload:  val_5.sharedMesh);
            goto label_27;
            label_3:
            val_22 = 0;
            val_23 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_47;
            }
            
            if( == 0)
            {
                goto label_51;
            }
            
            if(201 != 201)
            {
                goto label_49;
            }
            
            goto label_51;
            label_47:
            if( == 0)
            {
                goto label_51;
            }
            
            label_49:
            label_51:
            this.丐丟丟丈丅三丄丛丌();
        }
        public FortItemSceneView()
        {
        
        }
        private bool 丕丒丅专丁丑下丁与(UnityEngine.Mesh 丑与丗丛丝丈丙丆丌)
        {
            if(丑与丗丛丝丈丙丆丌 == 0)
            {
                    return false;
            }
            
            if(丑与丗丛丝丈丙丆丌.name == null)
            {
                    return false;
            }
            
            return System.Linq.Enumerable.Contains<System.String>(source:  this.丙丌丞世东下丄与一(), value:  丑与丗丛丝丈丙丆丌.name);
        }
    
    }

}
