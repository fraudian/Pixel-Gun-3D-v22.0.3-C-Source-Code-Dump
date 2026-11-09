using UnityEngine;

namespace Rilisoft
{
    public class CharactersCorouselItem : MonoBehaviour, 七丌且丛万与丞世丁<Rilisoft.丛且世丐丆上七业丁, Rilisoft.与专丒丞丐一丒丂东>
    {
        // Fields
        private Rilisoft.CharacterHelper 丆丆东专丟丂丈万不;
        private bool 一三丌东世丈丈丅丏;
        private Rilisoft.与专丒丞丐一丒丂东 世丝丞七丅丝丄与三;
        private UnityEngine.GameObject 丑七三丆丐丙丟丈且;
        private bool 丐丌丒丟丐丂万世世;
        private UnityEngine.Coroutine 且丐丘丄且丘七丗丏;
        private Rilisoft.丛且世丐丆上七业丁 <丅丝丌丝丁丏丙东丞>k__BackingField;
        
        // Properties
        public bool 东丝丝专世丁东丗丗 { get; set; }
        public Rilisoft.丛且世丐丆上七业丁 丄丄一丐东丐丝丗七 { get; set; }
        public Rilisoft.与专丒丞丐一丒丂东 丌且丝丘丌丕东丒与 { get; set; }
        
