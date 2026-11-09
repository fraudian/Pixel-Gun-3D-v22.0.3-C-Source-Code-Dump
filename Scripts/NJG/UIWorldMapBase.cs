using UnityEngine;

namespace NJG
{
    public abstract class UIWorldMapBase : UIMapBase
    {
        // Fields
        private static NJG.UIWorldMapBase 丄丈丂丅上专万丞丏;
        public MapTextManager mapTextManager;
        protected bool 下丄丆世丐业业丈丟;
        public NJGMapItem destinationPoint;
        
        // Properties
        public static NJG.UIWorldMapBase 丌丛万丛世丗丙丟与 { get; }
        
        // Methods
        public static NJG.UIWorldMapBase get_inst()
        {
            NJG.UIWorldMapBase val_5;
            var val_6;
            val_5 = NJG.UIWorldMapBase.丄丈丂丅上专万丞丏;
            if(val_5 != 0)
            {
                    return (NJG.UIWorldMapBase)NJG.UIWorldMapBase.丄丈丂丅上专万丞丏;
            }
            
            val_5 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle());
            UnityEngine.Object val_3 = UnityEngine.Object.FindObjectOfType(type:  val_5);
            val_6 = 0;
            NJG.UIWorldMapBase.丄丈丂丅上专万丞丏 = ;
            return (NJG.UIWorldMapBase)NJG.UIWorldMapBase.丄丈丂丅上专万丞丏;
        }
        public void InitInst()
        {
            NJG.UIWorldMapBase.丄丈丂丅上专万丞丏 = this;
        }
        protected override void Awake()
        {
            NJG.UIWorldMapBase.inst.enabled = true;
            mem[1152921541478698564] = 1;
            mem[1152921541478699088] = 0;
            this.Awake();
        }
        protected override void 丁业三上丛丐且专东()
        {
            UnityEngine.Transform val_8;
            UnityEngine.Object val_9;
            if(static_value_082C0000 == 0)
            {
                    val_8 = this.cachedTransform.GetChild(index:  0);
                mem[1152921541478831704] = val_8;
            }
            
            val_9 = 0;
            if(static_value_082C0000 == val_9)
            {
                    val_9 = 0;
                mem[1152921541478831704] = this.transform;
            }
            
            UnityEngine.Vector3 val_7 = this.rendererTransform.localScale;
            val_7.x = val_7.x * 0.5f;
            val_7.x = val_7.x * 0.25f;
            mem[1152921541478830960] = val_7.x;
            this.下丄丆世丐业业丈丟 = true;
        }
        protected override void 世丐丕三丞一丂三且(NJGMapItem 下丅丙一丂丗丅丝七)
        {
            if(this.isVisible == false)
            {
                    return;
            }
            
            NJG.UIMapIconBase val_2 = this.GetEntry(业业丙且东丒业世丟:  下丅丙一丂丗丅丝七);
            if(val_2 == 0)
            {
                    return;
            }
            
            if(val_2.isValid == true)
            {
                    return;
            }
            
            this.且丈业丕一且丝下上(丞丐丗丄下世丆丂丗:  val_2);
            val_2.isValid = true;
            val_2.isMapIcon = true;
        }
        protected override void 丕丂与丗丕丈丑且丛()
        {
            if(this.mapTextManager == 0)
            {
                    return;
            }
            
            if(this.mapTextManager.mapTexts == null)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = this.mapTextManager.mapTexts.GetEnumerator();
            label_10:
            if(((-1782448360) & 1) == 0)
            {
                goto label_8;
            }
            
            UnityEngine.Vector2 val_4 = this.WorldToMap(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3());
            0.丐丏七丌丕丗业且上().UpdatePosition(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            goto label_10;
            label_8:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        protected UIWorldMapBase()
        {
        
        }
    
    }

}
