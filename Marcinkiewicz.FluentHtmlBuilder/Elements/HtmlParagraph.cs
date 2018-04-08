using System;
using Marcinkiewicz.FluentHtmlBuilder.Abstraction;

namespace Marcinkiewicz.FluentHtmlBuilder
{
    /// <summary>
    /// Element representing HTML <p></p>
    /// </summary>
    public class HtmlParagraph : HtmlElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlParagraph"/> class.
        /// </summary>
        public HtmlParagraph()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlParagraph"/> class.
        /// </summary>
        /// <param name="stylesCfg">Styles configuration</param>
        public HtmlParagraph(Action<InlineStyles> stylesCfg)
            : base(stylesCfg)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlParagraph"/> class.
        /// </summary>
        /// <param name="styles">Inline styles</param>
        public HtmlParagraph(InlineStyles styles)
            : base(styles)
        {
        }

        /// <inheritdoc />
        protected override string ElementTag => $"p";
    }
}
