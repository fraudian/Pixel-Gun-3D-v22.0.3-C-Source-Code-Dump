using UnityEngine;

namespace Prime31
{
    public class GoogleBuyIntentExtraParams
    {
        // Fields
        public System.Collections.Generic.List<string> skusToReplace;
        public bool replaceSkusProration;
        public string accountId;
        
        // Methods
        public GoogleBuyIntentExtraParams()
        {
            this.skusToReplace = new System.Collections.Generic.List<System.String>();
        }
    
    }

}
