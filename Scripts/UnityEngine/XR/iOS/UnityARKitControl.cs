using UnityEngine;

namespace UnityEngine.XR.iOS
{
    public class UnityARKitControl : MonoBehaviour
    {
        // Fields
        private UnityEngine.XR.iOS.丌丝丆丂丘丗一丕丗[] 万丙丄丘万丄丅世且;
        private UnityEngine.XR.iOS.丗丈丕丘丝丙丒丆丄[] 世丝丈七丆丁丟不世;
        private UnityEngine.XR.iOS.丌丘丐丙一丆丐丄不[] 丙丄丟丑三丙业业丌;
        private int 丗丗不三丒万七万世;
        private int 丞丕万三丕丒万丂丕;
        private int 丛丌丏丂专万丆丒七;
        
        // Methods
        private void Start()
        {
            this.万丙丄丘万丄丅世且[0] = 3;
            this.万丙丄丘万丄丅世且[0] = 1;
            this.万丙丄丘万丄丅世且[1] = 2;
            this.万丙丄丘万丄丅世且[1] = 0;
            this.世丝丈七丆丁丟不世[0] = 2;
            this.世丝丈七丆丁丟不世[0] = 0;
            this.世丝丈七丆丁丟不世[1] = 1;
            this.丙丄丟丑三丙业业丌[0] = 1;
            this.丙丄丟丑三丙业业丌[0] = 0;
        }
        private void Update()
        {
        
        }
        private void OnGUI()
        {
            UnityEngine.XR.iOS.丗丈丕丘丝丙丒丆丄 val_20;
            UnityEngine.XR.iOS.丌丝丆丂丘丗一丕丗 val_21;
            var val_22;
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Stop")) != false)
            {
                    UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.丕丕下丐丟丏三万丄().世上专丐丂业世世丂();
            }
            
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Start")) != false)
            {
                    UnityEngine.XR.iOS.丌丘丐丙一丆丐丄不 val_21 = this.丙丄丟丑三丙业业丌[(this.丛丌丏丂专万丆丒七) << 2];
                val_20 = UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.丕丕下丐丟丏三万丄();
                UnityEngine.XR.iOS.丌丝丆丂丘丗一丕丗 val_22 = this.万丙丄丘万丄丅世且[(this.丗丗不三丒万七万世) << 2];
                val_21 = 0;
                val_20.世丞业不且上丒下丅(上世丏丁世丟世丆业:  new UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕() {世丕七丑丑丟不丙丏 = this.世丝丈七丆丁丟不世[(this.丞丕万三丕丒万丂丕) << 2], 丂一且丟与丗丗丂丟 = this.世丝丈七丆丁丟不世[(this.丞丕万三丕丒万丂丕) << 2], 上丆丑丞丄上丘丗下 = this.世丝丈七丆丁丟不世[(this.丞丕万三丕丒万丂丕) << 2], 七丝专丆丐丗世下一 = this.世丝丈七丆丁丟不世[(this.丞丕万三丕丒万丂丕) << 2]}, 万丙丄丘万丄丅世且:  val_21);
            }
            
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Start Non-WT Session")) != false)
            {
                    if(this.丞丕万三丕丒万丂丕 >= this.世丝丈七丆丁丟不世.Length)
            {
                    val_21 = 0;
            }
            
                val_20 = (this.世丝丈七丆丁丟不世[(this.丞丕万三丕丒万丂丕) << 2]) | 1103806595072;
                UnityEngine.XR.iOS.丐七丆七丑丞丄丘上.丕丕下丐丟丏三万丄().丟业丅上丗万东与丌(上世丏丁世丟世丆业:  new UnityEngine.XR.iOS.丑丙丌丙一丗与丗丙() {世丕七丑丑丟不丙丏 = val_20, 上丆丑丞丄上丘丗下 = false, 七丝专丆丐丗世下一 = false});
            }
            
            if(this.丗丗不三丒万七万世 == 0)
            {
                goto label_27;
            }
            
            if(this.丗丗不三丒万七万世 != 1)
            {
                goto label_28;
            }
            
            val_22 = "Tracking";
            goto label_30;
            label_27:
            val_22 = "Full";
            goto label_30;
            label_28:
            label_30:
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "RunOption:"("RunOption:") + (this.丗丗不三丒万七万世 == 2) ? "Anchors" : "None"((this.丗丗不三丒万七万世 == 2) ? "Anchors" : "None"))) != false)
            {
                    int val_24 = this.丗丗不三丒万七万世;
                int val_10 = val_24 + 1;
                val_24 = (val_10 < 0) ? (val_24 + 4) : (val_24 + 1);
                val_24 = val_24 & 4294967292;
                val_24 = val_10 - val_24;
                this.丗丗不三丒万七万世 = val_24;
            }
            
            int val_25 = this.丞丕万三丕丒万丂丕;
            val_25 = (val_25 == 0) ? "Camera" : ((val_25 == 1) ? "Gravity" : "GravityAndHeading");
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "AlignOption:"("AlignOption:") + val_25)) != false)
            {
                    int val_26 = this.丞丕万三丕丒万丂丕;
                val_26 = val_26 + 1;
                val_26 = val_26 - 0;
                this.丞丕万三丕丒万丂丕 = val_26;
            }
            
            if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "PlaneOption:"("PlaneOption:") + (this.丛丌丏丂专万丆丒七 == 0) ? "Horizontal" : "None"((this.丛丌丏丂专万丆丒七 == 0) ? "Horizontal" : "None"))) == false)
            {
                    return;
            }
            
            int val_27 = this.丛丌丏丂专万丆丒七;
            int val_18 = val_27 + 1;
            val_27 = (val_18 < 0) ? (val_27 + 2) : (val_27 + 1);
            val_27 = val_27 & 4294967294;
            val_27 = val_18 - val_27;
            this.丛丌丏丂专万丆丒七 = val_27;
        }
        public UnityARKitControl()
        {
            this.万丙丄丘万丄丅世且 = new UnityEngine.XR.iOS.丌丝丆丂丘丗一丕丗[4];
            this.世丝丈七丆丁丟不世 = new UnityEngine.XR.iOS.丗丈丕丘丝丙丒丆丄[3];
            this.丙丄丟丑三丙业业丌 = new UnityEngine.XR.iOS.丌丘丐丙一丆丐丄不[4];
        }
    
    }

}
