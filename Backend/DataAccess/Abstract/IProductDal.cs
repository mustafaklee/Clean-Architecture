﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
        //tamamen IProductDal a özel bir işlem için burası kullanılır.
        //Kendine has özellikler için.
    }
}
