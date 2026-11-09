using UnityEngine;

namespace Rilisoft
{
    [Serializable]
    public class GameEventItemData : ICloneable
    {
        // Fields
        private System.Nullable<Rilisoft.丝丑丂丛万丐丈丘且> _calculatedCount;
        internal PGCompany.三东丏不丗世丅丌丄 ItemParams;
        public string BgColor;
        public int ChestId;
        internal System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> CoinsLimits;
        public int ContainerId;
        public float DropChance;
        public int EventId;
        public int ExtSort;
        internal System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> GemsCoinsLimits;
        internal System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且> GemsLimits;
        public int PresettedCount;
        public int SubType;
        
        // Properties
        internal Rilisoft.GameEventItemType Type { get; }
        internal string Id { get; }
        internal Rilisoft.丝丑丂丛万丐丈丘且 BaseCount { get; }
        public int Count { get; }
        
        // Methods
        internal Rilisoft.GameEventItemType get_Type()
        {
            if(this.ItemParams == null)
            {
                    return (Rilisoft.GameEventItemType)this.ItemParams;
            }
            
            return PGCompany.专丏丐丄丛丈丄丂丂.丙一业丈专世丑丟丗(下丗丁丒丘东丂不丑:  this.ItemParams.不业丙丒丂丞下丆丙());
        }
        internal string get_Id()
        {
            int val_2;
            if(this.ItemParams != null)
            {
                    if(this.ItemParams.业上丙丞丐丄丆丅七() != null)
            {
                    return (string)val_2;
            }
            
            }
            
            val_2 = System.String.alignConst;
            return (string)val_2;
        }
        internal Rilisoft.丝丑丂丛万丐丈丘且 get_BaseCount()
        {
            if(this.ItemParams == null)
            {
                    return Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  this.ItemParams.丂丁丏一丙丛业且丌());
            }
            
