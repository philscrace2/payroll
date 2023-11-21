namespace PayrollAdminAdapterGui.events
{
    public class CalledNotImplementedFunctionEvent : Event
    {
        public readonly string functionName;
        public CalledNotImplementedFunctionEvent(String functionName)
        {
            this.functionName = functionName;
        }
    }

}


