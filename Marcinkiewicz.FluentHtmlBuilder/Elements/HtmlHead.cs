using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <head></head>
    /// </summary>
    public class HtmlHead : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlHead"/> class.
        /// </summary>
        public HtmlHead()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlHead"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlHead(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlHead"/> class.
        /// </summary>
        /// <param name="styles">Inline styles</param>
        public HtmlHead(InlineStyles styles)
            : base(styles)
        {
        }

        /// <inheritdoc />
        protected override string ElementTag => "head";
    }
}
