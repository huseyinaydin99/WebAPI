using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class BrandDal : IBrandDal
{
    private List<Brand> _brandList;

    public BrandDal()
    {
        _brandList = new List<Brand>();
        _brandList.Add(new Brand("Tofaş"));
        _brandList.Add(new Brand("Renault"));
        _brandList.Add(new Brand("Opel"));
    }

    public void Add(Brand brand)
    {
        _brandList.Add(brand);
    }

    public List<Brand> GetAll()
    {
        return _brandList;
    }
}