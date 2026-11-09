using UnityEngine;
public class ChooseBoxNGUIController : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<UILabel> unlockPrice;
    public MultipleToggleButton difficultyToggle;
    public UnityEngine.GameObject allInterfaceHolder;
    public UIButton backButton;
    public UIButton startButton;
    public UIButton unlockButton;
    public UnityEngine.GameObject grid;
    public UnityEngine.Transform ScrollTransform;
    public UnityEngine.GameObject SelectMapPanel;
    public int selectIndexMap;
    public int countMap;
    public float widthCell;
    
    // Methods
    private void Start()
    {
        int val_4 = UnityEngine.Screen.width * 760;
        val_4 = val_4 / UnityEngine.Screen.height;
        this.ScrollTransform.GetComponent<UIPanel>().baseClipRegion = new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f};
        this.countMap = this.grid.transform.childCount;
    }
    private void Update()
    {
        int val_11;
        int val_12;
        int val_13;
        if(this.SelectMapPanel.activeInHierarchy == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_2 = this.ScrollTransform.localPosition;
        UnityEngine.Vector3 val_3 = this.ScrollTransform.localPosition;
        if(val_2.x > 0f)
        {
                UnityEngine.Vector3 val_4 = this.ScrollTransform.localPosition;
            val_4.x = val_4.x / this.widthCell;
            val_4.x = val_4.x / (float)this.countMap;
            float val_12 = this.widthCell;
            float val_10 = (float)UnityEngine.Mathf.FloorToInt(f:  val_4.x);
            val_10 = val_12 * val_10;
            float val_11 = (float)this.countMap;
            val_11 = val_10 * val_11;
            val_11 = val_3.x - val_11;
            val_12 = val_11 / val_12;
            val_11 = this.countMap;
            val_12 = this.selectIndexMap;
            val_13 = val_11 - (UnityEngine.Mathf.RoundToInt(f:  val_12));
        }
        else
        {
                UnityEngine.Vector3 val_7 = this.ScrollTransform.localPosition;
            val_7.x = val_7.x / this.widthCell;
            val_7.x = val_7.x / (float)this.countMap;
            float val_15 = this.widthCell;
            float val_13 = (float)UnityEngine.Mathf.CeilToInt(f:  val_7.x);
            val_13 = val_15 * val_13;
            float val_14 = (float)this.countMap;
            val_14 = val_13 * val_14;
            val_14 = val_3.x - val_14;
            val_15 = val_14 / val_15;
            val_11 = this.countMap;
            val_13 = -(UnityEngine.Mathf.RoundToInt(f:  val_15));
            val_12 = this.selectIndexMap;
        }
        
        this.selectIndexMap = val_13;
        if(val_13 != val_11)
        {
                return;
        }
        
        mem2[0] = 0;
    }
    public ChooseBoxNGUIController()
    {
        this.widthCell = 824f;
    }

}
