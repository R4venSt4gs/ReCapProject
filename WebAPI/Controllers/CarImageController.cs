﻿using Business.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carImageService.GetById(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _carImageService.GetAll();
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpGet("getimagesbycarid")]
        public IActionResult GetImagesByCarId(int id)
        {
            var result = _carImageService.GetImagesByCarId(id);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm] CarImage carImage, [FromForm(Name = "Image")] IFormFile file)
        {
            var result = _carImageService.Add(carImage, file);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update([FromForm] CarImage carImage, [FromForm(Name = "Image")] IFormFile file)
        {
            var result = _carImageService.Update(carImage, file);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete([FromForm(Name = "Id")] int id)
        {
            var carImage = _carImageService.GetById(id).Data;
            var result = _carImageService.Delete(carImage);
            if (result.Success) return Ok(result);

            return BadRequest(result);
        }
    }
}