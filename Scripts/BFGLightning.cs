using UnityEngine;
internal sealed class BFGLightning : PGBehaviour
{
    // Fields
    private UnityEngine.LineRenderer _lineRenderer;
    private UnityEngine.Transform _endPoint;
    private UnityEngine.Vector3 东下丟丂且上丒丅丒;
    
    // Methods
    internal void 丆世与丑丆丅丐万且()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lineRenderer.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this._endPoint, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丗丙丛万丏丂丑丈丄(UnityEngine.Vector3 丟丄万万丂丝业丁丗)
    {
        this.东下丟丂且上丒丅丒 = 丟丄万万丂丝业丁丗;
        mem[1152921539654313660] = 丟丄万万丂丝业丁丗.y;
        mem[1152921539654313664] = 丟丄万万丂丝业丁丗.z;
        this.一上丝与丕丁一东七();
    }
    internal void 一上丝与丕丁一东七()
    {
        this._endPoint.position = new UnityEngine.Vector3() {x = this.东下丟丂且上丒丅丒, y = V9.16B, z = V10.16B};
        UnityEngine.Vector3 val_2 = this._endPoint.localPosition;
        this._lineRenderer.SetPosition(index:  this._lineRenderer.positionCount - 1, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
    }
    private void 下与丞三丅丛丄七丕()
    {
        UnityEngine.Vector3 val_2 = this._endPoint.localPosition;
        this._lineRenderer.SetPosition(index:  this._lineRenderer.positionCount - 1, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lineRenderer.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this._endPoint, 丏业丟一东丂东丘丛:  true);
    }
    internal void 下与丞三丅丛丄七丕(UnityEngine.Vector3 丟丄万万丂丝业丁丗)
    {
        this.东下丟丂且上丒丅丒 = 丟丄万万丂丝业丁丗;
        mem[1152921539654715196] = 丟丄万万丂丝业丁丗.y;
        mem[1152921539654715200] = 丟丄万万丂丝业丁丗.z;
        this.一上丝与丕丁一东七();
        this.下与丞三丅丛丄七丕();
    }
    public BFGLightning()
    {
    
    }

}
