using System.Collections;

namespace ForestGEO.WebApi.Model.Contracts
{
    public class Tree
    {
        public string Subquadrat { get; set; }
        public string Tag { get; set; }
        public string StemTag { get; set; }
        public string SpCode { get; set; }
        public double DBH { get; set; }
        public string Codes { get; set; }
        public string Comments { get; set; }
    }
}