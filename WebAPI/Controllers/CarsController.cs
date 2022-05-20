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
    public class CarsController : Controller
    {
        ICarService _carService;
        public CarsController(ICarService carService)
        {
            _carService = carService;
        }

        //Araba nesnesinin tum listesini verir.
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        //Araba nesnesini id'ye gore listesini verir.
        [HttpGet("getbyId")]
        public IActionResult GetById(int id)
        {
            var result = _carService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        //Yeni araba nesnesi eklenir.
        [HttpPost("add")]
        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        //Araba nesnesini siler.
        [HttpDelete("delete")]
        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        //Verilen filtre gore araba nesnelerini siler.
        [HttpDelete("deleteAll")]
        public IActionResult DeleteAll(Expression<Func<Car, bool>> filter)
        {
            var result = _carService.DeleteAll(filter);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        //Araba nesnesinin bilgilerini gunceller.
        [HttpPut("update")]
        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        //Arabalarin verecegimiz min ve max gunluk fiyatlarina gore listeler.
        [HttpGet("getByDailyPrice")]
        public IActionResult GetByDailyPrice(decimal min, decimal max)
        {
            var result = _carService.GetByDailyPrice(min, max);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest();
        }

        //Arabalarin detaylarini listeler.
        [HttpGet("getCarDetails")]
        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest();
        }


    }
}
