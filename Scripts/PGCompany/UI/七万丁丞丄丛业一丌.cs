using UnityEngine;

namespace PGCompany.UI
{
    internal class 七万丁丞丄丛业一丌 : IDisposable
    {
        // Fields
        private readonly UnityEngine.Transform 丒丝下丂丘东专丄三;
        private LoadingAnimation 丑丂专万东丟一丞业;
        
        // Properties
        internal bool 业与丟七与丞丛丒万 { get; }
        
        // Methods
        internal bool 且丑丛丘下丟丑丛丐()
        {
            if(this.丑丂专万东丟一丞业 == 0)
            {
                    return false;
            }
            
            if(this.丑丂专万东丟一丞业 != null)
            {
                    return this.丑丂专万东丟一丞业.世丑三丆丒七丘丕丑();
            }
            
            return this.丑丂专万东丟一丞业.世丑三丆丒七丘丕丑();
        }
        internal 七万丁丞丄丛业一丌(UnityEngine.Transform 七万上丐一丈丏丏专)
        {
            this.丒丝下丂丘东专丄三 = 七万上丐一丈丏丏专;
        }
        internal void 丒上丁丄丛上丅丁且()
        {
            this.与丙丏丘万不东丂丙();
            this.丟东丛丅与一三丕丏();
            StoreKitEventListener.一万丟丌东丈丄三一(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PGCompany.UI.七万丁丞丄丛业一丌::丈与丟一丄丄丒且丐(bool 丙业与丙丗丝不丈东)));
        }
        internal void 与丙丏丘万不东丂丙()
        {
            StoreKitEventListener.丛丈专丑上丙丕丗丝(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void PGCompany.UI.七万丁丞丄丛业一丌::丈与丟一丄丄丒且丐(bool 丙业与丙丗丝不丈东)));
        }
        private void 丈与丟一丄丄丒且丐(bool 丙业与丙丗丝不丈东)
        {
            this.丟东丛丅与一三丕丏();
        }
        private void 丟东丛丅与一三丕丏()
        {
            if(StoreKitEventListener.三丘丈不丝丕丞东丌() != false)
            {
                    if(this.丑丂专万东丟一丞业 == 0)
            {
                    LoadingAnimation val_3 = UnityEngine.Resources.Load<LoadingAnimation>(path:  "Banners/LoadingAnimation");
                if(val_3 != 0)
            {
                    int val_5 = UnityEngine.LayerMask.NameToLayer(layerName:  "IndicatorLoading");
                this.丑丂专万东丟一丞业 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与<LoadingAnimation>(丑且不丕与专丄业丙:  val_3, 丈东丘丏与丌东东下:  this.丒丝下丂丘东专丄三, 丙专下东丝一丐丌丟:  true, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            }
            
            }
            
                if(this.丑丂专万东丟一丞业 == 0)
            {
                    return;
            }
            
                this = this.丑丂专万东丟一丞业;
                this.下与丞三丅丛丄七丕(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0853"), 丂三丟丂丈丐丆丗丟:  -1f);
                return;
            }
            
            if(this.丑丂专万东丟一丞业 == 0)
            {
                    return;
            }
            
            this.丑丂专万东丟一丞业.丆世与丑丆丅丐万且();
        }
        public void Dispose()
        {
            this.与丙丏丘万不东丂丙();
            if(this.丑丂专万东丟一丞业 == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丑丂专万东丟一丞业.gameObject);
        }
    
    }

}
