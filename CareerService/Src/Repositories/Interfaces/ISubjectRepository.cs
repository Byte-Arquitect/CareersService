using careerService.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace careerService.Repositories
{
    public interface ISubjectRepository
    {
        Task<List<Subject>> GetAllSubjectsAsync();
        Task<Dictionary<string, List<string>>> GetPrerequisitesMapAsync();
        Task<Dictionary<string, List<string>>> GetPostrequisitesMapAsync();
        Task<List<SubjectRelationship>> GetAllRelationshipsAsync();
        
    }
}