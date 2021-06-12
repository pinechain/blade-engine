using UnityEngine;

using Bladengine.Utils;
using Bladengine.Blind.Base;

namespace Bladengine.Blind.Primitive
{
    [CreateAssetMenu(menuName = "Bladengine/Blind/String Value")]
    public class StringValue : BaseBlindValue<string>
    {
        #region Delegates
        private OnStringValueChanged valueChangeDelegate;
        
        public void subscribe(OnStringValueChanged func) => valueChangeDelegate += func;
        public void unsubscribe(OnStringValueChanged func) => valueChangeDelegate -= func;
        #endregion

        #region Abstraction layer
        protected override void onValueChanged(string finalValue)
        {
            if (valueChangeDelegate != null)
            {
                valueChangeDelegate(finalValue);
            }
        }
        #endregion
    }
}