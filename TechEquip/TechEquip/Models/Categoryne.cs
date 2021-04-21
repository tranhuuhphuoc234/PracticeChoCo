using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TechEquip.Models.ModelView;

namespace TechEquip.Models
{
    public class Categoryne
    {
        public List<CategoryView> GetAll() {
            Entity.Information_EquipmentEntities db = new Entity.Information_EquipmentEntities();
            var q = db.Categories.Where(d => d.active == true).Select(d => new CategoryView { id=d.id,name = d.name_category, active = d.active ?? false }).ToList();
            return q;
        }
    }
}