        // Methods
        public bool get_CharacterVisible()
        {
            return (bool)this.一三丌东世丈丈丅丏;
        }
        public void set_CharacterVisible(bool 丙业与丙丗丝不丈东)
        {
            this.一三丌东世丈丈丅丏 = 丙业与丙丗丝不丈东;
            if(this.丆丆东专丟丂丈万不 == 0)
            {
                    return;
            }
            
            this.丆丆东专丟丂丈万不.CharacterVisible = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.丛且世丐丆上七业丁 get_Context()
        {
            return (Rilisoft.丛且世丐丆上七业丁)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.丛且世丐丆上七业丁 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public Rilisoft.与专丒丞丐一丒丂东 get_Parameter()
        {
            return (Rilisoft.与专丒丞丐一丒丂东)this.世丝丞七丅丝丄与三;
        }
        public void set_Parameter(Rilisoft.与专丒丞丐一丒丂东 丙业与丙丗丝不丈东)
        {
            this.世丝丞七丅丝丄与三 = 丙业与丙丗丝不丈东;
            this.丝一丅丆三东丂丞七();
        }
        public void Setup(Rilisoft.丛且世丐丆上七业丁 与且专丈不万东一万, Rilisoft.与专丒丞丐一丒丂东 丆且丁丒丒丆丁三丆)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.世丝丞七丅丝丄与三 = 丆且丁丒丒丆丁三丆;
            this.丝一丅丆三东丂丞七();
            this.丝一丅丆三东丂丞七();
        }
        internal void 丗丏三万东丏世丂丞(string 丛丗丅丆丕丅上丑三, string 丝丁不丝丌三丅且丗)
        {
            this.丝丌丈丆丂万丂丒丆(丛丗丅丆丕丅上丑三:  丛丗丅丆丕丅上丑三, 丈丁丄丘丛世七丙丝:  丝丁不丝丌三丅且丗);
        }
        private void 丝丌丈丆丂万丂丒丆(string 丛丗丅丆丕丅上丑三, string 丈丁丄丘丛世七丙丝)
        {
            string val_18;
            var val_19;
            val_18 = 丛丗丅丆丕丅上丑三;
            val_19 = 1152921504848912384;
            if(this.丆丆东专丟丂丈万不 == 0)
            {
                    Rilisoft.CharacterHelper val_2 = this.GetComponent<Rilisoft.CharacterHelper>();
                this.丆丆东专丟丂丈万不 = val_2;
                if(val_2 == 0)
            {
                    Rilisoft.CharacterHelper val_5 = this.gameObject.AddComponent<Rilisoft.CharacterHelper>();
                this.丆丆东专丟丂丈万不 = val_5;
                val_5.丟丑万与丒与不下丛().丐丟专万与专与丑丛();
            }
            
            }
            
            this.丆丆东专丟丂丈万不.CharacterVisible = true;
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  val_18)) != false)
            {
                    this.丆丆东专丟丂丈万不.丈丑丅上七丑丅一丒(丗上丛丌丅下丙不丙:  val_18, 与丙丁不丆丘丄不丞:  true);
            }
            else
            {
                    val_19 = 1152921505253916672;
                if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_18)) != false)
            {
                    this.丆丆东专丟丂丈万不.丈丑丅上七丑丅一丒(丗上丛丌丅下丙不丙:  val_18, 与丙丁不丆丘丄不丞:  true);
                val_18 = this.丆丆东专丟丂丈万不.丟丑万与丒与不下丛();
                val_18.丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  丈丁丄丘丛世七丙丝);
            }
            else
            {
                    if(((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_18)) != true) && ((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_18)) != false))
            {
                    this.丆丆东专丟丂丈万不.丟丑万与丒与不下丛().丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  val_18);
                if((丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  丈丁丄丘丛世七丙丝)) != null)
            {
                    this.丆丆东专丟丂丈万不.丟丑万与丒与不下丛().丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  丈丁丄丘丛世七丙丝);
                return;
            }
            
            }
            
            }
            
            }
            
            this.丆丆东专丟丂丈万不.SetWeapon(三不三丟专丘东东丂:  丈丁丄丘丛世七丙丝);
        }
        private void OnDisable()
        {
            this.丐丌丒丟丐丂万世世 = false;
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_27;
            Rilisoft.CharacterHelper val_47;
            string val_48;
            val_47 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            if(this.世丝丞七丅丝丄与三 == null)
            {
                    return;
            }
            
            val_48 = 1152921504848912384;
            if((Rilisoft.PetsManager.东与三丘东丑丈丄下(世丐丗专丅三丝丑丆:  this.世丝丞七丅丝丄与三.丅三专且丈一丝丂丏())) != false)
            {
                    if(this.丆丆东专丟丂丈万不 != 0)
            {
                    UnityEngine.Object.Destroy(obj:  this.丆丆东专丟丂丈万不);
                this.丆丆东专丟丂丈万不 = 0;
            }
            
                if(this.且丐丘丄且丘七丗丏 != null)
            {
                    this.StopCoroutine(routine:  this.且丐丘丄且丘七丗丏);
            }
            
                this.且丐丘丄且丘七丗丏 = this.StartCoroutine(routine:  this.丑丞丆专业七丆东万());
                return;
            }
            
            if(this.丆丆东专丟丂丈万不 == 0)
            {
                    Rilisoft.CharacterHelper val_7 = this.GetComponent<Rilisoft.CharacterHelper>();
                this.丆丆东专丟丂丈万不 = val_7;
                if(val_7 == 0)
            {
                    Rilisoft.CharacterHelper val_10 = this.gameObject.AddComponent<Rilisoft.CharacterHelper>();
                this.丆丆东专丟丂丈万不 = val_10;
                val_10.丟丑万与丒与不下丛().丐丟专万与专与丑丛();
            }
            
            }
            
            this.丆丆东专丟丂丈万不.CharacterVisible = (this.一三丌东世丈丈丅丏 == true) ? 1 : 0;
            if(this.丑七三丆丐丙丟丈且 != 0)
            {
                    丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this.丑七三丆丐丙丟丈且);
                this.丑七三丆丐丙丟丈且 = 0;
            }
            
            val_48 = this.世丝丞七丅丝丄与三.丅三专且丈一丝丂丏();
            if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  val_48)) == false)
            {
                goto label_32;
            }
            
            val_47 = this.丆丆东专丟丂丈万不;
            if(val_47 != null)
            {
                goto label_91;
            }
            
            label_92:
            label_91:
            val_47.丈丑丅上七丑丅一丒(丗上丛丌丅下丙不丙:  this.世丝丞七丅丝丄与三.丅三专且丈一丝丂丏(), 与丙丁不丆丘丄不丞:  true);
            return;
            label_32:
            val_48 = this.世丝丞七丅丝丄与三.丅三专且丈一丝丂丏();
            if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_48)) != false)
            {
                    val_48 = this.世丝丞七丅丝丄与三.丅三专且丈一丝丂丏();
                this.丆丆东专丟丂丈万不.丈丑丅上七丑丅一丒(丗上丛丌丅下丙不丙:  val_48, 与丙丁不丆丘丄不丞:  true);
                val_47 = Rilisoft.万丂丕丁三一丒三丞.丗丑专丞专丙丛丟一();
                this.丆丆东专丟丂丈万不.丟丑万与丒与不下丛().丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  val_47);
                return;
            }
            
            List.Enumerator<T> val_25 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.丄三丐丟丗丄丟上丞().GetEnumerator();
            label_67:
            if(((-519531344) & 1) == 0)
            {
                goto label_48;
            }
            
            string val_28 = val_27.丐丏七丌丕丗业且上();
            if(((val_28 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_28.丅三专且丈一丝丂丏())) == true)) || ((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  val_28.丅三专且丈一丝丂丏())) == false))
            {
                goto label_67;
            }
            
            this.丆丆东专丟丂丈万不.丟丑万与丒与不下丛().丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  val_28.丅三专且丈一丝丂丏());
            三丅丁丗丗丝丂万且 val_37 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.世丝丞七丅丝丄与三.丅三专且丈一丝丂丏());
            if(val_37 == null)
            {
                goto label_67;
            }
            
            this.丆丆东专丟丂丈万不.丟丑万与丒与不下丛().丟丞丙一丄世专丟丐(丟丈一下东业一丝丆:  val_37.三与丛丑且丐丈业丌());
            goto label_67;
            label_48:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((0 & 1) != 0)
            {
                    return;
            }
            
            val_48 = System.Linq.Enumerable.FirstOrDefault<丛且专丞丗丆丙丒万>(source:  丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().Values, predicate:  new System.Func<丛且专丞丗丆丙丒万, System.Boolean>(object:  this, method:  System.Boolean Rilisoft.CharactersCorouselItem::丘丂丏丕一东丙一上(丛且专丞丗丆丙丒万 丏丛与丅丛丌万专丌)));
            if(val_48 == null)
            {
                goto label_88;
            }
            
            this.丆丆东专丟丂丈万不.SetWeapon(三不三丟专丘东东丂:  this.世丝丞七丅丝丄与三.丅三专且丈一丝丂丏());
            if(this.丆丆东专丟丂丈万不 != null)
            {
                goto label_91;
            }
            
            goto label_92;
            label_88:
            val_47 = this.世丝丞七丅丝丄与三.丅三专且丈一丝丂丏();
            this.丆丆东专丟丂丈万不.SetWeapon(三不三丟专丘东东丂:  val_47);
        }
        private System.Collections.IEnumerator 丑丞丆专业七丆东万()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new CharactersCorouselItem.丘丅不丌丟丌专丕丝();
        }
        public void SetAnimationEnabled(bool 丆丛丆丞下丅丂且丝)
        {
            if(this.丆丆东专丟丂丈万不 == 0)
            {
                    return;
            }
            
            this.丆丆东专丟丂丈万不.SetAnimationEnabled(丆丛丆丞下丅丂且丝:  丆丛丆丞下丅丂且丝);
        }
        public void SetRotation(UnityEngine.Quaternion 丙丆与丅丈丑一且丏)
        {
            if(this.丆丆东专丟丂丈万不 == 0)
            {
                    return;
            }
            
            this.丆丆东专丟丂丈万不.SetCharacterRotation(专丂丕丗丗东世丞下:  new UnityEngine.Quaternion() {x = 丙丆与丅丈丑一且丏.x, y = 丙丆与丅丈丑一且丏.y, z = 丙丆与丅丈丑一且丏.z, w = 丙丆与丅丈丑一且丏.w});
        }
        public void PlayTapAnimation()
        {
            if(this.丑七三丆丐丙丟丈且 == 0)
            {
                    return;
            }
            
            Rilisoft.PetEngine val_2 = this.丑七三丆丐丙丟丈且.GetComponent<Rilisoft.PetEngine>();
            if(val_2 == 0)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丄丟丑丘丕三七丄丅(丙丂不业且丄丏丞万:  val_2));
        }
        private System.Collections.IEnumerator 丄丟丑丘丕三七丄丅(Rilisoft.PetEngine 丙丂不业且丄丏丞万)
        {
            CharactersCorouselItem.专丑丁丂丈与且丝丞 val_1 = new CharactersCorouselItem.专丑丁丂丈与且丝丞();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丙丂不业且丄丏丞万 = 丙丂不业且丄丏丞万;
            return (System.Collections.IEnumerator)val_1;
        }
        public CharactersCorouselItem()
        {
        
        }
        private bool 丘丂丏丕一东丙一上(丛且专丞丗丆丙丒万 丏丛与丅丛丌万专丌)
        {
            丛且专丞丗丆丙丒万 val_2 = 丏丛与丅丛丌万专丌;
            if(val_2 == null)
            {
                    return false;
            }
            
            val_2 = 丏丛与丅丛丌万专丌.丝丈不丗丐不丙丟丁;
            if(val_2 == null)
            {
                    return false;
            }
            
            return val_2.ContainsValue(value:  this.世丝丞七丅丝丄与三.丅三专且丈一丝丂丏());
        }
    
    }

}
