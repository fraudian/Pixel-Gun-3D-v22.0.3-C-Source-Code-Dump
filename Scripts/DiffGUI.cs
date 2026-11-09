using UnityEngine;
public class DiffGUI : MonoBehaviour
{
    // Fields
    public UnityEngine.GUIStyle buttons;
    public UnityEngine.Texture fon;
    public UnityEngine.Texture[] instr;
    private int 丕丈丐丄丏上丅丁不;
    
    // Methods
    private void Start()
    {
        float val_5 = 16f;
        val_5 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_5;
        this.buttons.fontSize = UnityEngine.Mathf.RoundToInt(f:  val_5);
        this.丕丈丐丄丏上丅丁不 = UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.丟丐一丐七不业丂丆(), defaultValue:  1);
    }
    private void OnGUI()
    {
        var val_40;
        var val_41;
        var val_42;
        UnityEngine.GUI.depth = 99;
        float val_9 = (float)UnityEngine.Screen.width - (与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * (float)this.fon);
        float val_10 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * (float)this.fon;
        float val_11 = (float)UnityEngine.Screen.height - (与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * (float)this.fon);
        float val_12 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * (float)this.fon;
        UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, image:  this.fon);
        float val_16 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        val_16 = val_16 * (float)this.buttons.normal.background.width;
        float val_20 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        val_20 = val_20 * (float)this.buttons.normal.background.height;
        float val_22 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * 14f;
        float val_24 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
        float val_29 = (0.x + 0.x) - val_22;
        float val_30 = (val_24 + val_24) - val_22;
        val_30 = val_30 - (val_20 * 3f);
        val_30 = val_30 - (与丂丏丛丞丞丒丟丄.丐业丗丑专不万丂世 * 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专());
        val_29 = val_29 - val_16;
        val_29 = val_29 - (与丂丏丛丞丞丒丟丄.丐业丗丑专不万丂世 * val_24);
        string[] val_33 = new string[3];
        val_33[0] = "Easy";
        val_33[1] = "Medium";
        val_33[2] = "Hard";
        int val_34 = UnityEngine.GUI.SelectionGrid(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, selected:  this.丕丈丐丄丏上丅丁不, texts:  val_33, xCount:  1, style:  this.buttons);
        if(val_34 != this.丕丈丐丄丏上丅丁不)
        {
                ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            this.丕丈丐丄丏上丅丁不 = val_34;
            UnityEngine.PlayerPrefs.SetInt(key:  与丂丏丛丞丞丒丟丄.丟丐一丐七不业丂丆(), value:  this.丕丈丐丄丏上丅丁不);
            与丂丏丛丞丞丒丟丄.一丗丈丛丌专专世世 = this.丕丈丐丄丏上丅丁不;
        }
        
        val_40 = 0;
        if(this.丕丈丐丄丏上丅丁不 >= this.instr.Length)
        {
                val_40 = 0;
        }
        
        val_41 = 0;
        if(this.丕丈丐丄丏上丅丁不 >= this.instr.Length)
        {
                val_41 = 0;
        }
        
        if(this.丕丈丐丄丏上丅丁不 >= this.instr.Length)
        {
                val_42 = 0;
        }
        
        float val_43 = (float)this.instr[this.丕丈丐丄丏上丅丁不];
        val_43 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_43;
        float val_44 = (float)this.instr[this.丕丈丐丄丏上丅丁不];
        float val_45 = (float)this.instr[this.丕丈丐丄丏上丅丁不];
        val_43 = 0.x - val_43;
        val_44 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_44;
        val_45 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专() * val_45;
        UnityEngine.GUI.DrawTexture(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, image:  this.instr[this.丕丈丐丄丏上丅丁不]);
    }
    public DiffGUI()
    {
        this.instr = new UnityEngine.Texture[0];
        this.丕丈丐丄丏上丅丁不 = 1;
    }

}
