using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace _311Data.Models
{
    public class IssueData
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int UniqueKey { get; set; }

        public string CreatedDate { get; set; }

        public string ClosedDate { get; set; }

        public string Agency { get; set; }

        public string AdencyName { get; set; }

        public string ComplaintType { get; set; }

        public string Descriptor { get; set; }

        public string LocationType { get; set; }

        public int IncidentZip { get; set; }

        public string IncidentAddress { get; set; }

        public string StreetName { get; set; }

        public string CrossStreet1 { get; set; }

        public string IntersectionStreet1 { get; set; }

        public string IntersectionStreet2 { get; set; }

        public string AddressType { get; set; }

        public string City { get; set; }

        public string Landmark { get; set; }

        public string FacilityType { get; set; }

        public string Status { get; set; }

        public string DueDate { get; set; }

    }
}
