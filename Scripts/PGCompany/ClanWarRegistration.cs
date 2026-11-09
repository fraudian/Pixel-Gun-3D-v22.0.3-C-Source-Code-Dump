using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanWarRegistration : PGBehaviour
    {
        // Fields
        internal static bool 丑丘一丁丛丆丗一丕;
        private UnityEngine.GameObject _regButton;
        private UIButton _regWithPriceButton;
        private UnityEngine.GameObject _gem;
        private UnityEngine.GameObject _coin;
        private UILabel _price;
        private UnityEngine.GameObject _waiting;
        private UILabel _text;
        private System.IDisposable 丙丁下丂丄三东丘丝;
        
        // Methods
        private void Awake()
        {
            PGCompany.ClanWarProgressController.三丘丗丞丈丈三丛丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarRegistration::与丟丑东三丆丐丈丏()));
        }
        private void OnDestroy()
        {
            PGCompany.ClanWarProgressController.丆且且丄与业世业丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.ClanWarRegistration::与丟丑东三丆丐丈丏()));
        }
        private void OnEnable()
        {
            var val_16;
            string val_17;
            var val_18;
            var val_19;
            if(this.丙丁下丂丄三东丘丝 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                this.丙丁下丂丄三东丘丝.Dispose();
            }
            
            this.丙丁下丂丄三东丘丝 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.ClanWarRegistration::U_Close()), 与且专丈不万东一万:  "Clan war registration");
            val_16 = null;
            val_16 = null;
            val_17 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8540"), arg0:  BalanceController.三丝丑世与丌丞丟丑));
            this._text.text = val_17;
            if(BalanceController.下七不丙丌一丁专丕.丟丂丞不专丆万丒世() >= 1)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._regButton, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._regWithPriceButton, 丏业丟一东丂东丘丛:  true);
                val_18 = null;
                val_18 = null;
                val_19 = null;
                val_19 = null;
                string val_16 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
                val_16 = System.String.op_Equality(a:  BalanceController.下七不丙丌一丁专丕.东与三丌丅三丒丏业(), b:  val_16);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._gem, 丏业丟一东丂东丘丛:  val_16);
                string val_17 = 与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄;
                val_17 = System.String.op_Equality(a:  BalanceController.下七不丙丌一丁专丕.东与三丌丅三丒丏业(), b:  val_17);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._coin, 丏业丟一东丂东丘丛:  val_17);
                val_17 = BalanceController.下七不丙丌一丁专丕.丟丂丞不专丆万丒世().ToString();
                this._price.text = val_17;
                this.丏丂且丘丗一世七丝();
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._regButton, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._regWithPriceButton, 丏业丟一东丂东丘丛:  false);
        }
        private void OnDisable()
        {
            if(this.丙丁下丂丄三东丘丝 == null)
            {
                    return;
            }
            
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.丙丁下丂丄三东丘丝.Dispose();
        }
        private void Update()
        {
            this.丏丂且丘丗一世七丝();
        }
        private void 丏丂且丘丗一世七丝()
        {
            null = null;
            var val_1 = (PGCompany.ClanWarRegistration.丑丘一丁丛丆丗一丕 == false) ? 1 : 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._waiting, 丏业丟一东丂东丘丛:  (PGCompany.ClanWarRegistration.丑丘一丁丛丆丗一丕 == true) ? 1 : 0);
        }
        public void U_RegistrationInClanWar()
        {
            PGCompany.ClanWarRegistration.RegistrationInClanWar(丛丈七丒丄业丒丈丕:  this.gameObject, 丙丕丏下世丌不三丕:  0, 丒七丒丌世丘丑丂七:  new System.Action(object:  this, method:  public System.Void PGCompany.ClanWarRegistration::U_Close()));
        }
        public static void RegistrationInClanWar(UnityEngine.GameObject 丛丈七丒丄业丒丈丕, System.Action 丙丕丏下世丌不三丕, System.Action 丒七丒丌世丘丑丂七)
        {
            var val_9;
            var val_10;
            .丙丕丏下世丌不三丕 = 丙丕丏下世丌不三丕;
            val_9 = null;
            val_9 = null;
            if(BalanceController.下七不丙丌一丁专丕.丟丂丞不专丆万丒世() >= 1)
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  216);
                uint val_6 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丕丞与丒丒丝世不(业丏丈世世世丞丒世:  new System.Action(object:  new ClanWarRegistration.丞丆丌万丛不且七丐(), method:  System.Void ClanWarRegistration.丞丆丌万丛不且七丐::丆丛三万丆丅丑丕世()), 丁丒丗与丝世丁与且:  1, 丞丐丟三丌与丞上一:  0);
                val_10 = null;
                val_10 = null;
                上丑三丁丄丛丁万丑.七丝丘丌丌丕丞丏三(丛丈七丒丄业丒丈丕:  丛丈七丒丄业丒丈丕, 丒世丘丘上丆丝东丞:  BalanceController.下七不丙丌一丁专丕, 七丒上且丝业业下七:  new System.Action(object:  0, method:  static System.Void PGCompany.ClanWarRegistration::七丏丂丂且丞丏丑丑()), 丝丏丗丄丗与丐丌三:  0, 丒七丒丌世丘丑丂七:  丒七丒丌世丘丑丂七, 丞丐下东与丅万丅丁:  0, 与丟丁七丟专业一丅:  false, 三不三丟专丘东东丂:  "", 丝与丙丈丑丁七且丐:  0, 丐丈上丂与上丂丒丏:  121);
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
                return;
            }
            
            PGCompany.ClanWarRegistration.七世东丕且丆丅丌丒();
            if((ClanWarRegistration.丞丆丌万丛不且七丐)[1152921554258402064].丙丕丏下世丌不三丕 == null)
            {
                    return;
            }
            
            (ClanWarRegistration.丞丆丌万丛不且七丐)[1152921554258402064].丙丕丏下世丌不三丕.Invoke();
        }
        internal static void 七世东丕且丆丅丌丒()
        {
            var val_2;
            var val_3;
            val_2 = null;
            if(PGCompany.ClanWarRegistration.丗业丝丁业丅丁上丏() == false)
            {
                    return;
            }
            
            val_3 = null;
            val_3 = null;
            PGCompany.ClanWarRegistration.丑丘一丁丛丆丗一丕 = true;
            PGCompany.丐丁七一丒三东万丌.丟上世丐丈三丂丑丘();
        }
        private static bool 丗业丝丁业丅丁上丏()
        {
            string val_22;
            var val_23;
            var val_24;
            var val_25;
            val_22 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
            if(val_22.与七世丝上丗丄丌丗() != false)
            {
                    val_22 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
                if(val_22.丗丕三下上丗专东业() != true)
            {
                    val_23 = 1152921524404748272;
                val_22 = Rilisoft.Singleton<ClansController>.Instance;
                if(val_22.丞丗丑丈一丅丗丌丟() == null)
            {
                    return (bool)val_24;
            }
            
                val_22 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
                if(val_22.丁三丂丒业丁丙丂且() != false)
            {
                    val_25 = null;
                val_25 = null;
                if(BalanceController.下七不丙丌一丁专丕.丟丂丞不专丆万丒世() < 1)
            {
                    return (bool)val_24;
            }
            
                val_22 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁();
                char[] val_18 = new char[1];
                val_18[0] = '.';
                val_23 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  95).Split(separator:  val_18, options:  1);
                if(val_19.Length == 2)
            {
                    if((System.String.op_Inequality(a:  val_23[0], b:  val_22)) != true)
            {
                    if((System.String.op_Inequality(a:  val_23[1], b:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.不万丕丙一丒丂丒丌().ToString())) == false)
            {
                    return (bool)val_24;
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            val_24 = 0;
            return (bool)val_24;
        }
        internal static void 七丏丂丂且丞丏丑丑()
        {
            object val_8;
            var val_9;
            丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_2 != null)
            {
                    val_8 = val_2.丁丈丞一专下丛丕三();
            }
            else
            {
                    val_8 = 0;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  95, 丙业与丙丗丝不丈东:  System.String.Format(format:  "{0}.{1}", arg0:  val_8, arg1:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.不万丕丙一丒丂丒丌()));
            val_9 = null;
            val_9 = null;
            PGCompany.ClanWarRegistration.丑丘一丁丛丆丗一丕 = true;
        }
        internal void 与丂丁丑业上丌下且()
        {
        
        }
        public void U_Close()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
        }
        private void 与丟丑东三丆丐丈丏()
        {
            var val_3;
            if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丗丕三下上丗专东业()) != false)
            {
                    val_3 = null;
                val_3 = null;
                PGCompany.ClanWarRegistration.丑丘一丁丛丆丗一丕 = false;
            }
            
            this.U_Close();
        }
        public ClanWarRegistration()
        {
        
        }
        private static ClanWarRegistration()
        {
        
        }
    
    }

}
