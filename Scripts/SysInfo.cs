using UnityEngine;
public class SysInfo : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Text outputText;
    
    // Methods
    private void Start()
    {
        object[] val_1 = new object[4];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if("" != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        label_2:
        label_5:
        val_1[0] = "";
        val_1[1] = "<color=magenta>copyTextureSupport: </color><color=red>";
        val_1[2] = UnityEngine.SystemInfo.copyTextureSupport;
        val_1[3] = "\n</color>";
        string val_11 = +val_1(+val_1) + "<color=magenta>deviceModel: </color><color=red>"("<color=magenta>deviceModel: </color><color=red>") + UnityEngine.SystemInfo.deviceModel + "\n</color>"("\n</color>")(+val_1(+val_1) + "<color=magenta>deviceModel: </color><color=red>"("<color=magenta>deviceModel: </color><color=red>") + UnityEngine.SystemInfo.deviceModel + "\n</color>"("\n</color>")) + "<color=magenta>graphicsDeviceName: </color><color=red>"("<color=magenta>graphicsDeviceName: </color><color=red>") + UnityEngine.SystemInfo.graphicsDeviceName + "\n</color>"("\n</color>")(+val_1(+val_1) + "<color=magenta>deviceModel: </color><color=red>"("<color=magenta>deviceModel: </color><color=red>") + UnityEngine.SystemInfo.deviceModel + "\n</color>"("\n</color>")(+val_1(+val_1) + "<color=magenta>deviceModel: </color><color=red>"("<color=magenta>deviceModel: </color><color=red>") + UnityEngine.SystemInfo.deviceModel + "\n</color>"("\n</color>")) + "<color=magenta>graphicsDeviceName: </color><color=red>"("<color=magenta>graphicsDeviceName: </color><color=red>") + UnityEngine.SystemInfo.graphicsDeviceName + "\n</color>"("\n</color>")) + "<color=magenta>graphicsDeviceVendor: </color><color=red>"("<color=magenta>graphicsDeviceVendor: </color><color=red>") + UnityEngine.SystemInfo.graphicsDeviceVendor + "\n</color>"("\n</color>")(+val_1(+val_1) + "<color=magenta>deviceModel: </color><color=red>"("<color=magenta>deviceModel: </color><color=red>") + UnityEngine.SystemInfo.deviceModel + "\n</color>"("\n</color>")(+val_1(+val_1) + "<color=magenta>deviceModel: </color><color=red>"("<color=magenta>deviceModel: </color><color=red>") + UnityEngine.SystemInfo.deviceModel + "\n</color>"("\n</color>")) + "<color=magenta>graphicsDeviceName: </color><color=red>"("<color=magenta>graphicsDeviceName: </color><color=red>") + UnityEngine.SystemInfo.graphicsDeviceName + "\n</color>"("\n</color>")(+val_1(+val_1) + "<color=magenta>deviceModel: </color><color=red>"("<color=magenta>deviceModel: </color><color=red>") + UnityEngine.SystemInfo.deviceModel + "\n</color>"("\n</color>")(+val_1(+val_1) + "<color=magenta>deviceModel: </color><color=red>"("<color=magenta>deviceModel: </color><color=red>") + UnityEngine.SystemInfo.deviceModel + "\n</color>"("\n</color>")) + "<color=magenta>graphicsDeviceName: </color><color=red>"("<color=magenta>graphicsDeviceName: </color><color=red>") + UnityEngine.SystemInfo.graphicsDeviceName + "\n</color>"("\n</color>")) + "<color=magenta>graphicsDeviceVendor: </color><color=red>"("<color=magenta>graphicsDeviceVendor: </color><color=red>") + UnityEngine.SystemInfo.graphicsDeviceVendor + "\n</color>"("\n</color>")) + "<color=magenta>graphicsDeviceVersion: </color><color=red>"("<color=magenta>graphicsDeviceVersion: </color><color=red>") + UnityEngine.SystemInfo.graphicsDeviceVersion + "\n</color>"("\n</color>");
        object[] val_12 = new object[4];
        if(val_12 == null)
        {
            goto label_16;
        }
        
        if(val_11 != null)
        {
            goto label_17;
        }
        
        goto label_20;
        label_16:
        if(val_11 == null)
        {
            goto label_20;
        }
        
        label_17:
        label_20:
        val_12[0] = val_11;
        val_12[1] = "<color=magenta>graphicsMemorySize: </color><color=red>";
        val_12[2] = UnityEngine.SystemInfo.graphicsMemorySize;
        val_12[3] = "\n</color>";
        string val_18 = +val_12(+val_12) + "<color=magenta>graphicsMultiThreaded: </color><color=red>"("<color=magenta>graphicsMultiThreaded: </color><color=red>") + UnityEngine.SystemInfo.graphicsMultiThreaded.ToString() + "\n</color>"("\n</color>");
        object[] val_19 = new object[4];
        if(val_19 == null)
        {
            goto label_31;
        }
        
        if(val_18 != null)
        {
            goto label_32;
        }
        
        goto label_35;
        label_31:
        if(val_18 == null)
        {
            goto label_35;
        }
        
        label_32:
        label_35:
        val_19[0] = val_18;
        val_19[1] = "<color=magenta>graphicsShaderLevel: </color><color=red></color><color=red>";
        val_19[2] = UnityEngine.SystemInfo.graphicsShaderLevel;
        val_19[3] = "\n</color>";
        string val_21 = +val_19;
        object[] val_22 = new object[4];
        if(val_22 == null)
        {
            goto label_46;
        }
        
        if(val_21 != null)
        {
            goto label_47;
        }
        
        goto label_50;
        label_46:
        if(val_21 == null)
        {
            goto label_50;
        }
        
        label_47:
        label_50:
        val_22[0] = val_21;
        val_22[1] = "<color=magenta>maxTextureSize: </color><color=red>";
        val_22[2] = UnityEngine.SystemInfo.maxTextureSize;
        val_22[3] = "\n</color>";
        string val_26 = +val_22(+val_22) + "<color=magenta>operatingSystem: </color><color=red>"("<color=magenta>operatingSystem: </color><color=red>") + UnityEngine.SystemInfo.operatingSystem + "\n</color>"("\n</color>");
        object[] val_27 = new object[4];
        if(val_27 == null)
        {
            goto label_61;
        }
        
        if(val_26 != null)
        {
            goto label_62;
        }
        
        goto label_65;
        label_61:
        if(val_26 == null)
        {
            goto label_65;
        }
        
        label_62:
        label_65:
        val_27[0] = val_26;
        val_27[1] = "<color=magenta>processorCount: </color><color=red>";
        val_27[2] = UnityEngine.SystemInfo.processorCount;
        val_27[3] = "\n</color>";
        string val_29 = +val_27;
        object[] val_30 = new object[4];
        if(val_30 == null)
        {
            goto label_76;
        }
        
        if(val_29 != null)
        {
            goto label_77;
        }
        
        goto label_80;
        label_76:
        if(val_29 == null)
        {
            goto label_80;
        }
        
        label_77:
        label_80:
        val_30[0] = val_29;
        val_30[1] = "<color=magenta>processorFrequency: </color><color=red>";
        val_30[2] = UnityEngine.SystemInfo.processorFrequency;
        val_30[3] = "\n</color>";
        string val_54 = +val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsComputeShaders: </color><color=red>"("<color=magenta>supportsComputeShaders: </color><color=red>") + UnityEngine.SystemInfo.supportsComputeShaders.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsComputeShaders: </color><color=red>"("<color=magenta>supportsComputeShaders: </color><color=red>") + UnityEngine.SystemInfo.supportsComputeShaders.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsInstancing: </color><color=red>"("<color=magenta>supportsInstancing: </color><color=red>") + UnityEngine.SystemInfo.supportsInstancing.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsComputeShaders: </color><color=red>"("<color=magenta>supportsComputeShaders: </color><color=red>") + UnityEngine.SystemInfo.supportsComputeShaders.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsComputeShaders: </color><color=red>"("<color=magenta>supportsComputeShaders: </color><color=red>") + UnityEngine.SystemInfo.supportsComputeShaders.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsInstancing: </color><color=red>"("<color=magenta>supportsInstancing: </color><color=red>") + UnityEngine.SystemInfo.supportsInstancing.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsMipStreaming: </color><color=red>"("<color=magenta>supportsMipStreaming: </color><color=red>") + UnityEngine.SystemInfo.supportsMipStreaming.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsComputeShaders: </color><color=red>"("<color=magenta>supportsComputeShaders: </color><color=red>") + UnityEngine.SystemInfo.supportsComputeShaders.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsComputeShaders: </color><color=red>"("<color=magenta>supportsComputeShaders: </color><color=red>") + UnityEngine.SystemInfo.supportsComputeShaders.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsInstancing: </color><color=red>"("<color=magenta>supportsInstancing: </color><color=red>") + UnityEngine.SystemInfo.supportsInstancing.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsComputeShaders: </color><color=red>"("<color=magenta>supportsComputeShaders: </color><color=red>") + UnityEngine.SystemInfo.supportsComputeShaders.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")(+val_30(+val_30) + "<color=magenta>processorType: </color><color=red>"("<color=magenta>processorType: </color><color=red>") + UnityEngine.SystemInfo.processorType + "\n</color>"("\n</color>")) + "<color=magenta>supports2DArrayTextures: </color><color=red>"("<color=magenta>supports2DArrayTextures: </color><color=red>") + UnityEngine.SystemInfo.supports2DArrayTextures.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsComputeShaders: </color><color=red>"("<color=magenta>supportsComputeShaders: </color><color=red>") + UnityEngine.SystemInfo.supportsComputeShaders.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsInstancing: </color><color=red>"("<color=magenta>supportsInstancing: </color><color=red>") + UnityEngine.SystemInfo.supportsInstancing.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsMipStreaming: </color><color=red>"("<color=magenta>supportsMipStreaming: </color><color=red>") + UnityEngine.SystemInfo.supportsMipStreaming.ToString() + "\n</color>"("\n</color>")) + "<color=magenta>supportsShadows: </color><color=red>"("<color=magenta>supportsShadows: </color><color=red>") + UnityEngine.SystemInfo.supportsShadows.ToString() + "\n</color>"("\n</color>");
        object[] val_55 = new object[4];
        if(val_55 == null)
        {
            goto label_91;
        }
        
        if(val_54 != null)
        {
            goto label_92;
        }
        
        goto label_95;
        label_91:
        if(val_54 == null)
        {
            goto label_95;
        }
        
        label_92:
        label_95:
        val_55[0] = val_54;
        val_55[1] = "<color=magenta>systemMemorySize: </color><color=red>";
        val_55[2] = UnityEngine.SystemInfo.systemMemorySize;
        val_55[3] = "\n</color>";
        string val_65 = +val_55(+val_55) + "<color=magenta>TextureFormat.ASTC_RGBA_4x4: </color><color=red>"("<color=magenta>TextureFormat.ASTC_RGBA_4x4: </color><color=red>") + UnityEngine.SystemInfo.SupportsTextureFormat(format:  54).ToString()(UnityEngine.SystemInfo.SupportsTextureFormat(format:  54).ToString()) + "\n</color>"("\n</color>")(+val_55(+val_55) + "<color=magenta>TextureFormat.ASTC_RGBA_4x4: </color><color=red>"("<color=magenta>TextureFormat.ASTC_RGBA_4x4: </color><color=red>") + UnityEngine.SystemInfo.SupportsTextureFormat(format:  54).ToString()(UnityEngine.SystemInfo.SupportsTextureFormat(format:  54).ToString()) + "\n</color>"("\n</color>")) + "<color=magenta>TextureFormat.ETC2_RGBA8: </color><color=red>"("<color=magenta>TextureFormat.ETC2_RGBA8: </color><color=red>") + UnityEngine.SystemInfo.SupportsTextureFormat(format:  47).ToString()(UnityEngine.SystemInfo.SupportsTextureFormat(format:  47).ToString()) + "\n</color>"("\n</color>");
        if(this.outputText != null)
        {
                return;
        }
    
    }
    public SysInfo()
    {
    
    }

}
