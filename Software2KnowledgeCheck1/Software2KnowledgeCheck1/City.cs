namespace Software2KnowledgeCheck1
{
    public class City
    {
        public int ZipCode { get; set; }
        public string Name { get; set; }
        public string State { get; set; }
        public int Population { get; set; }

        public List<Building> Buildings { get; } = new List<Building>();

        
        



    }
}
