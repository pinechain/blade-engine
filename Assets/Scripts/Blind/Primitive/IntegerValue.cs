using UnityEngine;

using Bladengine.Utils;
using Bladengine.Blind.Base;

namespace Bladengine.Blind.Primitive
{
    [CreateAssetMenu(menuName = "Bladengine/Blind/Integer Value")]
    public class IntegerValue : BaseBlindValue<int>
    {
        #region Delegates
        private OnIntValueChanged valueChangeDelegate;
        
        public void subscribe(OnIntValueChanged func) => valueChangeDelegate += func;
        public void unsubscribe(OnIntValueChanged func) => valueChangeDelegate -= func;
        #endregion

        #region Abstraction layer
        protected override void onValueChanged(int finalValue)
        {
            if (valueChangeDelegate != null)
            {
                valueChangeDelegate(finalValue);
            }
        }
        #endregion
    }
}
