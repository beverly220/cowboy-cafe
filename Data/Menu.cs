using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {
    public class Menu {
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
