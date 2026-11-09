using UnityEngine;

namespace PGCompany
{
    internal sealed class PixelPassMigrationBanner : PGBehaviour
    {
        // Fields
        private System.Collections.Generic.List<UnityEngine.GameObject> _slides;
        private UnityEngine.GameObject _buttonNext;
        private UnityEngine.GameObject _buttonSweet;
        private int 丅丂丘丙一丝丐丅世;
        
        // Methods
        internal void 下与丞三丅丛丄七丕()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  true);
            this.丅丂丘丙一丝丐丅世 = 0;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            var val_7;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonNext, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonSweet, 丏业丟一东丂东丘丛:  false);
            val_7 = null;
            val_7 = null;
            if((PixelPassMigrationBanner.<>c.<>9__5_0) == null)
            {
                goto label_5;
            }
            
            label_16:
            this._slides.ForEach(action:  PixelPassMigrationBanner.<>c.<>9__5_0);
            if(this.丅丂丘丙一丝丐丅世 >= this._slides.Count)
            {
                    return;
            }
            
            var val_7 = this._slides.Count;
            val_7 = val_7 - 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._slides.Item[this.丅丂丘丙一丝丐丅世], 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonNext, 丏业丟一东丂东丘丛:  (this.丅丂丘丙一丝丐丅世 != val_7) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonSweet, 丏业丟一东丂东丘丛:  (this.丅丂丘丙一丝丐丅世 == val_7) ? 1 : 0);
            return;
            label_5:
            PixelPassMigrationBanner.<>c.<>9__5_0 = new System.Action<UnityEngine.GameObject>(object:  PixelPassMigrationBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PixelPassMigrationBanner.<>c::一丐且丑世丝不丆丒(UnityEngine.GameObject 专业业丆丄丄丗七丙));
            if(this._slides != null)
            {
                goto label_16;
            }
            
            goto label_16;
        }
        public void U_Next()
        {
            int val_1 = this.丅丂丘丙一丝丐丅世;
            val_1 = val_1 + 1;
            this.丅丂丘丙一丝丐丅世 = val_1;
            this.丝一丅丆三东丂丞七();
        }
        public void U_Hide()
        {
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().世丏丙且丒丗丆丐丂(业丄七丙丛上专专丕:  87);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  false);
        }
        public PixelPassMigrationBanner()
        {
            this._slides = new System.Collections.Generic.List<UnityEngine.GameObject>();
        }
    
    }

}
