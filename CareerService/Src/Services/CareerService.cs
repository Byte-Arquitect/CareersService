using CareersService;
using Grpc.Core;
using careerService.Repositories;

public class CareerService : Careers.CareersBase
{
    private readonly ICareerRepository _repository;

    public CareerService(ICareerRepository repository)
    {
        _repository = repository;
    }

    public override async Task<CareersList> GetAll(Empty request, ServerCallContext context)
    {
        var careersFromDb = await _repository.GetAllCareersAsync();

        var response = new CareersList();
        response.Careers.AddRange(careersFromDb.Select(c => new Career
        {
            Id = c.Id,
            Name = c.Name
        }));

        return response;
    }
}

