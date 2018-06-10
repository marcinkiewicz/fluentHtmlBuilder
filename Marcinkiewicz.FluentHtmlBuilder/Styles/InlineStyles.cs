using System;
using System.Collections.Generic;
using System.Text;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing styles property of the element
    /// </summary>
    public class InlineStyles
    {
        /// <summary>
        /// Gets style values
        /// </summary>
        protected Dictionary<string, string> Values { get; private set; } = new Dictionary<string, string>();

        /// <summary>
        /// Add new style
        /// </summary>
        /// <param name="name">Style name</param>
        /// <param name="value">Style value</param>
        public void AddStyle(string name, string value)
        {
            // Prevent adding the same style twice
            if (this.Values.ContainsKey(name))
            {
                throw new ArgumentException($"Style with {name} key already defined");
            }

            this.Values.Add(name, value);
        }

        /// <summary>
        /// Merge with another inline styles
        /// </summary>
        /// <param name="styles">Styles to be merged with</param>
        /// <param name="overrideWhenConflict">
        /// Value indicating whether single style should be overriden
        /// if another style is found in styles provided as parameter
        /// </param>
        public void MergeWith(InlineStyles styles, bool overrideWhenConflict)
        {
            if (styles == null)
            {
                throw new ArgumentException("Can't merge with empty styles");
            }

            foreach (var style in styles.Values)
            {
                if (this.Values.ContainsKey(style.Key))
                {
                    if (overrideWhenConflict)
                    {
                        // Override existing style
                        this.Values[style.Key] = style.Value;
                    }
                    // Otherwise leave current value
                }
                else
                {
                    this.Values.Add(style.Key, style.Value);
                }
            }
        }

        /// <summary>
        /// Return inline style representation with key name.
        /// </summary>
        /// <returns>Inline style as HTML text</returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder("style=\"");

            foreach (var styleValue in this.Values)
            {
                stringBuilder.Append($"{styleValue.Key}: {styleValue.Value}; ");
            }

            stringBuilder.Append("\"");
            return stringBuilder.ToString();
        }
    }
}
