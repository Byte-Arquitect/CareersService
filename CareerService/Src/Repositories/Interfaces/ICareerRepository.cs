using careerService.Models;

namespace careerService.Repositories
{
    public interface ICareerRepository
    {
         Task<List<Career>> GetAllCareersAsync();
    }
}

