using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjectDashboard.Data;
using ProjectDashboard.Models;

namespace ProjectDashboard.Pages.Dashboard.Orders
{
    public class IndexModel : PageModel
    {
        private readonly ProjectDashboard.Data.OrderContext _context;

        public IndexModel(ProjectDashboard.Data.OrderContext context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
        }
    }
}
