using UnityEngine;

namespace NJG
{
    public class UIMapArrow : MonoBehaviour
    {
        // Fields
        private NJGMapItem _item;
        public UnityEngine.Transform child;
        public bool isValid;
        public UISprite sprite;
        private UnityEngine.Transform 丐一丗丛丕世丘东丁;
        
        // Properties
        public NJGMapItem 下丅丙一丂丗丅丝七 { get; set; }
        public UnityEngine.Transform 丛丄与丌丛万业丝丞 { get; }
        
        // Methods
        public NJGMapItem get_item()
        {
            return (NJGMapItem)this._item;
        }
        public void set_item(NJGMapItem 丙业与丙丗丝不丈东)
        {
            this._item = 丙业与丙丗丝不丈东;
        }
        public UnityEngine.Transform get_cachedTransform()
        {
            UnityEngine.Transform val_3;
            if(this.丐一丗丛丕世丘东丁 == 0)
            {
                    this.丐一丗丛丕世丘东丁 = this.transform;
                return val_3;
            }
            
            val_3 = this.丐一丗丛丕世丘东丁;
            return val_3;
        }
        public void UpdatePosition(UnityEngine.Vector2 丐丝丐丂且东且一丏, UnityEngine.Vector2 且丅丘丑丆丞丘不丄, float 丅下上东丅七下一丟, float 东下丗丒丟丐业业丈)
        {
            float val_16 = 丅下上东丅七下一丟;
            float val_2 = 丐丝丐丂且东且一丏.x * 东下丗丒丟丐业业丈;
            val_2 = val_2 - (丐丝丐丂且东且一丏.y * val_16);
            float val_14 = (float)this.sprite.width;
            float val_15 = (float)this.sprite.width;
            val_14 = val_14 * 0.5f;
            val_15 = val_15 * 0.5f;
            val_16 = 丐丝丐丂且东且一丏.x * val_16;
            val_14 = val_14 - 且丅丘丑丆丞丘不丄.x;
            且丅丘丑丆丞丘不丄.x = 且丅丘丑丆丞丘不丄.x - val_15;
            且丅丘丑丆丞丘不丄.x = 且丅丘丑丆丞丘不丄.x + (-2f);
            float val_8 = UnityEngine.Mathf.Clamp(value:  val_2, min:  val_14 + 2f, max:  且丅丘丑丆丞丘不丄.x);
            val_16 = val_16 + (丐丝丐丂且东且一丏.y * 东下丗丒丟丐业业丈);
            float val_17 = (float)this.sprite.height;
            float val_18 = (float)this.sprite.height;
            val_17 = val_17 * 0.5f;
            val_18 = val_18 * 0.5f;
            val_17 = val_17 - 且丅丘丑丆丞丘不丄.y;
            float val_11 = 且丅丘丑丆丞丘不丄.y - val_18;
            val_11 = val_11 + (-2f);
            float val_13 = UnityEngine.Mathf.Clamp(value:  val_16, min:  val_17 + 2f, max:  val_11);
            this.cachedTransform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public UIMapArrow()
        {
        
        }
    
    }

}
