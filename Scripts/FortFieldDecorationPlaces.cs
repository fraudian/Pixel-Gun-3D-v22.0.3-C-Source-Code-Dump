using UnityEngine;
internal sealed class FortFieldDecorationPlaces : MonoBehaviour
{
    // Fields
    internal static FortFieldDecorationPlaces 丄丘七三上丕世丞业;
    private System.Collections.Generic.Dictionary<string, FortFieldItemPlace> 业业万丟丝丘丅东丂;
    
    // Properties
    internal System.Collections.Generic.Dictionary<string, FortFieldItemPlace> 专专上丒七丙上丅三 { get; }
    
    // Methods
    internal System.Collections.Generic.Dictionary<string, FortFieldItemPlace> 丝世东丙下丈丒专世()
    {
        System.Collections.Generic.Dictionary<System.String, FortFieldItemPlace> val_1 = this.业业万丟丝丘丅东丂;
        if(val_1 != null)
        {
                return val_1;
        }
        
        this.丝丑丁不下专丌且丅();
        val_1 = this.业业万丟丝丘丅东丂;
        return val_1;
    }
    private void Awake()
    {
        FortFieldDecorationPlaces.丄丘七三上丕世丞业 = this;
    }
    private void 丝丑丁不下专丌且丅()
    {
        var val_14;
        var val_15;
        var val_16;
        this.业业万丟丝丘丅东丂 = new System.Collections.Generic.Dictionary<System.String, FortFieldItemPlace>();
        System.Collections.IEnumerator val_3 = this.transform.GetEnumerator();
        label_21:
        var val_14 = 0;
        val_14 = val_14 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_7;
        }
        
        var val_15 = 0;
        val_15 = val_15 + 1;
        val_14 = val_3.Current;
        if(val_14 != null)
        {
                val_14 = 0;
        }
        
        this.业业万丟丝丘丅东丂.Add(key:  val_12.subcategory, value:  val_14.GetComponent<FortFieldItemPlace>());
        goto label_21;
        label_7:
        val_15 = 0;
        val_16 = 0;
        if(val_3 != null)
        {
                var val_16 = 0;
            val_16 = val_16 + 1;
            val_3.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public FortFieldDecorationPlaces()
    {
    
    }

}
