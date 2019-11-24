using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _311Data.Models;
using MongoDB.Driver;

namespace _311Data.Services
{
    public class DataService
    {
        private readonly IMongoCollection<IssueData> _issueData;

        public DataService(IDataDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _issueData = database.GetCollection<IssueData>(settings.DataCollectionName);
        }
    }
}
