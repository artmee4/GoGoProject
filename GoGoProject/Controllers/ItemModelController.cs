using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using GoGoProject.Models;

namespace GoGoProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemModelController : ControllerBase
    {
        public TypeIP typeIP = new TypeIP() { Id = 1 };
        public TypeOOO typeOOO = new TypeOOO() { Id = 2 };

        [HttpGet("Get")]
        public IEnumerable<ItemModel> Get()
        {
            List<ItemModel> drawlist = new();
            drawlist.Add(typeIP);
            drawlist.Add(typeOOO);
            
            return drawlist;
        }

        [HttpGet("GetOneElemet")]
        public ItemModel GetOneElement()
        {
            List<ItemModel> drawlist = new();
            drawlist.Add(typeIP);
            drawlist.Add(typeOOO);
            var a = drawlist[0];
            return a;
        }

    }




}