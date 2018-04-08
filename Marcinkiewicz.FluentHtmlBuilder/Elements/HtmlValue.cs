using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Text value placed between opening and closing tag of parent element.
    /// </summary>
    public class HtmlValue : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlValue"/> class.
        /// </summary>
        public HtmlValue()
        {
        }

        /// <summary>
        /// Gets or sets content text value
        /// </summary>
        public string Content { get; set; }

        /// <inheritdoc />
        protected override string ElementTag => string.Empty;

        /// <summary>
        /// Return content value as string.
        /// </summary>
        /// <returns>Content text</returns>
        public override string ToString()
        {
            return this.Content;
        }
    }
}
