using UnityEngine;

namespace Rilisoft
{
    public class AreaFog : AreaBase
    {
        // Fields
        private Rilisoft.FogSettings _prevSettings;
        private Rilisoft.SkySettings _prevSkySettings;
        private Rilisoft.FogSettings _settings;
        private Rilisoft.SkySettings _skySettings;
        private System.Threading.CancellationTokenSource 且丂丟丐七上且丗且;
        private float animationTime;
        private bool changeSky;
        
        // Properties
        private bool 丁丟东丁丑三与且万 { get; }
        
        // Methods
        private bool 上丈丟七万且丞丌上()
        {
            UnityEngine.Object val_7;
            var val_8;
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != false)
            {
                    val_8 = 0;
            }
            else
            {
                    val_7 = BankController.丑七不且上丗丁一世();
                if(val_7 == 0)
            {
                    val_8 = 1;
            }
            else
            {
                    val_7 = BankController.丑七不且上丗丁一世();
                bool val_5 = val_7.上丙丆不丂丂丄一丂();
                val_8 = val_5 ^ 1;
            }
            
            }
            
            val_5 = val_8;
            return (bool)val_5;
        }
        protected override void Awake()
        {
            UnityEngine.Material val_3;
            this.Awake();
            this._prevSettings = Rilisoft.FogSettings.且且丘丆三下丂丗下();
            if(this.changeSky == false)
            {
                    return;
            }
            
            if(this._skySettings != null)
            {
                    val_3 = this._skySettings.mat;
            }
            else
            {
                    val_3 = 64;
            }
            
            this._prevSkySettings = this._skySettings.且且丘丆三下丂丗下(丘上专不丂万业不一:  val_3);
        }
        public override void CheckIn(UnityEngine.GameObject 专丂丕丗丗东世丞下)
        {
            mem[1152921542321453184] = 1;
            this.且丂丟丐七上且丗且.Cancel();
            System.Threading.CancellationTokenSource val_1 = new System.Threading.CancellationTokenSource();
            this.且丂丟丐七上且丗且 = val_1;
            System.Threading.CancellationToken val_2 = val_1.Token;
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丗丁丕丗三不业不丕(丑丘万丝且丑丏丄下:  this._settings, 七丐万丁且东丘丙上:  this._skySettings, 丂三丟丂丈丐丆丗丟:  this.animationTime, 不丒三业下丑不丞业:  new System.Threading.CancellationToken() {m_source = val_2.m_source}));
        }
        public override void CheckOut(UnityEngine.GameObject 丈丗与丞一上且上上)
        {
            mem[1152921542321622528] = 0;
            this.且丂丟丐七上且丗且.Cancel();
            System.Threading.CancellationTokenSource val_1 = new System.Threading.CancellationTokenSource();
            this.且丂丟丐七上且丗且 = val_1;
            System.Threading.CancellationToken val_2 = val_1.Token;
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丗丁丕丗三不业不丕(丑丘万丝且丑丏丄下:  this._prevSettings, 七丐万丁且东丘丙上:  this._prevSkySettings, 丂三丟丂丈丐丆丗丟:  this.animationTime, 不丒三业下丑不丞业:  new System.Threading.CancellationToken() {m_source = val_2.m_source}));
        }
        private System.Collections.IEnumerator 丗丁丕丗三不业不丕(Rilisoft.FogSettings 丑丘万丝且丑丏丄下, Rilisoft.SkySettings 七丐万丁且东丘丙上, float 丂三丟丂丈丐丆丗丟, System.Threading.CancellationToken 不丒三业下丑不丞业)
        {
            AreaFog.丄丄不丏丑三不丆一 val_1 = new AreaFog.丄丄不丏丑三不丆一();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .丑丘万丝且丑丏丄下 = 丑丘万丝且丑丏丄下;
                .七丐万丁且东丘丙上 = 七丐万丁且东丘丙上;
                .丂三丟丂丈丐丆丗丟 = 丂三丟丂丈丐丆丗丟;
            }
            else
            {
                    mem[40] = this;
                mem[48] = 丑丘万丝且丑丏丄下;
                mem[56] = 七丐万丁且东丘丙上;
                mem[64] = 丂三丟丂丈丐丆丗丟;
            }
            
            .不丒三业下丑不丞业 = 不丒三业下丑不丞业;
            return (System.Collections.IEnumerator)val_1;
        }
        public AreaFog()
        {
            this.且丂丟丐七上且丗且 = new System.Threading.CancellationTokenSource();
            this.animationTime = 1f;
        }
    
    }

}
