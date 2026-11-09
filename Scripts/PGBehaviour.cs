using UnityEngine;
public class PGBehaviour : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform 丆丄世丒东丗丈丄丒;
    private UnityEngine.GameObject 业丟丏上丛与不一丝;
    private UnityEngine.Animation 业与丘丞丂专丘丗世;
    private UnityEngine.Rigidbody 丕丗丏丏丒丈丐丝丈;
    private UnityEngine.BoxCollider 万丄丏丟丏丞丗丟丐;
    
    // Properties
    internal UnityEngine.Transform 七丈丁万丛万业丈与 { get; }
    internal UnityEngine.Animation 丁业万丅与丗丑一丒 { get; }
    internal UnityEngine.Rigidbody 丆与专丏丗丟且且丁 { get; }
    internal UnityEngine.GameObject 丙丑丞丛丄丕丞丝丐 { get; }
    internal UnityEngine.BoxCollider 一业丛万丙东丞七专 { get; }
    
    // Methods
    internal UnityEngine.Transform 丌丟丄业且三丛丕丄()
    {
        UnityEngine.Transform val_3;
        if(this.丆丄世丒东丗丈丄丒 == 0)
        {
                this.丆丄世丒东丗丈丄丒 = this.transform;
            return val_3;
        }
        
        val_3 = this.丆丄世丒东丗丈丄丒;
        return val_3;
    }
    internal UnityEngine.Animation 丁业世丕上东丁丄丁()
    {
        UnityEngine.Animation val_3;
        if(this.业与丘丞丂专丘丗世 == 0)
        {
                this.业与丘丞丂专丘丗世 = this.与丘不世丕上与专东<UnityEngine.Animation>();
            return val_3;
        }
        
        val_3 = this.业与丘丞丂专丘丗世;
        return val_3;
    }
    internal UnityEngine.Rigidbody 七上不且且丑丂丟东()
    {
        UnityEngine.Rigidbody val_3;
        if(this.丕丗丏丏丒丈丐丝丈 == 0)
        {
                this.丕丗丏丏丒丈丐丝丈 = this.与丘不世丕上与专东<UnityEngine.Rigidbody>();
            return val_3;
        }
        
        val_3 = this.丕丗丏丏丒丈丐丝丈;
        return val_3;
    }
    internal UnityEngine.GameObject 丅与丌专丟一丝业三()
    {
        UnityEngine.GameObject val_3;
        if(this.业丟丏上丛与不一丝 == 0)
        {
                this.业丟丏上丛与不一丝 = this.gameObject;
            return val_3;
        }
        
        val_3 = this.业丟丏上丛与不一丝;
        return val_3;
    }
    internal UnityEngine.BoxCollider 丅丆万丙丕丕丞丁丁()
    {
        UnityEngine.BoxCollider val_3;
        if(this.万丄丏丟丏丞丗丟丐 == 0)
        {
                this.万丄丏丟丏丞丗丟丐 = this.GetComponent<UnityEngine.BoxCollider>();
            return val_3;
        }
        
        val_3 = this.万丄丏丟丏丞丗丟丐;
        return val_3;
    }
    private T 与丘不世丕上与专东<T>()
    {
        if(this == null)
        {
            
        }
    
    }
    public PGBehaviour()
    {
    
    }

}
