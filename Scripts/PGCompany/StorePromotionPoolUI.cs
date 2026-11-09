using UnityEngine;

namespace PGCompany
{
    internal sealed class StorePromotionPoolUI : PGBehaviour
    {
        // Fields
        public UnityEngine.MonoBehaviour example;
        public System.Collections.Generic.List<UnityEngine.MonoBehaviour> pool;
        public UnityEngine.Transform parent;
        
        // Methods
        public T Get<T>(System.Action<UnityEngine.MonoBehaviour> 丏东下下一丗专下丏)
        {
            var val_3;
            System.Collections.Generic.List<UnityEngine.MonoBehaviour> val_10;
            var val_11;
            UnityEngine.MonoBehaviour val_12;
            UnityEngine.Transform val_13;
            val_10 = __RuntimeMethodHiddenParam;
            val_11 = 丏东下下一丗专下丏;
            if(this.pool.Count < 1)
            {
                goto label_2;
            }
            
            val_11 = this.pool.Item[0];
            if(val_11 == null)
            {
                goto label_6;
            }
            
            val_12 = val_11;
            if(val_12 != null)
            {
                goto label_7;
            }
            
            label_6:
            val_12 = 0;
            label_7:
            val_10 = this.pool;
            val_10.RemoveAt(index:  0);
            return (PGCompany.StorePromotionInfoUIAbstract)val_12;
            label_2:
            val_12 = 0;
            if(this.example == 0)
            {
                    return (PGCompany.StorePromotionInfoUIAbstract)val_12;
            }
            
            if(this.parent != 0)
            {
                    val_13 = this.parent;
            }
            else
            {
                    val_13 = this.example.transform.parent;
            }
            
            val_3 = 0;
            val_12 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与(丑且不丕与专丄业丙:  this.example.gameObject, 丈东丘丏与丌东东下:  val_13, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            if(val_11 == null)
            {
                    return (PGCompany.StorePromotionInfoUIAbstract)val_12;
            }
            
            val_11.Invoke(obj:  val_12);
            return (PGCompany.StorePromotionInfoUIAbstract)val_12;
        }
        public void Return(UnityEngine.MonoBehaviour 万且万且丑丗且丌丆)
        {
            万且万且丑丗且丌丆.gameObject.SetActive(value:  false);
            this.pool.Add(item:  万且万且丑丗且丌丆);
        }
        public StorePromotionPoolUI()
        {
            this.pool = new System.Collections.Generic.List<UnityEngine.MonoBehaviour>();
        }
    
    }

}
