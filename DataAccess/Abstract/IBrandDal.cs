using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IBrandDal : IEntityRepository<Brand>
    {
        List<Brand> GetCarsByBrandId(int brandId);
    }
}
