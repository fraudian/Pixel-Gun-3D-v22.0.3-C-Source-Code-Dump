using UnityEngine;
internal class SlowdownZoneTriggerTransport : AreaBase
{
    // Fields
    public float slowCoef;
    public string[] ignoreTransportIds;
    
    // Methods
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        if((this.万丗世不与上丛不丘(丘丛丏丘丝七世七丅:  丘丛丏丘丝七世七丅, 丟万丑业上丈七且丈: out  0)) == false)
        {
                return;
        }
        
        if((System.Linq.Enumerable.Contains<System.String>(source:  this.ignoreTransportIds, value:  123438416)) == true)
        {
                return;
        }
        
        this.CheckIn(专丂丕丗丗东世丞下:  this.gameObject);
    }
    private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        if((this.万丗世不与上丛不丘(丘丛丏丘丝七世七丅:  丘丛丏丘丝七世七丅, 丟万丑业上丈七且丈: out  0)) == false)
        {
                return;
        }
        
        this.CheckOut(丈丗与丞一上且上上:  this.gameObject);
    }
    private bool 万丗世不与上丛不丘(UnityEngine.Collider 丘丛丏丘丝七世七丅, out TransportControllerBase 丟万丑业上丈七且丈)
    {
        var val_8;
        TransportControllerBase val_9;
        var val_10;
        val_8 = 1152921539176043216;
        val_9 = 丘丛丏丘丝七世七丅.GetComponent<TransportControllerBase>();
        if(val_9 == null)
        {
                UnityEngine.Transform val_3 = 丘丛丏丘丝七世七丅.transform.parent;
            if(val_3 != null)
        {
                val_9 = val_3.GetComponent<TransportControllerBase>();
        }
        else
        {
                val_9 = 0;
        }
        
        }
        
        丟万丑业上丈七且丈 = val_9;
        if((UnityEngine.Object.op_Implicit(exists:  val_9)) != false)
        {
                val_8 = 丟万丑业上丈七且丈.photonView;
            if(val_8.isMine != false)
        {
                val_10 = 1;
            return (bool)val_10;
        }
        
        }
        
        val_10 = 0;
        return (bool)val_10;
    }
    public SlowdownZoneTriggerTransport()
    {
        this.slowCoef = 0.8f;
        this.ignoreTransportIds = System.Array.Empty<System.String>();
    }

}
