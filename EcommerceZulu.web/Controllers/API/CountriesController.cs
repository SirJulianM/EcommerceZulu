﻿using EcommerceZulu.web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommerceZulu.web.Controllers.API
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCountries()
        {
            return Ok(_context.Countries.Include(c => c.Departments).ThenInclude(d => d.Cities));
        }
    }

}
