﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetCarsByColorId(int id);
        void Add(Color id);
        void Delete(Color id);

    }
}
