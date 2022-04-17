using AutoMapper;
using Crea_Demo.Domain;
using Crea_Demo.Services;
using Microsoft.AspNetCore.Mvc;

namespace Crea_Demo.Controllers;

[ApiController]
[Route("[controller]")]
public class AssignController : ControllerBase
{
    

    private readonly ILogger<AssignController> _logger;
    private readonly ICommunityService _communityService;
    private readonly IMapper _mapper;


    public AssignController(ILogger<AssignController> logger,ICommunityService communityService, IMapper mapper)
    {
        _logger = logger;
        _communityService = communityService;
        _mapper = mapper;

    }



    [HttpPost("AddPersonToCommunity")]
    public ActionResult<EnrolmentDTO> AddPerson([FromQuery]EnrolmentDTO enrolmentDTO)
    {
        var enrolment = _mapper.Map<Enrolment>(enrolmentDTO);
        _communityService.AddPersonToCommunity(enrolment);
        return CreatedAtAction("AddPerson", enrolment);
    }
    [HttpPost("DeletePersonToCommunity")]
    public ActionResult<string> DeletePerson([FromQuery] EnrolmentDTO enrolmentDTO)
    {
        var enrolment = _mapper.Map<Enrolment>(enrolmentDTO);
        _communityService.DeletePersonToCommunity(enrolment);
        return "deleted succesfully";
    }

}

