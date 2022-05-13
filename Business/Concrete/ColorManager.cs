using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorService _colorService;
        public ColorManager(IColorService colorService)
        {
            _colorService = _colorService;
        }
        public List<Color> GetAll()
        {
            return _colorService.GetAll();
        }

        public List<Color> GetCarsByColorId(int id)
        {
            return _colorService.Get(c => c.ColorId == id);
        }
    }
}
