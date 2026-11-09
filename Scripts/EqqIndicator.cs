using UnityEngine;
public class EqqIndicator : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject 丞丈且下且丙丞与丈;
    
    // Methods
    private void Start()
    {
        this.丞丈且下且丙丞与丈 = this.transform.GetChild(index:  0).gameObject;
        this.丝丞丂专丝丟不丐丟();
    }
    private void Update()
    {
        this.丝丞丂专丝丟不丐丟();
    }
    private void 丝丞丂专丝丟不丐丟()
    {
        if(this.丞丈且下且丙丞与丈 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.丞丈且下且丙丞与丈, 丏业丟一东丂东丘丛:  ((Rilisoft.Singleton<Rilisoft.EggsManager>.Instance.一且丂不丈丝丗一丆()) > 0) ? 1 : 0);
    }
    public EqqIndicator()
    {
    
    }

}
