using UnityEngine;

namespace Rilisoft
{
    public class GuiElement : GuiElementBase
    {
        // Fields
        private string _showOnScene;
        
        // Properties
        public override bool 七七业丒丟丝丘不丞 { get; }
        
        // Methods
        public override bool get_IsVisible()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeInHierarchy;
            }
            
            return val_1.activeInHierarchy;
        }
        protected override void 东丟丘世丕丆下不万()
        {
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        protected override void 丙丝七丅丑三丞丂且()
        {
            UnityEngine.Object val_4 = 0;
            if(this.gameObject != val_4)
            {
                    val_4 = 0;
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
            }
        
        }
        protected override void Start()
        {
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this._showOnScene)) == false)
            {
                    return;
            }
            
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丈丏丕丞一丗丏丄丅(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.且丙业丂丞一丈丙七>(object:  this, method:  System.Void Rilisoft.GuiElement::丄丌一丄与专丞丙丘(Rilisoft.且丙业丂丞一丈丙七 丕丁一不专丄丕丅丗)));
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.七东七不不丅下丞东(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.且丙业丂丞一丈丙七>(object:  this, method:  System.Void Rilisoft.GuiElement::丙与东丏丕丞丕丐东(Rilisoft.且丙业丂丞一丈丙七 丕丁一不专丄丕丅丗)));
            if((System.String.op_Equality(a:  Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗(), b:  this._showOnScene)) == false)
            {
                    return;
            }
            
            this.业下丛七业丆丛万丂();
        }
        private void 丙与东丏丕丞丕丐东(Rilisoft.且丙业丂丞一丈丙七 丕丁一不专丄丕丅丗)
        {
            if((System.String.op_Equality(a:  Rilisoft.SceneLoader.丝丝三丏丈丁丏丘丗(), b:  this._showOnScene)) == false)
            {
                    return;
            }
            
            this.业下丛七业丆丛万丂();
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
            
            if(this.gameObject == 0)
            {
                    return;
            }
            
            this = this.gameObject;
            UnityEngine.Object.Destroy(obj:  this);
        }
        protected override void OnDestroy()
        {
            Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.丛丌上丐丘不且丙七(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.且丙业丂丞一丈丙七>(object:  this, method:  System.Void Rilisoft.GuiElement::丙与东丏丕丞丕丐东(Rilisoft.且丙业丂丞一丈丙七 丕丁一不专丄丕丅丗)));
        }
        public GuiElement()
        {
        
        }
    
    }

}
