using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <body></body>
    /// </summary>
    public class HtmlBody : HtmlContainerElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlBody"/> class.
        /// </summary>
        public HtmlBody()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlBody"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlBody(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlBody"/> class.
        /// </summary>
        /// <param name="styles">Styles configuration</param>
        public HtmlBody(InlineStyles styles)
            : base(styles)
        {
        }

        /// <inheritdoc />
        protected override string ElementTag => "body";
    }
}
