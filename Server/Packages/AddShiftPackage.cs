﻿using System;
using System.Runtime.Serialization;
using Server.Database;

namespace Server.Packages
{
    [Serializable]
    internal class AddShiftPackage : ISerializable
    {
        public Shift shift;

        public AddShiftPackage()
        {
        }

        private AddShiftPackage(SerializationInfo info, StreamingContext context)
        {
            shift = info.GetValue("Shift", typeof(Shift)) as Shift;
        }

        #region ISerializable Members

        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Shift", shift);
        }

        #endregion
    }
}