using UnityEngine;

namespace Rilisoft
{
    public class SceneViewPrefabLoadOperation : MonoBehaviour
    {
        // Fields
        private UnityEngine.ResourceRequest 丞丂丙丙丁一丞万三;
        private object <丝丒下丆且七丗丒东>k__BackingField;
        private System.Func<object, bool> <三丅丅丐一丝世一丏>k__BackingField;
        private System.Action<object, UnityEngine.GameObject> <丅丈丘与与丑丈丗丌>k__BackingField;
        private bool <一丌丄不世东丌丙丁>k__BackingField;
        private bool <丘专七专丂七丘且丞>k__BackingField;
        
        // Properties
        public object 丅一三丞丗一世万丟 { get; set; }
        public System.Func<object, bool> 丕丟三且丄丒专不不 { get; set; }
        public System.Action<object, UnityEngine.GameObject> 下丌丕丘丟丌丞业且 { get; set; }
        public bool 业万下下不上东一与 { get; }
        public bool 三七丟丑丞丌七丘专 { get; set; }
        public bool 丌三世丘下丌丅丁三 { get; set; }
        
        // Methods
        public object get_LoadingItem()
        {
            return (object)this.<丝丒下丆且七丗丒东>k__BackingField;
        }
        private void 丒一丆不丟丕丙上丛(object 丙业与丙丗丝不丈东)
        {
            this.<丝丒下丆且七丗丒东>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Func<object, bool> get_BreakChecker()
        {
            return (System.Func<System.Object, System.Boolean>)this.<三丅丅丐一丝世一丏>k__BackingField;
        }
        private void 一丏七丈丂丟丌丕与(System.Func<object, bool> 丙业与丙丗丝不丈东)
        {
            this.<三丅丅丐一丝世一丏>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Action<object, UnityEngine.GameObject> get_OnPrefabLoadedAction()
        {
            return (System.Action<System.Object, UnityEngine.GameObject>)this.<丅丈丘与与丑丈丗丌>k__BackingField;
        }
        private void 丁丑下东业丌丗一专(System.Action<object, UnityEngine.GameObject> 丙业与丙丗丝不丈东)
        {
            this.<丅丈丘与与丑丈丗丌>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_IsLoading()
        {
            var val_3;
            if(this.丞丂丙丙丁一丞万三 != null)
            {
                    val_3 = this.丞丂丙丙丁一丞万三.isDone ^ 1;
                return (bool)val_3 & 1;
            }
            
            val_3 = 0;
            return (bool)val_3 & 1;
        }
        public bool get_LoadComplete()
        {
            return (bool)this.<一丌丄不世东丌丙丁>k__BackingField;
        }
        private void 与丕世东一下丞丌丂(bool 丙业与丙丗丝不丈东)
        {
            this.<一丌丄不世东丌丙丁>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_IsBreaking()
        {
            return (bool)this.<丘专七专丂七丘且丞>k__BackingField;
        }
        private void 业专丞世不上丒丕丐(bool 丙业与丙丗丝不丈东)
        {
            this.<丘专七专丂七丘且丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private void Awake()
        {
            this.enabled = false;
        }
        public void Setup(object 上丛东丆丆上世丟丞, string 丑与丞三且丛与丟业, System.Func<object, bool> 丒丒丁丆丁业丒三丆, System.Action<object, UnityEngine.GameObject> 丈丌上上丕丙丞业丞)
        {
            var val_2;
            this.<三丅丅丐一丝世一丏>k__BackingField = 丒丒丁丆丁业丒三丆;
            this.<丅丈丘与与丑丈丗丌>k__BackingField = 丈丌上上丕丙丞业丞;
            this.<丝丒下丆且七丗丒东>k__BackingField = 上丛东丆丆上世丟丞;
            if(上丛东丆丆上世丟丞 != null)
            {
                    val_2 = 1;
                this.丞丂丙丙丁一丞万三 = UnityEngine.Resources.LoadAsync<UnityEngine.GameObject>(path:  丑与丞三且丛与丟业);
            }
            else
            {
                    val_2 = 0;
                this.<丘专七专丂七丘且丞>k__BackingField = true;
            }
            
            this.enabled = false;
        }
        public void Update()
        {
            UnityEngine.GameObject val_4;
            if(this.丞丂丙丙丁一丞万三 == null)
            {
                    return;
            }
            
            if((this.<丝丒下丆且七丗丒东>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<丅丈丘与与丑丈丗丌>k__BackingField) == null)
            {
                    return;
            }
            
            if((this.<丘专七专丂七丘且丞>k__BackingField) == false)
            {
                goto label_4;
            }
            
            label_13:
            this.enabled = false;
            return;
            label_4:
            if((this.<三丅丅丐一丝世一丏>k__BackingField) != null)
            {
                    if((this.<三丅丅丐一丝世一丏>k__BackingField.Invoke(arg:  this.<丝丒下丆且七丗丒东>k__BackingField)) != false)
            {
                    this.<丘专七专丂七丘且丞>k__BackingField = true;
                this.enabled = false;
            }
            
            }
            
            if(this.丞丂丙丙丁一丞万三 == null)
            {
                    return;
            }
            
            if(this.丞丂丙丙丁一丞万三.isDone == false)
            {
                    return;
            }
            
            UnityEngine.ResourceRequest val_4 = this.丞丂丙丙丁一丞万三;
            this.<一丌丄不世东丌丙丁>k__BackingField = true;
            UnityEngine.Object val_3 = val_4.asset;
            if(val_3 != null)
            {
                    val_4 = (null == null) ? (val_3) : 0;
            }
            else
            {
                    val_4 = 0;
            }
            
            this.<丅丈丘与与丑丈丗丌>k__BackingField.Invoke(arg1:  this.<丝丒下丆且七丗丒东>k__BackingField, arg2:  val_4);
            goto label_13;
        }
        public void Break()
        {
            this.<丘专七专丂七丘且丞>k__BackingField = true;
            this.enabled = false;
        }
        public SceneViewPrefabLoadOperation()
        {
        
        }
    
    }

}
