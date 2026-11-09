using UnityEngine;
internal sealed class PathCreatorWindow : PGBehaviour
{
    // Fields
    internal FirstPersonControlSharp 丂丟世丄丅丌丞不丞;
    private bool 丝丛丆丄万七万丙下;
    public static PathCreatorWindow instance;
    internal UILabel statRecord;
    internal UIButton startRecord;
    internal UIButton stopRecord;
    internal UIButton saveRecord;
    internal UIButton addPointRecord;
    internal UIButton startPathRecord;
    internal UIButton endPathRecord;
    private UnityEngine.GameObject closeButton;
    private UnityEngine.Collider 丌与丘丄丗且与丞专;
    private UIButton 丗丛丘丛与丟丁丘世;
    
    // Methods
    private void Awake()
    {
        this.丌与丘丄丗且与丞专 = this.closeButton.GetComponent<UnityEngine.BoxCollider>();
        this.丗丛丘丛与丟丁丘世 = this.closeButton.GetComponent<UIButton>();
    }
    private void OnEnable()
    {
    
    }
    private void OnDisable()
    {
    
    }
    public void Close()
    {
    
    }
    public void StartRecord()
    {
    
    }
    public void StopRecord()
    {
    
    }
    public void SaveRecord(bool 丗且丏丄丌丙万丆丞 = True)
    {
    
    }
    public void AddNewWayPoint()
    {
    
    }
    public void StartBuildPath()
    {
    
    }
    public void StopBuildPath()
    {
    
    }
    public void StartBots()
    {
    
    }
    public void StartFightBots()
    {
    
    }
    public void DisableBots()
    {
    
    }
    private void 丛丏丌丗三上丛专世()
    {
    
    }
    private void 丘上丐世丆丑且丞丒()
    {
    
    }
    private void Update()
    {
    
    }
    public PathCreatorWindow()
    {
    
    }
    private static PathCreatorWindow()
    {
    
    }

}
