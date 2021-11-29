using North_DbFirst.Models;
using North_DbFirst.Models.ViewModel;

namespace North_DbFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private NorthwindContext _dbContext = new NorthwindContext();
        private void Form1_Load(object sender, EventArgs e)
        {
            var query1 = _dbContext.Categories.Select(x=>new CategoryViewModel()
            {
                CategoryName = x.CategoryName,
                Description=x.Description,
                Picture=x.Picture,
                ProductionCount=x.Products.Count
            }).ToList();
            dgvNorth.DataSource = query1;

            var query2 = from cat in _dbContext.Categories
                         join prod in _dbContext.Products on cat.CategoryId equals prod.CategoryId
                         where prod.UnitPrice > 20
                         select new
                         {
                             cat.CategoryName,
                             prod.ProductName,
                             prod.UnitPrice
                         };
            dgvNorth.DataSource = query2
                .OrderBy(x => x.CategoryName)
                .ThenByDescending(x => x.UnitPrice)
                .ToList();

        }
    }
}