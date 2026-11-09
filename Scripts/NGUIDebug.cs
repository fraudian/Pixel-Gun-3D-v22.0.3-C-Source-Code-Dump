using UnityEngine;
public class NGUIDebug : MonoBehaviour
{
    // Fields
    private static bool 一三世丞不与丆丐丁;
    private static System.Collections.Generic.List<string> 丌丌世且下三丈丟万;
    private static NGUIDebug 丂丙万丘三丙丒且丛;
    
    // Properties
    public static bool 丟丆丏丕丑东丐丞丁 { get; set; }
    
    // Methods
    public static bool get_debugRaycast()
    {
        null = null;
        return (bool)NGUIDebug.一三世丞不与丆丐丁;
    }
    public static void set_debugRaycast(bool 丙业与丙丗丝不丈东)
    {
        null = null;
        NGUIDebug.一三世丞不与丆丐丁 = 丙业与丙丗丝不丈东;
        if(丙业与丙丗丝不丈东 == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying == false)
        {
                return;
        }
        
        NGUIDebug.CreateInstance();
    }
    public static void CreateInstance()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(NGUIDebug.丂丙万丘三丙丒且丛 != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_2 = new UnityEngine.GameObject(name:  "_NGUI Debug");
        val_5 = null;
        val_5 = null;
        NGUIDebug.丂丙万丘三丙丒且丛 = val_2.AddComponent<NGUIDebug>();
        UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
    }
    private static void 丟丄丂丒丝丕丕业丛(string 丕丗丘丑丛与丑业丒)
    {
        var val_3;
        var val_4;
        var val_5;
        if(UnityEngine.Application.isPlaying != false)
        {
                val_3 = null;
            val_3 = null;
            if(NGUIDebug.丌丌世且下三丈丟万.Count >= 21)
        {
                val_4 = null;
            val_4 = null;
            NGUIDebug.丌丌世且下三丈丟万.RemoveAt(index:  0);
        }
        
            val_5 = null;
            val_5 = null;
            NGUIDebug.丌丌世且下三丈丟万.Add(item:  丕丗丘丑丛与丑业丒);
            NGUIDebug.CreateInstance();
            return;
        }
        
        UnityEngine.Debug.Log(message:  丕丗丘丑丛与丑业丒);
    }
    public static void Log(object[] 三丐上丄丝下丙丟业)
    {
        var val_3;
        string val_4;
        val_3 = 0;
        val_4 = "";
        goto label_1;
        label_7:
        object val_3 = 三丐上丄丝下丙丟业[0];
        if(val_3 != 0)
        {
                string val_1 = val_4 + ", " + val_3;
        }
        
        val_4 = val_4 + val_3;
        val_3 = 1;
        label_1:
        if(val_3 < 三丐上丄丝下丙丟业.Length)
        {
            goto label_7;
        }
        
        NGUIDebug.丟丄丂丒丝丕丕业丛(丕丗丘丑丛与丑业丒:  val_4);
    }
    public static void Clear()
    {
        null = null;
        NGUIDebug.丌丌世且下三丈丟万.Clear();
    }
    public static void DrawBounds(UnityEngine.Bounds 丌丗丏丏丛东专丁且)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B}, b:  new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B});
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z});
        UnityEngine.Color val_3 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, end:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color() {r = val_3.r, g = val_3.b});
        UnityEngine.Color val_4 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, end:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color() {r = val_4.r, g = val_4.b});
        UnityEngine.Color val_5 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, end:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color() {r = val_5.r, g = val_5.b});
        UnityEngine.Color val_6 = UnityEngine.Color.red;
        UnityEngine.Debug.DrawLine(start:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, end:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, color:  new UnityEngine.Color() {r = val_6.r, g = val_6.b, b = 0f, a = 0f});
    }
    private void OnGUI()
    {
        float val_48;
        float val_49;
        float val_50;
        float val_51;
        var val_52;
        System.Collections.Generic.List<System.String> val_53;
        float val_54;
        var val_55;
        string val_56;
        float val_57;
        float val_58;
        var val_59;
        val_48 = 1000f;
        val_49 = 5f;
        val_50 = 22f;
        val_51 = val_49;
        val_52 = null;
        val_52 = null;
        if(NGUIDebug.一三世丞不与丆丐丁 != false)
        {
                string val_2 = "Scheme: "("Scheme: ") + UICamera.currentScheme;
            UnityEngine.Color val_3 = UnityEngine.Color.black;
            val_53 = 1152921504882724864;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
            float val_48 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_48, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_2);
            val_54 = -1f;
            val_48 = val_48 + val_54;
            float val_4 = 0.x;
            val_4 = val_4 + val_54;
            0.x = val_4;
            UnityEngine.Color val_5 = UnityEngine.Color.white;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
            float val_49 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_49, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_2);
            val_49 = val_49 + 18f;
            float val_6 = 0.x;
            val_6 = val_6 + 1f;
            0.x = val_6;
            val_55 = "\"";
            string val_10 = "Hover: "("Hover: ") + 不丌丂丁丄一与丆丙.上丞丁业丛丑与丅丞(万且万且丑丗且丌丆:  UICamera.hoveredObject).Replace(oldValue:  "\"", newValue:  "")(不丌丂丁丄一与丆丙.上丞丁业丛丑与丅丞(万且万且丑丗且丌丆:  UICamera.hoveredObject).Replace(oldValue:  "\"", newValue:  ""));
            UnityEngine.Color val_11 = UnityEngine.Color.black;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
            float val_50 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_50, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_10);
            val_50 = val_50 + val_54;
            float val_12 = 0.x;
            val_12 = val_12 + val_54;
            0.x = val_12;
            UnityEngine.Color val_13 = UnityEngine.Color.white;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a};
            float val_51 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_51, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_10);
            val_51 = val_51 + 18f;
            float val_14 = 0.x;
            val_14 = val_14 + 1f;
            0.x = val_14;
            string val_18 = "Selection: "("Selection: ") + 不丌丂丁丄一与丆丙.上丞丁业丛丑与丅丞(万且万且丑丗且丌丆:  UICamera.selectedObject).Replace(oldValue:  "\"", newValue:  "")(不丌丂丁丄一与丆丙.上丞丁业丛丑与丅丞(万且万且丑丗且丌丆:  UICamera.selectedObject).Replace(oldValue:  "\"", newValue:  ""));
            UnityEngine.Color val_19 = UnityEngine.Color.black;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_19.r, g = val_19.g, b = val_19.b, a = val_19.a};
            float val_52 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_52, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_18);
            val_52 = val_52 + val_54;
            float val_20 = 0.x;
            val_20 = val_20 + val_54;
            0.x = val_20;
            UnityEngine.Color val_21 = UnityEngine.Color.white;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_21.r, g = val_21.g, b = val_21.b, a = val_21.a};
            float val_53 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_53, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_18);
            val_53 = val_53 + 18f;
            float val_22 = 0.x;
            val_22 = val_22 + 1f;
            0.x = val_22;
            string val_26 = "Controller: "("Controller: ") + 不丌丂丁丄一与丆丙.上丞丁业丛丑与丅丞(万且万且丑丗且丌丆:  UICamera.controllerNavigationObject).Replace(oldValue:  "\"", newValue:  "")(不丌丂丁丄一与丆丙.上丞丁业丛丑与丅丞(万且万且丑丗且丌丆:  UICamera.controllerNavigationObject).Replace(oldValue:  "\"", newValue:  ""));
            UnityEngine.Color val_27 = UnityEngine.Color.black;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_27.r, g = val_27.g, b = val_27.b, a = val_27.a};
            float val_54 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_54, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_26);
            val_54 = val_54 + val_54;
            float val_28 = 0.x;
            val_28 = val_28 + val_54;
            0.x = val_28;
            UnityEngine.Color val_29 = UnityEngine.Color.white;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_29.r, g = val_29.g, b = val_29.b, a = val_29.a};
            float val_55 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_55, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_26);
            val_55 = val_55 + 18f;
            float val_30 = 0.x;
            val_30 = val_30 + 1f;
            0.x = val_30;
            val_56 = "Active events: "("Active events: ") + UICamera.CountInputSources();
            if(UICamera.disableController != false)
        {
                val_56 = val_56 + ", disabled controller";
        }
        
            if(UICamera.inputHasFocus != false)
        {
                val_56 = val_56 + ", input focus";
        }
        
            UnityEngine.Color val_37 = UnityEngine.Color.black;
            val_57 = val_37.r;
            val_58 = val_37.b;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_57, g = val_37.g, b = val_58, a = val_37.a};
            float val_56 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_56, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_56);
            val_56 = val_56 + val_54;
            float val_38 = 0.x;
            val_38 = val_38 + val_54;
            0.x = val_38;
            UnityEngine.Color val_39 = UnityEngine.Color.white;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_39.r, g = val_39.g, b = val_39.b, a = val_39.a};
            float val_57 = 0f;
            val_51 = 0f;
            val_48 = 0f;
            val_50 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_57, m_YMin = val_51, m_Width = val_48, m_Height = val_50}, text:  val_56);
            val_57 = val_57 + 18f;
            val_49 = 0.x + 1f;
            0.x = val_49;
            val_52 = null;
        }
        
        val_52 = null;
        int val_41 = NGUIDebug.丌丌世且下三丈丟万.Count;
        if(val_41 < 1)
        {
                return;
        }
        
        val_55 = 1152921504882724864;
        var val_60 = 0;
        val_54 = -1f;
        do
        {
            UnityEngine.Color val_42 = UnityEngine.Color.black;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_42.r, g = val_42.g, b = val_42.b, a = val_42.a};
            val_59 = null;
            val_59 = null;
            float val_58 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  NGUIDebug.丌丌世且下三丈丟万.Item[0]);
            val_58 = val_58 + val_54;
            float val_44 = 0.x;
            val_44 = val_44 + val_54;
            0.x = val_44;
            UnityEngine.Color val_45 = UnityEngine.Color.white;
            UnityEngine.GUI.color = new UnityEngine.Color() {r = val_45.r, g = val_45.g, b = val_45.b, a = val_45.a};
            val_58 = 0f;
            val_57 = 0f;
            val_53 = NGUIDebug.丌丌世且下三丈丟万;
            float val_59 = 0f;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = val_58, m_Width = val_57, m_Height = 0f}, text:  val_53.Item[0]);
            val_59 = val_59 + 18f;
            float val_47 = 0.x;
            val_47 = val_47 + 1f;
            0.x = val_47;
            val_60 = val_60 + 1;
        }
        while(val_41 != val_60);
    
    }
    public NGUIDebug()
    {
    
    }
    private static NGUIDebug()
    {
        NGUIDebug.一三世丞不与丆丐丁 = false;
        NGUIDebug.丌丌世且下三丈丟万 = new System.Collections.Generic.List<System.String>();
        NGUIDebug.丂丙万丘三丙丒且丛 = 0;
    }

}
