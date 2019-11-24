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

        public string ResolutionDescription { get; set; }

        public string ResolutionActionUpdatedDate { get; set; }

        public string CommunityBoard { get; set; }

        public int BBL { get; set; }

        public string Borough {get; set;}

        [BsonElement("X Coordinate(State Plane)")]
        public int XStatePlane { get; set; }

        [BsonElement("Y Coordinate(State Plane)")]
        public int YStatePlane { get; set; }

        public string OpenDataChannelType { get; set; }

        public string ParkFacilityName { get; set; }

        public string ParkBorough { get; set; }

        public string VehicleType { get; set; }

        public string TaxiCompanyBorough { get; set; }

        public string TaxiPickUpLocation { get; set; }

        public string BridgeHighwayName { get; set; }

        public string BridgeHighwayDirection { get; set; }

        public string RoadRamp { get; set; }

        public string BridgeHighwaySegment { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public string Location { get; set; }
    }
}
