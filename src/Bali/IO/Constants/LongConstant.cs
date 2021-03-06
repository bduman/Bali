using System.IO;

namespace Bali.IO.Constants
{
    public class LongConstant : Constant
    {
        public LongConstant(long value)
            : base(ConstantKind.Long) => Value = value;
        
        public long Value
        {
            get;
        }
        
        public static LongConstant Create(Stream stream) => new LongConstant((long) stream.ReadU8());
    }
}