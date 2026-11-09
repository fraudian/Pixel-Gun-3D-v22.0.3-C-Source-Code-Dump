using UnityEngine;

namespace PGCompany
{
    internal abstract class 与丝专不不丛丑三丂 : 下丌丐三且丑且七东
    {
        // Fields
        private bool 丁东丝丁万丗且丝且;
        
        // Properties
        protected abstract string 丝下业与丞丐丝一专 { get; }
        internal override bool 上丒丂丘丂七丘丂七 { get; }
        
        // Methods
        protected abstract string 丆东丏一丐丟上万与(); // 0
        internal override bool 丈丌丐不丙丕丕丆东()
        {
            return false;
        }
        internal override void 丗下丗丕丂丈万七丛()
        {
            goto typeof(PGCompany.与丝专不不丛丑三丂).__il2cppRuntimeField_198;
        }
        protected virtual PGCompany.业丏世不丞丆不丈下 与七专丑三不丟七丝()
        {
            .Type = 119;
            PGCompany.业丏世不丞丆不丈下 val_3 = new PGCompany.业丏世不丞丆不丈下(七丞丂丝丈七丙丒丏:  X21, 世丝丛上丑丙丝且丟:  PGCompany.丂丆下丙丙丘一七下.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.GameTaskActionSettings(), 三东丏丐丟三丕丈上:  0), 下丙与丂丟丅不七不:  this);
            val_3.与世万世三丄丘丈三(三专丞东且丌丘专三:  new 丙上三东丟丒与丟丟(丁业三上丛丐且专东:  new System.Action(object:  this, method:  System.Void PGCompany.与丝专不不丛丑三丂::丘丐东丕世丙丗上万())));
            PGCompany.丕丅丘三丛丏丐三下 val_6 = new PGCompany.丕丅丘三丛丏丐三下(丝三丗万丞丁丄丌一:  "BattleNowLobby");
            PGCompany.丕丅丘三丛丏丐三下 val_7 = val_6.丝丟三丗丐丗三与专(丌且丘业丒不丙丝上:  "Key_11196", 丕专业丌与丆丑丐丕:  "Key_11197", 与一七丘丏与万丒七:  "match hint 1");
            val_3.与世万世三丄丘丈三(三专丞东且丌丘专三:  val_6);
            val_3.丒丆不七丏丂丛丕世(丙业与丙丗丝不丈东:  new System.Action<PGCompany.业丏世不丞丆不丈下>(object:  this, method:  System.Void PGCompany.与丝专不不丛丑三丂::丏丌不与一业丟丙丆(PGCompany.业丏世不丞丆不丈下 万丗丅七丘丗与丈丑)));
            System.Action<PGCompany.业丏世不丞丆不丈下> val_9 = new System.Action<PGCompany.业丏世不丞丆不丈下>(object:  this, method:  System.Void PGCompany.与丝专不不丛丑三丂::丏丌不与一业丟丙丆(PGCompany.业丏世不丞丆不丈下 万丗丅七丘丗与丈丑));
            if(val_3 != null)
            {
                    val_3.丒丛七世下万丒丅世(丙业与丙丗丝不丈东:  val_9);
            }
            else
            {
                    val_3.丒丛七世下万丒丅世(丙业与丙丗丝不丈东:  val_9);
            }
            
            .丈万丕丑丗丑丁且丁 = true;
            this.Add(item:  val_3);
            return val_3;
        }
        private void 丏丌不与一业丟丙丆(PGCompany.业丏世不丞丆不丈下 万丗丅七丘丗与丈丑)
        {
            InGameGUI.remove_OnCreateInGameGUI(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.与丝专不不丛丑三丂::丌丆丕七专专丁专丑()));
        }
        private void 丒丕上业世下丈万七()
        {
        
        }
        private void 丌丆丕七专专丁专丑()
        {
            if(InGameGUI.丙丞专丌丁丞与不丐 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  InGameGUI.丙丞专丌丁丞与不丐.shopView, 丏业丟一东丂东丘丛:  false);
        }
        private void 丐业丏一东丙丌丞丒()
        {
            UnityEngine.GameObject val_1;
            NetworkStartTableNGUIController val_2 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
            if(val_2 == null)
            {
                    return;
            }
            
            val_1 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 432];
            val_1 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.Continue_GoToLobbyButton;
            if(null != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  true);
                val_2 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
                if(val_2 == null)
            {
                    return;
            }
            
            }
            
            val_1 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 416];
            val_1 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.OkNoAdsButton;
            if(null != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1, 丏业丟一东丂东丘丛:  false);
                val_2 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟;
                if(val_2 == null)
            {
                    return;
            }
            
            }
            
            val_1 = mem[NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 + 520];
            val_1 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.BankShopGUI;
            if(null == 0)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_1, 丏业丟一东丂东丘丛:  false);
        }
        protected 与丝专不不丛丑三丂()
        {
        
        }
        private void 丘丐东丕世丙丗上万()
        {
            InGameGUI.add_OnCreateInGameGUI(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.与丝专不不丛丑三丂::丌丆丕七专专丁专丑()));
        }
    
    }

}
