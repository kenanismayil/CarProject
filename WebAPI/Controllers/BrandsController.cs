using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : Controller
    {
        IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        //Brand nesnesinin tum listesini verir.
        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _brandService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        //Brand nesnesini id'ye gore listesini verir.
        [HttpGet("getbyId")]
        public IActionResult GetById(int id)
        {
            var result = _brandService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        //Verilen car id'ye gore brand'leri listeler.
        [HttpGet("getbyCarId")]
        public IActionResult GetByCarId(int id)
        {
            var result = _brandService.GetByCarId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        //Yeni brand nesnesi eklenir.
        [HttpPost("add")]
        public IActionResult Add(Brand brand)
        {
            var result = _brandService.Add(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        //Brand nesnesini siler.
        [HttpDelete("delete")]
        public IActionResult Delete(Brand brand)
        {
            var result = _brandService.Delete(brand);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        //Verilen filtre gore araba nesnelerini siler.
        [HttpDelete("deleteAll")]
        public IActionResult DeleteAll(Expression<Func<Brand, bool>> filter)
        {
            var result = _brandService.DeleteAll(filter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
