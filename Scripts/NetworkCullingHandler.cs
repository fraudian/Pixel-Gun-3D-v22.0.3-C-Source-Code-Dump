using UnityEngine;
public class NetworkCullingHandler : MonoBehaviour, 丈丆丁上丁业丒七丘
{
    // Fields
    private int 万一上丂下丙丅专丞;
    private CullArea 丐丝东丙丞丗丙丘丟;
    private System.Collections.Generic.List<byte> 东下三丕丛三丌丟七;
    private System.Collections.Generic.List<byte> 三丈丕丝世丝专下东;
    private PhotonView 丁丁丐业丛丆丒丈专;
    private UnityEngine.Vector3 下丏业丏三一且万丝;
    private UnityEngine.Vector3 丒不三丁丒丏丂丒丈;
    
    // Methods
    private void OnEnable()
    {
        if(this.丁丁丐业丛丆丒丈专 == 0)
        {
                PhotonView val_2 = this.GetComponent<PhotonView>();
            this.丁丁丐业丛丆丒丈专 = val_2;
            if(val_2.isMine == false)
        {
                return;
        }
        
        }
        
        if(this.丐丝东丙丞丗丙丘丟 == 0)
        {
                this.丐丝东丙丞丗丙丘丟 = UnityEngine.Object.FindObjectOfType<CullArea>();
        }
        
        1152921504848912384 = 1152921504691564544;
        this.东下三丕丛三丌丟七 = new System.Collections.Generic.List<System.Byte>(capacity:  0);
        this.三丈丕丝世丝专下东 = new System.Collections.Generic.List<System.Byte>(capacity:  0);
        UnityEngine.Vector3 val_9 = this.transform.position;
        this.下丏业丏三一且万丝 = val_9;
        mem[1152921535617096084] = val_9.y;
        mem[1152921535617096088] = val_9.z;
        this.丒不三丁丒丏丂丒丈 = val_9;
        mem[1152921535617096096] = val_9.y;
        mem[1152921535617096100] = val_9.z;
    }
    private void Start()
    {
        if(this.丁丁丐业丛丆丒丈专.isMine == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.一上下丆世丛丌丆丞() == false)
        {
                return;
        }
        
        if(this.丐丝东丙丞丗丙丘丟.NumberOfSubdivisions != 0)
        {
                this.丁丁丐业丛丆丒丈专.ObservedComponents.Add(item:  this);
            return;
        }
        
        this.丁丁丐业丛丆丒丈专.group = this.丐丝东丙丞丗丙丘丟.FIRST_GROUP_ID;
        丅丒丗丑丒丙丛不丆.丞丘万三上丛丅万不(不丝丄丒丌丐一一与:  this.丐丝东丙丞丗丙丘丟.FIRST_GROUP_ID, 丝三丄专丗丞丄丄丌:  true);
    }
    private void Update()
    {
        if(this.丁丁丐业丛丆丒丈专.isMine == false)
        {
                return;
        }
        
        this.下丏业丏三一且万丝 = this.丒不三丁丒丏丂丒丈;
        mem[1152921535617407128] = ???;
        UnityEngine.Vector3 val_3 = this.transform.position;
        this.丒不三丁丒丏丂丒丈 = val_3;
        mem[1152921535617407136] = val_3.y;
        mem[1152921535617407140] = val_3.z;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, rhs:  new UnityEngine.Vector3() {x = this.下丏业丏三一且万丝, y = V11.16B, z = V12.16B})) == false)
        {
                return;
        }
        
        if(this.东丈一丁丒丈一万世() == false)
        {
                return;
        }
        
        this.上下丕丈丑丞且丌丒();
    }
    private void OnGUI()
    {
        UnityEngine.GUIStyle val_16;
        PhotonView val_17;
        object val_18;
        object val_19;
        var val_20;
        val_16 = this;
        val_17 = this.丁丁丐业丛丆丒丈专;
        if(val_17.isMine == false)
        {
                return;
        }
        
        val_18 = "Inside cells:\n";
        val_19 = "Subscribed cells:\n";
        val_20 = 0;
        goto label_3;
        label_9:
        if(val_20 <= this.丐丝东丙丞丗丙丘丟.NumberOfSubdivisions)
        {
                val_18 = val_18 + this.三丈丕丝世丝专下东.Item[0] + " | "(" | ");
        }
        
        val_19 = val_19 + this.三丈丕丝世丝专下东.Item[0] + " | "(" | ");
        val_20 = 1;
        label_3:
        if(val_20 < this.三丈丕丝世丝专下东.Count)
        {
            goto label_9;
        }
        
        float val_16 = (float)UnityEngine.Screen.height;
        val_16 = val_16 + (-120f);
        UnityEngine.GUIStyle val_9 = new UnityEngine.GUIStyle();
        if(val_9 != null)
        {
                val_9.alignment = 0;
        }
        else
        {
                val_9.alignment = 0;
        }
        
        val_9.fontSize = 16;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "<color=white>PhotonView Group: "("<color=white>PhotonView Group: ") + this.丁丁丐业丛丆丒丈专.group + "</color>"("</color>"), style:  val_9);
        float val_17 = (float)UnityEngine.Screen.height;
        val_17 = val_17 + (-100f);
        UnityEngine.GUIStyle val_12 = null;
        val_16 = val_12;
        val_12 = new UnityEngine.GUIStyle();
        if(val_16 != null)
        {
                val_12.alignment = 0;
        }
        else
        {
                val_12.alignment = 0;
        }
        
        val_12.fontSize = 16;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "<color=white>"("<color=white>") + val_18 + "</color>"("</color>"), style:  val_12);
        float val_18 = (float)UnityEngine.Screen.height;
        val_18 = val_18 + (-60f);
        val_17 = "<color=white>"("<color=white>") + val_19 + "</color>"("</color>");
        UnityEngine.GUIStyle val_15 = new UnityEngine.GUIStyle();
        if(val_15 != null)
        {
                val_15.alignment = 0;
        }
        else
        {
                val_15.alignment = 0;
        }
        
        val_15.fontSize = 16;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_17, style:  val_15);
    }
    private bool 东丈一丁丒丈一万世()
    {
        var val_12;
        System.Collections.Generic.List<System.Byte> val_13;
        System.Collections.Generic.List<System.Byte> val_14;
        var val_15;
        val_12 = this;
        if(this.丐丝东丙丞丗丙丘丟.NumberOfSubdivisions == 0)
        {
            goto label_2;
        }
        
        this.东下三丕丛三丌丟七 = new System.Collections.Generic.List<System.Byte>(collection:  this.三丈丕丝世丝专下东);
        UnityEngine.Vector3 val_3 = this.transform.position;
        val_13 = this.丐丝东丙丞丗丙丘丟.GetActiveCells(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        this.三丈丕丝世丝专下东 = val_13;
        goto label_5;
        label_10:
        val_13.Add(item:  this.丐丝东丙丞丗丙丘丟.FIRST_GROUP_ID);
        val_13 = this.三丈丕丝世丝专下东;
        label_5:
        if(val_13.Count <= this.丐丝东丙丞丗丙丘丟.NumberOfSubdivisions)
        {
            goto label_10;
        }
        
        val_14 = this.东下三丕丛三丌丟七;
        if(this.三丈丕丝世丝专下东.Count != val_14.Count)
        {
            goto label_13;
        }
        
        val_12 = this.三丈丕丝世丝专下东.Item[this.丐丝东丙丞丗丙丘丟.NumberOfSubdivisions];
        val_14 = this.丐丝东丙丞丗丙丘丟.NumberOfSubdivisions;
        var val_11 = ((val_12 & 255) != this.东下三丕丛三丌丟七.Item[val_14]) ? 1 : 0;
        return (bool)val_15;
        label_2:
        val_15 = 0;
        return (bool)val_15;
        label_13:
        val_15 = 1;
        return (bool)val_15;
    }
    private void 上下丕丈丑丞且丌丒()
    {
        var val_4;
        System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>(capacity:  0);
        List.Enumerator<T> val_2 = this.东下三丕丛三丌丟七.GetEnumerator();
        label_6:
        if((946479104 & 1) == 0)
        {
            goto label_2;
        }
        
        byte val_5 = val_4.Current;
        if((this.三丈丕丝世丝专下东.Contains(item:  val_5)) == true)
        {
            goto label_6;
        }
        
        val_1.Add(item:  val_5);
        goto label_6;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        丅丒丗丑丒丙丛不丆.丞丘万三上丛丅万不(丝上丙丂世丗丏丄丑:  val_1.ToArray(), 丈业世东丘七丆且上:  this.三丈丕丝世丝专下东.ToArray());
    }
    public void OnPhotonSerializeView(下丌丙丘丈丌世万专 东业丄丅丅且世七丄, 业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐)
    {
        int val_9;
        goto label_1;
        label_6:
        this.三丈丕丝世丝专下东.Add(item:  this.丐丝东丙丞丗丙丘丟.FIRST_GROUP_ID);
        label_1:
        if(this.三丈丕丝世丝专下东.Count <= this.丐丝东丙丞丗丙丘丟.NumberOfSubdivisions)
        {
            goto label_6;
        }
        
        if(this.丐丝东丙丞丗丙丘丟.NumberOfSubdivisions != 1)
        {
            goto label_8;
        }
        
        int val_2 = this.万一上丂下丙丅专丞 + 1;
        this.万一上丂下丙丅专丞 = val_2;
        val_9 = val_2 - ((val_2 / this.丐丝东丙丞丗丙丘丟.SUBDIVISION_FIRST_LEVEL_ORDER.Length) * this.丐丝东丙丞丗丙丘丟.SUBDIVISION_FIRST_LEVEL_ORDER.Length);
        this.万一上丂下丙丅专丞 = val_9;
        if(this.丐丝东丙丞丗丙丘丟 == null)
        {
                val_9 = this.万一上丂下丙丅专丞;
        }
        
        if(this.丐丝东丙丞丗丙丘丟.SUBDIVISION_FIRST_LEVEL_ORDER != null)
        {
            goto label_28;
        }
        
        label_29:
        label_28:
        if(this.丁丁丐业丛丆丒丈专 == null)
        {
            goto label_15;
        }
        
        this.丁丁丐业丛丆丒丈专.group = this.三丈丕丝世丝专下东.Item[this.丐丝东丙丞丗丙丘丟.SUBDIVISION_FIRST_LEVEL_ORDER[(long)val_9]];
        return;
        label_8:
        if(this.丐丝东丙丞丗丙丘丟.NumberOfSubdivisions != 2)
        {
            goto label_17;
        }
        
        int val_5 = this.万一上丂下丙丅专丞 + 1;
        this.万一上丂下丙丅专丞 = val_5;
        val_5 = val_5 - ((val_5 / this.丐丝东丙丞丗丙丘丟.SUBDIVISION_SECOND_LEVEL_ORDER.Length) * this.丐丝东丙丞丗丙丘丟.SUBDIVISION_SECOND_LEVEL_ORDER.Length);
        this.万一上丂下丙丅专丞 = val_5;
        if(this.丐丝东丙丞丗丙丘丟.SUBDIVISION_SECOND_LEVEL_ORDER != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_17:
        if(this.丐丝东丙丞丗丙丘丟.NumberOfSubdivisions != 3)
        {
                return;
        }
        
        int val_7 = this.万一上丂下丙丅专丞 + 1;
        this.万一上丂下丙丅专丞 = val_7;
        val_7 = val_7 - ((val_7 / this.丐丝东丙丞丗丙丘丟.SUBDIVISION_THIRD_LEVEL_ORDER.Length) * this.丐丝东丙丞丗丙丘丟.SUBDIVISION_THIRD_LEVEL_ORDER.Length);
        this.万一上丂下丙丅专丞 = val_7;
        if(this.丐丝东丙丞丗丙丘丟.SUBDIVISION_THIRD_LEVEL_ORDER != null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_15:
    }
    public NetworkCullingHandler()
    {
    
    }

}
