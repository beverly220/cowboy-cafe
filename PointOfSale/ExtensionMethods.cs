using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace Extensions {
    public static class ExtensionMethods {

        /// <summary>
        /// Finds the first ancestor in the visual tree that has
        /// the specified type or null if no such ancestor is 
        /// found
        /// </summary>
        /// <typeparam name="T">type being searched for</typeparam>
        /// <param name="element">the dependency object</param>
        /// <returns>the first ancestor of type T or null</returns>
        public static T FindAncestor<T>(this DependencyObject element) where T : DependencyObject {
            var parent = VisualTreeHelper.GetParent(element);

            if(parent == null) {
                //if isn't working, replace "==" with "is"
                return null;
            }
            else if (parent is T) {
                return parent as T;
            }
            return FindAncestor<T>(parent);
        }
    }
}
