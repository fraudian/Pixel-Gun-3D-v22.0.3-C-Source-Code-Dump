using UnityEngine;

namespace Rilisoft
{
    public class DirectionViewerTarget : MonoBehaviour
    {
        // Fields
        private Rocket _rocketComponent;
        private Rilisoft.专丂下上东丛专丗七 _Type;
        
        // Properties
        public Rilisoft.专丂下上东丛专丗七 丒三丝一上丙专丗丒 { get; }
        public UnityEngine.Transform 上万丗三上丗七丝丒 { get; }
        
        // Methods
        public Rilisoft.专丂下上东丛专丗七 get_Type()
        {
            return (Rilisoft.专丂下上东丛专丗七)this._Type;
        }
        public UnityEngine.Transform get_Transform()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.transform;
            }
            
            return val_1.transform;
        }
        private void OnEnable()
        {
            if(this._Type != 0)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.东下丂东与上业丌丁());
        }
        private void OnDisable()
        {
            this.一丒丆丛丅丁丆丒万();
        }
        private System.Collections.IEnumerator 东下丂东与上业丌丁()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new DirectionViewerTarget.世丑万七东丛三业不();
        }
        private System.Collections.IEnumerator 世七东丞上丐下丐丝()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new DirectionViewerTarget.上丕不下与且业丞不();
        }
        private void 丑丂上且丌专不一专()
        {
            var val_4;
            System.Func<System.Boolean> val_6;
            val_4 = null;
            val_4 = null;
            val_6 = DirectionViewerTarget.<>c.<>9__10_0;
            if(val_6 == null)
            {
                    System.Func<System.Boolean> val_1 = null;
                val_6 = val_1;
                val_1 = new System.Func<System.Boolean>(object:  DirectionViewerTarget.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean DirectionViewerTarget.<>c::且丒丞丒下丝专丛丛());
                DirectionViewerTarget.<>c.<>9__10_0 = val_6;
            }
            
            UnityEngine.Coroutine val_3 = CoroutineRunner.丆万七与丏丁丞丂专(且丐丈丕三丟丕丙丒:  val_1, 一丏丘业丅丈东东丄:  new System.Action(object:  this, method:  System.Void Rilisoft.DirectionViewerTarget::七丛丑丑丘丂丌丌世()));
        }
        private void 一丒丆丛丅丁丆丒万()
        {
            if((Rilisoft.DirectionViewer.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return;
            }
            
            Rilisoft.DirectionViewer.<不丁丄七丛不丆丁丕>k__BackingField.ForgetMe(丞下万上三丘上与专:  this);
        }
        public DirectionViewerTarget()
        {
        
        }
        private void 七丛丑丑丘丂丌丌世()
        {
            Rilisoft.DirectionViewer.<不丁丄七丛不丆丁丕>k__BackingField.LookToMe(丞下万上三丘上与专:  this);
        }
    
    }

}
