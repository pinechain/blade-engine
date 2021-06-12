using UnityEngine;

using Bladengine.Utils;
using Bladengine.Blind.Base;

namespace Bladengine.Blind.Primitive
{
    [CreateAssetMenu(menuName = "Bladengine/Blind/Double Value")]
    public class DoubleValue : BaseBlindValue<double>
    {
        #region Delegates
        private OnDoubleValueChanged valueChangeDelegate;
        
        public void subscribe(OnDoubleValueChanged func) => valueChangeDelegate += func;
        public void unsubscribe(OnDoubleValueChanged func) => valueChangeDelegate -= func;
        #endregion

        #region Abstraction layer
        protected override void onValueChanged(double finalValue)
        {
            if (valueChangeDelegate != null)
            {
                valueChangeDelegate(finalValue);
            }
        }
        #endregion
    }
}