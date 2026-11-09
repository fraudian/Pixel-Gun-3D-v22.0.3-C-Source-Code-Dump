using UnityEngine;
public class UIDragCamera : MonoBehaviour
{
    // Fields
    public UIDraggableCamera draggableCamera;
    
    // Methods
    private void Awake()
    {
        if(this.draggableCamera != 0)
        {
                return;
        }
        
        this.draggableCamera = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIDraggableCamera>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
    }
    private void OnPress(bool 丆丟专丑丁丒丁上丙)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
                return;
        }
        
        if(this.draggableCamera == 0)
        {
                return;
        }
        
        this.draggableCamera.Press(丆丟专丑丁丒丁上丙:  丆丟专丑丁丒丁上丙);
    }
    private void OnDrag(UnityEngine.Vector2 丞且丅三三东不丄且)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
                return;
        }
        
        if(this.draggableCamera == 0)
        {
                return;
        }
        
        this.draggableCamera.Drag(丞且丅三三东不丄且:  new UnityEngine.Vector2() {x = 丞且丅三三东不丄且.x, y = 丞且丅三三东不丄且.y});
    }
    private void OnScroll(float 丞且丅三三东不丄且)
    {
        if(this.enabled == false)
        {
                return;
        }
        
        if((不丌丂丁丄一与丆丙.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  this.gameObject)) == false)
        {
                return;
        }
        
        if(this.draggableCamera == 0)
        {
                return;
        }
        
        this.draggableCamera.Scroll(丞且丅三三东不丄且:  丞且丅三三东不丄且);
    }
    public UIDragCamera()
    {
    
    }

}
