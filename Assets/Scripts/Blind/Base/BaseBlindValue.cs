using UnityEngine;

namespace Bladengine.Blind.Base
{
    public abstract class BaseBlindValue<T> : ScriptableObject {
        #region Encapsulated value
        public T Value
        {
            get => this.value;
            set => changeValue(value);
        }
        [SerializeField] private T value;
        #endregion

        #region Setter
        private void changeValue(T value)
        {
            this.value = value;
            onValueChanged(value);
        }
        #endregion

        #region Abstraction layer
        protected abstract void onValueChanged(T finalValue);
        #endregion
    }
}