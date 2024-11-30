using CareersService;
using careerService.Models;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System.Linq;
using System.Threading.Tasks;
using careerService.Repositories;

public class SubjectGrpcService : SubjectService.SubjectServiceBase
{
    private readonly careerService.Services.SubjectService _subjectService;

    public SubjectGrpcService(careerService.Services.SubjectService subjectService)
    {
        _subjectService = subjectService;
    }


    public override async Task<SubjectList> GetAllSubjects(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
    {
        var subjectsFromDb = await _subjectService.GetAllSubjectsAsync();

        var response = new SubjectList();
        response.Subjects.AddRange(subjectsFromDb.Select(s => new CareersService.Subject
        {
            Id = s.Id,
            Code = s.Code,
            Name = s.Name,
            Department = s.Department,
            Credits = s.Credits,
            Semester = s.Semester
        }));

        return response;
    }

    public override async Task<PrerequisitesMap> GetPrerequisitesMap(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
    {
        var map = await _subjectService.GetPrerequisitesMapAsync();
        var response = new PrerequisitesMap();
        foreach (var entry in map)
        {
            response.Map.Add(entry.Key, new Prerequisites { Prereqs = { entry.Value } });
        }
        return response;
    }

    public override async Task<PostrequisitesMap> GetPostrequisitesMap(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
    {
        var map = await _subjectService.GetPostrequisitesMapAsync();
        var response = new PostrequisitesMap();
        foreach (var entry in map)
        {
            response.Map.Add(entry.Key, new Postrequisites { Postreqs = { entry.Value } });
        }
        return response;
    }

    public override async Task<SubjectRelationships> GetPrerequisiteObjects(Google.Protobuf.WellKnownTypes.Empty request, ServerCallContext context)
    {
        var relationships = await _subjectService.GetAllRelationshipsAsync();
        return new SubjectRelationships
        {
            Relationships = { relationships.Select(r => new CareersService.SubjectRelationship
            {
                Id = r.Id,
                SubjectCode = r.SubjectCode,
                PreSubjectCode = r.PreSubjectCode
            }) }
        };
    }
}

       


