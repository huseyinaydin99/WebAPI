using Business.DTOs.Requests;
using Business.DTOs.Responses;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface IBrandService
{
    CreatedBrandResponse Add(CreateBrandRequest brand);
    List<Brand> GetAll();
}
//responses and requests
//yanıtlar için ayrı dto, request için ayrı dto kullanılmalı ikisi içinde aynı dto kullanımı sektörde yaygın bir hatadır.!
