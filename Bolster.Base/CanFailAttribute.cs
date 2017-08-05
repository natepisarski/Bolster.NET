using System;

namespace Bolster.Base
{
    public class CanFailAttribute : Attribute
    {
        public string FaultReason { get; }
        
        public CanFailAttribute(string faultReason) {
            FaultReason = faultReason;
        } 
    }

    public class CanFailWithAttribute : CanFailAttribute
    {
        public Type FailureType { get; }
        
        public CanFailWithAttribute(Type t, string faultReason) : base(faultReason) {
            FailureType = t;
        }
    }
}