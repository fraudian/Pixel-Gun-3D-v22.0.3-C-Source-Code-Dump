using UnityEngine;
public class ChatScroll : MonoBehaviour
{
    // Fields
    public UITextListEdit _Textlist;
    private bool 丝一专丅丆丗丌专丈;
    
    // Methods
    private void Start()
    {
        float val_6 = 0.1f;
        val_6 = (float)UnityEngine.Screen.width * val_6;
        float val_3 = posNGUI.丆丗丞丗上一业丄专(丐丗丌丞丂世丙丏丅:  val_6);
        float val_7 = 0.03f;
        val_7 = (float)UnityEngine.Screen.height * val_7;
        float val_5 = posNGUI.丒世丁万丏丅丌不丛(丅丘丏丆丟丗与丅不:  val_7);
        this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void Update()
    {
        if(UnityEngine.Application.isEditor != false)
        {
                if((UnityEngine.Input.GetMouseButtonDown(button:  0)) != false)
        {
                this.丝一专丅丆丗丌专丈 = true;
            this._Textlist.OnSelect(丛丗七丅下丞丗且丐:  true);
        }
        
            if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
                return;
        }
        
            this.丝一专丅丆丗丌专丈 = false;
            this._Textlist.OnSelect(丛丗七丅下丞丗且丐:  false);
            return;
        }
        
        int val_4 = UnityEngine.Input.touchCount;
        if(val_4 < 1)
        {
                return;
        }
        
        var val_8 = 0;
        do
        {
            UnityEngine.Touch val_5 = UnityEngine.Input.GetTouch(index:  0);
            if(专三三与三且一且一() == 0)
        {
                this.丝一专丅丆丗丌专丈 = true;
            this._Textlist.OnSelect(丛丗七丅下丞丗且丐:  true);
        }
        
            if(专三三与三且一且一() == 3)
        {
                this.丝一专丅丆丗丌专丈 = false;
            this._Textlist.OnSelect(丛丗七丅下丞丗且丐:  false);
        }
        
            val_8 = val_8 + 1;
        }
        while(val_4 != val_8);
    
    }
    private void LateUpdate()
    {
        if(this.丝一专丅丆丗丌专丈 == false)
        {
                return;
        }
        
        float val_3 = -5f;
        val_3 = (UnityEngine.Input.GetAxis(axisName:  "Mouse Y")) / val_3;
        this._Textlist.OnScroll(下下丏一丙不丘丌丞:  (float)System.Math.Round(value:  (double)val_3, digits:  1));
    }
    public ChatScroll()
    {
    
    }

}
