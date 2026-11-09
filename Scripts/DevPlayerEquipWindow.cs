using UnityEngine;
internal sealed class DevPlayerEquipWindow : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<DevEquipButton> _equipButtons;
    
    // Methods
    private void OnEnable()
    {
        this.上一丏世丄丏专丐丐();
        this.丛且丐下世与丘丆丗();
    }
    private void OnDisable()
    {
        this.万与七三丄丁丏世丘();
    }
    private void 丈且东丑丂且万丒丅()
    {
        this.上一丏世丄丏专丐丐();
    }
    private void 上一丏世丄丏专丐丐()
    {
        int val_13;
        System.Collections.Generic.List<System.String> val_2 = 丂丏丈不丗丆下丈且.丑七不且上丗丁一世().业三三丟业专东丐丘();
        val_13 = System.Math.Min(val1:  this._equipButtons.Count, val2:  val_2.Count);
        if(val_13 < 1)
        {
            goto label_14;
        }
        
        var val_13 = 0;
        do
        {
            this._equipButtons.Item[0].gameObject.SetActive(value:  true);
            this._equipButtons.Item[0].丈且东丑丂且万丒丅(丏丐世丟丈上丂丕不:  val_2.Item[0]);
            val_13 = val_13 + 1;
        }
        while(val_13 != val_13);
        
        goto label_14;
        label_19:
        this._equipButtons.Item[val_13].gameObject.SetActive(value:  false);
        val_13 = val_13 + 1;
        label_14:
        if(val_13 < this._equipButtons.Count)
        {
            goto label_19;
        }
    
    }
    private void 丑丐丟丛丂丏丏丘七(string 丙上业万丑业丕万丐)
    {
        丂丏丈不丗丆下丈且.丑七不且上丗丁一世().丛丙三丕且东丛丑业(丄万世不丟丒丏东丁:  丙上业万丑业丕万丐);
    }
    private void 丛且丐下世与丘丆丗()
    {
        object val_4 = this;
        List.Enumerator<T> val_1 = this._equipButtons.GetEnumerator();
        label_4:
        if((1040146696 & 1) == 0)
        {
            goto label_2;
        }
        
        System.Action<System.String> val_3 = new System.Action<System.String>(object:  this, method:  System.Void DevPlayerEquipWindow::丑丐丟丛丂丏丏丘七(string 丙上业万丑业丕万丐));
        0.丐丏七丌丕丗业且上().且丁丟业三丄丆七下(丙业与丙丗丝不丈东:  null);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 万与七三丄丁丏世丘()
    {
        object val_4 = this;
        List.Enumerator<T> val_1 = this._equipButtons.GetEnumerator();
        label_4:
        if((1040283272 & 1) == 0)
        {
            goto label_2;
        }
        
        System.Action<System.String> val_3 = new System.Action<System.String>(object:  this, method:  System.Void DevPlayerEquipWindow::丑丐丟丛丂丏丏丘七(string 丙上业万丑业丕万丐));
        0.丐丏七丌丕丗业且上().丏丝丛丗不专丛专上(丙业与丙丗丝不丈东:  null);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public DevPlayerEquipWindow()
    {
        this._equipButtons = new System.Collections.Generic.List<DevEquipButton>();
    }

}
