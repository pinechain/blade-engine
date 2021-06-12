using UnityEngine;

using Bladengine.Utils;
using Bladengine.Blind.Base;

namespace Bladengine.Blind.Primitive
{
    [CreateAssetMenu(menuName = "Bladengine/Blind/Float Value")]
    public class FloatValue : BaseBlindValue<float>
    {
        #region Delegates
        private OnFloatValueChanged valueChangeDelegate;
        
        public void subscribe(OnFloatValueChanged func) => valueChangeDelegate += func;
        public void unsubscribe(OnFloatValueChanged func) => valueChangeDelegate -= func;
        #endregion

        #region Abstraction layer
        protected override void onValueChanged(float finalValue)
        {
            if (valueChangeDelegate != null)
            {
                valueChangeDelegate(finalValue);
            }
        }
        #endregion
    }
}