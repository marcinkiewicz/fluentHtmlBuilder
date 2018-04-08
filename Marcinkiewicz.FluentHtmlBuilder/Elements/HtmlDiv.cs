using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <div></div>
    /// </summary>
    public class HtmlDiv : HtmlContainerElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlDiv"/> class.
        /// </summary>
        public HtmlDiv()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlDiv"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlDiv(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlDiv"/> class.
        /// </summary>
        /// <param name="styles">Inline styles</param>
        public HtmlDiv(InlineStyles styles)
            : base(styles)
        {
        }

        /// <inheritdoc />
        protected override string ElementTag => $"div";
    }
}
