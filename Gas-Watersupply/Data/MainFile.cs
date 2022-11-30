namespace Gas_Watersupply.Data
{
    public class MainFile
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }

        public MainFile(string name,string type,int count)
        {
            Name = name;
            Type = type;
            Count = count;
        }

    }
}
