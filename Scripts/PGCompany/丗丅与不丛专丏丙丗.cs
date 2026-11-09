using UnityEngine;

namespace PGCompany
{
    internal sealed class 丗丅与不丛专丏丙丗
    {
        // Fields
        internal const string 业丐业丌丛丅且丅丗 = "ConnectSceneMigration";
        internal const int 丕业万丕丟丁丟丞丗 = 10;
        internal const int 丙上业专丁丐七丗万 = 11;
        internal const float 业世丘专丝世丝丁丅 = 0.5;
        internal const float 丁丟丙专三丅一东丄 = 0.5;
        internal const int 丕丁丆丛丒丑与丏丈 = 15;
        private static PGCompany.丗丅与不丛专丏丙丗 丝业丆丁业三丈丟东;
        private PGCompany.ConnectSceneMigrationData 业丑东丛丒丒丙业不;
        
        // Properties
        internal static PGCompany.丗丅与不丛专丏丙丗 丆丕丝丒不丙且丐丗 { get; }
        internal PGCompany.ConnectSceneMigrationData 一一上下丛丗且丙丂 { get; }
        
        // Methods
        internal static PGCompany.丗丅与不丛专丏丙丗 丑七不且上丗丁一世()
        {
            PGCompany.丗丅与不丛专丏丙丗 val_2 = PGCompany.丗丅与不丛专丏丙丗.丝业丆丁业三丈丟东;
            if(val_2 != null)
            {
                    return val_2;
            }
            
            PGCompany.丗丅与不丛专丏丙丗 val_1 = null;
            val_2 = val_1;
            val_1 = new PGCompany.丗丅与不丛专丏丙丗();
            PGCompany.丗丅与不丛专丏丙丗.丝业丆丁业三丈丟东 = val_2;
            return val_2;
        }
        internal PGCompany.ConnectSceneMigrationData 上丈下且世丈丟丄丝()
        {
            PGCompany.ConnectSceneMigrationData val_5 = this.业丑东丛丒丒丙业不;
            if(val_5 != null)
            {
                    return val_5;
            }
            
            string val_2 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丒与丈丛丝丙丌上下(下上丐丆丝丟丝丒不:  126);
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            this.业丑东丛丒丒丙业不 = val_5;
            return val_5;
        }
        internal PGCompany.丗丅与不丛专丏丙丗 下丕世且不丄丂且丏()
        {
            var val_10;
            bool val_1 = AuthSceneController.一不丆丏与丐丏丈丄();
            if(val_1 == false)
            {
                    return (PGCompany.丗丅与不丛专丏丙丗)this;
            }
            
            if(val_1.丆丝万丐且业丂丐丟() == true)
            {
                    return (PGCompany.丗丅与不丛专丏丙丗)this;
            }
            
            this.丅丛丝与丄丌丕且丘();
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  20);
            val_10 = 0;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  61);
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_10 = 0;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  126, 丙业与丙丗丝不丈东:  DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝().丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.上丈下且世丈丟丄丝()));
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
            return (PGCompany.丗丅与不丛专丏丙丗)this;
        }
        internal bool 丆丝万丐且业丂丐丟()
        {
            Progress.东丐世上丛丌丛丛丝 val_1 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
            if(val_1 != null)
            {
                    return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  61);
            }
            
            return val_1.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  61);
        }
        internal void 丙丞不丘丟丁丅丙丄(Rilisoft.丛且世丐丆上七业丁 丅东专与不三丂丁丝)
        {
            int val_23;
            if(this.上丈下且世丈丟丄丝() == null)
            {
                    return;
            }
            
            val_23 = Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专();
            if((val_23.丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  62)) == true)
            {
                    return;
            }
            
            Rilisoft.三一丈七且丄与丝东 val_4 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if((val_4 != null) && (val_4.丏世丞丕丂丒七上业() != null))
            {
                    Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  21);
                System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_7 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
                PGCompany.ConnectSceneMigrationData val_8 = this.上丈下且世丈丟丄丝();
                val_7.Add(item:  val_8.EventChestMedium);
                PGCompany.ConnectSceneMigrationData val_9 = this.上丈下且世丈丟丄丝();
                val_7.Add(item:  val_9.EventChestBig);
                PGCompany.ConnectSceneMigrationData val_10 = this.上丈下且世丈丟丄丝();
                val_7.Add(item:  val_10.EventChestSuper);
                PGCompany.ConnectSceneMigrationData val_11 = this.上丈下且世丈丟丄丝();
                val_7.Add(item:  val_11.EventCurrency);
                System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_13 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_7, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
                val_23 = this.上丈下且世丈丟丄丝();
                if(val_23.EventChestSuperPoint >= 1)
            {
                    val_23 = this.上丈下且世丈丟丄丝().EventChestSuperPoint;
                丅东专与不三丂丁丝.万丛丄丝且上丐丗丕(丌丒丝东丌下丕丁丅:  val_23);
            }
            
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  62);
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
                ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丗丅与不丛专丏丙丗::丙丞不丘丟丁丅丙丄()));
                return;
            }
            
            val_23 = 1152921504615739392;
            ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丗丅与不丛专丏丙丗::丙丞不丘丟丁丅丙丄()));
            ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.丗丅与不丛专丏丙丗::丙丞不丘丟丁丅丙丄()));
        }
        internal void 丙丞不丘丟丁丅丙丄()
        {
            Rilisoft.三一丈七且丄与丝东 val_1 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世();
            if(val_1 == null)
            {
                goto label_3;
            }
            
            if(this != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            this.丙丞不丘丟丁丅丙丄(丅东专与不三丂丁丝:  val_1.丏世丞丕丂丒七上业());
            return;
            label_3:
            if(this != null)
            {
                goto label_5;
            }
            
            goto label_6;
        }
        internal void 世丙丝业丁三丏丗三()
        {
            if(this.上丈下且世丈丟丄丝() == null)
            {
                    return;
            }
            
            if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  63)) == true)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  21);
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_5 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
            PGCompany.ConnectSceneMigrationData val_6 = this.上丈下且世丈丟丄丝();
            val_5.Add(item:  val_6.GemsByKeyChestSmallBooster);
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_8 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_5, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  63);
            this = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
            this.七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        private void 丅丛丝与丄丌丕且丘()
        {
            PGCompany.三东丏不丗世丅丌丄 val_63;
            var val_64;
            this.业丑东丛丒丒丙业不 = new PGCompany.ConnectSceneMigrationData();
            PGCompany.三东丏不丗世丅丌丄 val_2 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  200015);
            PGCompany.三东丏不丗世丅丌丄 val_3 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  239);
            PGCompany.三东丏不丗世丅丌丄 val_5 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_3.业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  100);
            PGCompany.三东丏不丗世丅丌丄 val_7 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  200015 + 1000);
            PGCompany.三东丏不丗世丅丌丄 val_8 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  215);
            PGCompany.三东丏不丗世丅丌丄 val_10 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_8.业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  10);
            PGCompany.三东丏不丗世丅丌丄 val_12 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  200015 + 2000);
            PGCompany.三东丏不丗世丅丌丄 val_15 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  191).业东丅东丌上丗丑不(), 丂丕丂丏专丂丄丕且:  244);
            int val_16 = val_2.业东丅东丌上丗丑不();
            this.业丑东丛丒丒丙业不.ConnectSceneChestSmall = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_16, 丂丕丂丏专丂丄丕且:  val_16.丟丐七丗七三七丏丐(丄业丏丙且丞业上东:  val_2, 业一万丂丄丝且丕丏:  val_5));
            PGCompany.ConnectSceneMigrationData val_19 = this.上丈下且世丈丟丄丝();
            this.业丑东丛丒丒丙业不.EventChestMedium = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  501015, 丂丕丂丏专丂丄丕且:  val_19.ConnectSceneChestSmall.丂丁丏一丙丛业且丌());
            int val_22 = val_7.业东丅东丌上丗丑不();
            this.业丑东丛丒丒丙业不.ConnectSceneChestBig = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_22, 丂丕丂丏专丂丄丕且:  val_22.丟丐七丗七三七丏丐(丄业丏丙且丞业上东:  val_7, 业一万丂丄丝且丕丏:  val_10));
            PGCompany.ConnectSceneMigrationData val_25 = this.上丈下且世丈丟丄丝();
            float val_67 = (float)val_25.ConnectSceneChestBig.丂丁丏一丙丛业且丌();
            val_67 = val_67 * 0.5f;
            this.业丑东丛丒丒丙业不.EventChestBig = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  501015 + 1000, 丂丕丂丏专丂丄丕且:  UnityEngine.Mathf.CeilToInt(f:  val_67));
            int val_30 = val_7.业东丅东丌上丗丑不();
            PGCompany.三东丏不丗世丅丌丄 val_32 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_30, 丂丕丂丏专丂丄丕且:  val_30.丟丐七丗七三七丏丐(丄业丏丙且丞业上东:  val_7, 业一万丂丄丝且丕丏:  val_10));
            int val_33 = val_12.业东丅东丌上丗丑不();
            this.业丑东丛丒丒丙业不.ConnectSceneChestEvent = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_33, 丂丕丂丏专丂丄丕且:  val_33.丟丐七丗七三七丏丐(丄业丏丙且丞业上东:  val_12, 业一万丂丄丝且丕丏:  val_15));
            PGCompany.ConnectSceneMigrationData val_36 = this.上丈下且世丈丟丄丝();
            this.业丑东丛丒丒丙业不.EventChestSuper = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  501015 + 2000, 丂丕丂丏专丂丄丕且:  val_36.ConnectSceneChestEvent.丂丁丏一丙丛业且丌());
            int val_40 = val_3.业东丅东丌上丗丑不();
            this.业丑东丛丒丒丙业不.ConnectSceneKeyChestSmall = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_40, 丂丕丂丏专丂丄丕且:  val_40.与丐且丘丆万丗专丕(业一万丂丄丝且丕丏:  val_5));
            int val_43 = val_8.业东丅东丌上丗丑不();
            this.业丑东丛丒丒丙业不.ConnectSceneKeyChestBig = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_43, 丂丕丂丏专丂丄丕且:  val_43.与丐且丘丆万丗专丕(业一万丂丄丝且丕丏:  val_10));
            PGCompany.ConnectSceneMigrationData val_46 = this.上丈下且世丈丟丄丝();
            float val_68 = (float)val_46.ConnectSceneKeyChestSmall.丂丁丏一丙丛业且丌();
            val_68 = val_68 * 0.5f;
            PGCompany.ConnectSceneMigrationData val_49 = this.上丈下且世丈丟丄丝();
            int val_50 = val_49.ConnectSceneKeyChestBig.丂丁丏一丙丛业且丌();
            int val_51 = val_50 << 4;
            val_51 = val_51 - val_50;
            this.业丑东丛丒丒丙业不.EventCurrency = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  127, 丂丕丂丏专丂丄丕且:  val_51 + (UnityEngine.Mathf.CeilToInt(f:  val_68)));
            int val_54 = val_12.业东丅东丌上丗丑不();
            this.业丑东丛丒丒丙业不.ConnectSceneKeyChestEvent = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  val_54, 丂丕丂丏专丂丄丕且:  val_54.与丐且丘丆万丗专丕(业一万丂丄丝且丕丏:  val_15));
            PGCompany.ConnectSceneMigrationData val_57 = this.上丈下且世丈丟丄丝();
            this.业丑东丛丒丒丙业不.EventChestSuperPoint = val_57.ConnectSceneKeyChestEvent.丂丁丏一丙丛业且丌();
            val_63 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            PGCompany.丘丛丟一丛且丅丆一 val_61 = val_63.上丟丘下世七与丁世<PGCompany.丘丛丟一丛且丅丆一>(丈丄不七三万丄丁不:  PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  305015), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            if(val_61 != null)
            {
                    val_63 = val_63.与下不与丐丈丁丈万();
                this.业丑东丛丒丒丙业不.ConnectSceneKeyChestSmallBooster = val_63;
                float val_69 = (float)val_61.丂丁丏一丙丛业且丌();
                val_69 = val_69 / 11f;
                val_64 = UnityEngine.Mathf.Max(a:  10, b:  UnityEngine.Mathf.FloorToInt(f:  val_69));
            }
            else
            {
                    val_64 = 0;
            }
            
            this.业丑东丛丒丒丙业不.GemsByKeyChestSmallBooster = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  223, 丂丕丂丏专丂丄丕且:  0);
        }
        private int 与丐且丘丆万丗专丕(PGCompany.三东丏不丗世丅丌丄 业一万丂丄丝且丕丏)
        {
            int val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丞世不丒下上上丝丑:  业一万丂丄丝且丕丏.业东丅东丌上丗丑不(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            int val_4 = 业一万丂丄丝且丕丏.丂丁丏一丙丛业且丌();
            float val_6 = (float)val_3;
            val_6 = val_6 / (float)val_4;
            int val_5 = UnityEngine.Mathf.FloorToInt(f:  val_6);
            val_5 = val_3 - (val_5 * val_4);
            return (int)val_5;
        }
        private int 丟丐七丗七三七丏丐(PGCompany.三东丏不丗世丅丌丄 丄业丏丙且丞业上东, PGCompany.三东丏不丗世丅丌丄 业一万丂丄丝且丕丏)
        {
            PGCompany.三东丏不丗世丅丌丄 val_8 = 业一万丂丄丝且丕丏;
            if(val_8 != null)
            {
                    float val_7 = (float)PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丈丄不七三万丄丁不:  val_8 = 业一万丂丄丝且丕丏, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
                val_7 = val_7 / (float)val_8.丂丁丏一丙丛业且丌();
                val_8 = UnityEngine.Mathf.FloorToInt(f:  val_7);
            }
            
            int val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丈丄不七三万丄丁不:  丄业丏丙且丞业上东, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            val_6 = val_6 + val_8;
            return (int)val_6;
        }
        public 丗丅与不丛专丏丙丗()
        {
        
        }
    
    }

}
