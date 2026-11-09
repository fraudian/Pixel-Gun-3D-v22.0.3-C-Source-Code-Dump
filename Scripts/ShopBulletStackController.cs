using UnityEngine;
public class ShopBulletStackController : MonoBehaviour
{
    // Fields
    internal static ShopBulletStackController 丄丞丁丈与业上丞丟;
    public System.Collections.Generic.List<UnityEngine.GameObject>[] bullets;
    private int[] 丄丂丙丒一丏丞且丘;
    public UnityEngine.Transform for252BulletStack;
    public UnityEngine.Transform greenBulletStack;
    public UnityEngine.Transform redBulletStack;
    public UnityEngine.Transform standartBulletStack;
    public UnityEngine.Transform turquoiseBulletStack;
    public UnityEngine.Transform violetBulletStack;
    
    // Methods
    private void Start()
    {
        System.Collections.Generic.List<UnityEngine.GameObject>[] val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        ShopBulletStackController.丄丞丁丈与业上丞丟 = this;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        var val_23 = 0;
        do
        {
            val_23 = val_23 + 1;
            this.丄丂丙丒一丏丞且丘[val_23] = 0;
        }
        while(val_23 != 6);
        
        val_23 = new System.Collections.Generic.List<UnityEngine.GameObject>[6];
        this.bullets = val_23;
        val_24 = 0;
        goto label_7;
        label_15:
        System.Collections.Generic.List<UnityEngine.GameObject> val_4 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        if(this.bullets == null)
        {
            goto label_8;
        }
        
        if(val_4 != null)
        {
            goto label_9;
        }
        
        goto label_12;
        label_8:
        if(val_4 == null)
        {
            goto label_12;
        }
        
        label_9:
        label_12:
        this.bullets[0] = val_4;
        val_23 = this.bullets;
        val_24 = 1;
        label_7:
        if(val_24 < this.bullets.Length)
        {
            goto label_15;
        }
        
        val_25 = 0;
        goto label_16;
        label_23:
        this.bullets[0].Add(item:  this.standartBulletStack.GetChild(index:  0).gameObject);
        val_25 = 1;
        label_16:
        if(val_25 < this.standartBulletStack.childCount)
        {
            goto label_23;
        }
        
        val_26 = 0;
        goto label_24;
        label_31:
        this.bullets[1].Add(item:  this.redBulletStack.GetChild(index:  0).gameObject);
        val_26 = 1;
        label_24:
        if(val_26 < this.redBulletStack.childCount)
        {
            goto label_31;
        }
        
        val_27 = 0;
        goto label_32;
        label_39:
        this.bullets[2].Add(item:  this.for252BulletStack.GetChild(index:  0).gameObject);
        val_27 = 1;
        label_32:
        if(val_27 < this.for252BulletStack.childCount)
        {
            goto label_39;
        }
        
        val_28 = 0;
        goto label_40;
        label_47:
        this.bullets[3].Add(item:  this.turquoiseBulletStack.GetChild(index:  0).gameObject);
        val_28 = 1;
        label_40:
        if(val_28 < this.turquoiseBulletStack.childCount)
        {
            goto label_47;
        }
        
        val_29 = 0;
        goto label_48;
        label_55:
        this.bullets[4].Add(item:  this.greenBulletStack.GetChild(index:  0).gameObject);
        val_29 = 1;
        label_48:
        if(val_29 < this.greenBulletStack.childCount)
        {
            goto label_55;
        }
        
        val_30 = 0;
        goto label_56;
        label_63:
        this.bullets[5].Add(item:  this.violetBulletStack.GetChild(index:  0).gameObject);
        val_30 = 1;
        label_56:
        if(val_30 < this.violetBulletStack.childCount)
        {
            goto label_63;
        }
    
    }
    public UnityEngine.GameObject GetCurrentBullet(int 丁丅丈丌丟世丗丗丟 = 0)
    {
        System.Int32[] val_12;
        int val_13;
        var val_14;
        val_13 = 丁丅丈丌丟世丗丗丟;
        if((val_13 & 2147483648) == 0)
        {
                int val_12 = this.丄丂丙丒一丏丞且丘[(long)val_13];
            val_12 = val_12 + 1;
            this.丄丂丙丒一丏丞且丘[(long)val_13] = val_12;
            if(this.丄丂丙丒一丏丞且丘[(long)val_13] >= this.bullets[(long)val_13].Count)
        {
                this.丄丂丙丒一丏丞且丘[(long)val_13] = 0;
        }
        
            Bullet val_3 = this.bullets[(long)val_13].Item[this.丄丂丙丒一丏丞且丘[(long)val_13]].GetComponent<Bullet>();
            if(val_3.isUse != false)
        {
                if(this.bullets[(long)val_13].Count <= 19)
        {
                this.bullets[(long)val_13].Add(item:  UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.bullets[(long)val_13].Item[0], parent:  this.bullets[(long)val_13].Item[0].transform.parent));
            int val_22 = this.bullets[(long)val_13].Count;
            val_22 = val_22 - 1;
            this.丄丂丙丒一丏丞且丘[(long)val_13] = val_22;
        }
        
        }
        
            val_12 = this.丄丂丙丒一丏丞且丘;
            val_13 = val_12[(long)val_13];
            UnityEngine.GameObject val_11 = this.bullets[(long)val_13].Item[val_13];
            return (UnityEngine.GameObject)val_14;
        }
        
        val_14 = 0;
        return (UnityEngine.GameObject)val_14;
    }
    private void OnDestroy()
    {
        ShopBulletStackController.丄丞丁丈与业上丞丟 = 0;
    }
    public ShopBulletStackController()
    {
        this.丄丂丙丒一丏丞且丘 = new int[6];
    }

}
