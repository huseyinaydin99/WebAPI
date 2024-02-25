using Business.Abstracts;
using Business.DTOs.Requests;
using Business.DTOs.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BrandsController : ControllerBase
{
    private readonly IBrandService _brandService;

    public BrandsController(IBrandService brandService)
    {
        _brandService = brandService;
    }

    [HttpPost]
    public IActionResult Add(CreateBrandRequest request)
    {
        CreatedBrandResponse response = _brandService.Add(request);
        return Created("",response);
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_brandService.GetAll());
    }
}