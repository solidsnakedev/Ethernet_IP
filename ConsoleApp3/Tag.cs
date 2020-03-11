namespace ConsoleApp3
{
    public class Tag
    {
        public string TagName;
        public string DataType;
        public PLC plc;
        public Tag (PLC plc, string TagName, string DataType)
        {
            this.plc = plc;
            this.TagName = TagName;
            this.DataType = DataType;
        }
    }
}
