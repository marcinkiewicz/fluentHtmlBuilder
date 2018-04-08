using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <span></span>
    /// </summary>
    public class HtmlSpan : HtmlContainerElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlSpan"/> class.
        /// </summary>
        public HtmlSpan()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlSpan"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlSpan(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlSpan"/> class.
        /// </summary>
        /// <param name="styles">Inline styles</param>
        public HtmlSpan(InlineStyles styles)
            : base(styles)
        {
        }

        /// <inheritdoc />
        protected override string ElementTag => $"span";
    }
}
