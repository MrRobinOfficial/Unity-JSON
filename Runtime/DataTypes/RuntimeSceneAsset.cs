using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace UnityEngine
{
    [System.Serializable]
    [StructLayout(LayoutKind.Sequential)]
    public struct RuntimeSceneAsset : IEquatable<RuntimeSceneAsset>, IFormattable
    {
        public bool Equals(RuntimeSceneAsset other) => throw new NotImplementedException();
        public string ToString(string format, IFormatProvider formatProvider) => throw new NotImplementedException();
    }
}