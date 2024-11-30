using careerService.Models;
using careerService.Repositories;

namespace careerService.Services
{

    public class SubjectService
    {
        private readonly ISubjectRepository _repository;

        public SubjectService(ISubjectRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Subject>> GetAllSubjectsAsync()
        {
            return await _repository.GetAllSubjectsAsync();
        }

        public async Task<Dictionary<string, List<string>>> GetPrerequisitesMapAsync()
        {
            var relationships = await _repository.GetAllRelationshipsAsync();
            return relationships
                .GroupBy(r => r.SubjectCode)
                .ToDictionary(g => g.Key, g => g.Select(r => r.PreSubjectCode).ToList());
        }

        public async Task<Dictionary<string, List<string>>> GetPostrequisitesMapAsync()
        {
            var relationships = await _repository.GetAllRelationshipsAsync();
            return relationships
                .GroupBy(r => r.PreSubjectCode)
                .ToDictionary(g => g.Key, g => g.Select(r => r.SubjectCode).ToList());
        }

        public async Task<List<SubjectRelationship>> GetAllRelationshipsAsync()
        {
            return await _repository.GetAllRelationshipsAsync();
        }
    }
}
