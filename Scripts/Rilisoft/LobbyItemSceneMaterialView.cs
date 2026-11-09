using UnityEngine;

namespace Rilisoft
{
    public class LobbyItemSceneMaterialView : LobbyItemSceneViewBase, 上丆丕业丘业丈丄丆
    {
        // Fields
        private UnityEngine.Material[] 丏丑丗丞丆七丘丅丐;
        
        // Properties
        protected override UnityEngine.GameObject 丘三业丒世丘世丞丟 { get; }
        
        // Methods
        protected override UnityEngine.GameObject 且丆上丂且下丙丐东()
        {
            UnityEngine.Transform val_4 = this.gameObject.transform.parent.GetChild(index:  0);
            if(val_4 != null)
            {
                    return val_4.gameObject;
            }
            
            return val_4.gameObject;
        }
        public override void Setup(UnityEngine.Transform 七万上丐一丈丏丏专, Rilisoft.丏丘七丞丄丙丌丞丁 下丅丙一丂丗丅丝七)
        {
            var val_16;
            System.Func<System.String, UnityEngine.Material> val_18;
            this.Setup(七万上丐一丈丏丏专:  七万上丐一丈丏丏专, 下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七);
            UnityEngine.Transform val_1 = 七万上丐一丈丏丏专.GetChild(index:  0);
            UnityEngine.GameObject val_2 = val_1.gameObject;
            if(val_2 == null)
            {
                    return;
            }
            
            if(val_2.Count == 0)
            {
                    return;
            }
            
            UnityEngine.Renderer val_4 = val_1.Item[0];
            this.丏丑丗丞丆七丘丅丐 = System.Linq.Enumerable.ToArray<UnityEngine.Material>(source:  val_4.sharedMaterials);
            UnityEngine.Renderer val_7 = 下丅丙一丂丗丅丝七.Item[0];
            val_16 = null;
            val_16 = null;
            val_18 = LobbyItemSceneMaterialView.<>c.<>9__3_0;
            if(val_18 == null)
            {
                    System.Func<System.String, UnityEngine.Material> val_10 = null;
                val_18 = val_10;
                val_10 = new System.Func<System.String, UnityEngine.Material>(object:  LobbyItemSceneMaterialView.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Material LobbyItemSceneMaterialView.<>c::世三专万丑万丏丕不(string 东丝丄丝丙专丘三丏));
                LobbyItemSceneMaterialView.<>c.<>9__3_0 = val_18;
            }
            
            val_4.set_Item(key:  val_7, value:  System.Linq.Enumerable.ToArray<UnityEngine.Material>(source:  System.Linq.Enumerable.Select<System.String, UnityEngine.Material>(source:  丙丕丞且丕不丘丙丑().丁丌丘丟丘丌下世丁(), selector:  val_10)));
            val_4.Item[0].sharedMaterials = val_4.Item[val_7.Item[0]];
        }
        public override void Hide()
        {
            if(51534 == 0)
            {
                    return;
            }
            
            if(51534.Count < 1)
            {
                    return;
            }
            
            Item[0].sharedMaterials = this.丏丑丗丞丆七丘丅丐;
        }
        public override void UpdateView()
        {
            this.七丌三东一一丗且七();
        }
        public override void Kill()
        {
            UnityEngine.Object.Destroy(obj:  this.gameObject);
        }
        public LobbyItemSceneMaterialView()
        {
        
        }
    
    }

}
