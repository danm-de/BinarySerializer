﻿namespace BinarySerialization.Test.Subtype
{
    public class InvalidSubtypeClass
    {
        [FieldOrder(0)]
        public byte Indicator { get; set; }

        [FieldOrder(1)]
        [Subtype("Indicator", 1, typeof (SubclassA))]
        [Subtype("Indicator", 2, typeof (string))]
        public Superclass Superclass { get; set; }
    }
}