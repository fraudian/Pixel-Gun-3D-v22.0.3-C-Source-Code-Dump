using UnityEngine;
public class CryptoPlayerPrefsManager : MonoBehaviour
{
    // Fields
    public int salt;
    public bool useRijndael;
    public bool useXor;
    
    // Methods
    private void Awake()
    {
        上七丈七三七七且丛.七丐丟业丄丞丛丞丘(丏丛与丅丛丌万专丌:  this.salt);
        上七丈七三七七且丛.丙丞七万世丅丅丕丐(丘丈不丐丒丘一丐一:  this.useRijndael);
        上七丈七三七七且丛.东丈万万七丅丈一丞(丘丈不丐丒丘一丐一:  this.useXor);
        UnityEngine.Object.Destroy(obj:  this);
    }
    public CryptoPlayerPrefsManager()
    {
        this.salt = 2147483647;
        this.useRijndael = true;
        this.useXor = true;
    }

}
