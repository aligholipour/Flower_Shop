using Flower_Shop.Models.Entities;
using Microsoft.AspNetCore.Mvc.Razor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flower_Shop.Common
{
    public abstract class FlowerViewBase : RazorPage<IEnumerable<Flower>>
    {
        public int Count => Model.Count();
    }
}
