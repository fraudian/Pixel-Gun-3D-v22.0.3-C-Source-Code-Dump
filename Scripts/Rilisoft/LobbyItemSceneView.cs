using UnityEngine;

namespace Rilisoft
{
    public class LobbyItemSceneView : LobbyItemSceneViewBase, 上丆丕业丘业丈丄丆
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
        public override void Setup(UnityEngine.Transform 七万上丐一丈丏丏专, Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
        {
            ClanLobbyItemController val_5;
            this.Setup(七万上丐一丈丏丏专:  七万上丐一丈丏丏专, 下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
            val_5 = ClanLobbyItemController.丄丘七三上丕世丞业;
            if(val_5 != 0)
            {
                    val_5 = this.gameObject;
                if((下丅丙一丂丗丅丝七 != null) && (val_5 != 0))
            {
                    ClanLobbyItemController.丄丘七三上丕世丞业.HideClanLobbyItems();
            }
            
            }
            
            this.gameObject.SetActive(value:  true);
        }
        public override void UpdateView()
        {
            this.gameObject.SetActive(value:  true);
            this.七丌三东一一丗且七();
            if(ClanLobbyItemController.丄丘七三上丕世丞业 == 0)
            {
                    return;
            }
            
            if(this.gameObject == 0)
            {
                    return;
            }
            
            if(null == 0)
            {
                    return;
            }
            
            ClanLobbyItemController.丄丘七三上丕世丞业.HideClanLobbyItems();
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
        protected override void 丌不丂丌丁丛丆丟与()
        {
            if(Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            Rilisoft.LobbyCraftController.丆丕丝丒不丙且丐丗.丕且与万一丐丞下丁(丂三七下丗且丌上一:  this, 丗业三丝丁万世丄丐:  false);
        }
        protected override void 丐丟丟丈丅三丄丛丌()
        {
            object val_4;
            object val_24;
            var val_25;
            var val_26;
            val_24 = this;
            if(true == 0)
            {
                    return;
            }
            
            System.Func<UnityEngine.Mesh, System.Boolean> val_1 = new System.Func<UnityEngine.Mesh, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.LobbyItemSceneView::丌世东且丝丙丟丏丞(UnityEngine.Mesh 丑与丗丛丝丈丙丆丌));
            List.Enumerator<T> val_2 = X21.GetEnumerator();
            label_30:
            if(((-89945248) & 1) == 0)
            {
                goto label_3;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            if(val_5 == 0)
            {
                goto label_30;
            }
            
            UnityEngine.MeshFilter val_7 = val_5.GetComponent<UnityEngine.MeshFilter>();
            if(((val_7 != 0) && (val_7.sharedMesh != 0)) && ((null.Invoke(arg:  val_7.sharedMesh)) != true))
            {
                    if((System.String.op_Inequality(a:  val_7.sharedMesh.name, b:  "Sphere001")) != false)
            {
                    UnityEngine.Resources.UnloadAsset(assetToUnload:  val_7.sharedMesh);
            }
            
            }
            
            if(((val_5 == null) || (val_5.sharedMesh == 0)) || ((null.Invoke(arg:  val_5.sharedMesh)) == true))
            {
                goto label_30;
            }
            
            UnityEngine.Resources.UnloadAsset(assetToUnload:  val_5.sharedMesh);
            goto label_30;
            label_3:
            val_25 = 0;
            val_26 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_53;
            }
            
            if( == 0)
            {
                goto label_57;
            }
            
            if(227 != 227)
            {
                goto label_55;
            }
            
            goto label_57;
            label_53:
            if( == 0)
            {
                goto label_57;
            }
            
            label_55:
            label_57:
            this.丐丟丟丈丅三丄丛丌();
        }
        public LobbyItemSceneView()
        {
        
        }
        private bool 丌世东且丝丙丟丏丞(UnityEngine.Mesh 丑与丗丛丝丈丙丆丌)
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
