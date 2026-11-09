using UnityEngine;

namespace Rilisoft
{
    public class GuiElementHandler : MonoBehaviour
    {
        // Fields
        private Rilisoft.GuiElementBase _element;
        private Rilisoft.PrefabHandler _prefabHandler;
        private string _showOnScene;
        
        // Methods
        private void Start()
        {
            object val_16;
            var val_17;
            System.Action<Rilisoft.且丙业丂丞一丈丙七> val_18;
            val_16 = this;
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this._showOnScene)) == false)
            {
                    return;
            }
            
            val_17 = 1152921504615686144;
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丈丏丕丞一丗丏丄丅(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.且丙业丂丞一丈丙七>(object:  this, method:  System.Void Rilisoft.GuiElementHandler::丄丌一丄与专丞丙丘(Rilisoft.且丙业丂丞一丈丙七 丕丁一不专丄丕丅丗)));
            System.Action<Rilisoft.且丙业丂丞一丈丙七> val_5 = null;
            val_18 = val_5;
            val_5 = new System.Action<Rilisoft.且丙业丂丞一丈丙七>(object:  this, method:  System.Void Rilisoft.GuiElementHandler::丙与东丏丕丞丕丐东(Rilisoft.且丙业丂丞一丈丙七 丕丁一不专丄丕丅丗));
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.七东七不不丅下丞东(丙业与丙丗丝不丈东:  val_5);
            if((System.String.op_Equality(a:  Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗(), b:  this._showOnScene)) == false)
            {
                    return;
            }
            
            val_16 = ???;
            val_18 = ???;
            val_17 = ???;
            goto typeof(Rilisoft.GuiElementHandler).__il2cppRuntimeField_168;
        }
        private void 丙与东丏丕丞丕丐东(Rilisoft.且丙业丂丞一丈丙七 丕丁一不专丄丕丅丗)
        {
            if((System.String.op_Equality(a:  Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗(), b:  this._showOnScene)) == false)
            {
                    return;
            }
            
            goto typeof(Rilisoft.GuiElementHandler).__il2cppRuntimeField_168;
        }
        private void 丄丌一丄与专丞丙丘(Rilisoft.且丙业丂丞一丈丙七 丕丁一不专丄丕丅丗)
        {
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this._showOnScene)) == false)
            {
                    return;
            }
            
            if((System.String.op_Inequality(a:  this._showOnScene, b:  丕丁一不专丄丕丅丗.<且上丁世丞丛上丁不>k__BackingField.丐丏七丌丕丗业且上())) == false)
            {
                    return;
            }
            
            if(this._element == 0)
            {
                    return;
            }
            
            this = this._element;
            UnityEngine.Object.Destroy(obj:  this);
        }
        private void OnDestroy()
        {
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丛丌上丐丘不且丙七(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.且丙业丂丞一丈丙七>(object:  this, method:  System.Void Rilisoft.GuiElementHandler::丙与东丏丕丞丕丐东(Rilisoft.且丙业丂丞一丈丙七 丕丁一不专丄丕丅丗)));
            if(this._element == 0)
            {
                    return;
            }
            
            this._element.专丌丅下万丐三丗丗();
        }
        public virtual void ShowElement()
        {
            if(this._element == 0)
            {
                goto label_3;
            }
            
            label_24:
            this._element.业下丛七业丆丛万丂();
            return;
            label_3:
            if(this._prefabHandler.Prefab == 0)
            {
                    return;
            }
            
            if((丞东丑专丛丆丄丝世.丏丆专业丞丗东丙丏<Rilisoft.GuiElementBase>(丝三丁东丈丒世丅业:  this._prefabHandler.Prefab)) == false)
            {
                    return;
            }
            
            UnityEngine.GameObject val_7 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._prefabHandler.Prefab);
            UnityEngine.Transform val_8 = val_7.transform;
            val_8.SetParent(p:  this.transform);
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_8.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.one;
            val_8.localScale = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
            Rilisoft.GuiElementBase val_12 = val_7.GetComponent<Rilisoft.GuiElementBase>();
            this._element = val_12;
            if(val_12 != null)
            {
                goto label_24;
            }
            
            goto label_24;
        }
        public virtual void HideElement()
        {
            this._element.专丌丅下万丐三丗丗();
        }
        public GuiElementHandler()
        {
        
        }
    
    }

}
