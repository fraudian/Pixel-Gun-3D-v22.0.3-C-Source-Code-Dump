using UnityEngine;

namespace Rilisoft
{
    internal sealed class ClanMembersHeaderViewItem : DynamicWrapGridItem
    {
        // Fields
        public UILabel headerLabel;
        public UILabel countLabel;
        public UITexture icon;
        public Rilisoft.ClanMembersHeaderViewItem.丄丂丏世丛丏万三丆 type;
        private UIBasicSprite _blinkBG;
        private int _blinkIteration;
        private UnityEngine.Color _blinkColor;
        private UnityEngine.Coroutine 丗且三一一三丅丒丟;
        private UnityEngine.Color 下丏丝丒丝与万丂丆;
        private int 下丙三七丛七丏与与;
        
        // Methods
        private void Awake()
        {
            if(this._blinkBG != 0)
            {
                    UnityEngine.Color val_2 = this._blinkBG.color;
            }
            else
            {
                    UnityEngine.Color val_3 = UnityEngine.Color.clear;
            }
            
            this.下丏丝丒丝与万丂丆 = val_3;
            mem[1152921542392949460] = val_3.g;
            mem[1152921542392949464] = val_3.b;
            mem[1152921542392949468] = val_3.a;
            GoblinAutoCollectorUi.且丝一丌丈丅三丛丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClanMembersHeaderViewItem::丙丘与丒七丒丞丗丈()));
        }
        private void OnDestroy()
        {
            GoblinAutoCollectorUi.丟不丌丁丆丝丟东丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.ClanMembersHeaderViewItem::丙丘与丒七丒丞丗丈()));
        }
        public override void UpdateContent(object 三丏丑不业丏不丂丈)
        {
            UITexture val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_21;
            if(三丏丑不业丏不丂丈 == null)
            {
                    return;
            }
            
            var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.一世丑丙丝与丒一丐.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 三丏丑不业丏不丂丈 : 0;
            if(val_1.不业丙丒丂丞下丆丙() <= 2)
            {
                    val_14 = mem[130689456 + (val_2) << 3];
                val_14 = 130689456 + (val_2) << 3;
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.headerLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  System.String.__il2cppRuntimeField_static_fields));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.countLabel, 丕丗丘丑丛与丑业丒:  val_1.丂丁丏一丙丛业且丌());
            if(val_1.不业丙丒丂丞下丆丙() <= 2)
            {
                    val_15 = mem[130689488 + (val_5) << 3];
                val_15 = 130689488 + (val_5) << 3;
            }
            
            UnityEngine.Texture val_6 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.__il2cppRuntimeField_static_fields);
            val_16 = this;
            this.type = val_1.不业丙丒丂丞下丆丙();
            val_13 = this.icon;
            if(val_1.不业丙丒丂丞下丆丙() == 1)
            {
                    UnityEngine.Color val_10 = 丞东丑专丛丆丄丝世.且丁丒丙丞丙丒丈上(一丞万丈丌上丌丛七:  -105381633);
            }
            else
            {
                    UnityEngine.Color val_11 = UnityEngine.Color.white;
            }
            
            val_13.color = new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a};
            if( != 0)
            {
                    val_21 = 0;
            }
            else
            {
                    val_21 = val_1;
            }
            
            this.下丙三七丛七丏与与 = val_21.丂丁丏一丙丛业且丌();
        }
        private string 丙三丁丑丈丆万丈丌(Rilisoft.ClanMembersHeaderViewItem.丄丂丏世丛丏万三丆 丁丅丈丌丟世丗丗丟)
        {
            var val_1;
            if(丁丅丈丌丟世丗丗丟 > 2)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_1 = mem[130689488 + (丁丅丈丌丟世丗丗丟) << 3];
            val_1 = 130689488 + (丁丅丈丌丟世丗丗丟) << 3;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        private string 丛丞丕上丄丟不丝丂(Rilisoft.ClanMembersHeaderViewItem.丄丂丏世丛丏万三丆 丁丅丈丌丟世丗丗丟)
        {
            var val_1;
            if(丁丅丈丌丟世丗丗丟 > 2)
            {
                    return (string)System.String.__il2cppRuntimeField_static_fields;
            }
            
            val_1 = mem[130689456 + (丁丅丈丌丟世丗丗丟) << 3];
            val_1 = 130689456 + (丁丅丈丌丟世丗丗丟) << 3;
            return (string)System.String.__il2cppRuntimeField_static_fields;
        }
        internal static Rilisoft.ClanMembersHeaderViewItem.丄丂丏世丛丏万三丆 且丒丕丕万万世业丗(Rilisoft.ClanMembersHeaderViewItem.丄丂丏世丛丏万三丆 丁丅丈丌丟世丗丗丟)
        {
            if((丁丅丈丌丟世丗丗丟 + 1) > 3)
            {
                    return 0;
            }
            
            return (丄丂丏世丛丏万三丆)106034032 + ((丁丅丈丌丟世丗丗丟 + 1)) << 2;
        }
        internal static Rilisoft.ClanMembersHeaderViewItem.丄丂丏世丛丏万三丆 一世丈丙丐丐丙丈丆(Rilisoft.ClanMembersHeaderViewItem.丄丂丏世丛丏万三丆 丁丅丈丌丟世丗丗丟)
        {
            if((丁丅丈丌丟世丗丗丟 + 1) > 3)
            {
                    return 0;
            }
            
            var val_2 = 106034000;
            val_2 = (106034000 + ((丁丅丈丌丟世丗丗丟 + 1)) << 2) + val_2;
            goto (106034000 + ((丁丅丈丌丟世丗丗丟 + 1)) << 2 + 106034000);
        }
        private void OnDisable()
        {
            if(this.丗且三一一三丅丒丟 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丗且三一一三丅丒丟);
            this.丗且三一一三丅丒丟 = 0;
        }
        internal void 丙丘与丒七丒丞丗丈()
        {
            if(this.type != 0)
            {
                    return;
            }
            
            if(this.丗且三一一三丅丒丟 != null)
            {
                    return;
            }
            
            this.丗且三一一三丅丒丟 = this.StartCoroutine(routine:  this.丛丒丝下业丐丝上七());
        }
        private void 丛三丑且且业丛丏丅()
        {
            if(this.丗且三一一三丅丒丟 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.丗且三一一三丅丒丟);
            this.丗且三一一三丅丒丟 = 0;
        }
        private System.Collections.IEnumerator 丛丒丝下业丐丝上七()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ClanMembersHeaderViewItem.丙丟丒丅世丏丒与上();
        }
        public ClanMembersHeaderViewItem()
        {
            this._blinkIteration = 15;
            UnityEngine.Color val_1 = UnityEngine.Color.magenta;
            this._blinkColor = val_1;
            mem[1152921542394398520] = val_1.g;
            mem[1152921542394398524] = val_1.b;
            mem[1152921542394398528] = val_1.a;
            this.下丙三七丛七丏与与 = 0;
        }
    
    }

}
