using UnityEngine;

namespace PGCompany
{
    internal sealed class ConnectSceneRollBackMigrationBannerLocalize : PGBehaviour
    {
        // Fields
        private string keyOldPlayer;
        private string keyNewPlayer;
        private UILabel 七丐丞丑丑丕世丙七;
        private static string 专七丑丙专丅丐万业;
        
        // Methods
        private void Start()
        {
            this.七丐丞丑丑丕世丙七 = this.GetComponent<UILabel>();
        }
        private void OnEnable()
        {
            var val_8;
            this.七丐丞丑丑丕世丙七 = this.GetComponent<UILabel>();
            this.七丐丞丑丑丕世丙七.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  ((System.Version.op_GreaterThanOrEqual(v1:  业丂丏与世一丏业不.一丒三丝三下丑业下(), v2:  new System.Version(major:  18, minor:  0, build:  0))) != true) ? this.keyNewPlayer : this.keyOldPlayer);
            val_8 = null;
            val_8 = null;
            this.七丐丞丑丑丕世丙七.ambigiousFont = 丟丏下丂七三下丗丕.三万丁丂万丆丅下丟(专万与丁丈丐丑丛且:  PGCompany.ConnectSceneRollBackMigrationBannerLocalize.专七丑丙专丅丐万业);
        }
        public ConnectSceneRollBackMigrationBannerLocalize()
        {
        
        }
        private static ConnectSceneRollBackMigrationBannerLocalize()
        {
            PGCompany.ConnectSceneRollBackMigrationBannerLocalize.专七丑丙专丅丐万业 = "Key_04B_03";
        }
    
    }

}
