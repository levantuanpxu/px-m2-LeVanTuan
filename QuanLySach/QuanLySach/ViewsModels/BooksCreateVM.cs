using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLySach.Models;

namespace QuanLySach.ViewsModels
{
    public class BooksCreateVM
    {
        public Books Books { get; set; }
        public IEnumerable<SelectListItem> CategorySelectList { get; set; }
    }
}
