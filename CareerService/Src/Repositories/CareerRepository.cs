using System.Collections.Generic;
using System.Threading.Tasks;
using careerService.Models;
using MongoDB.Driver;

// namespace careerService.Repositories
// {
//     public class CareerRepository : ICareerRepository
//     {
//         private readonly IMongoCollection<Career> _careersCollection;

//         public CareerRepository(IMongoDatabase database)
//         {
//             _careersCollection = database.GetCollection<Career>("Careers");
//         }

//         public async Task<IEnumerable<Career>> GetAllCareersAsync()
//         {
//             return await _careersCollection.Find(_ => true).ToListAsync();
//         }
//     }
// }

using careerService.Data;
using Microsoft.Extensions.Options;

namespace careerService.Repositories
{
    public class CareerRepository : ICareerRepository
    {
        private readonly IMongoCollection<Career> _careersCollection;

        public CareerRepository(IOptions<CareerServiceDbSettings> settings)
        {
            var client = new MongoClient(settings.Value.ConnectionString);
            var database = client.GetDatabase(settings.Value.DatabaseName);
            _careersCollection = database.GetCollection<Career>(settings.Value.CollectionName);
        }

        public async Task<List<Career>> GetAllCareersAsync()
        {
            return await _careersCollection.Find(_ => true).ToListAsync();
        }
    }
}

