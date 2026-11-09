using UnityEngine;
public class DetectColliderHit : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.Collider> 不七丗万丞丌丒丁丌;
    public int countHit;
    private float 丞丂丌丒不丂且丅世;
    
    // Methods
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Object val_31 = 丘丛丏丘丝七世七丅.transform;
        if(val_31 == this.transform.parent)
        {
                return;
        }
        
        val_31 = 丘丛丏丘丝七世七丅.gameObject.name;
        if((val_31.Equals(value:  "DamageCollider")) == true)
        {
                return;
        }
        
        val_31 = 丘丛丏丘丝七世七丅.gameObject;
        if((val_31.CompareTag(tag:  "Player")) == true)
        {
                return;
        }
        
        if((丘丛丏丘丝七世七丅.CompareTag(tag:  "Ladder")) == true)
        {
                return;
        }
        
        if((丘丛丏丘丝七世七丅.CompareTag(tag:  "Gravitation")) == true)
        {
                return;
        }
        
        if(丘丛丏丘丝七世七丅.transform.parent != 0)
        {
                val_31 = 丘丛丏丘丝七世七丅.transform.parent;
            if(val_31 == this.transform.parent)
        {
                return;
        }
        
            val_31 = 丘丛丏丘丝七世七丅.transform.parent.gameObject;
            if((val_31.CompareTag(tag:  "Player")) == true)
        {
                return;
        }
        
        }
        
        val_31 = 丘丛丏丘丝七世七丅.GetComponent<Rilisoft.AreaBase>();
        if(val_31 != 0)
        {
                return;
        }
        
        val_31 = 丘丛丏丘丝七世七丅.GetComponent<SlowdownCollider>();
        if(val_31 != 0)
        {
                return;
        }
        
        val_31 = 丘丛丏丘丝七世七丅.GetComponent<Rilisoft.AreaVisitMonitor>();
        if(val_31 != 0)
        {
                return;
        }
        
        val_31 = this.不七丗万丞丌丒丁丌;
        if((val_31.Contains(item:  丘丛丏丘丝七世七丅)) != false)
        {
                return;
        }
        
        this.不七丗万丞丌丒丁丌.Add(item:  丘丛丏丘丝七世七丅);
    }
    private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        if((this.不七丗万丞丌丒丁丌.Contains(item:  丘丛丏丘丝七世七丅)) == false)
        {
                return;
        }
        
        bool val_2 = this.不七丗万丞丌丒丁丌.Remove(item:  丘丛丏丘丝七世七丅);
    }
    private void Update()
    {
        var val_8;
        System.Collections.Generic.List<UnityEngine.Collider> val_9;
        val_8 = 0;
        goto label_1;
        label_11:
        if((this.不七丗万丞丌丒丁丌.Item[0] == 0) || (this.不七丗万丞丌丒丁丌.Item[0].gameObject.activeInHierarchy == false))
        {
            goto label_9;
        }
        
        val_8 = 1;
        label_1:
        val_9 = this.不七丗万丞丌丒丁丌;
        if(val_8 < val_9.Count)
        {
            goto label_11;
        }
        
        goto label_12;
        label_9:
        val_9 = this.不七丗万丞丌丒丁丌;
        val_9.RemoveAt(index:  0);
        label_12:
        this.countHit = this.不七丗万丞丌丒丁丌.Count;
    }
    public DetectColliderHit()
    {
        this.不七丗万丞丌丒丁丌 = new System.Collections.Generic.List<UnityEngine.Collider>();
        this.丞丂丌丒不丂且丅世 = 1f;
    }

}
