using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace GoGoProject.Models
{
    public abstract class ItemModel
    {
        public int Id { get; set; }
        public abstract string Name { get; set; }

    }

    public class TypeIP : ItemModel
    {
        public override string Name 
        { 
            get { return "IP"; }
            set { Name = value; }
             
        } //{ get; set = "IP"; } 
    }

    public class TypeOOO : ItemModel
    {
        public override string Name 
        { 
            get { return "OOO"; }
            set { Name = value; }
        }
    }
}
