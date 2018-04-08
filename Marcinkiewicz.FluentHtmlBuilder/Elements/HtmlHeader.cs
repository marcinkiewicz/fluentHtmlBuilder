using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <h></h>
    /// Default indent value is 1 leading to <h1></h1>
    /// </summary>
    public class HtmlHeader : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlHeader"/> class.
        /// </summary>
        public HtmlHeader()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlHeader"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlHeader(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlHeader"/> class.
        /// </summary>
        /// <param name="styles">Inline styles</param>
        public HtmlHeader(InlineStyles styles)
            : base(styles)
        {
        }

        /// <summary>
        /// Gets or sets indent level
        /// </summary>
        public int Level { get; set; } = 1;

        /// <inheritdoc />
        protected override string ElementTag => $"h{this.Level}";
    }
}
