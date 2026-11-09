using UnityEngine;

namespace Rilisoft
{
    public class GameEventExcludeChestsView : MonoBehaviour, 丁丝与丅丏且丂丙下, 丈丕丑且丘丘丆东丑, 七丌且丛万与丞世丁<Rilisoft.与专丒丞丐一丒丂东, System.Collections.Generic.List<int>>
    {
        // Fields
        private Rilisoft.与专丒丞丐一丒丂东 <丅丝丌丝丁丏丙东丞>k__BackingField;
        private System.Collections.Generic.List<int> <丝七不世七下世东丄>k__BackingField;
        private UILabel _mainLabel;
        private UILabel _countLabel;
        private UIButton _getPrizesButton;
        private System.Action<Rilisoft.GameEventExcludeChestsView> 丅丕丌丛万丂丈七与;
        
        // Properties
        public Rilisoft.与专丒丞丐一丒丂东 丄丄一丐东丐丝丗七 { get; set; }
        public System.Collections.Generic.List<int> 丌且丝丘丌丕东丒与 { get; set; }
        public bool 东且世与一东丂一丆 { get; }
        
        // Methods
        public Rilisoft.与专丒丞丐一丒丂东 get_Context()
        {
            return (Rilisoft.与专丒丞丐一丒丂东)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.与专丒丞丐一丒丂东 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public System.Collections.Generic.List<int> get_Parameter()
        {
            return (System.Collections.Generic.List<System.Int32>)this.<丝七不世七下世东丄>k__BackingField;
        }
        public void set_Parameter(System.Collections.Generic.List<int> 丙业与丙丗丝不丈东)
        {
            this.<丝七不世七下世东丄>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(Rilisoft.与专丒丞丐一丒丂东 与且专丈不万东一万, System.Collections.Generic.List<int> 丆且丁丒丒丆丁三丆)
        {
            System.Collections.Generic.List<System.Int32> val_10;
            string val_11;
            var val_12;
            val_10 = 丆且丁丒丒丆丁三丆;
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.<丝七不世七下世东丄>k__BackingField = val_10;
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = 与且专丈不万东一万.万丝世丘丞东万丟万();
            if(val_10 != null)
            {
                    val_10 = val_10.Count;
            }
            
            if(this._mainLabel != 0)
            {
                    val_11 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4554"), arg0:  null);
                this._mainLabel.text = val_11;
            }
            
            val_12 = 0;
            if(this._countLabel != 0)
            {
                    val_11 = this._countLabel;
                val_12 = 0;
                val_11.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4555"), arg0:  val_10, arg1:  null);
            }
            
            var val_9 = (val_10 >= ) ? 1 : 0;
        }
        public bool get___InterfaceEnabled()
        {
            UnityEngine.GameObject val_1 = this.gameObject;
            if(val_1 != null)
            {
                    return val_1.activeSelf;
            }
            
            return val_1.activeSelf;
        }
        public void ShowWindow()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        }
        public void HideWindow()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public void add_Clicked(System.Action<Rilisoft.GameEventExcludeChestsView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921542750285104);
        
        }
        public void remove_Clicked(System.Action<Rilisoft.GameEventExcludeChestsView> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丅丕丌丛万丂丈七与 != 1152921542750421680);
        
        }
        public GameEventExcludeChestsView()
        {
        
        }
    
    }

}
