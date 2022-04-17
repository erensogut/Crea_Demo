using AutoMapper;
using Crea_Demo.Domain;
using Crea_Demo.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crea_Demo.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CommunityController : ControllerBase
{
    

    private readonly ILogger<CommunityController> _logger;
    private readonly ICommunityService _communityService;
    private readonly IMapper _mapper;


    public CommunityController(ILogger<CommunityController> logger,ICommunityService communityService, IMapper mapper)
    {
        _logger = logger;
        _communityService = communityService;
        _mapper = mapper;
    }

    
    [HttpGet(Name = "GetCommunity")]

    public IEnumerable<CommunityDTO> Get()
    {
        
        return _mapper.Map<List<CommunityDTO>>(_communityService.GetCommunityList());

    }
    [HttpGet(Name = "GetCommunityWithPerson")]
    public CommunityWithPersonDTO GetCommunityWithPerson(int id)
    {
        return (_communityService.GetCommunityWithPerson(id));

    }
    [HttpPost("CreateCommunity")]
    public ActionResult<Person> Create(CommunityDTO communityDTO)
    {
        var community = _mapper.Map<Community>(communityDTO);
        _communityService.CreateCommunity(community);
        return CreatedAtAction("Create", community);
    }
    [HttpPost("EditCommunity")]
    public ActionResult<Person> Edit(CommunityDTO communityDTO)
    {
        var community = _mapper.Map<Community>(communityDTO);
        _communityService.EditCommunity(community);
        return CreatedAtAction("Edit", community);
    }
    [HttpPost("DeleteCommunity")]
    public ActionResult<string> Delete(int id)
    {
        _communityService.DeleteCommunity(id);
        return "deleted succesfully";
    }
}

