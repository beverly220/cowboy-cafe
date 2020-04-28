using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;

namespace Website.Pages {
    public class IndexModel : PageModel {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger) {
            _logger = logger;
        }

        /// <summary>
        /// The items to display on the index page 
        /// </summary>
        public IEnumerable<IOrderItem> MenuItems { get; protected set; }

        /// <summary>
        /// The current search terms 
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// The filtered items by type
        /// </summary>
        public string[] Types { get; set; }

        /// <summary>
        /// Gets and sets the minimium calories
        /// </summary>
        public float CaloriesMin { get; set; }

        /// <summary>
        /// Gets and sets the maximum calories
        /// </summary>
        public float CaloriesMax { get; set; }

        /// <summary>
        /// Gets and sets the minimium price
        /// </summary>
        public float PriceMin { get; set; }

        /// <summary>
        /// Gets and sets the maximum price
        /// </summary>
        public float PriceMax { get; set; }

        /// <summary>
        /// Gets the search results for display on the page
        /// </summary>
        public void OnGet(double? PriceMin, double? PriceMax, int? CaloriesMin, int? CalorieMax) {
            SearchTerms = Request.Query["SearchTerms"];
            Types = Request.Query["Types"];
            MenuItems = Menu.Search(SearchTerms);
            MenuItems = Menu.FilterByType(MenuItems, Types);
            MenuItems = Menu.FilterByPrice(MenuItems, PriceMin, PriceMax);
            MenuItems = Menu.FilterByCalories(MenuItems, CaloriesMin, CalorieMax);
            //if(Menu.AllMenuItems.Count() == MenuItems.Count()) {
              //  MenuItems = Enumerable.Empty<IOrderItem>();
            //}
        }
    }
}
