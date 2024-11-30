using MongoDB.Driver;
using careerService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace careerService.Repositories
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly IMongoCollection<Subject> _subjects;
        private readonly IMongoCollection<SubjectRelationship> _relationships;

        public SubjectRepository(IMongoDatabase database)
        {
            _subjects = database.GetCollection<Subject>("Subjects");
            _relationships = database.GetCollection<SubjectRelationship>("SubjectRelationship");
        }

        public async Task<List<Subject>> GetAllSubjectsAsync()
        {
            return await _subjects.Find(_ => true).ToListAsync();
        }

        public async Task<List<SubjectRelationship>> GetAllRelationshipsAsync()
        {
            return await _relationships.Find(_ => true).ToListAsync();
        }

        public async Task<Dictionary<string, List<string>>> GetPrerequisitesMapAsync()
        {
            var relationships = await _relationships.Find(_ => true).ToListAsync();
            var map = new Dictionary<string, List<string>>();

            foreach (var relationship in relationships)
            {
                if (!map.ContainsKey(relationship.SubjectCode))
                {
                    map[relationship.SubjectCode] = new List<string>();
                }
                map[relationship.SubjectCode].Add(relationship.PreSubjectCode);
            }

            return map;
        }

        public async Task<Dictionary<string, List<string>>> GetPostrequisitesMapAsync()
        {
            var relationships = await _relationships.Find(_ => true).ToListAsync();
            var map = new Dictionary<string, List<string>>();

            foreach (var relationship in relationships)
            {
                if (!map.ContainsKey(relationship.PreSubjectCode))
                {
                    map[relationship.PreSubjectCode] = new List<string>();
                }
                map[relationship.PreSubjectCode].Add(relationship.SubjectCode);
            }

            return map;
        }
    }
}
