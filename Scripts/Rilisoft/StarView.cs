using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    internal sealed class StarView : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _foregroundObject;
        private System.EventHandler Clicked;
        
        // Methods
        internal void 七一丕丁丅且专一丂(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.Clicked, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.Clicked != 1152921543520580848);
        
        }
        internal void 不上世丙丈丅丒上丂(System.EventHandler 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.Clicked, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.Clicked != 1152921543520717424);
        
        }
        internal void 丘丘一七丛东丑丕专(bool 下下东且万业丞丅丒)
        {
            if(this._foregroundObject == 0)
            {
                    return;
            }
            
            this._foregroundObject.SetActive(value:  下下东且万业丞丅丒);
        }
        private void OnClick()
        {
            var val_1;
            if(this.Clicked == null)
            {
                    return;
            }
            
            val_1 = null;
            val_1 = null;
            this.Clicked.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        public StarView()
        {
        
        }
    
    }

}