            return Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  this.ItemParams.丂丁丏一丙丛业且丌());
        }
        public int get_Count()
        {
            int val_2 = this.PresettedCount;
            if(val_2 > 0)
            {
                    return (int)val_2;
            }
            
            if(this._calculatedCount.HasValue != true)
            {
                    this.七丏丟丈丞丌一丆丒(丏上一世一下丑丂三:  false);
            }
            
            val_2;
            return (int)val_2;
        }
        public object Clone()
        {
            int val_2;
            Rilisoft.GameEventItemData val_1 = new Rilisoft.GameEventItemData();
            if(val_1 != null)
            {
                    .ItemParams = this.ItemParams;
                .BgColor = this.BgColor;
                .DropChance = this.DropChance;
                .ExtSort = this.ExtSort;
                val_2 = this.SubType;
            }
            else
            {
                    mem[40] = this.ItemParams;
                mem[48] = this.BgColor;
                .DropChance = this.DropChance;
                .ExtSort = this.ExtSort;
                val_2 = this.SubType;
            }
            
            .SubType = val_2;
            return (object)val_1;
        }
        public void 七丏丟丈丞丌一丆丒(bool 丏上一世一下丑丂三)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = this.一且丞七丟丌三且且(丏上一世一下丑丂三:  false);
            mem[1152921542106321232] = 0;
            this._calculatedCount = 0;
        }
        private Rilisoft.丝丑丂丛万丐丈丘且 一且丞七丟丌三且且(bool 丏上一世一下丑丂三)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = this.BaseCount;
            Rilisoft.丝丑丂丛万丐丈丘且 val_2 = Rilisoft.丝丑丂丛万丐丈丘且.万丒丌丕万丏不丈世(七丞丙丒三丕且丌丟:  -1155131472);
            return new Rilisoft.丝丑丂丛万丐丈丘且() {七丄不丐丗三丝丑一 = val_2.七丄不丐丗三丝丑一, 丑丒丄下丁丐专丄丞 = val_2.丑丒丄下丁丐专丄丞, 上万三丆专丏丒丗业 = val_2.上万三丆专丏丒丗业};
        }
        public UnityEngine.Texture 丑东丐下专丞丕丘世()
        {
            string val_92;
            var val_93;
            int val_94;
            string val_96;
            var val_97;
            var val_98;
            var val_99;
            string val_100;
            string val_102;
            var val_103;
            var val_104;
            val_92 = this;
            if(this.Type != 500)
            {
                goto label_1;
            }
            
            val_93 = 1152921504624312320;
            val_94 = System.String.alignConst;
            if((System.String.op_Equality(a:  this.Id, b:  "Coins")) == false)
            {
                goto label_2;
            }
            
            if(this.SubType < 1)
            {
                goto label_3;
            }
            
            val_96 = "Textures/Bank/Coins_Shop_{0}";
            goto label_79;
            label_1:
            if(this.Type != 100)
            {
                goto label_5;
            }
            
            val_97 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_92 = this.Id;
            val_98 = 10;
            goto label_105;
            label_2:
            if((System.String.op_Equality(a:  this.Id, b:  "Gems")) == false)
            {
                goto label_8;
            }
            
            if(this.SubType < 1)
            {
                goto label_9;
            }
            
            val_96 = "Textures/Bank/Coins_Shop_Gem_{0}";
            goto label_79;
            label_5:
            if(this.Type != 1300)
            {
                goto label_11;
            }
            
            val_97 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_92 = this.Id;
            val_98 = 20;
            label_105:
            if((val_97.一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  val_92)) == null)
            {
                    return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_102 = val_94);
            }
            
            val_94 = ???;
            val_92 = ???;
            val_93 = ???;
            val_100 = ???;
            goto typeof(PGCompany.丗丟丄丈东丝丕丄世).__il2cppRuntimeField_1C8;
            label_8:
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  val_92.Id)) == false)
            {
                goto label_30;
            }
            
            if(Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == 0)
            {
                goto label_19;
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_19 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世().Context;
            goto label_21;
            label_11:
            if(this.Type != 400)
            {
                goto label_22;
            }
            
            return 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.Id, 七丆丒与丗丌丄且丂:  48, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            label_3:
            val_94 = "OfferIcons/Marathon/bonus_coins";
            goto label_30;
            label_22:
            if(this.Type != 200)
            {
                goto label_26;
            }
            
            val_92 = this.Id;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_25 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  val_92);
            if(val_25 == null)
            {
                    return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_102);
            }
            
            string val_26 = val_25.丙三专万丛丟万丝丘();
            label_72:
            val_103 = 1152921524392989440;
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_102);
            label_9:
            val_94 = "OfferIcons/Marathon/bonus_gems";
            goto label_30;
            label_19:
            if(Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业() == null)
            {
                goto label_55;
            }
            
            label_21:
            val_100 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业().业上丙丞丐丄丆丅七();
            label_55:
            if((System.String.op_Equality(a:  val_100, b:  "halloween")) == false)
            {
                goto label_39;
            }
            
            val_96 = "Textures/Bank/Event/Event_Currency_halloween_{0}";
            goto label_79;
            label_26:
            if(this.Type != 300)
            {
                goto label_41;
            }
            
            val_99 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.Id)) == true)
            {
                    return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_102);
            }
            
            string val_36 = this.Id;
            return 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.Id, 七丆丒与丗丌丄且丂:  48, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            label_39:
            if((System.String.op_Equality(a:  val_100, b:  "homecoming")) == false)
            {
                goto label_48;
            }
            
            val_96 = "Textures/Bank/Event/Event_Currency_homecoming_{0}";
            goto label_79;
            label_41:
            if(this.Type != 600)
            {
                goto label_50;
            }
            
            return 丏丄丑上丛不丈且万.丟丕丟丟丁与一丒丏(丆万一不丌且东丐丐:  this.Id, 与丏丏丁丌与且三专:  new System.Nullable<System.Int32>() {HasValue = false});
            label_48:
            if((System.String.op_Equality(a:  val_100, b:  "4july")) == false)
            {
                goto label_53;
            }
            
            val_96 = "Textures/Bank/Event/Event_Currency_ribbons_{0}";
            goto label_79;
            label_50:
            if(this.Type != 800)
            {
                goto label_56;
            }
            
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  this.Id)) == false)
            {
                goto label_59;
            }
            
            val_92 = this.Id;
            Rilisoft.东且东丒丐世丐丞丒 val_46 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  val_92);
            if(val_46 == null)
            {
                    return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_102);
            }
            
            string val_47 = val_46.丙三专万丛丟万丝丘();
            goto label_72;
            label_53:
            if((System.String.op_Equality(a:  val_100, b:  "christmas2")) == false)
            {
                goto label_63;
            }
            
            val_96 = "Textures/Bank/Event/Event_Currency_christmas_{0}";
            goto label_79;
            label_56:
            if(this.Type != 900)
            {
                goto label_65;
            }
            
            val_102 = "OfferIcons/VIP_universal";
            val_104 = public static UnityEngine.Texture UnityEngine.Resources::Load<UnityEngine.Texture>(string path);
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_102);
            label_63:
            if((System.String.op_Equality(a:  val_100, b:  "new_year2")) == false)
            {
                goto label_67;
            }
            
            val_96 = "Textures/Bank/Event/event_currency_new_year_{0}";
            goto label_79;
            label_59:
            val_100 = Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  this.Id);
            string val_53 = this.Id;
            if(val_100 == false)
            {
                goto label_71;
            }
            
            if((PetInfo.丏且上丒且丂东丂专(世丐丗专丅三丝丑丆:  val_53)) != null)
            {
                goto label_72;
            }
            
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_102);
            label_65:
            if(this.Type != 1000)
            {
                goto label_74;
            }
            
            return 丛且丗丌丏下七下丈.三丗一丄不丆不丏三(丞一丁业丄一一业且:  this.Id);
            label_67:
            if((System.String.op_Equality(a:  val_100, b:  "sniper_tournament")) != true)
            {
                    if((System.String.op_Equality(a:  val_100, b:  "sniper2_roulette")) == false)
            {
                goto label_78;
            }
            
            }
            
            val_96 = "Textures/Bank/Event/Event_Currency_sniper_tournament_{0}";
            goto label_79;
            label_71:
            int val_59 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_53);
            string val_60 = this.Id;
            return 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  this.Id, 七丆丒与丗丌丄且丂:  48, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
            label_74:
            if(this.Type != 1100)
            {
                goto label_83;
            }
            
            string val_63 = this.Id;
            if(PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世() != null)
            {
                goto label_105;
            }
            
            goto label_105;
            label_78:
            val_96 = "Textures/Bank/Event/Event_Currency_{0}";
            label_79:
            val_94 = System.String.Format(format:  val_96, arg0:  System.Math.Max(val1:  val_92 + 108, val2:  1));
            label_30:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_94)) != false)
            {
                    val_100 = val_92.Id;
                val_99 = 0;
                if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  val_100)) == false)
            {
                    return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_102);
            }
            
                val_92 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  val_92.Id);
                val_99 = val_92;
                return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_102);
            }
            
            val_103 = 1152921524392989440;
            return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_102);
            label_83:
            if(this.Type != 1200)
            {
                goto label_94;
            }
            
            string val_82 = this.Id;
            if(PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世() != null)
            {
                goto label_105;
            }
            
            goto label_105;
            label_94:
            if(this.Type != 1400)
            {
                goto label_97;
            }
            
            string val_85 = this.Id;
            if(PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世() != null)
            {
                goto label_105;
            }
            
            goto label_105;
            label_97:
            if(this.Type != 1500)
            {
                goto label_100;
            }
            
            string val_88 = this.Id;
            if(PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世() != null)
            {
                goto label_105;
            }
            
            goto label_105;
            label_100:
            if(this.Type != 1600)
            {
                    return (UnityEngine.Texture)UnityEngine.Resources.Load<UnityEngine.Texture>(path:  val_102);
            }
            
            string val_91 = this.Id;
            if(PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世() != null)
            {
                goto label_105;
            }
            
            goto label_105;
        }
        public string 不丑万世且丗不东丄()
        {
            var val_11;
            var val_12;
            var val_13;
            string val_14;
            string val_15;
            if(this.Type != 500)
            {
                goto label_1;
            }
            
            if((System.String.op_Equality(a:  this.Id, b:  "Coins")) == false)
            {
                goto label_2;
            }
            
            val_11 = this;
            int val_4 = this.Count;
            val_12 = "Key_5030";
            val_13 = "Key_5027";
            goto label_3;
            label_2:
            val_14 = 0;
            if((System.String.op_Equality(a:  this.Id, b:  "Gems")) == false)
            {
                goto label_4;
            }
            
            val_11 = this;
            val_12 = "Key_5031";
            val_13 = "Key_5028";
            label_3:
            val_14 = mem[val_7 > 10 ? val_13 : val_12];
            val_14 = (this.Count > 10) ? (val_13) : (val_12);
            label_4:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_14)) == false)
            {
                goto label_7;
            }
            
            label_1:
            if(this.Type != 1400)
            {
                    return this.与丆业丅上丗七丆一();
            }
            
            val_15 = "Key_4053";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_15 = val_14);
            label_7:
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_15);
        }
        public string 与丆业丅上丗七丆一()
        {
            int val_98;
            int val_99;
            string val_100;
            object val_101;
            object val_102;
            var val_103;
            string val_104;
            var val_105;
            var val_106;
            string val_109;
            var val_110;
            int val_111;
            string val_112;
            var val_113;
            string val_114;
            var val_115;
            val_98 = 1152921504624312320;
            val_99 = System.String.alignConst;
            if(this.Type != 500)
            {
                goto label_1;
            }
            
            if((System.String.op_Equality(a:  this.Id, b:  "Tickets")) == false)
            {
                goto label_2;
            }
            
            val_100 = "{0} {1}";
            val_101 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2986");
            val_102 = this.Count;
            goto label_90;
            label_1:
            if(this.Type != 100)
            {
                goto label_6;
            }
            
            val_103 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_104 = this.Id;
            val_105 = 10;
            goto label_8;
            label_2:
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  this.Id)) == false)
            {
                goto label_9;
            }
            
            val_98 = this.EventId;
            Rilisoft.丛且世丐丆上七业丁 val_12 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丞丅业丕上丂一丂上(丅且三万丘丙业丙丗:  val_98);
            if(val_12 == null)
            {
                    return (string)val_99;
            }
            
            int val_14 = this.Count;
            val_100 = "{0} {1}";
            val_101 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_12.丟万丏且上业丐丈一());
            val_102 = val_14;
            label_90:
            string val_16 = System.String.Format(format:  val_100, arg0:  val_14, arg1:  val_101);
            goto label_96;
            label_6:
            if(this.Type != 1300)
            {
                goto label_17;
            }
            
            val_103 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_104 = this.Id;
            val_105 = 20;
            label_8:
            if((val_103.一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  val_104)) == null)
            {
                goto label_19;
            }
            
            goto label_96;
            label_19:
            val_99 = 0;
            return (string)val_99;
            label_9:
            val_98 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if((val_98.丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  this.Id)) == false)
            {
                    return (string)val_99;
            }
            
            val_105 = 1200;
            val_106 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  this.Id);
            goto label_96;
            label_17:
            if(this.Type != 400)
            {
                goto label_27;
            }
            
            PGCompany.丑丝丟与丘丐丏上三 val_29 = Rilisoft.EggsManager.万万丛世丅下丟丟丅(丈丕丁丘七丙丞不丙:  this.Id);
            if(val_29 == null)
            {
                    return (string)val_99;
            }
            
            string val_30 = val_29.丄丁下丑丛丗丁不丛();
            goto label_48;
            label_27:
            if(this.Type != 200)
            {
                goto label_32;
            }
            
            val_98 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
            Rilisoft.丏丘七丞丄丙丌丞丁 val_34 = val_98.丞丏丆丙丁丒丕与丄(丞丅上丏丂且下丅与:  this.Id);
            if(val_34 == null)
            {
                    return (string)val_99;
            }
            
            string val_36 = val_34.丙丕丞且丕不丘丙丑().丛丈丅丞丏丅丛丛丐();
            goto label_48;
            label_32:
            if(this.Type != 300)
            {
                goto label_37;
            }
            
            label_66:
            val_98 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance;
            if((val_98.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  this.Id)) == null)
            {
                    return (string)val_99;
            }
            
            val_109 = val_40.Lkey;
            val_110 = null;
            goto label_42;
            label_37:
            if(this.Type != 600)
            {
                goto label_43;
            }
            
            val_98 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Values;
            丕丈丏丝丗下丟丅丂 val_45 = System.Linq.Enumerable.FirstOrDefault<丕丈丏丝丗下丟丅丂>(source:  val_98, predicate:  new System.Func<丕丈丏丝丗下丟丅丂, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.GameEventItemData::丈不业丏丗丌七丘专(丕丈丏丝丗下丟丅丂 业七丐世专丝丂丟丈)));
            if(val_45 == null)
            {
                    return (string)val_99;
            }
            
            string val_46 = val_45.丛丈丅丞丏丅丛丛丐();
            goto label_48;
            label_43:
            if(this.Type != 800)
            {
                goto label_49;
            }
            
            if((Rilisoft.FortsManager.东上万与丟丙丅丆不(丞丅上丏丂且下丅与:  this.Id)) == false)
            {
                goto label_52;
            }
            
            val_98 = Rilisoft.Singleton<Rilisoft.FortsManager>.Instance;
            Rilisoft.东且东丒丐世丐丞丒 val_52 = val_98.丒丅丙丄丞丟下丏业(丞丅上丏丂且下丅与:  this.Id);
            if(val_52 == null)
            {
                    return (string)val_99;
            }
            
            label_48:
            val_109 = val_52.东丙上东业丆不丟丘();
            val_110 = null;
            label_42:
            label_96:
            val_99 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_109);
            return (string)val_99;
            label_49:
            if(this.Type != 900)
            {
                goto label_57;
            }
            
            System.TimeSpan val_57 = System.TimeSpan.FromSeconds(value:  (double)this.Count);
            val_111 = System.String.alignConst;
            if(val_57._ticks.Minutes < 1)
            {
                goto label_60;
            }
            
            val_112 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5103");
            double val_60 = val_57._ticks.TotalMinutes;
            goto label_80;
            label_52:
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  this.Id)) == true)
            {
                goto label_66;
            }
            
            string val_66 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  this.Id, 七丆丒与丗丌丄且丂:  丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  this.Id));
            goto label_96;
            label_57:
            if(this.Type != 1000)
            {
                goto label_70;
            }
            
            string val_69 = 丛且丗丌丏下七下丈.七业丑不七丐业丟丂(丞一丁业丄一一业且:  this.Id);
            goto label_96;
            label_70:
            if(this.Type != 1100)
            {
                goto label_74;
            }
            
            val_113 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_114 = this.Id;
            val_115 = 1150;
            goto label_102;
            label_60:
            if(val_57._ticks.Hours < 1)
            {
                goto label_77;
            }
            
            val_112 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5025");
            double val_75 = val_57._ticks.TotalHours;
            goto label_80;
            label_74:
            if(this.Type != 1200)
            {
                goto label_81;
            }
            
            val_113 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_114 = this.Id;
            val_115 = 1160;
            label_102:
            if((val_113.一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  136, 丞丅上丏丂且下丅与:  val_114)) != null)
            {
                goto label_96;
            }
            
            return (string)val_99;
            label_77:
            if(val_57._ticks.Days < 1)
            {
                goto label_85;
            }
            
            val_112 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4040");
            label_80:
            val_111 = System.String.Format(format:  val_112, arg0:  (int)val_57._ticks.TotalDays);
            label_85:
            string val_84 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4041");
            goto label_90;
            label_81:
            if(this.Type != 1400)
            {
                goto label_91;
            }
            
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  170, 丞丅上丏丂且下丅与:  this.Id)) == null)
            {
                    return (string)val_99;
            }
            
            string val_91 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_10641"), arg0:  this.Count);
            goto label_96;
            label_91:
            if(this.Type != 1500)
            {
                goto label_97;
            }
            
            string val_94 = this.Id;
            if(PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世() != null)
            {
                goto label_102;
            }
            
            goto label_102;
            label_97:
            if(this.Type != 1600)
            {
                    return (string)val_99;
            }
            
            string val_97 = this.Id;
            if(PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世() != null)
            {
                goto label_102;
            }
            
            goto label_102;
        }
        public string 丟世三不一下丕丒万()
        {
            string val_64;
            var val_65;
            string val_66;
            var val_67;
            var val_68;
            var val_70;
            string val_71;
            var val_72;
            if(this.Type != 500)
            {
                goto label_1;
            }
            
            if((System.String.op_Equality(a:  this.Id, b:  "Coins")) == false)
            {
                goto label_2;
            }
            
            val_64 = "Key_1835";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64 = "Key_3539");
            label_1:
            if(this.Type != 100)
            {
                goto label_6;
            }
            
            val_65 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_66 = this.Id;
            val_67 = 10;
            goto label_8;
            label_2:
            if((System.String.op_Equality(a:  this.Id, b:  "Gems")) == true)
            {
                goto label_9;
            }
            
            val_68 = null;
            val_68 = null;
            if((System.String.op_Equality(a:  this.Id, b:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝)) == false)
            {
                goto label_12;
            }
            
            label_9:
            val_64 = "Key_1836";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            label_6:
            if(this.Type != 1300)
            {
                goto label_16;
            }
            
            val_65 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_66 = this.Id;
            val_67 = 20;
            label_8:
            if((val_65.一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  val_66)) == null)
            {
                    return 0;
            }
            
            goto typeof(PGCompany.丗丟丄丈东丝丕丄世).__il2cppRuntimeField_218;
            label_16:
            if(this.Type != 400)
            {
                goto label_19;
            }
            
            val_64 = "Key_3397";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            label_12:
            if((System.String.op_Equality(a:  this.Id, b:  "Tickets")) == false)
            {
                goto label_23;
            }
            
            val_64 = "Key_2987";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            label_19:
            if(this.Type != 200)
            {
                goto label_27;
            }
            
            val_64 = "Key_3398";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            label_23:
            if((Rilisoft.丛且世丐丆上七业丁.不丐七且丈丛丘下丄(丏丂不专上丘丂不丅:  this.Id)) == false)
            {
                goto label_31;
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_28 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丞丅业丕上丂一丂上(丅且三万丘丙业丙丗:  this.EventId);
            if(val_28 == null)
            {
                    return 0;
            }
            
            string val_29 = val_28.不丅且万丐专丄丌丂();
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            label_27:
            if(this.Type != 300)
            {
                goto label_37;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            label_31:
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丙丂不东丅丒丄一丐(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  this.Id)) == false)
            {
                    return 0;
            }
            
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  176, 丞丅上丏丂且下丅与:  this.Id)) != null)
            {
                goto typeof(PGCompany.丗丟丄丈东丝丕丄世).__il2cppRuntimeField_218;
            }
            
            goto typeof(PGCompany.丗丟丄丈东丝丕丄世).__il2cppRuntimeField_218;
            label_37:
            if(this.Type == 600)
            {
                    丕丈丏丝丗下丟丅丂 val_41 = System.Linq.Enumerable.FirstOrDefault<丕丈丏丝丗下丟丅丂>(source:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Values, predicate:  new System.Func<丕丈丏丝丗下丟丅丂, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.GameEventItemData::丌丛万丕丗丄丙丟丐(丕丈丏丝丗下丟丅丂 业七丐世专丝丂丟丈)));
                if(val_41 == null)
            {
                    return 0;
            }
            
                string val_42 = val_41.丄东且丘丄丑下丑东();
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            }
            
            if(this.Type == 800)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            }
            
            if(this.Type == 900)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            }
            
            if(this.Type != 1000)
            {
                goto label_61;
            }
            
            int val_47 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  this.Id);
            if((val_47 & 2147483648) != 0)
            {
                    return 0;
            }
            
            if(val_47 <= 180000)
            {
                goto label_65;
            }
            
            if(val_47 == 190000)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            }
            
            if(val_47 == 200000)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            }
            
            if(val_47 != 210000)
            {
                    return 0;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            label_61:
            if(this.Type != 1100)
            {
                goto label_72;
            }
            
            val_70 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_71 = this.Id;
            val_72 = 1150;
            goto label_89;
            label_72:
            if(this.Type != 1200)
            {
                goto label_75;
            }
            
            val_70 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            val_71 = this.Id;
            val_72 = 1160;
            goto label_89;
            label_65:
            if(val_47 == 160000)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            }
            
            if(val_47 == 170000)
            {
                    return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            }
            
            if(val_47 != 180000)
            {
                    return 0;
            }
            
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_64);
            label_75:
            if(this.Type == 1400)
            {
                    val_70 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
                val_71 = this.Id;
                val_72 = 1450;
            }
            else
            {
                    if(this.Type == 1500)
            {
                    val_70 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
                val_71 = this.Id;
                val_72 = 1470;
            }
            else
            {
                    if(this.Type != 1600)
            {
                    return 0;
            }
            
                val_70 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
                val_71 = this.Id;
                val_72 = 1300;
            }
            
            }
            
            label_89:
            if((val_70.一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  val_71)) == null)
            {
                    return 0;
            }
        
        }
        public override string ToString()
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_3 = this.BaseCount;
            return (string)System.String.Format(format:  "id:\'{0}\', type:\'{1}\', count:\'{2}\'", arg0:  this.Id, arg1:  this.Type, arg2:  null);
        }
        public GameEventItemData()
        {
            this.CoinsLimits = new System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>();
            this.GemsCoinsLimits = new System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>();
            this.GemsLimits = new System.Collections.Generic.List<Rilisoft.丝丑丂丛万丐丈丘且>();
        }
        private bool 丈不业丏丗丌七丘专(丕丈丏丝丗下丟丅丂 业七丐世专丝丂丟丈)
        {
            return System.String.op_Equality(a:  业七丐世专丝丂丟丈.业上丙丞丐丄丆丅七(), b:  this.Id);
        }
        private bool 丌丛万丕丗丄丙丟丐(丕丈丏丝丗下丟丅丂 业七丐世专丝丂丟丈)
        {
            return System.String.op_Equality(a:  业七丐世专丝丂丟丈.业上丙丞丐丄丆丅七(), b:  this.Id);
        }
    
    }

}
