using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Models
{
    public class BaseModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Girmek Zorunlu")]
        public string Name { get; set; }
    }
}
