using UnityEngine;
public class PressController : MonoBehaviour
{
    // Fields
    public bool isPrimary;
    public PressController primaryPress;
    private UnityEngine.GameObject 丈七世丝丈丗下丙一;
    public UnityEngine.GameObject secondCollision;
    
    // Methods
    private void OnTriggerEnter(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        PressController val_8;
        UnityEngine.Object val_9;
        var val_10;
        val_8 = this;
        val_9 = 丆丛丂丝丄世且丛丕.transform.gameObject;
        val_10 = null;
        val_10 = null;
        if(val_9 != WeaponManager.丟丗丄业丘丗业丗七.myPlayer)
        {
                return;
        }
        
        if(this.isPrimary != false)
        {
                this.丈七世丝丈丗下丙一 = 丆丛丂丝丄世且丛丕.transform.gameObject;
        }
        else
        {
                val_9 = this.primaryPress;
            this.primaryPress.secondCollision = 丆丛丂丝丄世且丛丕.transform.gameObject;
            val_8 = this.primaryPress;
        }
        
        val_8.CheckSmash();
    }
    private void OnTriggerExit(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        PressController val_4;
        var val_5;
        UnityEngine.GameObject val_6;
        val_4 = this;
        val_5 = null;
        val_5 = null;
        if(丆丛丂丝丄世且丛丕.transform.gameObject != WeaponManager.丟丗丄业丘丗业丗七.myPlayer)
        {
                return;
        }
        
        if(this.isPrimary != false)
        {
                val_6 = this.丈七世丝丈丗下丙一;
        }
        else
        {
                val_4 = this.primaryPress;
            val_6 = this.primaryPress.secondCollision;
        }
        
        mem2[0] = 0;
    }
    public void CheckSmash()
    {
        if(this.丈七世丝丈丗下丙一 != this.secondCollision)
        {
                return;
        }
        
        SkinName val_2 = this.丈七世丝丈丗下丙一.GetComponent<SkinName>();
        val_2.playerMoveC.丏丘丂丝丝丙丕丂不(东丏业丞丞业下丄世:  0);
    }
    private void Update()
    {
    
    }
    public PressController()
    {
    
    }

}
