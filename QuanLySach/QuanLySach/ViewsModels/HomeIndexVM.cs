using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using QuanLySach.Models;

namespace QuanLySach.ViewsModels
{
    public class HomeIndexVM
    {
 
        public List<Books> Books { get; set; }
        public IEnumerable<Category> Categories { get; set; }
  
}
}
