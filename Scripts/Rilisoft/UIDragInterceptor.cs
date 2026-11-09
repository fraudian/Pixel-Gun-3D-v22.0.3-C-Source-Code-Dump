using UnityEngine;

namespace Rilisoft
{
    public class UIDragInterceptor : MonoBehaviour
    {
        // Fields
        private bool 三丘丞丆丙下丘不三;
        private System.Action 下丐丂丏下业丁三丛;
        private System.Action 一丁丁丟专丐丗丛与;
        private System.Action<UnityEngine.Vector2> 丙下业不上丕上不业;
        private System.Action 丌不丂丌丁丛丆丟与;
        
        // Methods
        public void add_OnDragStarted(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.下丐丂丏下业丁三丛, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下丐丂丏下业丁三丛 != 1152921543600101680);
        
        }
        public void remove_OnDragStarted(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.下丐丂丏下业丁三丛, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.下丐丂丏下业丁三丛 != 1152921543600238256);
        
        }
        public void add_OnDragEnded(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.一丁丁丟专丐丗丛与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.一丁丁丟专丐丗丛与 != 1152921543600374840);
        
        }
        public void remove_OnDragEnded(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.一丁丁丟专丐丗丛与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.一丁丁丟专丐丗丛与 != 1152921543600511416);
        
        }
        public void add_OnDragging(System.Action<UnityEngine.Vector2> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丙下业不上丕上不业, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丙下业不上丕上不业 != 1152921543600648000);
        
        }
        public void remove_OnDragging(System.Action<UnityEngine.Vector2> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丙下业不上丕上不业, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丙下业不上丕上不业 != 1152921543600784576);
        
        }
        public void add_OnClicked(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丌不丂丌丁丛丆丟与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丌不丂丌丁丛丆丟与 != 1152921543600921160);
        
        }
        public void remove_OnClicked(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丌不丂丌丁丛丆丟与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丌不丂丌丁丛丆丟与 != 1152921543601057736);
        
        }
        private void OnDragStart()
        {
            if(this.下丐丂丏下业丁三丛 == null)
            {
                    return;
            }
            
            this.下丐丂丏下业丁三丛.Invoke();
        }
        private void OnDrag(UnityEngine.Vector2 delta)
        {
            if(this.丙下业不上丕上不业 == null)
            {
                    return;
            }
            
            this.丙下业不上丕上不业.Invoke(obj:  new UnityEngine.Vector2() {x = delta.x, y = delta.y});
        }
        private void OnDragEnd()
        {
            this.三丘丞丆丙下丘不三 = true;
            if(this.一丁丁丟专丐丗丛与 == null)
            {
                    return;
            }
            
            this.一丁丁丟专丐丗丛与.Invoke();
        }
        private void OnClick()
        {
            if(this.三丘丞丆丙下丘不三 != false)
            {
                    this.三丘丞丆丙下丘不三 = false;
                return;
            }
            
            if(this.丌不丂丌丁丛丆丟与 == null)
            {
                    return;
            }
            
            this.丌不丂丌丁丛丆丟与.Invoke();
        }
        public UIDragInterceptor()
        {
        
        }
    
    }

}
