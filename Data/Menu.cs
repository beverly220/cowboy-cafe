using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CowboyCafe.Data {
    public class Menu {
        public static IEnumerable<IOrderItem> AllMenuItems {
            get {
                List<IOrderItem> all = new List<IOrderItem>();
                foreach (IOrderItem o in Entrees) {
                    all.Add(o);
                }
                foreach (IOrderItem o in Sides) {
                    all.Add(o);
                }
                foreach (IOrderItem o in Drinks) {
                    all.Add(o);
                }
                return all;
            }
        }

        /// <summary>
        /// Gets all entrees
        /// </summary>
        public static IEnumerable<IOrderItem> Entrees { 
            get {
                List<IOrderItem> entrees = new List<IOrderItem>();
                entrees.Add(new AngryChicken());
                entrees.Add(new CowpokeChili());
                entrees.Add(new DakotaDoubleBurger());
                entrees.Add(new PecosPulledPork());
                entrees.Add(new RustlersRibs());
                entrees.Add(new TexasTripleBurger());
                entrees.Add(new TrailBurger());
                return entrees; 
            } 
        }

        /// <summary>
        /// Searches the database for matching food
        /// </summary>
        /// <param name="terms">The terms to search for</param>
        /// <returns>A collection of movies</returns>
        public static IEnumerable<IOrderItem> Search(string terms) {
            List<IOrderItem> results = new List<IOrderItem>();
            if (terms == null) return AllMenuItems;
            foreach (IOrderItem entree in Entrees) {
                if (entree.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase)) {
                    results.Add(entree);
                }
            }
            foreach (IOrderItem side in Sides) {
                if (side.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase)) {
                    results.Add(side);
                }
            }
            foreach (IOrderItem drink in Drinks) {
                if (drink.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase)) {
                    results.Add(drink);
                }
            }
            return results;
        }

        /// <summary>
        /// Gets the possible order types
        /// </summary>
        public static string[] EntreeSideDrink {
            get => new string[]
            {
            "Entree",
            "Side",
            "Drink"
            };
        }

        /// <summary>
        /// Filters the provided collection of order
        /// </summary>
        /// <param name="items">The collection of items to filter</param>
        /// <param name="types">The types to include</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByType(IEnumerable<IOrderItem> items, IEnumerable<string> types) {
            if (types == null || types.Count() == 0) {
                return items;
            }
            List<IOrderItem> results = new List<IOrderItem>();
            foreach (IOrderItem item in items) {
                if (types.Contains("Entree") && item is Entree) {
                    results.Add(item);
                }
                if (types.Contains("Side") && item is Side) {
                    results.Add(item);
                }
                if (types.Contains("Drink") && item is Drink) {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of menu
        /// items by the given maximum and minimum
        /// calories searched
        /// </summary>
        /// <param name="items">The collection of ordered items
        /// to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu selection</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max) {
            if ((min == null && max == null) || (min == 0 && max == 0) || (min == 10 && max == 10)) return items;
            var results = new List<IOrderItem>();
            if (min == null || min == 0) {
                foreach (IOrderItem item in items) {
                    if (item.Calories <= max) {
                        results.Add(item);
                    }
                }
                return results;
            }
            if (max == null || max == 0) {
                foreach (IOrderItem item in items) {
                    if (item.Calories >= min) {
                        results.Add(item);
                    }
                }
                return results;
            }
            foreach (IOrderItem item in items) {
                if (item.Calories >= min && item.Calories <= max) {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the provided collection of menu
        /// items by the given maximum and minimum
        /// price searched
        /// </summary>
        /// <param name="items">The collection of ordered items
        /// to filter</param>
        /// <param name="min">The minimum range value</param>
        /// <param name="max">The maximum range value</param>
        /// <returns>The filtered menu selection</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max) {
            if ((min == null && max == null) || (min == 0 && max == 0)) return items;
            var results = new List<IOrderItem>();
            if (min == null || min == 0) {
                foreach (IOrderItem item in items) {
                    if (item.Price <= max) {
                        results.Add(item);
                    }
                }
                return results;
            }
            if (max == null || max == 0) {
                foreach (IOrderItem item in items) {
                    if (item.Price >= min) {
                        results.Add(item);
                    }
                }
                return results;
            }
            foreach (IOrderItem item in items) {
                if (item.Price >= min && item.Calories <= max) {
                    results.Add(item);
                }
            }
            
            return results;
        }

        /// <summary>
        /// Gets all entrees
        /// </summary>
        public static IEnumerable<Side> Sides {
            get {
                List<Side> sides = new List<Side>();
                BakedBeans sBB = new BakedBeans();
                sBB.Size = Size.Small;
                sides.Add(sBB);
                BakedBeans mBB = new BakedBeans();
                mBB.Size = Size.Medium;
                sides.Add(mBB);
                BakedBeans lBB = new BakedBeans();
                lBB.Size = Size.Large;
                sides.Add(lBB);

                ChiliCheeseFries sCCF = new ChiliCheeseFries();
                sCCF.Size = Size.Small;
                sides.Add(sCCF);
                ChiliCheeseFries mCCF = new ChiliCheeseFries();
                mCCF.Size = Size.Medium;
                sides.Add(mCCF);
                ChiliCheeseFries lCCF = new ChiliCheeseFries();
                lCCF.Size = Size.Large;
                sides.Add(lCCF);

                CornDodgers sCD = new CornDodgers();
                sCD.Size = Size.Small;
                sides.Add(sCD);
                CornDodgers mCD = new CornDodgers();
                mCD.Size = Size.Medium;
                sides.Add(mCD);
                CornDodgers lCD = new CornDodgers();
                lCD.Size = Size.Large;
                sides.Add(lCD);

                PanDeCampo sPDC = new PanDeCampo();
                sPDC.Size = Size.Small;
                sides.Add(sPDC);
                PanDeCampo mPDC = new PanDeCampo();
                mPDC.Size = Size.Medium;
                sides.Add(mPDC);
                PanDeCampo lPDC = new PanDeCampo();
                lPDC.Size = Size.Large;
                sides.Add(lPDC);
                return sides;
            }
        }

        /// <summary>
        /// Gets all entrees
        /// </summary>
        public static IEnumerable<Drink> Drinks {
            get {
                List<Drink> drinks = new List<Drink>();

                CowboyCoffee sCC = new CowboyCoffee();
                sCC.Size = Size.Small;
                drinks.Add(sCC);
                CowboyCoffee mCC = new CowboyCoffee();
                mCC.Size = Size.Medium;
                drinks.Add(mCC);
                CowboyCoffee lCC = new CowboyCoffee();
                lCC.Size = Size.Large;
                drinks.Add(lCC);

                JerkedSoda sJS = new JerkedSoda();
                sJS.Size = Size.Small;
                sJS.Flavor = SodaFlavor.BirchBeer;
                drinks.Add(sJS);
                JerkedSoda mJS = new JerkedSoda();
                mJS.Size = Size.Medium;
                mJS.Flavor = SodaFlavor.BirchBeer;
                drinks.Add(mJS);
                JerkedSoda lJS = new JerkedSoda();
                lJS.Size = Size.Large;
                lJS.Flavor = SodaFlavor.BirchBeer;
                drinks.Add(lJS);

                sJS.Flavor = SodaFlavor.RootBeer;
                drinks.Add(sJS);
                mJS.Flavor = SodaFlavor.RootBeer;
                drinks.Add(mJS);
                lJS.Flavor = SodaFlavor.RootBeer;
                drinks.Add(lJS);

                sJS.Flavor = SodaFlavor.CreamSoda;
                drinks.Add(sJS);
                mJS.Flavor = SodaFlavor.CreamSoda;
                drinks.Add(mJS);
                lJS.Flavor = SodaFlavor.CreamSoda;
                drinks.Add(lJS);

                sJS.Flavor = SodaFlavor.OrangeSoda;
                drinks.Add(sJS);
                mJS.Flavor = SodaFlavor.OrangeSoda;
                drinks.Add(mJS);
                lJS.Flavor = SodaFlavor.OrangeSoda;
                drinks.Add(lJS);

                sJS.Flavor = SodaFlavor.Sarsparilla;
                drinks.Add(sJS);
                mJS.Flavor = SodaFlavor.Sarsparilla;
                drinks.Add(mJS);
                lJS.Flavor = SodaFlavor.Sarsparilla;
                drinks.Add(lJS);

                TexasTea sTT = new TexasTea();
                sTT.Size = Size.Small;
                drinks.Add(sTT);
                TexasTea mTT = new TexasTea();
                mTT.Size = Size.Medium;
                drinks.Add(mTT);
                TexasTea lTT = new TexasTea();
                lTT.Size = Size.Large;
                drinks.Add(lTT);

                Water sW = new Water();
                sW.Size = Size.Small;
                drinks.Add(sW);
                Water mW = new Water();
                mW.Size = Size.Medium;
                drinks.Add(mW);
                Water lW = new Water();
                lW.Size = Size.Large;
                drinks.Add(lW);
                return drinks;
            }
        }
    }
}
