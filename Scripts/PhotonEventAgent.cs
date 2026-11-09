using UnityEngine;
public sealed class PhotonEventAgent : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<PhotonEventAgent.EventObject> eventObjects;
    public System.Collections.Generic.Dictionary<byte, PhotonEventBehaviour> eventBehaviourByID;
    public byte eventCode;
    private object[] 业丑不上三三三与万;
    private int[] 丄与丙专专丗世丝且;
    
    // Methods
    internal void Awake()
    {
        丅丒丗丑丒丙丛不丆.丈丘丝丁上丄且七丛(丙业与丙丗丝不丈东:  new 丅丒丗丑丒丙丛不丆.且专丆下丆丐丏东丂(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PhotonEventAgent::丕东专丗专丛万专丘(byte 丏不丅一丈丅万丗一, object 三丏丑不业丏不丂丈, int 万丕丅下丒丗丐丐丘)));
        this.万业东东丂业丈上专();
    }
    internal void OnDestroy()
    {
        丅丒丗丑丒丙丛不丆.一丈且丈丞丑丟世与(丙业与丙丗丝不丈东:  new 丅丒丗丑丒丙丛不丆.且专丆下丆丐丏东丂(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void PhotonEventAgent::丕东专丗专丛万专丘(byte 丏不丅一丈丅万丗一, object 三丏丑不业丏不丂丈, int 万丕丅下丒丗丐丐丘)));
    }
    private void 万业东东丂业丈上专()
    {
        goto label_1;
        label_13:
        EventObject val_1 = this.eventObjects.Item[0];
        EventObject val_2 = this.eventObjects.Item[0];
        val_1.eventObject.七丘东丞世丆丕丙丅 = this;
        val_1.eventObject.与东世不丟万丒丕专 = val_2.networkID;
        EventObject val_3 = this.eventObjects.Item[0];
        EventObject val_4 = this.eventObjects.Item[0];
        this.eventBehaviourByID.Add(key:  val_3.networkID, value:  val_4.eventObject);
        0 = 1;
        label_1:
        if(0 < this.eventObjects.Count)
        {
            goto label_13;
        }
    
    }
    internal void 七丂东世不丐丗丕丑(byte 与东世不丟万丒丕专, byte 丑丐丗三丒世丏东丅, ReceiverGroup 丈丅丘丐三丂丗且丌, bool 丕业丑万一丞丞东三, bool 世丐丒下一一三七上, object[] 丗丟上上丒丐丗丞丙)
    {
        if(this.业丑不上三三三与万 == null)
        {
            goto label_1;
        }
        
        if(与东世不丟万丒丕专 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(与东世不丟万丒丕专 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        this.业丑不上三三三与万[0] = 与东世不丟万丒丕专;
        if(this.业丑不上三三三与万 == null)
        {
            goto label_7;
        }
        
        if(丑丐丗三丒世丏东丅 != 0)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(丑丐丗三丒世丏东丅 == 0)
        {
            goto label_11;
        }
        
        label_8:
        label_11:
        this.业丑不上三三三与万[1] = 丑丐丗三丒世丏东丅;
        if(this.业丑不上三三三与万 == null)
        {
            goto label_13;
        }
        
        if(丗丟上上丒丐丗丞丙 != null)
        {
            goto label_14;
        }
        
        goto label_17;
        label_13:
        if(丗丟上上丒丐丗丞丙 == null)
        {
            goto label_17;
        }
        
        label_14:
        label_17:
        this.业丑不上三三三与万[2] = 丗丟上上丒丐丗丞丙;
        .丟丄丆东业且万上三 = 丈丅丘丐三丂丗且丌;
        if(丕业丑万一丞丞东三 != false)
        {
                .三三丞丗专丄不不世 = 4;
        }
        
        bool val_3 = 丅丒丗丑丒丙丛不丆.一丗丁东丑下丛丟丟(丏不丅一丈丅万丗一:  this.eventCode, 不丙丒丌专丄丂丑专:  this.业丑不上三三三与万, 不三七丈丕丘丐丝与:  世丐丒下一一三七上, 丆与丛丅丂三万一丑:  new 丗业三丆丅丐丗不丏());
    }
    internal void 七丂东世不丐丗丕丑(byte 与东世不丟万丒丕专, byte 丑丐丗三丒世丏东丅, 与丅丕丈丘东丝世丟 丞下万上三丘上与专, bool 世丐丒下一一三七上, object[] 丗丟上上丒丐丗丞丙)
    {
        if(this.业丑不上三三三与万 == null)
        {
            goto label_1;
        }
        
        if(与东世不丟万丒丕专 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(与东世不丟万丒丕专 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        this.业丑不上三三三与万[0] = 与东世不丟万丒丕专;
        if(this.业丑不上三三三与万 == null)
        {
            goto label_7;
        }
        
        if(丑丐丗三丒世丏东丅 != 0)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(丑丐丗三丒世丏东丅 == 0)
        {
            goto label_11;
        }
        
        label_8:
        label_11:
        this.业丑不上三三三与万[1] = 丑丐丗三丒世丏东丅;
        if(this.业丑不上三三三与万 == null)
        {
            goto label_13;
        }
        
        if(丗丟上上丒丐丗丞丙 != null)
        {
            goto label_14;
        }
        
        goto label_17;
        label_13:
        if(丗丟上上丒丐丗丞丙 == null)
        {
            goto label_17;
        }
        
        label_14:
        label_17:
        this.业丑不上三三三与万[2] = 丗丟上上丒丐丗丞丙;
        this.丄与丙专专丗世丝且[0] = 丞下万上三丘上与专.业丐丐三丕一丗丛丁();
        .丅丆丁专丛世丗丑一 = this.丄与丙专专丗世丝且;
        bool val_4 = 丅丒丗丑丒丙丛不丆.一丗丁东丑下丛丟丟(丏不丅一丈丅万丗一:  this.eventCode, 不丙丒丌专丄丂丑专:  this.业丑不上三三三与万, 不三七丈丕丘丐丝与:  世丐丒下一一三七上, 丆与丛丅丂三万一丑:  new 丗业三丆丅丐丗不丏());
    }
    private void 丕东专丗专丛万专丘(byte 丏不丅一丈丅万丗一, object 三丏丑不业丏不丂丈, int 万丕丅下丒丗丐丐丘)
    {
        var val_6;
        var val_7;
        val_6 = 三丏丑不业丏不丂丈;
        val_7 = 丏不丅一丈丅万丗一;
        if(this.eventCode != val_7)
        {
                return;
        }
        
        val_6 = val_6;
        if(val_6 == null)
        {
                return;
        }
        
        if(this.eventCode < 3)
        {
                return;
        }
        
        if((this.eventBehaviourByID.ContainsKey(key:  0)) == false)
        {
                return;
        }
        
        if(this.eventBehaviourByID.Item[0] == null)
        {
                return;
        }
        
        var val_6 = 0;
        val_6 = val_6 + 1;
        bool val_5 = this.eventBehaviourByID.Item[0].OnEventFired(丞世不丒下上上丝丑:  0, 专丒丌丆下丐丞丟丞:  1152921537674434160);
    }
    public PhotonEventAgent()
    {
        this.eventObjects = new System.Collections.Generic.List<EventObject>();
        this.eventBehaviourByID = new System.Collections.Generic.Dictionary<System.Byte, PhotonEventBehaviour>();
        this.业丑不上三三三与万 = new object[3];
        this.丄与丙专专丗世丝且 = new int[1];
    }

}
