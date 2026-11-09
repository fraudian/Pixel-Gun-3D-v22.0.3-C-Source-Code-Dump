using UnityEngine;
internal sealed class TapOnTankPointGesture : TapGesture
{
    // Methods
    private void Update()
    {
        UnityEngine.Object val_8 = this;
        if((UnityEngine.Input.GetKeyDown(key:  67)) == false)
        {
                return;
        }
        
        val_8 = this.丈丌丑丑且丘万丏业<ClanTankPlaceableItemPoint>();
        if(val_8 == 0)
        {
                return;
        }
        
        val_8 = ???;
        goto typeof(ClanTankPlaceableItemPoint).__il2cppRuntimeField_198;
    }
    protected override void 世七七业业丘与丂丕(UnityEngine.Touch 丟下丙丆不东一与丅)
    {
        UnityEngine.Object val_7;
        72771.世七七业业丘与丂丕(丟下丙丆不东一与丅:  new UnityEngine.Touch() {m_FingerId = 丟下丙丆不东一与丅.m_FingerId, m_Position = new UnityEngine.Vector2() {x = 丟下丙丆不东一与丅.m_Position.x, y = 丟下丙丆不东一与丅.m_Position.y}, m_RawPosition = new UnityEngine.Vector2() {x = 丟下丙丆不东一与丅.m_RawPosition.x, y = 丟下丙丆不东一与丅.m_RawPosition.y}, m_PositionDelta = new UnityEngine.Vector2() {x = 丟下丙丆不东一与丅.m_PositionDelta.x, y = 丟下丙丆不东一与丅.m_PositionDelta.y}, m_TimeDelta = 丟下丙丆不东一与丅.m_TimeDelta, m_TapCount = 丟下丙丆不东一与丅.m_TapCount, m_Phase = 丟下丙丆不东一与丅.m_Phase, m_Type = 丟下丙丆不东一与丅.m_Type, m_Pressure = 丟下丙丆不东一与丅.m_Pressure, m_maximumPossiblePressure = 丟下丙丆不东一与丅.m_maximumPossiblePressure, m_Radius = 丟下丙丆不东一与丅.m_Radius, m_RadiusVariance = 丟下丙丆不东一与丅.m_RadiusVariance, m_AltitudeAngle = 丟下丙丆不东一与丅.m_AltitudeAngle, m_AzimuthAngle = 丟下丙丆不东一与丅.m_AzimuthAngle});
        val_7 = this.丈丌丑丑且丘万丏业<ClanTankPlaceableItemPoint>();
        if(val_7 == 0)
        {
                return;
        }
        
        val_7 = ???;
        goto typeof(ClanTankPlaceableItemPoint).__il2cppRuntimeField_198;
    }
    private T 丈丌丑丑且丘万丏业<T>()
    {
        float val_4;
        float val_5;
        System.Collections.Generic.IEnumerable<TSource> val_20;
        var val_21;
        System.Func<T, TResult> val_22;
        var val_23;
        var val_24;
        UnityEngine.Object val_25;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        UnityEngine.Ray val_3 = UnityEngine.Camera.main.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.RaycastHit[] val_6 = UnityEngine.Physics.RaycastAll(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = val_5, y = val_5, z = val_5}, m_Direction = new UnityEngine.Vector3() {x = val_5, y = val_4, z = val_4}});
        val_20 = val_6;
        if((System.Linq.Enumerable.Any<UnityEngine.RaycastHit>(source:  val_6)) != false)
        {
                val_21 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_21 = __RuntimeMethodHiddenParam + 48 + 294;
            if((val_21 & 1) == 0)
        {
                val_21 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_21 = __RuntimeMethodHiddenParam + 48 + 294;
        }
        
            val_22 = mem[__RuntimeMethodHiddenParam + 48 + 184 + 8];
            val_22 = __RuntimeMethodHiddenParam + 48 + 184 + 8;
            if(val_22 == 0)
        {
                val_23 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_23 = __RuntimeMethodHiddenParam + 48 + 294;
            if((val_23 & 1) == 0)
        {
                val_23 = mem[__RuntimeMethodHiddenParam + 48 + 294];
            val_23 = __RuntimeMethodHiddenParam + 48 + 294;
        }
        
            System.Func<UnityEngine.RaycastHit, System.Single> val_8 = null;
            val_22 = val_8;
            val_8 = new System.Func<UnityEngine.RaycastHit, System.Single>(object:  __RuntimeMethodHiddenParam + 48 + 184, method:  __RuntimeMethodHiddenParam + 48 + 8);
            mem2[0] = val_22;
        }
        
            val_20 = System.Linq.Enumerable.ToArray<UnityEngine.RaycastHit>(source:  System.Linq.Enumerable.OrderBy<UnityEngine.RaycastHit, System.Single>(source:  val_20, keySelector:  val_8));
        }
        
        val_24 = 0;
        goto label_17;
        label_38:
        if( == 0)
        {
            goto label_21;
        }
        
        val_25 = gameObject;
        if(val_25 != 0)
        {
                return (ClanTankPlaceableItemPoint)val_25;
        }
        
        if((gameObject.GetComponent<UIWidgetContainer>()) != 0)
        {
            goto label_36;
        }
        
        if((gameObject.GetComponent<UIBasicSprite>()) != 0)
        {
            goto label_36;
        }
        
        label_21:
        val_24 = 1;
        label_17:
        if(val_24 < val_10.Length)
        {
            goto label_38;
        }
        
        label_36:
        val_25 = 0;
        return (ClanTankPlaceableItemPoint)val_25;
    }
    public TapOnTankPointGesture()
    {
        mem[1152921536920818124] = 1036831949;
        val_1 = new BaseGesture();
    }

}
