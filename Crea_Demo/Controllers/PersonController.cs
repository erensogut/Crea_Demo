using System.Globalization;
using AutoMapper;
using Crea_Demo.Domain;
using Crea_Demo.Domain.DTO;
using Crea_Demo.Domain.Entities;
using Crea_Demo.Services;
using CsvHelper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Crea_Demo.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class PersonController : ControllerBase
{
    

    private readonly IPersonService _personService;
    private readonly IMapper _mapper;


    public PersonController(IMapper mapper,IPersonService personService)
    {
        _mapper = mapper;
        _personService = personService;
    }


    [HttpGet("GetPerson")]

    public IEnumerable<PersonDTO> Get()
    {
        
        return _mapper.Map<List<PersonDTO>>(_personService.GetPersonList());
    }
    [HttpPost("CreatePerson")]
    public ActionResult<Person> Create(PersonDTO personDTO)
    {
        var person = _mapper.Map<Person>(personDTO);
        _personService.CreatePerson(person);
        return CreatedAtAction("Create", person);
    }
    [HttpPost("EditPerson")]
    public ActionResult<Person> Edit(PersonDTO personDTO)
    {
        var person = _mapper.Map<Person>(personDTO);
        _personService.EditPerson(person);
        return CreatedAtAction("Edit", person);
    }
    [HttpPost("DeletePerson")]
    public ActionResult<string> Delete(int id)
    {
        _personService.DeletePerson(id);
        return "deleted succesfully";
    }
    [HttpPost("BulkUpload")]
    public ActionResult<string> BulkUpload(IFormFile file)
    {
        var fileextension = Path.GetExtension(file.FileName);
        var filename = Guid.NewGuid().ToString() + fileextension;
        var filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "files", filename);
        using (FileStream fs = System.IO.File.Create(filepath))
        {
            file.CopyTo(fs);
        }
        if (fileextension == ".csv")
        {
            using (var reader = new StreamReader(filepath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<Person>();
                foreach (var record in records)
                {

                    if (string.IsNullOrWhiteSpace(record.FirstName))
                    {
                        break;
                    }
                    Person person = new Person();


                    person.FirstName = record.FirstName;
                    person.LastName = record.LastName;
                    person.Occupation = record.Occupation;

                    _personService.CreatePerson(person);

                }
            }
        }
            return "deleted succesfully";
    }
    [HttpGet("SearchPerson")]
    public PagedList<Person> SearchPerson([FromQuery]SearchPersonParameter searchParameter)
    {
        var list = _personService.SearchPerson(searchParameter.FirstName);
        return PagedList<Person>.ToPagedList(list.OrderBy(f => f.FirstName), searchParameter.PageNumber, searchParameter.PageSize);
    }
}

