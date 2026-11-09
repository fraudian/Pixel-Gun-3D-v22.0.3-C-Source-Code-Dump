using UnityEngine;

namespace Rilisoft
{
    public class 上丏丂下丄丕丑丏丂
    {
        // Fields
        private static System.Action 丛丄业丘不丆丄三丞;
        private static Rilisoft.GameEventBuyCurrencyView <不丁丄七丛不丆丁丕>k__BackingField;
        
        // Properties
        public static Rilisoft.GameEventBuyCurrencyView 丆丕丝丒不丙且丐丗 { get; set; }
        
        // Methods
        public static void 丈丗丐丗丛丝丕丙一(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Combine(a:  Rilisoft.上丏丂下丄丕丑丏丂.丛丄业丘不丆丄三丞, b:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        public static void 丟不丛世下东且丗丈(System.Action 丙业与丙丗丝不丈东)
        {
            System.Delegate val_3 = System.Delegate.Remove(source:  Rilisoft.上丏丂下丄丕丑丏丂.丛丄业丘不丆丄三丞, value:  丙业与丙丗丝不丈东);
            if(val_3 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
            
            val_3 = 0;
        }
        public static Rilisoft.GameEventBuyCurrencyView 丑七不且上丗丁一世()
        {
            return (Rilisoft.GameEventBuyCurrencyView)Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(Rilisoft.GameEventBuyCurrencyView 丙业与丙丗丝不丈东)
        {
            Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public static void 下与丞三丅丛丄七丕(string 丅丑不丏丞丛丆与丛, UnityEngine.Transform 丆丏七丟不丒与七专)
        {
            var val_8;
            if((Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField) != 0)
            {
                    Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField.Hide();
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_3 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  丅丑不丏丞丛丆与丛);
            if(val_3 != null)
            {
                    val_8 = null;
                Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField = GameEventsHalper.业一丁丙丏专下丟丗<Rilisoft.GameEventBuyCurrencyView>(丅东专与不三丂丁丝:  val_3, 丒丘丏上丙丟丑丕丈:  "buy", 丈东丘丏与丌东东下:  丆丏七丟不丒与七专, 丛下丅丏丄且丁一业:  true);
                val_8 = null;
                Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField.add_OnPurchaseSelected(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameCurrencyData>(object:  0, method:  static System.Void Rilisoft.上丏丂下丄丕丑丏丂::七下不上上不丞世万(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)));
                Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField.add_OnHide(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void Rilisoft.上丏丂下丄丕丑丏丂::丅丟丛一下业丙业丟()));
                Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField.Show(丅东专与不三丂丁丝:  val_3);
                return;
            }
            
            object[] val_7 = new object[1];
            val_7[0] = 丅丑不丏丞丛丆与丛;
            UnityEngine.Debug.LogErrorFormat(format:  "game event with tag \'{0}\' not found", args:  val_7);
        }
        public static void 丆世与丑丆丅丐万且()
        {
            if((Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField) == 0)
            {
                    return;
            }
            
            Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField.remove_OnPurchaseSelected(丙业与丙丗丝不丈东:  new System.Action<Rilisoft.GameCurrencyData>(object:  0, method:  static System.Void Rilisoft.上丏丂下丄丕丑丏丂::七下不上上不丞世万(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)));
            Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField.remove_OnHide(丙业与丙丗丝不丈东:  new System.Action(object:  0, method:  static System.Void Rilisoft.上丏丂下丄丕丑丏丂::丅丟丛一下业丙业丟()));
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField.gameObject);
            Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField = 0;
            if(Rilisoft.上丏丂下丄丕丑丏丂.丛丄业丘不丆丄三丞 == null)
            {
                    return;
            }
            
            Rilisoft.上丏丂下丄丕丑丏丂.丛丄业丘不丆丄三丞.Invoke();
        }
        private static void 七下不上上不丞世万(Rilisoft.GameCurrencyData 一下世丆丙万丞东丆)
        {
            Rilisoft.上丏丂下丄丕丑丏丂.丆世与丑丆丅丐万且();
            Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().不丞丘一丙丝丒与与(丅东专与不三丂丁丝:  Rilisoft.上丏丂下丄丕丑丏丂.<不丁丄七丛不丆丁丕>k__BackingField.Context, 一下世丆丙万丞东丆:  一下世丆丙万丞东丆);
        }
        private static void 丅丟丛一下业丙业丟()
        {
            Rilisoft.上丏丂下丄丕丑丏丂.丆世与丑丆丅丐万且();
        }
        public 上丏丂下丄丕丑丏丂()
        {
        
        }
    
    }

}
